using System;
using FirstBlazorApp.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace FirstBlazorApp.Pages
{
    public partial class Adress : ComponentBase
    {
        List<province> provinces1 = new List<province>();
        List<district> districts1 = new List<district>();
        List<district> districts = new List<district>();
        List<district> districts2 = new List<district>();
        List<tambon> tambons1 = new List<tambon>();
        public Adress()
        {
        }
        protected override async Task OnInitializedAsync()
        {
            await DBContext.OpenIndexedDb();
            provinces1 = await DBContext.GetAll<province>("province");
            districts1 = await DBContext.GetAll<district>("district");
            tambons1 = await DBContext.GetAll<tambon>("tambon");
        }
    }
}

