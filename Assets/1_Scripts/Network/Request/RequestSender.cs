public class RequestSender : Singleton<RequestSender>
{
    public Request SignIn()
    {
        var request = new SignInRequest();
        return request.Send<SignInResponse>();
    }
}
