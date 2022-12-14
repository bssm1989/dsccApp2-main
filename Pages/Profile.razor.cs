using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using Darnton.Blazor.DeviceInterop.Geolocation;
using FirstBlazorApp.Models;
using FirstBlazorApp.Pages;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using static FirstBlazorApp.Pages.Profile;

namespace FirstBlazorApp.Pages
{
    public partial class Profile : ComponentBase
    {

        bool checked1 = true;
        protected string Val1;
        person recordSurveyProfile = new person();
        person personAdd = new person();
        List<province> provinces1 = new List<province>();
        List<district> districts1 = new List<district>();
        List<district> districts = new List<district>();
        List<district> districts2 = new List<district>();
        List<tambon> tambons = new List<tambon>();
        List<tambon> tambons1 = new List<tambon>();
        List<const_prenme> const_prenme1 = new List<const_prenme>();
        List<const_sex> const_sex1 = new List<const_sex>();
        List<person> person1 = new List<person>();
        List<const_currlev> const_currlev1 = new List<const_currlev>();
        List<const_disability_type> const_disability_type1 = new List<const_disability_type>();
        List<const_edulev> const_edulev1 = new List<const_edulev>();
        List<const_elderly_grp> const_elderly_grp1 = new List<const_elderly_grp>();
        List<const_house_conditions> const_house_conditions1 = new List<const_house_conditions>();
        List<const_occ> const_occ1 = new List<const_occ>();
        List<const_pertyp> const_pertyp1 = new List<const_pertyp>();
        List<const_plc> const_plc1 = new List<const_plc>();
        List<const_plcnmegen> const_plcnmegen1 = new List<const_plcnmegen>();
        List<const_reg> const_reg1 = new List<const_reg>();
        List<const_reltyp> const_reltyp1 = new List<const_reltyp>();
        List<const_school> const_school1 = new List<const_school>();
        List<const_stsmar> const_stsmar1 = new List<const_stsmar>();
        List<const_vaccination> const_vaccination1 = new List<const_vaccination>();
        public bool checkedCongenital_disease1 { get; set; }
        public bool checkedCongenital_disease2 { get; set; }
        public bool checkedCongenital_disease3 { get; set; }
        public bool checkedCongenital_disease4 { get; set; }
        public bool checkedCongenital_disease5 { get; set; }
        public bool checkedCongenital_disease6 { get; set; }
        public bool checkedCongenital_disease7 { get; set; }
        public bool checkedCongenital_disease8 { get; set; }
        public bool checkedCongenital_disease9 { get; set; }
        public bool checkedCongenital_disease11 { get; set; }
        public bool checkedCongenital_disease12 { get; set; }
        public bool checkedCongenital_disease13 { get; set; }
        public bool checkedCongenital_disease_oth1 { get; set; }
        public bool checkedCongenital_disease_oth2 { get; set; }
        public bool checkedCongenital_disease_oth3 { get; set; }
        public bool checkedCongenital_disease_oth4 { get; set; }
        public bool checkedCongenital_disease_oth5 { get; set; }
        public bool checkedCongenital_disease_oth6 { get; set; }
        static SemaphoreSlim semaphonSlim = new SemaphoreSlim(1);
        string provinceId;
        string districtId;
        string districtId2;
        string tambonId2;
        string complete = "";
        private string threatId3 = null;
        public string tambonId
        {
            get { return threatId3; }
            set
            {
                threatId3 = value;
            }
        }
        private string threatId = null;

        private string threatId4 = null;
        private string threatId5 = null;
        private string threatId2 = null;
        private string districtSel = null;
        private IJSObjectReference _jsModule;
        [Parameter]
        public string HC { get; set; }
        //EmployeeContext DBContext;


        [Inject] public IGeolocationService GeolocationService { get; set; }
        protected GeolocationResult CurrentPositionResult { get; set; }
        protected string CurrentLatitude => CurrentPositionResult?.Position?.Coords?.Latitude.ToString("F2");
        protected string CurrentLongitude => CurrentPositionResult?.Position?.Coords?.Longitude.ToString("F2");
        private bool isWatching => WatchHandlerId.HasValue;
        protected long? WatchHandlerId { get; set; }
        protected GeolocationResult LastWatchPositionResult { get; set; }
        protected string LastWatchLatitude => LastWatchPositionResult?.Position?.Coords?.Latitude.ToString("F2");
        protected string LastWatchLongitude => LastWatchPositionResult?.Position?.Coords?.Longitude.ToString("F2");
        protected string LastWatchTimestamp => LastWatchPositionResult?.Position?.DateTimeOffset.ToString();
        protected string ToggleWatchCommand => isWatching ? "Stop watching" : "Start watching";
        public async void ShowCurrentPosition()
        {


            CurrentPositionResult = await GeolocationService.GetCurrentPosition();
            recordSurveyProfile.lat = CurrentLatitude;
            recordSurveyProfile.lon = CurrentLongitude;
            StateHasChanged();
        }
        public static class configSurvey
        {
            public static string survey_year = "2563";
            public static string survey_no_num = "1";
            public static string survey_no(string HC, int? index)
            {//-------no-------------survey year


                var index4 = index.ToString().PadLeft(4, '0');
                return configSurvey.survey_no_num + "|" + configSurvey.survey_year + "|" + HC + "|" + index4;

            }
            public static string HC_random(string hc)
            {
                //var index4 = (1).ToString().PadLeft(4, '0');
                string hc2 = hc.ToString() + "|" + configSurvey.randomNum();
                return configSurvey.survey_no_num + "|" + configSurvey.survey_year + "|" + hc2;
                //return 1 + "|" + configSurvey.survey_year + "|" + hc + "|" + configSurvey.randomNum;

            }
            public static string HC_noId(string hc)
            {
                //var index4 = (1).ToString().PadLeft(4, '0');
                string hc2 = hc.ToString();
                return configSurvey.survey_no_num + "|" + configSurvey.survey_year + "|" + hc2;
                //return 1 + "|" + configSurvey.survey_year + "|" + hc + "|" + configSurvey.randomNum;

            }
            public static string randomNum()
            {
                Random r = new Random();
                int num = r.Next();
                return num.ToString();
            }
            public static int timestam()
            {
                return (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            }
            public static void commentUplog()
            {
                //await DBContext.AddItems<log_file>("log_file", new List<log_file> {
                //	new log_file {
                //		id=Convert.ToInt32(configSurvey.randomNum()),
                //		username= await JSRuntime.InvokeAsync<string>("localStorage.getItem", "name"),
                //		time1=configSurvey.timestam(),
                //		detail=detail
                //		} });

            }


        }
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



        public void autoTab(KeyboardEventArgs e)
        {
            //var key=e.Code.Remove(e.Code.Length - 1);
            //if (key == "Digit" ||key == "Numpad")
            //{
            //	// ...
            //	recordSurveyProfile.HC = recordSurveyProfile.HC + e.Key;
            //}
            //         else
            //         {
            //	recordSurveyProfile.HC = recordSurveyProfile.HC.Remove(recordSurveyProfile.HC.Length - 1) + "|";

            //}

        }


        protected override async Task OnInitializedAsync()
        {
            this.VisibleProperty = true;
            
            await DBContext.OpenIndexedDb();
            provinces1 = await DBContext.GetAll<province>("province");
            districts1 = await DBContext.GetAll<district>("district");
            tambons1 = await DBContext.GetAll<tambon>("tambon");
            const_prenme1 = await DBContext.GetAll<const_prenme>("const_prenme");
            const_sex1 = await DBContext.GetAll<const_sex>("const_sex");
            //person1
            //= await DBContext.GetAll<person>("person");
            const_currlev1 = await DBContext.GetAll<const_currlev>("const_currlev");
            const_disability_type1 = await DBContext.GetAll<const_disability_type>("const_disability_type");
            const_edulev1 = await DBContext.GetAll<const_edulev>("const_edulev");
            const_elderly_grp1 = await DBContext.GetAll<const_elderly_grp>("const_elderly_grp");
            const_house_conditions1 = await DBContext.GetAll<const_house_conditions>("const_house_conditions");
            const_occ1 = await DBContext.GetAll<const_occ>("const_occ");
            const_pertyp1 = await DBContext.GetAll<const_pertyp>("const_pertyp");
            //const_plc1 = await DBContext.GetAll<const_plc>("const_plc");
            //const_plcnmegen1 = await DBContext.GetAll<const_plcnmegen>("const_plcnmegen");
            const_reg1 = await DBContext.GetAll<const_reg>("const_reg");
            const_reltyp1 = await DBContext.GetAll<const_reltyp>("const_reltyp");
            const_school1 = await DBContext.GetAll<const_school>("const_school");
            const_sex1 = await DBContext.GetAll<const_sex>("const_sex");
            const_stsmar1 = await DBContext.GetAll<const_stsmar>("const_stsmar");
            const_vaccination1 = await DBContext.GetAll<const_vaccination>("const_vaccination");
            //################
            await JSRuntime.InvokeVoidAsync("localStorage.setItem", "HC", HC);
            //_jsModule = await JSRuntime.InvokeAsync<IJSObjectReference>("import", "./script/callFunction.js");
            if (HC != null)
            {

                List<person> getAllSurPro = await DBContext.GetByIndex<string, person>("person", HC, null, "hc", false);
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
            this.VisibleProperty = false;
        }



        private string imageString = "";
        private string imageDataurl = "";
        async Task OnInputFileChange(InputFileChangeEventArgs e)
        {


            var imageFiles = e.GetMultipleFiles(1).FirstOrDefault();
            var format = "image/png";

            var test1 = await DBContext.GetByIndex<string, ch2_gis>("ch2_gis", "222", "", "hc", false);
            var test2 = test1.FirstOrDefault();

            var resizedīmageFile = await imageFiles.RequestImageFileAsync(format, 400, 400);
            var buffer = new byte[resizedīmageFile.Size];
            await resizedīmageFile.OpenReadStream().ReadAsync(buffer);
            imageString = Convert.ToBase64String(buffer);

            imageDataurl = $"data:{format}; base64, {imageString}";
            //var imageDataurl = $"data:{format}; base64, {Convert.ToBase64String(buffer)}";



        }
        protected async Task HandleValidSubmit(EditContext context)
        {
            
            string User = await JSRuntime.InvokeAsync<string>("localStorage.getItem", "name");
            await DBContext.OpenIndexedDb();
            Random r = new Random();
            int num = r.Next();
            if (recordSurveyProfile.HC == null || recordSurveyProfile.id==null)
            {
                recordSurveyProfile.HC = num.ToString();
                recordSurveyProfile.id = num.ToString();
            }
            
            int updateStamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            recordSurveyProfile.JUN = SelectProvinceId;
            recordSurveyProfile.AMP = SelectDistrictId;
            recordSurveyProfile.TMP = tambonId;
            recordSurveyProfile.picname1 = imageString;
            var HCFromInput = configSurvey.HC_random(recordSurveyProfile.HC);

            //recordSurveyProfile.survey_no = HCFromInput;
            List<person> GetHC = await DBContext.GetByIndex<string, person>("person", recordSurveyProfile.HC, null, "hc", false);
            if (GetHC.Count != 0)
            {
                recordSurveyProfile.upddte = updateStamp;
                _ = await DBContext.UpdateItems<person>("person", new List<person> { recordSurveyProfile });
                _ = await DBContext.AddItems<log_file>("log_file", new List<log_file> { new log_file { id = num, username = User, time1 = updateStamp, detail = "แก้ไข" + recordSurveyProfile.HC + "profile" } });
            }
            else
            {
                recordSurveyProfile.id = num.ToString();
                await DBContext.AddItems<person>("person", new List<person>() { recordSurveyProfile });

                //update person set create_survey='".date("U")."' where HC='$HC'
                //districts =await DBContext.GetByIndex<int?,district>("district", proId,0,"province_id",false);
                var getAll = await DBContext.GetAll<person>("person");
                List<person> updateSurPro = await DBContext.GetByIndex<string, person>("person", recordSurveyProfile.HC, null, "hc", false);
                updateSurPro.First().upddte  = updateStamp;
                await DBContext.UpdateItems<person>("person", new List<person> { updateSurPro.First() });
                //$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','เพิ่ม $HC')";
                await DBContext.AddItems<log_file>("log_file", new List<log_file>{
        new log_file{
            id=num,
                username=User,
                time1=(int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds,
                detail="เพิ่ม "+recordSurveyProfile.HC
        }
        });

            }

            List<survey_staff> getSurveyStaff = await DBContext.GetAll<survey_staff>("survey_staff");
            var getStaffBySurveyYear = getSurveyStaff.Where(x => x.HC.Contains(recordSurveyProfile.HC)).ToList();
            //$query1="insert into survey_staff (HC,survey_year,survey_no,staff) value('$HC','$survey_year','$survey_no','$staff')";
            if (getStaffBySurveyYear.Count == 0)
            {

                _ = await DBContext.AddItems<survey_staff>("survey_staff", new List<survey_staff> {

                    new survey_staff
                    {
						//HC =  recordSurveyProfile.HC,
						HC =recordSurveyProfile.HC,
                        survey_year = configSurvey.survey_year,
                        survey_no = configSurvey.survey_no_num,
                        staff=User,
                        ch1_st=(int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds

                    }

                });
            }


            HC = recordSurveyProfile.HC;
            //$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','เพิ่ม $HC')";
            complete = "เรียบร้อย";
        }
        private Task gotoPage(string HC_nextPage)
        {
            NavigationManager.NavigateTo("/surveya1/" + HC_nextPage);
            return Task.CompletedTask;
        }

        public Task gotoSelAsync()
        {
            //{
            //	await DBContext.OpenIndexedDb();
            //	districts = await DBContext.GetByIndex<int?, district>("district", Convert.ToInt32(recordSurveyProfile.JUN), 0, "province_id", false);
            //	tambons = await DBContext.GetByIndex<string, tambon>("tambon", "9402", null, "district_id", false);

            SelectProvinceId = "94";
            //	//SelectDistrictId = recordSurveyProfile.AMP;
           // recordSurveyProfile.TMP = "940109";
           // recordSurveyProfile.AGRI_NO = "sdsdsdsdsdsdsds";
            return Task.CompletedTask;
        }

        public MatTheme theme = new MatTheme { Primary = "#AAAA00", Secondary = "#00AAAA", OnSecondary = "#FAFAAA" };
        void Navigate(string HC_nextPage)
        {
            UriHelper.NavigateTo("/surveya1/" + HC_nextPage);
        }
        string textINfo2 = "";
        string stringValue = "";
        protected async void SetValue(string Value)
        {
            textINfo2 = "text :" + Value;
            string textVal = Value.Replace("-", "");
            if (textVal.Length > 10)
            {
                await DBContext.OpenIndexedDb();
                var getHcBytext = await DBContext.GetByIndex<string, person>("person", Value, "", "hc", false);

                if (getHcBytext != null && getHcBytext.Count > 0)
                {
                    Globals.HC_globla = getHcBytext.FirstOrDefault().HC;

                }
                else
                {
                    Globals.HC_globla = "";

                }
            }


        }
    }

    



}
