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
    ///  Class for testing ToolsOzoneModerationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ToolsOzoneModerationApiTests : IDisposable
    {
        private ToolsOzoneModerationApi instance;

        public ToolsOzoneModerationApiTests()
        {
            instance = new ToolsOzoneModerationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ToolsOzoneModerationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ToolsOzoneModerationApi
            //Assert.IsType<ToolsOzoneModerationApi>(instance);
        }

        /// <summary>
        /// Test ToolsOzoneModerationEmitEvent
        /// </summary>
        [Fact]
        public void ToolsOzoneModerationEmitEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ToolsOzoneModerationEmitEventRequest toolsOzoneModerationEmitEventRequest = null;
            //var response = instance.ToolsOzoneModerationEmitEvent(toolsOzoneModerationEmitEventRequest);
            //Assert.IsType<ToolsOzoneModerationDefsModEventView>(response);
        }

        /// <summary>
        /// Test ToolsOzoneModerationGetEvent
        /// </summary>
        [Fact]
        public void ToolsOzoneModerationGetEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.ToolsOzoneModerationGetEvent(id);
            //Assert.IsType<ToolsOzoneModerationDefsModEventViewDetail>(response);
        }

        /// <summary>
        /// Test ToolsOzoneModerationGetRecord
        /// </summary>
        [Fact]
        public void ToolsOzoneModerationGetRecordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uri = null;
            //string? cid = null;
            //var response = instance.ToolsOzoneModerationGetRecord(uri, cid);
            //Assert.IsType<ToolsOzoneModerationDefsRecordViewDetail>(response);
        }

        /// <summary>
        /// Test ToolsOzoneModerationGetRepo
        /// </summary>
        [Fact]
        public void ToolsOzoneModerationGetRepoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string did = null;
            //var response = instance.ToolsOzoneModerationGetRepo(did);
            //Assert.IsType<ToolsOzoneModerationDefsRepoViewDetail>(response);
        }

        /// <summary>
        /// Test ToolsOzoneModerationQueryEvents
        /// </summary>
        [Fact]
        public void ToolsOzoneModerationQueryEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string>? types = null;
            //string? createdBy = null;
            //string? sortDirection = null;
            //DateTime? createdAfter = null;
            //DateTime? createdBefore = null;
            //string? subject = null;
            //bool? includeAllUserRecords = null;
            //int? limit = null;
            //bool? hasComment = null;
            //string? comment = null;
            //List<string>? addedLabels = null;
            //List<string>? removedLabels = null;
            //List<string>? addedTags = null;
            //List<string>? removedTags = null;
            //List<string>? reportTypes = null;
            //string? cursor = null;
            //var response = instance.ToolsOzoneModerationQueryEvents(types, createdBy, sortDirection, createdAfter, createdBefore, subject, includeAllUserRecords, limit, hasComment, comment, addedLabels, removedLabels, addedTags, removedTags, reportTypes, cursor);
            //Assert.IsType<ToolsOzoneModerationQueryEvents200Response>(response);
        }

        /// <summary>
        /// Test ToolsOzoneModerationQueryStatuses
        /// </summary>
        [Fact]
        public void ToolsOzoneModerationQueryStatusesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? subject = null;
            //string? comment = null;
            //DateTime? reportedAfter = null;
            //DateTime? reportedBefore = null;
            //DateTime? reviewedAfter = null;
            //DateTime? reviewedBefore = null;
            //bool? includeMuted = null;
            //bool? onlyMuted = null;
            //string? reviewState = null;
            //List<string>? ignoreSubjects = null;
            //string? lastReviewedBy = null;
            //string? sortField = null;
            //string? sortDirection = null;
            //bool? takendown = null;
            //bool? appealed = null;
            //int? limit = null;
            //List<string>? tags = null;
            //List<string>? excludeTags = null;
            //string? cursor = null;
            //var response = instance.ToolsOzoneModerationQueryStatuses(subject, comment, reportedAfter, reportedBefore, reviewedAfter, reviewedBefore, includeMuted, onlyMuted, reviewState, ignoreSubjects, lastReviewedBy, sortField, sortDirection, takendown, appealed, limit, tags, excludeTags, cursor);
            //Assert.IsType<ToolsOzoneModerationQueryStatuses200Response>(response);
        }

        /// <summary>
        /// Test ToolsOzoneModerationSearchRepos
        /// </summary>
        [Fact]
        public void ToolsOzoneModerationSearchReposTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? q = null;
            //int? limit = null;
            //string? cursor = null;
            //var response = instance.ToolsOzoneModerationSearchRepos(q, limit, cursor);
            //Assert.IsType<ToolsOzoneModerationSearchRepos200Response>(response);
        }
    }
}
