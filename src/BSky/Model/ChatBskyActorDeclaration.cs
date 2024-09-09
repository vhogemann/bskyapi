/*
 * AT Protocol XRPC API
 *
 * This section contains HTTP API reference docs for Bluesky and AT Protocol lexicons. Generate a bearer token to test API calls directly from the docs.
 *
 * The version of the OpenAPI document: 0.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = BSky.Client.OpenAPIDateConverter;

namespace BSky.Model
{
    /// <summary>
    /// ChatBskyActorDeclaration
    /// </summary>
    [DataContract(Name = "chat.bsky.actor.declaration")]
    public partial class ChatBskyActorDeclaration : IValidatableObject
    {
        /// <summary>
        /// Defines AllowIncoming
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AllowIncomingEnum
        {
            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 1,

            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 2,

            /// <summary>
            /// Enum Following for value: following
            /// </summary>
            [EnumMember(Value = "following")]
            Following = 3
        }


        /// <summary>
        /// Gets or Sets AllowIncoming
        /// </summary>
        [DataMember(Name = "allowIncoming", IsRequired = true, EmitDefaultValue = true)]
        public AllowIncomingEnum AllowIncoming { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBskyActorDeclaration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChatBskyActorDeclaration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBskyActorDeclaration" /> class.
        /// </summary>
        /// <param name="allowIncoming">allowIncoming (required).</param>
        public ChatBskyActorDeclaration(AllowIncomingEnum allowIncoming = default(AllowIncomingEnum))
        {
            this.AllowIncoming = allowIncoming;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChatBskyActorDeclaration {\n");
            sb.Append("  AllowIncoming: ").Append(AllowIncoming).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
