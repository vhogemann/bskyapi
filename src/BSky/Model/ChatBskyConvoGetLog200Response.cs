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
    /// ChatBskyConvoGetLog200Response
    /// </summary>
    [DataContract(Name = "chat_bsky_convo_getLog_200_response")]
    public partial class ChatBskyConvoGetLog200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBskyConvoGetLog200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChatBskyConvoGetLog200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBskyConvoGetLog200Response" /> class.
        /// </summary>
        /// <param name="cursor">cursor.</param>
        /// <param name="logs">logs (required).</param>
        public ChatBskyConvoGetLog200Response(string cursor = default(string), List<ChatBskyConvoGetLog200ResponseLogsInner> logs = default(List<ChatBskyConvoGetLog200ResponseLogsInner>))
        {
            // to ensure "logs" is required (not null)
            if (logs == null)
            {
                throw new ArgumentNullException("logs is a required property for ChatBskyConvoGetLog200Response and cannot be null");
            }
            this.Logs = logs;
            this.Cursor = cursor;
        }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        public string Cursor { get; set; }

        /// <summary>
        /// Gets or Sets Logs
        /// </summary>
        [DataMember(Name = "logs", IsRequired = true, EmitDefaultValue = true)]
        public List<ChatBskyConvoGetLog200ResponseLogsInner> Logs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChatBskyConvoGetLog200Response {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  Logs: ").Append(Logs).Append("\n");
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
