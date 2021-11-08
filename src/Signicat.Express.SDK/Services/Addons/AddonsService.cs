using System.Collections.Generic;
using System.Threading.Tasks;
using Signicat.Express.Addons.Organization;
using Signicat.Express.Addons.Person;
using Signicat.Express.Infrastructure;
using OrganizationResponse = Signicat.Express.Addons.Organization.OrganizationResponse;

namespace Signicat.Express.Addons
{
    public class AddonsService : SignicatBaseService, IAddonsService
    {
        public AddonsService()
        {
        }

        public AddonsService(string clientId, string clientSecret, IEnumerable<string> scopes)
            : base(clientId, clientSecret, scopes)
        {
        }

        public AddonsService(string clientId, string clientSecret, IEnumerable<OAuthScope> scopes)
            : base(clientId, clientSecret, scopes)
        {
        }

        /// <summary>
        /// Retrieve person information 
        /// </summary>
        /// <returns></returns>
        public async Task<PersonResponse> GetAmlPersonAsync(PersonQueryModel personQuery)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Addons}/aml/person/",
                new Dictionary<string, object>()
                {
                    {"dateOfBirth", personQuery.DateOfBirth},
                    {"firstName", personQuery.FirstName},
                    {"lastName", personQuery.LastName},
                    {"ssn", personQuery.Ssn},
                    {"countryOfSSn", personQuery.CountryOfSsn},
                    {"language", personQuery.Language},
                    {"Expands", string.Join(",", personQuery.Expands)},
                    {"matchMode", personQuery.MatchMode},
                    {"addPdfAppendix", personQuery.AddPdfAppendix},
                });
            return await GetAsync<PersonResponse>(url);
        }

        /// <summary>
        /// Retrieve organization information 
        /// </summary>
        /// <returns></returns>
        public async Task<OrganizationResponse> GetAmlOrganizationAsync(OrganizationQueryModel organizationQuery)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Addons}/aml/organization/",
                new Dictionary<string, object>()
                {
                    {"OrganizationNumber", organizationQuery.OrganizationNumber},
                    {"Nationality", organizationQuery.Nationality},
                    {"DunsNumber", organizationQuery.DunsNumber},
                    {"Expands", string.Join(",", organizationQuery.Expands)},
                    {"RequestUri", organizationQuery.RequestUri},
                    {"Language", organizationQuery.Language},
                });
            return await GetAsync<OrganizationResponse>(url);
        }

        public PersonResponse GetAmlPerson(PersonQueryModel personQuery)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Addons}/aml/person/",
                new Dictionary<string, object>()
                {
                    {"dateOfBirth", personQuery.DateOfBirth},
                    {"firstName", personQuery.FirstName},
                    {"lastName", personQuery.LastName},
                    {"ssn", personQuery.Ssn},
                    {"countryOfSSn", personQuery.CountryOfSsn},
                    {"language", personQuery.Language},
                    {"Expands", string.Join(",", personQuery.Expands)},
                    {"matchMode", personQuery.MatchMode},
                    {"addPdfAppendix", personQuery.AddPdfAppendix},
                });
            return Get<PersonResponse>(url);
        }

        /// <summary>
        /// Retrieve organization information 
        /// </summary>
        /// <returns></returns>
        public OrganizationResponse GetAmlOrganization(OrganizationQueryModel organizationQuery)
        {
            var url = APIHelper.AppendQueryParams($"{Urls.Addons}/aml/organization/",
                new Dictionary<string, object>()
                {
                    {"OrganizationNumber", organizationQuery.OrganizationNumber},
                    {"Nationality", organizationQuery.Nationality},
                    {"DunsNumber", organizationQuery.DunsNumber},
                    {"Expands", string.Join(",", organizationQuery.Expands)},
                    {"RequestUri", organizationQuery.RequestUri},
                    {"Language", organizationQuery.Language},
                });
            return Get<OrganizationResponse>(url);
        }
    }
}