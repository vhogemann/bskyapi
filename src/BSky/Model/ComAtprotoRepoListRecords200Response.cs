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
    /// ComAtprotoRepoListRecords200Response
    /// </summary>
    [DataContract(Name = "com_atproto_repo_listRecords_200_response")]
    public partial class ComAtprotoRepoListRecords200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoRepoListRecords200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoRepoListRecords200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoRepoListRecords200Response" /> class.
        /// </summary>
        /// <param name="cursor">cursor.</param>
        /// <param name="records">records (required).</param>
        public ComAtprotoRepoListRecords200Response(string cursor = default(string), List<ComAtprotoRepoListRecordsRecord> records = default(List<ComAtprotoRepoListRecordsRecord>))
        {
            // to ensure "records" is required (not null)
            if (records == null)
            {
                throw new ArgumentNullException("records is a required property for ComAtprotoRepoListRecords200Response and cannot be null");
            }
            this.Records = records;
            this.Cursor = cursor;
        }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        public string Cursor { get; set; }

        /// <summary>
        /// Gets or Sets Records
        /// </summary>
        [DataMember(Name = "records", IsRequired = true, EmitDefaultValue = true)]
        public List<ComAtprotoRepoListRecordsRecord> Records { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoRepoListRecords200Response {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
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
