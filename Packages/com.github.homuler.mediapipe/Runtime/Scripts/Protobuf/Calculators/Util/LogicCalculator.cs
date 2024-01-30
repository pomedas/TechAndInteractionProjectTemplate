// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mediapipe/calculators/util/logic_calculator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mediapipe {

  /// <summary>Holder for reflection information generated from mediapipe/calculators/util/logic_calculator.proto</summary>
  public static partial class LogicCalculatorReflection {

    #region Descriptor
    /// <summary>File descriptor for mediapipe/calculators/util/logic_calculator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LogicCalculatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFtZWRpYXBpcGUvY2FsY3VsYXRvcnMvdXRpbC9sb2dpY19jYWxjdWxhdG9y",
            "LnByb3RvEgltZWRpYXBpcGUaJG1lZGlhcGlwZS9mcmFtZXdvcmsvY2FsY3Vs",
            "YXRvci5wcm90byLvAQoWTG9naWNDYWxjdWxhdG9yT3B0aW9ucxI3CgJvcBgB",
            "IAEoDjIrLm1lZGlhcGlwZS5Mb2dpY0NhbGN1bGF0b3JPcHRpb25zLk9wZXJh",
            "dGlvbhIOCgZuZWdhdGUYAiABKAgSEwoLaW5wdXRfdmFsdWUYAyADKAgiJQoJ",
            "T3BlcmF0aW9uEgcKA0FORBAAEgYKAk9SEAESBwoDWE9SEAIyUAoDZXh0Ehwu",
            "bWVkaWFwaXBlLkNhbGN1bGF0b3JPcHRpb25zGO7BwqEBIAEoCzIhLm1lZGlh",
            "cGlwZS5Mb2dpY0NhbGN1bGF0b3JPcHRpb25zQkQKJWNvbS5nb29nbGUubWVk",
            "aWFwaXBlLmNhbGN1bGF0b3IucHJvdG9CG0xvZ2ljQ2FsY3VsYXRvck9wdGlv",
            "bnNQcm90bw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Mediapipe.CalculatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mediapipe.LogicCalculatorOptions), global::Mediapipe.LogicCalculatorOptions.Parser, new[]{ "Op", "Negate", "InputValue" }, null, new[]{ typeof(global::Mediapipe.LogicCalculatorOptions.Types.Operation) }, new pb::Extension[] { global::Mediapipe.LogicCalculatorOptions.Extensions.Ext }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LogicCalculatorOptions : pb::IMessage<LogicCalculatorOptions>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LogicCalculatorOptions> _parser = new pb::MessageParser<LogicCalculatorOptions>(() => new LogicCalculatorOptions());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LogicCalculatorOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mediapipe.LogicCalculatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogicCalculatorOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogicCalculatorOptions(LogicCalculatorOptions other) : this() {
      _hasBits0 = other._hasBits0;
      op_ = other.op_;
      negate_ = other.negate_;
      inputValue_ = other.inputValue_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LogicCalculatorOptions Clone() {
      return new LogicCalculatorOptions(this);
    }

    /// <summary>Field number for the "op" field.</summary>
    public const int OpFieldNumber = 1;
    private readonly static global::Mediapipe.LogicCalculatorOptions.Types.Operation OpDefaultValue = global::Mediapipe.LogicCalculatorOptions.Types.Operation.And;

    private global::Mediapipe.LogicCalculatorOptions.Types.Operation op_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Mediapipe.LogicCalculatorOptions.Types.Operation Op {
      get { if ((_hasBits0 & 1) != 0) { return op_; } else { return OpDefaultValue; } }
      set {
        _hasBits0 |= 1;
        op_ = value;
      }
    }
    /// <summary>Gets whether the "op" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasOp {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "op" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearOp() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "negate" field.</summary>
    public const int NegateFieldNumber = 2;
    private readonly static bool NegateDefaultValue = false;

    private bool negate_;
    /// <summary>
    /// Whether to negate the result.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Negate {
      get { if ((_hasBits0 & 2) != 0) { return negate_; } else { return NegateDefaultValue; } }
      set {
        _hasBits0 |= 2;
        negate_ = value;
      }
    }
    /// <summary>Gets whether the "negate" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasNegate {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "negate" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearNegate() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "input_value" field.</summary>
    public const int InputValueFieldNumber = 3;
    private static readonly pb::FieldCodec<bool> _repeated_inputValue_codec
        = pb::FieldCodec.ForBool(24);
    private readonly pbc::RepeatedField<bool> inputValue_ = new pbc::RepeatedField<bool>();
    /// <summary>
    /// Optional bool input values.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<bool> InputValue {
      get { return inputValue_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LogicCalculatorOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LogicCalculatorOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Op != other.Op) return false;
      if (Negate != other.Negate) return false;
      if(!inputValue_.Equals(other.inputValue_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasOp) hash ^= Op.GetHashCode();
      if (HasNegate) hash ^= Negate.GetHashCode();
      hash ^= inputValue_.GetHashCode();
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
      if (HasOp) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Op);
      }
      if (HasNegate) {
        output.WriteRawTag(16);
        output.WriteBool(Negate);
      }
      inputValue_.WriteTo(output, _repeated_inputValue_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasOp) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Op);
      }
      if (HasNegate) {
        output.WriteRawTag(16);
        output.WriteBool(Negate);
      }
      inputValue_.WriteTo(ref output, _repeated_inputValue_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasOp) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Op);
      }
      if (HasNegate) {
        size += 1 + 1;
      }
      size += inputValue_.CalculateSize(_repeated_inputValue_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LogicCalculatorOptions other) {
      if (other == null) {
        return;
      }
      if (other.HasOp) {
        Op = other.Op;
      }
      if (other.HasNegate) {
        Negate = other.Negate;
      }
      inputValue_.Add(other.inputValue_);
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
            Op = (global::Mediapipe.LogicCalculatorOptions.Types.Operation) input.ReadEnum();
            break;
          }
          case 16: {
            Negate = input.ReadBool();
            break;
          }
          case 26:
          case 24: {
            inputValue_.AddEntriesFrom(input, _repeated_inputValue_codec);
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
            Op = (global::Mediapipe.LogicCalculatorOptions.Types.Operation) input.ReadEnum();
            break;
          }
          case 16: {
            Negate = input.ReadBool();
            break;
          }
          case 26:
          case 24: {
            inputValue_.AddEntriesFrom(ref input, _repeated_inputValue_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the LogicCalculatorOptions message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The logical operation to apply.
      /// </summary>
      public enum Operation {
        [pbr::OriginalName("AND")] And = 0,
        [pbr::OriginalName("OR")] Or = 1,
        [pbr::OriginalName("XOR")] Xor = 2,
      }

    }
    #endregion

    #region Extensions
    /// <summary>Container for extensions for other messages declared in the LogicCalculatorOptions message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Extensions {
      public static readonly pb::Extension<global::Mediapipe.CalculatorOptions, global::Mediapipe.LogicCalculatorOptions> Ext =
        new pb::Extension<global::Mediapipe.CalculatorOptions, global::Mediapipe.LogicCalculatorOptions>(338731246, pb::FieldCodec.ForMessage(2709849970, global::Mediapipe.LogicCalculatorOptions.Parser));
    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
