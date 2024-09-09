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
    /// AppBskyEmbedRecordViewBlocked
    /// </summary>
    [DataContract(Name = "app.bsky.embed.record.viewBlocked")]
    public partial class AppBskyEmbedRecordViewBlocked : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedRecordViewBlocked" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyEmbedRecordViewBlocked() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedRecordViewBlocked" /> class.
        /// </summary>
        /// <param name="uri">uri (required).</param>
        /// <param name="blocked">blocked (required) (default to true).</param>
        /// <param name="author">author (required).</param>
        public AppBskyEmbedRecordViewBlocked(string uri = default(string), bool blocked = true, AppBskyFeedDefsBlockedAuthor author = default(AppBskyFeedDefsBlockedAuthor))
        {
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new ArgumentNullException("uri is a required property for AppBskyEmbedRecordViewBlocked and cannot be null");
            }
            this.Uri = uri;
            this.Blocked = blocked;
            // to ensure "author" is required (not null)
            if (author == null)
            {
                throw new ArgumentNullException("author is a required property for AppBskyEmbedRecordViewBlocked and cannot be null");
            }
            this.Author = author;
        }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name = "uri", IsRequired = true, EmitDefaultValue = true)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets Blocked
        /// </summary>
        [DataMember(Name = "blocked", IsRequired = true, EmitDefaultValue = true)]
        public bool Blocked { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name = "author", IsRequired = true, EmitDefaultValue = true)]
        public AppBskyFeedDefsBlockedAuthor Author { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyEmbedRecordViewBlocked {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Blocked: ").Append(Blocked).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
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
