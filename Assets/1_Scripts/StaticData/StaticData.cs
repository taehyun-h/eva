using System.Collections.Generic;
using System.Linq;
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

    private const string WordDataPath = "StaticData/WordData";

    private readonly Dictionary<int, WordData> _wordData = new Dictionary<int, WordData>();

    public WordData GetWorldData(int id)
    {
        return _wordData.TryGetValue(id, out var wordData) ? wordData : null;
    }

    private void LoadWordData()
    {
        var text = Resources.Load<TextAsset>(WordDataPath).text;
        var allWordData = text.Split('\n');
        for (var id = 1; id <= allWordData.Length; id++)
        {
            var wordData = allWordData[id - 1].Split(':');
            if (wordData.Length == 0) continue;

            for (var i = 0; i < wordData.Length; i++)
            {
                wordData[i] = wordData[i].Trim();
            }

            _wordData[id] = new WordData
            {
                Id = id,
                Spelling = wordData[0],
                Meanings = wordData.Length == 1 ? new string[] { } : wordData.Skip(1).ToArray(),
            };
        }
    }

    #endregion
}
