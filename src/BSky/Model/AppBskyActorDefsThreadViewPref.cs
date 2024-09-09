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
    /// AppBskyActorDefsThreadViewPref
    /// </summary>
    [DataContract(Name = "app.bsky.actor.defs.threadViewPref")]
    public partial class AppBskyActorDefsThreadViewPref : IValidatableObject
    {
        /// <summary>
        /// Sorting mode for threads.
        /// </summary>
        /// <value>Sorting mode for threads.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SortEnum
        {
            /// <summary>
            /// Enum Oldest for value: oldest
            /// </summary>
            [EnumMember(Value = "oldest")]
            Oldest = 1,

            /// <summary>
            /// Enum Newest for value: newest
            /// </summary>
            [EnumMember(Value = "newest")]
            Newest = 2,

            /// <summary>
            /// Enum MostLikes for value: most-likes
            /// </summary>
            [EnumMember(Value = "most-likes")]
            MostLikes = 3,

            /// <summary>
            /// Enum Random for value: random
            /// </summary>
            [EnumMember(Value = "random")]
            Random = 4
        }


        /// <summary>
        /// Sorting mode for threads.
        /// </summary>
        /// <value>Sorting mode for threads.</value>
        [DataMember(Name = "sort", EmitDefaultValue = false)]
        public SortEnum? Sort { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyActorDefsThreadViewPref" /> class.
        /// </summary>
        /// <param name="sort">Sorting mode for threads..</param>
        /// <param name="prioritizeFollowedUsers">Show followed users at the top of all replies..</param>
        public AppBskyActorDefsThreadViewPref(SortEnum? sort = default(SortEnum?), bool prioritizeFollowedUsers = default(bool))
        {
            this.Sort = sort;
            this.PrioritizeFollowedUsers = prioritizeFollowedUsers;
        }

        /// <summary>
        /// Show followed users at the top of all replies.
        /// </summary>
        /// <value>Show followed users at the top of all replies.</value>
        [DataMember(Name = "prioritizeFollowedUsers", EmitDefaultValue = true)]
        public bool PrioritizeFollowedUsers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyActorDefsThreadViewPref {\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  PrioritizeFollowedUsers: ").Append(PrioritizeFollowedUsers).Append("\n");
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
