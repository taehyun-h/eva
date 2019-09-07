using System.Collections.Generic;
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

        LoadWordData();
        ShowTitlePanel();
    }

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

    #region Word Data

    private const string WordDataJsonPath = "WordData";

    private List<WordData> _wordData;

    private void LoadWordData()
    {
        var text = Resources.Load<TextAsset>(WordDataJsonPath).text;
        _wordData = JsonUtil.DeserializeObject<List<WordData>>(text);
    }

    public int GetWordDataCount()
    {
        return _wordData.Count;
    }

    public WordData GetWordData(int index)
    {
        return _wordData[index];
    }

    #endregion

    #region Unity Button

    public void OnHomeButtonClick()
    {
        ShowTitlePanel();
    }

    #endregion
}
