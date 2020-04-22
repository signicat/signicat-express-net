using System.Collections.Generic;
using System.Threading.Tasks;
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
        /// <param name="organizationNumber"></param>
        /// <param name="nationality"></param>
        /// <param name="dunsNumber"></param>
        /// <param name="expands"></param>
        /// <param name="language"></param>
        /// <returns></returns>
        public AmlPersonResponse AmlPerson(string id)
        {
            return Get<AmlPersonResponse>($"{Urls.Addons}/api/aml/person");
        }
        /// <summary>
        /// Retrieve organization information 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IdSession GetSession(string id)
        {
            return Get<IdSession>($"{Urls.IdentificationV2}/sessions/{id}");
        }
}