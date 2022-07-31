using System;
using FirstBlazorApp.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using System.Linq;

namespace FirstBlazorApp.Pages
{
    public partial class Adress : ComponentBase
    {
        survey_profile recordSurveyProfile = new survey_profile();
        List<province> provinces1 = new List<province>();
        List<district> districts1 = new List<district>();
        List<district> districts = new List<district>();
        List<district> districts2 = new List<district>();
        List<tambon> tambons1 = new List<tambon>();
        [Parameter]
        public string HC { get; set; }


        string provinceId;
        string districtId;
        string districtId2;
        string tambonId2;
        List<tambon> tambons = new List<tambon>();
        string complete = "";
        private string threatId = null;

        private string threatId4 = null;
        private string threatId5 = null;
        private string threatId2 = null;
        private string districtSel = null;
        private string threatId3 = null;
        public string tambonId
        {
            get { return threatId3; }
            set
            {
                threatId3 = value;
            }
        }
        person personAdd = new person();
        public string SelectProvinceId
        {
            get { return threatId4; }
            set
            {
                if (value.Substring(0, 1) == "s")
                {
                    threatId4 = value.Substring(3);
                }
                else
                {

                    threatId4 = value;

                    SelectThreatValueChanged(value);
                }
            }
        }
        public string SelectPrenme
        {
            get { return threatId5; }
            set
            {
                if (value.Substring(0, 1) == "s")
                {
                    threatId5 = value.Substring(3);
                }
                else
                {

                    threatId5 = value;

                    SelectThreatValueChanged(value);
                }
            }
        }
        public string SelectDistrictId
        {
            get { return threatId2; }
            set
            {
                if (value != null && value != "")
                {


                    if (value.Substring(0, 1) == "s")
                    {
                        threatId2 = value.Substring(3);
                    }
                    else if (value == "x")
                    {
                        threatId2 = "";
                    }
                    else
                    {

                        threatId2 = value;
                        SelectDistrictValueChanged(value);
                    }
                }


            }
        }
        public string SelectTambonId
        {
            get { return threatId3; }
            set
            {

                threatId3 = value;


            }
        }


        private async void SelectDistrictValueChanged(string id)
        {//https://stackoverflow.com/questions/64802201/blazor-matblazor-how-to-catch-the-value-change-of-matselect-component
            int proId = Convert.ToInt32(id);
            if (id != null)
                tambons = await DBContext.GetByIndex<string, tambon>("tambon", id, null, "district_id", false);
            tambonId = "";
            StateHasChanged();


        }
        private async void SelectThreatValueChanged(string id)
        {//https://stackoverflow.com/questions/64802201/blazor-matblazor-how-to-catch-the-value-change-of-matselect-component
            int proId = Convert.ToInt32(id);
            tambonId = "";
            districts = await DBContext.GetByIndex<int?, district>("district", proId, 0, "province_id", false);
            SelectDistrictId = "x";

            tambons = new List<tambon>();
            StateHasChanged();
            //
        }


        protected override async Task OnInitializedAsync()
        {
            await DBContext.OpenIndexedDb();
            provinces1 = await DBContext.GetAll<province>("province");
            //districts1 = await DBContext.GetAll<district>("district");
            tambons1 = await DBContext.GetAll<tambon>("tambon");
            await JSRuntime.InvokeVoidAsync("localStorage.setItem", "HC", HC);
            if (HC != null)
            {

                List<survey_profile> getAllSurPro = await DBContext.GetByIndex<string, survey_profile>("survey_profile", HC, null, "hc", false);
                recordSurveyProfile = getAllSurPro.First();
                //	semaphonSlim.Wait();
                //SelectThreatValueChanged(recordSurveyProfile.JUN);
                //SelectDistrictValueChanged(recordSurveyProfile.AMP);
                SelectProvinceId = "sel" + recordSurveyProfile.JUN;
                SelectDistrictId = "sel" + recordSurveyProfile.AMP;
                SelectTambonId = recordSurveyProfile.TMP;
            }
            if (recordSurveyProfile.AMP != null && recordSurveyProfile.AMP != "")
            {
                int amp = Convert.ToInt32(recordSurveyProfile.JUN);
                districts = await DBContext.GetByIndex<int?, district>("district", amp, 0, "province_id", false);

                tambons = await DBContext.GetByIndex<string, tambon>("tambon", recordSurveyProfile.AMP, null, "district_id", false);
                StateHasChanged();

            }

            provinces1 = await DBContext.GetAll<province>("province");
        }
    }
}

