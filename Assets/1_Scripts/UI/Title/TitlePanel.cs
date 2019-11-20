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
        var words = User.Instance.TodayStudyingWordIds;
        _study.color = words == null || words.Count == 0 ? Color.white : Color.yellow;
    }

    private void UpdateTestButton()
    {
        var words = User.Instance.TodayTestingWordIds;
        _test.color = words == null || words.Count == 0 ? Color.white : Color.yellow;
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
