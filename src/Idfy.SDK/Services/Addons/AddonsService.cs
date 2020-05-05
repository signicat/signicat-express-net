using System.Collections.Generic;
using Idfy.Addons.Entities;
using Idfy.Addons.Entities.Organization;
using Idfy.Infrastructure;

namespace Idfy.Addons
{
    public class Addons : IdfyBaseService, IAddonsService
    {
        public Addons()
        {
        }

        public Addons(string clientId, string clientSecret, IEnumerable<string> scopes)
            : base(clientId, clientSecret, scopes)
        {
        }

        public Addons(string clientId, string clientSecret, IEnumerable<OAuthScope> scopes)
            : base(clientId, clientSecret, scopes)
        {
        }

        /// <summary>
        /// Retrieve person information 
        /// </summary>
        /// <returns></returns>
        public PersonAmlModel AmlPerson(PersonQueryModel personQuery)
        {
            return Get<PersonAmlModel>($"{Urls.Addons}/api/aml/person");
        }

        /// <summary>
        /// Retrieve organization information 
        /// </summary>
        /// <returns></returns>
        public OrganizationResponseModel AmlOrganization(OrganizationQueryInput organizationQuery)
        {
            return Get<OrganizationResponseModel>($"{Urls.Addons}/api/aml/organization");
        }
    }
}
}