// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueWorkbenchHandleFuncCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueWorkbenchHandleFuncCsReq.proto</summary>
  public static partial class RogueWorkbenchHandleFuncCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueWorkbenchHandleFuncCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueWorkbenchHandleFuncCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNSb2d1ZVdvcmtiZW5jaEhhbmRsZUZ1bmNDc1JlcS5wcm90bxoRSE1OSkpP",
            "UE9PQ0cucHJvdG8ibwodUm9ndWVXb3JrYmVuY2hIYW5kbGVGdW5jQ3NSZXES",
            "EwoLRUFKSUpKT0ZIS0wYCCABKA0SIQoLSUhQTEJOSkZGQkkYBCABKAsyDC5I",
            "TU5KSk9QT09DRxIWCg5wcm9wX2VudGl0eV9pZBgCIAEoDUIeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HMNJJOPOOCGReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueWorkbenchHandleFuncCsReq), global::EggLink.DanhengServer.Proto.RogueWorkbenchHandleFuncCsReq.Parser, new[]{ "EAJIJJOFHKL", "IHPLBNJFFBI", "PropEntityId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueWorkbenchHandleFuncCsReq : pb::IMessage<RogueWorkbenchHandleFuncCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueWorkbenchHandleFuncCsReq> _parser = new pb::MessageParser<RogueWorkbenchHandleFuncCsReq>(() => new RogueWorkbenchHandleFuncCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueWorkbenchHandleFuncCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueWorkbenchHandleFuncCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueWorkbenchHandleFuncCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueWorkbenchHandleFuncCsReq(RogueWorkbenchHandleFuncCsReq other) : this() {
      eAJIJJOFHKL_ = other.eAJIJJOFHKL_;
      iHPLBNJFFBI_ = other.iHPLBNJFFBI_ != null ? other.iHPLBNJFFBI_.Clone() : null;
      propEntityId_ = other.propEntityId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueWorkbenchHandleFuncCsReq Clone() {
      return new RogueWorkbenchHandleFuncCsReq(this);
    }

    /// <summary>Field number for the "EAJIJJOFHKL" field.</summary>
    public const int EAJIJJOFHKLFieldNumber = 8;
    private uint eAJIJJOFHKL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EAJIJJOFHKL {
      get { return eAJIJJOFHKL_; }
      set {
        eAJIJJOFHKL_ = value;
      }
    }

    /// <summary>Field number for the "IHPLBNJFFBI" field.</summary>
    public const int IHPLBNJFFBIFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.HMNJJOPOOCG iHPLBNJFFBI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HMNJJOPOOCG IHPLBNJFFBI {
      get { return iHPLBNJFFBI_; }
      set {
        iHPLBNJFFBI_ = value;
      }
    }

    /// <summary>Field number for the "prop_entity_id" field.</summary>
    public const int PropEntityIdFieldNumber = 2;
    private uint propEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PropEntityId {
      get { return propEntityId_; }
      set {
        propEntityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueWorkbenchHandleFuncCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueWorkbenchHandleFuncCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EAJIJJOFHKL != other.EAJIJJOFHKL) return false;
      if (!object.Equals(IHPLBNJFFBI, other.IHPLBNJFFBI)) return false;
      if (PropEntityId != other.PropEntityId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EAJIJJOFHKL != 0) hash ^= EAJIJJOFHKL.GetHashCode();
      if (iHPLBNJFFBI_ != null) hash ^= IHPLBNJFFBI.GetHashCode();
      if (PropEntityId != 0) hash ^= PropEntityId.GetHashCode();
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
      if (PropEntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(PropEntityId);
      }
      if (iHPLBNJFFBI_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(IHPLBNJFFBI);
      }
      if (EAJIJJOFHKL != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(EAJIJJOFHKL);
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
      if (PropEntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(PropEntityId);
      }
      if (iHPLBNJFFBI_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(IHPLBNJFFBI);
      }
      if (EAJIJJOFHKL != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(EAJIJJOFHKL);
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
      if (EAJIJJOFHKL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EAJIJJOFHKL);
      }
      if (iHPLBNJFFBI_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IHPLBNJFFBI);
      }
      if (PropEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PropEntityId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueWorkbenchHandleFuncCsReq other) {
      if (other == null) {
        return;
      }
      if (other.EAJIJJOFHKL != 0) {
        EAJIJJOFHKL = other.EAJIJJOFHKL;
      }
      if (other.iHPLBNJFFBI_ != null) {
        if (iHPLBNJFFBI_ == null) {
          IHPLBNJFFBI = new global::EggLink.DanhengServer.Proto.HMNJJOPOOCG();
        }
        IHPLBNJFFBI.MergeFrom(other.IHPLBNJFFBI);
      }
      if (other.PropEntityId != 0) {
        PropEntityId = other.PropEntityId;
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
          case 16: {
            PropEntityId = input.ReadUInt32();
            break;
          }
          case 34: {
            if (iHPLBNJFFBI_ == null) {
              IHPLBNJFFBI = new global::EggLink.DanhengServer.Proto.HMNJJOPOOCG();
            }
            input.ReadMessage(IHPLBNJFFBI);
            break;
          }
          case 64: {
            EAJIJJOFHKL = input.ReadUInt32();
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
          case 16: {
            PropEntityId = input.ReadUInt32();
            break;
          }
          case 34: {
            if (iHPLBNJFFBI_ == null) {
              IHPLBNJFFBI = new global::EggLink.DanhengServer.Proto.HMNJJOPOOCG();
            }
            input.ReadMessage(IHPLBNJFFBI);
            break;
          }
          case 64: {
            EAJIJJOFHKL = input.ReadUInt32();
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