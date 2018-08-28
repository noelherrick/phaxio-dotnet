﻿using System;
using System.Collections.Generic;
using System.IO;
using Phaxio.Tests.Helpers;

namespace Phaxio.Tests
{
    public class JsonResponseFixtures
    {
        public static string FromFile(string fixtureName)
        {
            return File.ReadAllText(getQualifiedPath(fixtureName + ".json"));
        }

        private static string getQualifiedPath(string filename)
        {
            var fullPath = App.BaseDirectory() + "Fixtures/Json/" + filename;
            return fullPath.Replace('/', Path.DirectorySeparatorChar);
        }

        public static Dictionary<string, string> Fixtures = new Dictionary<string, string>
        {
            {
                "authFail",
                @"{
                    ""success"":false,
                    ""message"":""That key or secret is not correct.""
                }"
            },
            {
                "accountStatus",
                @"{
                    ""success"":true,
                    ""message"":""Account status retrieved successfully"",
                    ""data"": {
                        ""faxes_sent_this_month"":120,
                        ""faxes_sent_today"":10,
                        ""balance"":3000
                    }
                }"
            },
            {
                "areaCodes",
                @"{
                    ""success"": true,
                    ""message"": ""295 area codes available."",
                    ""data"": {
                        ""201"": {
                            ""city"": ""Bayonne, Jersey City, Union City"",
                            ""state"": ""New Jersey""
                        },
                        ""202"": {
                            ""city"": ""Washington"",
                            ""state"": ""District Of Columbia""
                        }
                    }
                }"
            },
            {
                "faxCancel",
                @"{
                    ""success"":true,
                    ""message"":""Fax canceled successfully.""
                }"
            },
            {
                "resendFax",
                @"{
                    ""success"":true,
                    ""message"":""Fax resent successfully.""
                }"
            },
            {
                "deleteFax",
                @"{
                    ""success"":true,
                    ""message"":""Fax deleted successfully.""
                }"
            },
            {
                "releaseNumber",
                @"{
                    ""success"":true,
                    ""message"":""Number released successfully!."",
                    ""data"":[]
                }"
            },
            {
                "supportedCountries",
                @"{""success"":true,""message"":""Data contains supported countries."",""data"":{""United States"":{""price_per_page"":7},""Canada"":{""price_per_page"":7},""Argentina"":{""price_per_page"":10}}}"

            },
            {
                "provisionNumber",
                @"{
                    ""success"":true,
                    ""message"":""Number provisioned successfully!"",
                    ""data"":{
                        ""number"":""8475551234"",
                        ""city"":""Northbrook"",
                        ""state"":""Illinois"",
                        ""cost"":200,
                        ""last_billed_at"":""2013-11-12 11:39:05"",
                        ""provisioned_at"":""2013-11-12 11:39:05""
                    }
                }"
            },
            {
                "numberList",
                @"{
                    ""success"":true,
                    ""message"":""Retrieved user phone numbers successfully"",
                    ""data"":[
                {
                            ""number"":""8475551234"",
                            ""city"":""Northbrook"",
                            ""state"":""Illinois"",
                            ""cost"":200,
                            ""last_billed_at"":""2013-11-12 11:39:05"",
                            ""provisioned_at"":""2013-11-12 11:39:05""
                        },
                {
                            ""number"":""8476661235"",
                            ""city"":""Northbrook"",
                            ""state"":""Illinois"",
                            ""cost"":200,
                            ""last_billed_at"":""2013-11-12 11:31:06"",
                            ""provisioned_at"":""2013-11-12 11:31:06""
                        }
                    ]
                }"
            },
            {
                "createPhaxCodeUrl",
                "{\"success\":true,\"message\":\"success\",\"data\":{\"url\":\"http:\\/\\/www.phaxio.com\\/phaxCodes\\/render\\/4k75ny\"}}"
            },
            {
                "send",
                @"{
                    ""success"":true,
                    ""message"":""Fax queued for sending"",
                    ""faxId"":1234,
                    ""data"":{
                        ""faxId"":1234
                    }
                }"
            },
            {
                "testReceive",
                @"{
                    ""success"":true,
                    ""message"":""Test fax received from 234567890. Calling back now.""
                }"
            },
        };
    }
}
