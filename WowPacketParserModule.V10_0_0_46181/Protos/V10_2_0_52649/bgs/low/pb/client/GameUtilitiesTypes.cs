// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: bgs/low/pb/client/game_utilities_types.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.GameUtilities.V1 {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/game_utilities_types.proto</summary>
  public static partial class GameUtilitiesTypesReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/game_utilities_types.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GameUtilitiesTypesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixiZ3MvbG93L3BiL2NsaWVudC9nYW1lX3V0aWxpdGllc190eXBlcy5wcm90",
            "bxIeYmdzLnByb3RvY29sLmdhbWVfdXRpbGl0aWVzLnYxGidiZ3MvbG93L3Bi",
            "L2NsaWVudC9hdHRyaWJ1dGVfdHlwZXMucHJvdG8aJGJncy9sb3cvcGIvY2xp",
            "ZW50L2VudGl0eV90eXBlcy5wcm90bxohYmdzL2xvdy9wYi9jbGllbnQvcnBj",
            "X3R5cGVzLnByb3RvIncKD1BsYXllclZhcmlhYmxlcxIoCghpZGVudGl0eRgB",
            "IAIoCzIWLmJncy5wcm90b2NvbC5JZGVudGl0eRIOCgZyYXRpbmcYAiABKAES",
            "KgoJYXR0cmlidXRlGAMgAygLMhcuYmdzLnByb3RvY29sLkF0dHJpYnV0ZSJA",
            "CgpDbGllbnRJbmZvEhYKDmNsaWVudF9hZGRyZXNzGAEgASgJEhoKEnByaXZp",
            "bGVnZWRfbmV0d29yaxgCIAEoCEI7Ch5iZ3MucHJvdG9jb2wuZ2FtZV91dGls",
            "aXRpZXMudjFCF0dhbWVVdGlsaXRpZXNUeXBlc1Byb3RvSAE="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.AttributeTypesReflection.Descriptor, WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.EntityTypesReflection.Descriptor, WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.RpcTypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.GameUtilities.V1.PlayerVariables), WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.GameUtilities.V1.PlayerVariables.Parser, new[]{ "Identity", "Rating", "Attribute" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.GameUtilities.V1.ClientInfo), WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.GameUtilities.V1.ClientInfo.Parser, new[]{ "ClientAddress", "PrivilegedNetwork" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerVariables : pb::IMessage<PlayerVariables>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerVariables> _parser = new pb::MessageParser<PlayerVariables>(() => new PlayerVariables());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerVariables> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.GameUtilities.V1.GameUtilitiesTypesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerVariables() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerVariables(PlayerVariables other) : this() {
      _hasBits0 = other._hasBits0;
      identity_ = other.identity_ != null ? other.identity_.Clone() : null;
      rating_ = other.rating_;
      attribute_ = other.attribute_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerVariables Clone() {
      return new PlayerVariables(this);
    }

    /// <summary>Field number for the "identity" field.</summary>
    public const int IdentityFieldNumber = 1;
    private WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Identity identity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Identity Identity {
      get { return identity_; }
      set {
        identity_ = value;
      }
    }

    /// <summary>Field number for the "rating" field.</summary>
    public const int RatingFieldNumber = 2;
    private readonly static double RatingDefaultValue = 0D;

    private double rating_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Rating {
      get { if ((_hasBits0 & 1) != 0) { return rating_; } else { return RatingDefaultValue; } }
      set {
        _hasBits0 |= 1;
        rating_ = value;
      }
    }
    /// <summary>Gets whether the "rating" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasRating {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "rating" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearRating() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "attribute" field.</summary>
    public const int AttributeFieldNumber = 3;
    private static readonly pb::FieldCodec<WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Attribute> _repeated_attribute_codec
        = pb::FieldCodec.ForMessage(26, WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Attribute.Parser);
    private readonly pbc::RepeatedField<WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Attribute> attribute_ = new pbc::RepeatedField<WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Attribute>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Attribute> Attribute {
      get { return attribute_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerVariables);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerVariables other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Identity, other.Identity)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Rating, other.Rating)) return false;
      if(!attribute_.Equals(other.attribute_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (identity_ != null) hash ^= Identity.GetHashCode();
      if (HasRating) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Rating);
      hash ^= attribute_.GetHashCode();
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
      if (identity_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Identity);
      }
      if (HasRating) {
        output.WriteRawTag(17);
        output.WriteDouble(Rating);
      }
      attribute_.WriteTo(output, _repeated_attribute_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (identity_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Identity);
      }
      if (HasRating) {
        output.WriteRawTag(17);
        output.WriteDouble(Rating);
      }
      attribute_.WriteTo(ref output, _repeated_attribute_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (identity_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Identity);
      }
      if (HasRating) {
        size += 1 + 8;
      }
      size += attribute_.CalculateSize(_repeated_attribute_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerVariables other) {
      if (other == null) {
        return;
      }
      if (other.identity_ != null) {
        if (identity_ == null) {
          Identity = new WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Identity();
        }
        Identity.MergeFrom(other.Identity);
      }
      if (other.HasRating) {
        Rating = other.Rating;
      }
      attribute_.Add(other.attribute_);
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
            if (identity_ == null) {
              Identity = new WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Identity();
            }
            input.ReadMessage(Identity);
            break;
          }
          case 17: {
            Rating = input.ReadDouble();
            break;
          }
          case 26: {
            attribute_.AddEntriesFrom(input, _repeated_attribute_codec);
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
            if (identity_ == null) {
              Identity = new WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Identity();
            }
            input.ReadMessage(Identity);
            break;
          }
          case 17: {
            Rating = input.ReadDouble();
            break;
          }
          case 26: {
            attribute_.AddEntriesFrom(ref input, _repeated_attribute_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ClientInfo : pb::IMessage<ClientInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClientInfo> _parser = new pb::MessageParser<ClientInfo>(() => new ClientInfo());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClientInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.GameUtilities.V1.GameUtilitiesTypesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientInfo(ClientInfo other) : this() {
      _hasBits0 = other._hasBits0;
      clientAddress_ = other.clientAddress_;
      privilegedNetwork_ = other.privilegedNetwork_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientInfo Clone() {
      return new ClientInfo(this);
    }

    /// <summary>Field number for the "client_address" field.</summary>
    public const int ClientAddressFieldNumber = 1;
    private readonly static string ClientAddressDefaultValue = "";

    private string clientAddress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientAddress {
      get { return clientAddress_ ?? ClientAddressDefaultValue; }
      set {
        clientAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "client_address" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasClientAddress {
      get { return clientAddress_ != null; }
    }
    /// <summary>Clears the value of the "client_address" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearClientAddress() {
      clientAddress_ = null;
    }

    /// <summary>Field number for the "privileged_network" field.</summary>
    public const int PrivilegedNetworkFieldNumber = 2;
    private readonly static bool PrivilegedNetworkDefaultValue = false;

    private bool privilegedNetwork_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool PrivilegedNetwork {
      get { if ((_hasBits0 & 1) != 0) { return privilegedNetwork_; } else { return PrivilegedNetworkDefaultValue; } }
      set {
        _hasBits0 |= 1;
        privilegedNetwork_ = value;
      }
    }
    /// <summary>Gets whether the "privileged_network" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasPrivilegedNetwork {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "privileged_network" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearPrivilegedNetwork() {
      _hasBits0 &= ~1;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ClientInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClientInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClientAddress != other.ClientAddress) return false;
      if (PrivilegedNetwork != other.PrivilegedNetwork) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasClientAddress) hash ^= ClientAddress.GetHashCode();
      if (HasPrivilegedNetwork) hash ^= PrivilegedNetwork.GetHashCode();
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
      if (HasClientAddress) {
        output.WriteRawTag(10);
        output.WriteString(ClientAddress);
      }
      if (HasPrivilegedNetwork) {
        output.WriteRawTag(16);
        output.WriteBool(PrivilegedNetwork);
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
      if (HasClientAddress) {
        output.WriteRawTag(10);
        output.WriteString(ClientAddress);
      }
      if (HasPrivilegedNetwork) {
        output.WriteRawTag(16);
        output.WriteBool(PrivilegedNetwork);
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
      if (HasClientAddress) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientAddress);
      }
      if (HasPrivilegedNetwork) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ClientInfo other) {
      if (other == null) {
        return;
      }
      if (other.HasClientAddress) {
        ClientAddress = other.ClientAddress;
      }
      if (other.HasPrivilegedNetwork) {
        PrivilegedNetwork = other.PrivilegedNetwork;
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
            ClientAddress = input.ReadString();
            break;
          }
          case 16: {
            PrivilegedNetwork = input.ReadBool();
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
            ClientAddress = input.ReadString();
            break;
          }
          case 16: {
            PrivilegedNetwork = input.ReadBool();
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
