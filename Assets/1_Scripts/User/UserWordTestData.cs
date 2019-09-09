public class UserWordTestData
{
    public int Id;
    public int TestPassCount;
    public int LastPassedDate;

    public UserWordTestData(ProtocolUserWordTestData data)
    {
        Id = data.Id;
        TestPassCount = data.TestPassCount;
        LastPassedDate = data.LastPassedDate;
    }
}
