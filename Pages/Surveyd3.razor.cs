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
$d5=$_POST[d5];
$d5_1=$_POST[d5_1];
$d5_1_1=$_POST[d5_1_1];
$d5_1_2=$_POST[d5_1_2];
$d5_2=$_POST[d5_2];
$d5_2_1=$_POST[d5_2_1];
$d5_2_2=$_POST[d5_2_2];
$d5_3=$_POST[d5_3];
$d5_3_1=$_POST[d5_3_1];
$d5_3_2=$_POST[d5_3_2];
$d5_4=$_POST[d5_4];
$d5_4_1=$_POST[d5_4_1];
$d5_4_2=$_POST[d5_4_2];
$d5_5=$_POST[d5_5];
$d5_5_1=$_POST[d5_5_1];
$d5_5_2=$_POST[d5_5_2];
$d5_6=$_POST[d5_6];
$d5_6_1=$_POST[d5_6_1];
$d5_6_2=$_POST[d5_6_2];
$d5_7=$_POST[d5_7];
$d5_7_1=$_POST[d5_7_1];
$d5_7_2=$_POST[d5_7_2];
$d5_8=$_POST[d5_8];
$d5_8_1=$_POST[d5_8_1];
$d5_8_2=$_POST[d5_8_2];
$d5_9=$_POST[d5_9];
$d5_9_1=$_POST[d5_9_1];
$d5_9_2=$_POST[d5_9_2];
$d5_10=$_POST[d5_10];
$d5_10_1=$_POST[d5_10_1];
$d5_10_2=$_POST[d5_10_2];
$d5_11=$_POST[d5_11];
$d5_11_1=$_POST[d5_11_1];
$d5_11_2=$_POST[d5_11_2];

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
    public partial class Surveyd3 : ComponentBase
    {

        [Parameter]
        public string HC { get; set; }
string complete = "";
        chksurveyb2 formData = new chksurveyb2();
        class chksurveyb2
        {

            public survey_d3 surveyTemp = new survey_d3();

        }

        protected override async Task OnInitializedAsync()
        {
            await DBContext.OpenIndexedDb();
            string hc = configSurvey.HC_noId(HC);
            List<survey_d3> getAllSurPro = await DBContext.GetByIndex<string, survey_d3>("survey_d3", hc, null, "hc", false);

            if (getAllSurPro.Count() > 0)
            {

                formData.surveyTemp = getAllSurPro.FirstOrDefault();
            }



        }
        protected async Task HandleValidSubmit(EditContext context)
        {
            int index = 0;
            //$query="update survey_a1 set a7_0='$a7_0[$i]',a7_1='$a7_1[$i]',a7_1_1='$a7_1_1[$i]',a7_1_2='$a7_1_2[$i]',a7_2='$a7_2[$i]',a7_2_1='$a7_2_1[$i]',a7_2_2='$a7_2_2[$i]',a7_3='$a7_3[$i]',a7_3_1='$a7_3_1[$i]',a7_3_2='$a7_3_2[$i]',a7_4='$a7_4[$i]',a7_4_1='$a7_4_1[$i]',a7_4_2='$a7_4_2[$i]',a7_5='$a7_5[$i]',a7_5_1='$a7_5_1[$i]',a7_5_2='$a7_5_2[$i]',a7_6='$a7_6[$i]',a7_6_1='$a7_6_1[$i]',a7_6_2='$a7_6_2[$i]',a7_7='$a7_7[$i]',a7_7_1='$a7_7_1[$i]',a7_7_2='$a7_7_2[$i]',a7_8='$a7_8[$i]',a7_8_1='$a7_8_1[$i]',a7_8_2='$a7_8_2[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";


            string hc = configSurvey.HC_noId(HC);
            formData.surveyTemp.HC = hc;
            formData.surveyTemp.survey_year = configSurvey.survey_year;
            formData.surveyTemp.survey_no = configSurvey.survey_no_num;
            //List<survey_b2> getAllSurPro = await DBContext.GetByIndex<string, survey_b2>("survey_b2", hc, null, "hc", false);
            //if(getAllSurPro.Count() > 0)
            //{
            await DBContext.UpdateItems<survey_d3>("survey_d3", new List<survey_d3>() {
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
                    firstStaff.ch4_sp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

                    await DBContext.UpdateItems<survey_staff>("survey_staff", new List<survey_staff>() { firstStaff });
                }
            }
            complete = "เรียบร้อย";
        }


        private async Task gotoPage(string HC_nextPage)
        {
            NavigationManager.NavigateTo("/surveye1/" + HC_nextPage);
        }
    }
}


/*
$query1="insert into survey_d3 (HC,survey_year,survey_no,d5,d5_1,d5_1_1,d5_1_2,d5_2,d5_2_1,d5_2_2,d5_3,d5_3_1,d5_3_2,d5_4,d5_4_1,d5_4_2,d5_5,d5_5_1,d5_5_2,d5_6,d5_6_1,d5_6_2,d5_7,d5_7_1,d5_7_2,d5_8,d5_8_1,d5_8_2,d5_9,d5_9_1,d5_9_2,d5_10,d5_10_1,d5_10_2,d5_11,d5_11_1,d5_11_2) values('$HC','$survey_year','$survey_no','$d5','$d5_1','$d5_1_1','$d5_1_2','$d5_2','$d5_2_1','$d5_2_2','$d5_3','$d5_3_1','$d5_3_2','$d5_4','$d5_4_1','$d5_4_2','$d5_5','$d5_5_1','$d5_5_2','$d5_6','$d5_6_1','$d5_6_2','$d5_7','$d5_7_1','$d5_7_2','$d5_8','$d5_8_1','$d5_8_2','$d5_9','$d5_9_1','$d5_9_2','$d5_10','$d5_10_1','$d5_10_2','$d5_11','$d5_11_1','$d5_11_2');";
$mysqli->query($query1);

$query1="update survey_d3 set d5='$d5',d5_1='$d5_1',d5_1_1='$d5_1_1',d5_1_2='$d5_1_2',d5_2='$d5_2',d5_2_1='$d5_2_1',d5_2_2='$d5_2_2',d5_3='$d5_3',d5_3_1='$d5_3_1',d5_3_2='$d5_3_2',d5_4='$d5_4',d5_4_1='$d5_4_1',d5_4_2='$d5_4_2',d5_5='$d5_5',d5_5_1='$d5_5_1',d5_5_2='$d5_5_2',d5_6='$d5_6',d5_6_1='$d5_6_1',d5_6_2='$d5_6_2',d5_7='$d5_7',d5_7_1='$d5_7_1',d5_7_2='$d5_7_2',d5_8='$d5_8',d5_8_1='$d5_8_1',d5_8_2='$d5_8_2',d5_9='$d5_9',d5_9_1='$d5_9_1',d5_9_2='$d5_9_2',d5_10='$d5_10',d5_10_1='$d5_10_1',d5_10_2='$d5_10_2',d5_11='$d5_11',d5_11_1='$d5_11_1',d5_11_2='$d5_11_2' where HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$mysqli->query($query1);

//echo$query1."<br>";


$query_up1="update survey_staff set ch4_sp='".date("U")."' where  HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$result_up1=$mysqli->query($query_up1);

$username=$_COOKIE[username_log];
$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 4 3/3')";
$result_log=$mysqli->query($log);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveye1'
</script>*/