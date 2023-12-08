using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace PetStore.Store.Subscribe {
    public class SubscribePostRequestBody : IParsable {
        /// <summary>This URL will be called by the server when the desired event will occur</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallbackUrl { get; set; }
#nullable restore
#else
        public string CallbackUrl { get; set; }
#endif
        /// <summary>Event name for the subscription</summary>
        public SubscribePostRequestBody_eventName? EventName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SubscribePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubscribePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"callbackUrl", n => { CallbackUrl = n.GetStringValue(); } },
                {"eventName", n => { EventName = n.GetEnumValue<SubscribePostRequestBody_eventName>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("callbackUrl", CallbackUrl);
            writer.WriteEnumValue<SubscribePostRequestBody_eventName>("eventName", EventName);
        }
    }
}
