using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components.Web;
using FirstBlazorApp.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;

using static FirstBlazorApp.Pages.Surveypageone;

namespace FirstBlazorApp.Pages
{
    public partial class Surveyb2 : ComponentBase
    {

        [Parameter]
        public string HC { get; set; }
string complete = "";
        chksurveyb2 formData = new chksurveyb2();
        class chksurveyb2
        {
            public bool b8_0 { get; set; }
            public bool b8_1 { get; set; }
            public bool b8_2 { get; set; }
            public bool b8_3 { get; set; }
            public bool b8_4 { get; set; }
            public bool b8_5 { get; set; }
            public bool b8_6 { get; set; }
            public survey_b2 survey_B2 = new survey_b2();

        }
        class surveyb3Model
        {
            // public survey_b2 Surveyb2 { get; set; }
            public chksurveyb2 chk { get; set; }
        }
        public string getUpdate { get; set; }
        public string getAdd { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await DBContext.OpenIndexedDb();
            string hc = configSurvey.HC_noId(HC);
            List<survey_b2> getAllSurPro = await DBContext.GetByIndex<string, survey_b2>("survey_b2", hc, null, "hc", false);


            //if (getAllSurPro.Count() > 0)
            //{
            //    //formData.survey_B2= getAllSurPro.FirstOrDefault();
            //}
            //else

            //{
            //    //                modelSurvey.Surveyb2 = new survey_b2 { b8_0="1",b8_1="1",b8_1_1="1",b8_1_2="1",b8_1_3="1",b8_1_4="1",b8_1_1_1="1",b8_1_1_2="1",b8_1_1_3="1",b8_1_1_4="1",b8_1_1_5="1",b8_1_1_6="1",b8_2="1",b8_2_1="1",b8_2_2="1",b8_2_3="1",b8_2_4="1",
            //    //b8_3="1",b8_3_1="1",b8_3_2="1",b8_3_3="1",b8_3_4="1",b8_4="1",b8_5="1",b8_5_1="1",b8_5_2="1",b8_5_3="1",b8_5_4="1",b8_5_5="1",b8_5_6="1",
            //    //b8_6="1",b8_6_1="1",b8_6_2="1",b8_6_3="1",b8_6_4="1",HC=hc,survey_no=configSurvey.survey_no_num,survey_year=configSurvey.survey_year
            //    //                } ;
            //    await DBContext.AddItems<survey_b2>("survey_b2", new List<survey_b2> {
            //        new survey_b2{
            //         HC =configSurvey.HC_noId(HC),
            //         survey_year =configSurvey.survey_year,
            //         survey_no =configSurvey.survey_no_num,


            //                        } });
            //    if (getAllSurPro.Count() > 0)
            //    {
            //        formData.survey_B2 = getAllSurPro.FirstOrDefault();
            //    }


            //}
            if (getAllSurPro.Count() > 0) {

                formData.survey_B2 = getAllSurPro.FirstOrDefault();
            }

            formData.b8_0 = String.IsNullOrEmpty(formData.survey_B2.b8_0) ? false : true;
            formData.b8_1 = String.IsNullOrEmpty(formData.survey_B2.b8_1) ? false : true;
            formData.b8_2 = String.IsNullOrEmpty(formData.survey_B2.b8_2) ? false : true;
            formData.b8_3 = String.IsNullOrEmpty(formData.survey_B2.b8_3) ? false : true;
            formData.b8_4 = String.IsNullOrEmpty(formData.survey_B2.b8_4) ? false : true;
            formData.b8_5 = String.IsNullOrEmpty(formData.survey_B2.b8_5) ? false : true;
            formData.b8_6 = String.IsNullOrEmpty(formData.survey_B2.b8_6) ? false : true;

        }
        protected async Task HandleValidSubmit(EditContext context)
        {
            int index = 0;
            //$query="update survey_a1 set a7_0='$a7_0[$i]',a7_1='$a7_1[$i]',a7_1_1='$a7_1_1[$i]',a7_1_2='$a7_1_2[$i]',a7_2='$a7_2[$i]',a7_2_1='$a7_2_1[$i]',a7_2_2='$a7_2_2[$i]',a7_3='$a7_3[$i]',a7_3_1='$a7_3_1[$i]',a7_3_2='$a7_3_2[$i]',a7_4='$a7_4[$i]',a7_4_1='$a7_4_1[$i]',a7_4_2='$a7_4_2[$i]',a7_5='$a7_5[$i]',a7_5_1='$a7_5_1[$i]',a7_5_2='$a7_5_2[$i]',a7_6='$a7_6[$i]',a7_6_1='$a7_6_1[$i]',a7_6_2='$a7_6_2[$i]',a7_7='$a7_7[$i]',a7_7_1='$a7_7_1[$i]',a7_7_2='$a7_7_2[$i]',a7_8='$a7_8[$i]',a7_8_1='$a7_8_1[$i]',a7_8_2='$a7_8_2[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";

            formData.survey_B2.b8_0 = formData.b8_0 ? "0" : "";
            formData.survey_B2.b8_1 = formData.b8_1 ? "1" : "";
            formData.survey_B2.b8_2 = formData.b8_2 ? "2" : "";
            formData.survey_B2.b8_3 = formData.b8_3 ? "3" : "";
            formData.survey_B2.b8_4 = formData.b8_4 ? "4" : "";
            formData.survey_B2.b8_5 = formData.b8_5 ? "5" : "";
            formData.survey_B2.b8_6 = formData.b8_6 ? "6" : "";
            string hc = configSurvey.HC_noId(HC);
            formData.survey_B2.HC = hc;
            formData.survey_B2.survey_year = configSurvey.survey_year;
            formData.survey_B2.survey_no = configSurvey.survey_no_num;
            //List<survey_b2> getAllSurPro = await DBContext.GetByIndex<string, survey_b2>("survey_b2", hc, null, "hc", false);
            //if(getAllSurPro.Count() > 0)
            //{
            getUpdate = await DBContext.UpdateItems<survey_b2>("survey_b2", new List<survey_b2>() {
                formData.survey_B2
             });
            complete = "เรียบร้อย";
            //else
            //{
            //    getAdd=await DBContext.AddItems<survey_b2>("survey_b2", new List<survey_b2>() {
            //            formData.survey_B2
            //});
            //}

        }
            
        
                private async Task gotoPage(string HC_nextPage)
        {
            NavigationManager.NavigateTo("/surveyb3/" + HC_nextPage);
        }
    }
}
