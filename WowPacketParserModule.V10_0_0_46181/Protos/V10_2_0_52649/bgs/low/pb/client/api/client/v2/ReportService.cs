// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: bgs/low/pb/client/api/client/v2/report_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2 {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/api/client/v2/report_service.proto</summary>
  public static partial class ReportServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/api/client/v2/report_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReportServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL3JlcG9ydF9zZXJ2",
            "aWNlLnByb3RvEhZiZ3MucHJvdG9jb2wucmVwb3J0LnYyGiViZ3MvbG93L3Bi",
            "L2NsaWVudC9hY2NvdW50X3R5cGVzLnByb3RvGjJiZ3MvbG93L3BiL2NsaWVu",
            "dC9hcGkvY2xpZW50L3YyL3JlcG9ydF90eXBlcy5wcm90bxohYmdzL2xvdy9w",
            "Yi9jbGllbnQvcnBjX3R5cGVzLnByb3RvIrACChNTdWJtaXRSZXBvcnRSZXF1",
            "ZXN0EjQKCGFnZW50X2lkGAEgASgLMiIuYmdzLnByb3RvY29sLmFjY291bnQu",
            "djEuQWNjb3VudElkEhgKEHVzZXJfZGVzY3JpcHRpb24YAiABKAkSOwoMdXNl",
            "cl9vcHRpb25zGAogASgLMiMuYmdzLnByb3RvY29sLnJlcG9ydC52Mi5Vc2Vy",
            "T3B0aW9uc0gAEjsKDGNsdWJfb3B0aW9ucxgLIAEoCzIjLmJncy5wcm90b2Nv",
            "bC5yZXBvcnQudjIuQ2x1Yk9wdGlvbnNIABI/Cg5lbnRpdHlfb3B0aW9ucxgU",
            "IAEoCzIlLmJncy5wcm90b2NvbC5yZXBvcnQudjIuRW50aXR5T3B0aW9uc0gA",
            "OgaC+SsCCAFCBgoEdHlwZTLCAQoNUmVwb3J0U2VydmljZRJ0CgxTdWJtaXRS",
            "ZXBvcnQSKy5iZ3MucHJvdG9jb2wucmVwb3J0LnYyLlN1Ym1pdFJlcG9ydFJl",
            "cXVlc3QaFC5iZ3MucHJvdG9jb2wuTm9EYXRhIiGC+SsdCAFCGVJlc29sdmVT",
            "dWJtaXRSZXBvcnRSZWdpb24aO4L5KzEKJWJuZXQucHJvdG9jb2wucmVwb3J0",
            "LnYyLlJlcG9ydFNlcnZpY2UqBnJlcG9ydEgBivkrAhABQgVIAYABAA=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Account.V1.AccountTypesReflection.Descriptor, WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.ReportTypesReflection.Descriptor, WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.RpcTypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.SubmitReportRequest), WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.SubmitReportRequest.Parser, new[]{ "AgentId", "UserDescription", "UserOptions", "ClubOptions", "EntityOptions" }, new[]{ "Type" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SubmitReportRequest : pb::IMessage<SubmitReportRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SubmitReportRequest> _parser = new pb::MessageParser<SubmitReportRequest>(() => new SubmitReportRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SubmitReportRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.ReportServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SubmitReportRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SubmitReportRequest(SubmitReportRequest other) : this() {
      agentId_ = other.agentId_ != null ? other.agentId_.Clone() : null;
      userDescription_ = other.userDescription_;
      switch (other.TypeCase) {
        case TypeOneofCase.UserOptions:
          UserOptions = other.UserOptions.Clone();
          break;
        case TypeOneofCase.ClubOptions:
          ClubOptions = other.ClubOptions.Clone();
          break;
        case TypeOneofCase.EntityOptions:
          EntityOptions = other.EntityOptions.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SubmitReportRequest Clone() {
      return new SubmitReportRequest(this);
    }

    /// <summary>Field number for the "agent_id" field.</summary>
    public const int AgentIdFieldNumber = 1;
    private WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Account.V1.AccountId agentId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Account.V1.AccountId AgentId {
      get { return agentId_; }
      set {
        agentId_ = value;
      }
    }

    /// <summary>Field number for the "user_description" field.</summary>
    public const int UserDescriptionFieldNumber = 2;
    private readonly static string UserDescriptionDefaultValue = "";

    private string userDescription_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UserDescription {
      get { return userDescription_ ?? UserDescriptionDefaultValue; }
      set {
        userDescription_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "user_description" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasUserDescription {
      get { return userDescription_ != null; }
    }
    /// <summary>Clears the value of the "user_description" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearUserDescription() {
      userDescription_ = null;
    }

    /// <summary>Field number for the "user_options" field.</summary>
    public const int UserOptionsFieldNumber = 10;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.UserOptions UserOptions {
      get { return typeCase_ == TypeOneofCase.UserOptions ? (WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.UserOptions) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.UserOptions;
      }
    }

    /// <summary>Field number for the "club_options" field.</summary>
    public const int ClubOptionsFieldNumber = 11;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.ClubOptions ClubOptions {
      get { return typeCase_ == TypeOneofCase.ClubOptions ? (WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.ClubOptions) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.ClubOptions;
      }
    }

    /// <summary>Field number for the "entity_options" field.</summary>
    public const int EntityOptionsFieldNumber = 20;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.EntityOptions EntityOptions {
      get { return typeCase_ == TypeOneofCase.EntityOptions ? (WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.EntityOptions) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.EntityOptions;
      }
    }

    private object type_;
    /// <summary>Enum of possible cases for the "type" oneof.</summary>
    public enum TypeOneofCase {
      None = 0,
      UserOptions = 10,
      ClubOptions = 11,
      EntityOptions = 20,
    }
    private TypeOneofCase typeCase_ = TypeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TypeOneofCase TypeCase {
      get { return typeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearType() {
      typeCase_ = TypeOneofCase.None;
      type_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SubmitReportRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SubmitReportRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AgentId, other.AgentId)) return false;
      if (UserDescription != other.UserDescription) return false;
      if (!object.Equals(UserOptions, other.UserOptions)) return false;
      if (!object.Equals(ClubOptions, other.ClubOptions)) return false;
      if (!object.Equals(EntityOptions, other.EntityOptions)) return false;
      if (TypeCase != other.TypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (agentId_ != null) hash ^= AgentId.GetHashCode();
      if (HasUserDescription) hash ^= UserDescription.GetHashCode();
      if (typeCase_ == TypeOneofCase.UserOptions) hash ^= UserOptions.GetHashCode();
      if (typeCase_ == TypeOneofCase.ClubOptions) hash ^= ClubOptions.GetHashCode();
      if (typeCase_ == TypeOneofCase.EntityOptions) hash ^= EntityOptions.GetHashCode();
      hash ^= (int) typeCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (agentId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AgentId);
      }
      if (HasUserDescription) {
        output.WriteRawTag(18);
        output.WriteString(UserDescription);
      }
      if (typeCase_ == TypeOneofCase.UserOptions) {
        output.WriteRawTag(82);
        output.WriteMessage(UserOptions);
      }
      if (typeCase_ == TypeOneofCase.ClubOptions) {
        output.WriteRawTag(90);
        output.WriteMessage(ClubOptions);
      }
      if (typeCase_ == TypeOneofCase.EntityOptions) {
        output.WriteRawTag(162, 1);
        output.WriteMessage(EntityOptions);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (agentId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AgentId);
      }
      if (HasUserDescription) {
        output.WriteRawTag(18);
        output.WriteString(UserDescription);
      }
      if (typeCase_ == TypeOneofCase.UserOptions) {
        output.WriteRawTag(82);
        output.WriteMessage(UserOptions);
      }
      if (typeCase_ == TypeOneofCase.ClubOptions) {
        output.WriteRawTag(90);
        output.WriteMessage(ClubOptions);
      }
      if (typeCase_ == TypeOneofCase.EntityOptions) {
        output.WriteRawTag(162, 1);
        output.WriteMessage(EntityOptions);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (agentId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AgentId);
      }
      if (HasUserDescription) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserDescription);
      }
      if (typeCase_ == TypeOneofCase.UserOptions) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UserOptions);
      }
      if (typeCase_ == TypeOneofCase.ClubOptions) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ClubOptions);
      }
      if (typeCase_ == TypeOneofCase.EntityOptions) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(EntityOptions);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SubmitReportRequest other) {
      if (other == null) {
        return;
      }
      if (other.agentId_ != null) {
        if (agentId_ == null) {
          AgentId = new WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Account.V1.AccountId();
        }
        AgentId.MergeFrom(other.AgentId);
      }
      if (other.HasUserDescription) {
        UserDescription = other.UserDescription;
      }
      switch (other.TypeCase) {
        case TypeOneofCase.UserOptions:
          if (UserOptions == null) {
            UserOptions = new WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.UserOptions();
          }
          UserOptions.MergeFrom(other.UserOptions);
          break;
        case TypeOneofCase.ClubOptions:
          if (ClubOptions == null) {
            ClubOptions = new WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.ClubOptions();
          }
          ClubOptions.MergeFrom(other.ClubOptions);
          break;
        case TypeOneofCase.EntityOptions:
          if (EntityOptions == null) {
            EntityOptions = new WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.EntityOptions();
          }
          EntityOptions.MergeFrom(other.EntityOptions);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (agentId_ == null) {
              AgentId = new WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Account.V1.AccountId();
            }
            input.ReadMessage(AgentId);
            break;
          }
          case 18: {
            UserDescription = input.ReadString();
            break;
          }
          case 82: {
            WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.UserOptions subBuilder = new WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.UserOptions();
            if (typeCase_ == TypeOneofCase.UserOptions) {
              subBuilder.MergeFrom(UserOptions);
            }
            input.ReadMessage(subBuilder);
            UserOptions = subBuilder;
            break;
          }
          case 90: {
            WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.ClubOptions subBuilder = new WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.ClubOptions();
            if (typeCase_ == TypeOneofCase.ClubOptions) {
              subBuilder.MergeFrom(ClubOptions);
            }
            input.ReadMessage(subBuilder);
            ClubOptions = subBuilder;
            break;
          }
          case 162: {
            WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.EntityOptions subBuilder = new WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.EntityOptions();
            if (typeCase_ == TypeOneofCase.EntityOptions) {
              subBuilder.MergeFrom(EntityOptions);
            }
            input.ReadMessage(subBuilder);
            EntityOptions = subBuilder;
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (agentId_ == null) {
              AgentId = new WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Account.V1.AccountId();
            }
            input.ReadMessage(AgentId);
            break;
          }
          case 18: {
            UserDescription = input.ReadString();
            break;
          }
          case 82: {
            WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.UserOptions subBuilder = new WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.UserOptions();
            if (typeCase_ == TypeOneofCase.UserOptions) {
              subBuilder.MergeFrom(UserOptions);
            }
            input.ReadMessage(subBuilder);
            UserOptions = subBuilder;
            break;
          }
          case 90: {
            WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.ClubOptions subBuilder = new WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.ClubOptions();
            if (typeCase_ == TypeOneofCase.ClubOptions) {
              subBuilder.MergeFrom(ClubOptions);
            }
            input.ReadMessage(subBuilder);
            ClubOptions = subBuilder;
            break;
          }
          case 162: {
            WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.EntityOptions subBuilder = new WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Report.V2.EntityOptions();
            if (typeCase_ == TypeOneofCase.EntityOptions) {
              subBuilder.MergeFrom(EntityOptions);
            }
            input.ReadMessage(subBuilder);
            EntityOptions = subBuilder;
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
