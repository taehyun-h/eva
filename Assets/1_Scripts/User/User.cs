using System.Collections.Generic;

public partial class User : Singleton<User>
{
    public string Id { get; private set; }
    public int TodayStudyDate { get; private set; }

    public int TodayStudyingWordsIndex { get; private set; }
    public List<int> TodayStudyingWordIds { get; private set; } = new List<int>();

    public int TodayTestingWordsIndex { get; private set; }
    public List<int> TodayTestingWordIds { get; private set; } = new List<int>();
}
