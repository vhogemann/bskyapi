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
    /// If set, an active progress guide. Once completed, can be set to undefined. Should have unspecced fields tracking progress.
    /// </summary>
    [DataContract(Name = "app.bsky.actor.defs.bskyAppProgressGuide")]
    public partial class AppBskyActorDefsBskyAppProgressGuide : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyActorDefsBskyAppProgressGuide" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyActorDefsBskyAppProgressGuide() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyActorDefsBskyAppProgressGuide" /> class.
        /// </summary>
        /// <param name="guide">guide (required).</param>
        public AppBskyActorDefsBskyAppProgressGuide(string guide = default(string))
        {
            // to ensure "guide" is required (not null)
            if (guide == null)
            {
                throw new ArgumentNullException("guide is a required property for AppBskyActorDefsBskyAppProgressGuide and cannot be null");
            }
            this.Guide = guide;
        }

        /// <summary>
        /// Gets or Sets Guide
        /// </summary>
        [DataMember(Name = "guide", IsRequired = true, EmitDefaultValue = true)]
        public string Guide { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyActorDefsBskyAppProgressGuide {\n");
            sb.Append("  Guide: ").Append(Guide).Append("\n");
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
            // Guide (string) maxLength
            if (this.Guide != null && this.Guide.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Guide, length must be less than 100.", new [] { "Guide" });
            }

            yield break;
        }
    }

}