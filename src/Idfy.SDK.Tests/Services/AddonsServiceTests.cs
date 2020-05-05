using System.Collections.Generic;
using System.Threading.Tasks;
using Idfy.Addons;
using Idfy.Addons.Entities;
using Idfy.Addons.Entities.Organization;
using Idfy.Addons.Entities.Person;
using NUnit.Framework;

namespace Idfy.SDK.Tests
{
    public class AddonsServicetest : BaseTest
    {
        private IAddonsService _addonsService;

        [SetUp]
        public void Setup()
        {
            // To test against test env: 
            // Change oauth token url in BaseTest -> Initialize to https://api.idfy.io
            // Add a client here with test access to addons and overridden BankIdAML settings
            // Set Urls -> Addons to https://addonstest.signere.com
            _addonsService = new AddonsService("<REMOVED>",
                "<REMOVED>", new List<string> {"addons"});
        }

        [Test]
        public async Task GetAmlOrganization()
        {
            var opts = new OrganizationQueryInput()
            {
                Expands = new List<OrganizationExpands>
                {
                    OrganizationExpands.keyInformation_lei,
                    OrganizationExpands.address,
                    OrganizationExpands.links_reports_aml
                },
                OrganizationNumber = "123456789",
                Nationality = "NO"
            };
            var response = await _addonsService.GetAmlOrganizationAsync(opts);
            Assert.IsNotNull(response);
        }
        [Test]
        public async Task GetAmlPerson()
        {
            var opts = new PersonQueryModel()
            {
                Expands = new List<PersonExpand>()
                {
                    PersonExpand.aml,
                    PersonExpand.address_postal,
                    PersonExpand.links_reports_aml
                },
                FirstName = "Tomas",
                LastName = "Topstad",
                Ssn = "01010750160",
                MatchMode = MatchMode.EXACT,
                CountryOfSsn = "NO"
            };
            var response = await _addonsService.GetAmlPersonAsync(opts);
            Assert.IsNotNull(response);
        }
    }
}