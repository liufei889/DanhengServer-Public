// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EJFLFKFJBJC.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EJFLFKFJBJC.proto</summary>
  public static partial class EJFLFKFJBJCReflection {

    #region Descriptor
    /// <summary>File descriptor for EJFLFKFJBJC.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EJFLFKFJBJCReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFFSkZMRktGSkJKQy5wcm90byJhCgtFSkZMRktGSkJKQxITCgtCTk1FQk9J",
            "SU5JTxgIIAEoDRITCgtIT0ZGQkhCSlBOQhgFIAEoDRITCgtGTkFBQUtKRkdC",
            "ShgOIAEoCBITCgtCSkVGS05PRFBITBgHIAEoDUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EJFLFKFJBJC), global::EggLink.DanhengServer.Proto.EJFLFKFJBJC.Parser, new[]{ "BNMEBOIINIO", "HOFFBHBJPNB", "FNAAAKJFGBJ", "BJEFKNODPHL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EJFLFKFJBJC : pb::IMessage<EJFLFKFJBJC>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EJFLFKFJBJC> _parser = new pb::MessageParser<EJFLFKFJBJC>(() => new EJFLFKFJBJC());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EJFLFKFJBJC> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EJFLFKFJBJCReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EJFLFKFJBJC() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EJFLFKFJBJC(EJFLFKFJBJC other) : this() {
      bNMEBOIINIO_ = other.bNMEBOIINIO_;
      hOFFBHBJPNB_ = other.hOFFBHBJPNB_;
      fNAAAKJFGBJ_ = other.fNAAAKJFGBJ_;
      bJEFKNODPHL_ = other.bJEFKNODPHL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EJFLFKFJBJC Clone() {
      return new EJFLFKFJBJC(this);
    }

    /// <summary>Field number for the "BNMEBOIINIO" field.</summary>
    public const int BNMEBOIINIOFieldNumber = 8;
    private uint bNMEBOIINIO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BNMEBOIINIO {
      get { return bNMEBOIINIO_; }
      set {
        bNMEBOIINIO_ = value;
      }
    }

    /// <summary>Field number for the "HOFFBHBJPNB" field.</summary>
    public const int HOFFBHBJPNBFieldNumber = 5;
    private uint hOFFBHBJPNB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HOFFBHBJPNB {
      get { return hOFFBHBJPNB_; }
      set {
        hOFFBHBJPNB_ = value;
      }
    }

    /// <summary>Field number for the "FNAAAKJFGBJ" field.</summary>
    public const int FNAAAKJFGBJFieldNumber = 14;
    private bool fNAAAKJFGBJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool FNAAAKJFGBJ {
      get { return fNAAAKJFGBJ_; }
      set {
        fNAAAKJFGBJ_ = value;
      }
    }

    /// <summary>Field number for the "BJEFKNODPHL" field.</summary>
    public const int BJEFKNODPHLFieldNumber = 7;
    private uint bJEFKNODPHL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BJEFKNODPHL {
      get { return bJEFKNODPHL_; }
      set {
        bJEFKNODPHL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EJFLFKFJBJC);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EJFLFKFJBJC other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BNMEBOIINIO != other.BNMEBOIINIO) return false;
      if (HOFFBHBJPNB != other.HOFFBHBJPNB) return false;
      if (FNAAAKJFGBJ != other.FNAAAKJFGBJ) return false;
      if (BJEFKNODPHL != other.BJEFKNODPHL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BNMEBOIINIO != 0) hash ^= BNMEBOIINIO.GetHashCode();
      if (HOFFBHBJPNB != 0) hash ^= HOFFBHBJPNB.GetHashCode();
      if (FNAAAKJFGBJ != false) hash ^= FNAAAKJFGBJ.GetHashCode();
      if (BJEFKNODPHL != 0) hash ^= BJEFKNODPHL.GetHashCode();
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
      if (HOFFBHBJPNB != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(HOFFBHBJPNB);
      }
      if (BJEFKNODPHL != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(BJEFKNODPHL);
      }
      if (BNMEBOIINIO != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(BNMEBOIINIO);
      }
      if (FNAAAKJFGBJ != false) {
        output.WriteRawTag(112);
        output.WriteBool(FNAAAKJFGBJ);
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
      if (HOFFBHBJPNB != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(HOFFBHBJPNB);
      }
      if (BJEFKNODPHL != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(BJEFKNODPHL);
      }
      if (BNMEBOIINIO != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(BNMEBOIINIO);
      }
      if (FNAAAKJFGBJ != false) {
        output.WriteRawTag(112);
        output.WriteBool(FNAAAKJFGBJ);
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
      if (BNMEBOIINIO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BNMEBOIINIO);
      }
      if (HOFFBHBJPNB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HOFFBHBJPNB);
      }
      if (FNAAAKJFGBJ != false) {
        size += 1 + 1;
      }
      if (BJEFKNODPHL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BJEFKNODPHL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EJFLFKFJBJC other) {
      if (other == null) {
        return;
      }
      if (other.BNMEBOIINIO != 0) {
        BNMEBOIINIO = other.BNMEBOIINIO;
      }
      if (other.HOFFBHBJPNB != 0) {
        HOFFBHBJPNB = other.HOFFBHBJPNB;
      }
      if (other.FNAAAKJFGBJ != false) {
        FNAAAKJFGBJ = other.FNAAAKJFGBJ;
      }
      if (other.BJEFKNODPHL != 0) {
        BJEFKNODPHL = other.BJEFKNODPHL;
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
          case 40: {
            HOFFBHBJPNB = input.ReadUInt32();
            break;
          }
          case 56: {
            BJEFKNODPHL = input.ReadUInt32();
            break;
          }
          case 64: {
            BNMEBOIINIO = input.ReadUInt32();
            break;
          }
          case 112: {
            FNAAAKJFGBJ = input.ReadBool();
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
          case 40: {
            HOFFBHBJPNB = input.ReadUInt32();
            break;
          }
          case 56: {
            BJEFKNODPHL = input.ReadUInt32();
            break;
          }
          case 64: {
            BNMEBOIINIO = input.ReadUInt32();
            break;
          }
          case 112: {
            FNAAAKJFGBJ = input.ReadBool();
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