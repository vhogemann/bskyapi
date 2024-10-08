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
    /// AppBskyNotificationListNotifications200Response
    /// </summary>
    [DataContract(Name = "app_bsky_notification_listNotifications_200_response")]
    public partial class AppBskyNotificationListNotifications200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyNotificationListNotifications200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyNotificationListNotifications200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyNotificationListNotifications200Response" /> class.
        /// </summary>
        /// <param name="cursor">cursor.</param>
        /// <param name="notifications">notifications (required).</param>
        /// <param name="priority">priority.</param>
        /// <param name="seenAt">seenAt.</param>
        public AppBskyNotificationListNotifications200Response(string cursor = default(string), List<AppBskyNotificationListNotificationsNotification> notifications = default(List<AppBskyNotificationListNotificationsNotification>), bool priority = default(bool), DateTime seenAt = default(DateTime))
        {
            // to ensure "notifications" is required (not null)
            if (notifications == null)
            {
                throw new ArgumentNullException("notifications is a required property for AppBskyNotificationListNotifications200Response and cannot be null");
            }
            this.Notifications = notifications;
            this.Cursor = cursor;
            this.Priority = priority;
            this.SeenAt = seenAt;
        }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        public string Cursor { get; set; }

        /// <summary>
        /// Gets or Sets Notifications
        /// </summary>
        [DataMember(Name = "notifications", IsRequired = true, EmitDefaultValue = true)]
        public List<AppBskyNotificationListNotificationsNotification> Notifications { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = true)]
        public bool Priority { get; set; }

        /// <summary>
        /// Gets or Sets SeenAt
        /// </summary>
        [DataMember(Name = "seenAt", EmitDefaultValue = false)]
        public DateTime SeenAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyNotificationListNotifications200Response {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  Notifications: ").Append(Notifications).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  SeenAt: ").Append(SeenAt).Append("\n");
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
