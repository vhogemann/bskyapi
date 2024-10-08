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
    /// AppBskyVideoDefsJobStatus
    /// </summary>
    [DataContract(Name = "app.bsky.video.defs.jobStatus")]
    public partial class AppBskyVideoDefsJobStatus : IValidatableObject
    {
        /// <summary>
        /// The state of the video processing job. All values not listed as a known value indicate that the job is in process.
        /// </summary>
        /// <value>The state of the video processing job. All values not listed as a known value indicate that the job is in process.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum COMPLETED for value: JOB_STATE_COMPLETED
            /// </summary>
            [EnumMember(Value = "JOB_STATE_COMPLETED")]
            COMPLETED = 1,

            /// <summary>
            /// Enum FAILED for value: JOB_STATE_FAILED
            /// </summary>
            [EnumMember(Value = "JOB_STATE_FAILED")]
            FAILED = 2
        }


        /// <summary>
        /// The state of the video processing job. All values not listed as a known value indicate that the job is in process.
        /// </summary>
        /// <value>The state of the video processing job. All values not listed as a known value indicate that the job is in process.</value>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyVideoDefsJobStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyVideoDefsJobStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyVideoDefsJobStatus" /> class.
        /// </summary>
        /// <param name="jobId">jobId (required).</param>
        /// <param name="did">did (required).</param>
        /// <param name="state">The state of the video processing job. All values not listed as a known value indicate that the job is in process. (required).</param>
        /// <param name="progress">progress.</param>
        /// <param name="blob">blob.</param>
        /// <param name="error">error.</param>
        /// <param name="message">message.</param>
        public AppBskyVideoDefsJobStatus(string jobId = default(string), string did = default(string), StateEnum state = default(StateEnum), int progress = default(int), System.IO.Stream blob = default(System.IO.Stream), string error = default(string), string message = default(string))
        {
            // to ensure "jobId" is required (not null)
            if (jobId == null)
            {
                throw new ArgumentNullException("jobId is a required property for AppBskyVideoDefsJobStatus and cannot be null");
            }
            this.JobId = jobId;
            // to ensure "did" is required (not null)
            if (did == null)
            {
                throw new ArgumentNullException("did is a required property for AppBskyVideoDefsJobStatus and cannot be null");
            }
            this.Did = did;
            this.State = state;
            this.Progress = progress;
            this.Blob = blob;
            this.Error = error;
            this.Message = message;
        }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name = "jobId", IsRequired = true, EmitDefaultValue = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or Sets Did
        /// </summary>
        [DataMember(Name = "did", IsRequired = true, EmitDefaultValue = true)]
        public string Did { get; set; }

        /// <summary>
        /// Gets or Sets Progress
        /// </summary>
        [DataMember(Name = "progress", EmitDefaultValue = false)]
        public int Progress { get; set; }

        /// <summary>
        /// Gets or Sets Blob
        /// </summary>
        [DataMember(Name = "blob", EmitDefaultValue = false)]
        public System.IO.Stream Blob { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyVideoDefsJobStatus {\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  Did: ").Append(Did).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Blob: ").Append(Blob).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            // Progress (int) maximum
            if (this.Progress > (int)100)
            {
                yield return new ValidationResult("Invalid value for Progress, must be a value less than or equal to 100.", new [] { "Progress" });
            }

            // Progress (int) minimum
            if (this.Progress < (int)0)
            {
                yield return new ValidationResult("Invalid value for Progress, must be a value greater than or equal to 0.", new [] { "Progress" });
            }

            yield break;
        }
    }

}
