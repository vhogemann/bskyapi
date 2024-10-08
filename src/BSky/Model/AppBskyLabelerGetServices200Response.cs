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
    /// AppBskyLabelerGetServices200Response
    /// </summary>
    [DataContract(Name = "app_bsky_labeler_getServices_200_response")]
    public partial class AppBskyLabelerGetServices200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyLabelerGetServices200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyLabelerGetServices200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyLabelerGetServices200Response" /> class.
        /// </summary>
        /// <param name="views">views (required).</param>
        public AppBskyLabelerGetServices200Response(List<AppBskyLabelerGetServices200ResponseViewsInner> views = default(List<AppBskyLabelerGetServices200ResponseViewsInner>))
        {
            // to ensure "views" is required (not null)
            if (views == null)
            {
                throw new ArgumentNullException("views is a required property for AppBskyLabelerGetServices200Response and cannot be null");
            }
            this.Views = views;
        }

        /// <summary>
        /// Gets or Sets Views
        /// </summary>
        [DataMember(Name = "views", IsRequired = true, EmitDefaultValue = true)]
        public List<AppBskyLabelerGetServices200ResponseViewsInner> Views { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyLabelerGetServices200Response {\n");
            sb.Append("  Views: ").Append(Views).Append("\n");
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
