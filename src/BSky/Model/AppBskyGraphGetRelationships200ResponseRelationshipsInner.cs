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
    /// AppBskyGraphGetRelationships200ResponseRelationshipsInner
    /// </summary>
    [JsonConverter(typeof(AppBskyGraphGetRelationships200ResponseRelationshipsInnerJsonConverter))]
    [DataContract(Name = "app_bsky_graph_getRelationships_200_response_relationships_inner")]
    public partial class AppBskyGraphGetRelationships200ResponseRelationshipsInner : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyGraphGetRelationships200ResponseRelationshipsInner" /> class
        /// with the <see cref="AppBskyGraphDefsRelationship" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppBskyGraphDefsRelationship.</param>
        public AppBskyGraphGetRelationships200ResponseRelationshipsInner(AppBskyGraphDefsRelationship actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyGraphGetRelationships200ResponseRelationshipsInner" /> class
        /// with the <see cref="AppBskyGraphDefsNotFoundActor" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppBskyGraphDefsNotFoundActor.</param>
        public AppBskyGraphGetRelationships200ResponseRelationshipsInner(AppBskyGraphDefsNotFoundActor actualInstance)
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
                if (value.GetType() == typeof(AppBskyGraphDefsNotFoundActor) || value is AppBskyGraphDefsNotFoundActor)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppBskyGraphDefsRelationship) || value is AppBskyGraphDefsRelationship)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AppBskyGraphDefsNotFoundActor, AppBskyGraphDefsRelationship");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AppBskyGraphDefsRelationship`. If the actual instance is not `AppBskyGraphDefsRelationship`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppBskyGraphDefsRelationship</returns>
        public AppBskyGraphDefsRelationship GetAppBskyGraphDefsRelationship()
        {
            return (AppBskyGraphDefsRelationship)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppBskyGraphDefsNotFoundActor`. If the actual instance is not `AppBskyGraphDefsNotFoundActor`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppBskyGraphDefsNotFoundActor</returns>
        public AppBskyGraphDefsNotFoundActor GetAppBskyGraphDefsNotFoundActor()
        {
            return (AppBskyGraphDefsNotFoundActor)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppBskyGraphGetRelationships200ResponseRelationshipsInner {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AppBskyGraphGetRelationships200ResponseRelationshipsInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AppBskyGraphGetRelationships200ResponseRelationshipsInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AppBskyGraphGetRelationships200ResponseRelationshipsInner</returns>
        public static AppBskyGraphGetRelationships200ResponseRelationshipsInner FromJson(string jsonString)
        {
            AppBskyGraphGetRelationships200ResponseRelationshipsInner newAppBskyGraphGetRelationships200ResponseRelationshipsInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAppBskyGraphGetRelationships200ResponseRelationshipsInner;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppBskyGraphDefsNotFoundActor).GetProperty("AdditionalProperties") == null)
                {
                    newAppBskyGraphGetRelationships200ResponseRelationshipsInner = new AppBskyGraphGetRelationships200ResponseRelationshipsInner(JsonConvert.DeserializeObject<AppBskyGraphDefsNotFoundActor>(jsonString, AppBskyGraphGetRelationships200ResponseRelationshipsInner.SerializerSettings));
                }
                else
                {
                    newAppBskyGraphGetRelationships200ResponseRelationshipsInner = new AppBskyGraphGetRelationships200ResponseRelationshipsInner(JsonConvert.DeserializeObject<AppBskyGraphDefsNotFoundActor>(jsonString, AppBskyGraphGetRelationships200ResponseRelationshipsInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppBskyGraphDefsNotFoundActor");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppBskyGraphDefsNotFoundActor: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppBskyGraphDefsRelationship).GetProperty("AdditionalProperties") == null)
                {
                    newAppBskyGraphGetRelationships200ResponseRelationshipsInner = new AppBskyGraphGetRelationships200ResponseRelationshipsInner(JsonConvert.DeserializeObject<AppBskyGraphDefsRelationship>(jsonString, AppBskyGraphGetRelationships200ResponseRelationshipsInner.SerializerSettings));
                }
                else
                {
                    newAppBskyGraphGetRelationships200ResponseRelationshipsInner = new AppBskyGraphGetRelationships200ResponseRelationshipsInner(JsonConvert.DeserializeObject<AppBskyGraphDefsRelationship>(jsonString, AppBskyGraphGetRelationships200ResponseRelationshipsInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppBskyGraphDefsRelationship");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppBskyGraphDefsRelationship: {1}", jsonString, exception.ToString()));
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
            return newAppBskyGraphGetRelationships200ResponseRelationshipsInner;
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
    /// Custom JSON converter for AppBskyGraphGetRelationships200ResponseRelationshipsInner
    /// </summary>
    public class AppBskyGraphGetRelationships200ResponseRelationshipsInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AppBskyGraphGetRelationships200ResponseRelationshipsInner).GetMethod("ToJson").Invoke(value, null)));
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
                    return AppBskyGraphGetRelationships200ResponseRelationshipsInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return AppBskyGraphGetRelationships200ResponseRelationshipsInner.FromJson(JArray.Load(reader).ToString(Formatting.None));
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