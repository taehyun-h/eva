public class StudyWorkRequest : Request
{
    protected override TResponse GetResponse<TResponse>()
    {
        var protocolUser = Server.Instance.GetProtocolUser();
        UpdateWordStudyCount(protocolUser);
        Server.Instance.SaveProtocolUser();

        var response = new StudyWorkResponse()
        {
            ProtocolUser = protocolUser
        };
        return response as TResponse;
    }

    private void UpdateWordStudyCount(ProtocolUser protocolUser)
    {
        var todayStudyWords = protocolUser.TodayStudyWords[protocolUser.TodayStudyDate];
        var id = todayStudyWords[protocolUser.TodayStudyWordsIndex];
        protocolUser.TodayStudyWordsIndex = (protocolUser.TodayStudyWordsIndex + 1) % todayStudyWords.Count;

        var data = protocolUser.WordStudyData[id];
        if (data.StudyCount >= StaticData.StudyPeriodDate.Length)
        {
            // TODO : Add word to test data
        }
        else
        {
            data.StudyCount++;

            var nextStudyDate = protocolUser.TodayStudyDate + StaticData.StudyPeriodDate[data.StudyCount - 1];
            protocolUser.AddStudyWord(nextStudyDate, data.Id);
        }
    }
}
