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
    /// AppBskyEmbedExternalExternal
    /// </summary>
    [DataContract(Name = "app.bsky.embed.external.external")]
    public partial class AppBskyEmbedExternalExternal : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedExternalExternal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyEmbedExternalExternal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedExternalExternal" /> class.
        /// </summary>
        /// <param name="uri">uri (required).</param>
        /// <param name="title">title (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="thumb">thumb.</param>
        public AppBskyEmbedExternalExternal(string uri = default(string), string title = default(string), string description = default(string), System.IO.Stream thumb = default(System.IO.Stream))
        {
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new ArgumentNullException("uri is a required property for AppBskyEmbedExternalExternal and cannot be null");
            }
            this.Uri = uri;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for AppBskyEmbedExternalExternal and cannot be null");
            }
            this.Title = title;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for AppBskyEmbedExternalExternal and cannot be null");
            }
            this.Description = description;
            this.Thumb = thumb;
        }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name = "uri", IsRequired = true, EmitDefaultValue = true)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Thumb
        /// </summary>
        [DataMember(Name = "thumb", EmitDefaultValue = false)]
        public System.IO.Stream Thumb { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyEmbedExternalExternal {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Thumb: ").Append(Thumb).Append("\n");
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
            // Thumb (System.IO.Stream) maxLength
            if (this.Thumb != null && this.Thumb.Length > 1000000)
            {
                yield return new ValidationResult("Invalid value for Thumb, length must be less than 1000000.", new [] { "Thumb" });
            }

            yield break;
        }
    }

}
