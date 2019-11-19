using Grpc.Core;

public class NewRequestSender : SingletonMonoBehaviour<NewRequestSender>
{
    private const string ServerUrl = "127.0.0.1:50051";

    private Channel _channel;

    protected override void Init()
    {
        _channel = new Channel(ServerUrl, ChannelCredentials.Insecure);
    }

    public void SignIn(string userId)
    {
        InputBlocker.Instance.BlockInput();

        var client = new Service.Sign.Sign.SignClient(_channel);
        var request = new Service.Sign.SignInRequest
        {
            UserId = userId,
        };

        var response = client.SignIn(request);
        NewResponseUpdater.Instance.OnUpdate(response);

        InputBlocker.Instance.UnblockInput();
    }

    public void MoveToPreviousWord()
    {
        InputBlocker.Instance.BlockInput();

        var client = new Service.Study.Study.StudyClient(_channel);
        var request = new Service.Study.MoveToPreviousWordRequest
        {
            UserId = User.Instance.Id,
        };

        var response = client.MoveToPreviousWord(request);
        NewResponseUpdater.Instance.OnUpdate(response);

        InputBlocker.Instance.UnblockInput();
    }

    public void MoveToNextWord()
    {
        InputBlocker.Instance.BlockInput();

        var client = new Service.Study.Study.StudyClient(_channel);
        var request = new Service.Study.MoveToNextWordRequest
        {
            UserId = User.Instance.Id,
        };

        var response = client.MoveToNextWord(request);
        NewResponseUpdater.Instance.OnUpdate(response);

        InputBlocker.Instance.UnblockInput();
    }
}
