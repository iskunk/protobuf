// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: protos/google/protobuf/field_presence_test.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Google.ProtocolBuffers.TestProtos.FieldPresence {

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class FieldPresenceTest {

    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_Google_ProtocolBuffers_TestProtos_FieldPresence_TestAllTypes__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes, global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Builder> internal__static_Google_ProtocolBuffers_TestProtos_FieldPresence_TestAllTypes__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_Google_ProtocolBuffers_TestProtos_FieldPresence_TestAllTypes_NestedMessage__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedMessage, global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedMessage.Builder> internal__static_Google_ProtocolBuffers_TestProtos_FieldPresence_TestAllTypes_NestedMessage__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;

    static FieldPresenceTest() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBwcm90b3MvZ29vZ2xlL3Byb3RvYnVmL2ZpZWxkX3ByZXNlbmNlX3Rlc3Qu", 
            "cHJvdG8SL0dvb2dsZS5Qcm90b2NvbEJ1ZmZlcnMuVGVzdFByb3Rvcy5GaWVs", 
            "ZFByZXNlbmNlIvYCCgxUZXN0QWxsVHlwZXMSFgoOb3B0aW9uYWxfaW50MzIY", 
            "ASABKAUSFwoPb3B0aW9uYWxfc3RyaW5nGAIgASgJEhYKDm9wdGlvbmFsX2J5", 
            "dGVzGAMgASgMEmYKFG9wdGlvbmFsX25lc3RlZF9lbnVtGAQgASgOMkguR29v", 
            "Z2xlLlByb3RvY29sQnVmZmVycy5UZXN0UHJvdG9zLkZpZWxkUHJlc2VuY2Uu", 
            "VGVzdEFsbFR5cGVzLk5lc3RlZEVudW0SbAoXb3B0aW9uYWxfbmVzdGVkX21l", 
            "c3NhZ2UYBSABKAsySy5Hb29nbGUuUHJvdG9jb2xCdWZmZXJzLlRlc3RQcm90", 
            "b3MuRmllbGRQcmVzZW5jZS5UZXN0QWxsVHlwZXMuTmVzdGVkTWVzc2FnZRoe", 
            "Cg1OZXN0ZWRNZXNzYWdlEg0KBXZhbHVlGAEgASgFIicKCk5lc3RlZEVudW0S", 
          "BwoDRk9PEAASBwoDQkFSEAESBwoDQkFaEAJiBnByb3RvMw=="));
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_Google_ProtocolBuffers_TestProtos_FieldPresence_TestAllTypes__Descriptor = Descriptor.MessageTypes[0];
        internal__static_Google_ProtocolBuffers_TestProtos_FieldPresence_TestAllTypes__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes, global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Builder>(internal__static_Google_ProtocolBuffers_TestProtos_FieldPresence_TestAllTypes__Descriptor,
                new string[] { "OptionalInt32", "OptionalString", "OptionalBytes", "OptionalNestedEnum", "OptionalNestedMessage", });
        internal__static_Google_ProtocolBuffers_TestProtos_FieldPresence_TestAllTypes_NestedMessage__Descriptor = internal__static_Google_ProtocolBuffers_TestProtos_FieldPresence_TestAllTypes__Descriptor.NestedTypes[0];
        internal__static_Google_ProtocolBuffers_TestProtos_FieldPresence_TestAllTypes_NestedMessage__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedMessage, global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedMessage.Builder>(internal__static_Google_ProtocolBuffers_TestProtos_FieldPresence_TestAllTypes_NestedMessage__Descriptor,
                new string[] { "Value", });
        pb::ExtensionRegistry registry = pb::ExtensionRegistry.CreateInstance();
        RegisterAllExtensions(registry);
        return registry;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          }, assigner);
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class TestAllTypes : pb::GeneratedMessage<TestAllTypes, TestAllTypes.Builder> {
    private TestAllTypes() { }
    private static readonly TestAllTypes defaultInstance = new TestAllTypes().MakeReadOnly();
    private static readonly string[] _testAllTypesFieldNames = new string[] { "optional_bytes", "optional_int32", "optional_nested_enum", "optional_nested_message", "optional_string" };
    private static readonly uint[] _testAllTypesFieldTags = new uint[] { 26, 8, 32, 42, 18 };
    public static TestAllTypes DefaultInstance {
      get { return defaultInstance; }
    }

    public override TestAllTypes DefaultInstanceForType {
      get { return DefaultInstance; }
    }

    protected override TestAllTypes ThisMessage {
      get { return this; }
    }

    public static pbd::MessageDescriptor Descriptor {
      get { return global::Google.ProtocolBuffers.TestProtos.FieldPresence.FieldPresenceTest.internal__static_Google_ProtocolBuffers_TestProtos_FieldPresence_TestAllTypes__Descriptor; }
    }

    protected override pb::FieldAccess.FieldAccessorTable<TestAllTypes, TestAllTypes.Builder> InternalFieldAccessors {
      get { return global::Google.ProtocolBuffers.TestProtos.FieldPresence.FieldPresenceTest.internal__static_Google_ProtocolBuffers_TestProtos_FieldPresence_TestAllTypes__FieldAccessorTable; }
    }

    #region Nested types
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum NestedEnum {
        FOO = 0,
        BAR = 1,
        BAZ = 2,
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class NestedMessage : pb::GeneratedMessage<NestedMessage, NestedMessage.Builder> {
        private NestedMessage() { }
        private static readonly NestedMessage defaultInstance = new NestedMessage().MakeReadOnly();
        private static readonly string[] _nestedMessageFieldNames = new string[] { "value" };
        private static readonly uint[] _nestedMessageFieldTags = new uint[] { 8 };
        public static NestedMessage DefaultInstance {
          get { return defaultInstance; }
        }

        public override NestedMessage DefaultInstanceForType {
          get { return DefaultInstance; }
        }

        protected override NestedMessage ThisMessage {
          get { return this; }
        }

        public static pbd::MessageDescriptor Descriptor {
          get { return global::Google.ProtocolBuffers.TestProtos.FieldPresence.FieldPresenceTest.internal__static_Google_ProtocolBuffers_TestProtos_FieldPresence_TestAllTypes_NestedMessage__Descriptor; }
        }

        protected override pb::FieldAccess.FieldAccessorTable<NestedMessage, NestedMessage.Builder> InternalFieldAccessors {
          get { return global::Google.ProtocolBuffers.TestProtos.FieldPresence.FieldPresenceTest.internal__static_Google_ProtocolBuffers_TestProtos_FieldPresence_TestAllTypes_NestedMessage__FieldAccessorTable; }
        }

        public const int ValueFieldNumber = 1;
        private int value_;
        public int Value {
          get { return value_; }
        }

        public override void WriteTo(pb::ICodedOutputStream output) {
          CalcSerializedSize();
          string[] field_names = _nestedMessageFieldNames;
          if (Value != 0) {
            output.WriteInt32(1, field_names[0], Value);
          }
          UnknownFields.WriteTo(output);
        }

        private int memoizedSerializedSize = -1;
        public override int SerializedSize {
          get {
            int size = memoizedSerializedSize;
            if (size != -1) return size;
            return CalcSerializedSize();
          }
        }

        private int CalcSerializedSize() {
          int size = memoizedSerializedSize;
          if (size != -1) return size;

          size = 0;
          if (Value != 0) {
            size += pb::CodedOutputStream.ComputeInt32Size(1, Value);
          }
          size += UnknownFields.SerializedSize;
          memoizedSerializedSize = size;
          return size;
        }
        public static NestedMessage ParseFrom(pb::ByteString data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }
        public static NestedMessage ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }
        public static NestedMessage ParseFrom(byte[] data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }
        public static NestedMessage ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }
        public static NestedMessage ParseFrom(global::System.IO.Stream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }
        public static NestedMessage ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }
        public static NestedMessage ParseDelimitedFrom(global::System.IO.Stream input) {
          return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }
        public static NestedMessage ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }
        public static NestedMessage ParseFrom(pb::ICodedInputStream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }
        public static NestedMessage ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }
        private NestedMessage MakeReadOnly() {
          return this;
        }

        public static Builder CreateBuilder() { return new Builder(); }
        public override Builder ToBuilder() { return CreateBuilder(this); }
        public override Builder CreateBuilderForType() { return new Builder(); }
        public static Builder CreateBuilder(NestedMessage prototype) {
          return new Builder(prototype);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed partial class Builder : pb::GeneratedBuilder<NestedMessage, Builder> {
          protected override Builder ThisBuilder {
            get { return this; }
          }
          public Builder() {
            result = DefaultInstance;
            resultIsReadOnly = true;
          }
          internal Builder(NestedMessage cloneFrom) {
            result = cloneFrom;
            resultIsReadOnly = true;
          }

          private bool resultIsReadOnly;
          private NestedMessage result;

          private NestedMessage PrepareBuilder() {
            if (resultIsReadOnly) {
              NestedMessage original = result;
              result = new NestedMessage();
              resultIsReadOnly = false;
              MergeFrom(original);
            }
            return result;
          }

          public override bool IsInitialized {
            get { return result.IsInitialized; }
          }

          protected override NestedMessage MessageBeingBuilt {
            get { return PrepareBuilder(); }
          }

          public override Builder Clear() {
            result = DefaultInstance;
            resultIsReadOnly = true;
            return this;
          }

          public override Builder Clone() {
            if (resultIsReadOnly) {
              return new Builder(result);
            } else {
              return new Builder().MergeFrom(result);
            }
          }

          public override pbd::MessageDescriptor DescriptorForType {
            get { return global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedMessage.Descriptor; }
          }

          public override NestedMessage DefaultInstanceForType {
            get { return global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedMessage.DefaultInstance; }
          }

          public override NestedMessage BuildPartial() {
            if (resultIsReadOnly) {
              return result;
            }
            resultIsReadOnly = true;
            return result.MakeReadOnly();
          }

          public override Builder MergeFrom(pb::IMessage other) {
            if (other is NestedMessage) {
              return MergeFrom((NestedMessage) other);
            } else {
              base.MergeFrom(other);
              return this;
            }
          }

          public override Builder MergeFrom(NestedMessage other) {
            if (other == global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedMessage.DefaultInstance) return this;
            PrepareBuilder();
            if (other.Value != 0) {
              Value = other.Value;
            }
            this.MergeUnknownFields(other.UnknownFields);
            return this;
          }

          public override Builder MergeFrom(pb::ICodedInputStream input) {
            return MergeFrom(input, pb::ExtensionRegistry.Empty);
          }

          public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
            PrepareBuilder();
            pb::UnknownFieldSet.Builder unknownFields = null;
            uint tag;
            string field_name;
            while (input.ReadTag(out tag, out field_name)) {
              if(tag == 0 && field_name != null) {
                int field_ordinal = global::System.Array.BinarySearch(_nestedMessageFieldNames, field_name, global::System.StringComparer.Ordinal);
                if(field_ordinal >= 0)
                  tag = _nestedMessageFieldTags[field_ordinal];
                else {
                  if (unknownFields == null) {
                    unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                  }
                  ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
                  continue;
                }
              }
              switch (tag) {
                case 0: {
                  throw pb::InvalidProtocolBufferException.InvalidTag();
                }
                default: {
                  if (pb::WireFormat.IsEndGroupTag(tag)) {
                    if (unknownFields != null) {
                      this.UnknownFields = unknownFields.Build();
                    }
                    return this;
                  }
                  if (unknownFields == null) {
                    unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                  }
                  ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
                  break;
                }
                case 8: {
                  input.ReadInt32(ref result.value_);
                  break;
                }
              }
            }

            if (unknownFields != null) {
              this.UnknownFields = unknownFields.Build();
            }
            return this;
          }


          public int Value {
            get { return result.Value; }
            set { SetValue(value); }
          }
          public Builder SetValue(int value) {
            PrepareBuilder();
            result.value_ = value;
            return this;
          }
          public Builder ClearValue() {
            PrepareBuilder();
            result.value_ = 0;
            return this;
          }
        }
        static NestedMessage() {
          object.ReferenceEquals(global::Google.ProtocolBuffers.TestProtos.FieldPresence.FieldPresenceTest.Descriptor, null);
        }
      }

    }
    #endregion

    public const int OptionalInt32FieldNumber = 1;
    private int optionalInt32_;
    public int OptionalInt32 {
      get { return optionalInt32_; }
    }

    public const int OptionalStringFieldNumber = 2;
    private string optionalString_ = "";
    public string OptionalString {
      get { return optionalString_; }
    }

    public const int OptionalBytesFieldNumber = 3;
    private pb::ByteString optionalBytes_ = pb::ByteString.Empty;
    public pb::ByteString OptionalBytes {
      get { return optionalBytes_; }
    }

    public const int OptionalNestedEnumFieldNumber = 4;
    private global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedEnum optionalNestedEnum_ = global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedEnum.FOO;
    public global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedEnum OptionalNestedEnum {
      get { return optionalNestedEnum_; }
    }

    public const int OptionalNestedMessageFieldNumber = 5;
    private bool hasOptionalNestedMessage;
    private global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedMessage optionalNestedMessage_;
    public bool HasOptionalNestedMessage {
      get { return hasOptionalNestedMessage; }
    }
    public global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedMessage OptionalNestedMessage {
      get { return optionalNestedMessage_ ?? global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedMessage.DefaultInstance; }
    }

    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _testAllTypesFieldNames;
      if (OptionalInt32 != 0) {
        output.WriteInt32(1, field_names[1], OptionalInt32);
      }
      if (OptionalString != "") {
        output.WriteString(2, field_names[4], OptionalString);
      }
      if (OptionalBytes != pb::ByteString.Empty) {
        output.WriteBytes(3, field_names[0], OptionalBytes);
      }
      if (OptionalNestedEnum != global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedEnum.FOO) {
        output.WriteEnum(4, field_names[2], (int) OptionalNestedEnum, OptionalNestedEnum);
      }
      if (hasOptionalNestedMessage) {
        output.WriteMessage(5, field_names[3], OptionalNestedMessage);
      }
      UnknownFields.WriteTo(output);
    }

    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        return CalcSerializedSize();
      }
    }

    private int CalcSerializedSize() {
      int size = memoizedSerializedSize;
      if (size != -1) return size;

      size = 0;
      if (OptionalInt32 != 0) {
        size += pb::CodedOutputStream.ComputeInt32Size(1, OptionalInt32);
      }
      if (OptionalString != "") {
        size += pb::CodedOutputStream.ComputeStringSize(2, OptionalString);
      }
      if (OptionalBytes != pb::ByteString.Empty) {
        size += pb::CodedOutputStream.ComputeBytesSize(3, OptionalBytes);
      }
      if (OptionalNestedEnum != global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedEnum.FOO) {
        size += pb::CodedOutputStream.ComputeEnumSize(4, (int) OptionalNestedEnum);
      }
      if (hasOptionalNestedMessage) {
        size += pb::CodedOutputStream.ComputeMessageSize(5, OptionalNestedMessage);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static TestAllTypes ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static TestAllTypes ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static TestAllTypes ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static TestAllTypes ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static TestAllTypes ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static TestAllTypes ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static TestAllTypes ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static TestAllTypes ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static TestAllTypes ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static TestAllTypes ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private TestAllTypes MakeReadOnly() {
      return this;
    }

    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(TestAllTypes prototype) {
      return new Builder(prototype);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<TestAllTypes, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(TestAllTypes cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

      private bool resultIsReadOnly;
      private TestAllTypes result;

      private TestAllTypes PrepareBuilder() {
        if (resultIsReadOnly) {
          TestAllTypes original = result;
          result = new TestAllTypes();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

      protected override TestAllTypes MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Descriptor; }
      }

      public override TestAllTypes DefaultInstanceForType {
        get { return global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.DefaultInstance; }
      }

      public override TestAllTypes BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

      public override Builder MergeFrom(pb::IMessage other) {
        if (other is TestAllTypes) {
          return MergeFrom((TestAllTypes) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

      public override Builder MergeFrom(TestAllTypes other) {
        if (other == global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.DefaultInstance) return this;
        PrepareBuilder();
        if (other.OptionalInt32 != 0) {
          OptionalInt32 = other.OptionalInt32;
        }
        if (other.OptionalString != "") {
          OptionalString = other.OptionalString;
        }
        if (other.OptionalBytes != pb::ByteString.Empty) {
          OptionalBytes = other.OptionalBytes;
        }
        if (other.OptionalNestedEnum != global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedEnum.FOO) {
          OptionalNestedEnum = other.OptionalNestedEnum;
        }
        if (other.HasOptionalNestedMessage) {
          MergeOptionalNestedMessage(other.OptionalNestedMessage);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }

      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_testAllTypesFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _testAllTypesFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 8: {
              input.ReadInt32(ref result.optionalInt32_);
              break;
            }
            case 18: {
              input.ReadString(ref result.optionalString_);
              break;
            }
            case 26: {
              input.ReadBytes(ref result.optionalBytes_);
              break;
            }
            case 32: {
              object unknown;
              if(input.ReadEnum(ref result.optionalNestedEnum_, out unknown)) {
              } else if(unknown is int) {
                if (unknownFields == null) {
                  unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                }
                unknownFields.MergeVarintField(4, (ulong)(int)unknown);
              }
              break;
            }
            case 42: {
              global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedMessage.Builder subBuilder = global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedMessage.CreateBuilder();
              if (result.hasOptionalNestedMessage) {
                subBuilder.MergeFrom(OptionalNestedMessage);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              OptionalNestedMessage = subBuilder.BuildPartial();
              break;
            }
          }
        }

        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }


      public int OptionalInt32 {
        get { return result.OptionalInt32; }
        set { SetOptionalInt32(value); }
      }
      public Builder SetOptionalInt32(int value) {
        PrepareBuilder();
        result.optionalInt32_ = value;
        return this;
      }
      public Builder ClearOptionalInt32() {
        PrepareBuilder();
        result.optionalInt32_ = 0;
        return this;
      }

      public string OptionalString {
        get { return result.OptionalString; }
        set { SetOptionalString(value); }
      }
      public Builder SetOptionalString(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.optionalString_ = value;
        return this;
      }
      public Builder ClearOptionalString() {
        PrepareBuilder();
        result.optionalString_ = "";
        return this;
      }

      public pb::ByteString OptionalBytes {
        get { return result.OptionalBytes; }
        set { SetOptionalBytes(value); }
      }
      public Builder SetOptionalBytes(pb::ByteString value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.optionalBytes_ = value;
        return this;
      }
      public Builder ClearOptionalBytes() {
        PrepareBuilder();
        result.optionalBytes_ = pb::ByteString.Empty;
        return this;
      }

      public global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedEnum OptionalNestedEnum {
        get { return result.OptionalNestedEnum; }
        set { SetOptionalNestedEnum(value); }
      }
      public Builder SetOptionalNestedEnum(global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedEnum value) {
        PrepareBuilder();
        result.optionalNestedEnum_ = value;
        return this;
      }
      public Builder ClearOptionalNestedEnum() {
        PrepareBuilder();
        result.optionalNestedEnum_ = global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedEnum.FOO;
        return this;
      }

      public bool HasOptionalNestedMessage {
       get { return result.hasOptionalNestedMessage; }
      }
      public global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedMessage OptionalNestedMessage {
        get { return result.OptionalNestedMessage; }
        set { SetOptionalNestedMessage(value); }
      }
      public Builder SetOptionalNestedMessage(global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasOptionalNestedMessage = true;
        result.optionalNestedMessage_ = value;
        return this;
      }
      public Builder SetOptionalNestedMessage(global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedMessage.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasOptionalNestedMessage = true;
        result.optionalNestedMessage_ = builderForValue.Build();
        return this;
      }
      public Builder MergeOptionalNestedMessage(global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedMessage value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasOptionalNestedMessage &&
            result.optionalNestedMessage_ != global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedMessage.DefaultInstance) {
            result.optionalNestedMessage_ = global::Google.ProtocolBuffers.TestProtos.FieldPresence.TestAllTypes.Types.NestedMessage.CreateBuilder(result.optionalNestedMessage_).MergeFrom(value).BuildPartial();
        } else {
          result.optionalNestedMessage_ = value;
        }
        result.hasOptionalNestedMessage = true;
        return this;
      }
      public Builder ClearOptionalNestedMessage() {
        PrepareBuilder();
        result.hasOptionalNestedMessage = false;
        result.optionalNestedMessage_ = null;
        return this;
      }
    }
    static TestAllTypes() {
      object.ReferenceEquals(global::Google.ProtocolBuffers.TestProtos.FieldPresence.FieldPresenceTest.Descriptor, null);
    }
  }

  #endregion

}

#endregion Designer generated code
