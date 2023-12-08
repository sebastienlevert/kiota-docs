using System.Runtime.Serialization;
using System;
namespace PetStore.Models {
    /// <summary>Order Status</summary>
    public enum Order_status {
        [EnumMember(Value = "placed")]
        Placed,
        [EnumMember(Value = "approved")]
        Approved,
        [EnumMember(Value = "delivered")]
        Delivered,
    }
}
