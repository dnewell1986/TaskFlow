namespace TaskFlow.Shared;

using System.Runtime.Serialization;

public enum Priority
{
    [EnumMember(Value = "None")]
    None = 0,
    [EnumMember(Value = "Low")]
    Low = 1,
    [EnumMember(Value = "Medium")]
    Medium = 2,
    [EnumMember(Value = "High")]
    High = 3
}
