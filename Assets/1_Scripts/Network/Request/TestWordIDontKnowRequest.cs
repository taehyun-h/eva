public class TestWordIDontKnowRequest : Request
{
    public override string Url { get; } = "test_word_i_dont_know";

    public override void Complete(string content)
    {
        ResponseUpdater.Instance.OnUpdate(new TestWordIDontKnowResponse
        {
            ProtocolUser = JsonUtil.DeserializeObject<ProtocolUser>(content)
        });

        base.Complete(content);
    }
}
