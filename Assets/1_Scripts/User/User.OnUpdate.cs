using System.Collections.Generic;

public partial class User
{
    #region Response

    public void OnUpdate(SignInResponse response)
    {
        OnUpdate(response.ProtocolUser);
    }

    public void OnUpdate(StudyWordResponse response)
    {
        OnUpdate(response.ProtocolUser);
    }

    #endregion

    private void OnUpdate(ProtocolUser protocolUser)
    {
        TodayStudyDate = protocolUser.TodayStudyDate;
        WordStudyData = new Dictionary<int, UserWordStudyData>();
        foreach (var (id, data) in protocolUser.WordStudyData)
        {
            WordStudyData[id] = new UserWordStudyData(data);
        }
        WordTestData = new Dictionary<int, UserWordTestData>();
        foreach (var (id, data) in protocolUser.WordTestData)
        {
            WordTestData[id] = new UserWordTestData(data);
        }

        TodayStudyWordsIndex = protocolUser.TodayStudyWordsIndex;
        TodayStudyWords = new Dictionary<int, List<int>>(protocolUser.TodayStudyWords);

        TodayTestWordsIndex = protocolUser.TodayTestWordsIndex;
        TodayTestWords = new Dictionary<int, List<int>>(protocolUser.TodayTestWords);
    }
}
