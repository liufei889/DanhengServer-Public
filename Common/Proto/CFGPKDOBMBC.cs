// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CFGPKDOBMBC.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from CFGPKDOBMBC.proto</summary>
  public static partial class CFGPKDOBMBCReflection {

    #region Descriptor
    /// <summary>File descriptor for CFGPKDOBMBC.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CFGPKDOBMBCReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFDRkdQS0RPQk1CQy5wcm90bxoRQUtIQ0lQTVBNSkgucHJvdG8ibgoLQ0ZH",
            "UEtET0JNQkMSEwoLSFBJT0NJSEhHUEoYASABKA0SEgoKbW9uc3Rlcl9pZBgC",
            "IAEoDRIhCgtOR0lBSU9HR0xPTxgDIAMoCzIMLkFLSENJUE1QTUpIEhMKC0pE",
            "RUdIS0xLTEFIGAQgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AKHCIPMPMJHReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.CFGPKDOBMBC), global::EggLink.DanhengServer.Proto.CFGPKDOBMBC.Parser, new[]{ "HPIOCIHHGPJ", "MonsterId", "NGIAIOGGLOO", "JDEGHKLKLAH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CFGPKDOBMBC : pb::IMessage<CFGPKDOBMBC>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CFGPKDOBMBC> _parser = new pb::MessageParser<CFGPKDOBMBC>(() => new CFGPKDOBMBC());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CFGPKDOBMBC> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.CFGPKDOBMBCReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CFGPKDOBMBC() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CFGPKDOBMBC(CFGPKDOBMBC other) : this() {
      hPIOCIHHGPJ_ = other.hPIOCIHHGPJ_;
      monsterId_ = other.monsterId_;
      nGIAIOGGLOO_ = other.nGIAIOGGLOO_.Clone();
      jDEGHKLKLAH_ = other.jDEGHKLKLAH_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CFGPKDOBMBC Clone() {
      return new CFGPKDOBMBC(this);
    }

    /// <summary>Field number for the "HPIOCIHHGPJ" field.</summary>
    public const int HPIOCIHHGPJFieldNumber = 1;
    private uint hPIOCIHHGPJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HPIOCIHHGPJ {
      get { return hPIOCIHHGPJ_; }
      set {
        hPIOCIHHGPJ_ = value;
      }
    }

    /// <summary>Field number for the "monster_id" field.</summary>
    public const int MonsterIdFieldNumber = 2;
    private uint monsterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MonsterId {
      get { return monsterId_; }
      set {
        monsterId_ = value;
      }
    }

    /// <summary>Field number for the "NGIAIOGGLOO" field.</summary>
    public const int NGIAIOGGLOOFieldNumber = 3;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AKHCIPMPMJH> _repeated_nGIAIOGGLOO_codec
        = pb::FieldCodec.ForMessage(26, global::EggLink.DanhengServer.Proto.AKHCIPMPMJH.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AKHCIPMPMJH> nGIAIOGGLOO_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AKHCIPMPMJH>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AKHCIPMPMJH> NGIAIOGGLOO {
      get { return nGIAIOGGLOO_; }
    }

    /// <summary>Field number for the "JDEGHKLKLAH" field.</summary>
    public const int JDEGHKLKLAHFieldNumber = 4;
    private uint jDEGHKLKLAH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JDEGHKLKLAH {
      get { return jDEGHKLKLAH_; }
      set {
        jDEGHKLKLAH_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CFGPKDOBMBC);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CFGPKDOBMBC other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HPIOCIHHGPJ != other.HPIOCIHHGPJ) return false;
      if (MonsterId != other.MonsterId) return false;
      if(!nGIAIOGGLOO_.Equals(other.nGIAIOGGLOO_)) return false;
      if (JDEGHKLKLAH != other.JDEGHKLKLAH) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HPIOCIHHGPJ != 0) hash ^= HPIOCIHHGPJ.GetHashCode();
      if (MonsterId != 0) hash ^= MonsterId.GetHashCode();
      hash ^= nGIAIOGGLOO_.GetHashCode();
      if (JDEGHKLKLAH != 0) hash ^= JDEGHKLKLAH.GetHashCode();
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
      if (HPIOCIHHGPJ != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(HPIOCIHHGPJ);
      }
      if (MonsterId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MonsterId);
      }
      nGIAIOGGLOO_.WriteTo(output, _repeated_nGIAIOGGLOO_codec);
      if (JDEGHKLKLAH != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(JDEGHKLKLAH);
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
      if (HPIOCIHHGPJ != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(HPIOCIHHGPJ);
      }
      if (MonsterId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MonsterId);
      }
      nGIAIOGGLOO_.WriteTo(ref output, _repeated_nGIAIOGGLOO_codec);
      if (JDEGHKLKLAH != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(JDEGHKLKLAH);
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
      if (HPIOCIHHGPJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HPIOCIHHGPJ);
      }
      if (MonsterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MonsterId);
      }
      size += nGIAIOGGLOO_.CalculateSize(_repeated_nGIAIOGGLOO_codec);
      if (JDEGHKLKLAH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JDEGHKLKLAH);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CFGPKDOBMBC other) {
      if (other == null) {
        return;
      }
      if (other.HPIOCIHHGPJ != 0) {
        HPIOCIHHGPJ = other.HPIOCIHHGPJ;
      }
      if (other.MonsterId != 0) {
        MonsterId = other.MonsterId;
      }
      nGIAIOGGLOO_.Add(other.nGIAIOGGLOO_);
      if (other.JDEGHKLKLAH != 0) {
        JDEGHKLKLAH = other.JDEGHKLKLAH;
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
          case 8: {
            HPIOCIHHGPJ = input.ReadUInt32();
            break;
          }
          case 16: {
            MonsterId = input.ReadUInt32();
            break;
          }
          case 26: {
            nGIAIOGGLOO_.AddEntriesFrom(input, _repeated_nGIAIOGGLOO_codec);
            break;
          }
          case 32: {
            JDEGHKLKLAH = input.ReadUInt32();
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
          case 8: {
            HPIOCIHHGPJ = input.ReadUInt32();
            break;
          }
          case 16: {
            MonsterId = input.ReadUInt32();
            break;
          }
          case 26: {
            nGIAIOGGLOO_.AddEntriesFrom(ref input, _repeated_nGIAIOGGLOO_codec);
            break;
          }
          case 32: {
            JDEGHKLKLAH = input.ReadUInt32();
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