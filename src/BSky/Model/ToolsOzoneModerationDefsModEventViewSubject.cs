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
    /// ToolsOzoneModerationDefsModEventViewSubject
    /// </summary>
    [JsonConverter(typeof(ToolsOzoneModerationDefsModEventViewSubjectJsonConverter))]
    [DataContract(Name = "tools_ozone_moderation_defs_modEventView_subject")]
    public partial class ToolsOzoneModerationDefsModEventViewSubject : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsOzoneModerationDefsModEventViewSubject" /> class
        /// with the <see cref="ComAtprotoAdminDefsRepoRef" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ComAtprotoAdminDefsRepoRef.</param>
        public ToolsOzoneModerationDefsModEventViewSubject(ComAtprotoAdminDefsRepoRef actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsOzoneModerationDefsModEventViewSubject" /> class
        /// with the <see cref="ComAtprotoRepoStrongRef" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ComAtprotoRepoStrongRef.</param>
        public ToolsOzoneModerationDefsModEventViewSubject(ComAtprotoRepoStrongRef actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsOzoneModerationDefsModEventViewSubject" /> class
        /// with the <see cref="ChatBskyConvoDefsMessageRef" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ChatBskyConvoDefsMessageRef.</param>
        public ToolsOzoneModerationDefsModEventViewSubject(ChatBskyConvoDefsMessageRef actualInstance)
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
                if (value.GetType() == typeof(ChatBskyConvoDefsMessageRef) || value is ChatBskyConvoDefsMessageRef)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ComAtprotoAdminDefsRepoRef) || value is ComAtprotoAdminDefsRepoRef)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ComAtprotoRepoStrongRef) || value is ComAtprotoRepoStrongRef)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ChatBskyConvoDefsMessageRef, ComAtprotoAdminDefsRepoRef, ComAtprotoRepoStrongRef");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ComAtprotoAdminDefsRepoRef`. If the actual instance is not `ComAtprotoAdminDefsRepoRef`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ComAtprotoAdminDefsRepoRef</returns>
        public ComAtprotoAdminDefsRepoRef GetComAtprotoAdminDefsRepoRef()
        {
            return (ComAtprotoAdminDefsRepoRef)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ComAtprotoRepoStrongRef`. If the actual instance is not `ComAtprotoRepoStrongRef`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ComAtprotoRepoStrongRef</returns>
        public ComAtprotoRepoStrongRef GetComAtprotoRepoStrongRef()
        {
            return (ComAtprotoRepoStrongRef)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ChatBskyConvoDefsMessageRef`. If the actual instance is not `ChatBskyConvoDefsMessageRef`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ChatBskyConvoDefsMessageRef</returns>
        public ChatBskyConvoDefsMessageRef GetChatBskyConvoDefsMessageRef()
        {
            return (ChatBskyConvoDefsMessageRef)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ToolsOzoneModerationDefsModEventViewSubject {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, ToolsOzoneModerationDefsModEventViewSubject.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ToolsOzoneModerationDefsModEventViewSubject
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ToolsOzoneModerationDefsModEventViewSubject</returns>
        public static ToolsOzoneModerationDefsModEventViewSubject FromJson(string jsonString)
        {
            ToolsOzoneModerationDefsModEventViewSubject newToolsOzoneModerationDefsModEventViewSubject = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newToolsOzoneModerationDefsModEventViewSubject;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ChatBskyConvoDefsMessageRef).GetProperty("AdditionalProperties") == null)
                {
                    newToolsOzoneModerationDefsModEventViewSubject = new ToolsOzoneModerationDefsModEventViewSubject(JsonConvert.DeserializeObject<ChatBskyConvoDefsMessageRef>(jsonString, ToolsOzoneModerationDefsModEventViewSubject.SerializerSettings));
                }
                else
                {
                    newToolsOzoneModerationDefsModEventViewSubject = new ToolsOzoneModerationDefsModEventViewSubject(JsonConvert.DeserializeObject<ChatBskyConvoDefsMessageRef>(jsonString, ToolsOzoneModerationDefsModEventViewSubject.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ChatBskyConvoDefsMessageRef");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ChatBskyConvoDefsMessageRef: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ComAtprotoAdminDefsRepoRef).GetProperty("AdditionalProperties") == null)
                {
                    newToolsOzoneModerationDefsModEventViewSubject = new ToolsOzoneModerationDefsModEventViewSubject(JsonConvert.DeserializeObject<ComAtprotoAdminDefsRepoRef>(jsonString, ToolsOzoneModerationDefsModEventViewSubject.SerializerSettings));
                }
                else
                {
                    newToolsOzoneModerationDefsModEventViewSubject = new ToolsOzoneModerationDefsModEventViewSubject(JsonConvert.DeserializeObject<ComAtprotoAdminDefsRepoRef>(jsonString, ToolsOzoneModerationDefsModEventViewSubject.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ComAtprotoAdminDefsRepoRef");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ComAtprotoAdminDefsRepoRef: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ComAtprotoRepoStrongRef).GetProperty("AdditionalProperties") == null)
                {
                    newToolsOzoneModerationDefsModEventViewSubject = new ToolsOzoneModerationDefsModEventViewSubject(JsonConvert.DeserializeObject<ComAtprotoRepoStrongRef>(jsonString, ToolsOzoneModerationDefsModEventViewSubject.SerializerSettings));
                }
                else
                {
                    newToolsOzoneModerationDefsModEventViewSubject = new ToolsOzoneModerationDefsModEventViewSubject(JsonConvert.DeserializeObject<ComAtprotoRepoStrongRef>(jsonString, ToolsOzoneModerationDefsModEventViewSubject.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ComAtprotoRepoStrongRef");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ComAtprotoRepoStrongRef: {1}", jsonString, exception.ToString()));
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
            return newToolsOzoneModerationDefsModEventViewSubject;
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
    /// Custom JSON converter for ToolsOzoneModerationDefsModEventViewSubject
    /// </summary>
    public class ToolsOzoneModerationDefsModEventViewSubjectJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ToolsOzoneModerationDefsModEventViewSubject).GetMethod("ToJson").Invoke(value, null)));
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
                    return ToolsOzoneModerationDefsModEventViewSubject.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return ToolsOzoneModerationDefsModEventViewSubject.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
