using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstBlazorApp.Pages
{
    public class EmployeeDetailsBase : ComponentBase
    {
        

        [Parameter]
        public string Id { get; set; }
    }
}
