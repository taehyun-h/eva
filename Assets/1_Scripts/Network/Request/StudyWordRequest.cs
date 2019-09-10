public class StudyWordRequest : Request
{
    public override string Url { get; } = "study_word";

    public override void Complete(string content)
    {
        ResponseUpdater.Instance.OnUpdate(new SignInResponse
        {
            ProtocolUser = JsonUtil.DeserializeObject<ProtocolUser>(content)
        });

        base.Complete(content);
    }
}
