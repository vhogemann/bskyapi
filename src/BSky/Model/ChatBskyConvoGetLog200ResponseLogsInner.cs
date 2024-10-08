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
    /// ChatBskyConvoGetLog200ResponseLogsInner
    /// </summary>
    [JsonConverter(typeof(ChatBskyConvoGetLog200ResponseLogsInnerJsonConverter))]
    [DataContract(Name = "chat_bsky_convo_getLog_200_response_logs_inner")]
    public partial class ChatBskyConvoGetLog200ResponseLogsInner : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBskyConvoGetLog200ResponseLogsInner" /> class
        /// with the <see cref="ChatBskyConvoDefsLogBeginConvo" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ChatBskyConvoDefsLogBeginConvo.</param>
        public ChatBskyConvoGetLog200ResponseLogsInner(ChatBskyConvoDefsLogBeginConvo actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBskyConvoGetLog200ResponseLogsInner" /> class
        /// with the <see cref="ChatBskyConvoDefsLogLeaveConvo" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ChatBskyConvoDefsLogLeaveConvo.</param>
        public ChatBskyConvoGetLog200ResponseLogsInner(ChatBskyConvoDefsLogLeaveConvo actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBskyConvoGetLog200ResponseLogsInner" /> class
        /// with the <see cref="ChatBskyConvoDefsLogCreateMessage" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ChatBskyConvoDefsLogCreateMessage.</param>
        public ChatBskyConvoGetLog200ResponseLogsInner(ChatBskyConvoDefsLogCreateMessage actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBskyConvoGetLog200ResponseLogsInner" /> class
        /// with the <see cref="ChatBskyConvoDefsLogDeleteMessage" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ChatBskyConvoDefsLogDeleteMessage.</param>
        public ChatBskyConvoGetLog200ResponseLogsInner(ChatBskyConvoDefsLogDeleteMessage actualInstance)
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
                if (value.GetType() == typeof(ChatBskyConvoDefsLogBeginConvo) || value is ChatBskyConvoDefsLogBeginConvo)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ChatBskyConvoDefsLogCreateMessage) || value is ChatBskyConvoDefsLogCreateMessage)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ChatBskyConvoDefsLogDeleteMessage) || value is ChatBskyConvoDefsLogDeleteMessage)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ChatBskyConvoDefsLogLeaveConvo) || value is ChatBskyConvoDefsLogLeaveConvo)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ChatBskyConvoDefsLogBeginConvo, ChatBskyConvoDefsLogCreateMessage, ChatBskyConvoDefsLogDeleteMessage, ChatBskyConvoDefsLogLeaveConvo");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ChatBskyConvoDefsLogBeginConvo`. If the actual instance is not `ChatBskyConvoDefsLogBeginConvo`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ChatBskyConvoDefsLogBeginConvo</returns>
        public ChatBskyConvoDefsLogBeginConvo GetChatBskyConvoDefsLogBeginConvo()
        {
            return (ChatBskyConvoDefsLogBeginConvo)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ChatBskyConvoDefsLogLeaveConvo`. If the actual instance is not `ChatBskyConvoDefsLogLeaveConvo`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ChatBskyConvoDefsLogLeaveConvo</returns>
        public ChatBskyConvoDefsLogLeaveConvo GetChatBskyConvoDefsLogLeaveConvo()
        {
            return (ChatBskyConvoDefsLogLeaveConvo)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ChatBskyConvoDefsLogCreateMessage`. If the actual instance is not `ChatBskyConvoDefsLogCreateMessage`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ChatBskyConvoDefsLogCreateMessage</returns>
        public ChatBskyConvoDefsLogCreateMessage GetChatBskyConvoDefsLogCreateMessage()
        {
            return (ChatBskyConvoDefsLogCreateMessage)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ChatBskyConvoDefsLogDeleteMessage`. If the actual instance is not `ChatBskyConvoDefsLogDeleteMessage`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ChatBskyConvoDefsLogDeleteMessage</returns>
        public ChatBskyConvoDefsLogDeleteMessage GetChatBskyConvoDefsLogDeleteMessage()
        {
            return (ChatBskyConvoDefsLogDeleteMessage)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatBskyConvoGetLog200ResponseLogsInner {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, ChatBskyConvoGetLog200ResponseLogsInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ChatBskyConvoGetLog200ResponseLogsInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ChatBskyConvoGetLog200ResponseLogsInner</returns>
        public static ChatBskyConvoGetLog200ResponseLogsInner FromJson(string jsonString)
        {
            ChatBskyConvoGetLog200ResponseLogsInner newChatBskyConvoGetLog200ResponseLogsInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newChatBskyConvoGetLog200ResponseLogsInner;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ChatBskyConvoDefsLogBeginConvo).GetProperty("AdditionalProperties") == null)
                {
                    newChatBskyConvoGetLog200ResponseLogsInner = new ChatBskyConvoGetLog200ResponseLogsInner(JsonConvert.DeserializeObject<ChatBskyConvoDefsLogBeginConvo>(jsonString, ChatBskyConvoGetLog200ResponseLogsInner.SerializerSettings));
                }
                else
                {
                    newChatBskyConvoGetLog200ResponseLogsInner = new ChatBskyConvoGetLog200ResponseLogsInner(JsonConvert.DeserializeObject<ChatBskyConvoDefsLogBeginConvo>(jsonString, ChatBskyConvoGetLog200ResponseLogsInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ChatBskyConvoDefsLogBeginConvo");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ChatBskyConvoDefsLogBeginConvo: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ChatBskyConvoDefsLogCreateMessage).GetProperty("AdditionalProperties") == null)
                {
                    newChatBskyConvoGetLog200ResponseLogsInner = new ChatBskyConvoGetLog200ResponseLogsInner(JsonConvert.DeserializeObject<ChatBskyConvoDefsLogCreateMessage>(jsonString, ChatBskyConvoGetLog200ResponseLogsInner.SerializerSettings));
                }
                else
                {
                    newChatBskyConvoGetLog200ResponseLogsInner = new ChatBskyConvoGetLog200ResponseLogsInner(JsonConvert.DeserializeObject<ChatBskyConvoDefsLogCreateMessage>(jsonString, ChatBskyConvoGetLog200ResponseLogsInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ChatBskyConvoDefsLogCreateMessage");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ChatBskyConvoDefsLogCreateMessage: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ChatBskyConvoDefsLogDeleteMessage).GetProperty("AdditionalProperties") == null)
                {
                    newChatBskyConvoGetLog200ResponseLogsInner = new ChatBskyConvoGetLog200ResponseLogsInner(JsonConvert.DeserializeObject<ChatBskyConvoDefsLogDeleteMessage>(jsonString, ChatBskyConvoGetLog200ResponseLogsInner.SerializerSettings));
                }
                else
                {
                    newChatBskyConvoGetLog200ResponseLogsInner = new ChatBskyConvoGetLog200ResponseLogsInner(JsonConvert.DeserializeObject<ChatBskyConvoDefsLogDeleteMessage>(jsonString, ChatBskyConvoGetLog200ResponseLogsInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ChatBskyConvoDefsLogDeleteMessage");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ChatBskyConvoDefsLogDeleteMessage: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ChatBskyConvoDefsLogLeaveConvo).GetProperty("AdditionalProperties") == null)
                {
                    newChatBskyConvoGetLog200ResponseLogsInner = new ChatBskyConvoGetLog200ResponseLogsInner(JsonConvert.DeserializeObject<ChatBskyConvoDefsLogLeaveConvo>(jsonString, ChatBskyConvoGetLog200ResponseLogsInner.SerializerSettings));
                }
                else
                {
                    newChatBskyConvoGetLog200ResponseLogsInner = new ChatBskyConvoGetLog200ResponseLogsInner(JsonConvert.DeserializeObject<ChatBskyConvoDefsLogLeaveConvo>(jsonString, ChatBskyConvoGetLog200ResponseLogsInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ChatBskyConvoDefsLogLeaveConvo");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ChatBskyConvoDefsLogLeaveConvo: {1}", jsonString, exception.ToString()));
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
            return newChatBskyConvoGetLog200ResponseLogsInner;
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
    /// Custom JSON converter for ChatBskyConvoGetLog200ResponseLogsInner
    /// </summary>
    public class ChatBskyConvoGetLog200ResponseLogsInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ChatBskyConvoGetLog200ResponseLogsInner).GetMethod("ToJson").Invoke(value, null)));
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
                    return ChatBskyConvoGetLog200ResponseLogsInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return ChatBskyConvoGetLog200ResponseLogsInner.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
