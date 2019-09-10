public class TestWordIKnowRequest : Request
{
    public override string Url { get; } = "test_word_i_know";

    public override void Complete(string content)
    {
        ResponseUpdater.Instance.OnUpdate(new SignInResponse
        {
            ProtocolUser = JsonUtil.DeserializeObject<ProtocolUser>(content)
        });

        base.Complete(content);
    }
}
