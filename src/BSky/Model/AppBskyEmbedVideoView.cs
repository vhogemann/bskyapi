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
    /// AppBskyEmbedVideoView
    /// </summary>
    [DataContract(Name = "app.bsky.embed.video.view")]
    public partial class AppBskyEmbedVideoView : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedVideoView" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyEmbedVideoView() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedVideoView" /> class.
        /// </summary>
        /// <param name="cid">cid (required).</param>
        /// <param name="playlist">playlist (required).</param>
        /// <param name="thumbnail">thumbnail.</param>
        /// <param name="alt">alt.</param>
        /// <param name="aspectRatio">aspectRatio.</param>
        public AppBskyEmbedVideoView(string cid = default(string), string playlist = default(string), string thumbnail = default(string), string alt = default(string), AppBskyEmbedDefsAspectRatio aspectRatio = default(AppBskyEmbedDefsAspectRatio))
        {
            // to ensure "cid" is required (not null)
            if (cid == null)
            {
                throw new ArgumentNullException("cid is a required property for AppBskyEmbedVideoView and cannot be null");
            }
            this.Cid = cid;
            // to ensure "playlist" is required (not null)
            if (playlist == null)
            {
                throw new ArgumentNullException("playlist is a required property for AppBskyEmbedVideoView and cannot be null");
            }
            this.Playlist = playlist;
            this.Thumbnail = thumbnail;
            this.Alt = alt;
            this.AspectRatio = aspectRatio;
        }

        /// <summary>
        /// Gets or Sets Cid
        /// </summary>
        [DataMember(Name = "cid", IsRequired = true, EmitDefaultValue = true)]
        public string Cid { get; set; }

        /// <summary>
        /// Gets or Sets Playlist
        /// </summary>
        [DataMember(Name = "playlist", IsRequired = true, EmitDefaultValue = true)]
        public string Playlist { get; set; }

        /// <summary>
        /// Gets or Sets Thumbnail
        /// </summary>
        [DataMember(Name = "thumbnail", EmitDefaultValue = false)]
        public string Thumbnail { get; set; }

        /// <summary>
        /// Gets or Sets Alt
        /// </summary>
        [DataMember(Name = "alt", EmitDefaultValue = false)]
        public string Alt { get; set; }

        /// <summary>
        /// Gets or Sets AspectRatio
        /// </summary>
        [DataMember(Name = "aspectRatio", EmitDefaultValue = false)]
        public AppBskyEmbedDefsAspectRatio AspectRatio { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyEmbedVideoView {\n");
            sb.Append("  Cid: ").Append(Cid).Append("\n");
            sb.Append("  Playlist: ").Append(Playlist).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  Alt: ").Append(Alt).Append("\n");
            sb.Append("  AspectRatio: ").Append(AspectRatio).Append("\n");
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
            // Alt (string) maxLength
            if (this.Alt != null && this.Alt.Length > 10000)
            {
                yield return new ValidationResult("Invalid value for Alt, length must be less than 10000.", new [] { "Alt" });
            }

            yield break;
        }
    }

}
