using System;
using UnityEngine;
using UnityEngine.UI;

public class StudyPanel : MonoBehaviour
{
    [SerializeField] private Text _word;
    [SerializeField] private Text[] _means;

    public void Show()
    {
        SetNextWord();
    }

    private void SetNextWord()
    {
        var wordId = User.Instance.TodayStudyWords[User.Instance.TodayStudyWordsIndex];
        SetWordData(StaticData.Instance.GetWorldData(wordId));

        // TODO : study word request
    }

    private void SetWordData(WordData wordData)
    {
        _word.text = wordData.Spelling;

        var i = 0;
        var length = Math.Min(wordData.Meanings.Length, _means.Length);
        for (i = 0; i < length; i++)
        {
            _means[i].gameObject.SetActive(true);
            _means[i].text = wordData.Meanings[i];
        }

        for (; i < _means.Length; i++)
        {
            _means[i].gameObject.SetActive(false);
        }
    }

    public void OnBackgroundButtonClick()
    {
        SetNextWord();
    }
}
