using System.Threading.Tasks;
using Signicat.Express.Addons.Organization;
using Signicat.Express.Addons.Person;
using OrganizationResponse = Signicat.Express.Addons.Organization.OrganizationResponse;

namespace Signicat.Express.Addons
{
    public interface IAddonsService
    {
        /// <summary>
        /// Retrieve person information 
        /// </summary>
        /// <returns></returns>
        Task<PersonResponse> GetAmlPersonAsync(PersonQueryModel personQuery);

        /// <summary>
        /// Retrieve organization information 
        /// </summary>
        /// <returns></returns>
        Task<OrganizationResponse> GetAmlOrganizationAsync(OrganizationQueryModel personQuery);
        
        /// <summary>
        /// Retrieve person information 
        /// </summary>
        /// <returns></returns>
        PersonResponse GetAmlPerson(PersonQueryModel personQuery);

        /// <summary>
        /// Retrieve organization information 
        /// </summary>
        /// <returns></returns>
        OrganizationResponse GetAmlOrganization(OrganizationQueryModel personQuery);
    }
}