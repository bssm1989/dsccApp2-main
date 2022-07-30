using FirstBlazorApp.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using static FirstBlazorApp.Pages.Surveypageone;
using MatBlazor;
using System.IO;
using System.Diagnostics;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using DnetIndexedDb;
using System.Text;

namespace FirstBlazorApp.Pages
{
    public partial class Index2 : ComponentBase
    {
        [Parameter]
        public string id { get; set; } = "";
        Employee emp = new Employee();
        private List<Models.Employee> employees = new List<Employee>();
        private List<Models.survey_profile> survey_profile_list = new List<survey_profile>();
        bool displayValidationErrorMessages = false;
        bool displayUserAddedToDB = false;

        //**************แบบสำรวจ***********
        private List<Models.staff_jun> re_ce = new List<Models.staff_jun>();
        private List<survey_staff> SurveyStaff = new List<survey_staff>();
        private List<Models.volunteer> name1 = new List<Models.volunteer>();
        private int num_total = 0;
        private string searchHc = "";
        class tableListSurvey
        {
            public survey_staff survey_staff { get; set; }
            public string HC { get; set; }
            public int? id { get; set; }
            public string status { get; set; }
            public string UserName { get; set; }
            public string nameProvince { get; set; }
            public bool spinning { get; set; }
            public int index { get; set; }
            public string imageFormData { get; set; }

        }
        List<tableListSurvey> tableListSurveys = new List<tableListSurvey>();

        IList<string> imageDataUrls = new List<string>();
        async Task OnInputFileChange(InputFileChangeEventArgs e)
        {
            await DBContext.OpenIndexedDb();

            var imageFiles = e.GetMultipleFiles(1);
            var format = "image/png";
            var test3 = new ch2_gis()
            {
                HC = "222"
            };
            await DBContext.UpdateItems<ch2_gis>("ch2_gis", new List<ch2_gis>() { test3 });
            var test1 = await DBContext.GetByIndex<string, ch2_gis>("ch2_gis", "222", "", "hc", false);
            var test2 = test1.FirstOrDefault();
            foreach (var imageFile in imageFiles)
            {
                var resizedīmageFile = await imageFile.RequestImageFileAsync(format, 400, 400);
                var buffer = new byte[resizedīmageFile.Size];
                await resizedīmageFile.OpenReadStream().ReadAsync(buffer);
                test2.mm = Convert.ToBase64String(buffer);
                await DBContext.UpdateItems<ch2_gis>("ch2_gis", new List<ch2_gis>() { test2 });
                var imageDataurl = $"data:{format}; base64, {test2.mm}";
                //var imageDataurl = $"data:{format}; base64, {Convert.ToBase64String(buffer)}";
                imageDataUrls.Add(imageDataurl);

            }
        }
        string currentCount = "";
        bool spinning = false;

        //******************* File content*********************
        string fileContent;

        async Task FilesReadyForContent(IMatFileUploadEntry[] files)
        {
            try
            {
                var file = files.FirstOrDefault();
                if (file == null)
                {
                    return;
                }

                using (var stream = new MemoryStream())
                {
                    var sw = Stopwatch.StartNew();
                    await file.WriteToStreamAsync(stream);
                    sw.Stop();
                    if (stream.Length > 1024 * 1024)
                    {
                        fileContent = "";
                        fileContent += $"Name:\t{file.Name}\r\n";
                        fileContent += $"Type:\t{file.Type}\r\n";
                        fileContent += $"LastModified:\t{file.LastModified}\r\n";
                        fileContent += $"Size:\t{file.Size}\r\n";
                        fileContent += $"Time:\t{sw.Elapsed}\r\n";
                        fileContent += $"Speed:\t{(stream.Length / sw.Elapsed.TotalSeconds):N0}  b/s\r\n";
                    }
                    else
                    {
                        stream.Seek(0, SeekOrigin.Begin);
                        using (var reader = new StreamReader(stream))
                        {
                            fileContent = await reader.ReadToEndAsync();
                        }
                    }
                }
            }

            catch (Exception e)
            {
                fileContent = $"Error:\r\n{e.Message}\r\n{e.StackTrace}";
            }
            finally
            {
                await InvokeAsync(StateHasChanged);
            }
        }
        //******************* loading *********************
        protected async Task DeleteData()
        {
            await DBContext2.OpenIndexedDb();
            await DBContext2.DeleteAll("ch2_gis_2");
            InvokeAsync(() =>
            {
                StateHasChanged();
            });
        }
        private async Task AsyncLongFunc()
        {


            ch2_gis_2 sampleCh2 = new ch2_gis_2();
            sampleCh2.HC = configSurvey.randomNum();

            var test1 = await DBContext2.OpenIndexedDb();
            if (test1 == 0)
            {
                await DBContext2.AddItems<ch2_gis_2>("ch2_gis_2", new List<ch2_gis_2>(){
                sampleCh2
            });
            }
            var test = await DBContext2.GetAll<ch2_gis_2>("ch2_gis_2");
            currentCount = test.Count.ToString();



            spinning = true;
            // flushing changes. The trick!!
            LongFunc();               // non-async code
                                      // currentCount++;
            spinning = false;

            await Task.CompletedTask;



            StateHasChanged();
        }
        private async Task syndatabyHc(int? id, int index)
        {

            tableListSurveys.ElementAt(index).spinning = true;
            await Task.Delay(1000);
            await DBContext.toServerByHc(id);
            tableListSurveys.ElementAt(index).spinning = false;
            await Task.CompletedTask;
            await InvokeAsync(StateHasChanged);
        }


        async Task LongFunc()
        {
            Task.Delay(10000).Wait();
        }



        private List<Models.survey_profile> survey_profile_list_by_hc = new List<survey_profile>();
        private List<survey_profile> survey_profiles = new List<survey_profile>();

        public class listTableByHc
        {
            List<Models.survey_profile> survey_profile_list_by_hc = new List<survey_profile>();

        }


        public async Task synData()
        {
            await DBContext.loadDbFromServer();
        }

        // http

        Employee ReceivedEmployee;
        public string FormSubmitMessage { get; set; } = "Reservation Not Created";

        public async Task HandleValidSubmit()
        {
        }

        private async Task GetSavedEmployees()
        { employees = await DBContext.GetAll(); }
        private async Task DeleteEmployee(int id)
        {
            await DBContext.Delete(id);
            await Task.Run(() => GetSavedEmployees());
            await Task.CompletedTask;
        }
        private async Task DeleteSurvey_profile(int? id)
        {
            var openResult = await DBContext.OpenIndexedDb();

            await DBContext.DeleteByKey<int?>("survey_profile", id);
            survey_profile_list = await DBContext.GetAll<survey_profile>("survey_profile");
            //var updateSurPro=await DBContext.GetByIndex<string, survey_profile>("survey_profile", "1", null, "hc", false);
            var itemToRemove = tableListSurveys.Single(r => r.id == id);
            tableListSurveys.Remove(itemToRemove);

            StateHasChanged();
        }

        private async Task HandleValidSubmit(EditContext context)
        {
            displayValidationErrorMessages = true;
            displayUserAddedToDB = false;
            await DBContext.Add(new Models.Employee()
            {
                Email = emp.Email,
                Fullname = emp.Fullname,
                MobileNumber = emp.MobileNumber


            });
            emp.Fullname = "";
            emp.Email = "";
            emp.MobileNumber = "";
        }
        private async Task HandleInvalidSubmitAsync(EditContext context)
        {
            displayValidationErrorMessages = true;
            displayUserAddedToDB = false;


        }
        private async Task searchHcList()
        {
            //await DBContext.OpenIndexedDb;
            survey_profile_list_by_hc = await DBContext.GetAll<survey_profile>("survey_profile");
            //survey_profile_list_by_hc = survey_profile_list_by_hc
            //    .Where(x=>x.HC.Contains(searchHc) &&
            //    x.survey_year==configSurvey.survey_year &&
            //    x.survey_no== configSurvey.survey_no_num 
            //   ).ToList();
            SurveyStaff = await DBContext.GetAll<survey_staff>("survey_staff");
            var listProfileStaff = from sp in survey_profile_list_by_hc
                                   join st in SurveyStaff on sp.survey_no equals st.HC
                                   select new { sp, st };
            var listByhc = listProfileStaff.ToList();
            //listByhc.ElementAt(0).sp.HC;
        }

        async void runBuild()
        {
            var builder = WebAssemblyHostBuilder.CreateDefault();
            builder.Services.AddIndexedDbDatabase<EmployeeContext2>(o => { o.UseDatabase(new EmployeeOfflineDb2()); });

            await builder.Build().RunAsync();
        }
        protected override async Task OnInitializedAsync()
        {
            var openResult = await DBContext.OpenIndexedDb();
            await DBContext2.OpenIndexedDb();
            var test = await DBContext2.GetAll<ch2_gis_2>("ch2_gis_2");
            currentCount = test.Count.ToString();
            //await DBContext2.OpenIndexedDb();
            // ch2_gis sampleCh2 = new ch2_gis();
            // sampleCh2.HC = "dfdfsssdghghdsdddddddddddddddfssssd";
            // await DBContext2.AddItems<ch2_gis>("ch2_gis", new List<ch2_gis>(){
            //     sampleCh2
            // }) ;
            // await DBContext2.DeleteIndexedDb();



            survey_profile_list = (await DBContext.GetAll<survey_profile>("survey_profile")).OrderBy(x => x.create_survey).ToList();

            employees = await DBContext.GetAll();
            //************  syn data *********
            var getProvince = await DBContext.GetAll<province>("province");
            if (getProvince.Count == 0)
            {

                await DBContext.loadDbFromServer();
            }
            List<volunteer> getuser = new List<volunteer>();
            var listUser = await DBContext.GetAll<volunteer>("volunteer");
            if(listUser.Count == 0)
            {
                if (id != "")

                {
                    await DBContext.loadUserFromServer(Int32.Parse(id));
                    getuser = await DBContext.GetByIndex<int?, volunteer>("volunteer", Int16.Parse(id), null, "id", false);
                    await JSRuntime.InvokeVoidAsync("localStorage.setItem", "name", getuser.Where(x => x.id == Int16.Parse(id)).FirstOrDefault().username);
                    StateHasChanged();
                    NavigationManager.NavigateTo("https://livingonnewpacesite1.github.io/LONPApp");
                    
                }
            }else
            {
                    NavigationManager.NavigateTo("https://livingonnewpacesite1.github.io/LONPApp");
                if (id != ""&& id!=null)
                {
                    getuser= await DBContext.GetByIndex<int?, volunteer>("volunteer", Int16.Parse(id), null, "id", false);
                    if (getuser.Count > 0)
                    {
                        var survey_profiles = await DBContext.GetAll<survey_profile>("survey_profile");
                        var provinces = await DBContext.GetAll<province>("province");
                        var survey_staffs = await DBContext.GetAll<survey_staff>("survey_staff");
                        var listProfileStaff = from sp in survey_profiles
                                               join st in survey_staffs on sp.HC equals st.HC
                                               select new { sp, st };
                        var listByhc = listProfileStaff.ToList();
                        int index = 0;
                        foreach (var item in listByhc.OrderBy(x => x.sp.create_survey))
                        {
                            var provinceName = "";
                            var getTxtProvince = await DBContext.GetByIndex<string, province>("province", string.IsNullOrEmpty(item.sp.JUN) ? "" : item.sp.JUN, "", "province_id", false);
                            if (getTxtProvince.Count == 0)
                            {
                                provinceName = "";
                            }
                            else
                            {
                                provinceName = getTxtProvince.FirstOrDefault().province_name_thai;
                            }
                            tableListSurveys.Add(new tableListSurvey
                            {
                                survey_staff = item.st,
                                UserName = item.st.staff,
                                nameProvince = provinceName,
                                HC = item.sp.HC,
                                id = item.sp.id,
                                status = item.sp.status,
                                spinning = false,
                                index = index,
                                imageFormData = $"data:{"image/png"}; base64, {item.sp.PP}"

                            });
                            index++;
                        }

                        num_total = survey_profile_list.Count();


                    }
                }
                else
                {
                    StateHasChanged(); NavigationManager.NavigateTo("https://livingonnewpacesite1.github.io/LONPApp");

                }
            }
           

            //**************แบบสำรวจ***********
            //$query_p = "select HC,JUN from        survey_profile where HC='$row->HC'";
            //198: 	$query_st = "select name from   volunteer where username='$row->staff'";
            //202: 	$query_j = "select              province_name_thai from province where province_id='$row_p->JUN'";
            //206: 	$qcheck = "select username from survey_check where HC='$row->HC' and survey_year='$survey_year' and survey_no='$survey_no'";
           

        }
        public static string UnixTimeStampToDateTime(int? unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            if (unixTimeStamp == null)
            {
                return "";
            }
            else
            {
                DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                dateTime = dateTime.AddSeconds((double)unixTimeStamp).ToLocalTime();
                return dateTime.ToString();
            }

        }
        
        private string AddResult = string.Empty;
    }
}

