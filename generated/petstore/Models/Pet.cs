using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace PetStore.Models {
    public class Pet : IParsable {
        /// <summary>Categories this pet belongs to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PetStore.Models.Category? Category { get; set; }
#nullable restore
#else
        public PetStore.Models.Category Category { get; set; }
#endif
        /// <summary>The friend property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Pet? Friend { get; set; }
#nullable restore
#else
        public Pet Friend { get; set; }
#endif
        /// <summary>Pet ID</summary>
        public long? Id { get; set; }
        /// <summary>The name given to a pet</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Type of a pet</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PetType { get; set; }
#nullable restore
#else
        public string PetType { get; set; }
#endif
        /// <summary>The list of URL to a cute photos featuring pet</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PhotoUrls { get; set; }
#nullable restore
#else
        public List<string> PhotoUrls { get; set; }
#endif
        /// <summary>Pet status in the store</summary>
        public Pet_status? Status { get; set; }
        /// <summary>Tags attached to the pet</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Tag>? Tags { get; set; }
#nullable restore
#else
        public List<Tag> Tags { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Pet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("petType")?.GetStringValue();
            return mappingValue switch {
                "bee" => new HoneyBee(),
                "cat" => new Cat(),
                "dog" => new Dog(),
                _ => new Pet(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"category", n => { Category = n.GetObjectValue<PetStore.Models.Category>(PetStore.Models.Category.CreateFromDiscriminatorValue); } },
                {"friend", n => { Friend = n.GetObjectValue<Pet>(Pet.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetLongValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"petType", n => { PetType = n.GetStringValue(); } },
                {"photoUrls", n => { PhotoUrls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"status", n => { Status = n.GetEnumValue<Pet_status>(); } },
                {"tags", n => { Tags = n.GetCollectionOfObjectValues<Tag>(Tag.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PetStore.Models.Category>("category", Category);
            writer.WriteObjectValue<Pet>("friend", Friend);
            writer.WriteLongValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("petType", PetType);
            writer.WriteCollectionOfPrimitiveValues<string>("photoUrls", PhotoUrls);
            writer.WriteEnumValue<Pet_status>("status", Status);
            writer.WriteCollectionOfObjectValues<Tag>("tags", Tags);
        }
    }
}
