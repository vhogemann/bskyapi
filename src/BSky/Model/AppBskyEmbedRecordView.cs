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
    /// AppBskyEmbedRecordView
    /// </summary>
    [DataContract(Name = "app.bsky.embed.record.view")]
    public partial class AppBskyEmbedRecordView : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedRecordView" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyEmbedRecordView() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedRecordView" /> class.
        /// </summary>
        /// <param name="record">record (required).</param>
        public AppBskyEmbedRecordView(AppBskyEmbedRecordViewRecord record = default(AppBskyEmbedRecordViewRecord))
        {
            // to ensure "record" is required (not null)
            if (record == null)
            {
                throw new ArgumentNullException("record is a required property for AppBskyEmbedRecordView and cannot be null");
            }
            this.Record = record;
        }

        /// <summary>
        /// Gets or Sets Record
        /// </summary>
        [DataMember(Name = "record", IsRequired = true, EmitDefaultValue = true)]
        public AppBskyEmbedRecordViewRecord Record { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyEmbedRecordView {\n");
            sb.Append("  Record: ").Append(Record).Append("\n");
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
