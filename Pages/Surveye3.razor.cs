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
$e3=$_POST[e3];
$e4=$_POST[e4];
$e5=$_POST[e5];
$e6=$_POST[e6];
$e7_1=$_POST[e7_1];
$e7_2=$_POST[e7_2];
$e7_3=$_POST[e7_3];
$e7_4=$_POST[e7_4];
$e7_5=$_POST[e7_5];
$e7_6=$_POST[e7_6];
$e7_7=$_POST[e7_7];
$e7_8=$_POST[e7_8];
$e7_9=$_POST[e7_9];
$e7_10=$_POST[e7_10];
$e7_11=$_POST[e7_11];
$e7_11_1=$_POST[e7_11_1];
$e8=$_POST[e8];
$e8_1_1=$_POST[e8_1_1];
$e8_1_2=$_POST[e8_1_2];
$e8_1_3=$_POST[e8_1_3];
$e8_1_4=$_POST[e8_1_4];
$e8_1_4_1=$_POST[e8_1_4_1];
$e8_2_1=$_POST[e8_2_1];
$e8_2_2=$_POST[e8_2_2];
$e8_2_3=$_POST[e8_2_3];
$e8_2_4=$_POST[e8_2_4];
$e8_2_5=$_POST[e8_2_5];
$e8_2_6=$_POST[e8_2_6];
$e8_2_7=$_POST[e8_2_7];
$e8_2_8=$_POST[e8_2_8];
$e8_2_9=$_POST[e8_2_9];
$e8_2_10=$_POST[e8_2_10];
$e8_2_11=$_POST[e8_2_11];
$e8_2_11_1=$_POST[e8_2_11_1];
$e9_1=$_POST[e9_1];
$e9_2=$_POST[e9_2];
$e9_3=$_POST[e9_3];
$e9_4=$_POST[e9_4];
$e10_1=$_POST[e10_1];
$e10_2=$_POST[e10_2];
$e10_3=$_POST[e10_3];
$e10_4=$_POST[e10_4];

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
    public partial class Surveye3 : ComponentBase
    {

        [Parameter]
        public string HC { get; set; }
string complete = "";
        chksurveyb2 formData = new chksurveyb2();
        class chksurveyb2
        {
            public bool e7_1 { get; set; }
            public bool e7_2 { get; set; }
            public bool e7_3 { get; set; }
            public bool e7_4 { get; set; }
            public bool e7_5 { get; set; }
            public bool e7_6 { get; set; }
            public bool e7_7 { get; set; }
            public bool e7_8 { get; set; }
            public bool e7_9 { get; set; }
            public bool e7_10 { get; set; }
            public bool e7_11 { get; set; }
            public bool e8_1_1 { get; set; }
            public bool e8_1_2 { get; set; }
            public bool e8_1_3 { get; set; }
            public bool e8_1_4 { get; set; }
            public bool e8_2_1 { get; set; }
            public bool e8_2_2 { get; set; }
            public bool e8_2_3 { get; set; }
            public bool e8_2_4 { get; set; }
            public bool e8_2_5 { get; set; }
            public bool e8_2_6 { get; set; }
            public bool e8_2_7 { get; set; }
            public bool e8_2_8 { get; set; }
            public bool e8_2_9 { get; set; }
            public bool e8_2_10 { get; set; }
            public bool e8_2_11 { get; set; }
            public bool e9_1 { get; set; }
            public bool e9_2 { get; set; }
            public bool e9_3 { get; set; }
            public bool e9_4 { get; set; }
            public bool e10_1 { get; set; }
            public bool e10_2 { get; set; }
            public bool e10_3 { get; set; }
            public bool e10_4 { get; set; }
            public survey_e3 surveyTemp = new survey_e3();

        }

        protected override async Task OnInitializedAsync()
        {
            await DBContext.OpenIndexedDb();
            string hc = configSurvey.HC_noId(HC);
            List<survey_e3> getAllSurPro = await DBContext.GetByIndex<string, survey_e3>("survey_e3", hc, null, "hc", false);

            if (getAllSurPro.Count() > 0)
            {

                formData.surveyTemp = getAllSurPro.FirstOrDefault();
            }

            formData.e7_1 = String.IsNullOrEmpty(formData.surveyTemp.e7_1) ? false : true;
            formData.e7_2 = String.IsNullOrEmpty(formData.surveyTemp.e7_2) ? false : true;
            formData.e7_3 = String.IsNullOrEmpty(formData.surveyTemp.e7_3) ? false : true;
            formData.e7_4 = String.IsNullOrEmpty(formData.surveyTemp.e7_4) ? false : true;
            formData.e7_5 = String.IsNullOrEmpty(formData.surveyTemp.e7_5) ? false : true;
            formData.e7_6 = String.IsNullOrEmpty(formData.surveyTemp.e7_6) ? false : true;
            formData.e7_7 = String.IsNullOrEmpty(formData.surveyTemp.e7_7) ? false : true;
            formData.e7_8 = String.IsNullOrEmpty(formData.surveyTemp.e7_8) ? false : true;
            formData.e7_9 = String.IsNullOrEmpty(formData.surveyTemp.e7_9) ? false : true;
            formData.e7_10 = String.IsNullOrEmpty(formData.surveyTemp.e7_10) ? false : true;
            formData.e7_11 = String.IsNullOrEmpty(formData.surveyTemp.e7_11) ? false : true;
            formData.e8_1_1 = String.IsNullOrEmpty(formData.surveyTemp.e8_1_1) ? false : true;
            formData.e8_1_2 = String.IsNullOrEmpty(formData.surveyTemp.e8_1_2) ? false : true;
            formData.e8_1_3 = String.IsNullOrEmpty(formData.surveyTemp.e8_1_3) ? false : true;
            formData.e8_1_4 = String.IsNullOrEmpty(formData.surveyTemp.e8_1_4) ? false : true;
            formData.e8_2_1 = String.IsNullOrEmpty(formData.surveyTemp.e8_2_1) ? false : true;
            formData.e8_2_2 = String.IsNullOrEmpty(formData.surveyTemp.e8_2_2) ? false : true;
            formData.e8_2_3 = String.IsNullOrEmpty(formData.surveyTemp.e8_2_3) ? false : true;
            formData.e8_2_4 = String.IsNullOrEmpty(formData.surveyTemp.e8_2_4) ? false : true;
            formData.e8_2_5 = String.IsNullOrEmpty(formData.surveyTemp.e8_2_5) ? false : true;
            formData.e8_2_6 = String.IsNullOrEmpty(formData.surveyTemp.e8_2_6) ? false : true;
            formData.e8_2_7 = String.IsNullOrEmpty(formData.surveyTemp.e8_2_7) ? false : true;
            formData.e8_2_8 = String.IsNullOrEmpty(formData.surveyTemp.e8_2_8) ? false : true;
            formData.e8_2_9 = String.IsNullOrEmpty(formData.surveyTemp.e8_2_9) ? false : true;
            formData.e8_2_10 = String.IsNullOrEmpty(formData.surveyTemp.e8_2_10) ? false : true;
            formData.e8_2_11 = String.IsNullOrEmpty(formData.surveyTemp.e8_2_11) ? false : true;
            formData.e9_1 = String.IsNullOrEmpty(formData.surveyTemp.e9_1) ? false : true;
            formData.e9_2 = String.IsNullOrEmpty(formData.surveyTemp.e9_2) ? false : true;
            formData.e9_3 = String.IsNullOrEmpty(formData.surveyTemp.e9_3) ? false : true;
            formData.e9_4 = String.IsNullOrEmpty(formData.surveyTemp.e9_4) ? false : true;
            formData.e10_1 = String.IsNullOrEmpty(formData.surveyTemp.e10_1) ? false : true;
            formData.e10_2 = String.IsNullOrEmpty(formData.surveyTemp.e10_2) ? false : true;
            formData.e10_3 = String.IsNullOrEmpty(formData.surveyTemp.e10_3) ? false : true;
            formData.e10_4 = String.IsNullOrEmpty(formData.surveyTemp.e10_4) ? false : true;



        }
        protected async Task HandleValidSubmit(EditContext context)
        {
            int index = 0;
            //$query="update survey_a1 set a7_0='$a7_0[$i]',a7_1='$a7_1[$i]',a7_1_1='$a7_1_1[$i]',a7_1_2='$a7_1_2[$i]',a7_2='$a7_2[$i]',a7_2_1='$a7_2_1[$i]',a7_2_2='$a7_2_2[$i]',a7_3='$a7_3[$i]',a7_3_1='$a7_3_1[$i]',a7_3_2='$a7_3_2[$i]',a7_4='$a7_4[$i]',a7_4_1='$a7_4_1[$i]',a7_4_2='$a7_4_2[$i]',a7_5='$a7_5[$i]',a7_5_1='$a7_5_1[$i]',a7_5_2='$a7_5_2[$i]',a7_6='$a7_6[$i]',a7_6_1='$a7_6_1[$i]',a7_6_2='$a7_6_2[$i]',a7_7='$a7_7[$i]',a7_7_1='$a7_7_1[$i]',a7_7_2='$a7_7_2[$i]',a7_8='$a7_8[$i]',a7_8_1='$a7_8_1[$i]',a7_8_2='$a7_8_2[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
            formData.surveyTemp.e7_1 = formData.e7_1 ? "1" : "";
            formData.surveyTemp.e7_2 = formData.e7_2 ? "2" : "";
            formData.surveyTemp.e7_3 = formData.e7_3 ? "3" : "";
            formData.surveyTemp.e7_4 = formData.e7_4 ? "4" : "";
            formData.surveyTemp.e7_5 = formData.e7_5 ? "5" : "";
            formData.surveyTemp.e7_6 = formData.e7_6 ? "6" : "";
            formData.surveyTemp.e7_7 = formData.e7_7 ? "7" : "";
            formData.surveyTemp.e7_8 = formData.e7_8 ? "8" : "";
            formData.surveyTemp.e7_9 = formData.e7_9 ? "9" : "";
            formData.surveyTemp.e7_10 = formData.e7_10 ? "10" : "";
            formData.surveyTemp.e7_11 = formData.e7_11 ? "11" : "";
            formData.surveyTemp.e8_1_1 = formData.e8_1_1 ? "1" : "";
            formData.surveyTemp.e8_1_2 = formData.e8_1_2 ? "2" : "";
            formData.surveyTemp.e8_1_3 = formData.e8_1_3 ? "3" : "";
            formData.surveyTemp.e8_1_4 = formData.e8_1_4 ? "4" : "";
            formData.surveyTemp.e8_2_1 = formData.e8_2_1 ? "1" : "";
            formData.surveyTemp.e8_2_2 = formData.e8_2_2 ? "2" : "";
            formData.surveyTemp.e8_2_3 = formData.e8_2_3 ? "3" : "";
            formData.surveyTemp.e8_2_4 = formData.e8_2_4 ? "4" : "";
            formData.surveyTemp.e8_2_5 = formData.e8_2_5 ? "5" : "";
            formData.surveyTemp.e8_2_6 = formData.e8_2_6 ? "6" : "";
            formData.surveyTemp.e8_2_7 = formData.e8_2_7 ? "7" : "";
            formData.surveyTemp.e8_2_8 = formData.e8_2_8 ? "8" : "";
            formData.surveyTemp.e8_2_9 = formData.e8_2_9 ? "9" : "";
            formData.surveyTemp.e8_2_10 = formData.e8_2_10 ? "10" : "";
            formData.surveyTemp.e8_2_11 = formData.e8_2_11 ? "11" : "";
            formData.surveyTemp.e9_1 = formData.e9_1 ? "1" : "";
            formData.surveyTemp.e9_2 = formData.e9_2 ? "2" : "";
            formData.surveyTemp.e9_3 = formData.e9_3 ? "3" : "";
            formData.surveyTemp.e9_4 = formData.e9_4 ? "4" : "";
            formData.surveyTemp.e10_1 = formData.e10_1 ? "1" : "";
            formData.surveyTemp.e10_2 = formData.e10_2 ? "2" : "";
            formData.surveyTemp.e10_3 = formData.e10_3 ? "3" : "";
            formData.surveyTemp.e10_4 = formData.e10_4 ? "4" : "";

            string hc = configSurvey.HC_noId(HC);
            formData.surveyTemp.HC = hc;
            formData.surveyTemp.survey_year = configSurvey.survey_year;
            formData.surveyTemp.survey_no = configSurvey.survey_no_num;
            //List<survey_b2> getAllSurPro = await DBContext.GetByIndex<string, survey_b2>("survey_b2", hc, null, "hc", false);
            //if(getAllSurPro.Count() > 0)
            //{
            await DBContext.UpdateItems<survey_e3>("survey_e3", new List<survey_e3>() {
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

/*
$query="select HC from survey_e3 where HC='$HC'";
$result=$mysqli->query($query);
$row=$result->fetch_object();
if($row->HC){//if($row->HC){
	$query1="update survey_e3 set e3='$e3',e4='$e4',e5='$e5',e6='$e6',e7_1='$e7_1',e7_2='$e7_2',e7_3='$e7_3',e7_4='$e7_4',e7_5='$e7_5',e7_6='$e7_6',e7_7='$e7_7',e7_8='$e7_8',e7_9='$e7_9',e7_10='$e7_10',e7_11='$e7_11',e7_11_1='$e7_11_1',e8='$e8',e8_1_1='$e8_1_1',e8_1_2='$e8_1_2',e8_1_3='$e8_1_3',e8_1_4='$e8_1_4',e8_1_4_1='$e8_1_4_1',e8_2_1='$e8_2_1',e8_2_2='$e8_2_2',e8_2_3='$e8_2_3',e8_2_4='$e8_2_4',e8_2_5='$e8_2_5',e8_2_6='$e8_2_6',e8_2_7='$e8_2_7',e8_2_8='$e8_2_8',e8_2_9='$e8_2_9',e8_2_10='$e8_2_10',e8_2_11='$e8_2_11',e8_2_11_1='$e8_2_11_1',e9_1='$e9_1',e9_2='$e9_2',e9_3='$e9_3',e9_4='$e9_4',e10_1='$e10_1',e10_2='$e10_2',e10_3='$e10_3',e10_4='$e10_4' where HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
}else{//if($row->HC){
	$query1="insert into survey_e3 (HC,survey_year,survey_no,e3,e4,e5,e6,e7_1,e7_2,e7_3,e7_4,e7_5,e7_6,e7_7,e7_8,e7_9,e7_10,e7_11,e7_11_1,e8,e8_1_1,e8_1_2,e8_1_3,e8_1_4,e8_1_4_1,e8_2_1,e8_2_2,e8_2_3,e8_2_4,e8_2_5,e8_2_6,e8_2_7,e8_2_8,e8_2_9,e8_2_10,e8_2_11,e8_2_11_1,e9_1,e9_2,e9_3,e9_4,e10_1,e10_2,e10_3,e10_4) values('$HC','$survey_year','$survey_no','$e3','$e4','$e5','$e6','$e7_1','$e7_2','$e7_3','$e7_4','$e7_5','$e7_6','$e7_7','$e7_8','$e7_9','$e7_10','$e7_11','$e7_11_1','$e8','$e8_1_1','$e8_1_2','$e8_1_3','$e8_1_4','$e8_1_4_1','$e8_2_1','$e8_2_2','$e8_2_3','$e8_2_4','$e8_2_5','$e8_2_6','$e8_2_7','$e8_2_8','$e8_2_9','$e8_2_10','$e8_2_11','$e8_2_11_1','$e9_1','$e9_2','$e9_3','$e9_4','$e10_1','$e10_2','$e10_3','$e10_4');";
}//if($row->HC){

//echo$query1."<br>";
$mysqli->query($query1);

$query_up1="update survey_staff set ch5_sp='".date("U")."' where  HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$result_up1=$mysqli->query($query_up1);

$username=$_COOKIE[username_log];
$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 5 3/3')";
$result_log=$mysqli->query($log);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveyf'
</script>*/