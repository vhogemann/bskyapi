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
    /// ComAtprotoSyncListReposRepo
    /// </summary>
    [DataContract(Name = "com.atproto.sync.listRepos.repo")]
    public partial class ComAtprotoSyncListReposRepo : IValidatableObject
    {
        /// <summary>
        /// If active&#x3D;false, this optional field indicates a possible reason for why the account is not active. If active&#x3D;false and no status is supplied, then the host makes no claim for why the repository is no longer being hosted.
        /// </summary>
        /// <value>If active&#x3D;false, this optional field indicates a possible reason for why the account is not active. If active&#x3D;false and no status is supplied, then the host makes no claim for why the repository is no longer being hosted.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Takendown for value: takendown
            /// </summary>
            [EnumMember(Value = "takendown")]
            Takendown = 1,

            /// <summary>
            /// Enum Suspended for value: suspended
            /// </summary>
            [EnumMember(Value = "suspended")]
            Suspended = 2,

            /// <summary>
            /// Enum Deactivated for value: deactivated
            /// </summary>
            [EnumMember(Value = "deactivated")]
            Deactivated = 3
        }


        /// <summary>
        /// If active&#x3D;false, this optional field indicates a possible reason for why the account is not active. If active&#x3D;false and no status is supplied, then the host makes no claim for why the repository is no longer being hosted.
        /// </summary>
        /// <value>If active&#x3D;false, this optional field indicates a possible reason for why the account is not active. If active&#x3D;false and no status is supplied, then the host makes no claim for why the repository is no longer being hosted.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoSyncListReposRepo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoSyncListReposRepo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoSyncListReposRepo" /> class.
        /// </summary>
        /// <param name="did">did (required).</param>
        /// <param name="head">Current repo commit CID (required).</param>
        /// <param name="rev">rev (required).</param>
        /// <param name="active">active.</param>
        /// <param name="status">If active&#x3D;false, this optional field indicates a possible reason for why the account is not active. If active&#x3D;false and no status is supplied, then the host makes no claim for why the repository is no longer being hosted..</param>
        public ComAtprotoSyncListReposRepo(string did = default(string), string head = default(string), string rev = default(string), bool active = default(bool), StatusEnum? status = default(StatusEnum?))
        {
            // to ensure "did" is required (not null)
            if (did == null)
            {
                throw new ArgumentNullException("did is a required property for ComAtprotoSyncListReposRepo and cannot be null");
            }
            this.Did = did;
            // to ensure "head" is required (not null)
            if (head == null)
            {
                throw new ArgumentNullException("head is a required property for ComAtprotoSyncListReposRepo and cannot be null");
            }
            this.Head = head;
            // to ensure "rev" is required (not null)
            if (rev == null)
            {
                throw new ArgumentNullException("rev is a required property for ComAtprotoSyncListReposRepo and cannot be null");
            }
            this.Rev = rev;
            this.Active = active;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets Did
        /// </summary>
        [DataMember(Name = "did", IsRequired = true, EmitDefaultValue = true)]
        public string Did { get; set; }

        /// <summary>
        /// Current repo commit CID
        /// </summary>
        /// <value>Current repo commit CID</value>
        [DataMember(Name = "head", IsRequired = true, EmitDefaultValue = true)]
        public string Head { get; set; }

        /// <summary>
        /// Gets or Sets Rev
        /// </summary>
        [DataMember(Name = "rev", IsRequired = true, EmitDefaultValue = true)]
        public string Rev { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoSyncListReposRepo {\n");
            sb.Append("  Did: ").Append(Did).Append("\n");
            sb.Append("  Head: ").Append(Head).Append("\n");
            sb.Append("  Rev: ").Append(Rev).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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