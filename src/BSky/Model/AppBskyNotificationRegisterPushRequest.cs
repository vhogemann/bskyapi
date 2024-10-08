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
    /// AppBskyNotificationRegisterPushRequest
    /// </summary>
    [DataContract(Name = "app_bsky_notification_registerPush_request")]
    public partial class AppBskyNotificationRegisterPushRequest : IValidatableObject
    {
        /// <summary>
        /// Defines Platform
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PlatformEnum
        {
            /// <summary>
            /// Enum Ios for value: ios
            /// </summary>
            [EnumMember(Value = "ios")]
            Ios = 1,

            /// <summary>
            /// Enum Android for value: android
            /// </summary>
            [EnumMember(Value = "android")]
            Android = 2,

            /// <summary>
            /// Enum Web for value: web
            /// </summary>
            [EnumMember(Value = "web")]
            Web = 3
        }


        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = true)]
        public PlatformEnum Platform { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyNotificationRegisterPushRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyNotificationRegisterPushRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyNotificationRegisterPushRequest" /> class.
        /// </summary>
        /// <param name="serviceDid">serviceDid (required).</param>
        /// <param name="token">token (required).</param>
        /// <param name="platform">platform (required).</param>
        /// <param name="appId">appId (required).</param>
        public AppBskyNotificationRegisterPushRequest(string serviceDid = default(string), string token = default(string), PlatformEnum platform = default(PlatformEnum), string appId = default(string))
        {
            // to ensure "serviceDid" is required (not null)
            if (serviceDid == null)
            {
                throw new ArgumentNullException("serviceDid is a required property for AppBskyNotificationRegisterPushRequest and cannot be null");
            }
            this.ServiceDid = serviceDid;
            // to ensure "token" is required (not null)
            if (token == null)
            {
                throw new ArgumentNullException("token is a required property for AppBskyNotificationRegisterPushRequest and cannot be null");
            }
            this.Token = token;
            this.Platform = platform;
            // to ensure "appId" is required (not null)
            if (appId == null)
            {
                throw new ArgumentNullException("appId is a required property for AppBskyNotificationRegisterPushRequest and cannot be null");
            }
            this.AppId = appId;
        }

        /// <summary>
        /// Gets or Sets ServiceDid
        /// </summary>
        [DataMember(Name = "serviceDid", IsRequired = true, EmitDefaultValue = true)]
        public string ServiceDid { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", IsRequired = true, EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets AppId
        /// </summary>
        [DataMember(Name = "appId", IsRequired = true, EmitDefaultValue = true)]
        public string AppId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyNotificationRegisterPushRequest {\n");
            sb.Append("  ServiceDid: ").Append(ServiceDid).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
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
