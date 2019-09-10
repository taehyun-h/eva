public class SignInRequest : Request
{
    public override string Url { get; } = "sign_in";

    public override void Complete(string content)
    {
        ResponseUpdater.Instance.OnUpdate(new SignInResponse
        {
            ProtocolUser = JsonUtil.DeserializeObject<ProtocolUser>(content)
        });

        base.Complete(content);
    }
}
