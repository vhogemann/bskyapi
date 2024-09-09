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
    /// width:height represents an aspect ratio. It may be approximate, and may not correspond to absolute dimensions in any given unit.
    /// </summary>
    [DataContract(Name = "app.bsky.embed.defs.aspectRatio")]
    public partial class AppBskyEmbedDefsAspectRatio : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedDefsAspectRatio" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyEmbedDefsAspectRatio() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedDefsAspectRatio" /> class.
        /// </summary>
        /// <param name="width">width (required).</param>
        /// <param name="height">height (required).</param>
        public AppBskyEmbedDefsAspectRatio(int width = default(int), int height = default(int))
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name = "width", IsRequired = true, EmitDefaultValue = true)]
        public int Width { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "height", IsRequired = true, EmitDefaultValue = true)]
        public int Height { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyEmbedDefsAspectRatio {\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
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
            // Width (int) minimum
            if (this.Width < (int)1)
            {
                yield return new ValidationResult("Invalid value for Width, must be a value greater than or equal to 1.", new [] { "Width" });
            }

            // Height (int) minimum
            if (this.Height < (int)1)
            {
                yield return new ValidationResult("Invalid value for Height, must be a value greater than or equal to 1.", new [] { "Height" });
            }

            yield break;
        }
    }

}