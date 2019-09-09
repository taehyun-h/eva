using System;

public class SignInRequest : Request
{
    protected override TResponse GetResponse<TResponse>()
    {
        var response = new SignInResponse
        {
            ProtocolUser = GetProtocolUser()
        };
        return response as TResponse;
    }

    private ProtocolUser GetProtocolUser()
    {
        var protocolUser = Server.Instance.GetProtocolUser();
        UpdateSignIn(protocolUser);
        Server.Instance.SaveProtocolUser();

        return protocolUser;
    }

    private void UpdateSignIn(ProtocolUser protocolUser)
    {
        var now = DateTime.Now;
        var isFirstLoginToday = now.Year != protocolUser.LastSignInTime.Year || now.DayOfYear != protocolUser.LastSignInTime.DayOfYear;
        protocolUser.LastSignInTime = now;

        if (isFirstLoginToday)
        {
            UpdateTodayWords(protocolUser);
        }
    }

    private void UpdateTodayWords(ProtocolUser protocolUser)
    {
        protocolUser.TodayStudyDate++;
        protocolUser.TodayStudyWordsIndex = 0;
        if (StaticData.Instance.ShouldStudyNewWord(protocolUser.TodayStudyDate))
        {
            AddNewStudyWords(protocolUser);
        }

        UpdateTodayWordStudyCount(protocolUser);
    }

    private void AddNewStudyWords(ProtocolUser protocolUser)
    {
        for (var i = 0; i < StaticData.NewStudyWordCount; i++)
        {
            var id = protocolUser.LastStudiedWordId + 1;
            var wordData = StaticData.Instance.GetWorldData(id);
            if (wordData == null) break;

            protocolUser.LastStudiedWordId++;
            protocolUser.WordStudyData[id] = new ProtocolUserWordStudyData
            {
                Id = id,
                StudyCount = 0,
            };
            protocolUser.AddStudyWord(protocolUser.TodayStudyDate, id);
        }
    }

    private void UpdateTodayWordStudyCount(ProtocolUser protocolUser)
    {
        var todayStudyWords = protocolUser.TodayStudyWords[protocolUser.TodayStudyDate];
        foreach (var id in todayStudyWords)
        {
            var data = protocolUser.WordStudyData[id];
            if (data.StudyCount >= StaticData.StudyPeriodDate.Length)
            {
                AddTestWordToNextPeriod(protocolUser, data);
            }
            else
            {
                AddStudyWordToNextPeriod(protocolUser, data);
            }
        }
    }

    private void AddTestWordToNextPeriod(ProtocolUser protocolUser, ProtocolUserWordStudyData data)
    {
        var testData = new ProtocolUserWordTestData
        {
            Id = data.Id,
            LastPassedDate = protocolUser.TodayStudyDate,
            TestPassCount = 0
        };
        var nextStudyDate = protocolUser.TodayStudyDate + StaticData.TestPeriodDate[testData.TestPassCount];
        protocolUser.AddTestWord(nextStudyDate, testData.Id);
    }

    private void AddStudyWordToNextPeriod(ProtocolUser protocolUser, ProtocolUserWordStudyData data)
    {
        data.StudyCount++;

        var nextStudyDate = protocolUser.TodayStudyDate + StaticData.StudyPeriodDate[data.StudyCount - 1];
        protocolUser.AddStudyWord(nextStudyDate, data.Id);
    }
}
