// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: user.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Data.User {

  /// <summary>Holder for reflection information generated from user.proto</summary>
  public static partial class UserReflection {

    #region Descriptor
    /// <summary>File descriptor for user.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgp1c2VyLnByb3RvEglkYXRhLnVzZXIiFAoEVGltZRIMCgR0aW1lGAEgASgD",
            "IjEKDFN0dWR5aW5nV29yZBIKCgJpZBgBIAEoBRIVCg1zdHVkaWVkX2NvdW50",
            "GAIgASgFIi8KC1Rlc3RpbmdXb3JkEgoKAmlkGAEgASgFEhQKDHBhc3NlZF9j",
            "b3VudBgCIAEoBSImCglXb3JkT3JkZXISCgoCaWQYASABKAUSDQoFb3JkZXIY",
            "AiABKAUivQYKBFVzZXISCgoCaWQYASABKAkSKgoRbGFzdF9zaWduaW5nX3Rp",
            "bWUYAiABKAsyDy5kYXRhLnVzZXIuVGltZRIYChB0b2RheV9zdHVkeV9kYXRl",
            "GAMgASgFEhwKFGxhc3Rfc3R1ZGllZF93b3JkX2lkGAQgASgFEjoKDnN0dWR5",
            "aW5nX3dvcmRzGAUgAygLMiIuZGF0YS51c2VyLlVzZXIuU3R1ZHlpbmdXb3Jk",
            "c0VudHJ5EjgKDXRlc3Rpbmdfd29yZHMYBiADKAsyIS5kYXRhLnVzZXIuVXNl",
            "ci5UZXN0aW5nV29yZHNFbnRyeRJFChRzdHVkeWluZ193b3JkX29yZGVycxgH",
            "IAMoCzInLmRhdGEudXNlci5Vc2VyLlN0dWR5aW5nV29yZE9yZGVyc0VudHJ5",
            "EkMKE3Rlc3Rpbmdfd29yZF9vcmRlcnMYCCADKAsyJi5kYXRhLnVzZXIuVXNl",
            "ci5UZXN0aW5nV29yZE9yZGVyc0VudHJ5EiIKGnRvZGF5X3N0dWR5aW5nX3dv",
            "cmRzX2luZGV4GAkgASgFEh8KF3RvZGF5X3N0dWR5aW5nX3dvcmRfaWRzGAog",
            "AygFEiEKGXRvZGF5X3Rlc3Rpbmdfd29yZHNfaW5kZXgYCyABKAUSHgoWdG9k",
            "YXlfdGVzdGluZ193b3JkX2lkcxgMIAMoBRpNChJTdHVkeWluZ1dvcmRzRW50",
            "cnkSCwoDa2V5GAEgASgFEiYKBXZhbHVlGAIgASgLMhcuZGF0YS51c2VyLlN0",
            "dWR5aW5nV29yZDoCOAEaSwoRVGVzdGluZ1dvcmRzRW50cnkSCwoDa2V5GAEg",
            "ASgFEiUKBXZhbHVlGAIgASgLMhYuZGF0YS51c2VyLlRlc3RpbmdXb3JkOgI4",
            "ARpPChdTdHVkeWluZ1dvcmRPcmRlcnNFbnRyeRILCgNrZXkYASABKAUSIwoF",
            "dmFsdWUYAiABKAsyFC5kYXRhLnVzZXIuV29yZE9yZGVyOgI4ARpOChZUZXN0",
            "aW5nV29yZE9yZGVyc0VudHJ5EgsKA2tleRgBIAEoBRIjCgV2YWx1ZRgCIAEo",
            "CzIULmRhdGEudXNlci5Xb3JkT3JkZXI6AjgBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Data.User.Time), global::Data.User.Time.Parser, new[]{ "Time_" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Data.User.StudyingWord), global::Data.User.StudyingWord.Parser, new[]{ "Id", "StudiedCount" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Data.User.TestingWord), global::Data.User.TestingWord.Parser, new[]{ "Id", "PassedCount" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Data.User.WordOrder), global::Data.User.WordOrder.Parser, new[]{ "Id", "Order" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Data.User.User), global::Data.User.User.Parser, new[]{ "Id", "LastSigningTime", "TodayStudyDate", "LastStudiedWordId", "StudyingWords", "TestingWords", "StudyingWordOrders", "TestingWordOrders", "TodayStudyingWordsIndex", "TodayStudyingWordIds", "TodayTestingWordsIndex", "TodayTestingWordIds" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Time : pb::IMessage<Time> {
    private static readonly pb::MessageParser<Time> _parser = new pb::MessageParser<Time>(() => new Time());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Time> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Data.User.UserReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Time() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Time(Time other) : this() {
      time_ = other.time_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Time Clone() {
      return new Time(this);
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int Time_FieldNumber = 1;
    private long time_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Time_ {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Time);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Time other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Time_ != other.Time_) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Time_ != 0L) hash ^= Time_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Time_ != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Time_);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Time_ != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Time_);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Time other) {
      if (other == null) {
        return;
      }
      if (other.Time_ != 0L) {
        Time_ = other.Time_;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Time_ = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class StudyingWord : pb::IMessage<StudyingWord> {
    private static readonly pb::MessageParser<StudyingWord> _parser = new pb::MessageParser<StudyingWord>(() => new StudyingWord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StudyingWord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Data.User.UserReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StudyingWord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StudyingWord(StudyingWord other) : this() {
      id_ = other.id_;
      studiedCount_ = other.studiedCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StudyingWord Clone() {
      return new StudyingWord(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "studied_count" field.</summary>
    public const int StudiedCountFieldNumber = 2;
    private int studiedCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int StudiedCount {
      get { return studiedCount_; }
      set {
        studiedCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StudyingWord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StudyingWord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (StudiedCount != other.StudiedCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (StudiedCount != 0) hash ^= StudiedCount.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (StudiedCount != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(StudiedCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (StudiedCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StudiedCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StudyingWord other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.StudiedCount != 0) {
        StudiedCount = other.StudiedCount;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            StudiedCount = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class TestingWord : pb::IMessage<TestingWord> {
    private static readonly pb::MessageParser<TestingWord> _parser = new pb::MessageParser<TestingWord>(() => new TestingWord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TestingWord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Data.User.UserReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TestingWord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TestingWord(TestingWord other) : this() {
      id_ = other.id_;
      passedCount_ = other.passedCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TestingWord Clone() {
      return new TestingWord(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "passed_count" field.</summary>
    public const int PassedCountFieldNumber = 2;
    private int passedCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PassedCount {
      get { return passedCount_; }
      set {
        passedCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TestingWord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TestingWord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (PassedCount != other.PassedCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (PassedCount != 0) hash ^= PassedCount.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (PassedCount != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PassedCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (PassedCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PassedCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TestingWord other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.PassedCount != 0) {
        PassedCount = other.PassedCount;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            PassedCount = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class WordOrder : pb::IMessage<WordOrder> {
    private static readonly pb::MessageParser<WordOrder> _parser = new pb::MessageParser<WordOrder>(() => new WordOrder());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WordOrder> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Data.User.UserReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WordOrder() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WordOrder(WordOrder other) : this() {
      id_ = other.id_;
      order_ = other.order_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WordOrder Clone() {
      return new WordOrder(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "order" field.</summary>
    public const int OrderFieldNumber = 2;
    private int order_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Order {
      get { return order_; }
      set {
        order_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WordOrder);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WordOrder other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Order != other.Order) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Order != 0) hash ^= Order.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Order != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Order);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Order != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Order);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WordOrder other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Order != 0) {
        Order = other.Order;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            Order = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class User : pb::IMessage<User> {
    private static readonly pb::MessageParser<User> _parser = new pb::MessageParser<User>(() => new User());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<User> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Data.User.UserReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User(User other) : this() {
      id_ = other.id_;
      lastSigningTime_ = other.lastSigningTime_ != null ? other.lastSigningTime_.Clone() : null;
      todayStudyDate_ = other.todayStudyDate_;
      lastStudiedWordId_ = other.lastStudiedWordId_;
      studyingWords_ = other.studyingWords_.Clone();
      testingWords_ = other.testingWords_.Clone();
      studyingWordOrders_ = other.studyingWordOrders_.Clone();
      testingWordOrders_ = other.testingWordOrders_.Clone();
      todayStudyingWordsIndex_ = other.todayStudyingWordsIndex_;
      todayStudyingWordIds_ = other.todayStudyingWordIds_.Clone();
      todayTestingWordsIndex_ = other.todayTestingWordsIndex_;
      todayTestingWordIds_ = other.todayTestingWordIds_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User Clone() {
      return new User(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "last_signing_time" field.</summary>
    public const int LastSigningTimeFieldNumber = 2;
    private global::Data.User.Time lastSigningTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Data.User.Time LastSigningTime {
      get { return lastSigningTime_; }
      set {
        lastSigningTime_ = value;
      }
    }

    /// <summary>Field number for the "today_study_date" field.</summary>
    public const int TodayStudyDateFieldNumber = 3;
    private int todayStudyDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TodayStudyDate {
      get { return todayStudyDate_; }
      set {
        todayStudyDate_ = value;
      }
    }

    /// <summary>Field number for the "last_studied_word_id" field.</summary>
    public const int LastStudiedWordIdFieldNumber = 4;
    private int lastStudiedWordId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int LastStudiedWordId {
      get { return lastStudiedWordId_; }
      set {
        lastStudiedWordId_ = value;
      }
    }

    /// <summary>Field number for the "studying_words" field.</summary>
    public const int StudyingWordsFieldNumber = 5;
    private static readonly pbc::MapField<int, global::Data.User.StudyingWord>.Codec _map_studyingWords_codec
        = new pbc::MapField<int, global::Data.User.StudyingWord>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForMessage(18, global::Data.User.StudyingWord.Parser), 42);
    private readonly pbc::MapField<int, global::Data.User.StudyingWord> studyingWords_ = new pbc::MapField<int, global::Data.User.StudyingWord>();
    /// <summary>
    /// key : word id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, global::Data.User.StudyingWord> StudyingWords {
      get { return studyingWords_; }
    }

    /// <summary>Field number for the "testing_words" field.</summary>
    public const int TestingWordsFieldNumber = 6;
    private static readonly pbc::MapField<int, global::Data.User.TestingWord>.Codec _map_testingWords_codec
        = new pbc::MapField<int, global::Data.User.TestingWord>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForMessage(18, global::Data.User.TestingWord.Parser), 50);
    private readonly pbc::MapField<int, global::Data.User.TestingWord> testingWords_ = new pbc::MapField<int, global::Data.User.TestingWord>();
    /// <summary>
    /// key : word id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, global::Data.User.TestingWord> TestingWords {
      get { return testingWords_; }
    }

    /// <summary>Field number for the "studying_word_orders" field.</summary>
    public const int StudyingWordOrdersFieldNumber = 7;
    private static readonly pbc::MapField<int, global::Data.User.WordOrder>.Codec _map_studyingWordOrders_codec
        = new pbc::MapField<int, global::Data.User.WordOrder>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForMessage(18, global::Data.User.WordOrder.Parser), 58);
    private readonly pbc::MapField<int, global::Data.User.WordOrder> studyingWordOrders_ = new pbc::MapField<int, global::Data.User.WordOrder>();
    /// <summary>
    /// key : word id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, global::Data.User.WordOrder> StudyingWordOrders {
      get { return studyingWordOrders_; }
    }

    /// <summary>Field number for the "testing_word_orders" field.</summary>
    public const int TestingWordOrdersFieldNumber = 8;
    private static readonly pbc::MapField<int, global::Data.User.WordOrder>.Codec _map_testingWordOrders_codec
        = new pbc::MapField<int, global::Data.User.WordOrder>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForMessage(18, global::Data.User.WordOrder.Parser), 66);
    private readonly pbc::MapField<int, global::Data.User.WordOrder> testingWordOrders_ = new pbc::MapField<int, global::Data.User.WordOrder>();
    /// <summary>
    /// key : word id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, global::Data.User.WordOrder> TestingWordOrders {
      get { return testingWordOrders_; }
    }

    /// <summary>Field number for the "today_studying_words_index" field.</summary>
    public const int TodayStudyingWordsIndexFieldNumber = 9;
    private int todayStudyingWordsIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TodayStudyingWordsIndex {
      get { return todayStudyingWordsIndex_; }
      set {
        todayStudyingWordsIndex_ = value;
      }
    }

    /// <summary>Field number for the "today_studying_word_ids" field.</summary>
    public const int TodayStudyingWordIdsFieldNumber = 10;
    private static readonly pb::FieldCodec<int> _repeated_todayStudyingWordIds_codec
        = pb::FieldCodec.ForInt32(82);
    private readonly pbc::RepeatedField<int> todayStudyingWordIds_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> TodayStudyingWordIds {
      get { return todayStudyingWordIds_; }
    }

    /// <summary>Field number for the "today_testing_words_index" field.</summary>
    public const int TodayTestingWordsIndexFieldNumber = 11;
    private int todayTestingWordsIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TodayTestingWordsIndex {
      get { return todayTestingWordsIndex_; }
      set {
        todayTestingWordsIndex_ = value;
      }
    }

    /// <summary>Field number for the "today_testing_word_ids" field.</summary>
    public const int TodayTestingWordIdsFieldNumber = 12;
    private static readonly pb::FieldCodec<int> _repeated_todayTestingWordIds_codec
        = pb::FieldCodec.ForInt32(98);
    private readonly pbc::RepeatedField<int> todayTestingWordIds_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> TodayTestingWordIds {
      get { return todayTestingWordIds_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as User);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(User other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!object.Equals(LastSigningTime, other.LastSigningTime)) return false;
      if (TodayStudyDate != other.TodayStudyDate) return false;
      if (LastStudiedWordId != other.LastStudiedWordId) return false;
      if (!StudyingWords.Equals(other.StudyingWords)) return false;
      if (!TestingWords.Equals(other.TestingWords)) return false;
      if (!StudyingWordOrders.Equals(other.StudyingWordOrders)) return false;
      if (!TestingWordOrders.Equals(other.TestingWordOrders)) return false;
      if (TodayStudyingWordsIndex != other.TodayStudyingWordsIndex) return false;
      if(!todayStudyingWordIds_.Equals(other.todayStudyingWordIds_)) return false;
      if (TodayTestingWordsIndex != other.TodayTestingWordsIndex) return false;
      if(!todayTestingWordIds_.Equals(other.todayTestingWordIds_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (lastSigningTime_ != null) hash ^= LastSigningTime.GetHashCode();
      if (TodayStudyDate != 0) hash ^= TodayStudyDate.GetHashCode();
      if (LastStudiedWordId != 0) hash ^= LastStudiedWordId.GetHashCode();
      hash ^= StudyingWords.GetHashCode();
      hash ^= TestingWords.GetHashCode();
      hash ^= StudyingWordOrders.GetHashCode();
      hash ^= TestingWordOrders.GetHashCode();
      if (TodayStudyingWordsIndex != 0) hash ^= TodayStudyingWordsIndex.GetHashCode();
      hash ^= todayStudyingWordIds_.GetHashCode();
      if (TodayTestingWordsIndex != 0) hash ^= TodayTestingWordsIndex.GetHashCode();
      hash ^= todayTestingWordIds_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (lastSigningTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(LastSigningTime);
      }
      if (TodayStudyDate != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(TodayStudyDate);
      }
      if (LastStudiedWordId != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(LastStudiedWordId);
      }
      studyingWords_.WriteTo(output, _map_studyingWords_codec);
      testingWords_.WriteTo(output, _map_testingWords_codec);
      studyingWordOrders_.WriteTo(output, _map_studyingWordOrders_codec);
      testingWordOrders_.WriteTo(output, _map_testingWordOrders_codec);
      if (TodayStudyingWordsIndex != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(TodayStudyingWordsIndex);
      }
      todayStudyingWordIds_.WriteTo(output, _repeated_todayStudyingWordIds_codec);
      if (TodayTestingWordsIndex != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(TodayTestingWordsIndex);
      }
      todayTestingWordIds_.WriteTo(output, _repeated_todayTestingWordIds_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (lastSigningTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LastSigningTime);
      }
      if (TodayStudyDate != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TodayStudyDate);
      }
      if (LastStudiedWordId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LastStudiedWordId);
      }
      size += studyingWords_.CalculateSize(_map_studyingWords_codec);
      size += testingWords_.CalculateSize(_map_testingWords_codec);
      size += studyingWordOrders_.CalculateSize(_map_studyingWordOrders_codec);
      size += testingWordOrders_.CalculateSize(_map_testingWordOrders_codec);
      if (TodayStudyingWordsIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TodayStudyingWordsIndex);
      }
      size += todayStudyingWordIds_.CalculateSize(_repeated_todayStudyingWordIds_codec);
      if (TodayTestingWordsIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TodayTestingWordsIndex);
      }
      size += todayTestingWordIds_.CalculateSize(_repeated_todayTestingWordIds_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(User other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.lastSigningTime_ != null) {
        if (lastSigningTime_ == null) {
          LastSigningTime = new global::Data.User.Time();
        }
        LastSigningTime.MergeFrom(other.LastSigningTime);
      }
      if (other.TodayStudyDate != 0) {
        TodayStudyDate = other.TodayStudyDate;
      }
      if (other.LastStudiedWordId != 0) {
        LastStudiedWordId = other.LastStudiedWordId;
      }
      studyingWords_.Add(other.studyingWords_);
      testingWords_.Add(other.testingWords_);
      studyingWordOrders_.Add(other.studyingWordOrders_);
      testingWordOrders_.Add(other.testingWordOrders_);
      if (other.TodayStudyingWordsIndex != 0) {
        TodayStudyingWordsIndex = other.TodayStudyingWordsIndex;
      }
      todayStudyingWordIds_.Add(other.todayStudyingWordIds_);
      if (other.TodayTestingWordsIndex != 0) {
        TodayTestingWordsIndex = other.TodayTestingWordsIndex;
      }
      todayTestingWordIds_.Add(other.todayTestingWordIds_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            if (lastSigningTime_ == null) {
              LastSigningTime = new global::Data.User.Time();
            }
            input.ReadMessage(LastSigningTime);
            break;
          }
          case 24: {
            TodayStudyDate = input.ReadInt32();
            break;
          }
          case 32: {
            LastStudiedWordId = input.ReadInt32();
            break;
          }
          case 42: {
            studyingWords_.AddEntriesFrom(input, _map_studyingWords_codec);
            break;
          }
          case 50: {
            testingWords_.AddEntriesFrom(input, _map_testingWords_codec);
            break;
          }
          case 58: {
            studyingWordOrders_.AddEntriesFrom(input, _map_studyingWordOrders_codec);
            break;
          }
          case 66: {
            testingWordOrders_.AddEntriesFrom(input, _map_testingWordOrders_codec);
            break;
          }
          case 72: {
            TodayStudyingWordsIndex = input.ReadInt32();
            break;
          }
          case 82:
          case 80: {
            todayStudyingWordIds_.AddEntriesFrom(input, _repeated_todayStudyingWordIds_codec);
            break;
          }
          case 88: {
            TodayTestingWordsIndex = input.ReadInt32();
            break;
          }
          case 98:
          case 96: {
            todayTestingWordIds_.AddEntriesFrom(input, _repeated_todayTestingWordIds_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
