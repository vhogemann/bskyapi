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
    /// ComAtprotoIdentityUpdateHandleRequest
    /// </summary>
    [DataContract(Name = "com_atproto_identity_updateHandle_request")]
    public partial class ComAtprotoIdentityUpdateHandleRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoIdentityUpdateHandleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoIdentityUpdateHandleRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoIdentityUpdateHandleRequest" /> class.
        /// </summary>
        /// <param name="handle">The new handle. (required).</param>
        public ComAtprotoIdentityUpdateHandleRequest(string handle = default(string))
        {
            // to ensure "handle" is required (not null)
            if (handle == null)
            {
                throw new ArgumentNullException("handle is a required property for ComAtprotoIdentityUpdateHandleRequest and cannot be null");
            }
            this.Handle = handle;
        }

        /// <summary>
        /// The new handle.
        /// </summary>
        /// <value>The new handle.</value>
        [DataMember(Name = "handle", IsRequired = true, EmitDefaultValue = true)]
        public string Handle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoIdentityUpdateHandleRequest {\n");
            sb.Append("  Handle: ").Append(Handle).Append("\n");
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
