using System.Collections.Generic;

public partial class User : Singleton<User>
{
    public int TodayStudyDate { get; private set; }
    public int TodayStudyWordsIndex { get; private set; }
    public List<int> TodayStudyWords { get; private set; }

    public HashSet<UserWordStudyData> WordStudyData { get; private set; }
}
