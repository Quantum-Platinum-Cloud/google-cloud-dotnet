// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/websecurityscanner/v1/scan_run.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.WebSecurityScanner.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/websecurityscanner/v1/scan_run.proto</summary>
  public static partial class ScanRunReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/websecurityscanner/v1/scan_run.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ScanRunReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvY2xvdWQvd2Vic2VjdXJpdHlzY2FubmVyL3YxL3NjYW5fcnVu",
            "LnByb3RvEiJnb29nbGUuY2xvdWQud2Vic2VjdXJpdHlzY2FubmVyLnYxGj1n",
            "b29nbGUvY2xvdWQvd2Vic2VjdXJpdHlzY2FubmVyL3YxL3NjYW5fcnVuX2Vy",
            "cm9yX3RyYWNlLnByb3RvGj9nb29nbGUvY2xvdWQvd2Vic2VjdXJpdHlzY2Fu",
            "bmVyL3YxL3NjYW5fcnVuX3dhcm5pbmdfdHJhY2UucHJvdG8aH2dvb2dsZS9w",
            "cm90b2J1Zi90aW1lc3RhbXAucHJvdG8i0AUKB1NjYW5SdW4SDAoEbmFtZRgB",
            "IAEoCRJTCg9leGVjdXRpb25fc3RhdGUYAiABKA4yOi5nb29nbGUuY2xvdWQu",
            "d2Vic2VjdXJpdHlzY2FubmVyLnYxLlNjYW5SdW4uRXhlY3V0aW9uU3RhdGUS",
            "TQoMcmVzdWx0X3N0YXRlGAMgASgOMjcuZ29vZ2xlLmNsb3VkLndlYnNlY3Vy",
            "aXR5c2Nhbm5lci52MS5TY2FuUnVuLlJlc3VsdFN0YXRlEi4KCnN0YXJ0X3Rp",
            "bWUYBCABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wEiwKCGVuZF90",
            "aW1lGAUgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBIaChJ1cmxz",
            "X2NyYXdsZWRfY291bnQYBiABKAMSGQoRdXJsc190ZXN0ZWRfY291bnQYByAB",
            "KAMSGwoTaGFzX3Z1bG5lcmFiaWxpdGllcxgIIAEoCBIYChBwcm9ncmVzc19w",
            "ZXJjZW50GAkgASgFEkoKC2Vycm9yX3RyYWNlGAogASgLMjUuZ29vZ2xlLmNs",
            "b3VkLndlYnNlY3VyaXR5c2Nhbm5lci52MS5TY2FuUnVuRXJyb3JUcmFjZRJP",
            "Cg53YXJuaW5nX3RyYWNlcxgLIAMoCzI3Lmdvb2dsZS5jbG91ZC53ZWJzZWN1",
            "cml0eXNjYW5uZXIudjEuU2NhblJ1bldhcm5pbmdUcmFjZSJZCg5FeGVjdXRp",
            "b25TdGF0ZRIfChtFWEVDVVRJT05fU1RBVEVfVU5TUEVDSUZJRUQQABIKCgZR",
            "VUVVRUQQARIMCghTQ0FOTklORxACEgwKCEZJTklTSEVEEAMiTwoLUmVzdWx0",
            "U3RhdGUSHAoYUkVTVUxUX1NUQVRFX1VOU1BFQ0lGSUVEEAASCwoHU1VDQ0VT",
            "UxABEgkKBUVSUk9SEAISCgoGS0lMTEVEEANCgAIKJmNvbS5nb29nbGUuY2xv",
            "dWQud2Vic2VjdXJpdHlzY2FubmVyLnYxQgxTY2FuUnVuUHJvdG9QAVpUZ29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC93ZWJz",
            "ZWN1cml0eXNjYW5uZXIvdjE7d2Vic2VjdXJpdHlzY2FubmVyqgIiR29vZ2xl",
            "LkNsb3VkLldlYlNlY3VyaXR5U2Nhbm5lci5WMcoCIkdvb2dsZVxDbG91ZFxX",
            "ZWJTZWN1cml0eVNjYW5uZXJcVjHqAiVHb29nbGU6OkNsb3VkOjpXZWJTZWN1",
            "cml0eVNjYW5uZXI6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.WebSecurityScanner.V1.ScanRunErrorTraceReflection.Descriptor, global::Google.Cloud.WebSecurityScanner.V1.ScanRunWarningTraceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.WebSecurityScanner.V1.ScanRun), global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Parser, new[]{ "Name", "ExecutionState", "ResultState", "StartTime", "EndTime", "UrlsCrawledCount", "UrlsTestedCount", "HasVulnerabilities", "ProgressPercent", "ErrorTrace", "WarningTraces" }, null, new[]{ typeof(global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ExecutionState), typeof(global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ResultState) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A ScanRun is a output-only resource representing an actual run of the scan.
  /// Next id: 12
  /// </summary>
  public sealed partial class ScanRun : pb::IMessage<ScanRun>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ScanRun> _parser = new pb::MessageParser<ScanRun>(() => new ScanRun());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ScanRun> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.WebSecurityScanner.V1.ScanRunReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScanRun() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScanRun(ScanRun other) : this() {
      name_ = other.name_;
      executionState_ = other.executionState_;
      resultState_ = other.resultState_;
      startTime_ = other.startTime_ != null ? other.startTime_.Clone() : null;
      endTime_ = other.endTime_ != null ? other.endTime_.Clone() : null;
      urlsCrawledCount_ = other.urlsCrawledCount_;
      urlsTestedCount_ = other.urlsTestedCount_;
      hasVulnerabilities_ = other.hasVulnerabilities_;
      progressPercent_ = other.progressPercent_;
      errorTrace_ = other.errorTrace_ != null ? other.errorTrace_.Clone() : null;
      warningTraces_ = other.warningTraces_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScanRun Clone() {
      return new ScanRun(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. The resource name of the ScanRun. The name follows the format of
    /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
    /// The ScanRun IDs are generated by the system.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "execution_state" field.</summary>
    public const int ExecutionStateFieldNumber = 2;
    private global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ExecutionState executionState_ = global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ExecutionState.Unspecified;
    /// <summary>
    /// Output only. The execution state of the ScanRun.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ExecutionState ExecutionState {
      get { return executionState_; }
      set {
        executionState_ = value;
      }
    }

    /// <summary>Field number for the "result_state" field.</summary>
    public const int ResultStateFieldNumber = 3;
    private global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ResultState resultState_ = global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ResultState.Unspecified;
    /// <summary>
    /// Output only. The result state of the ScanRun. This field is only available after the
    /// execution state reaches "FINISHED".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ResultState ResultState {
      get { return resultState_; }
      set {
        resultState_ = value;
      }
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp startTime_;
    /// <summary>
    /// Output only. The time at which the ScanRun started.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp endTime_;
    /// <summary>
    /// Output only. The time at which the ScanRun reached termination state - that the ScanRun
    /// is either finished or stopped by user.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    /// <summary>Field number for the "urls_crawled_count" field.</summary>
    public const int UrlsCrawledCountFieldNumber = 6;
    private long urlsCrawledCount_;
    /// <summary>
    /// Output only. The number of URLs crawled during this ScanRun. If the scan is in progress,
    /// the value represents the number of URLs crawled up to now.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long UrlsCrawledCount {
      get { return urlsCrawledCount_; }
      set {
        urlsCrawledCount_ = value;
      }
    }

    /// <summary>Field number for the "urls_tested_count" field.</summary>
    public const int UrlsTestedCountFieldNumber = 7;
    private long urlsTestedCount_;
    /// <summary>
    /// Output only. The number of URLs tested during this ScanRun. If the scan is in progress,
    /// the value represents the number of URLs tested up to now. The number of
    /// URLs tested is usually larger than the number URLS crawled because
    /// typically a crawled URL is tested with multiple test payloads.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long UrlsTestedCount {
      get { return urlsTestedCount_; }
      set {
        urlsTestedCount_ = value;
      }
    }

    /// <summary>Field number for the "has_vulnerabilities" field.</summary>
    public const int HasVulnerabilitiesFieldNumber = 8;
    private bool hasVulnerabilities_;
    /// <summary>
    /// Output only. Whether the scan run has found any vulnerabilities.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasVulnerabilities {
      get { return hasVulnerabilities_; }
      set {
        hasVulnerabilities_ = value;
      }
    }

    /// <summary>Field number for the "progress_percent" field.</summary>
    public const int ProgressPercentFieldNumber = 9;
    private int progressPercent_;
    /// <summary>
    /// Output only. The percentage of total completion ranging from 0 to 100.
    /// If the scan is in queue, the value is 0.
    /// If the scan is running, the value ranges from 0 to 100.
    /// If the scan is finished, the value is 100.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ProgressPercent {
      get { return progressPercent_; }
      set {
        progressPercent_ = value;
      }
    }

    /// <summary>Field number for the "error_trace" field.</summary>
    public const int ErrorTraceFieldNumber = 10;
    private global::Google.Cloud.WebSecurityScanner.V1.ScanRunErrorTrace errorTrace_;
    /// <summary>
    /// Output only. If result_state is an ERROR, this field provides the primary reason for
    /// scan's termination and more details, if such are available.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.WebSecurityScanner.V1.ScanRunErrorTrace ErrorTrace {
      get { return errorTrace_; }
      set {
        errorTrace_ = value;
      }
    }

    /// <summary>Field number for the "warning_traces" field.</summary>
    public const int WarningTracesFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Google.Cloud.WebSecurityScanner.V1.ScanRunWarningTrace> _repeated_warningTraces_codec
        = pb::FieldCodec.ForMessage(90, global::Google.Cloud.WebSecurityScanner.V1.ScanRunWarningTrace.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.WebSecurityScanner.V1.ScanRunWarningTrace> warningTraces_ = new pbc::RepeatedField<global::Google.Cloud.WebSecurityScanner.V1.ScanRunWarningTrace>();
    /// <summary>
    /// Output only. A list of warnings, if such are encountered during this scan run.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.WebSecurityScanner.V1.ScanRunWarningTrace> WarningTraces {
      get { return warningTraces_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ScanRun);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ScanRun other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (ExecutionState != other.ExecutionState) return false;
      if (ResultState != other.ResultState) return false;
      if (!object.Equals(StartTime, other.StartTime)) return false;
      if (!object.Equals(EndTime, other.EndTime)) return false;
      if (UrlsCrawledCount != other.UrlsCrawledCount) return false;
      if (UrlsTestedCount != other.UrlsTestedCount) return false;
      if (HasVulnerabilities != other.HasVulnerabilities) return false;
      if (ProgressPercent != other.ProgressPercent) return false;
      if (!object.Equals(ErrorTrace, other.ErrorTrace)) return false;
      if(!warningTraces_.Equals(other.warningTraces_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (ExecutionState != global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ExecutionState.Unspecified) hash ^= ExecutionState.GetHashCode();
      if (ResultState != global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ResultState.Unspecified) hash ^= ResultState.GetHashCode();
      if (startTime_ != null) hash ^= StartTime.GetHashCode();
      if (endTime_ != null) hash ^= EndTime.GetHashCode();
      if (UrlsCrawledCount != 0L) hash ^= UrlsCrawledCount.GetHashCode();
      if (UrlsTestedCount != 0L) hash ^= UrlsTestedCount.GetHashCode();
      if (HasVulnerabilities != false) hash ^= HasVulnerabilities.GetHashCode();
      if (ProgressPercent != 0) hash ^= ProgressPercent.GetHashCode();
      if (errorTrace_ != null) hash ^= ErrorTrace.GetHashCode();
      hash ^= warningTraces_.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (ExecutionState != global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ExecutionState.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ExecutionState);
      }
      if (ResultState != global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ResultState.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ResultState);
      }
      if (startTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(StartTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(EndTime);
      }
      if (UrlsCrawledCount != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(UrlsCrawledCount);
      }
      if (UrlsTestedCount != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(UrlsTestedCount);
      }
      if (HasVulnerabilities != false) {
        output.WriteRawTag(64);
        output.WriteBool(HasVulnerabilities);
      }
      if (ProgressPercent != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(ProgressPercent);
      }
      if (errorTrace_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(ErrorTrace);
      }
      warningTraces_.WriteTo(output, _repeated_warningTraces_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (ExecutionState != global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ExecutionState.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ExecutionState);
      }
      if (ResultState != global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ResultState.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ResultState);
      }
      if (startTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(StartTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(EndTime);
      }
      if (UrlsCrawledCount != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(UrlsCrawledCount);
      }
      if (UrlsTestedCount != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(UrlsTestedCount);
      }
      if (HasVulnerabilities != false) {
        output.WriteRawTag(64);
        output.WriteBool(HasVulnerabilities);
      }
      if (ProgressPercent != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(ProgressPercent);
      }
      if (errorTrace_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(ErrorTrace);
      }
      warningTraces_.WriteTo(ref output, _repeated_warningTraces_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (ExecutionState != global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ExecutionState.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ExecutionState);
      }
      if (ResultState != global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ResultState.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ResultState);
      }
      if (startTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartTime);
      }
      if (endTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EndTime);
      }
      if (UrlsCrawledCount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UrlsCrawledCount);
      }
      if (UrlsTestedCount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UrlsTestedCount);
      }
      if (HasVulnerabilities != false) {
        size += 1 + 1;
      }
      if (ProgressPercent != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ProgressPercent);
      }
      if (errorTrace_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ErrorTrace);
      }
      size += warningTraces_.CalculateSize(_repeated_warningTraces_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ScanRun other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.ExecutionState != global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ExecutionState.Unspecified) {
        ExecutionState = other.ExecutionState;
      }
      if (other.ResultState != global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ResultState.Unspecified) {
        ResultState = other.ResultState;
      }
      if (other.startTime_ != null) {
        if (startTime_ == null) {
          StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        StartTime.MergeFrom(other.StartTime);
      }
      if (other.endTime_ != null) {
        if (endTime_ == null) {
          EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        EndTime.MergeFrom(other.EndTime);
      }
      if (other.UrlsCrawledCount != 0L) {
        UrlsCrawledCount = other.UrlsCrawledCount;
      }
      if (other.UrlsTestedCount != 0L) {
        UrlsTestedCount = other.UrlsTestedCount;
      }
      if (other.HasVulnerabilities != false) {
        HasVulnerabilities = other.HasVulnerabilities;
      }
      if (other.ProgressPercent != 0) {
        ProgressPercent = other.ProgressPercent;
      }
      if (other.errorTrace_ != null) {
        if (errorTrace_ == null) {
          ErrorTrace = new global::Google.Cloud.WebSecurityScanner.V1.ScanRunErrorTrace();
        }
        ErrorTrace.MergeFrom(other.ErrorTrace);
      }
      warningTraces_.Add(other.warningTraces_);
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
            Name = input.ReadString();
            break;
          }
          case 16: {
            ExecutionState = (global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ExecutionState) input.ReadEnum();
            break;
          }
          case 24: {
            ResultState = (global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ResultState) input.ReadEnum();
            break;
          }
          case 34: {
            if (startTime_ == null) {
              StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 42: {
            if (endTime_ == null) {
              EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
          case 48: {
            UrlsCrawledCount = input.ReadInt64();
            break;
          }
          case 56: {
            UrlsTestedCount = input.ReadInt64();
            break;
          }
          case 64: {
            HasVulnerabilities = input.ReadBool();
            break;
          }
          case 72: {
            ProgressPercent = input.ReadInt32();
            break;
          }
          case 82: {
            if (errorTrace_ == null) {
              ErrorTrace = new global::Google.Cloud.WebSecurityScanner.V1.ScanRunErrorTrace();
            }
            input.ReadMessage(ErrorTrace);
            break;
          }
          case 90: {
            warningTraces_.AddEntriesFrom(input, _repeated_warningTraces_codec);
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
            Name = input.ReadString();
            break;
          }
          case 16: {
            ExecutionState = (global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ExecutionState) input.ReadEnum();
            break;
          }
          case 24: {
            ResultState = (global::Google.Cloud.WebSecurityScanner.V1.ScanRun.Types.ResultState) input.ReadEnum();
            break;
          }
          case 34: {
            if (startTime_ == null) {
              StartTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 42: {
            if (endTime_ == null) {
              EndTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EndTime);
            break;
          }
          case 48: {
            UrlsCrawledCount = input.ReadInt64();
            break;
          }
          case 56: {
            UrlsTestedCount = input.ReadInt64();
            break;
          }
          case 64: {
            HasVulnerabilities = input.ReadBool();
            break;
          }
          case 72: {
            ProgressPercent = input.ReadInt32();
            break;
          }
          case 82: {
            if (errorTrace_ == null) {
              ErrorTrace = new global::Google.Cloud.WebSecurityScanner.V1.ScanRunErrorTrace();
            }
            input.ReadMessage(ErrorTrace);
            break;
          }
          case 90: {
            warningTraces_.AddEntriesFrom(ref input, _repeated_warningTraces_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ScanRun message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Types of ScanRun execution state.
      /// </summary>
      public enum ExecutionState {
        /// <summary>
        /// Represents an invalid state caused by internal server error. This value
        /// should never be returned.
        /// </summary>
        [pbr::OriginalName("EXECUTION_STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The scan is waiting in the queue.
        /// </summary>
        [pbr::OriginalName("QUEUED")] Queued = 1,
        /// <summary>
        /// The scan is in progress.
        /// </summary>
        [pbr::OriginalName("SCANNING")] Scanning = 2,
        /// <summary>
        /// The scan is either finished or stopped by user.
        /// </summary>
        [pbr::OriginalName("FINISHED")] Finished = 3,
      }

      /// <summary>
      /// Types of ScanRun result state.
      /// </summary>
      public enum ResultState {
        /// <summary>
        /// Default value. This value is returned when the ScanRun is not yet
        /// finished.
        /// </summary>
        [pbr::OriginalName("RESULT_STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The scan finished without errors.
        /// </summary>
        [pbr::OriginalName("SUCCESS")] Success = 1,
        /// <summary>
        /// The scan finished with errors.
        /// </summary>
        [pbr::OriginalName("ERROR")] Error = 2,
        /// <summary>
        /// The scan was terminated by user.
        /// </summary>
        [pbr::OriginalName("KILLED")] Killed = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
