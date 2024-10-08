/*
 * AT Protocol XRPC API
 *
 * This section contains HTTP API reference docs for Bluesky and AT Protocol lexicons. Generate a bearer token to test API calls directly from the docs.
 *
 * The version of the OpenAPI document: 0.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using BSky.Client;
using BSky.Api;
// uncomment below to import models
//using BSky.Model;

namespace BSky.Test.Api
{
    /// <summary>
    ///  Class for testing ComAtprotoLabelApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ComAtprotoLabelApiTests : IDisposable
    {
        private ComAtprotoLabelApi instance;

        public ComAtprotoLabelApiTests()
        {
            instance = new ComAtprotoLabelApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ComAtprotoLabelApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ComAtprotoLabelApi
            //Assert.IsType<ComAtprotoLabelApi>(instance);
        }

        /// <summary>
        /// Test ComAtprotoLabelQueryLabels
        /// </summary>
        [Fact]
        public void ComAtprotoLabelQueryLabelsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> uriPatterns = null;
            //List<string>? sources = null;
            //int? limit = null;
            //string? cursor = null;
            //var response = instance.ComAtprotoLabelQueryLabels(uriPatterns, sources, limit, cursor);
            //Assert.IsType<ComAtprotoLabelQueryLabels200Response>(response);
        }
    }
}
