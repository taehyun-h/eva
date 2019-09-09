public class ResponseUpdater : Singleton<ResponseUpdater>
{
    public void OnUpdate(Response response)
    {
        switch (response)
        {
            case SignInResponse signInResponse:
            {
                User.Instance.OnUpdate(signInResponse);
                break;
            }
            case StudyWordResponse studyWordResponse:
            {
                User.Instance.OnUpdate(studyWordResponse);
                break;
            }
            case TestWordIKnowResponse testWordIKnowResponse:
            {
                User.Instance.OnUpdate(testWordIKnowResponse);
                break;
            }
            case TestWordIDontKnowResponse testWordIDontKnowResponse:
            {
                User.Instance.OnUpdate(testWordIDontKnowResponse);
                break;
            }
            default:
            {
                D.Error("Unimplemented response");
                break;
            }
        }
    }
}
