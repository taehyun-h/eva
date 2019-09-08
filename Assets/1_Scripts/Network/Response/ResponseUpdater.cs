public class ResponseUpdater : Singleton<ResponseUpdater>
{
    public void OnUpdate(Response response)
    {
        switch (response)
        {
            case SignInResponse signInResponse:
            {
                // TODO
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
