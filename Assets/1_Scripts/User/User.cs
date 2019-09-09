using System.Collections.Generic;

public partial class User : Singleton<User>
{
    public int TodayStudyDate { get; private set; }
    public Dictionary<int, UserWordStudyData> WordStudyData { get; private set; }
    public Dictionary<int, UserWordTestData> WordTestData { get; private set; }

    public int TodayStudyWordsIndex { get; private set; }
    public Dictionary<int, List<int>> TodayStudyWords { get; private set; }

    public int TodayTestWordsIndex { get; private set; }
    public Dictionary<int, List<int>> TodayTestWords { get; private set; }
}
