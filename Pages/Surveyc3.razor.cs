/*<?php
session_start();
error_reporting(E_ALL & ~E_DEPRECATED & ~E_STRICT & ~E_NOTICE &  ~E_WARNING);
//phpinfo();
//exit();
require_once ("config.php");
require_once ("function.php");
$next=str_replace("'","\'",$_POST["next"]);
if($next){
$mysqli=mcon($mysql["host"], $mysql["user"], $mysql["pass"], $mysql["dbname"],$mysql["charset"]);

$HC=$_SESSION["HC"];
$c6=$_POST[c6];
$c6_1=$_POST[c6_1];
$c6_2=$_POST[c6_2];
$c6_3=$_POST[c6_3];
$c6_4=$_POST[c6_4];
$c6_5=$_POST[c6_5];
$c6_6=$_POST[c6_6];
$c6_7=$_POST[c6_7];
$c6_8=$_POST[c6_8];
$c6_9=$_POST[c6_9];
$c6_10=$_POST[c6_10];
$c6_11=$_POST[c6_11];
$c6_11_1=$_POST[c6_11_1];

if(!$_SESSION["HC"]){
?>
<script>
location='https://livingonnewpace.com/survey/index.php?curr=survey_profile';
</script>*/
/*<?php
	exit();
}
*/


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
    public partial class Surveyc3 : ComponentBase
    {

        [Parameter]
        public string HC { get; set; }
string complete = "";
        chksurveyb2 formData = new chksurveyb2();
        class chksurveyb2
        {
            public bool c6 { get; set; }
            public bool c5 { get; set; }
            public bool c6_1 { get; set; }
            public bool c6_2 { get; set; }
            public bool c6_3 { get; set; }
            public bool c6_4 { get; set; }
            public bool c6_5 { get; set; }
            public bool c6_6 { get; set; }
            public bool c6_7 { get; set; }
            public bool c6_8 { get; set; }
            public bool c6_9 { get; set; }
            public bool c6_10 { get; set; }
            public bool c6_11 { get; set; }
            public survey_c1 surveyTemp = new survey_c1();

        }

        protected override async Task OnInitializedAsync()
        {
            await DBContext.OpenIndexedDb();
            string hc = configSurvey.HC_noId(HC);
            List<survey_c1> getAllSurPro = await DBContext.GetByIndex<string, survey_c1>("survey_c1", hc, null, "hc", false);

            if (getAllSurPro.Count() > 0)
            {

                formData.surveyTemp = getAllSurPro.FirstOrDefault();
            }

            formData.c6 = String.IsNullOrEmpty(formData.surveyTemp.c6) ? false : true;
            //formData.c5 = String.IsNullOrEmpty(formData.surveyTemp.c5) ? false : true;
            formData.c6_1 = String.IsNullOrEmpty(formData.surveyTemp.c6_1) ? false : true;
            formData.c6_2 = String.IsNullOrEmpty(formData.surveyTemp.c6_2) ? false : true;
            formData.c6_3 = String.IsNullOrEmpty(formData.surveyTemp.c6_3) ? false : true;
            formData.c6_4 = String.IsNullOrEmpty(formData.surveyTemp.c6_4) ? false : true;
            formData.c6_5 = String.IsNullOrEmpty(formData.surveyTemp.c6_5) ? false : true;
            formData.c6_6 = String.IsNullOrEmpty(formData.surveyTemp.c6_6) ? false : true;
            formData.c6_7 = String.IsNullOrEmpty(formData.surveyTemp.c6_7) ? false : true;
            formData.c6_8 = String.IsNullOrEmpty(formData.surveyTemp.c6_8) ? false : true;
            formData.c6_9 = String.IsNullOrEmpty(formData.surveyTemp.c6_9) ? false : true;
            formData.c6_10 = String.IsNullOrEmpty(formData.surveyTemp.c6_10) ? false : true;
            formData.c6_11 = String.IsNullOrEmpty(formData.surveyTemp.c6_11) ? false : true;

        }
        protected async Task HandleValidSubmit(EditContext context)
        {
            int index = 0;
            //$query="update survey_a1 set a7_0='$a7_0[$i]',a7_1='$a7_1[$i]',a7_1_1='$a7_1_1[$i]',a7_1_2='$a7_1_2[$i]',a7_2='$a7_2[$i]',a7_2_1='$a7_2_1[$i]',a7_2_2='$a7_2_2[$i]',a7_3='$a7_3[$i]',a7_3_1='$a7_3_1[$i]',a7_3_2='$a7_3_2[$i]',a7_4='$a7_4[$i]',a7_4_1='$a7_4_1[$i]',a7_4_2='$a7_4_2[$i]',a7_5='$a7_5[$i]',a7_5_1='$a7_5_1[$i]',a7_5_2='$a7_5_2[$i]',a7_6='$a7_6[$i]',a7_6_1='$a7_6_1[$i]',a7_6_2='$a7_6_2[$i]',a7_7='$a7_7[$i]',a7_7_1='$a7_7_1[$i]',a7_7_2='$a7_7_2[$i]',a7_8='$a7_8[$i]',a7_8_1='$a7_8_1[$i]',a7_8_2='$a7_8_2[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";

            formData.surveyTemp.c6 = formData.c6 ? "0" : "";
            //formData.surveyTemp.c5 = formData.c5 ? "1" : "";
            formData.surveyTemp.c6_1 = formData.c6_1 ? "1" : "";
            formData.surveyTemp.c6_2 = formData.c6_2 ? "2" : "";
            formData.surveyTemp.c6_3 = formData.c6_3 ? "3" : "";
            formData.surveyTemp.c6_4 = formData.c6_4 ? "4" : "";
            formData.surveyTemp.c6_5 = formData.c6_5 ? "5" : "";
            formData.surveyTemp.c6_6 = formData.c6_6 ? "6" : "";
            formData.surveyTemp.c6_7 = formData.c6_7 ? "7" : "";
            formData.surveyTemp.c6_8 = formData.c6_8 ? "8" : "";
            formData.surveyTemp.c6_9 = formData.c6_9 ? "9" : "";
            formData.surveyTemp.c6_10 = formData.c6_10 ? "10" : "";
            formData.surveyTemp.c6_11 = formData.c6_11 ? "11" : "";
            string hc = configSurvey.HC_noId(HC);
            formData.surveyTemp.HC = hc;
            formData.surveyTemp.survey_year = configSurvey.survey_year;
            formData.surveyTemp.survey_no = configSurvey.survey_no_num;
            //List<survey_b2> getAllSurPro = await DBContext.GetByIndex<string, survey_b2>("survey_b2", hc, null, "hc", false);
            //if(getAllSurPro.Count() > 0)
            //{
            await DBContext.UpdateItems<survey_c1>("survey_c1", new List<survey_c1>() {
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
                    firstStaff.ch3_sp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

                    await DBContext.UpdateItems<survey_staff>("survey_staff", new List<survey_staff>() { firstStaff });
                }
            }
            complete = "เรียบร้อย";
        }


        private async Task gotoPage(string HC_nextPage)
        {
            NavigationManager.NavigateTo("/surveyd1/" + HC_nextPage);
        }
    }
}



/*

$query1="update survey_c1 set c6='$c6',c6_1='$c6_1',c6_2='$c6_2',c6_3='$c6_3',c6_4='$c6_4',c6_5='$c6_5',c6_6='$c6_6',c6_7='$c6_7',c6_8='$c6_8',c6_9='$c6_9',c6_10='$c6_10',c6_11='$c6_11',c6_11_1='$c6_11_1' where HC='$HC'  and survey_year='$survey_year' and survey_no='$survey_no'";

//echo$query1."<br>";
$mysqli->query($query1);

$query_up1="update survey_staff set ch3_sp='".date("U")."' where  HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$result_up1=$mysqli->query($query_up1);

$username=$_COOKIE[username_log];
$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 3 3/3')";
$result_log=$mysqli->query($log);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveyd1'
</script>*/