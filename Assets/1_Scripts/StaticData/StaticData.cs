using System.Collections.Generic;
using System.Linq;

public class StaticData : Singleton<StaticData>
{
    public void Load(string wordDataText)
    {
        LoadWordData(wordDataText);
    }

    #region WordData

    private readonly Dictionary<int, WordData> _wordData = new Dictionary<int, WordData>();

    public WordData GetWorldData(int id)
    {
        return _wordData.TryGetValue(id, out var wordData) ? wordData : null;
    }

    private void LoadWordData(string wordDataText)
    {
        var allWordData = wordDataText.Split('\n');
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
