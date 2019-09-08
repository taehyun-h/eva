using System;
using System.Collections.Generic;

[Serializable]
public class ProtocolUser
{
    public DateTime LastSignInTime;

    public int TodayStudyDate;
    public int TodayStudyWordsIndex;
    public List<int> TodayStudyWords = new List<int>();
    
    public int LastStudiedWordId;
    public Dictionary<int, ProtocolUserWordStudyData> WordStudyData = new Dictionary<int, ProtocolUserWordStudyData>();
}
