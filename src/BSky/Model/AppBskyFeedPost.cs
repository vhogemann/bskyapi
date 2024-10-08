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
    /// AppBskyFeedPost
    /// </summary>
    [DataContract(Name = "app.bsky.feed.post")]
    public partial class AppBskyFeedPost : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyFeedPost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyFeedPost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyFeedPost" /> class.
        /// </summary>
        /// <param name="text">The primary post content. May be an empty string, if there are embeds. (required).</param>
        /// <param name="facets">facets.</param>
        /// <param name="reply">reply.</param>
        /// <param name="embed">embed.</param>
        /// <param name="langs">langs.</param>
        /// <param name="labels">labels.</param>
        /// <param name="tags">tags.</param>
        /// <param name="createdAt">Client-declared timestamp when this post was originally created. (required).</param>
        public AppBskyFeedPost(string text = default(string), List<AppBskyRichtextFacet> facets = default(List<AppBskyRichtextFacet>), AppBskyFeedPostReplyRef reply = default(AppBskyFeedPostReplyRef), AppBskyFeedPostEmbed embed = default(AppBskyFeedPostEmbed), List<string> langs = default(List<string>), AppBskyActorProfileLabels labels = default(AppBskyActorProfileLabels), List<string> tags = default(List<string>), DateTime createdAt = default(DateTime))
        {
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new ArgumentNullException("text is a required property for AppBskyFeedPost and cannot be null");
            }
            this.Text = text;
            this.CreatedAt = createdAt;
            this.Facets = facets;
            this.Reply = reply;
            this.Embed = embed;
            this.Langs = langs;
            this.Labels = labels;
            this.Tags = tags;
        }

        /// <summary>
        /// The primary post content. May be an empty string, if there are embeds.
        /// </summary>
        /// <value>The primary post content. May be an empty string, if there are embeds.</value>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Facets
        /// </summary>
        [DataMember(Name = "facets", EmitDefaultValue = false)]
        public List<AppBskyRichtextFacet> Facets { get; set; }

        /// <summary>
        /// Gets or Sets Reply
        /// </summary>
        [DataMember(Name = "reply", EmitDefaultValue = false)]
        public AppBskyFeedPostReplyRef Reply { get; set; }

        /// <summary>
        /// Gets or Sets Embed
        /// </summary>
        [DataMember(Name = "embed", EmitDefaultValue = false)]
        public AppBskyFeedPostEmbed Embed { get; set; }

        /// <summary>
        /// Gets or Sets Langs
        /// </summary>
        [DataMember(Name = "langs", EmitDefaultValue = false)]
        public List<string> Langs { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public AppBskyActorProfileLabels Labels { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Client-declared timestamp when this post was originally created.
        /// </summary>
        /// <value>Client-declared timestamp when this post was originally created.</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyFeedPost {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Facets: ").Append(Facets).Append("\n");
            sb.Append("  Reply: ").Append(Reply).Append("\n");
            sb.Append("  Embed: ").Append(Embed).Append("\n");
            sb.Append("  Langs: ").Append(Langs).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            // Text (string) maxLength
            if (this.Text != null && this.Text.Length > 3000)
            {
                yield return new ValidationResult("Invalid value for Text, length must be less than 3000.", new [] { "Text" });
            }

            yield break;
        }
    }

}
