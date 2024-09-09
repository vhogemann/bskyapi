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
    /// AppBskyEmbedVideoCaption
    /// </summary>
    [DataContract(Name = "app.bsky.embed.video.caption")]
    public partial class AppBskyEmbedVideoCaption : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedVideoCaption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyEmbedVideoCaption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedVideoCaption" /> class.
        /// </summary>
        /// <param name="lang">lang (required).</param>
        /// <param name="file">file (required).</param>
        public AppBskyEmbedVideoCaption(string lang = default(string), System.IO.Stream file = default(System.IO.Stream))
        {
            // to ensure "lang" is required (not null)
            if (lang == null)
            {
                throw new ArgumentNullException("lang is a required property for AppBskyEmbedVideoCaption and cannot be null");
            }
            this.Lang = lang;
            // to ensure "file" is required (not null)
            if (file == null)
            {
                throw new ArgumentNullException("file is a required property for AppBskyEmbedVideoCaption and cannot be null");
            }
            this.File = file;
        }

        /// <summary>
        /// Gets or Sets Lang
        /// </summary>
        [DataMember(Name = "lang", IsRequired = true, EmitDefaultValue = true)]
        public string Lang { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name = "file", IsRequired = true, EmitDefaultValue = true)]
        public System.IO.Stream File { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyEmbedVideoCaption {\n");
            sb.Append("  Lang: ").Append(Lang).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
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
            // File (System.IO.Stream) maxLength
            if (this.File != null && this.File.Length > 20000)
            {
                yield return new ValidationResult("Invalid value for File, length must be less than 20000.", new [] { "File" });
            }

            yield break;
        }
    }

}