using EmployeeMangementSystem.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EmployeeMangementSystem.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class EmployeeMangementSystemController : AbpController
    {
        protected EmployeeMangementSystemController()
        {
            LocalizationResource = typeof(EmployeeMangementSystemResource);
        }
    }
}