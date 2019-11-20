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

    public void OnUpdate(Service.Test.IKnowResponse response)
    {
        TodayTestingWordsIndex = response.NewIndex;
    }

    public void OnUpdate(Service.Test.IDontKnowResponse response)
    {
        TodayTestingWordsIndex = response.NewIndex;
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
}
