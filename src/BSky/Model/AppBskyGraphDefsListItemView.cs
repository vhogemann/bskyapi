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
    /// AppBskyGraphDefsListItemView
    /// </summary>
    [DataContract(Name = "app.bsky.graph.defs.listItemView")]
    public partial class AppBskyGraphDefsListItemView : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyGraphDefsListItemView" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyGraphDefsListItemView() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyGraphDefsListItemView" /> class.
        /// </summary>
        /// <param name="uri">uri (required).</param>
        /// <param name="subject">subject (required).</param>
        public AppBskyGraphDefsListItemView(string uri = default(string), AppBskyActorDefsProfileView subject = default(AppBskyActorDefsProfileView))
        {
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new ArgumentNullException("uri is a required property for AppBskyGraphDefsListItemView and cannot be null");
            }
            this.Uri = uri;
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new ArgumentNullException("subject is a required property for AppBskyGraphDefsListItemView and cannot be null");
            }
            this.Subject = subject;
        }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name = "uri", IsRequired = true, EmitDefaultValue = true)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", IsRequired = true, EmitDefaultValue = true)]
        public AppBskyActorDefsProfileView Subject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyGraphDefsListItemView {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
