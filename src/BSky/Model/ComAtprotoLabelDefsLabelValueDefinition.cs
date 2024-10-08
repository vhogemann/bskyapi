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
    /// Declares a label value and its expected interpretations and behaviors.
    /// </summary>
    [DataContract(Name = "com.atproto.label.defs.labelValueDefinition")]
    public partial class ComAtprotoLabelDefsLabelValueDefinition : IValidatableObject
    {
        /// <summary>
        /// How should a client visually convey this label? &#39;inform&#39; means neutral and informational; &#39;alert&#39; means negative and warning; &#39;none&#39; means show nothing.
        /// </summary>
        /// <value>How should a client visually convey this label? &#39;inform&#39; means neutral and informational; &#39;alert&#39; means negative and warning; &#39;none&#39; means show nothing.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SeverityEnum
        {
            /// <summary>
            /// Enum Inform for value: inform
            /// </summary>
            [EnumMember(Value = "inform")]
            Inform = 1,

            /// <summary>
            /// Enum Alert for value: alert
            /// </summary>
            [EnumMember(Value = "alert")]
            Alert = 2,

            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 3
        }


        /// <summary>
        /// How should a client visually convey this label? &#39;inform&#39; means neutral and informational; &#39;alert&#39; means negative and warning; &#39;none&#39; means show nothing.
        /// </summary>
        /// <value>How should a client visually convey this label? &#39;inform&#39; means neutral and informational; &#39;alert&#39; means negative and warning; &#39;none&#39; means show nothing.</value>
        [DataMember(Name = "severity", IsRequired = true, EmitDefaultValue = true)]
        public SeverityEnum Severity { get; set; }
        /// <summary>
        /// What should this label hide in the UI, if applied? &#39;content&#39; hides all of the target; &#39;media&#39; hides the images/video/audio; &#39;none&#39; hides nothing.
        /// </summary>
        /// <value>What should this label hide in the UI, if applied? &#39;content&#39; hides all of the target; &#39;media&#39; hides the images/video/audio; &#39;none&#39; hides nothing.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BlursEnum
        {
            /// <summary>
            /// Enum Content for value: content
            /// </summary>
            [EnumMember(Value = "content")]
            Content = 1,

            /// <summary>
            /// Enum Media for value: media
            /// </summary>
            [EnumMember(Value = "media")]
            Media = 2,

            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 3
        }


        /// <summary>
        /// What should this label hide in the UI, if applied? &#39;content&#39; hides all of the target; &#39;media&#39; hides the images/video/audio; &#39;none&#39; hides nothing.
        /// </summary>
        /// <value>What should this label hide in the UI, if applied? &#39;content&#39; hides all of the target; &#39;media&#39; hides the images/video/audio; &#39;none&#39; hides nothing.</value>
        [DataMember(Name = "blurs", IsRequired = true, EmitDefaultValue = true)]
        public BlursEnum Blurs { get; set; }
        /// <summary>
        /// The default setting for this label.
        /// </summary>
        /// <value>The default setting for this label.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DefaultSettingEnum
        {
            /// <summary>
            /// Enum Ignore for value: ignore
            /// </summary>
            [EnumMember(Value = "ignore")]
            Ignore = 1,

            /// <summary>
            /// Enum Warn for value: warn
            /// </summary>
            [EnumMember(Value = "warn")]
            Warn = 2,

            /// <summary>
            /// Enum Hide for value: hide
            /// </summary>
            [EnumMember(Value = "hide")]
            Hide = 3
        }


        /// <summary>
        /// The default setting for this label.
        /// </summary>
        /// <value>The default setting for this label.</value>
        [DataMember(Name = "defaultSetting", EmitDefaultValue = false)]
        public DefaultSettingEnum? DefaultSetting { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoLabelDefsLabelValueDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoLabelDefsLabelValueDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoLabelDefsLabelValueDefinition" /> class.
        /// </summary>
        /// <param name="identifier">The value of the label being defined. Must only include lowercase ascii and the &#39;-&#39; character ([a-z-]+). (required).</param>
        /// <param name="severity">How should a client visually convey this label? &#39;inform&#39; means neutral and informational; &#39;alert&#39; means negative and warning; &#39;none&#39; means show nothing. (required).</param>
        /// <param name="blurs">What should this label hide in the UI, if applied? &#39;content&#39; hides all of the target; &#39;media&#39; hides the images/video/audio; &#39;none&#39; hides nothing. (required).</param>
        /// <param name="defaultSetting">The default setting for this label. (default to DefaultSettingEnum.Warn).</param>
        /// <param name="adultOnly">Does the user need to have adult content enabled in order to configure this label?.</param>
        /// <param name="locales">locales (required).</param>
        public ComAtprotoLabelDefsLabelValueDefinition(string identifier = default(string), SeverityEnum severity = default(SeverityEnum), BlursEnum blurs = default(BlursEnum), DefaultSettingEnum? defaultSetting = DefaultSettingEnum.Warn, bool adultOnly = default(bool), List<ComAtprotoLabelDefsLabelValueDefinitionStrings> locales = default(List<ComAtprotoLabelDefsLabelValueDefinitionStrings>))
        {
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier is a required property for ComAtprotoLabelDefsLabelValueDefinition and cannot be null");
            }
            this.Identifier = identifier;
            this.Severity = severity;
            this.Blurs = blurs;
            // to ensure "locales" is required (not null)
            if (locales == null)
            {
                throw new ArgumentNullException("locales is a required property for ComAtprotoLabelDefsLabelValueDefinition and cannot be null");
            }
            this.Locales = locales;
            this.DefaultSetting = defaultSetting;
            this.AdultOnly = adultOnly;
        }

        /// <summary>
        /// The value of the label being defined. Must only include lowercase ascii and the &#39;-&#39; character ([a-z-]+).
        /// </summary>
        /// <value>The value of the label being defined. Must only include lowercase ascii and the &#39;-&#39; character ([a-z-]+).</value>
        [DataMember(Name = "identifier", IsRequired = true, EmitDefaultValue = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Does the user need to have adult content enabled in order to configure this label?
        /// </summary>
        /// <value>Does the user need to have adult content enabled in order to configure this label?</value>
        [DataMember(Name = "adultOnly", EmitDefaultValue = true)]
        public bool AdultOnly { get; set; }

        /// <summary>
        /// Gets or Sets Locales
        /// </summary>
        [DataMember(Name = "locales", IsRequired = true, EmitDefaultValue = true)]
        public List<ComAtprotoLabelDefsLabelValueDefinitionStrings> Locales { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoLabelDefsLabelValueDefinition {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  Blurs: ").Append(Blurs).Append("\n");
            sb.Append("  DefaultSetting: ").Append(DefaultSetting).Append("\n");
            sb.Append("  AdultOnly: ").Append(AdultOnly).Append("\n");
            sb.Append("  Locales: ").Append(Locales).Append("\n");
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
            // Identifier (string) maxLength
            if (this.Identifier != null && this.Identifier.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Identifier, length must be less than 100.", new [] { "Identifier" });
            }

            yield break;
        }
    }

}
