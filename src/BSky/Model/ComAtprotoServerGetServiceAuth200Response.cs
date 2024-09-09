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
    /// ComAtprotoServerGetServiceAuth200Response
    /// </summary>
    [DataContract(Name = "com_atproto_server_getServiceAuth_200_response")]
    public partial class ComAtprotoServerGetServiceAuth200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoServerGetServiceAuth200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoServerGetServiceAuth200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoServerGetServiceAuth200Response" /> class.
        /// </summary>
        /// <param name="token">token (required).</param>
        public ComAtprotoServerGetServiceAuth200Response(string token = default(string))
        {
            // to ensure "token" is required (not null)
            if (token == null)
            {
                throw new ArgumentNullException("token is a required property for ComAtprotoServerGetServiceAuth200Response and cannot be null");
            }
            this.Token = token;
        }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", IsRequired = true, EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoServerGetServiceAuth200Response {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
