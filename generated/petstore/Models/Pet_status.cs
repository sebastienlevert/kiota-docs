using System.Runtime.Serialization;
using System;
namespace PetStore.Models {
    /// <summary>Pet status in the store</summary>
    public enum Pet_status {
        [EnumMember(Value = "available")]
        Available,
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "sold")]
        Sold,
    }
}
