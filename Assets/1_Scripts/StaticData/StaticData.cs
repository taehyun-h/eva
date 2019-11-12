using System.Collections.Generic;
using System.Linq;
using Data.Word;
using UnityEngine;

public class StaticData : Singleton<StaticData>
{
    public StaticData()
    {
        LoadWord();
    }

    public void Load(string wordDataText)
    {
        LoadWordData(wordDataText);
    }

    #region Word

    private const string WordDataPath = "Data/WordData";
    private readonly Word _defaultWord = new Word
    {
        Id = -1,
        Spelling = "Not Found"
    };

    private Words _words;

    public Word GetWord(int id)
    {
        return _words.Words_.ContainsKey(id) ? _words.Words_[id] : _defaultWord;
    }

    private void LoadWord()
    {
        var wordData = Resources.Load<TextAsset>(WordDataPath);
        if (wordData == null)
        {
            _words = new Words();
            return;
        }

        _words = Words.Parser.ParseFrom(wordData.bytes);
    }

    #endregion

    #region WordData

    private readonly Dictionary<int, WordData> _wordData = new Dictionary<int, WordData>();

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
