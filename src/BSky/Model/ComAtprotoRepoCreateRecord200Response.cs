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
    /// ComAtprotoRepoCreateRecord200Response
    /// </summary>
    [DataContract(Name = "com_atproto_repo_createRecord_200_response")]
    public partial class ComAtprotoRepoCreateRecord200Response : IValidatableObject
    {
        /// <summary>
        /// Defines ValidationStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValidationStatusEnum
        {
            /// <summary>
            /// Enum Valid for value: valid
            /// </summary>
            [EnumMember(Value = "valid")]
            Valid = 1,

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 2
        }


        /// <summary>
        /// Gets or Sets ValidationStatus
        /// </summary>
        [DataMember(Name = "validationStatus", EmitDefaultValue = false)]
        public ValidationStatusEnum? ValidationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoRepoCreateRecord200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoRepoCreateRecord200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoRepoCreateRecord200Response" /> class.
        /// </summary>
        /// <param name="uri">uri (required).</param>
        /// <param name="cid">cid (required).</param>
        /// <param name="commit">commit.</param>
        /// <param name="validationStatus">validationStatus.</param>
        public ComAtprotoRepoCreateRecord200Response(string uri = default(string), string cid = default(string), ComAtprotoRepoDefsCommitMeta commit = default(ComAtprotoRepoDefsCommitMeta), ValidationStatusEnum? validationStatus = default(ValidationStatusEnum?))
        {
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new ArgumentNullException("uri is a required property for ComAtprotoRepoCreateRecord200Response and cannot be null");
            }
            this.Uri = uri;
            // to ensure "cid" is required (not null)
            if (cid == null)
            {
                throw new ArgumentNullException("cid is a required property for ComAtprotoRepoCreateRecord200Response and cannot be null");
            }
            this.Cid = cid;
            this.Commit = commit;
            this.ValidationStatus = validationStatus;
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
        /// Gets or Sets Commit
        /// </summary>
        [DataMember(Name = "commit", EmitDefaultValue = false)]
        public ComAtprotoRepoDefsCommitMeta Commit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoRepoCreateRecord200Response {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Cid: ").Append(Cid).Append("\n");
            sb.Append("  Commit: ").Append(Commit).Append("\n");
            sb.Append("  ValidationStatus: ").Append(ValidationStatus).Append("\n");
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
