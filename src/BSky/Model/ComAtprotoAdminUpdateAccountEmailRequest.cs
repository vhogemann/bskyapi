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
    /// ComAtprotoAdminUpdateAccountEmailRequest
    /// </summary>
    [DataContract(Name = "com_atproto_admin_updateAccountEmail_request")]
    public partial class ComAtprotoAdminUpdateAccountEmailRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminUpdateAccountEmailRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoAdminUpdateAccountEmailRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminUpdateAccountEmailRequest" /> class.
        /// </summary>
        /// <param name="account">The handle or DID of the repo. (required).</param>
        /// <param name="email">email (required).</param>
        public ComAtprotoAdminUpdateAccountEmailRequest(string account = default(string), string email = default(string))
        {
            // to ensure "account" is required (not null)
            if (account == null)
            {
                throw new ArgumentNullException("account is a required property for ComAtprotoAdminUpdateAccountEmailRequest and cannot be null");
            }
            this.Account = account;
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for ComAtprotoAdminUpdateAccountEmailRequest and cannot be null");
            }
            this.Email = email;
        }

        /// <summary>
        /// The handle or DID of the repo.
        /// </summary>
        /// <value>The handle or DID of the repo.</value>
        [DataMember(Name = "account", IsRequired = true, EmitDefaultValue = true)]
        public string Account { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoAdminUpdateAccountEmailRequest {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
