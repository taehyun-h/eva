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
            default:
            {
                D.Error("Unimplemented response");
                break;
            }
        }
    }
}
