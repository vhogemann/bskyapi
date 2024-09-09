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
    /// AppBskyEmbedExternalView
    /// </summary>
    [DataContract(Name = "app.bsky.embed.external.view")]
    public partial class AppBskyEmbedExternalView : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedExternalView" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyEmbedExternalView() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedExternalView" /> class.
        /// </summary>
        /// <param name="external">external (required).</param>
        public AppBskyEmbedExternalView(AppBskyEmbedExternalViewExternal external = default(AppBskyEmbedExternalViewExternal))
        {
            // to ensure "external" is required (not null)
            if (external == null)
            {
                throw new ArgumentNullException("external is a required property for AppBskyEmbedExternalView and cannot be null");
            }
            this.External = external;
        }

        /// <summary>
        /// Gets or Sets External
        /// </summary>
        [DataMember(Name = "external", IsRequired = true, EmitDefaultValue = true)]
        public AppBskyEmbedExternalViewExternal External { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyEmbedExternalView {\n");
            sb.Append("  External: ").Append(External).Append("\n");
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