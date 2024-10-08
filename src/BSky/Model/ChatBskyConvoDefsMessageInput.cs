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
    /// ChatBskyConvoDefsMessageInput
    /// </summary>
    [DataContract(Name = "chat.bsky.convo.defs.messageInput")]
    public partial class ChatBskyConvoDefsMessageInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBskyConvoDefsMessageInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChatBskyConvoDefsMessageInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBskyConvoDefsMessageInput" /> class.
        /// </summary>
        /// <param name="text">text (required).</param>
        /// <param name="facets">facets.</param>
        /// <param name="embed">embed.</param>
        public ChatBskyConvoDefsMessageInput(string text = default(string), List<AppBskyRichtextFacet> facets = default(List<AppBskyRichtextFacet>), ChatBskyConvoDefsMessageInputEmbed embed = default(ChatBskyConvoDefsMessageInputEmbed))
        {
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new ArgumentNullException("text is a required property for ChatBskyConvoDefsMessageInput and cannot be null");
            }
            this.Text = text;
            this.Facets = facets;
            this.Embed = embed;
        }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Facets
        /// </summary>
        [DataMember(Name = "facets", EmitDefaultValue = false)]
        public List<AppBskyRichtextFacet> Facets { get; set; }

        /// <summary>
        /// Gets or Sets Embed
        /// </summary>
        [DataMember(Name = "embed", EmitDefaultValue = false)]
        public ChatBskyConvoDefsMessageInputEmbed Embed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChatBskyConvoDefsMessageInput {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Facets: ").Append(Facets).Append("\n");
            sb.Append("  Embed: ").Append(Embed).Append("\n");
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
            // Text (string) maxLength
            if (this.Text != null && this.Text.Length > 10000)
            {
                yield return new ValidationResult("Invalid value for Text, length must be less than 10000.", new [] { "Text" });
            }

            yield break;
        }
    }

}
