/*
 * AT Protocol XRPC API
 *
 * This section contains HTTP API reference docs for Bluesky and AT Protocol lexicons. Generate a bearer token to test API calls directly from the docs.
 *
 * The version of the OpenAPI document: 0.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using BSky.Model;
using BSky.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace BSky.Test.Model
{
    /// <summary>
    ///  Class for testing ComAtprotoAdminSendEmailRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ComAtprotoAdminSendEmailRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ComAtprotoAdminSendEmailRequest
        //private ComAtprotoAdminSendEmailRequest instance;

        public ComAtprotoAdminSendEmailRequestTests()
        {
            // TODO uncomment below to create an instance of ComAtprotoAdminSendEmailRequest
            //instance = new ComAtprotoAdminSendEmailRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ComAtprotoAdminSendEmailRequest
        /// </summary>
        [Fact]
        public void ComAtprotoAdminSendEmailRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" ComAtprotoAdminSendEmailRequest
            //Assert.IsType<ComAtprotoAdminSendEmailRequest>(instance);
        }

        /// <summary>
        /// Test the property 'RecipientDid'
        /// </summary>
        [Fact]
        public void RecipientDidTest()
        {
            // TODO unit test for the property 'RecipientDid'
        }

        /// <summary>
        /// Test the property 'Content'
        /// </summary>
        [Fact]
        public void ContentTest()
        {
            // TODO unit test for the property 'Content'
        }

        /// <summary>
        /// Test the property 'Subject'
        /// </summary>
        [Fact]
        public void SubjectTest()
        {
            // TODO unit test for the property 'Subject'
        }

        /// <summary>
        /// Test the property 'SenderDid'
        /// </summary>
        [Fact]
        public void SenderDidTest()
        {
            // TODO unit test for the property 'SenderDid'
        }

        /// <summary>
        /// Test the property 'Comment'
        /// </summary>
        [Fact]
        public void CommentTest()
        {
            // TODO unit test for the property 'Comment'
        }
    }
}
