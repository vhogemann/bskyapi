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
    /// Operation which creates a new record.
    /// </summary>
    [DataContract(Name = "com.atproto.repo.applyWrites.create")]
    public partial class ComAtprotoRepoApplyWritesCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoRepoApplyWritesCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoRepoApplyWritesCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoRepoApplyWritesCreate" /> class.
        /// </summary>
        /// <param name="collection">collection (required).</param>
        /// <param name="rkey">rkey.</param>
        /// <param name="value">value (required).</param>
        public ComAtprotoRepoApplyWritesCreate(string collection = default(string), string rkey = default(string), Object value = default(Object))
        {
            // to ensure "collection" is required (not null)
            if (collection == null)
            {
                throw new ArgumentNullException("collection is a required property for ComAtprotoRepoApplyWritesCreate and cannot be null");
            }
            this.Collection = collection;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for ComAtprotoRepoApplyWritesCreate and cannot be null");
            }
            this.Value = value;
            this.Rkey = rkey;
        }

        /// <summary>
        /// Gets or Sets Collection
        /// </summary>
        [DataMember(Name = "collection", IsRequired = true, EmitDefaultValue = true)]
        public string Collection { get; set; }

        /// <summary>
        /// Gets or Sets Rkey
        /// </summary>
        [DataMember(Name = "rkey", EmitDefaultValue = false)]
        public string Rkey { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public Object Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoRepoApplyWritesCreate {\n");
            sb.Append("  Collection: ").Append(Collection).Append("\n");
            sb.Append("  Rkey: ").Append(Rkey).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            // Rkey (string) maxLength
            if (this.Rkey != null && this.Rkey.Length > 15)
            {
                yield return new ValidationResult("Invalid value for Rkey, length must be less than 15.", new [] { "Rkey" });
            }

            yield break;
        }
    }

}
