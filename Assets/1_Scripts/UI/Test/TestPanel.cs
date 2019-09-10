using System;
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
    }

    private void SetWordIndex()
    {
        var todayTestWords = User.Instance.TodayTestWords[User.Instance.TodayStudyDate];
        _index.text = $"{User.Instance.TodayTestWordsIndex + 1} / {todayTestWords.Count}";
    }

    private void SetWordData()
    {
        var todayTestWords = User.Instance.TodayTestWords[User.Instance.TodayStudyDate];
        var id = todayTestWords[User.Instance.TodayStudyWordsIndex];
        var wordData = StaticData.Instance.GetWorldData(id);
        _word.text = wordData.Spelling;

        var i = 0;
        var length = Math.Min(wordData.Meanings.Length, _meaningTexts.Length);
        for (i = 0; i < length; i++)
        {
            _meaningTexts[i].gameObject.SetActive(true);
            _meaningTexts[i].text = wordData.Meanings[i];
        }

        for (; i < _meaningTexts.Length; i++)
        {
            _meaningTexts[i].gameObject.SetActive(false);
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
