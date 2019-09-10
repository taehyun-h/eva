public class GetWordDataRequest : Request
{
    public override string Url { get; } = "get_word_data";

    public override void Complete(string content)
    {
        ResponseUpdater.Instance.OnUpdate(new GetWordDataResponse
        {
            WordDataText = content
        });

        base.Complete(content);
    }
}
