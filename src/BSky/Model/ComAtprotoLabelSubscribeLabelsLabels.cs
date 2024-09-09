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
    /// ComAtprotoLabelSubscribeLabelsLabels
    /// </summary>
    [DataContract(Name = "com.atproto.label.subscribeLabels.labels")]
    public partial class ComAtprotoLabelSubscribeLabelsLabels : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoLabelSubscribeLabelsLabels" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoLabelSubscribeLabelsLabels() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoLabelSubscribeLabelsLabels" /> class.
        /// </summary>
        /// <param name="seq">seq (required).</param>
        /// <param name="labels">labels (required).</param>
        public ComAtprotoLabelSubscribeLabelsLabels(int seq = default(int), List<ComAtprotoLabelDefsLabel> labels = default(List<ComAtprotoLabelDefsLabel>))
        {
            this.Seq = seq;
            // to ensure "labels" is required (not null)
            if (labels == null)
            {
                throw new ArgumentNullException("labels is a required property for ComAtprotoLabelSubscribeLabelsLabels and cannot be null");
            }
            this.Labels = labels;
        }

        /// <summary>
        /// Gets or Sets Seq
        /// </summary>
        [DataMember(Name = "seq", IsRequired = true, EmitDefaultValue = true)]
        public int Seq { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name = "labels", IsRequired = true, EmitDefaultValue = true)]
        public List<ComAtprotoLabelDefsLabel> Labels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoLabelSubscribeLabelsLabels {\n");
            sb.Append("  Seq: ").Append(Seq).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
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
