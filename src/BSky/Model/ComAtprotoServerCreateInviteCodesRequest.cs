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
    /// ComAtprotoServerCreateInviteCodesRequest
    /// </summary>
    [DataContract(Name = "com_atproto_server_createInviteCodes_request")]
    public partial class ComAtprotoServerCreateInviteCodesRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoServerCreateInviteCodesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoServerCreateInviteCodesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoServerCreateInviteCodesRequest" /> class.
        /// </summary>
        /// <param name="codeCount">codeCount (required) (default to 1).</param>
        /// <param name="useCount">useCount (required).</param>
        /// <param name="forAccounts">forAccounts.</param>
        public ComAtprotoServerCreateInviteCodesRequest(int codeCount = 1, int useCount = default(int), List<string> forAccounts = default(List<string>))
        {
            this.CodeCount = codeCount;
            this.UseCount = useCount;
            this.ForAccounts = forAccounts;
        }

        /// <summary>
        /// Gets or Sets CodeCount
        /// </summary>
        [DataMember(Name = "codeCount", IsRequired = true, EmitDefaultValue = true)]
        public int CodeCount { get; set; }

        /// <summary>
        /// Gets or Sets UseCount
        /// </summary>
        [DataMember(Name = "useCount", IsRequired = true, EmitDefaultValue = true)]
        public int UseCount { get; set; }

        /// <summary>
        /// Gets or Sets ForAccounts
        /// </summary>
        [DataMember(Name = "forAccounts", EmitDefaultValue = false)]
        public List<string> ForAccounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoServerCreateInviteCodesRequest {\n");
            sb.Append("  CodeCount: ").Append(CodeCount).Append("\n");
            sb.Append("  UseCount: ").Append(UseCount).Append("\n");
            sb.Append("  ForAccounts: ").Append(ForAccounts).Append("\n");
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
