using System.Collections;
using Grpc.Core;
using UnityEngine.Networking;

public class RequestSender : SingletonMonoBehaviour<RequestSender>
{
    private const string ServerUrl = "127.0.0.1:50051";

    private Channel _channel;

    protected override void Init()
    {
        _channel = new Channel(ServerUrl, ChannelCredentials.Insecure);
    }

    public Service.Sign.SignInResponse SignIn(string userId)
    {
        var client = new Service.Sign.Sign.SignClient(_channel);
        var request = new Service.Sign.SignInRequest
        {
            UserId = userId,
        };
        return client.SignIn(request);
    }

    public TRequest Send<TRequest>()
        where TRequest : Request, new()
    {
        InputBlocker.Instance.BlockInput();

        var request = new TRequest();
        StartCoroutine(SendRequest(request));
        return request;
    }

    private IEnumerator SendRequest(Request request)
    {
        yield return 0;

        var www = UnityWebRequest.Get($"{ServerUrl}/{request.Url}");
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            D.ErrorPack("Request fail", www.error);
            request.Fail();
        }
        else
        {
            D.LogPack("Request success", www.downloadHandler.text);

            var content = GetContent(www.downloadHandler.text);
            D.LogPack("Response Content", content);

            request.Complete(content);
        }

        InputBlocker.Instance.UnblockInput();
    }

    private string GetContent(string response)
    {
        if (string.IsNullOrEmpty(response)) return response;
        if (!response.StartsWith("HTTP")) return response;

        return StringUtil.RemoveCharacterWithCount((string) response.Clone(), '\n', 4);
    }
}
