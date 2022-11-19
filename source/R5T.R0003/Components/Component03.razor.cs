using System;
using System.Threading.Tasks;

namespace R5T.R0003
{
    /// <summary>
    /// A component using an asynchronous service.
    /// </summary>
    public partial class Component03
    {
        private string ServiceCResult { get; set; }


        protected override async Task OnParametersSetAsync()
        {
            this.ServiceCResult = await this.ServiceC.RunFunction();
        }
    }
}
