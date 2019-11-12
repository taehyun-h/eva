using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestPanel : MonoBehaviour
{
    [SerializeField] private GameObject _done;
    [SerializeField] private GameObject _test;

    [SerializeField] private Text _word;
    [SerializeField] private Text[] _meaningTexts;
    [SerializeField] private Text _index;

    [SerializeField] private GameObject _meanings;
    [SerializeField] private GameObject _showMeaningsButton;
    [SerializeField] private GameObject _iKnowButton;
    [SerializeField] private GameObject _iDontKnowButton;

    private List<int> TodayTestWords => User.Instance.TodayTestWords.TryGetValueOrDefaultValue(User.Instance.TodayStudyDate);

    public void Show()
    {
        SetNextWord();
    }

    private void SetNextWord()
    {
        if (TodayTestWords == null)
        {
            _done.SetActive(true);
            _test.SetActive(false);
        }
        else
        {
            SetTest();
        }
    }

    private void SetTest()
    {
        _done.SetActive(false);
        _test.SetActive(true);

        SetWordIndex();
        SetWordData();

        _meanings.SetActive(false);
        _showMeaningsButton.SetActive(true);
        _iKnowButton.SetActive(false);
        _iDontKnowButton.SetActive(false);
    }

    private void SetWordIndex()
    {
        var todayTestWords = User.Instance.TodayTestWords[User.Instance.TodayStudyDate];
        _index.text = $"{User.Instance.TodayTestWordsIndex + 1} / {todayTestWords.Count}";
    }

    private void SetWordData()
    {
        var todayTestWords = User.Instance.TodayTestWords[User.Instance.TodayStudyDate];
        var id = todayTestWords[User.Instance.TodayTestWordsIndex];
        var word = StaticData.Instance.GetWord(id);
        _word.text = word.Spelling;

        SetMeaning(0, word.Meaning);
        SetMeaning(1, word.Meaning2);
    }

    private void SetMeaning(int index, string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            _meaningTexts[index].gameObject.SetActive(false);
        }
        else
        {
            _meaningTexts[index].gameObject.SetActive(true);
            _meaningTexts[index].text = text;
        }
    }

    public void OnShowMeaningsButtonClick()
    {
        _meanings.SetActive(true);

        _showMeaningsButton.SetActive(false);
        _iKnowButton.SetActive(true);
        _iDontKnowButton.SetActive(true);
    }

    public void OnIKnowButtonClick()
    {
        RequestSender.Instance.Send<TestWordIKnowRequest>()
            .SetOnCompleteAction(SetNextWord);
    }

    public void OnIDontKnowButtonClick()
    {
        RequestSender.Instance.Send<TestWordIDontKnowRequest>()
            .SetOnCompleteAction(SetNextWord);
    }
}
