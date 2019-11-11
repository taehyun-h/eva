using UnityEngine;

public class SceneManager : SingletonMonoBehaviour<SceneManager>
{
    [SerializeField] private TitlePanel _titlePanel;
    [SerializeField] private StudyPanel _studyPanel;
    [SerializeField] private TestPanel _testPanel;

    private GameObject _activePanel;

    protected override void Init()
    {
        base.Init();

//        RequestSender.Instance.Send<GetWordDataRequest>()
//            .SetOnCompleteAction(InitUser);
    }

    private void InitUser()
    {
//        RequestSender.Instance.Send<SignInRequest>()
//            .SetOnCompleteAction(ShowTitlePanel);
    }

    #region UI

    public void ShowTitlePanel()
    {
        SetActivePanel(_titlePanel.gameObject);
        _titlePanel.Show();
    }

    public void ShowStudyPanel()
    {
        SetActivePanel(_studyPanel.gameObject);
        _studyPanel.Show();
    }

    public void ShowTestPanel()
    {
        SetActivePanel(_testPanel.gameObject);
        _testPanel.Show();
    }

    private void SetActivePanel(GameObject panel)
    {
        if (_activePanel != null)
        {
            _activePanel.SetActive(false);
        }

        _activePanel = panel;
        _activePanel.SetActive(true);
    }

    #endregion

    #region Unity Button

    public void OnHomeButtonClick()
    {
        ShowTitlePanel();
    }

    #endregion
}
