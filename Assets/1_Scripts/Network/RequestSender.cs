using System.Collections;
using UnityEngine.Networking;

public class RequestSender : SingletonMonoBehaviour<RequestSender>
{
    private const string ServerUrl = "http://127.0.0.1:80";

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
            request.Complete(www.downloadHandler.text);
        }

        InputBlocker.Instance.UnblockInput();
    }
}
