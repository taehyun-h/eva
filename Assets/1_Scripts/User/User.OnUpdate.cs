using System.Collections.Generic;

public partial class User
{
    public void OnUpdate(Service.Sign.SignInResponse response)
    {
        OnUpdate(response.User);
    }

    public void OnUpdate(Service.Study.MoveToPreviousWordResponse response)
    {
        TodayStudyingWordsIndex = response.NewIndex;
    }

    public void OnUpdate(Service.Study.MoveToNextWordResponse response)
    {
        TodayStudyingWordsIndex = response.NewIndex;
    }

    private void OnUpdate(Service.Entities.User pbObject)
    {
        Id = pbObject.Id;
        TodayStudyDate = pbObject.TodayStudyDate;

        TodayStudyingWordsIndex = pbObject.TodayStudyingWordsIndex;
        TodayStudyingWordIds.Clear();
        foreach (var id in pbObject.TodayStudyingWordIds)
        {
            TodayStudyingWordIds.Add(id);
        }

        TodayTestingWordsIndex = pbObject.TodayTestingWordsIndex;
        TodayTestingWordIds.Clear();
        foreach (var id in pbObject.TodayTestingWordIds)
        {
            TodayTestingWordIds.Add(id);
        }
    }

    #region Response

    public void OnUpdate(SignInResponse response)
    {
        OnUpdate(response.ProtocolUser);
    }

    public void OnUpdate(StudyWordResponse response)
    {
        OnUpdate(response.ProtocolUser);
    }

    public void OnUpdate(TestWordIKnowResponse response)
    {
        OnUpdate(response.ProtocolUser);
    }

    public void OnUpdate(TestWordIDontKnowResponse response)
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
