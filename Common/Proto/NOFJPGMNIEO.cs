// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NOFJPGMNIEO.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from NOFJPGMNIEO.proto</summary>
  public static partial class NOFJPGMNIEOReflection {

    #region Descriptor
    /// <summary>File descriptor for NOFJPGMNIEO.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NOFJPGMNIEOReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFOT0ZKUEdNTklFTy5wcm90bxoRTkNPSVBKSkFOQU4ucHJvdG8ijwEKC05P",
            "RkpQR01OSUVPEg8KB2FyZWFfaWQYBSABKA0SIQoLRFBJSkJESEhPTE8YAyAD",
            "KAsyDC5OQ09JUEpKQU5BThITCgtDTENHTFBETkJJSRgGIAEoDRITCgtLQ0xG",
            "TkhCSEpCQRgBIAEoDRINCgVsZXZlbBgOIAEoDRITCgtFR05HSUFEQ05MUBgE",
            "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.NCOIPJJANANReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.NOFJPGMNIEO), global::EggLink.DanhengServer.Proto.NOFJPGMNIEO.Parser, new[]{ "AreaId", "DPIJBDHHOLO", "CLCGLPDNBII", "KCLFNHBHJBA", "Level", "EGNGIADCNLP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class NOFJPGMNIEO : pb::IMessage<NOFJPGMNIEO>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NOFJPGMNIEO> _parser = new pb::MessageParser<NOFJPGMNIEO>(() => new NOFJPGMNIEO());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NOFJPGMNIEO> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.NOFJPGMNIEOReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NOFJPGMNIEO() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NOFJPGMNIEO(NOFJPGMNIEO other) : this() {
      areaId_ = other.areaId_;
      dPIJBDHHOLO_ = other.dPIJBDHHOLO_.Clone();
      cLCGLPDNBII_ = other.cLCGLPDNBII_;
      kCLFNHBHJBA_ = other.kCLFNHBHJBA_;
      level_ = other.level_;
      eGNGIADCNLP_ = other.eGNGIADCNLP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NOFJPGMNIEO Clone() {
      return new NOFJPGMNIEO(this);
    }

    /// <summary>Field number for the "area_id" field.</summary>
    public const int AreaIdFieldNumber = 5;
    private uint areaId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AreaId {
      get { return areaId_; }
      set {
        areaId_ = value;
      }
    }

    /// <summary>Field number for the "DPIJBDHHOLO" field.</summary>
    public const int DPIJBDHHOLOFieldNumber = 3;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.NCOIPJJANAN> _repeated_dPIJBDHHOLO_codec
        = pb::FieldCodec.ForMessage(26, global::EggLink.DanhengServer.Proto.NCOIPJJANAN.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.NCOIPJJANAN> dPIJBDHHOLO_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.NCOIPJJANAN>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.NCOIPJJANAN> DPIJBDHHOLO {
      get { return dPIJBDHHOLO_; }
    }

    /// <summary>Field number for the "CLCGLPDNBII" field.</summary>
    public const int CLCGLPDNBIIFieldNumber = 6;
    private uint cLCGLPDNBII_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CLCGLPDNBII {
      get { return cLCGLPDNBII_; }
      set {
        cLCGLPDNBII_ = value;
      }
    }

    /// <summary>Field number for the "KCLFNHBHJBA" field.</summary>
    public const int KCLFNHBHJBAFieldNumber = 1;
    private uint kCLFNHBHJBA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KCLFNHBHJBA {
      get { return kCLFNHBHJBA_; }
      set {
        kCLFNHBHJBA_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 14;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "EGNGIADCNLP" field.</summary>
    public const int EGNGIADCNLPFieldNumber = 4;
    private uint eGNGIADCNLP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EGNGIADCNLP {
      get { return eGNGIADCNLP_; }
      set {
        eGNGIADCNLP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NOFJPGMNIEO);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NOFJPGMNIEO other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AreaId != other.AreaId) return false;
      if(!dPIJBDHHOLO_.Equals(other.dPIJBDHHOLO_)) return false;
      if (CLCGLPDNBII != other.CLCGLPDNBII) return false;
      if (KCLFNHBHJBA != other.KCLFNHBHJBA) return false;
      if (Level != other.Level) return false;
      if (EGNGIADCNLP != other.EGNGIADCNLP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AreaId != 0) hash ^= AreaId.GetHashCode();
      hash ^= dPIJBDHHOLO_.GetHashCode();
      if (CLCGLPDNBII != 0) hash ^= CLCGLPDNBII.GetHashCode();
      if (KCLFNHBHJBA != 0) hash ^= KCLFNHBHJBA.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (EGNGIADCNLP != 0) hash ^= EGNGIADCNLP.GetHashCode();
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
      if (KCLFNHBHJBA != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(KCLFNHBHJBA);
      }
      dPIJBDHHOLO_.WriteTo(output, _repeated_dPIJBDHHOLO_codec);
      if (EGNGIADCNLP != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(EGNGIADCNLP);
      }
      if (AreaId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(AreaId);
      }
      if (CLCGLPDNBII != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CLCGLPDNBII);
      }
      if (Level != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Level);
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
      if (KCLFNHBHJBA != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(KCLFNHBHJBA);
      }
      dPIJBDHHOLO_.WriteTo(ref output, _repeated_dPIJBDHHOLO_codec);
      if (EGNGIADCNLP != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(EGNGIADCNLP);
      }
      if (AreaId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(AreaId);
      }
      if (CLCGLPDNBII != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CLCGLPDNBII);
      }
      if (Level != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Level);
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
      if (AreaId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AreaId);
      }
      size += dPIJBDHHOLO_.CalculateSize(_repeated_dPIJBDHHOLO_codec);
      if (CLCGLPDNBII != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CLCGLPDNBII);
      }
      if (KCLFNHBHJBA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KCLFNHBHJBA);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (EGNGIADCNLP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EGNGIADCNLP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NOFJPGMNIEO other) {
      if (other == null) {
        return;
      }
      if (other.AreaId != 0) {
        AreaId = other.AreaId;
      }
      dPIJBDHHOLO_.Add(other.dPIJBDHHOLO_);
      if (other.CLCGLPDNBII != 0) {
        CLCGLPDNBII = other.CLCGLPDNBII;
      }
      if (other.KCLFNHBHJBA != 0) {
        KCLFNHBHJBA = other.KCLFNHBHJBA;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.EGNGIADCNLP != 0) {
        EGNGIADCNLP = other.EGNGIADCNLP;
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
            KCLFNHBHJBA = input.ReadUInt32();
            break;
          }
          case 26: {
            dPIJBDHHOLO_.AddEntriesFrom(input, _repeated_dPIJBDHHOLO_codec);
            break;
          }
          case 32: {
            EGNGIADCNLP = input.ReadUInt32();
            break;
          }
          case 40: {
            AreaId = input.ReadUInt32();
            break;
          }
          case 48: {
            CLCGLPDNBII = input.ReadUInt32();
            break;
          }
          case 112: {
            Level = input.ReadUInt32();
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
            KCLFNHBHJBA = input.ReadUInt32();
            break;
          }
          case 26: {
            dPIJBDHHOLO_.AddEntriesFrom(ref input, _repeated_dPIJBDHHOLO_codec);
            break;
          }
          case 32: {
            EGNGIADCNLP = input.ReadUInt32();
            break;
          }
          case 40: {
            AreaId = input.ReadUInt32();
            break;
          }
          case 48: {
            CLCGLPDNBII = input.ReadUInt32();
            break;
          }
          case 112: {
            Level = input.ReadUInt32();
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