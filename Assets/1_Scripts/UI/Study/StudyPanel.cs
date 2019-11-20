using UnityEngine;
using UnityEngine.UI;

public class StudyPanel : MonoBehaviour
{
    [SerializeField] private Text _word;
    [SerializeField] private Text[] _means;
    [SerializeField] private Text _index;

    public void Show()
    {
        UpdateWord();
    }

    private void UpdateWord()
    {
        _index.text = $"{User.Instance.TodayStudyingWordsIndex + 1} / {User.Instance.TodayStudyingWordIds.Count}";

        var id = User.Instance.TodayStudyingWordIds[User.Instance.TodayStudyingWordsIndex];
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

    public void OnPreviousButtonClick()
    {
        RequestSender.Instance.MoveToPreviousWord();
        UpdateWord();
    }

    public void OnNextButtonClick()
    {
        RequestSender.Instance.MoveToNextWord();
        UpdateWord();
    }
}
