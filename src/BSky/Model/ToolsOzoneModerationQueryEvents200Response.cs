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
    /// ToolsOzoneModerationQueryEvents200Response
    /// </summary>
    [DataContract(Name = "tools_ozone_moderation_queryEvents_200_response")]
    public partial class ToolsOzoneModerationQueryEvents200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsOzoneModerationQueryEvents200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ToolsOzoneModerationQueryEvents200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsOzoneModerationQueryEvents200Response" /> class.
        /// </summary>
        /// <param name="cursor">cursor.</param>
        /// <param name="events">events (required).</param>
        public ToolsOzoneModerationQueryEvents200Response(string cursor = default(string), List<ToolsOzoneModerationDefsModEventView> events = default(List<ToolsOzoneModerationDefsModEventView>))
        {
            // to ensure "events" is required (not null)
            if (events == null)
            {
                throw new ArgumentNullException("events is a required property for ToolsOzoneModerationQueryEvents200Response and cannot be null");
            }
            this.Events = events;
            this.Cursor = cursor;
        }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        public string Cursor { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", IsRequired = true, EmitDefaultValue = true)]
        public List<ToolsOzoneModerationDefsModEventView> Events { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ToolsOzoneModerationQueryEvents200Response {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
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
