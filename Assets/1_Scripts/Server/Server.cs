using UnityEngine;

public class Server : Singleton<Server>
{
    public const string ProtocolUserPath = "ServerData/ProtocolUser";

    private ProtocolUser _protocolUser;

    public ProtocolUser GetProtocolUser()
    {
        if (_protocolUser == null)
        {
            var text = Resources.Load<TextAsset>(ProtocolUserPath).text;
            _protocolUser = JsonUtil.DeserializeObject<ProtocolUser>(text);
        }

        return _protocolUser;
    }

    public void SaveProtocolUser()
    {
        var text = JsonUtil.SerializeObjectWithIndentation(_protocolUser);
        FileUtil.WriteText($"Assets/Resources/{ProtocolUserPath}.json", text);
    }
}
