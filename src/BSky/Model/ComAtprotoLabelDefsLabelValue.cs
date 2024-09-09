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
    /// Defines com.atproto.label.defs.labelValue
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComAtprotoLabelDefsLabelValue
    {
        /// <summary>
        /// Enum Hide for value: !hide
        /// </summary>
        [EnumMember(Value = "!hide")]
        Hide = 1,

        /// <summary>
        /// Enum NoPromote for value: !no-promote
        /// </summary>
        [EnumMember(Value = "!no-promote")]
        NoPromote = 2,

        /// <summary>
        /// Enum Warn for value: !warn
        /// </summary>
        [EnumMember(Value = "!warn")]
        Warn = 3,

        /// <summary>
        /// Enum NoUnauthenticated for value: !no-unauthenticated
        /// </summary>
        [EnumMember(Value = "!no-unauthenticated")]
        NoUnauthenticated = 4,

        /// <summary>
        /// Enum DmcaViolation for value: dmca-violation
        /// </summary>
        [EnumMember(Value = "dmca-violation")]
        DmcaViolation = 5,

        /// <summary>
        /// Enum Doxxing for value: doxxing
        /// </summary>
        [EnumMember(Value = "doxxing")]
        Doxxing = 6,

        /// <summary>
        /// Enum Porn for value: porn
        /// </summary>
        [EnumMember(Value = "porn")]
        Porn = 7,

        /// <summary>
        /// Enum Sexual for value: sexual
        /// </summary>
        [EnumMember(Value = "sexual")]
        Sexual = 8,

        /// <summary>
        /// Enum Nudity for value: nudity
        /// </summary>
        [EnumMember(Value = "nudity")]
        Nudity = 9,

        /// <summary>
        /// Enum Nsfl for value: nsfl
        /// </summary>
        [EnumMember(Value = "nsfl")]
        Nsfl = 10,

        /// <summary>
        /// Enum Gore for value: gore
        /// </summary>
        [EnumMember(Value = "gore")]
        Gore = 11
    }

}
