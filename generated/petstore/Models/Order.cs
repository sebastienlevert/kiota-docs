using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace PetStore.Models {
    public class Order : IParsable {
        /// <summary>Indicates whenever order was completed or not</summary>
        public bool? Complete { get; private set; }
        /// <summary>Order ID</summary>
        public long? Id { get; set; }
        /// <summary>Pet ID</summary>
        public long? PetId { get; set; }
        /// <summary>The quantity property</summary>
        public int? Quantity { get; set; }
        /// <summary>Unique Request Id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestId { get; set; }
#nullable restore
#else
        public string RequestId { get; set; }
#endif
        /// <summary>Estimated ship date</summary>
        public DateTimeOffset? ShipDate { get; set; }
        /// <summary>Order Status</summary>
        public Order_status? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Order CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Order();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"complete", n => { Complete = n.GetBoolValue(); } },
                {"id", n => { Id = n.GetLongValue(); } },
                {"petId", n => { PetId = n.GetLongValue(); } },
                {"quantity", n => { Quantity = n.GetIntValue(); } },
                {"requestId", n => { RequestId = n.GetStringValue(); } },
                {"shipDate", n => { ShipDate = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<Order_status>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("id", Id);
            writer.WriteLongValue("petId", PetId);
            writer.WriteIntValue("quantity", Quantity);
            writer.WriteStringValue("requestId", RequestId);
            writer.WriteDateTimeOffsetValue("shipDate", ShipDate);
            writer.WriteEnumValue<Order_status>("status", Status);
        }
    }
}
