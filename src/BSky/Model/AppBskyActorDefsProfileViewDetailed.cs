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
    /// AppBskyActorDefsProfileViewDetailed
    /// </summary>
    [DataContract(Name = "app.bsky.actor.defs.profileViewDetailed")]
    public partial class AppBskyActorDefsProfileViewDetailed : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyActorDefsProfileViewDetailed" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyActorDefsProfileViewDetailed() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyActorDefsProfileViewDetailed" /> class.
        /// </summary>
        /// <param name="did">did (required).</param>
        /// <param name="handle">handle (required).</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="description">description.</param>
        /// <param name="avatar">avatar.</param>
        /// <param name="banner">banner.</param>
        /// <param name="followersCount">followersCount.</param>
        /// <param name="followsCount">followsCount.</param>
        /// <param name="postsCount">postsCount.</param>
        /// <param name="associated">associated.</param>
        /// <param name="joinedViaStarterPack">joinedViaStarterPack.</param>
        /// <param name="indexedAt">indexedAt.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="viewer">viewer.</param>
        /// <param name="labels">labels.</param>
        public AppBskyActorDefsProfileViewDetailed(string did = default(string), string handle = default(string), string displayName = default(string), string description = default(string), string avatar = default(string), string banner = default(string), int followersCount = default(int), int followsCount = default(int), int postsCount = default(int), AppBskyActorDefsProfileAssociated associated = default(AppBskyActorDefsProfileAssociated), AppBskyGraphDefsStarterPackViewBasic joinedViaStarterPack = default(AppBskyGraphDefsStarterPackViewBasic), DateTime indexedAt = default(DateTime), DateTime createdAt = default(DateTime), AppBskyActorDefsViewerState viewer = default(AppBskyActorDefsViewerState), List<ComAtprotoLabelDefsLabel> labels = default(List<ComAtprotoLabelDefsLabel>))
        {
            // to ensure "did" is required (not null)
            if (did == null)
            {
                throw new ArgumentNullException("did is a required property for AppBskyActorDefsProfileViewDetailed and cannot be null");
            }
            this.Did = did;
            // to ensure "handle" is required (not null)
            if (handle == null)
            {
                throw new ArgumentNullException("handle is a required property for AppBskyActorDefsProfileViewDetailed and cannot be null");
            }
            this.Handle = handle;
            this.DisplayName = displayName;
            this.Description = description;
            this.Avatar = avatar;
            this.Banner = banner;
            this.FollowersCount = followersCount;
            this.FollowsCount = followsCount;
            this.PostsCount = postsCount;
            this.Associated = associated;
            this.JoinedViaStarterPack = joinedViaStarterPack;
            this.IndexedAt = indexedAt;
            this.CreatedAt = createdAt;
            this.Viewer = viewer;
            this.Labels = labels;
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
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [DataMember(Name = "avatar", EmitDefaultValue = false)]
        public string Avatar { get; set; }

        /// <summary>
        /// Gets or Sets Banner
        /// </summary>
        [DataMember(Name = "banner", EmitDefaultValue = false)]
        public string Banner { get; set; }

        /// <summary>
        /// Gets or Sets FollowersCount
        /// </summary>
        [DataMember(Name = "followersCount", EmitDefaultValue = false)]
        public int FollowersCount { get; set; }

        /// <summary>
        /// Gets or Sets FollowsCount
        /// </summary>
        [DataMember(Name = "followsCount", EmitDefaultValue = false)]
        public int FollowsCount { get; set; }

        /// <summary>
        /// Gets or Sets PostsCount
        /// </summary>
        [DataMember(Name = "postsCount", EmitDefaultValue = false)]
        public int PostsCount { get; set; }

        /// <summary>
        /// Gets or Sets Associated
        /// </summary>
        [DataMember(Name = "associated", EmitDefaultValue = false)]
        public AppBskyActorDefsProfileAssociated Associated { get; set; }

        /// <summary>
        /// Gets or Sets JoinedViaStarterPack
        /// </summary>
        [DataMember(Name = "joinedViaStarterPack", EmitDefaultValue = false)]
        public AppBskyGraphDefsStarterPackViewBasic JoinedViaStarterPack { get; set; }

        /// <summary>
        /// Gets or Sets IndexedAt
        /// </summary>
        [DataMember(Name = "indexedAt", EmitDefaultValue = false)]
        public DateTime IndexedAt { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Viewer
        /// </summary>
        [DataMember(Name = "viewer", EmitDefaultValue = false)]
        public AppBskyActorDefsViewerState Viewer { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public List<ComAtprotoLabelDefsLabel> Labels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyActorDefsProfileViewDetailed {\n");
            sb.Append("  Did: ").Append(Did).Append("\n");
            sb.Append("  Handle: ").Append(Handle).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  Banner: ").Append(Banner).Append("\n");
            sb.Append("  FollowersCount: ").Append(FollowersCount).Append("\n");
            sb.Append("  FollowsCount: ").Append(FollowsCount).Append("\n");
            sb.Append("  PostsCount: ").Append(PostsCount).Append("\n");
            sb.Append("  Associated: ").Append(Associated).Append("\n");
            sb.Append("  JoinedViaStarterPack: ").Append(JoinedViaStarterPack).Append("\n");
            sb.Append("  IndexedAt: ").Append(IndexedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Viewer: ").Append(Viewer).Append("\n");
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
            // DisplayName (string) maxLength
            if (this.DisplayName != null && this.DisplayName.Length > 640)
            {
                yield return new ValidationResult("Invalid value for DisplayName, length must be less than 640.", new [] { "DisplayName" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 2560)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 2560.", new [] { "Description" });
            }

            yield break;
        }
    }

}
