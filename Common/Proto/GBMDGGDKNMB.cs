// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GBMDGGDKNMB.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GBMDGGDKNMB.proto</summary>
  public static partial class GBMDGGDKNMBReflection {

    #region Descriptor
    /// <summary>File descriptor for GBMDGGDKNMB.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GBMDGGDKNMBReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFHQk1ER0dES05NQi5wcm90byJYCgtHQk1ER0dES05NQhIPCgdidWZmX2lk",
            "GA4gASgNEg4KBmlzX3dpbhgFIAEoCBITCgtJR0tJR0ZCT0tDShgLIAEoDRIT",
            "CgtBT0FNTElMTENERxgHIAEoCEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GBMDGGDKNMB), global::EggLink.DanhengServer.Proto.GBMDGGDKNMB.Parser, new[]{ "BuffId", "IsWin", "IGKIGFBOKCJ", "AOAMLILLCDG" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GBMDGGDKNMB : pb::IMessage<GBMDGGDKNMB>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GBMDGGDKNMB> _parser = new pb::MessageParser<GBMDGGDKNMB>(() => new GBMDGGDKNMB());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GBMDGGDKNMB> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GBMDGGDKNMBReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GBMDGGDKNMB() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GBMDGGDKNMB(GBMDGGDKNMB other) : this() {
      buffId_ = other.buffId_;
      isWin_ = other.isWin_;
      iGKIGFBOKCJ_ = other.iGKIGFBOKCJ_;
      aOAMLILLCDG_ = other.aOAMLILLCDG_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GBMDGGDKNMB Clone() {
      return new GBMDGGDKNMB(this);
    }

    /// <summary>Field number for the "buff_id" field.</summary>
    public const int BuffIdFieldNumber = 14;
    private uint buffId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BuffId {
      get { return buffId_; }
      set {
        buffId_ = value;
      }
    }

    /// <summary>Field number for the "is_win" field.</summary>
    public const int IsWinFieldNumber = 5;
    private bool isWin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsWin {
      get { return isWin_; }
      set {
        isWin_ = value;
      }
    }

    /// <summary>Field number for the "IGKIGFBOKCJ" field.</summary>
    public const int IGKIGFBOKCJFieldNumber = 11;
    private uint iGKIGFBOKCJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IGKIGFBOKCJ {
      get { return iGKIGFBOKCJ_; }
      set {
        iGKIGFBOKCJ_ = value;
      }
    }

    /// <summary>Field number for the "AOAMLILLCDG" field.</summary>
    public const int AOAMLILLCDGFieldNumber = 7;
    private bool aOAMLILLCDG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool AOAMLILLCDG {
      get { return aOAMLILLCDG_; }
      set {
        aOAMLILLCDG_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GBMDGGDKNMB);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GBMDGGDKNMB other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BuffId != other.BuffId) return false;
      if (IsWin != other.IsWin) return false;
      if (IGKIGFBOKCJ != other.IGKIGFBOKCJ) return false;
      if (AOAMLILLCDG != other.AOAMLILLCDG) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BuffId != 0) hash ^= BuffId.GetHashCode();
      if (IsWin != false) hash ^= IsWin.GetHashCode();
      if (IGKIGFBOKCJ != 0) hash ^= IGKIGFBOKCJ.GetHashCode();
      if (AOAMLILLCDG != false) hash ^= AOAMLILLCDG.GetHashCode();
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
      if (IsWin != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsWin);
      }
      if (AOAMLILLCDG != false) {
        output.WriteRawTag(56);
        output.WriteBool(AOAMLILLCDG);
      }
      if (IGKIGFBOKCJ != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(IGKIGFBOKCJ);
      }
      if (BuffId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(BuffId);
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
      if (IsWin != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsWin);
      }
      if (AOAMLILLCDG != false) {
        output.WriteRawTag(56);
        output.WriteBool(AOAMLILLCDG);
      }
      if (IGKIGFBOKCJ != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(IGKIGFBOKCJ);
      }
      if (BuffId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(BuffId);
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
      if (BuffId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuffId);
      }
      if (IsWin != false) {
        size += 1 + 1;
      }
      if (IGKIGFBOKCJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IGKIGFBOKCJ);
      }
      if (AOAMLILLCDG != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GBMDGGDKNMB other) {
      if (other == null) {
        return;
      }
      if (other.BuffId != 0) {
        BuffId = other.BuffId;
      }
      if (other.IsWin != false) {
        IsWin = other.IsWin;
      }
      if (other.IGKIGFBOKCJ != 0) {
        IGKIGFBOKCJ = other.IGKIGFBOKCJ;
      }
      if (other.AOAMLILLCDG != false) {
        AOAMLILLCDG = other.AOAMLILLCDG;
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
            IsWin = input.ReadBool();
            break;
          }
          case 56: {
            AOAMLILLCDG = input.ReadBool();
            break;
          }
          case 88: {
            IGKIGFBOKCJ = input.ReadUInt32();
            break;
          }
          case 112: {
            BuffId = input.ReadUInt32();
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
            IsWin = input.ReadBool();
            break;
          }
          case 56: {
            AOAMLILLCDG = input.ReadBool();
            break;
          }
          case 88: {
            IGKIGFBOKCJ = input.ReadUInt32();
            break;
          }
          case 112: {
            BuffId = input.ReadUInt32();
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