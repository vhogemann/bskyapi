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
    /// Add a comment to a subject
    /// </summary>
    [DataContract(Name = "tools.ozone.moderation.defs.modEventComment")]
    public partial class ToolsOzoneModerationDefsModEventComment : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsOzoneModerationDefsModEventComment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ToolsOzoneModerationDefsModEventComment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsOzoneModerationDefsModEventComment" /> class.
        /// </summary>
        /// <param name="comment">comment (required).</param>
        /// <param name="sticky">Make the comment persistent on the subject.</param>
        public ToolsOzoneModerationDefsModEventComment(string comment = default(string), bool sticky = default(bool))
        {
            // to ensure "comment" is required (not null)
            if (comment == null)
            {
                throw new ArgumentNullException("comment is a required property for ToolsOzoneModerationDefsModEventComment and cannot be null");
            }
            this.Comment = comment;
            this.Sticky = sticky;
        }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "comment", IsRequired = true, EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// Make the comment persistent on the subject
        /// </summary>
        /// <value>Make the comment persistent on the subject</value>
        [DataMember(Name = "sticky", EmitDefaultValue = true)]
        public bool Sticky { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ToolsOzoneModerationDefsModEventComment {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Sticky: ").Append(Sticky).Append("\n");
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
