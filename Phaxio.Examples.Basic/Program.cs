﻿using IniParser;
using IniParser.Model;
using Phaxio.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phaxio.Examples.Basic
{
    class Example
    {
        static void Main(string[] args)
        {
            var parser = new FileIniDataParser();
            IniData config = parser.ReadFile(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "keys.ini");

            var testToNumber = "8088675309";
            var testOptions = new FaxOptions
            {
                HeaderText = "headertext",
                StringData = "somedata",
                StringDataType = "html",
                IsBatch = true,
                BatchDelaySeconds = 10,
                AvoidBatchCollision = true,
                CallbackUrl = "https://example.com/callback",
                CancelTimeoutAfter = 20
            };

            var phaxio = new PhaxioClient(config["Phaxio"]["api_key"], config["Phaxio"]["api_secret"]);

            var pdf = new FileInfo("C:\\temp\\test.pdf");

            var faxId = phaxio.SendFax(testToNumber, pdf, testOptions);
        }
    }
}