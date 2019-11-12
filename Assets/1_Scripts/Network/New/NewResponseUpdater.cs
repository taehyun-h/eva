public class NewResponseUpdater : Singleton<NewResponseUpdater>
{
    public void OnUpdate(Service.Sign.SignInResponse response)
    {
        User.Instance.OnUpdate(response);
    }
}
