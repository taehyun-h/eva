using System;
using UnityEngine;
using UnityEngine.UI;

public class StudyPanel : MonoBehaviour
{
    [SerializeField] private Text _word;
    [SerializeField] private Text[] _means;

    private int _wordDataIndex;

    public void Show()
    {
        _wordDataIndex = 0;

        SetNextWord();
    }

    private void SetNextWord()
    {
        SetWordData(SceneManager.Instance.GetWordData(_wordDataIndex));

        _wordDataIndex = (_wordDataIndex + 1) % SceneManager.Instance.GetWordDataCount();
    }

    private void SetWordData(WordData wordData)
    {
        _word.text = wordData.Word;

        var i = 0;
        var length = Math.Min(wordData.Means.Length, _means.Length);
        for (i = 0; i < length; i++)
        {
            _means[i].gameObject.SetActive(true);
            _means[i].text = wordData.Means[i];
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
