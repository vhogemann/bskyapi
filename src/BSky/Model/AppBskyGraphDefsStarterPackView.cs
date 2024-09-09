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
    /// AppBskyGraphDefsStarterPackView
    /// </summary>
    [DataContract(Name = "app.bsky.graph.defs.starterPackView")]
    public partial class AppBskyGraphDefsStarterPackView : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyGraphDefsStarterPackView" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyGraphDefsStarterPackView() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyGraphDefsStarterPackView" /> class.
        /// </summary>
        /// <param name="uri">uri (required).</param>
        /// <param name="cid">cid (required).</param>
        /// <param name="record">record (required).</param>
        /// <param name="creator">creator (required).</param>
        /// <param name="list">list.</param>
        /// <param name="listItemsSample">listItemsSample.</param>
        /// <param name="feeds">feeds.</param>
        /// <param name="joinedWeekCount">joinedWeekCount.</param>
        /// <param name="joinedAllTimeCount">joinedAllTimeCount.</param>
        /// <param name="labels">labels.</param>
        /// <param name="indexedAt">indexedAt (required).</param>
        public AppBskyGraphDefsStarterPackView(string uri = default(string), string cid = default(string), Object record = default(Object), AppBskyActorDefsProfileViewBasic creator = default(AppBskyActorDefsProfileViewBasic), AppBskyGraphDefsListViewBasic list = default(AppBskyGraphDefsListViewBasic), List<AppBskyGraphDefsListItemView> listItemsSample = default(List<AppBskyGraphDefsListItemView>), List<AppBskyFeedDefsGeneratorView> feeds = default(List<AppBskyFeedDefsGeneratorView>), int joinedWeekCount = default(int), int joinedAllTimeCount = default(int), List<ComAtprotoLabelDefsLabel> labels = default(List<ComAtprotoLabelDefsLabel>), DateTime indexedAt = default(DateTime))
        {
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new ArgumentNullException("uri is a required property for AppBskyGraphDefsStarterPackView and cannot be null");
            }
            this.Uri = uri;
            // to ensure "cid" is required (not null)
            if (cid == null)
            {
                throw new ArgumentNullException("cid is a required property for AppBskyGraphDefsStarterPackView and cannot be null");
            }
            this.Cid = cid;
            // to ensure "record" is required (not null)
            if (record == null)
            {
                throw new ArgumentNullException("record is a required property for AppBskyGraphDefsStarterPackView and cannot be null");
            }
            this.Record = record;
            // to ensure "creator" is required (not null)
            if (creator == null)
            {
                throw new ArgumentNullException("creator is a required property for AppBskyGraphDefsStarterPackView and cannot be null");
            }
            this.Creator = creator;
            this.IndexedAt = indexedAt;
            this.List = list;
            this.ListItemsSample = listItemsSample;
            this.Feeds = feeds;
            this.JoinedWeekCount = joinedWeekCount;
            this.JoinedAllTimeCount = joinedAllTimeCount;
            this.Labels = labels;
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
        /// Gets or Sets Record
        /// </summary>
        [DataMember(Name = "record", IsRequired = true, EmitDefaultValue = true)]
        public Object Record { get; set; }

        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        [DataMember(Name = "creator", IsRequired = true, EmitDefaultValue = true)]
        public AppBskyActorDefsProfileViewBasic Creator { get; set; }

        /// <summary>
        /// Gets or Sets List
        /// </summary>
        [DataMember(Name = "list", EmitDefaultValue = false)]
        public AppBskyGraphDefsListViewBasic List { get; set; }

        /// <summary>
        /// Gets or Sets ListItemsSample
        /// </summary>
        [DataMember(Name = "listItemsSample", EmitDefaultValue = false)]
        public List<AppBskyGraphDefsListItemView> ListItemsSample { get; set; }

        /// <summary>
        /// Gets or Sets Feeds
        /// </summary>
        [DataMember(Name = "feeds", EmitDefaultValue = false)]
        public List<AppBskyFeedDefsGeneratorView> Feeds { get; set; }

        /// <summary>
        /// Gets or Sets JoinedWeekCount
        /// </summary>
        [DataMember(Name = "joinedWeekCount", EmitDefaultValue = false)]
        public int JoinedWeekCount { get; set; }

        /// <summary>
        /// Gets or Sets JoinedAllTimeCount
        /// </summary>
        [DataMember(Name = "joinedAllTimeCount", EmitDefaultValue = false)]
        public int JoinedAllTimeCount { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public List<ComAtprotoLabelDefsLabel> Labels { get; set; }

        /// <summary>
        /// Gets or Sets IndexedAt
        /// </summary>
        [DataMember(Name = "indexedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime IndexedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyGraphDefsStarterPackView {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Cid: ").Append(Cid).Append("\n");
            sb.Append("  Record: ").Append(Record).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  List: ").Append(List).Append("\n");
            sb.Append("  ListItemsSample: ").Append(ListItemsSample).Append("\n");
            sb.Append("  Feeds: ").Append(Feeds).Append("\n");
            sb.Append("  JoinedWeekCount: ").Append(JoinedWeekCount).Append("\n");
            sb.Append("  JoinedAllTimeCount: ").Append(JoinedAllTimeCount).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  IndexedAt: ").Append(IndexedAt).Append("\n");
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
            // JoinedWeekCount (int) minimum
            if (this.JoinedWeekCount < (int)0)
            {
                yield return new ValidationResult("Invalid value for JoinedWeekCount, must be a value greater than or equal to 0.", new [] { "JoinedWeekCount" });
            }

            // JoinedAllTimeCount (int) minimum
            if (this.JoinedAllTimeCount < (int)0)
            {
                yield return new ValidationResult("Invalid value for JoinedAllTimeCount, must be a value greater than or equal to 0.", new [] { "JoinedAllTimeCount" });
            }

            yield break;
        }
    }

}