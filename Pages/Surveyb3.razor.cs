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
$b9_1=$_POST[b9_1];
$b9_2=$_POST[b9_2];
$b9_3=$_POST[b9_3];
$b9_4=$_POST[b9_4];
$b9_5=$_POST[b9_5];
$b9_6=$_POST[b9_6];
$b9_6_1=$_POST[b9_6_1];
$b10=$_POST[b10];
$b10_1=$_POST[b10_1];
$b10_2=$_POST[b10_2];
$b10_3=$_POST[b10_3];
$b10_4=$_POST[b10_4];
$b10_5=$_POST[b10_5];
$b10_6=$_POST[b10_6];
$b10_7=$_POST[b10_7];
$b10_7_1=$_POST[b10_7_1];

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
    public partial class Surveyb3 : ComponentBase
    {

        [Parameter]
        public string HC { get; set; }
string complete = "";
        chksurveyb2 formData = new chksurveyb2();
        class chksurveyb2
        {
            public bool b9_1 { get; set; }
            public bool b9_2 { get; set; }
            public bool b9_3 { get; set; }
            public bool b9_4 { get; set; }
            public bool b9_5 { get; set; }
            public bool b9_6 { get; set; }
            public bool b10_1 { get; set; }
            public bool b10_2 { get; set; }
            public bool b10_3 { get; set; }
            public bool b10_4 { get; set; }
            public bool b10_5 { get; set; }
            public bool b10_6 { get; set; }
            public bool b10_7 { get; set; }
            public survey_b2 surveyTemp = new survey_b2();

        }


        protected override async Task OnInitializedAsync()
        {
            await DBContext.OpenIndexedDb();
            string hc = configSurvey.HC_noId(HC);
            List<survey_b2> getAllSurPro = await DBContext.GetByIndex<string, survey_b2>("survey_b2", hc, null, "hc", false);

            if (getAllSurPro.Count() > 0)
            {

                formData.surveyTemp = getAllSurPro.FirstOrDefault();
            }

            formData.b9_1 = String.IsNullOrEmpty(formData.surveyTemp.b9_1) ? false : true;
            formData.b9_2 = String.IsNullOrEmpty(formData.surveyTemp.b9_2) ? false : true;
            formData.b9_3 = String.IsNullOrEmpty(formData.surveyTemp.b9_3) ? false : true;
            formData.b9_4 = String.IsNullOrEmpty(formData.surveyTemp.b9_4) ? false : true;
            formData.b9_5 = String.IsNullOrEmpty(formData.surveyTemp.b9_5) ? false : true;
            formData.b9_6 = String.IsNullOrEmpty(formData.surveyTemp.b9_6) ? false : true;
            formData.b10_1 = String.IsNullOrEmpty(formData.surveyTemp.b10_1) ? false : true;
            formData.b10_2 = String.IsNullOrEmpty(formData.surveyTemp.b10_2) ? false : true;
            formData.b10_3 = String.IsNullOrEmpty(formData.surveyTemp.b10_3) ? false : true;
            formData.b10_4 = String.IsNullOrEmpty(formData.surveyTemp.b10_4) ? false : true;
            formData.b10_5 = String.IsNullOrEmpty(formData.surveyTemp.b10_5) ? false : true;
            formData.b10_6 = String.IsNullOrEmpty(formData.surveyTemp.b10_6) ? false : true;
            formData.b10_7 = String.IsNullOrEmpty(formData.surveyTemp.b10_7) ? false : true;

        }
        protected async Task HandleValidSubmit(EditContext context)
        {
            int index = 0;
            //$query="update survey_a1 set a7_0='$a7_0[$i]',a7_1='$a7_1[$i]',a7_1_1='$a7_1_1[$i]',a7_1_2='$a7_1_2[$i]',a7_2='$a7_2[$i]',a7_2_1='$a7_2_1[$i]',a7_2_2='$a7_2_2[$i]',a7_3='$a7_3[$i]',a7_3_1='$a7_3_1[$i]',a7_3_2='$a7_3_2[$i]',a7_4='$a7_4[$i]',a7_4_1='$a7_4_1[$i]',a7_4_2='$a7_4_2[$i]',a7_5='$a7_5[$i]',a7_5_1='$a7_5_1[$i]',a7_5_2='$a7_5_2[$i]',a7_6='$a7_6[$i]',a7_6_1='$a7_6_1[$i]',a7_6_2='$a7_6_2[$i]',a7_7='$a7_7[$i]',a7_7_1='$a7_7_1[$i]',a7_7_2='$a7_7_2[$i]',a7_8='$a7_8[$i]',a7_8_1='$a7_8_1[$i]',a7_8_2='$a7_8_2[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";

            formData.surveyTemp.b9_1 = formData.b9_1 ? "0" : "";
            formData.surveyTemp.b9_2 = formData.b9_2 ? "0" : "";
            formData.surveyTemp.b9_3 = formData.b9_3 ? "0" : "";
            formData.surveyTemp.b9_4 = formData.b9_4 ? "0" : "";
            formData.surveyTemp.b9_5 = formData.b9_5 ? "0" : "";
            formData.surveyTemp.b9_6 = formData.b9_6 ? "0" : "";
            formData.surveyTemp.b10_1 = formData.b10_1 ? "0" : "";
            formData.surveyTemp.b10_2 = formData.b10_2 ? "0" : "";
            formData.surveyTemp.b10_3 = formData.b10_3 ? "0" : "";
            formData.surveyTemp.b10_4 = formData.b10_4 ? "0" : "";
            formData.surveyTemp.b10_5 = formData.b10_5 ? "0" : "";
            formData.surveyTemp.b10_6 = formData.b10_6 ? "0" : "";
            formData.surveyTemp.b10_7 = formData.b10_7 ? "0" : "";
            string hc = configSurvey.HC_noId(HC);
            formData.surveyTemp.HC = hc;
            formData.surveyTemp.survey_year = configSurvey.survey_year;
            formData.surveyTemp.survey_no = configSurvey.survey_no_num;
            
            await DBContext.UpdateItems<survey_b2>("survey_b2", new List<survey_b2>() {
                formData.surveyTemp
             });
            complete = "เรียบร้อย";
        }


        private async Task gotoPage(string HC_nextPage)
        {
            NavigationManager.NavigateTo("/surveyb3/" + HC_nextPage);
        }
    }
}








/*

$query="update survey_b2 set b9_1='$b9_1',b9_2='$b9_2',b9_3='$b9_3',b9_4='$b9_4',b9_5='$b9_5',b9_6='$b9_6',b9_6_1='$b9_6_1',b10='$b10',b10_1='$b10_1',b10_2='$b10_2',b10_3='$b10_3',b10_4='$b10_4',b10_5='$b10_5',b10_6='$b10_6',b10_7='$b10_7',b10_7_1='$b10_7_1' where HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
//echo$query."<br>";
$mysqli->query($query);

$username=$_COOKIE[username_log];
$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 2 3/4')";
$result_log=$mysqli->query($log);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveyb4'
</script>*/
