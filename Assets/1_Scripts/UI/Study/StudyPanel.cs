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
        var todayStudyWords = User.Instance.TodayStudyWords[User.Instance.TodayStudyDate];
        _index.text = $"{User.Instance.TodayStudyWordsIndex + 1} / {todayStudyWords.Count}";

        var id = todayStudyWords[User.Instance.TodayStudyWordsIndex];
        SetWordData(id);
    }

    private void SetWordData(int id)
    {
        var word = StaticData.Instance.GetWord(id);
        _word.text = word.Spelling;

        SetMeaning(0, word.Meaning);
        SetMeaning(1, word.Meaning2);
    }

    private void SetMeaning(int index, string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            _means[index].gameObject.SetActive(false);
        }
        else
        {
            _means[index].gameObject.SetActive(true);
            _means[index].text = text;
        }
    }

    public void OnBackgroundButtonClick()
    {
        RequestSender.Instance.Send<StudyWordRequest>()
            .SetOnCompleteAction(SetNextWord);
    }
}
