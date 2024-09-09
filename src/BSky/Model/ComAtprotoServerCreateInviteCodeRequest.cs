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
    /// ComAtprotoServerCreateInviteCodeRequest
    /// </summary>
    [DataContract(Name = "com_atproto_server_createInviteCode_request")]
    public partial class ComAtprotoServerCreateInviteCodeRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoServerCreateInviteCodeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoServerCreateInviteCodeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoServerCreateInviteCodeRequest" /> class.
        /// </summary>
        /// <param name="useCount">useCount (required).</param>
        /// <param name="forAccount">forAccount.</param>
        public ComAtprotoServerCreateInviteCodeRequest(int useCount = default(int), string forAccount = default(string))
        {
            this.UseCount = useCount;
            this.ForAccount = forAccount;
        }

        /// <summary>
        /// Gets or Sets UseCount
        /// </summary>
        [DataMember(Name = "useCount", IsRequired = true, EmitDefaultValue = true)]
        public int UseCount { get; set; }

        /// <summary>
        /// Gets or Sets ForAccount
        /// </summary>
        [DataMember(Name = "forAccount", EmitDefaultValue = false)]
        public string ForAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoServerCreateInviteCodeRequest {\n");
            sb.Append("  UseCount: ").Append(UseCount).Append("\n");
            sb.Append("  ForAccount: ").Append(ForAccount).Append("\n");
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
