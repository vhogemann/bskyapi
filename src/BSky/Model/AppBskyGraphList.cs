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
    /// AppBskyGraphList
    /// </summary>
    [DataContract(Name = "app.bsky.graph.list")]
    public partial class AppBskyGraphList : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyGraphList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyGraphList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyGraphList" /> class.
        /// </summary>
        /// <param name="purpose">purpose (required).</param>
        /// <param name="name">Display name for list; can not be empty. (required).</param>
        /// <param name="description">description.</param>
        /// <param name="descriptionFacets">descriptionFacets.</param>
        /// <param name="avatar">avatar.</param>
        /// <param name="labels">labels.</param>
        /// <param name="createdAt">createdAt (required).</param>
        public AppBskyGraphList(AppBskyGraphDefsListPurpose purpose = default(AppBskyGraphDefsListPurpose), string name = default(string), string description = default(string), List<AppBskyRichtextFacet> descriptionFacets = default(List<AppBskyRichtextFacet>), System.IO.Stream avatar = default(System.IO.Stream), AppBskyActorProfileLabels labels = default(AppBskyActorProfileLabels), DateTime createdAt = default(DateTime))
        {
            // to ensure "purpose" is required (not null)
            if (purpose == null)
            {
                throw new ArgumentNullException("purpose is a required property for AppBskyGraphList and cannot be null");
            }
            this.Purpose = purpose;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AppBskyGraphList and cannot be null");
            }
            this.Name = name;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.DescriptionFacets = descriptionFacets;
            this.Avatar = avatar;
            this.Labels = labels;
        }

        /// <summary>
        /// Gets or Sets Purpose
        /// </summary>
        [DataMember(Name = "purpose", IsRequired = true, EmitDefaultValue = true)]
        public AppBskyGraphDefsListPurpose Purpose { get; set; }

        /// <summary>
        /// Display name for list; can not be empty.
        /// </summary>
        /// <value>Display name for list; can not be empty.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DescriptionFacets
        /// </summary>
        [DataMember(Name = "descriptionFacets", EmitDefaultValue = false)]
        public List<AppBskyRichtextFacet> DescriptionFacets { get; set; }

        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [DataMember(Name = "avatar", EmitDefaultValue = false)]
        public System.IO.Stream Avatar { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public AppBskyActorProfileLabels Labels { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyGraphList {\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DescriptionFacets: ").Append(DescriptionFacets).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 64)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 64.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 3000)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 3000.", new [] { "Description" });
            }

            // Avatar (System.IO.Stream) maxLength
            if (this.Avatar != null && this.Avatar.Length > 1000000)
            {
                yield return new ValidationResult("Invalid value for Avatar, length must be less than 1000000.", new [] { "Avatar" });
            }

            yield break;
        }
    }

}