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
    /// AppBskyFeedGetActorFeeds200Response
    /// </summary>
    [DataContract(Name = "app_bsky_feed_getActorFeeds_200_response")]
    public partial class AppBskyFeedGetActorFeeds200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyFeedGetActorFeeds200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyFeedGetActorFeeds200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyFeedGetActorFeeds200Response" /> class.
        /// </summary>
        /// <param name="cursor">cursor.</param>
        /// <param name="feeds">feeds (required).</param>
        public AppBskyFeedGetActorFeeds200Response(string cursor = default(string), List<AppBskyFeedDefsGeneratorView> feeds = default(List<AppBskyFeedDefsGeneratorView>))
        {
            // to ensure "feeds" is required (not null)
            if (feeds == null)
            {
                throw new ArgumentNullException("feeds is a required property for AppBskyFeedGetActorFeeds200Response and cannot be null");
            }
            this.Feeds = feeds;
            this.Cursor = cursor;
        }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        public string Cursor { get; set; }

        /// <summary>
        /// Gets or Sets Feeds
        /// </summary>
        [DataMember(Name = "feeds", IsRequired = true, EmitDefaultValue = true)]
        public List<AppBskyFeedDefsGeneratorView> Feeds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyFeedGetActorFeeds200Response {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  Feeds: ").Append(Feeds).Append("\n");
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
