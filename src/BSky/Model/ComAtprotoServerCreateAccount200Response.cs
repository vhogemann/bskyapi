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
    /// Account login session returned on successful account creation.
    /// </summary>
    [DataContract(Name = "com_atproto_server_createAccount_200_response")]
    public partial class ComAtprotoServerCreateAccount200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoServerCreateAccount200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoServerCreateAccount200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoServerCreateAccount200Response" /> class.
        /// </summary>
        /// <param name="accessJwt">accessJwt (required).</param>
        /// <param name="refreshJwt">refreshJwt (required).</param>
        /// <param name="handle">handle (required).</param>
        /// <param name="did">The DID of the new account. (required).</param>
        /// <param name="didDoc">didDoc.</param>
        public ComAtprotoServerCreateAccount200Response(string accessJwt = default(string), string refreshJwt = default(string), string handle = default(string), string did = default(string), Object didDoc = default(Object))
        {
            // to ensure "accessJwt" is required (not null)
            if (accessJwt == null)
            {
                throw new ArgumentNullException("accessJwt is a required property for ComAtprotoServerCreateAccount200Response and cannot be null");
            }
            this.AccessJwt = accessJwt;
            // to ensure "refreshJwt" is required (not null)
            if (refreshJwt == null)
            {
                throw new ArgumentNullException("refreshJwt is a required property for ComAtprotoServerCreateAccount200Response and cannot be null");
            }
            this.RefreshJwt = refreshJwt;
            // to ensure "handle" is required (not null)
            if (handle == null)
            {
                throw new ArgumentNullException("handle is a required property for ComAtprotoServerCreateAccount200Response and cannot be null");
            }
            this.Handle = handle;
            // to ensure "did" is required (not null)
            if (did == null)
            {
                throw new ArgumentNullException("did is a required property for ComAtprotoServerCreateAccount200Response and cannot be null");
            }
            this.Did = did;
            this.DidDoc = didDoc;
        }

        /// <summary>
        /// Gets or Sets AccessJwt
        /// </summary>
        [DataMember(Name = "accessJwt", IsRequired = true, EmitDefaultValue = true)]
        public string AccessJwt { get; set; }

        /// <summary>
        /// Gets or Sets RefreshJwt
        /// </summary>
        [DataMember(Name = "refreshJwt", IsRequired = true, EmitDefaultValue = true)]
        public string RefreshJwt { get; set; }

        /// <summary>
        /// Gets or Sets Handle
        /// </summary>
        [DataMember(Name = "handle", IsRequired = true, EmitDefaultValue = true)]
        public string Handle { get; set; }

        /// <summary>
        /// The DID of the new account.
        /// </summary>
        /// <value>The DID of the new account.</value>
        [DataMember(Name = "did", IsRequired = true, EmitDefaultValue = true)]
        public string Did { get; set; }

        /// <summary>
        /// Gets or Sets DidDoc
        /// </summary>
        [DataMember(Name = "didDoc", EmitDefaultValue = true)]
        public Object DidDoc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoServerCreateAccount200Response {\n");
            sb.Append("  AccessJwt: ").Append(AccessJwt).Append("\n");
            sb.Append("  RefreshJwt: ").Append(RefreshJwt).Append("\n");
            sb.Append("  Handle: ").Append(Handle).Append("\n");
            sb.Append("  Did: ").Append(Did).Append("\n");
            sb.Append("  DidDoc: ").Append(DidDoc).Append("\n");
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
