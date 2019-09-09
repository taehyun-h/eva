public class TestWordIDontKnowRequest : Request
{
    protected override TResponse GetResponse<TResponse>()
    {
        var protocolUser = Server.Instance.GetProtocolUser();
        UpdateTestWord(protocolUser);
        UpdateTodayTestWord(protocolUser);
        Server.Instance.SaveProtocolUser();

        var response = new TestWordIDontKnowResponse()
        {
            ProtocolUser = protocolUser
        };
        return response as TResponse;
    }

    private void UpdateTestWord(ProtocolUser protocolUser)
    {
        if (!protocolUser.TodayTestWords.TryGetValue(protocolUser.TodayStudyDate, out var todayTestWords)) return;

        var id = todayTestWords[protocolUser.TodayTestWordsIndex];
        if (!protocolUser.WordTestData.TryGetValue(id, out var data)) return;

        data.LastPassedDate = protocolUser.TodayStudyDate;

        var nextTestData = protocolUser.TodayStudyDate + StaticData.TestPeriodDate[data.TestPassCount];
        protocolUser.AddTestWord(nextTestData, data.Id);
    }

    private void UpdateTodayTestWord(ProtocolUser protocolUser)
    {
        if (!protocolUser.TodayTestWords.TryGetValue(protocolUser.TodayStudyDate, out var todayTestWords)) return;

        protocolUser.TodayTestWordsIndex++;
        if (protocolUser.TodayTestWordsIndex >= todayTestWords.Count)
        {
            protocolUser.TodayTestWordsIndex = 0;
            protocolUser.TodayTestWords.Remove(protocolUser.TodayStudyDate);
        }
        else
        {
            protocolUser.TodayTestWordsIndex %= protocolUser.TodayStudyDate;
        }
    }
}
