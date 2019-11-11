// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: entities.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Service.Entities {

  /// <summary>Holder for reflection information generated from entities.proto</summary>
  public static partial class EntitiesReflection {

    #region Descriptor
    /// <summary>File descriptor for entities.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EntitiesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5lbnRpdGllcy5wcm90bxIQc2VydmljZS5lbnRpdGllcyK0AQoEVXNlchIK",
            "CgJpZBgBIAEoCRIYChB0b2RheV9zdHVkeV9kYXRlGAIgASgFEiIKGnRvZGF5",
            "X3N0dWR5aW5nX3dvcmRzX2luZGV4GAMgASgFEh8KF3RvZGF5X3N0dWR5aW5n",
            "X3dvcmRfaWRzGAQgAygFEiEKGXRvZGF5X3Rlc3Rpbmdfd29yZHNfaW5kZXgY",
            "BSABKAUSHgoWdG9kYXlfdGVzdGluZ193b3JkX2lkcxgGIAMoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Service.Entities.User), global::Service.Entities.User.Parser, new[]{ "Id", "TodayStudyDate", "TodayStudyingWordsIndex", "TodayStudyingWordIds", "TodayTestingWordsIndex", "TodayTestingWordIds" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class User : pb::IMessage<User> {
    private static readonly pb::MessageParser<User> _parser = new pb::MessageParser<User>(() => new User());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<User> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Service.Entities.EntitiesReflection.Descriptor.MessageTypes[0]; }
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
      todayStudyDate_ = other.todayStudyDate_;
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

    /// <summary>Field number for the "today_study_date" field.</summary>
    public const int TodayStudyDateFieldNumber = 2;
    private int todayStudyDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TodayStudyDate {
      get { return todayStudyDate_; }
      set {
        todayStudyDate_ = value;
      }
    }

    /// <summary>Field number for the "today_studying_words_index" field.</summary>
    public const int TodayStudyingWordsIndexFieldNumber = 3;
    private int todayStudyingWordsIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TodayStudyingWordsIndex {
      get { return todayStudyingWordsIndex_; }
      set {
        todayStudyingWordsIndex_ = value;
      }
    }

    /// <summary>Field number for the "today_studying_word_ids" field.</summary>
    public const int TodayStudyingWordIdsFieldNumber = 4;
    private static readonly pb::FieldCodec<int> _repeated_todayStudyingWordIds_codec
        = pb::FieldCodec.ForInt32(34);
    private readonly pbc::RepeatedField<int> todayStudyingWordIds_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> TodayStudyingWordIds {
      get { return todayStudyingWordIds_; }
    }

    /// <summary>Field number for the "today_testing_words_index" field.</summary>
    public const int TodayTestingWordsIndexFieldNumber = 5;
    private int todayTestingWordsIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TodayTestingWordsIndex {
      get { return todayTestingWordsIndex_; }
      set {
        todayTestingWordsIndex_ = value;
      }
    }

    /// <summary>Field number for the "today_testing_word_ids" field.</summary>
    public const int TodayTestingWordIdsFieldNumber = 6;
    private static readonly pb::FieldCodec<int> _repeated_todayTestingWordIds_codec
        = pb::FieldCodec.ForInt32(50);
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
      if (TodayStudyDate != other.TodayStudyDate) return false;
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
      if (TodayStudyDate != 0) hash ^= TodayStudyDate.GetHashCode();
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
      if (TodayStudyDate != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(TodayStudyDate);
      }
      if (TodayStudyingWordsIndex != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(TodayStudyingWordsIndex);
      }
      todayStudyingWordIds_.WriteTo(output, _repeated_todayStudyingWordIds_codec);
      if (TodayTestingWordsIndex != 0) {
        output.WriteRawTag(40);
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
      if (TodayStudyDate != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TodayStudyDate);
      }
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
      if (other.TodayStudyDate != 0) {
        TodayStudyDate = other.TodayStudyDate;
      }
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
          case 16: {
            TodayStudyDate = input.ReadInt32();
            break;
          }
          case 24: {
            TodayStudyingWordsIndex = input.ReadInt32();
            break;
          }
          case 34:
          case 32: {
            todayStudyingWordIds_.AddEntriesFrom(input, _repeated_todayStudyingWordIds_codec);
            break;
          }
          case 40: {
            TodayTestingWordsIndex = input.ReadInt32();
            break;
          }
          case 50:
          case 48: {
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
