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
    /// ComAtprotoServerReserveSigningKey200Response
    /// </summary>
    [DataContract(Name = "com_atproto_server_reserveSigningKey_200_response")]
    public partial class ComAtprotoServerReserveSigningKey200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoServerReserveSigningKey200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoServerReserveSigningKey200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoServerReserveSigningKey200Response" /> class.
        /// </summary>
        /// <param name="signingKey">The public key for the reserved signing key, in did:key serialization. (required).</param>
        public ComAtprotoServerReserveSigningKey200Response(string signingKey = default(string))
        {
            // to ensure "signingKey" is required (not null)
            if (signingKey == null)
            {
                throw new ArgumentNullException("signingKey is a required property for ComAtprotoServerReserveSigningKey200Response and cannot be null");
            }
            this.SigningKey = signingKey;
        }

        /// <summary>
        /// The public key for the reserved signing key, in did:key serialization.
        /// </summary>
        /// <value>The public key for the reserved signing key, in did:key serialization.</value>
        [DataMember(Name = "signingKey", IsRequired = true, EmitDefaultValue = true)]
        public string SigningKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoServerReserveSigningKey200Response {\n");
            sb.Append("  SigningKey: ").Append(SigningKey).Append("\n");
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