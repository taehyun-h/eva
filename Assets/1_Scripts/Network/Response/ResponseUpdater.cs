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
            case StudyWorkResponse studyWorkResponse:
            {
                User.Instance.OnUpdate(studyWorkResponse);
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
