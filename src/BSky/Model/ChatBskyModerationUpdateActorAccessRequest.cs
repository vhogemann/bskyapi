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
    /// ChatBskyModerationUpdateActorAccessRequest
    /// </summary>
    [DataContract(Name = "chat_bsky_moderation_updateActorAccess_request")]
    public partial class ChatBskyModerationUpdateActorAccessRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBskyModerationUpdateActorAccessRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChatBskyModerationUpdateActorAccessRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBskyModerationUpdateActorAccessRequest" /> class.
        /// </summary>
        /// <param name="actor">actor (required).</param>
        /// <param name="allowAccess">allowAccess (required).</param>
        /// <param name="varRef">varRef.</param>
        public ChatBskyModerationUpdateActorAccessRequest(string actor = default(string), bool allowAccess = default(bool), string varRef = default(string))
        {
            // to ensure "actor" is required (not null)
            if (actor == null)
            {
                throw new ArgumentNullException("actor is a required property for ChatBskyModerationUpdateActorAccessRequest and cannot be null");
            }
            this.Actor = actor;
            this.AllowAccess = allowAccess;
            this.Ref = varRef;
        }

        /// <summary>
        /// Gets or Sets Actor
        /// </summary>
        [DataMember(Name = "actor", IsRequired = true, EmitDefaultValue = true)]
        public string Actor { get; set; }

        /// <summary>
        /// Gets or Sets AllowAccess
        /// </summary>
        [DataMember(Name = "allowAccess", IsRequired = true, EmitDefaultValue = true)]
        public bool AllowAccess { get; set; }

        /// <summary>
        /// Gets or Sets Ref
        /// </summary>
        [DataMember(Name = "ref", EmitDefaultValue = false)]
        public string Ref { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChatBskyModerationUpdateActorAccessRequest {\n");
            sb.Append("  Actor: ").Append(Actor).Append("\n");
            sb.Append("  AllowAccess: ").Append(AllowAccess).Append("\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
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