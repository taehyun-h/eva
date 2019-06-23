using UnityEngine;

public class TitlePanel : MonoBehaviour
{
    public void Show()
    {
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
