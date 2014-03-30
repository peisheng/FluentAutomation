﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentAutomation.Tests
{
    /// <summary>
    /// Base Test that opens the test to the AUT
    /// </summary>
    public class BaseTest : FluentTest<IWebDriver>
    {
        public string SiteUrl { get { return "http://localhost:38043/"; } }

        public BaseTest()
        {
            Config.WaitUntilTimeout(TimeSpan.FromSeconds(2));

            // Default tests use chrome and load the site
            FluentAutomation.SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Chrome);
            I.Open(SiteUrl);
        }
    }
}