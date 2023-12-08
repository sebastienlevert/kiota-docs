using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace PetStore.Models {
    public class User : IParsable {
        /// <summary>User email address</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>User first name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirstName { get; set; }
#nullable restore
#else
        public string FirstName { get; set; }
#endif
        /// <summary>The id property</summary>
        public long? Id { get; private set; }
        /// <summary>User last name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastName { get; set; }
#nullable restore
#else
        public string LastName { get; set; }
#endif
        /// <summary>User password, MUST contain a mix of upper and lower case letters, as well as digits</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Password { get; set; }
#nullable restore
#else
        public string Password { get; set; }
#endif
        /// <summary>The pet property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserWrapper? Pet { get; set; }
#nullable restore
#else
        public UserWrapper Pet { get; set; }
#endif
        /// <summary>User phone number in international format</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone { get; set; }
#nullable restore
#else
        public string Phone { get; set; }
#endif
        /// <summary>User supplied username</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Username { get; set; }
#nullable restore
#else
        public string Username { get; set; }
#endif
        /// <summary>User status</summary>
        public int? UserStatus { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static User CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new User();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"email", n => { Email = n.GetStringValue(); } },
                {"firstName", n => { FirstName = n.GetStringValue(); } },
                {"id", n => { Id = n.GetLongValue(); } },
                {"lastName", n => { LastName = n.GetStringValue(); } },
                {"password", n => { Password = n.GetStringValue(); } },
                {"pet", n => { Pet = n.GetObjectValue<UserWrapper>(UserWrapper.CreateFromDiscriminatorValue); } },
                {"phone", n => { Phone = n.GetStringValue(); } },
                {"username", n => { Username = n.GetStringValue(); } },
                {"userStatus", n => { UserStatus = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("firstName", FirstName);
            writer.WriteStringValue("lastName", LastName);
            writer.WriteStringValue("password", Password);
            writer.WriteObjectValue<UserWrapper>("pet", Pet);
            writer.WriteStringValue("phone", Phone);
            writer.WriteStringValue("username", Username);
            writer.WriteIntValue("userStatus", UserStatus);
        }
        /// <summary>
        /// Composed type wrapper for classes Pet, Tag
        /// </summary>
        public class UserWrapper : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type Pet</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public PetStore.Models.Pet? Pet { get; set; }
#nullable restore
#else
            public PetStore.Models.Pet Pet { get; set; }
#endif
            /// <summary>Composed type representation for type Tag</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public PetStore.Models.Tag? Tag { get; set; }
#nullable restore
#else
            public PetStore.Models.Tag Tag { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static UserWrapper CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("petType")?.GetStringValue();
                var result = new UserWrapper();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.Pet = new PetStore.Models.Pet();
                }
                else if("Tag".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.Tag = new PetStore.Models.Tag();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(Pet != null) {
                    return Pet.GetFieldDeserializers();
                }
                else if(Tag != null) {
                    return Tag.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(Pet != null) {
                    writer.WriteObjectValue<PetStore.Models.Pet>(null, Pet);
                }
                else if(Tag != null) {
                    writer.WriteObjectValue<PetStore.Models.Tag>(null, Tag);
                }
            }
        }
    }
}
