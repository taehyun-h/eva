using System.Collections.Generic;
using UnityEngine;

public class StaticData : Singleton<StaticData>
{
    public const int NewStudyWordCount = 30;
    public static readonly int[] StudyPeriodDate = {2, 3, 5};
    public static readonly int[] TestPeriodDate = {5, 10, 20};

    public void Load()
    {
        LoadWordData();
    }

    public bool ShouldStudyNewWord(int date)
    {
        return date % 3 == 1 || date % 3 == 2;
    }

    #region WordData

    private const string WordDataJsonPath = "StaticData/WordData";

    private readonly Dictionary<int, WordData> _wordData = new Dictionary<int, WordData>();

    public WordData GetWorldData(int id)
    {
        return _wordData.TryGetValue(id, out var wordData) ? wordData : null;
    }

    private void LoadWordData()
    {
        var text = Resources.Load<TextAsset>(WordDataJsonPath).text;
        var wordData = JsonUtil.DeserializeObject<List<WordData>>(text);
        foreach (var word in wordData)
        {
            _wordData[word.Id] = word;
        }
    }

    #endregion
}
