// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QueryProductInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from QueryProductInfoScRsp.proto</summary>
  public static partial class QueryProductInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for QueryProductInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QueryProductInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtRdWVyeVByb2R1Y3RJbmZvU2NSc3AucHJvdG8aDVByb2R1Y3QucHJvdG8i",
            "kwEKFVF1ZXJ5UHJvZHVjdEluZm9TY1JzcBITCgtJR0VDRktIQUxHSRgLIAEo",
            "DRIPCgdyZXRjb2RlGAogASgNEhMKC0JFREtETkVMSERFGAMgASgNEiAKGG1v",
            "bnRoX2NhcmRfb3V0X2RhdGVfdGltZRgBIAEoBBIdCgtCTklKRElPT01JRhgH",
            "IAMoCzIILlByb2R1Y3RCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ProductReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.QueryProductInfoScRsp), global::EggLink.DanhengServer.Proto.QueryProductInfoScRsp.Parser, new[]{ "IGECFKHALGI", "Retcode", "BEDKDNELHDE", "MonthCardOutDateTime", "BNIJDIOOMIF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class QueryProductInfoScRsp : pb::IMessage<QueryProductInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QueryProductInfoScRsp> _parser = new pb::MessageParser<QueryProductInfoScRsp>(() => new QueryProductInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QueryProductInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.QueryProductInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryProductInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryProductInfoScRsp(QueryProductInfoScRsp other) : this() {
      iGECFKHALGI_ = other.iGECFKHALGI_;
      retcode_ = other.retcode_;
      bEDKDNELHDE_ = other.bEDKDNELHDE_;
      monthCardOutDateTime_ = other.monthCardOutDateTime_;
      bNIJDIOOMIF_ = other.bNIJDIOOMIF_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryProductInfoScRsp Clone() {
      return new QueryProductInfoScRsp(this);
    }

    /// <summary>Field number for the "IGECFKHALGI" field.</summary>
    public const int IGECFKHALGIFieldNumber = 11;
    private uint iGECFKHALGI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IGECFKHALGI {
      get { return iGECFKHALGI_; }
      set {
        iGECFKHALGI_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 10;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "BEDKDNELHDE" field.</summary>
    public const int BEDKDNELHDEFieldNumber = 3;
    private uint bEDKDNELHDE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BEDKDNELHDE {
      get { return bEDKDNELHDE_; }
      set {
        bEDKDNELHDE_ = value;
      }
    }

    /// <summary>Field number for the "month_card_out_date_time" field.</summary>
    public const int MonthCardOutDateTimeFieldNumber = 1;
    private ulong monthCardOutDateTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong MonthCardOutDateTime {
      get { return monthCardOutDateTime_; }
      set {
        monthCardOutDateTime_ = value;
      }
    }

    /// <summary>Field number for the "BNIJDIOOMIF" field.</summary>
    public const int BNIJDIOOMIFFieldNumber = 7;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Product> _repeated_bNIJDIOOMIF_codec
        = pb::FieldCodec.ForMessage(58, global::EggLink.DanhengServer.Proto.Product.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Product> bNIJDIOOMIF_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Product>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Product> BNIJDIOOMIF {
      get { return bNIJDIOOMIF_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QueryProductInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QueryProductInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IGECFKHALGI != other.IGECFKHALGI) return false;
      if (Retcode != other.Retcode) return false;
      if (BEDKDNELHDE != other.BEDKDNELHDE) return false;
      if (MonthCardOutDateTime != other.MonthCardOutDateTime) return false;
      if(!bNIJDIOOMIF_.Equals(other.bNIJDIOOMIF_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IGECFKHALGI != 0) hash ^= IGECFKHALGI.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (BEDKDNELHDE != 0) hash ^= BEDKDNELHDE.GetHashCode();
      if (MonthCardOutDateTime != 0UL) hash ^= MonthCardOutDateTime.GetHashCode();
      hash ^= bNIJDIOOMIF_.GetHashCode();
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
      if (MonthCardOutDateTime != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(MonthCardOutDateTime);
      }
      if (BEDKDNELHDE != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BEDKDNELHDE);
      }
      bNIJDIOOMIF_.WriteTo(output, _repeated_bNIJDIOOMIF_codec);
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      if (IGECFKHALGI != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(IGECFKHALGI);
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
      if (MonthCardOutDateTime != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(MonthCardOutDateTime);
      }
      if (BEDKDNELHDE != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BEDKDNELHDE);
      }
      bNIJDIOOMIF_.WriteTo(ref output, _repeated_bNIJDIOOMIF_codec);
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      if (IGECFKHALGI != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(IGECFKHALGI);
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
      if (IGECFKHALGI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IGECFKHALGI);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (BEDKDNELHDE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BEDKDNELHDE);
      }
      if (MonthCardOutDateTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(MonthCardOutDateTime);
      }
      size += bNIJDIOOMIF_.CalculateSize(_repeated_bNIJDIOOMIF_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QueryProductInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.IGECFKHALGI != 0) {
        IGECFKHALGI = other.IGECFKHALGI;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.BEDKDNELHDE != 0) {
        BEDKDNELHDE = other.BEDKDNELHDE;
      }
      if (other.MonthCardOutDateTime != 0UL) {
        MonthCardOutDateTime = other.MonthCardOutDateTime;
      }
      bNIJDIOOMIF_.Add(other.bNIJDIOOMIF_);
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
            MonthCardOutDateTime = input.ReadUInt64();
            break;
          }
          case 24: {
            BEDKDNELHDE = input.ReadUInt32();
            break;
          }
          case 58: {
            bNIJDIOOMIF_.AddEntriesFrom(input, _repeated_bNIJDIOOMIF_codec);
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 88: {
            IGECFKHALGI = input.ReadUInt32();
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
            MonthCardOutDateTime = input.ReadUInt64();
            break;
          }
          case 24: {
            BEDKDNELHDE = input.ReadUInt32();
            break;
          }
          case 58: {
            bNIJDIOOMIF_.AddEntriesFrom(ref input, _repeated_bNIJDIOOMIF_codec);
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 88: {
            IGECFKHALGI = input.ReadUInt32();
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