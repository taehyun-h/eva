using UnityEngine;
using UnityEngine.UI;

public class TitlePanel : MonoBehaviour
{
    [SerializeField] private Text _day;
    [SerializeField] private Text _study;
    [SerializeField] private Text _test;

    public void Show()
    {
        _day.text = $"Day {User.Instance.TodayStudyDate}";

        UpdateStudyButton();
        UpdateTestButton();
    }

    private void UpdateStudyButton()
    {
        var todayStudyWords = User.Instance.TodayStudyWords.TryGetValueOrDefaultValue(User.Instance.TodayStudyDate);
        _study.color = todayStudyWords == null || todayStudyWords.Count == 0 ? Color.white : Color.yellow;
    }

    private void UpdateTestButton()
    {
        var todayTestWords = User.Instance.TodayTestWords.TryGetValueOrDefaultValue(User.Instance.TodayStudyDate);
        _test.color = todayTestWords == null || todayTestWords.Count == 0 ? Color.white : Color.yellow;
    }

    public void OnStudyButtonClick()
    {
        SceneManager.Instance.ShowStudyPanel();
    }

    public void OnTestButtonClick()
    {
        SceneManager.Instance.ShowTestPanel();
    }
}
