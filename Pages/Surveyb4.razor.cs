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
$b11_1=$_POST[b11_1];
$b11_1_1=$_POST[b11_1_1];
$b11_2=$_POST[b11_2];
$b11_2_1=$_POST[b11_2_1];
$b12_1=$_POST[b12_1];
$b12_2=$_POST[b12_2];
$b12_3=$_POST[b12_3];
$b12_4=$_POST[b12_4];
$b12_5=$_POST[b12_5];
$b12_6=$_POST[b12_6];
$b12_7=$_POST[b12_7];
$b12_8=$_POST[b12_8];
$b12_9=$_POST[b12_9];
$b12_10=$_POST[b12_10];
$b12_11=$_POST[b12_11];
$b12_12=$_POST[b12_12];
$b12_12_1=$_POST[b12_12_1];
$b13_1=$_POST[b13_1];
$b13_2=$_POST[b13_2];
$b13_3=$_POST[b13_3];
$b13_4=$_POST[b13_4];
$b13_5=$_POST[b13_5];
$b13_6=$_POST[b13_6];
$b13_7=$_POST[b13_7];
$b13_8=$_POST[b13_8];
$b13_9=$_POST[b13_9];
$b13_10=$_POST[b13_10];
$b13_11=$_POST[b13_11];
$b13_12=$_POST[b13_12];
$b13_12_1=$_POST[b13_12_1];
$b14=$_POST[b14];
$b15=$_POST[b15];

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
    public partial class Surveyb4 : ComponentBase
    {

        [Parameter]
        public string HC { get; set; }
string complete = "";
        chksurveyb2 formData = new chksurveyb2();
        class chksurveyb2
        {
            public bool b12_1 { get; set; }
            public bool b12_2 { get; set; }
            public bool b12_3 { get; set; }
            public bool b12_4 { get; set; }
            public bool b12_5 { get; set; }
            public bool b12_6 { get; set; }
            public bool b12_7 { get; set; }
            public bool b12_8 { get; set; }
            public bool b12_9 { get; set; }
            public bool b12_10 { get; set; }
            public bool b12_11 { get; set; }
            public bool b12_12 { get; set; }
            public bool b13_1 { get; set; }
            public bool b13_2 { get; set; }
            public bool b13_3 { get; set; }
            public bool b13_4 { get; set; }
            public bool b13_5 { get; set; }
            public bool b13_6 { get; set; }
            public bool b13_7 { get; set; }
            public bool b13_8 { get; set; }
            public bool b13_9 { get; set; }
            public bool b13_10 { get; set; }
            public bool b13_11 { get; set; }
            public bool b13_12 { get; set; }
            public survey_b3 surveyTemp = new survey_b3();

        }

        protected override async Task OnInitializedAsync()
        {
            await DBContext.OpenIndexedDb();
            string hc = configSurvey.HC_noId(HC);
            List<survey_b3> getAllSurPro = await DBContext.GetByIndex<string, survey_b3>("survey_b3", hc, null, "hc", false);

            if (getAllSurPro.Count() > 0)
            {

                formData.surveyTemp = getAllSurPro.FirstOrDefault();
            }

            formData.b12_1 = String.IsNullOrEmpty(formData.surveyTemp.b12_1) ? false : true;
            formData.b12_2 = String.IsNullOrEmpty(formData.surveyTemp.b12_2) ? false : true;
            formData.b12_3 = String.IsNullOrEmpty(formData.surveyTemp.b12_3) ? false : true;
            formData.b12_4 = String.IsNullOrEmpty(formData.surveyTemp.b12_4) ? false : true;
            formData.b12_5 = String.IsNullOrEmpty(formData.surveyTemp.b12_5) ? false : true;
            formData.b12_6 = String.IsNullOrEmpty(formData.surveyTemp.b12_6) ? false : true;
            formData.b12_7 = String.IsNullOrEmpty(formData.surveyTemp.b12_7) ? false : true;
            formData.b12_8 = String.IsNullOrEmpty(formData.surveyTemp.b12_8) ? false : true;
            formData.b12_9 = String.IsNullOrEmpty(formData.surveyTemp.b12_9) ? false : true;
            formData.b12_10 = String.IsNullOrEmpty(formData.surveyTemp.b12_10) ? false : true;
            formData.b12_11 = String.IsNullOrEmpty(formData.surveyTemp.b12_11) ? false : true;
            formData.b12_12 = String.IsNullOrEmpty(formData.surveyTemp.b12_12) ? false : true;
            formData.b13_1 = String.IsNullOrEmpty(formData.surveyTemp.b13_1) ? false : true;
            formData.b13_2 = String.IsNullOrEmpty(formData.surveyTemp.b13_2) ? false : true;
            formData.b13_3 = String.IsNullOrEmpty(formData.surveyTemp.b13_3) ? false : true;
            formData.b13_4 = String.IsNullOrEmpty(formData.surveyTemp.b13_4) ? false : true;
            formData.b13_5 = String.IsNullOrEmpty(formData.surveyTemp.b13_5) ? false : true;
            formData.b13_6 = String.IsNullOrEmpty(formData.surveyTemp.b13_6) ? false : true;
            formData.b13_7 = String.IsNullOrEmpty(formData.surveyTemp.b13_7) ? false : true;
            formData.b13_8 = String.IsNullOrEmpty(formData.surveyTemp.b13_8) ? false : true;
            formData.b13_9 = String.IsNullOrEmpty(formData.surveyTemp.b13_9) ? false : true;
            formData.b13_10 = String.IsNullOrEmpty(formData.surveyTemp.b13_10) ? false : true;
            formData.b13_11 = String.IsNullOrEmpty(formData.surveyTemp.b13_11) ? false : true;
            formData.b13_12 = String.IsNullOrEmpty(formData.surveyTemp.b13_12) ? false : true;

        }
        protected async Task HandleValidSubmit(EditContext context)
        {
            int index = 0;
            //$query="update survey_a1 set a7_0='$a7_0[$i]',a7_1='$a7_1[$i]',a7_1_1='$a7_1_1[$i]',a7_1_2='$a7_1_2[$i]',a7_2='$a7_2[$i]',a7_2_1='$a7_2_1[$i]',a7_2_2='$a7_2_2[$i]',a7_3='$a7_3[$i]',a7_3_1='$a7_3_1[$i]',a7_3_2='$a7_3_2[$i]',a7_4='$a7_4[$i]',a7_4_1='$a7_4_1[$i]',a7_4_2='$a7_4_2[$i]',a7_5='$a7_5[$i]',a7_5_1='$a7_5_1[$i]',a7_5_2='$a7_5_2[$i]',a7_6='$a7_6[$i]',a7_6_1='$a7_6_1[$i]',a7_6_2='$a7_6_2[$i]',a7_7='$a7_7[$i]',a7_7_1='$a7_7_1[$i]',a7_7_2='$a7_7_2[$i]',a7_8='$a7_8[$i]',a7_8_1='$a7_8_1[$i]',a7_8_2='$a7_8_2[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";

            formData.surveyTemp.b12_1 = formData.b12_1 ? "1" : "";
            formData.surveyTemp.b12_2 = formData.b12_2 ? "2" : "";
            formData.surveyTemp.b12_3 = formData.b12_3 ? "3" : "";
            formData.surveyTemp.b12_4 = formData.b12_4 ? "4" : "";
            formData.surveyTemp.b12_5 = formData.b12_5 ? "5" : "";
            formData.surveyTemp.b12_6 = formData.b12_6 ? "6" : "";
            formData.surveyTemp.b12_7 = formData.b12_7 ? "7" : "";
            formData.surveyTemp.b12_8 = formData.b12_8 ? "8" : "";
            formData.surveyTemp.b12_9 = formData.b12_9 ? "9" : "";
            formData.surveyTemp.b12_10 = formData.b12_10 ? "10" : "";
            formData.surveyTemp.b12_11 = formData.b12_11 ? "11" : "";
            formData.surveyTemp.b12_12 = formData.b12_12 ? "12" : "";
            formData.surveyTemp.b13_1 = formData.b13_1 ? "1" : "";
            formData.surveyTemp.b13_2 = formData.b13_2 ? "2" : "";
            formData.surveyTemp.b13_3 = formData.b13_3 ? "3" : "";
            formData.surveyTemp.b13_4 = formData.b13_4 ? "4" : "";
            formData.surveyTemp.b13_5 = formData.b13_5 ? "5" : "";
            formData.surveyTemp.b13_6 = formData.b13_6 ? "6" : "";
            formData.surveyTemp.b13_7 = formData.b13_7 ? "7" : "";
            formData.surveyTemp.b13_8 = formData.b13_8 ? "8" : "";
            formData.surveyTemp.b13_9 = formData.b13_9 ? "9" : "";
            formData.surveyTemp.b13_10 = formData.b13_10 ? "10" : "";
            formData.surveyTemp.b13_11 = formData.b13_11 ? "11" : "";
            formData.surveyTemp.b13_12 = formData.b13_12 ? "12" : "";
            string hc = configSurvey.HC_noId(HC);
            formData.surveyTemp.HC = hc;
            formData.surveyTemp.survey_year = configSurvey.survey_year;
            formData.surveyTemp.survey_no = configSurvey.survey_no_num;
            //List<survey_b2> getAllSurPro = await DBContext.GetByIndex<string, survey_b2>("survey_b2", hc, null, "hc", false);
            //if(getAllSurPro.Count() > 0)
            //{
            await DBContext.UpdateItems<survey_b3>("survey_b3", new List<survey_b3>() {
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
                    firstStaff.ch2_sp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

                    await DBContext.UpdateItems<survey_staff>("survey_staff", new List<survey_staff>() { firstStaff });
                }
            }
            complete = "เรียบร้อย";
        }


        private async Task gotoPage(string HC_nextPage)
        {
            NavigationManager.NavigateTo("/surveyc1/" + HC_nextPage);
        }
    }
}



/*

$query="select HC from survey_b3 where HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$result=$mysqli->query($query);
$row=$result->fetch_object();

$query1="insert into survey_b3 (HC,survey_year,survey_no,b11_1,b11_1_1,b11_2,b11_2_1,b12_1,b12_2,b12_3,b12_4,b12_5,b12_6,b12_7,b12_8,b12_9,b12_10,b12_11,b12_12,b12_12_1,b13_1,b13_2,b13_3,b13_4,b13_5,b13_6,b13_7,b13_8,b13_9,b13_10,b13_11,b13_12,b14,b15,b13_12_1) values('$HC','$survey_year','$survey_no','$b11_1','$b11_1_1','$b11_2','$b11_2_1','$b12_1','$b12_2','$b12_3','$b12_4','$b12_5','$b12_6','$b12_7','$b12_8','$b12_9','$b12_10','$b12_11','$b12_12','$b12_12_1','$b13_1','$b13_2','$b13_3','$b13_4','$b13_5','$b13_6','$b13_7','$b13_8','$b13_9','$b13_10','$b13_11','$b13_12','$b14','$b15','$b13_12_1');";
$mysqli->query($query1);

$query1="update survey_b3 set b11_1='$b11_1',b11_1_1='$b11_1_1',b11_2='$b11_2',b11_2_1='$b11_2_1',b12_1='$b12_1',b12_2='$b12_2',b12_3='$b12_3',b12_4='$b12_4',b12_5='$b12_5',b12_6='$b12_6',b12_7='$b12_7',b12_8='$b12_8',b12_9='$b12_9',b12_10='$b12_10',b12_11='$b12_11',b12_12='$b12_12',b12_12_1='$b12_12_1',b13_1='$b13_1',b13_2='$b13_2',b13_3='$b13_3',b13_4='$b13_4',b13_5='$b13_5',b13_6='$b13_6',b13_7='$b13_7',b13_8='$b13_8',b13_9='$b13_9',b13_10='$b13_10',b13_11='$b13_11',b13_12='$b13_12',b14='$b14',b15='$b15',b13_12_1='$b13_12_1' where HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$mysqli->query($query1);

//echo$query1."<br>";


$query_up1="update survey_staff set ch2_sp='".date("U")."' where  HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$result_up1=$mysqli->query($query_up1);

$username=$_COOKIE[username_log];
$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 2 4/4')";
$result_log=$mysqli->query($log);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveyc1'
</script>*/
