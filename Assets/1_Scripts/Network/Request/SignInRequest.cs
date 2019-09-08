using System;
using UnityEngine;

public class SignInRequest : Request
{
    protected override TResponse GetResponse<TResponse>()
    {
        var protocolUser = GetProtocolUser();
        UpdateProtocolUser(protocolUser);

        var response = new SignInResponse
        {
            ProtocolUser = protocolUser
        };
        return response as TResponse;
    }

    private ProtocolUser GetProtocolUser()
    {
        var text = Resources.Load<TextAsset>("ServerData/ProtocolUser").text;
        return JsonUtil.DeserializeObject<ProtocolUser>(text);
    }

    private void UpdateProtocolUser(ProtocolUser protocolUser)
    {
        var now = DateTime.Now;
        var isFirstLoginToday = now.Year != protocolUser.LastSignInTime.Year || now.DayOfYear != protocolUser.LastSignInTime.DayOfYear;
        protocolUser.LastSignInTime = now;

        if (!isFirstLoginToday) return;

        protocolUser.TodayStudyDate++;
        protocolUser.TodayStudyWordsIndex = 0;
        if (StaticData.Instance.ShouldStudyNewWord(protocolUser.TodayStudyDate))
        {
            AddNewStudyWords(protocolUser);
        }
    }

    private void AddNewStudyWords(ProtocolUser protocolUser)
    {
        for (var i = 0; i < StaticData.NewStudyWordCount; i++)
        {
            var id = protocolUser.LastStudiedWordId + 1;
            var wordData = StaticData.Instance.GetWorldData(id);
            if (wordData == null) break;

            protocolUser.LastStudiedWordId++;
            protocolUser.WordStudyData[id] = new ProtocolUserWordStudyData
            {
                Id = id,
                StudyCount = 0,
            };
            protocolUser.TodayStudyWords.Add(id);
        }
    }
}
