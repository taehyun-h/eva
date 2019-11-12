using Data.Word;
using UnityEngine;

public class StaticData : Singleton<StaticData>
{
    public StaticData()
    {
        LoadWord();
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
}
