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
    /// Defines tools.ozone.moderation.defs.subjectReviewState
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ToolsOzoneModerationDefsSubjectReviewState
    {
        /// <summary>
        /// Enum ReviewOpen for value: #reviewOpen
        /// </summary>
        [EnumMember(Value = "#reviewOpen")]
        ReviewOpen = 1,

        /// <summary>
        /// Enum ReviewEscalated for value: #reviewEscalated
        /// </summary>
        [EnumMember(Value = "#reviewEscalated")]
        ReviewEscalated = 2,

        /// <summary>
        /// Enum ReviewClosed for value: #reviewClosed
        /// </summary>
        [EnumMember(Value = "#reviewClosed")]
        ReviewClosed = 3,

        /// <summary>
        /// Enum ReviewNone for value: #reviewNone
        /// </summary>
        [EnumMember(Value = "#reviewNone")]
        ReviewNone = 4
    }

}
