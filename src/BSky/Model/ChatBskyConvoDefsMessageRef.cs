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
    /// ChatBskyConvoDefsMessageRef
    /// </summary>
    [DataContract(Name = "chat.bsky.convo.defs.messageRef")]
    public partial class ChatBskyConvoDefsMessageRef : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBskyConvoDefsMessageRef" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChatBskyConvoDefsMessageRef() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBskyConvoDefsMessageRef" /> class.
        /// </summary>
        /// <param name="did">did (required).</param>
        /// <param name="convoId">convoId (required).</param>
        /// <param name="messageId">messageId (required).</param>
        public ChatBskyConvoDefsMessageRef(string did = default(string), string convoId = default(string), string messageId = default(string))
        {
            // to ensure "did" is required (not null)
            if (did == null)
            {
                throw new ArgumentNullException("did is a required property for ChatBskyConvoDefsMessageRef and cannot be null");
            }
            this.Did = did;
            // to ensure "convoId" is required (not null)
            if (convoId == null)
            {
                throw new ArgumentNullException("convoId is a required property for ChatBskyConvoDefsMessageRef and cannot be null");
            }
            this.ConvoId = convoId;
            // to ensure "messageId" is required (not null)
            if (messageId == null)
            {
                throw new ArgumentNullException("messageId is a required property for ChatBskyConvoDefsMessageRef and cannot be null");
            }
            this.MessageId = messageId;
        }

        /// <summary>
        /// Gets or Sets Did
        /// </summary>
        [DataMember(Name = "did", IsRequired = true, EmitDefaultValue = true)]
        public string Did { get; set; }

        /// <summary>
        /// Gets or Sets ConvoId
        /// </summary>
        [DataMember(Name = "convoId", IsRequired = true, EmitDefaultValue = true)]
        public string ConvoId { get; set; }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name = "messageId", IsRequired = true, EmitDefaultValue = true)]
        public string MessageId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChatBskyConvoDefsMessageRef {\n");
            sb.Append("  Did: ").Append(Did).Append("\n");
            sb.Append("  ConvoId: ").Append(ConvoId).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
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
