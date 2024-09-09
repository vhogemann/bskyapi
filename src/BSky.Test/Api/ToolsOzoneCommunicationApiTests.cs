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
    ///  Class for testing ToolsOzoneCommunicationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ToolsOzoneCommunicationApiTests : IDisposable
    {
        private ToolsOzoneCommunicationApi instance;

        public ToolsOzoneCommunicationApiTests()
        {
            instance = new ToolsOzoneCommunicationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ToolsOzoneCommunicationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ToolsOzoneCommunicationApi
            //Assert.IsType<ToolsOzoneCommunicationApi>(instance);
        }

        /// <summary>
        /// Test ToolsOzoneCommunicationCreateTemplate
        /// </summary>
        [Fact]
        public void ToolsOzoneCommunicationCreateTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ToolsOzoneCommunicationCreateTemplateRequest toolsOzoneCommunicationCreateTemplateRequest = null;
            //var response = instance.ToolsOzoneCommunicationCreateTemplate(toolsOzoneCommunicationCreateTemplateRequest);
            //Assert.IsType<ToolsOzoneCommunicationDefsTemplateView>(response);
        }

        /// <summary>
        /// Test ToolsOzoneCommunicationDeleteTemplate
        /// </summary>
        [Fact]
        public void ToolsOzoneCommunicationDeleteTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ToolsOzoneCommunicationDeleteTemplateRequest toolsOzoneCommunicationDeleteTemplateRequest = null;
            //instance.ToolsOzoneCommunicationDeleteTemplate(toolsOzoneCommunicationDeleteTemplateRequest);
        }

        /// <summary>
        /// Test ToolsOzoneCommunicationListTemplates
        /// </summary>
        [Fact]
        public void ToolsOzoneCommunicationListTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ToolsOzoneCommunicationListTemplates();
            //Assert.IsType<ToolsOzoneCommunicationListTemplates200Response>(response);
        }

        /// <summary>
        /// Test ToolsOzoneCommunicationUpdateTemplate
        /// </summary>
        [Fact]
        public void ToolsOzoneCommunicationUpdateTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ToolsOzoneCommunicationUpdateTemplateRequest toolsOzoneCommunicationUpdateTemplateRequest = null;
            //var response = instance.ToolsOzoneCommunicationUpdateTemplate(toolsOzoneCommunicationUpdateTemplateRequest);
            //Assert.IsType<ToolsOzoneCommunicationDefsTemplateView>(response);
        }
    }
}
