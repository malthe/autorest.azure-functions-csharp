﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using AutoRest.TestServer.Tests.Infrastructure;
using media_types;
using media_types.Models;
using NUnit.Framework;

namespace AutoRest.TestServer.Tests
{
    [IgnoreOnTestServer(TestServerVersion.V2, "These tests are not implemented on V2")]
    public class MediaTypesTests : TestServerTestBase
    {
        public MediaTypesTests(TestServerVersion version) : base(version, "mediatypes") { }

        [Test]
        public Task MediaTypeJson() => Test(async (host, pipeline) =>
        {
            var value = new SourcePath
            {
                Source = "anything"
            };
            var response = await new ServiceClient(ClientDiagnostics, pipeline, host).AnalyzeBodyAsync(value);
            Assert.AreEqual("Nice job with JSON", response.Value);
        });

        [Test]
        public Task MediaTypePdf() => Test(async (host, pipeline) =>
        {
            await using var value = new MemoryStream(Encoding.UTF8.GetBytes("PDF"));
            var response = await new ServiceClient(ClientDiagnostics, pipeline, host).AnalyzeBodyAsync(ContentType.ApplicationPdf, value);
            Assert.AreEqual("Nice job with PDF", response.Value);
        });
    }
}