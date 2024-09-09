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
    /// ToolsOzoneModerationDefsRepoViewDetail
    /// </summary>
    [DataContract(Name = "tools.ozone.moderation.defs.repoViewDetail")]
    public partial class ToolsOzoneModerationDefsRepoViewDetail : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsOzoneModerationDefsRepoViewDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ToolsOzoneModerationDefsRepoViewDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsOzoneModerationDefsRepoViewDetail" /> class.
        /// </summary>
        /// <param name="did">did (required).</param>
        /// <param name="handle">handle (required).</param>
        /// <param name="email">email.</param>
        /// <param name="relatedRecords">relatedRecords (required).</param>
        /// <param name="indexedAt">indexedAt (required).</param>
        /// <param name="moderation">moderation (required).</param>
        /// <param name="labels">labels.</param>
        /// <param name="invitedBy">invitedBy.</param>
        /// <param name="invites">invites.</param>
        /// <param name="invitesDisabled">invitesDisabled.</param>
        /// <param name="inviteNote">inviteNote.</param>
        /// <param name="emailConfirmedAt">emailConfirmedAt.</param>
        /// <param name="deactivatedAt">deactivatedAt.</param>
        public ToolsOzoneModerationDefsRepoViewDetail(string did = default(string), string handle = default(string), string email = default(string), List<Object> relatedRecords = default(List<Object>), DateTime indexedAt = default(DateTime), ToolsOzoneModerationDefsModerationDetail moderation = default(ToolsOzoneModerationDefsModerationDetail), List<ComAtprotoLabelDefsLabel> labels = default(List<ComAtprotoLabelDefsLabel>), ComAtprotoServerDefsInviteCode invitedBy = default(ComAtprotoServerDefsInviteCode), List<ComAtprotoServerDefsInviteCode> invites = default(List<ComAtprotoServerDefsInviteCode>), bool invitesDisabled = default(bool), string inviteNote = default(string), DateTime emailConfirmedAt = default(DateTime), DateTime deactivatedAt = default(DateTime))
        {
            // to ensure "did" is required (not null)
            if (did == null)
            {
                throw new ArgumentNullException("did is a required property for ToolsOzoneModerationDefsRepoViewDetail and cannot be null");
            }
            this.Did = did;
            // to ensure "handle" is required (not null)
            if (handle == null)
            {
                throw new ArgumentNullException("handle is a required property for ToolsOzoneModerationDefsRepoViewDetail and cannot be null");
            }
            this.Handle = handle;
            // to ensure "relatedRecords" is required (not null)
            if (relatedRecords == null)
            {
                throw new ArgumentNullException("relatedRecords is a required property for ToolsOzoneModerationDefsRepoViewDetail and cannot be null");
            }
            this.RelatedRecords = relatedRecords;
            this.IndexedAt = indexedAt;
            // to ensure "moderation" is required (not null)
            if (moderation == null)
            {
                throw new ArgumentNullException("moderation is a required property for ToolsOzoneModerationDefsRepoViewDetail and cannot be null");
            }
            this.Moderation = moderation;
            this.Email = email;
            this.Labels = labels;
            this.InvitedBy = invitedBy;
            this.Invites = invites;
            this.InvitesDisabled = invitesDisabled;
            this.InviteNote = inviteNote;
            this.EmailConfirmedAt = emailConfirmedAt;
            this.DeactivatedAt = deactivatedAt;
        }

        /// <summary>
        /// Gets or Sets Did
        /// </summary>
        [DataMember(Name = "did", IsRequired = true, EmitDefaultValue = true)]
        public string Did { get; set; }

        /// <summary>
        /// Gets or Sets Handle
        /// </summary>
        [DataMember(Name = "handle", IsRequired = true, EmitDefaultValue = true)]
        public string Handle { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets RelatedRecords
        /// </summary>
        [DataMember(Name = "relatedRecords", IsRequired = true, EmitDefaultValue = true)]
        public List<Object> RelatedRecords { get; set; }

        /// <summary>
        /// Gets or Sets IndexedAt
        /// </summary>
        [DataMember(Name = "indexedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime IndexedAt { get; set; }

        /// <summary>
        /// Gets or Sets Moderation
        /// </summary>
        [DataMember(Name = "moderation", IsRequired = true, EmitDefaultValue = true)]
        public ToolsOzoneModerationDefsModerationDetail Moderation { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public List<ComAtprotoLabelDefsLabel> Labels { get; set; }

        /// <summary>
        /// Gets or Sets InvitedBy
        /// </summary>
        [DataMember(Name = "invitedBy", EmitDefaultValue = false)]
        public ComAtprotoServerDefsInviteCode InvitedBy { get; set; }

        /// <summary>
        /// Gets or Sets Invites
        /// </summary>
        [DataMember(Name = "invites", EmitDefaultValue = false)]
        public List<ComAtprotoServerDefsInviteCode> Invites { get; set; }

        /// <summary>
        /// Gets or Sets InvitesDisabled
        /// </summary>
        [DataMember(Name = "invitesDisabled", EmitDefaultValue = true)]
        public bool InvitesDisabled { get; set; }

        /// <summary>
        /// Gets or Sets InviteNote
        /// </summary>
        [DataMember(Name = "inviteNote", EmitDefaultValue = false)]
        public string InviteNote { get; set; }

        /// <summary>
        /// Gets or Sets EmailConfirmedAt
        /// </summary>
        [DataMember(Name = "emailConfirmedAt", EmitDefaultValue = false)]
        public DateTime EmailConfirmedAt { get; set; }

        /// <summary>
        /// Gets or Sets DeactivatedAt
        /// </summary>
        [DataMember(Name = "deactivatedAt", EmitDefaultValue = false)]
        public DateTime DeactivatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ToolsOzoneModerationDefsRepoViewDetail {\n");
            sb.Append("  Did: ").Append(Did).Append("\n");
            sb.Append("  Handle: ").Append(Handle).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  RelatedRecords: ").Append(RelatedRecords).Append("\n");
            sb.Append("  IndexedAt: ").Append(IndexedAt).Append("\n");
            sb.Append("  Moderation: ").Append(Moderation).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  InvitedBy: ").Append(InvitedBy).Append("\n");
            sb.Append("  Invites: ").Append(Invites).Append("\n");
            sb.Append("  InvitesDisabled: ").Append(InvitesDisabled).Append("\n");
            sb.Append("  InviteNote: ").Append(InviteNote).Append("\n");
            sb.Append("  EmailConfirmedAt: ").Append(EmailConfirmedAt).Append("\n");
            sb.Append("  DeactivatedAt: ").Append(DeactivatedAt).Append("\n");
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
