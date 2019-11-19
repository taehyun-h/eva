using System.Collections.Generic;

public partial class User : Singleton<User>
{
    public Dictionary<int, UserWordStudyData> WordStudyData { get; private set; }
    public Dictionary<int, UserWordTestData> WordTestData { get; private set; }

    public int TodayStudyWordsIndex { get; private set; }
    public Dictionary<int, List<int>> TodayStudyWords { get; private set; }

    public int TodayTestWordsIndex { get; private set; }
    public Dictionary<int, List<int>> TodayTestWords { get; private set; }

    #region Grpc

    public string Id { get; private set; }
    public int TodayStudyDate { get; private set; }

    public int TodayStudyingWordsIndex { get; private set; }
    public List<int> TodayStudyingWordIds { get; private set; } = new List<int>();

    public int TodayTestingWordsIndex { get; private set; }
    public List<int> TodayTestingWordIds { get; private set; } = new List<int>();

    #endregion
}
