using System.Threading.Tasks;
using Idfy.Addons.Entities.Organization;
using Idfy.Addons.Entities.Person;
using OrganizationResponse = Idfy.Addons.Entities.Organization.OrganizationResponse;

namespace Idfy.Addons
{
    public interface IAddonsService
    {
        Task<PersonResponse> GetAmlPersonAsync(PersonQueryModel personQuery);

        Task<OrganizationResponse> GetAmlOrganizationAsync(OrganizationQueryInput personQuery);
        
        PersonResponse GetAmlPerson(PersonQueryModel personQuery);

        OrganizationResponse GetAmlOrganization(OrganizationQueryInput personQuery);
    }
}