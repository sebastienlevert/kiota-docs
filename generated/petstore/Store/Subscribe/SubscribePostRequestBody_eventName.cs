using System.Runtime.Serialization;
using System;
namespace PetStore.Store.Subscribe {
    /// <summary>Event name for the subscription</summary>
    public enum SubscribePostRequestBody_eventName {
        [EnumMember(Value = "orderInProgress")]
        OrderInProgress,
        [EnumMember(Value = "orderShipped")]
        OrderShipped,
        [EnumMember(Value = "orderDelivered")]
        OrderDelivered,
    }
}
