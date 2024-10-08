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
    /// ToolsOzoneModerationDefsModEventViewDetail
    /// </summary>
    [DataContract(Name = "tools.ozone.moderation.defs.modEventViewDetail")]
    public partial class ToolsOzoneModerationDefsModEventViewDetail : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsOzoneModerationDefsModEventViewDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ToolsOzoneModerationDefsModEventViewDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsOzoneModerationDefsModEventViewDetail" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="varEvent">varEvent (required).</param>
        /// <param name="subject">subject (required).</param>
        /// <param name="subjectBlobs">subjectBlobs (required).</param>
        /// <param name="createdBy">createdBy (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        public ToolsOzoneModerationDefsModEventViewDetail(int id = default(int), ToolsOzoneModerationDefsModEventViewEvent varEvent = default(ToolsOzoneModerationDefsModEventViewEvent), ToolsOzoneModerationDefsModEventViewDetailSubject subject = default(ToolsOzoneModerationDefsModEventViewDetailSubject), List<ToolsOzoneModerationDefsBlobView> subjectBlobs = default(List<ToolsOzoneModerationDefsBlobView>), string createdBy = default(string), DateTime createdAt = default(DateTime))
        {
            this.Id = id;
            // to ensure "varEvent" is required (not null)
            if (varEvent == null)
            {
                throw new ArgumentNullException("varEvent is a required property for ToolsOzoneModerationDefsModEventViewDetail and cannot be null");
            }
            this.Event = varEvent;
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new ArgumentNullException("subject is a required property for ToolsOzoneModerationDefsModEventViewDetail and cannot be null");
            }
            this.Subject = subject;
            // to ensure "subjectBlobs" is required (not null)
            if (subjectBlobs == null)
            {
                throw new ArgumentNullException("subjectBlobs is a required property for ToolsOzoneModerationDefsModEventViewDetail and cannot be null");
            }
            this.SubjectBlobs = subjectBlobs;
            // to ensure "createdBy" is required (not null)
            if (createdBy == null)
            {
                throw new ArgumentNullException("createdBy is a required property for ToolsOzoneModerationDefsModEventViewDetail and cannot be null");
            }
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Event
        /// </summary>
        [DataMember(Name = "event", IsRequired = true, EmitDefaultValue = true)]
        public ToolsOzoneModerationDefsModEventViewEvent Event { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", IsRequired = true, EmitDefaultValue = true)]
        public ToolsOzoneModerationDefsModEventViewDetailSubject Subject { get; set; }

        /// <summary>
        /// Gets or Sets SubjectBlobs
        /// </summary>
        [DataMember(Name = "subjectBlobs", IsRequired = true, EmitDefaultValue = true)]
        public List<ToolsOzoneModerationDefsBlobView> SubjectBlobs { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", IsRequired = true, EmitDefaultValue = true)]
        public string CreatedBy { get; set; }

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
            sb.Append("class ToolsOzoneModerationDefsModEventViewDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  SubjectBlobs: ").Append(SubjectBlobs).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
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
