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
    /// AppBskyGraphGetFollows200Response
    /// </summary>
    [DataContract(Name = "app_bsky_graph_getFollows_200_response")]
    public partial class AppBskyGraphGetFollows200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyGraphGetFollows200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyGraphGetFollows200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyGraphGetFollows200Response" /> class.
        /// </summary>
        /// <param name="subject">subject (required).</param>
        /// <param name="cursor">cursor.</param>
        /// <param name="follows">follows (required).</param>
        public AppBskyGraphGetFollows200Response(AppBskyActorDefsProfileView subject = default(AppBskyActorDefsProfileView), string cursor = default(string), List<AppBskyActorDefsProfileView> follows = default(List<AppBskyActorDefsProfileView>))
        {
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new ArgumentNullException("subject is a required property for AppBskyGraphGetFollows200Response and cannot be null");
            }
            this.Subject = subject;
            // to ensure "follows" is required (not null)
            if (follows == null)
            {
                throw new ArgumentNullException("follows is a required property for AppBskyGraphGetFollows200Response and cannot be null");
            }
            this.Follows = follows;
            this.Cursor = cursor;
        }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", IsRequired = true, EmitDefaultValue = true)]
        public AppBskyActorDefsProfileView Subject { get; set; }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        public string Cursor { get; set; }

        /// <summary>
        /// Gets or Sets Follows
        /// </summary>
        [DataMember(Name = "follows", IsRequired = true, EmitDefaultValue = true)]
        public List<AppBskyActorDefsProfileView> Follows { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyGraphGetFollows200Response {\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  Follows: ").Append(Follows).Append("\n");
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
