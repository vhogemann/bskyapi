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
    /// ToolsOzoneTeamAddMemberRequest
    /// </summary>
    [DataContract(Name = "tools_ozone_team_addMember_request")]
    public partial class ToolsOzoneTeamAddMemberRequest : IValidatableObject
    {
        /// <summary>
        /// Defines Role
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleEnum
        {
            /// <summary>
            /// Enum RoleAdmin for value: tools.ozone.team.defs#roleAdmin
            /// </summary>
            [EnumMember(Value = "tools.ozone.team.defs#roleAdmin")]
            RoleAdmin = 1,

            /// <summary>
            /// Enum RoleModerator for value: tools.ozone.team.defs#roleModerator
            /// </summary>
            [EnumMember(Value = "tools.ozone.team.defs#roleModerator")]
            RoleModerator = 2,

            /// <summary>
            /// Enum RoleTriage for value: tools.ozone.team.defs#roleTriage
            /// </summary>
            [EnumMember(Value = "tools.ozone.team.defs#roleTriage")]
            RoleTriage = 3
        }


        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name = "role", IsRequired = true, EmitDefaultValue = true)]
        public RoleEnum Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsOzoneTeamAddMemberRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ToolsOzoneTeamAddMemberRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsOzoneTeamAddMemberRequest" /> class.
        /// </summary>
        /// <param name="did">did (required).</param>
        /// <param name="role">role (required).</param>
        public ToolsOzoneTeamAddMemberRequest(string did = default(string), RoleEnum role = default(RoleEnum))
        {
            // to ensure "did" is required (not null)
            if (did == null)
            {
                throw new ArgumentNullException("did is a required property for ToolsOzoneTeamAddMemberRequest and cannot be null");
            }
            this.Did = did;
            this.Role = role;
        }

        /// <summary>
        /// Gets or Sets Did
        /// </summary>
        [DataMember(Name = "did", IsRequired = true, EmitDefaultValue = true)]
        public string Did { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ToolsOzoneTeamAddMemberRequest {\n");
            sb.Append("  Did: ").Append(Did).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
