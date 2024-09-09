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
    /// ToolsOzoneModerationDefsRecordViewDetail
    /// </summary>
    [DataContract(Name = "tools.ozone.moderation.defs.recordViewDetail")]
    public partial class ToolsOzoneModerationDefsRecordViewDetail : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsOzoneModerationDefsRecordViewDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ToolsOzoneModerationDefsRecordViewDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsOzoneModerationDefsRecordViewDetail" /> class.
        /// </summary>
        /// <param name="uri">uri (required).</param>
        /// <param name="cid">cid (required).</param>
        /// <param name="value">value (required).</param>
        /// <param name="blobs">blobs (required).</param>
        /// <param name="labels">labels.</param>
        /// <param name="indexedAt">indexedAt (required).</param>
        /// <param name="moderation">moderation (required).</param>
        /// <param name="repo">repo (required).</param>
        public ToolsOzoneModerationDefsRecordViewDetail(string uri = default(string), string cid = default(string), Object value = default(Object), List<ToolsOzoneModerationDefsBlobView> blobs = default(List<ToolsOzoneModerationDefsBlobView>), List<ComAtprotoLabelDefsLabel> labels = default(List<ComAtprotoLabelDefsLabel>), DateTime indexedAt = default(DateTime), ToolsOzoneModerationDefsModerationDetail moderation = default(ToolsOzoneModerationDefsModerationDetail), ToolsOzoneModerationDefsRepoView repo = default(ToolsOzoneModerationDefsRepoView))
        {
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new ArgumentNullException("uri is a required property for ToolsOzoneModerationDefsRecordViewDetail and cannot be null");
            }
            this.Uri = uri;
            // to ensure "cid" is required (not null)
            if (cid == null)
            {
                throw new ArgumentNullException("cid is a required property for ToolsOzoneModerationDefsRecordViewDetail and cannot be null");
            }
            this.Cid = cid;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for ToolsOzoneModerationDefsRecordViewDetail and cannot be null");
            }
            this.Value = value;
            // to ensure "blobs" is required (not null)
            if (blobs == null)
            {
                throw new ArgumentNullException("blobs is a required property for ToolsOzoneModerationDefsRecordViewDetail and cannot be null");
            }
            this.Blobs = blobs;
            this.IndexedAt = indexedAt;
            // to ensure "moderation" is required (not null)
            if (moderation == null)
            {
                throw new ArgumentNullException("moderation is a required property for ToolsOzoneModerationDefsRecordViewDetail and cannot be null");
            }
            this.Moderation = moderation;
            // to ensure "repo" is required (not null)
            if (repo == null)
            {
                throw new ArgumentNullException("repo is a required property for ToolsOzoneModerationDefsRecordViewDetail and cannot be null");
            }
            this.Repo = repo;
            this.Labels = labels;
        }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name = "uri", IsRequired = true, EmitDefaultValue = true)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets Cid
        /// </summary>
        [DataMember(Name = "cid", IsRequired = true, EmitDefaultValue = true)]
        public string Cid { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public Object Value { get; set; }

        /// <summary>
        /// Gets or Sets Blobs
        /// </summary>
        [DataMember(Name = "blobs", IsRequired = true, EmitDefaultValue = true)]
        public List<ToolsOzoneModerationDefsBlobView> Blobs { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public List<ComAtprotoLabelDefsLabel> Labels { get; set; }

        /// <summary>
        /// Gets or Sets IndexedAt
        /// </summary>
        [DataMember(Name = "indexedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime IndexedAt { get; set; }

        /// <summary>
        /// Gets or Sets Moderation
        /// </summary>
        [DataMember(Name = "moderation", IsRequired = true, EmitDefaultValue = true)]
        public ToolsOzoneModerationDefsModerationDetail Moderation { get; set; }

        /// <summary>
        /// Gets or Sets Repo
        /// </summary>
        [DataMember(Name = "repo", IsRequired = true, EmitDefaultValue = true)]
        public ToolsOzoneModerationDefsRepoView Repo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ToolsOzoneModerationDefsRecordViewDetail {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Cid: ").Append(Cid).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Blobs: ").Append(Blobs).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  IndexedAt: ").Append(IndexedAt).Append("\n");
            sb.Append("  Moderation: ").Append(Moderation).Append("\n");
            sb.Append("  Repo: ").Append(Repo).Append("\n");
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
