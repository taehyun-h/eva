using UnityEngine;
using UnityEngine.UI;

public class TitlePanel : MonoBehaviour
{
    [SerializeField] private Text _day;

    public void Show()
    {
        _day.text = $"Day {User.Instance.TodayStudyDate}";
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
