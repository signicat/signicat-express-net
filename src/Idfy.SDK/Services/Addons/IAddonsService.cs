using System.Collections.Generic;
using System.Threading.Tasks;
using Idfy.Addons.Entities;
using Idfy.Addons.Entities.Organization;
using Idfy.IdentificationV2;

namespace Idfy.Addons
{
    public interface IAddonsService
    {
        PersonAmlModel AmlPerson(PersonQueryModel personQuery);

        OrganizationResponseModel AmlOrganization(OrganizationQueryInput personQuery);
    }
}