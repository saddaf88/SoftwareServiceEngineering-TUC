﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace URLParser
{
    public class URLTester
    {
        [Fact]
        public void TestUrls()
        {
            string s = "http://www.tu-chemnitz.de:8080/ein%20test?my-name=my-value&a=1#id";
            URL url = new URL(s);
            Assert.Equal("http", url.Scheme);
            Assert.Equal("www.tu-chemnitz.de", url.Host);
            Assert.Equal(8080, url.Port);
            Assert.Equal("/ein test", url.Path);
            Assert.Equal("my-name=my-value&a=1", url.Query);
            Assert.Equal("id", url.FragmentId);
            Assert.Equal(s, url.ToString());
        }
    }
}
