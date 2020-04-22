using System.Collections.Generic;
using System.Threading.Tasks;

namespace Idfy.Addons
{
    public interface IAddonsService
    {
        /// <summary>
        /// Retrieve person information 
        /// </summary>
        /// <param name="organizationNumber"></param>
        /// <param name="nationality"></param>
        /// <param name="dunsNumber"></param>
        /// <param name="expands"></param>
        /// <param name="language"></param>
        /// <returns></returns>
        IdSession GetSession(string id);
    }
}