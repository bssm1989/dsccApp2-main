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
$c1_1_0=$_POST[c1_1_0];
$c1_1_1=$_POST[c1_1_1];
$c1_1_1_1=$_POST[c1_1_1_1];
$c1_1_1_2=$_POST[c1_1_1_2];
$c1_1_2=$_POST[c1_1_2];
$c1_1_2_1=$_POST[c1_1_2_1];
$c1_1_2_2=$_POST[c1_1_2_2];
$c1_1_3=$_POST[c1_1_3];
$c1_1_3_1=$_POST[c1_1_3_1];
$c1_1_3_2=$_POST[c1_1_3_2];
$c1_1_4=$_POST[c1_1_4];
$c1_1_4_1=$_POST[c1_1_4_1];
$c1_1_4_2=$_POST[c1_1_4_2];
$c1_2_0=$_POST[c1_2_0];
$c1_2_1=$_POST[c1_2_1];
$c1_2_1_1=$_POST[c1_2_1_1];
$c1_2_1_2=$_POST[c1_2_1_2];
$c1_2_2=$_POST[c1_2_2];
$c1_2_2_1=$_POST[c1_2_2_1];
$c1_2_2_2=$_POST[c1_2_2_2];
$c1_2_3=$_POST[c1_2_3];
$c1_2_3_1=$_POST[c1_2_3_1];
$c1_2_3_2=$_POST[c1_2_3_2];
$c1_3_0=$_POST[c1_3_0];
$c1_3_1=$_POST[c1_3_1];
$c1_3_1_1=$_POST[c1_3_1_1];
$c1_3_1_2=$_POST[c1_3_1_2];
$c1_3_2=$_POST[c1_3_2];
$c1_3_2_1=$_POST[c1_3_2_1];
$c1_3_2_2=$_POST[c1_3_2_2];
$c2=$_POST[c2];
$c3_1=$_POST[c3_1];
$c3_1_1=$_POST[c3_1_1];
$c3_1_2=$_POST[c3_1_2];
$c3_1_3=$_POST[c3_1_3];
$c3_2=$_POST[c3_2];
$c3_2_1=$_POST[c3_2_1];
$c3_3=$_POST[c3_3];
$c3_3_1=$_POST[c3_3_1];
$c3_4=$_POST[c3_4];
$c3_4_1=$_POST[c3_4_1];
$c3_5=$_POST[c3_5];
$c3_5_1=$_POST[c3_5_1];
$c3_6=$_POST[c3_6];
$c3_6_1=$_POST[c3_6_1];
$c3_7=$_POST[c3_7];
$c3_7_1=$_POST[c3_7_1];
$c3_8=$_POST[c3_8];
$c3_8_1=$_POST[c3_8_1];
$c3_9=$_POST[c3_9];
$c3_9_1=$_POST[c3_9_1];
$c3_10=$_POST[c3_10];
$c3_10_1=$_POST[c3_10_1];
$c3_10_2=$_POST[c3_10_2];
$c4=$_POST[c4];
$c4_1=$_POST[c4_1];
$c4_1_1=$_POST[c4_1_1];
$c4_2=$_POST[c4_2];
$c4_2_1=$_POST[c4_2_1];
$c4_3=$_POST[c4_3];
$c4_3_1=$_POST[c4_3_1];
$c4_4=$_POST[c4_4];
$c4_4_1=$_POST[c4_4_1];
$c4_5=$_POST[c4_5];
$c4_5_1=$_POST[c4_5_1];
$c4_6=$_POST[c4_6];
$c4_6_1=$_POST[c4_6_1];
$c4_6_2=$_POST[c4_6_2];

if(!$_SESSION["HC"]){
?>
<script>
location='https://livingonnewpace.com/survey/index.php?curr=survey_profile';
</script>*/
/*<?php
	exit();
}

*/

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
    public partial class Surveyc1 : ComponentBase
    {

        [Parameter]
        public string HC { get; set; }
string complete = "";
        chksurveyb2 formData = new chksurveyb2();
        class chksurveyb2
        {
            public bool c1_1_0 { get; set; }
            public bool c1_1_1 { get; set; }
            public bool c1_1_2 { get; set; }
            public bool c1_1_3 { get; set; }
            public bool c1_1_4 { get; set; }
            public bool c1_2_0 { get; set; }
            public bool c1_2_1 { get; set; }
            public bool c1_2_2 { get; set; }
            public bool c1_2_3 { get; set; }
            public bool c1_3_0 { get; set; }
            public bool c1_3_1 { get; set; }
            public bool c1_3_2 { get; set; }
            public bool c3_1 { get; set; }
            public bool c3_2 { get; set; }
            public bool c3_3 { get; set; }
            public bool c3_4 { get; set; }
            public bool c3_5 { get; set; }
            public bool c3_6 { get; set; }
            public bool c3_7 { get; set; }
            public bool c3_8 { get; set; }
            public bool c3_9 { get; set; }
            public bool c3_10 { get; set; }
            public bool c4_1 { get; set; }
            public bool c4_2 { get; set; }
            public bool c4_3 { get; set; }
            public bool c4_4 { get; set; }
            public bool c4_5 { get; set; }
            public bool c4_6 { get; set; }
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

            formData.c1_1_0 = String.IsNullOrEmpty(formData.surveyTemp.c1_1_0) ? false : true;
            formData.c1_1_1 = String.IsNullOrEmpty(formData.surveyTemp.c1_1_1) ? false : true;
            formData.c1_1_2 = String.IsNullOrEmpty(formData.surveyTemp.c1_1_2) ? false : true;
            formData.c1_1_3 = String.IsNullOrEmpty(formData.surveyTemp.c1_1_3) ? false : true;
            formData.c1_1_4 = String.IsNullOrEmpty(formData.surveyTemp.c1_1_4) ? false : true;
            formData.c1_2_0 = String.IsNullOrEmpty(formData.surveyTemp.c1_2_0) ? false : true;
            formData.c1_2_1 = String.IsNullOrEmpty(formData.surveyTemp.c1_2_1) ? false : true;
            formData.c1_2_2 = String.IsNullOrEmpty(formData.surveyTemp.c1_2_2) ? false : true;
            formData.c1_2_3 = String.IsNullOrEmpty(formData.surveyTemp.c1_2_3) ? false : true;
            formData.c1_3_0 = String.IsNullOrEmpty(formData.surveyTemp.c1_3_0) ? false : true;
            formData.c1_3_1 = String.IsNullOrEmpty(formData.surveyTemp.c1_3_1) ? false : true;
            formData.c1_3_2 = String.IsNullOrEmpty(formData.surveyTemp.c1_3_2) ? false : true;
            formData.c3_1 = String.IsNullOrEmpty(formData.surveyTemp.c3_1) ? false : true;
            formData.c3_2 = String.IsNullOrEmpty(formData.surveyTemp.c3_2) ? false : true;
            formData.c3_3 = String.IsNullOrEmpty(formData.surveyTemp.c3_3) ? false : true;
            formData.c3_4 = String.IsNullOrEmpty(formData.surveyTemp.c3_4) ? false : true;
            formData.c3_5 = String.IsNullOrEmpty(formData.surveyTemp.c3_5) ? false : true;
            formData.c3_6 = String.IsNullOrEmpty(formData.surveyTemp.c3_6) ? false : true;
            formData.c3_7 = String.IsNullOrEmpty(formData.surveyTemp.c3_7) ? false : true;
            formData.c3_8 = String.IsNullOrEmpty(formData.surveyTemp.c3_8) ? false : true;
            formData.c3_9 = String.IsNullOrEmpty(formData.surveyTemp.c3_9) ? false : true;
            formData.c3_10 = String.IsNullOrEmpty(formData.surveyTemp.c3_10) ? false : true;
            formData.c4_1 = String.IsNullOrEmpty(formData.surveyTemp.c4_1) ? false : true;
            formData.c4_2 = String.IsNullOrEmpty(formData.surveyTemp.c4_2) ? false : true;
            formData.c4_3 = String.IsNullOrEmpty(formData.surveyTemp.c4_3) ? false : true;
            formData.c4_4 = String.IsNullOrEmpty(formData.surveyTemp.c4_4) ? false : true;
            formData.c4_5 = String.IsNullOrEmpty(formData.surveyTemp.c4_5) ? false : true;
            formData.c4_6 = String.IsNullOrEmpty(formData.surveyTemp.c4_6) ? false : true;
            var getallSurveyStaff = await DBContext.GetAll<survey_staff>("survey_staff");
            string hc_id = getallSurveyStaff.Where(x => x.HC.Contains(HC)).FirstOrDefault().HC;
            if (hc_id != null)
            {
                var updateStaff = await DBContext.GetByIndex<string, survey_staff>("survey_staff", hc_id, "", "hc", false);
                var firstStaff = updateStaff.FirstOrDefault();
                if (firstStaff != null)
                {
                    firstStaff.ch3_st = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

                    await DBContext.UpdateItems<survey_staff>("survey_staff", new List<survey_staff>() { firstStaff });
                }
            }
        }
        protected async Task HandleValidSubmit(EditContext context)
        {
            int index = 0;
            //$query="update survey_a1 set a7_0='$a7_0[$i]',a7_1='$a7_1[$i]',a7_1_1='$a7_1_1[$i]',a7_1_2='$a7_1_2[$i]',a7_2='$a7_2[$i]',a7_2_1='$a7_2_1[$i]',a7_2_2='$a7_2_2[$i]',a7_3='$a7_3[$i]',a7_3_1='$a7_3_1[$i]',a7_3_2='$a7_3_2[$i]',a7_4='$a7_4[$i]',a7_4_1='$a7_4_1[$i]',a7_4_2='$a7_4_2[$i]',a7_5='$a7_5[$i]',a7_5_1='$a7_5_1[$i]',a7_5_2='$a7_5_2[$i]',a7_6='$a7_6[$i]',a7_6_1='$a7_6_1[$i]',a7_6_2='$a7_6_2[$i]',a7_7='$a7_7[$i]',a7_7_1='$a7_7_1[$i]',a7_7_2='$a7_7_2[$i]',a7_8='$a7_8[$i]',a7_8_1='$a7_8_1[$i]',a7_8_2='$a7_8_2[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";

            formData.surveyTemp.c1_1_0 = formData.c1_1_0 ? "0" : "";
            formData.surveyTemp.c1_1_1 = formData.c1_1_1 ? "0" : "";
            formData.surveyTemp.c1_1_2 = formData.c1_1_2 ? "0" : "";
            formData.surveyTemp.c1_1_3 = formData.c1_1_3 ? "0" : "";
            formData.surveyTemp.c1_1_4 = formData.c1_1_4 ? "0" : "";
            formData.surveyTemp.c1_2_0 = formData.c1_2_0 ? "0" : "";
            formData.surveyTemp.c1_2_1 = formData.c1_2_1 ? "0" : "";
            formData.surveyTemp.c1_2_2 = formData.c1_2_2 ? "0" : "";
            formData.surveyTemp.c1_2_3 = formData.c1_2_3 ? "0" : "";
            formData.surveyTemp.c1_3_0 = formData.c1_3_0 ? "0" : "";
            formData.surveyTemp.c1_3_1 = formData.c1_3_1 ? "0" : "";
            formData.surveyTemp.c1_3_2 = formData.c1_3_2 ? "0" : "";
            formData.surveyTemp.c3_1 = formData.c3_1 ? "0" : "";
            formData.surveyTemp.c3_2 = formData.c3_2 ? "0" : "";
            formData.surveyTemp.c3_3 = formData.c3_3 ? "0" : "";
            formData.surveyTemp.c3_4 = formData.c3_4 ? "0" : "";
            formData.surveyTemp.c3_5 = formData.c3_5 ? "0" : "";
            formData.surveyTemp.c3_6 = formData.c3_6 ? "0" : "";
            formData.surveyTemp.c3_7 = formData.c3_7 ? "0" : "";
            formData.surveyTemp.c3_8 = formData.c3_8 ? "0" : "";
            formData.surveyTemp.c3_9 = formData.c3_9 ? "0" : "";
            formData.surveyTemp.c3_10 = formData.c3_10 ? "0" : "";
            formData.surveyTemp.c4_1 = formData.c4_1 ? "0" : "";
            formData.surveyTemp.c4_2 = formData.c4_2 ? "0" : "";
            formData.surveyTemp.c4_3 = formData.c4_3 ? "0" : "";
            formData.surveyTemp.c4_4 = formData.c4_4 ? "0" : "";
            formData.surveyTemp.c4_5 = formData.c4_5 ? "0" : "";
            formData.surveyTemp.c4_6 = formData.c4_6 ? "0" : "";
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
            complete = "เรียบร้อย";
        }


        private async Task gotoPage(string HC_nextPage)
        {
            NavigationManager.NavigateTo("/surveyc2/" + HC_nextPage);
        }
    }
}



/*

$query="select HC from survey_c1 where HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$result=$mysqli->query($query);
$row=$result->fetch_object();

$query1="insert into survey_c1 (HC,survey_year,survey_no,b11_1,b11_1_1,b11_2,b11_2_1,b12_1,b12_2,b12_3,b12_4,b12_5,b12_6,b12_7,b12_8,b12_9,b12_10,b12_11,b12_12,b12_12_1,b13_1,b13_2,b13_3,b13_4,b13_5,b13_6,b13_7,b13_8,b13_9,b13_10,b13_11,b13_12,b14,b15,b13_12_1) values('$HC','$survey_year','$survey_no','$b11_1','$b11_1_1','$b11_2','$b11_2_1','$b12_1','$b12_2','$b12_3','$b12_4','$b12_5','$b12_6','$b12_7','$b12_8','$b12_9','$b12_10','$b12_11','$b12_12','$b12_12_1','$b13_1','$b13_2','$b13_3','$b13_4','$b13_5','$b13_6','$b13_7','$b13_8','$b13_9','$b13_10','$b13_11','$b13_12','$b14','$b15','$b13_12_1');";
$mysqli->query($query1);

$query1="update survey_c1 set b11_1='$b11_1',b11_1_1='$b11_1_1',b11_2='$b11_2',b11_2_1='$b11_2_1',b12_1='$b12_1',b12_2='$b12_2',b12_3='$b12_3',b12_4='$b12_4',b12_5='$b12_5',b12_6='$b12_6',b12_7='$b12_7',b12_8='$b12_8',b12_9='$b12_9',b12_10='$b12_10',b12_11='$b12_11',b12_12='$b12_12',b12_12_1='$b12_12_1',b13_1='$b13_1',b13_2='$b13_2',b13_3='$b13_3',b13_4='$b13_4',b13_5='$b13_5',b13_6='$b13_6',b13_7='$b13_7',b13_8='$b13_8',b13_9='$b13_9',b13_10='$b13_10',b13_11='$b13_11',b13_12='$b13_12',b14='$b14',b15='$b15',b13_12_1='$b13_12_1' where HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
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


/*
$query="select HC from survey_c1 where HC='$HC'";
$result=$mysqli->query($query);
$row=$result->fetch_object();

$query1="insert into survey_c1 (HC,survey_year,survey_no,c1_1_0,c1_1_1,c1_1_1_1,c1_1_1_2,c1_1_2,c1_1_2_1,c1_1_2_2,c1_1_3,c1_1_3_1,c1_1_3_2,c1_1_4,c1_1_4_1,c1_1_4_2,c1_2_0,c1_2_1,c1_2_1_1,c1_2_1_2,c1_2_2,c1_2_2_1,c1_2_2_2,c1_2_3,c1_2_3_1,c1_2_3_2,c1_3_0,c1_3_1,c1_3_1_1,c1_3_1_2,c1_3_2,c1_3_2_1,c1_3_2_2,c2
,c3_1
,c3_1_1
,c3_1_2
,c3_1_3
,c3_2,c3_2_1,c3_3,c3_3_1,c3_4,c3_4_1,c3_5,c3_5_1,c3_6,c3_6_1,c3_7,c3_7_1,c3_8,c3_8_1,c3_9,c3_9_1,c3_10,c3_10_1,c3_10_2,c4,c4_1,c4_1_1,c4_2,c4_2_1,c4_3,c4_3_1,c4_4,c4_4_1,c4_5,c4_5_1,c4_6,c4_6_1,c4_6_2) values('$HC','$survey_year','$survey_no',	'$c1_1_0','$c1_1_1','$c1_1_1_1','$c1_1_1_2','$c1_1_2','$c1_1_2_1','$c1_1_2_2','$c1_1_3','$c1_1_3_1','$c1_1_3_2','$c1_1_4','$c1_1_4_1','$c1_1_4_2','$c1_2_0','$c1_2_1','$c1_2_1_1','$c1_2_1_2','$c1_2_2','$c1_2_2_1','$c1_2_2_2','$c1_2_3','$c1_2_3_1','$c1_2_3_2','$c1_3_0','$c1_3_1','$c1_3_1_1','$c1_3_1_2','$c1_3_2','$c1_3_2_1','$c1_3_2_2','$c2'

,'$c3_1'
,'$c3_1_1'
,'$c3_1_2'
,'$c3_1_3'


,'$c3_2','$c3_2_1','$c3_3','$c3_3_1','$c3_4','$c3_4_1','$c3_5','$c3_5_1','$c3_6','$c3_6_1','$c3_7','$c3_7_1','$c3_8','$c3_8_1','$c3_9','$c3_9_1','$c3_10','$c3_10_1','$c3_10_2','$c4','$c4_1','$c4_1_1','$c4_2','$c4_2_1','$c4_3','$c4_3_1','$c4_4','$c4_4_1','$c4_5','$c4_5_1','$c4_6','$c4_6_1','$c4_6_2');";
$mysqli->query($query1);

$query1="update survey_c1 set c1_1_0='$c1_1_0',c1_1_1='$c1_1_1',c1_1_1_1='$c1_1_1_1',c1_1_1_2='$c1_1_1_2',c1_1_2='$c1_1_2',c1_1_2_1='$c1_1_2_1',c1_1_2_2='$c1_1_2_2',c1_1_3='$c1_1_3',c1_1_3_1='$c1_1_3_1',c1_1_3_2='$c1_1_3_2',c1_1_4='$c1_1_4',c1_1_4_1='$c1_1_4_1',c1_1_4_2='$c1_1_4_2',c1_2_0='$c1_2_0',c1_2_1='$c1_2_1',c1_2_1_1='$c1_2_1_1',c1_2_1_2='$c1_2_1_2',c1_2_2='$c1_2_2',c1_2_2_1='$c1_2_2_1',c1_2_2_2='$c1_2_2_2',c1_2_3='$c1_2_3',c1_2_3_1='$c1_2_3_1',c1_2_3_2='$c1_2_3_2',c1_3_0='$c1_3_0',c1_3_1='$c1_3_1',c1_3_1_1='$c1_3_1_1',c1_3_1_2='$c1_3_1_2',c1_3_2='$c1_3_2',c1_3_2_1='$c1_3_2_1',c1_3_2_2='$c1_3_2_2',c2='$c2'
,c3_1='$c3_1'
,c3_1_1='$c3_1_1'
,c3_1_2='$c3_1_2'
,c3_1_3='$c3_1_3'

,c3_2='$c3_2',c3_2_1='$c3_2_1',c3_3='$c3_3',c3_3_1='$c3_3_1',c3_4='$c3_4',c3_4_1='$c3_4_1',c3_5='$c3_5',c3_5_1='$c3_5_1',c3_6='$c3_6',c3_6_1='$c3_6_1',c3_7='$c3_7',c3_7_1='$c3_7_1',c3_8='$c3_8',c3_8_1='$c3_8_1',c3_9='$c3_9',c3_9_1='$c3_9_1',c3_10='$c3_10',c3_10_1='$c3_10_1',c3_10_2='$c3_10_2',c4='$c4',c4_1='$c4_1',c4_1_1='$c4_1_1',c4_2='$c4_2',c4_2_1='$c4_2_1',c4_3='$c4_3',c4_3_1='$c4_3_1',c4_4='$c4_4',c4_4_1='$c4_4_1',c4_5='$c4_5',c4_5_1='$c4_5_1',c4_6='$c4_6',c4_6_1='$c4_6_1',c4_6_2='$c4_6_2' where HC='$HC'  and survey_year='$survey_year' and survey_no='$survey_no'";
$mysqli->query($query1);


//echo$query1."<br>";
//$mysqli->query($query1);
$username=$_COOKIE[username_log];
$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 3 1/3')";
$result_log=$mysqli->query($log);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveyc2'
</script>*/