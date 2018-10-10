using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Idfy.Infrastructure;
using Idfy.Signature;
using NUnit.Framework;

namespace Idfy.SDK.Tests
{
    [TestFixture]
    public class APIHelperTest
    {
        [Test]
        public void AppendsQueryParams()
        {
            var q = new Dictionary<string, object>()
            {
                {"foo", "bar"},
                {"limit", 25},
                {"fileFormat", FileFormat.StandardPackaging},
                {"fromDate", new DateTime(2018, 01, 01, 8, 0, 0, DateTimeKind.Utc)},
                {"mock", null}
            };

            var url = APIHelper.AppendQueryParams("https://api.idfy.io", q);
            
            Assert.IsNotEmpty(url);
            Assert.AreEqual("https://api.idfy.io?foo=bar&limit=25&fileFormat=standard_packaging&fromDate=2018-01-01T08:00:00Z", url);
        }

        [Test]
        public void BuildsQueryString()
        {
            var q = APIHelper.ToQueryString(new NameValueCollection()
            {
                {"foo", "bar"},
                {"test_param", "test_value"}
            });
            
            Assert.IsNotEmpty(q);
            Assert.AreEqual("?foo=bar&test_param=test_value", q);
        }
    }
}