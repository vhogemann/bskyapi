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
    /// AppBskyGraphFollow
    /// </summary>
    [DataContract(Name = "app.bsky.graph.follow")]
    public partial class AppBskyGraphFollow : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyGraphFollow" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyGraphFollow() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyGraphFollow" /> class.
        /// </summary>
        /// <param name="subject">subject (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        public AppBskyGraphFollow(string subject = default(string), DateTime createdAt = default(DateTime))
        {
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new ArgumentNullException("subject is a required property for AppBskyGraphFollow and cannot be null");
            }
            this.Subject = subject;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", IsRequired = true, EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyGraphFollow {\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
