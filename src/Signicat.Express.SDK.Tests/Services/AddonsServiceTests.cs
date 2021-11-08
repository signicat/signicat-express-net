using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AutoFixture;
using NUnit.Framework;
using Signicat.Express.Addons;
using Signicat.Express.Addons.Organization;
using Signicat.Express.Addons.Person;
using Signicat.Express.Infrastructure;

namespace Signicat.Express.SDK.Tests
{
    [TestFixture]
    public class AddonsServiceTest : BaseTest
    {
        private IAddonsService _addonsService;

        [SetUp]
        public void Setup()
        {
            _addonsService = new AddonsService();
        }

        [Test]
        [Ignore("Awaiting update to docs")]
        public async Task GetAmlOrganizationAsync()
        {
            var opts = Fixture.Create<OrganizationQueryModel>();
            var url = APIHelper.AppendQueryParams($"{Urls.Addons}/aml/organization/",
                new Dictionary<string, object>()
                {
                    {"OrganizationNumber", opts.OrganizationNumber},
                    {"Nationality", opts.Nationality},
                    {"DunsNumber", opts.DunsNumber},
                    {"Expands", string.Join(",", opts.Expands)},
                    {"RequestUri", opts.RequestUri},
                    {"Language", opts.Language},
                });
            
            var response = await _addonsService.GetAmlOrganizationAsync(opts);
            Assert.IsNotNull(response);
            AssertRequest(HttpMethod.Get, url);
        }

        [Test]
        [Ignore("Awaiting update to docs")]
        public async Task GetAmlPersonAsync()
        {
            var opts = Fixture.Create<PersonQueryModel>();
            var url = APIHelper.AppendQueryParams($"{Urls.Addons}/aml/person/",
                new Dictionary<string, object>()
                {
                    {"dateOfBirth", opts.DateOfBirth},
                    {"firstName", opts.FirstName},
                    {"lastName", opts.LastName},
                    {"ssn", opts.Ssn},
                    {"countryOfSSn", opts.CountryOfSsn},
                    {"language", opts.Language},
                    {"Expands", string.Join(",", opts.Expands)},
                    {"matchMode", opts.MatchMode},
                    {"addPdfAppendix", opts.AddPdfAppendix},
                });

            var response = await _addonsService.GetAmlPersonAsync(opts);
            Assert.IsNotNull(response);
            AssertRequest(HttpMethod.Get, url);
        }

        [Test]
        [Ignore("Awaiting update to docs")]
        public void GetAmlPerson()
        {
            var opts = Fixture.Create<PersonQueryModel>();
            var url = APIHelper.AppendQueryParams($"{Urls.Addons}/aml/person/",
                new Dictionary<string, object>()
                {
                    {"dateOfBirth", opts.DateOfBirth},
                    {"firstName", opts.FirstName},
                    {"lastName", opts.LastName},
                    {"ssn", opts.Ssn},
                    {"countryOfSSn", opts.CountryOfSsn},
                    {"language", opts.Language},
                    {"Expands", string.Join(",", opts.Expands)},
                    {"matchMode", opts.MatchMode},
                    {"addPdfAppendix", opts.AddPdfAppendix},
                });

            var response = _addonsService.GetAmlPerson(opts);
            Assert.IsNotNull(response);
            AssertRequest(HttpMethod.Get, url);
        }

        [Test]
        [Ignore("Awaiting update to docs")]
        public void GetAmlOrganization()
        {
            var opts = Fixture.Create<OrganizationQueryModel>();
            var url = APIHelper.AppendQueryParams($"{Urls.Addons}/aml/organization/",
                new Dictionary<string, object>()
                {
                    {"OrganizationNumber", opts.OrganizationNumber},
                    {"Nationality", opts.Nationality},
                    {"DunsNumber", opts.DunsNumber},
                    {"Expands", string.Join(",", opts.Expands)},
                    {"RequestUri", opts.RequestUri},
                    {"Language", opts.Language},
                });

            var response = _addonsService.GetAmlOrganization(opts);
            Assert.IsNotNull(response);
            AssertRequest(HttpMethod.Get, url);
        }
    }
}