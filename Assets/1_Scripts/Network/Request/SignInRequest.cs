using System;

public class SignInRequest : Request
{
    protected override TResponse GetResponse<TResponse>()
    {
        var protocolUser = Server.Instance.GetProtocolUser();
        UpdateSignIn(protocolUser);
        Server.Instance.SaveProtocolUser();

        var response = new SignInResponse
        {
            ProtocolUser = protocolUser
        };
        return response as TResponse;
    }

    private void UpdateSignIn(ProtocolUser protocolUser)
    {
        var now = DateTime.Now;
        var isFirstLoginToday = now.Year != protocolUser.LastSignInTime.Year || now.DayOfYear != protocolUser.LastSignInTime.DayOfYear;
        protocolUser.LastSignInTime = now;

        if (!isFirstLoginToday) return;

        protocolUser.TodayStudyDate++;
        protocolUser.TodayStudyWordsIndex = 0;
        if (StaticData.Instance.ShouldStudyNewWord(protocolUser.TodayStudyDate))
        {
            AddNewStudyWords(protocolUser);
        }
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
}
