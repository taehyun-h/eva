using System.Collections.Generic;

public partial class User
{
    #region Response

    public void OnUpdate(SignInResponse response)
    {
        OnUpdate(response.ProtocolUser);
    }

    #endregion

    private void OnUpdate(ProtocolUser protocolUser)
    {
        TodayStudyDate = protocolUser.TodayStudyDate;
        TodayStudyWordsIndex = protocolUser.TodayStudyWordsIndex;
        TodayStudyWords = new List<int>(protocolUser.TodayStudyWords);
        WordStudyData = new Dictionary<int, UserWordStudyData>();
        foreach (var (id, data) in protocolUser.WordStudyData)
        {
            WordStudyData[id] = new UserWordStudyData(data);
        }
    }
}
