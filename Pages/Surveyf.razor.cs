

using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstBlazorApp.Models;
using Microsoft.AspNetCore.Components.Forms;
using static FirstBlazorApp.Pages.Surveypageone;

namespace FirstBlazorApp.Pages
{
    public partial class Surveyf : ComponentBase
    {

        [Parameter]
        public string HC { get; set; }
        string complete = "";
        chksurveyb2 formData = new chksurveyb2();
        class chksurveyb2
        {
            public bool r1 { get; set; }
            public bool r2 { get; set; }
            public bool r3 { get; set; }
            public bool r4 { get; set; }
            public bool r5 { get; set; }
            public bool r6 { get; set; }
            public bool r7 { get; set; }
            public bool r8 { get; set; }
            public bool r9 { get; set; }
            public survey_f1 surveyTemp = new survey_f1();

        }

        protected override async Task OnInitializedAsync()
        {
            await DBContext.OpenIndexedDb();
            string hc = configSurvey.HC_noId(HC);
            List<survey_f1> getAllSurPro = await DBContext.GetByIndex<string, survey_f1>("survey_f1", hc, null, "hc", false);

            if (getAllSurPro.Count() > 0)
            {

                formData.surveyTemp = getAllSurPro.FirstOrDefault();
            }

            formData.r1 = String.IsNullOrEmpty(formData.surveyTemp.r1) ? false : true;
            formData.r2 = String.IsNullOrEmpty(formData.surveyTemp.r2) ? false : true;
            formData.r3 = String.IsNullOrEmpty(formData.surveyTemp.r3) ? false : true;
            formData.r4 = String.IsNullOrEmpty(formData.surveyTemp.r4) ? false : true;
            formData.r5 = String.IsNullOrEmpty(formData.surveyTemp.r5) ? false : true;
            formData.r6 = String.IsNullOrEmpty(formData.surveyTemp.r6) ? false : true;
            formData.r7 = String.IsNullOrEmpty(formData.surveyTemp.r7) ? false : true;
            formData.r8 = String.IsNullOrEmpty(formData.surveyTemp.r8) ? false : true;
            formData.r9 = String.IsNullOrEmpty(formData.surveyTemp.r9) ? false : true;



        }
        protected async Task HandleValidSubmit(EditContext context)
        {
            int index = 0;
            //$query="update survey_a1 set a7_0='$a7_0[$i]',a7_1='$a7_1[$i]',a7_1_1='$a7_1_1[$i]',a7_1_2='$a7_1_2[$i]',a7_2='$a7_2[$i]',a7_2_1='$a7_2_1[$i]',a7_2_2='$a7_2_2[$i]',a7_3='$a7_3[$i]',a7_3_1='$a7_3_1[$i]',a7_3_2='$a7_3_2[$i]',a7_4='$a7_4[$i]',a7_4_1='$a7_4_1[$i]',a7_4_2='$a7_4_2[$i]',a7_5='$a7_5[$i]',a7_5_1='$a7_5_1[$i]',a7_5_2='$a7_5_2[$i]',a7_6='$a7_6[$i]',a7_6_1='$a7_6_1[$i]',a7_6_2='$a7_6_2[$i]',a7_7='$a7_7[$i]',a7_7_1='$a7_7_1[$i]',a7_7_2='$a7_7_2[$i]',a7_8='$a7_8[$i]',a7_8_1='$a7_8_1[$i]',a7_8_2='$a7_8_2[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
            formData.r1 = String.IsNullOrEmpty(formData.surveyTemp.r1) ? false : true;
            formData.r2 = String.IsNullOrEmpty(formData.surveyTemp.r2) ? false : true;
            formData.r3 = String.IsNullOrEmpty(formData.surveyTemp.r3) ? false : true;
            formData.r4 = String.IsNullOrEmpty(formData.surveyTemp.r4) ? false : true;
            formData.r5 = String.IsNullOrEmpty(formData.surveyTemp.r5) ? false : true;
            formData.r6 = String.IsNullOrEmpty(formData.surveyTemp.r6) ? false : true;
            formData.r7 = String.IsNullOrEmpty(formData.surveyTemp.r7) ? false : true;
            formData.r8 = String.IsNullOrEmpty(formData.surveyTemp.r8) ? false : true;
            formData.r9 = String.IsNullOrEmpty(formData.surveyTemp.r9) ? false : true;

            string hc = configSurvey.HC_noId(HC);
            formData.surveyTemp.HC = hc;
            formData.surveyTemp.survey_year = configSurvey.survey_year;
            formData.surveyTemp.survey_no = configSurvey.survey_no_num;
            //List<survey_b2> getAllSurPro = await DBContext.GetByIndex<string, survey_b2>("survey_b2", hc, null, "hc", false);
            //if(getAllSurPro.Count() > 0)
            //{
            await DBContext.UpdateItems<survey_f1>("survey_f1", new List<survey_f1>() {
                formData.surveyTemp
             });

            //else
            //{
            //    getAdd=await DBContext.AddItems<survey_b2>("survey_b2", new List<survey_b2>() {
            //            formData.survey_B2
            //});
            //}
            var getallSurveyStaff = await DBContext.GetAll<survey_staff>("survey_staff");
            string hc_id = getallSurveyStaff.Where(x => x.HC.Contains(HC)).FirstOrDefault().HC;
            if (hc_id != null)
            {
                var updateStaff = await DBContext.GetByIndex<string, survey_staff>("survey_staff", hc_id, "", "hc", false);
                var firstStaff = updateStaff.FirstOrDefault();
                if (firstStaff != null)
                {
                    firstStaff.ch5_sp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

                    await DBContext.UpdateItems<survey_staff>("survey_staff", new List<survey_staff>() { firstStaff });
                }
            }
            complete = "เรียบร้อย";
        }


        private async Task gotoPage(string HC_nextPage)
        {
            NavigationManager.NavigateTo("/surveyd2/" + HC_nextPage);
        }
    }
}