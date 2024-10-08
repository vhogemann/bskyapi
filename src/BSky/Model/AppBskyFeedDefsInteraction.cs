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
    /// AppBskyFeedDefsInteraction
    /// </summary>
    [DataContract(Name = "app.bsky.feed.defs.interaction")]
    public partial class AppBskyFeedDefsInteraction : IValidatableObject
    {
        /// <summary>
        /// Defines Event
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventEnum
        {
            /// <summary>
            /// Enum RequestLess for value: app.bsky.feed.defs#requestLess
            /// </summary>
            [EnumMember(Value = "app.bsky.feed.defs#requestLess")]
            RequestLess = 1,

            /// <summary>
            /// Enum RequestMore for value: app.bsky.feed.defs#requestMore
            /// </summary>
            [EnumMember(Value = "app.bsky.feed.defs#requestMore")]
            RequestMore = 2,

            /// <summary>
            /// Enum ClickthroughItem for value: app.bsky.feed.defs#clickthroughItem
            /// </summary>
            [EnumMember(Value = "app.bsky.feed.defs#clickthroughItem")]
            ClickthroughItem = 3,

            /// <summary>
            /// Enum ClickthroughAuthor for value: app.bsky.feed.defs#clickthroughAuthor
            /// </summary>
            [EnumMember(Value = "app.bsky.feed.defs#clickthroughAuthor")]
            ClickthroughAuthor = 4,

            /// <summary>
            /// Enum ClickthroughReposter for value: app.bsky.feed.defs#clickthroughReposter
            /// </summary>
            [EnumMember(Value = "app.bsky.feed.defs#clickthroughReposter")]
            ClickthroughReposter = 5,

            /// <summary>
            /// Enum ClickthroughEmbed for value: app.bsky.feed.defs#clickthroughEmbed
            /// </summary>
            [EnumMember(Value = "app.bsky.feed.defs#clickthroughEmbed")]
            ClickthroughEmbed = 6,

            /// <summary>
            /// Enum InteractionSeen for value: app.bsky.feed.defs#interactionSeen
            /// </summary>
            [EnumMember(Value = "app.bsky.feed.defs#interactionSeen")]
            InteractionSeen = 7,

            /// <summary>
            /// Enum InteractionLike for value: app.bsky.feed.defs#interactionLike
            /// </summary>
            [EnumMember(Value = "app.bsky.feed.defs#interactionLike")]
            InteractionLike = 8,

            /// <summary>
            /// Enum InteractionRepost for value: app.bsky.feed.defs#interactionRepost
            /// </summary>
            [EnumMember(Value = "app.bsky.feed.defs#interactionRepost")]
            InteractionRepost = 9,

            /// <summary>
            /// Enum InteractionReply for value: app.bsky.feed.defs#interactionReply
            /// </summary>
            [EnumMember(Value = "app.bsky.feed.defs#interactionReply")]
            InteractionReply = 10,

            /// <summary>
            /// Enum InteractionQuote for value: app.bsky.feed.defs#interactionQuote
            /// </summary>
            [EnumMember(Value = "app.bsky.feed.defs#interactionQuote")]
            InteractionQuote = 11,

            /// <summary>
            /// Enum InteractionShare for value: app.bsky.feed.defs#interactionShare
            /// </summary>
            [EnumMember(Value = "app.bsky.feed.defs#interactionShare")]
            InteractionShare = 12
        }


        /// <summary>
        /// Gets or Sets Event
        /// </summary>
        [DataMember(Name = "event", EmitDefaultValue = false)]
        public EventEnum? Event { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyFeedDefsInteraction" /> class.
        /// </summary>
        /// <param name="item">item.</param>
        /// <param name="varEvent">varEvent.</param>
        /// <param name="feedContext">Context on a feed item that was originally supplied by the feed generator on getFeedSkeleton..</param>
        public AppBskyFeedDefsInteraction(string item = default(string), EventEnum? varEvent = default(EventEnum?), string feedContext = default(string))
        {
            this.Item = item;
            this.Event = varEvent;
            this.FeedContext = feedContext;
        }

        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name = "item", EmitDefaultValue = false)]
        public string Item { get; set; }

        /// <summary>
        /// Context on a feed item that was originally supplied by the feed generator on getFeedSkeleton.
        /// </summary>
        /// <value>Context on a feed item that was originally supplied by the feed generator on getFeedSkeleton.</value>
        [DataMember(Name = "feedContext", EmitDefaultValue = false)]
        public string FeedContext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyFeedDefsInteraction {\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  FeedContext: ").Append(FeedContext).Append("\n");
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
            // FeedContext (string) maxLength
            if (this.FeedContext != null && this.FeedContext.Length > 2000)
            {
                yield return new ValidationResult("Invalid value for FeedContext, length must be less than 2000.", new [] { "FeedContext" });
            }

            yield break;
        }
    }

}
