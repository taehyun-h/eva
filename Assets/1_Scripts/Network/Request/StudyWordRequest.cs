public class StudyWorkRequest : Request
{
    protected override TResponse GetResponse<TResponse>()
    {
        var protocolUser = Server.Instance.GetProtocolUser();
        UpdateTodayStudyWordsIndex(protocolUser);
        Server.Instance.SaveProtocolUser();

        var response = new StudyWorkResponse()
        {
            ProtocolUser = protocolUser
        };
        return response as TResponse;
    }

    private void UpdateTodayStudyWordsIndex(ProtocolUser protocolUser)
    {
        var todayStudyWords = protocolUser.TodayStudyWords[protocolUser.TodayStudyDate];
        protocolUser.TodayStudyWordsIndex = (protocolUser.TodayStudyWordsIndex + 1) % todayStudyWords.Count;
    }
}
