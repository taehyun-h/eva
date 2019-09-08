using System;

[Serializable]
public struct ProtocolUserWordStudyData : IEquatable<ProtocolUserWordStudyData>
{
    public readonly int Id;
    public int StudyCount;

    public ProtocolUserWordStudyData(int id)
    {
        Id = id;
        StudyCount = 0;
    }

    public override int GetHashCode()
    {
        return Id;
    }

    public override bool Equals(object obj)
    {
        return obj is ProtocolUserWordStudyData data && Equals(data);
    }

    public bool Equals(ProtocolUserWordStudyData data)
    {
        return Id == data.Id;
    }
}
