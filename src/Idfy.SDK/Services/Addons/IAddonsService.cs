using System.Threading.Tasks;
using Idfy.Addons.Entities.Organization;
using Idfy.Addons.Entities.Person;
using OrganizationResponse = Idfy.Addons.Entities.Organization.OrganizationResponse;

namespace Idfy.Addons
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