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
    ///  Class for testing AppBskyNotificationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AppBskyNotificationApiTests : IDisposable
    {
        private AppBskyNotificationApi instance;

        public AppBskyNotificationApiTests()
        {
            instance = new AppBskyNotificationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppBskyNotificationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AppBskyNotificationApi
            //Assert.IsType<AppBskyNotificationApi>(instance);
        }

        /// <summary>
        /// Test AppBskyNotificationGetUnreadCount
        /// </summary>
        [Fact]
        public void AppBskyNotificationGetUnreadCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? priority = null;
            //DateTime? seenAt = null;
            //var response = instance.AppBskyNotificationGetUnreadCount(priority, seenAt);
            //Assert.IsType<AppBskyNotificationGetUnreadCount200Response>(response);
        }

        /// <summary>
        /// Test AppBskyNotificationListNotifications
        /// </summary>
        [Fact]
        public void AppBskyNotificationListNotificationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //bool? priority = null;
            //string? cursor = null;
            //DateTime? seenAt = null;
            //var response = instance.AppBskyNotificationListNotifications(limit, priority, cursor, seenAt);
            //Assert.IsType<AppBskyNotificationListNotifications200Response>(response);
        }

        /// <summary>
        /// Test AppBskyNotificationPutPreferences
        /// </summary>
        [Fact]
        public void AppBskyNotificationPutPreferencesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AppBskyNotificationPutPreferencesRequest appBskyNotificationPutPreferencesRequest = null;
            //instance.AppBskyNotificationPutPreferences(appBskyNotificationPutPreferencesRequest);
        }

        /// <summary>
        /// Test AppBskyNotificationRegisterPush
        /// </summary>
        [Fact]
        public void AppBskyNotificationRegisterPushTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AppBskyNotificationRegisterPushRequest appBskyNotificationRegisterPushRequest = null;
            //instance.AppBskyNotificationRegisterPush(appBskyNotificationRegisterPushRequest);
        }

        /// <summary>
        /// Test AppBskyNotificationUpdateSeen
        /// </summary>
        [Fact]
        public void AppBskyNotificationUpdateSeenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AppBskyNotificationUpdateSeenRequest appBskyNotificationUpdateSeenRequest = null;
            //instance.AppBskyNotificationUpdateSeen(appBskyNotificationUpdateSeenRequest);
        }
    }
}
