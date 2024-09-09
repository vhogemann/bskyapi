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
    /// AppBskyFeedDefsPostView
    /// </summary>
    [DataContract(Name = "app.bsky.feed.defs.postView")]
    public partial class AppBskyFeedDefsPostView : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyFeedDefsPostView" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyFeedDefsPostView() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyFeedDefsPostView" /> class.
        /// </summary>
        /// <param name="uri">uri (required).</param>
        /// <param name="cid">cid (required).</param>
        /// <param name="author">author (required).</param>
        /// <param name="record">record (required).</param>
        /// <param name="embed">embed.</param>
        /// <param name="replyCount">replyCount.</param>
        /// <param name="repostCount">repostCount.</param>
        /// <param name="likeCount">likeCount.</param>
        /// <param name="quoteCount">quoteCount.</param>
        /// <param name="indexedAt">indexedAt (required).</param>
        /// <param name="viewer">viewer.</param>
        /// <param name="labels">labels.</param>
        /// <param name="threadgate">threadgate.</param>
        public AppBskyFeedDefsPostView(string uri = default(string), string cid = default(string), AppBskyActorDefsProfileViewBasic author = default(AppBskyActorDefsProfileViewBasic), Object record = default(Object), AppBskyEmbedRecordViewRecordEmbedsInner embed = default(AppBskyEmbedRecordViewRecordEmbedsInner), int replyCount = default(int), int repostCount = default(int), int likeCount = default(int), int quoteCount = default(int), DateTime indexedAt = default(DateTime), AppBskyFeedDefsViewerState viewer = default(AppBskyFeedDefsViewerState), List<ComAtprotoLabelDefsLabel> labels = default(List<ComAtprotoLabelDefsLabel>), AppBskyFeedDefsThreadgateView threadgate = default(AppBskyFeedDefsThreadgateView))
        {
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new ArgumentNullException("uri is a required property for AppBskyFeedDefsPostView and cannot be null");
            }
            this.Uri = uri;
            // to ensure "cid" is required (not null)
            if (cid == null)
            {
                throw new ArgumentNullException("cid is a required property for AppBskyFeedDefsPostView and cannot be null");
            }
            this.Cid = cid;
            // to ensure "author" is required (not null)
            if (author == null)
            {
                throw new ArgumentNullException("author is a required property for AppBskyFeedDefsPostView and cannot be null");
            }
            this.Author = author;
            // to ensure "record" is required (not null)
            if (record == null)
            {
                throw new ArgumentNullException("record is a required property for AppBskyFeedDefsPostView and cannot be null");
            }
            this.Record = record;
            this.IndexedAt = indexedAt;
            this.Embed = embed;
            this.ReplyCount = replyCount;
            this.RepostCount = repostCount;
            this.LikeCount = likeCount;
            this.QuoteCount = quoteCount;
            this.Viewer = viewer;
            this.Labels = labels;
            this.Threadgate = threadgate;
        }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name = "uri", IsRequired = true, EmitDefaultValue = true)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets Cid
        /// </summary>
        [DataMember(Name = "cid", IsRequired = true, EmitDefaultValue = true)]
        public string Cid { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name = "author", IsRequired = true, EmitDefaultValue = true)]
        public AppBskyActorDefsProfileViewBasic Author { get; set; }

        /// <summary>
        /// Gets or Sets Record
        /// </summary>
        [DataMember(Name = "record", IsRequired = true, EmitDefaultValue = true)]
        public Object Record { get; set; }

        /// <summary>
        /// Gets or Sets Embed
        /// </summary>
        [DataMember(Name = "embed", EmitDefaultValue = false)]
        public AppBskyEmbedRecordViewRecordEmbedsInner Embed { get; set; }

        /// <summary>
        /// Gets or Sets ReplyCount
        /// </summary>
        [DataMember(Name = "replyCount", EmitDefaultValue = false)]
        public int ReplyCount { get; set; }

        /// <summary>
        /// Gets or Sets RepostCount
        /// </summary>
        [DataMember(Name = "repostCount", EmitDefaultValue = false)]
        public int RepostCount { get; set; }

        /// <summary>
        /// Gets or Sets LikeCount
        /// </summary>
        [DataMember(Name = "likeCount", EmitDefaultValue = false)]
        public int LikeCount { get; set; }

        /// <summary>
        /// Gets or Sets QuoteCount
        /// </summary>
        [DataMember(Name = "quoteCount", EmitDefaultValue = false)]
        public int QuoteCount { get; set; }

        /// <summary>
        /// Gets or Sets IndexedAt
        /// </summary>
        [DataMember(Name = "indexedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime IndexedAt { get; set; }

        /// <summary>
        /// Gets or Sets Viewer
        /// </summary>
        [DataMember(Name = "viewer", EmitDefaultValue = false)]
        public AppBskyFeedDefsViewerState Viewer { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public List<ComAtprotoLabelDefsLabel> Labels { get; set; }

        /// <summary>
        /// Gets or Sets Threadgate
        /// </summary>
        [DataMember(Name = "threadgate", EmitDefaultValue = false)]
        public AppBskyFeedDefsThreadgateView Threadgate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyFeedDefsPostView {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Cid: ").Append(Cid).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Record: ").Append(Record).Append("\n");
            sb.Append("  Embed: ").Append(Embed).Append("\n");
            sb.Append("  ReplyCount: ").Append(ReplyCount).Append("\n");
            sb.Append("  RepostCount: ").Append(RepostCount).Append("\n");
            sb.Append("  LikeCount: ").Append(LikeCount).Append("\n");
            sb.Append("  QuoteCount: ").Append(QuoteCount).Append("\n");
            sb.Append("  IndexedAt: ").Append(IndexedAt).Append("\n");
            sb.Append("  Viewer: ").Append(Viewer).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Threadgate: ").Append(Threadgate).Append("\n");
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
