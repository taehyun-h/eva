using System;
using UnityEngine;
using UnityEngine.UI;

public class StudyPanel : MonoBehaviour
{
    [SerializeField] private Text _word;
    [SerializeField] private Text[] _means;
    [SerializeField] private Text _index;

    public void Show()
    {
        SetNextWord();
    }

    private void SetNextWord()
    {
        _index.text = $"{User.Instance.TodayStudyWordsIndex + 1} / {User.Instance.TodayStudyWords.Count}";
        SetWordData(User.Instance.TodayStudyWords[User.Instance.TodayStudyDate][User.Instance.TodayStudyWordsIndex]);

        // TODO : study word request
    }

    private void SetWordData(int id)
    {
        var wordData = StaticData.Instance.GetWorldData(id);
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
