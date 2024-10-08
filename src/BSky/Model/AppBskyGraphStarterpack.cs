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
    /// AppBskyGraphStarterpack
    /// </summary>
    [DataContract(Name = "app.bsky.graph.starterpack")]
    public partial class AppBskyGraphStarterpack : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyGraphStarterpack" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyGraphStarterpack() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyGraphStarterpack" /> class.
        /// </summary>
        /// <param name="name">Display name for starter pack; can not be empty. (required).</param>
        /// <param name="description">description.</param>
        /// <param name="descriptionFacets">descriptionFacets.</param>
        /// <param name="list">Reference (AT-URI) to the list record. (required).</param>
        /// <param name="feeds">feeds.</param>
        /// <param name="createdAt">createdAt (required).</param>
        public AppBskyGraphStarterpack(string name = default(string), string description = default(string), List<AppBskyRichtextFacet> descriptionFacets = default(List<AppBskyRichtextFacet>), string list = default(string), List<AppBskyGraphStarterpackFeedItem> feeds = default(List<AppBskyGraphStarterpackFeedItem>), DateTime createdAt = default(DateTime))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AppBskyGraphStarterpack and cannot be null");
            }
            this.Name = name;
            // to ensure "list" is required (not null)
            if (list == null)
            {
                throw new ArgumentNullException("list is a required property for AppBskyGraphStarterpack and cannot be null");
            }
            this.List = list;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.DescriptionFacets = descriptionFacets;
            this.Feeds = feeds;
        }

        /// <summary>
        /// Display name for starter pack; can not be empty.
        /// </summary>
        /// <value>Display name for starter pack; can not be empty.</value>
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
        /// Reference (AT-URI) to the list record.
        /// </summary>
        /// <value>Reference (AT-URI) to the list record.</value>
        [DataMember(Name = "list", IsRequired = true, EmitDefaultValue = true)]
        public string List { get; set; }

        /// <summary>
        /// Gets or Sets Feeds
        /// </summary>
        [DataMember(Name = "feeds", EmitDefaultValue = false)]
        public List<AppBskyGraphStarterpackFeedItem> Feeds { get; set; }

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
            sb.Append("class AppBskyGraphStarterpack {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DescriptionFacets: ").Append(DescriptionFacets).Append("\n");
            sb.Append("  List: ").Append(List).Append("\n");
            sb.Append("  Feeds: ").Append(Feeds).Append("\n");
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
            if (this.Name != null && this.Name.Length > 500)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 500.", new [] { "Name" });
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

            yield break;
        }
    }

}
