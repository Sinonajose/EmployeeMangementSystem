using System;
using System.Collections.Generic;
using System.Text;
using EmployeeMangementSystem.Localization;
using Volo.Abp.Application.Services;

namespace EmployeeMangementSystem
{
    /* Inherit your application services from this class.
     */
    public abstract class EmployeeMangementSystemAppService : ApplicationService
    {
        protected EmployeeMangementSystemAppService()
        {
            LocalizationResource = typeof(EmployeeMangementSystemResource);
        }
    }
}
