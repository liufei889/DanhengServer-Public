// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueCollectionStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueCollectionStatus.proto</summary>
  public static partial class RogueCollectionStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueCollectionStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueCollectionStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtSb2d1ZUNvbGxlY3Rpb25TdGF0dXMucHJvdG8qbwoVUm9ndWVDb2xsZWN0",
            "aW9uU3RhdHVzEhkKFVJPR1VFX0NPTExFQ1RJT05fTk9ORRAAEh0KGVJPR1VF",
            "X0NPTExFQ1RJT05fVU5MT0NLRUQQARIcChhST0dVRV9DT0xMRUNUSU9OX0RJ",
            "U1BMQVkQAkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.RogueCollectionStatus), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum RogueCollectionStatus {
    [pbr::OriginalName("ROGUE_COLLECTION_NONE")] RogueCollectionNone = 0,
    [pbr::OriginalName("ROGUE_COLLECTION_UNLOCKED")] RogueCollectionUnlocked = 1,
    [pbr::OriginalName("ROGUE_COLLECTION_DISPLAY")] RogueCollectionDisplay = 2,
  }

  #endregion

}

#endregion Designer generated code