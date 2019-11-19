public class NewResponseUpdater : Singleton<NewResponseUpdater>
{
    public void OnUpdate(Service.Sign.SignInResponse response)
    {
        User.Instance.OnUpdate(response);
    }

    public void OnUpdate(Service.Study.MoveToPreviousWordResponse response)
    {
        User.Instance.OnUpdate(response);
    }

    public void OnUpdate(Service.Study.MoveToNextWordResponse response)
    {
        User.Instance.OnUpdate(response);
    }
}
