// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DLNHBHEHCHK.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DLNHBHEHCHK.proto</summary>
  public static partial class DLNHBHEHCHKReflection {

    #region Descriptor
    /// <summary>File descriptor for DLNHBHEHCHK.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DLNHBHEHCHKReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFETE5IQkhFSENISy5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIpEBCgtE",
            "TE5IQkhFSENISxISCgptaXJhY2xlX2lkGAwgASgNEiAKCWNvc3RfZGF0YRgB",
            "IAEoCzINLkl0ZW1Db3N0RGF0YRITCgtFR0ZDUFBHUEFLTRgCIAEoCBIiCgtO",
            "SUZFSklDTk5HTxgKIAEoCzINLkl0ZW1Db3N0RGF0YRITCgtMTkZHQ0lGUEhG",
            "RBgIIAEoCEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemCostDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DLNHBHEHCHK), global::EggLink.DanhengServer.Proto.DLNHBHEHCHK.Parser, new[]{ "MiracleId", "CostData", "EGFCPPGPAKM", "NIFEJICNNGO", "LNFGCIFPHFD" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DLNHBHEHCHK : pb::IMessage<DLNHBHEHCHK>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DLNHBHEHCHK> _parser = new pb::MessageParser<DLNHBHEHCHK>(() => new DLNHBHEHCHK());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DLNHBHEHCHK> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DLNHBHEHCHKReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DLNHBHEHCHK() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DLNHBHEHCHK(DLNHBHEHCHK other) : this() {
      miracleId_ = other.miracleId_;
      costData_ = other.costData_ != null ? other.costData_.Clone() : null;
      eGFCPPGPAKM_ = other.eGFCPPGPAKM_;
      nIFEJICNNGO_ = other.nIFEJICNNGO_ != null ? other.nIFEJICNNGO_.Clone() : null;
      lNFGCIFPHFD_ = other.lNFGCIFPHFD_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DLNHBHEHCHK Clone() {
      return new DLNHBHEHCHK(this);
    }

    /// <summary>Field number for the "miracle_id" field.</summary>
    public const int MiracleIdFieldNumber = 12;
    private uint miracleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MiracleId {
      get { return miracleId_; }
      set {
        miracleId_ = value;
      }
    }

    /// <summary>Field number for the "cost_data" field.</summary>
    public const int CostDataFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.ItemCostData costData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemCostData CostData {
      get { return costData_; }
      set {
        costData_ = value;
      }
    }

    /// <summary>Field number for the "EGFCPPGPAKM" field.</summary>
    public const int EGFCPPGPAKMFieldNumber = 2;
    private bool eGFCPPGPAKM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EGFCPPGPAKM {
      get { return eGFCPPGPAKM_; }
      set {
        eGFCPPGPAKM_ = value;
      }
    }

    /// <summary>Field number for the "NIFEJICNNGO" field.</summary>
    public const int NIFEJICNNGOFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.ItemCostData nIFEJICNNGO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemCostData NIFEJICNNGO {
      get { return nIFEJICNNGO_; }
      set {
        nIFEJICNNGO_ = value;
      }
    }

    /// <summary>Field number for the "LNFGCIFPHFD" field.</summary>
    public const int LNFGCIFPHFDFieldNumber = 8;
    private bool lNFGCIFPHFD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool LNFGCIFPHFD {
      get { return lNFGCIFPHFD_; }
      set {
        lNFGCIFPHFD_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DLNHBHEHCHK);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DLNHBHEHCHK other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MiracleId != other.MiracleId) return false;
      if (!object.Equals(CostData, other.CostData)) return false;
      if (EGFCPPGPAKM != other.EGFCPPGPAKM) return false;
      if (!object.Equals(NIFEJICNNGO, other.NIFEJICNNGO)) return false;
      if (LNFGCIFPHFD != other.LNFGCIFPHFD) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MiracleId != 0) hash ^= MiracleId.GetHashCode();
      if (costData_ != null) hash ^= CostData.GetHashCode();
      if (EGFCPPGPAKM != false) hash ^= EGFCPPGPAKM.GetHashCode();
      if (nIFEJICNNGO_ != null) hash ^= NIFEJICNNGO.GetHashCode();
      if (LNFGCIFPHFD != false) hash ^= LNFGCIFPHFD.GetHashCode();
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
      if (costData_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CostData);
      }
      if (EGFCPPGPAKM != false) {
        output.WriteRawTag(16);
        output.WriteBool(EGFCPPGPAKM);
      }
      if (LNFGCIFPHFD != false) {
        output.WriteRawTag(64);
        output.WriteBool(LNFGCIFPHFD);
      }
      if (nIFEJICNNGO_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(NIFEJICNNGO);
      }
      if (MiracleId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MiracleId);
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
      if (costData_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CostData);
      }
      if (EGFCPPGPAKM != false) {
        output.WriteRawTag(16);
        output.WriteBool(EGFCPPGPAKM);
      }
      if (LNFGCIFPHFD != false) {
        output.WriteRawTag(64);
        output.WriteBool(LNFGCIFPHFD);
      }
      if (nIFEJICNNGO_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(NIFEJICNNGO);
      }
      if (MiracleId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MiracleId);
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
      if (MiracleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MiracleId);
      }
      if (costData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CostData);
      }
      if (EGFCPPGPAKM != false) {
        size += 1 + 1;
      }
      if (nIFEJICNNGO_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NIFEJICNNGO);
      }
      if (LNFGCIFPHFD != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DLNHBHEHCHK other) {
      if (other == null) {
        return;
      }
      if (other.MiracleId != 0) {
        MiracleId = other.MiracleId;
      }
      if (other.costData_ != null) {
        if (costData_ == null) {
          CostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
        }
        CostData.MergeFrom(other.CostData);
      }
      if (other.EGFCPPGPAKM != false) {
        EGFCPPGPAKM = other.EGFCPPGPAKM;
      }
      if (other.nIFEJICNNGO_ != null) {
        if (nIFEJICNNGO_ == null) {
          NIFEJICNNGO = new global::EggLink.DanhengServer.Proto.ItemCostData();
        }
        NIFEJICNNGO.MergeFrom(other.NIFEJICNNGO);
      }
      if (other.LNFGCIFPHFD != false) {
        LNFGCIFPHFD = other.LNFGCIFPHFD;
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
            if (costData_ == null) {
              CostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(CostData);
            break;
          }
          case 16: {
            EGFCPPGPAKM = input.ReadBool();
            break;
          }
          case 64: {
            LNFGCIFPHFD = input.ReadBool();
            break;
          }
          case 82: {
            if (nIFEJICNNGO_ == null) {
              NIFEJICNNGO = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(NIFEJICNNGO);
            break;
          }
          case 96: {
            MiracleId = input.ReadUInt32();
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
            if (costData_ == null) {
              CostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(CostData);
            break;
          }
          case 16: {
            EGFCPPGPAKM = input.ReadBool();
            break;
          }
          case 64: {
            LNFGCIFPHFD = input.ReadBool();
            break;
          }
          case 82: {
            if (nIFEJICNNGO_ == null) {
              NIFEJICNNGO = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(NIFEJICNNGO);
            break;
          }
          case 96: {
            MiracleId = input.ReadUInt32();
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