// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BPGMBAJHNHA.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BPGMBAJHNHA.proto</summary>
  public static partial class BPGMBAJHNHAReflection {

    #region Descriptor
    /// <summary>File descriptor for BPGMBAJHNHA.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BPGMBAJHNHAReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFCUEdNQkFKSE5IQS5wcm90byI3CgtCUEdNQkFKSE5IQRITCgtHQkxHRFBQ",
            "SUZQRRgLIAEoDRITCgtGT09ETENCR0VLUBgNIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.BPGMBAJHNHA), global::EggLink.DanhengServer.Proto.BPGMBAJHNHA.Parser, new[]{ "GBLGDPPIFPE", "FOODLCBGEKP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BPGMBAJHNHA : pb::IMessage<BPGMBAJHNHA>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BPGMBAJHNHA> _parser = new pb::MessageParser<BPGMBAJHNHA>(() => new BPGMBAJHNHA());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BPGMBAJHNHA> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.BPGMBAJHNHAReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BPGMBAJHNHA() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BPGMBAJHNHA(BPGMBAJHNHA other) : this() {
      gBLGDPPIFPE_ = other.gBLGDPPIFPE_;
      fOODLCBGEKP_ = other.fOODLCBGEKP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BPGMBAJHNHA Clone() {
      return new BPGMBAJHNHA(this);
    }

    /// <summary>Field number for the "GBLGDPPIFPE" field.</summary>
    public const int GBLGDPPIFPEFieldNumber = 11;
    private uint gBLGDPPIFPE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GBLGDPPIFPE {
      get { return gBLGDPPIFPE_; }
      set {
        gBLGDPPIFPE_ = value;
      }
    }

    /// <summary>Field number for the "FOODLCBGEKP" field.</summary>
    public const int FOODLCBGEKPFieldNumber = 13;
    private uint fOODLCBGEKP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FOODLCBGEKP {
      get { return fOODLCBGEKP_; }
      set {
        fOODLCBGEKP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BPGMBAJHNHA);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BPGMBAJHNHA other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GBLGDPPIFPE != other.GBLGDPPIFPE) return false;
      if (FOODLCBGEKP != other.FOODLCBGEKP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GBLGDPPIFPE != 0) hash ^= GBLGDPPIFPE.GetHashCode();
      if (FOODLCBGEKP != 0) hash ^= FOODLCBGEKP.GetHashCode();
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
      if (GBLGDPPIFPE != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GBLGDPPIFPE);
      }
      if (FOODLCBGEKP != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(FOODLCBGEKP);
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
      if (GBLGDPPIFPE != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GBLGDPPIFPE);
      }
      if (FOODLCBGEKP != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(FOODLCBGEKP);
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
      if (GBLGDPPIFPE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GBLGDPPIFPE);
      }
      if (FOODLCBGEKP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FOODLCBGEKP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BPGMBAJHNHA other) {
      if (other == null) {
        return;
      }
      if (other.GBLGDPPIFPE != 0) {
        GBLGDPPIFPE = other.GBLGDPPIFPE;
      }
      if (other.FOODLCBGEKP != 0) {
        FOODLCBGEKP = other.FOODLCBGEKP;
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
          case 88: {
            GBLGDPPIFPE = input.ReadUInt32();
            break;
          }
          case 104: {
            FOODLCBGEKP = input.ReadUInt32();
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
          case 88: {
            GBLGDPPIFPE = input.ReadUInt32();
            break;
          }
          case 104: {
            FOODLCBGEKP = input.ReadUInt32();
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