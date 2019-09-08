using System;
using System.Collections.Generic;

[Serializable]
public class ProtocolUser
{
    public DateTime LastSignInTime;

    public int TodayStudyDate;
    public int TodayStudyWordsIndex;
    public Dictionary<int, List<int>> TodayStudyWords = new Dictionary<int, List<int>>();

    public int LastStudiedWordId;
    public Dictionary<int, ProtocolUserWordStudyData> WordStudyData = new Dictionary<int, ProtocolUserWordStudyData>();

    public void AddStudyWord(int date, int id)
    {
        if (!TodayStudyWords.TryGetValue(date, out var list))
        {
            list = new List<int>();
            TodayStudyWords[date] = list;
        }

        list.Add(id);
    }
}
