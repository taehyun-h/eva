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
        if (!protocolUser.TodayStudyWords.TryGetValue(protocolUser.TodayStudyDate, out var todayStudyWords)) return;

        protocolUser.TodayStudyWordsIndex = (protocolUser.TodayStudyWordsIndex + 1) % todayStudyWords.Count;
    }
}
