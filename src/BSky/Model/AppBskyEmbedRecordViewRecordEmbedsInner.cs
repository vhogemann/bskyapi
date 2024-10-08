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
using System.Reflection;

namespace BSky.Model
{
    /// <summary>
    /// AppBskyEmbedRecordViewRecordEmbedsInner
    /// </summary>
    [JsonConverter(typeof(AppBskyEmbedRecordViewRecordEmbedsInnerJsonConverter))]
    [DataContract(Name = "app_bsky_embed_record_viewRecord_embeds_inner")]
    public partial class AppBskyEmbedRecordViewRecordEmbedsInner : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedRecordViewRecordEmbedsInner" /> class
        /// with the <see cref="AppBskyEmbedImagesView" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppBskyEmbedImagesView.</param>
        public AppBskyEmbedRecordViewRecordEmbedsInner(AppBskyEmbedImagesView actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedRecordViewRecordEmbedsInner" /> class
        /// with the <see cref="AppBskyEmbedVideoView" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppBskyEmbedVideoView.</param>
        public AppBskyEmbedRecordViewRecordEmbedsInner(AppBskyEmbedVideoView actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedRecordViewRecordEmbedsInner" /> class
        /// with the <see cref="AppBskyEmbedExternalView" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppBskyEmbedExternalView.</param>
        public AppBskyEmbedRecordViewRecordEmbedsInner(AppBskyEmbedExternalView actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedRecordViewRecordEmbedsInner" /> class
        /// with the <see cref="AppBskyEmbedRecordView" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppBskyEmbedRecordView.</param>
        public AppBskyEmbedRecordViewRecordEmbedsInner(AppBskyEmbedRecordView actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedRecordViewRecordEmbedsInner" /> class
        /// with the <see cref="AppBskyEmbedRecordWithMediaView" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppBskyEmbedRecordWithMediaView.</param>
        public AppBskyEmbedRecordViewRecordEmbedsInner(AppBskyEmbedRecordWithMediaView actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(AppBskyEmbedExternalView) || value is AppBskyEmbedExternalView)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppBskyEmbedImagesView) || value is AppBskyEmbedImagesView)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppBskyEmbedRecordView) || value is AppBskyEmbedRecordView)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppBskyEmbedRecordWithMediaView) || value is AppBskyEmbedRecordWithMediaView)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppBskyEmbedVideoView) || value is AppBskyEmbedVideoView)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AppBskyEmbedExternalView, AppBskyEmbedImagesView, AppBskyEmbedRecordView, AppBskyEmbedRecordWithMediaView, AppBskyEmbedVideoView");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AppBskyEmbedImagesView`. If the actual instance is not `AppBskyEmbedImagesView`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppBskyEmbedImagesView</returns>
        public AppBskyEmbedImagesView GetAppBskyEmbedImagesView()
        {
            return (AppBskyEmbedImagesView)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppBskyEmbedVideoView`. If the actual instance is not `AppBskyEmbedVideoView`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppBskyEmbedVideoView</returns>
        public AppBskyEmbedVideoView GetAppBskyEmbedVideoView()
        {
            return (AppBskyEmbedVideoView)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppBskyEmbedExternalView`. If the actual instance is not `AppBskyEmbedExternalView`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppBskyEmbedExternalView</returns>
        public AppBskyEmbedExternalView GetAppBskyEmbedExternalView()
        {
            return (AppBskyEmbedExternalView)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppBskyEmbedRecordView`. If the actual instance is not `AppBskyEmbedRecordView`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppBskyEmbedRecordView</returns>
        public AppBskyEmbedRecordView GetAppBskyEmbedRecordView()
        {
            return (AppBskyEmbedRecordView)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppBskyEmbedRecordWithMediaView`. If the actual instance is not `AppBskyEmbedRecordWithMediaView`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppBskyEmbedRecordWithMediaView</returns>
        public AppBskyEmbedRecordWithMediaView GetAppBskyEmbedRecordWithMediaView()
        {
            return (AppBskyEmbedRecordWithMediaView)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppBskyEmbedRecordViewRecordEmbedsInner {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, AppBskyEmbedRecordViewRecordEmbedsInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AppBskyEmbedRecordViewRecordEmbedsInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AppBskyEmbedRecordViewRecordEmbedsInner</returns>
        public static AppBskyEmbedRecordViewRecordEmbedsInner FromJson(string jsonString)
        {
            AppBskyEmbedRecordViewRecordEmbedsInner newAppBskyEmbedRecordViewRecordEmbedsInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAppBskyEmbedRecordViewRecordEmbedsInner;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppBskyEmbedExternalView).GetProperty("AdditionalProperties") == null)
                {
                    newAppBskyEmbedRecordViewRecordEmbedsInner = new AppBskyEmbedRecordViewRecordEmbedsInner(JsonConvert.DeserializeObject<AppBskyEmbedExternalView>(jsonString, AppBskyEmbedRecordViewRecordEmbedsInner.SerializerSettings));
                }
                else
                {
                    newAppBskyEmbedRecordViewRecordEmbedsInner = new AppBskyEmbedRecordViewRecordEmbedsInner(JsonConvert.DeserializeObject<AppBskyEmbedExternalView>(jsonString, AppBskyEmbedRecordViewRecordEmbedsInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppBskyEmbedExternalView");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppBskyEmbedExternalView: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppBskyEmbedImagesView).GetProperty("AdditionalProperties") == null)
                {
                    newAppBskyEmbedRecordViewRecordEmbedsInner = new AppBskyEmbedRecordViewRecordEmbedsInner(JsonConvert.DeserializeObject<AppBskyEmbedImagesView>(jsonString, AppBskyEmbedRecordViewRecordEmbedsInner.SerializerSettings));
                }
                else
                {
                    newAppBskyEmbedRecordViewRecordEmbedsInner = new AppBskyEmbedRecordViewRecordEmbedsInner(JsonConvert.DeserializeObject<AppBskyEmbedImagesView>(jsonString, AppBskyEmbedRecordViewRecordEmbedsInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppBskyEmbedImagesView");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppBskyEmbedImagesView: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppBskyEmbedRecordView).GetProperty("AdditionalProperties") == null)
                {
                    newAppBskyEmbedRecordViewRecordEmbedsInner = new AppBskyEmbedRecordViewRecordEmbedsInner(JsonConvert.DeserializeObject<AppBskyEmbedRecordView>(jsonString, AppBskyEmbedRecordViewRecordEmbedsInner.SerializerSettings));
                }
                else
                {
                    newAppBskyEmbedRecordViewRecordEmbedsInner = new AppBskyEmbedRecordViewRecordEmbedsInner(JsonConvert.DeserializeObject<AppBskyEmbedRecordView>(jsonString, AppBskyEmbedRecordViewRecordEmbedsInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppBskyEmbedRecordView");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppBskyEmbedRecordView: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppBskyEmbedRecordWithMediaView).GetProperty("AdditionalProperties") == null)
                {
                    newAppBskyEmbedRecordViewRecordEmbedsInner = new AppBskyEmbedRecordViewRecordEmbedsInner(JsonConvert.DeserializeObject<AppBskyEmbedRecordWithMediaView>(jsonString, AppBskyEmbedRecordViewRecordEmbedsInner.SerializerSettings));
                }
                else
                {
                    newAppBskyEmbedRecordViewRecordEmbedsInner = new AppBskyEmbedRecordViewRecordEmbedsInner(JsonConvert.DeserializeObject<AppBskyEmbedRecordWithMediaView>(jsonString, AppBskyEmbedRecordViewRecordEmbedsInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppBskyEmbedRecordWithMediaView");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppBskyEmbedRecordWithMediaView: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppBskyEmbedVideoView).GetProperty("AdditionalProperties") == null)
                {
                    newAppBskyEmbedRecordViewRecordEmbedsInner = new AppBskyEmbedRecordViewRecordEmbedsInner(JsonConvert.DeserializeObject<AppBskyEmbedVideoView>(jsonString, AppBskyEmbedRecordViewRecordEmbedsInner.SerializerSettings));
                }
                else
                {
                    newAppBskyEmbedRecordViewRecordEmbedsInner = new AppBskyEmbedRecordViewRecordEmbedsInner(JsonConvert.DeserializeObject<AppBskyEmbedVideoView>(jsonString, AppBskyEmbedRecordViewRecordEmbedsInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppBskyEmbedVideoView");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppBskyEmbedVideoView: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newAppBskyEmbedRecordViewRecordEmbedsInner;
        }


        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for AppBskyEmbedRecordViewRecordEmbedsInner
    /// </summary>
    public class AppBskyEmbedRecordViewRecordEmbedsInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AppBskyEmbedRecordViewRecordEmbedsInner).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return AppBskyEmbedRecordViewRecordEmbedsInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return AppBskyEmbedRecordViewRecordEmbedsInner.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
