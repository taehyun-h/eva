public class UserWordStudyData
{
    public int Id;
    public int StudyCount;

    public UserWordStudyData(ProtocolUserWordStudyData data)
    {
        Id = data.Id;
        StudyCount = data.StudyCount;
    }
}
