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
$c5=$_POST[c5];
$c5_1_1=$_POST[c5_1_1];
$c5_1_2=$_POST[c5_1_2];
$c5_1_3=$_POST[c5_1_3];
$c5_1_4=$_POST[c5_1_4];
$c5_1_4_1=$_POST[c5_1_4_1];
$c5_2_1=$_POST[c5_2_1];
$c5_2_1_1=$_POST[c5_2_1_1];
$c5_2_1_2_1=$_POST[c5_2_1_2_1];
$c5_2_1_2_2=$_POST[c5_2_1_2_2];
$c5_2_1_2_3=$_POST[c5_2_1_2_3];
$c5_2_1_3=$_POST[c5_2_1_3];
$c5_2_1_4=$_POST[c5_2_1_4];
$c5_2_2=$_POST[c5_2_2];
$c5_2_2_1=$_POST[c5_2_2_1];
$c5_2_2_2_1=$_POST[c5_2_2_2_1];
$c5_2_2_2_2=$_POST[c5_2_2_2_2];
$c5_2_2_2_3=$_POST[c5_2_2_2_3];
$c5_2_2_3=$_POST[c5_2_2_3];
$c5_2_2_4=$_POST[c5_2_2_4];
$c5_2_3=$_POST[c5_2_3];
$c5_2_3_1=$_POST[c5_2_3_1];
$c5_2_3_2_1=$_POST[c5_2_3_2_1];
$c5_2_3_2_2=$_POST[c5_2_3_2_2];
$c5_2_3_2_3=$_POST[c5_2_3_2_3];
$c5_2_3_3=$_POST[c5_2_3_3];
$c5_2_3_4=$_POST[c5_2_3_4];
$c5_2_4=$_POST[c5_2_4];
$c5_2_4_1=$_POST[c5_2_4_1];
$c5_2_4_2_1=$_POST[c5_2_4_2_1];
$c5_2_4_2_2=$_POST[c5_2_4_2_2];
$c5_2_4_2_3=$_POST[c5_2_4_2_3];
$c5_2_4_3=$_POST[c5_2_4_3];
$c5_2_4_4=$_POST[c5_2_4_4];
$c5_2_5=$_POST[c5_2_5];
$c5_2_5_1=$_POST[c5_2_5_1];
$c5_2_5_2_1=$_POST[c5_2_5_2_1];
$c5_2_5_2_2=$_POST[c5_2_5_2_2];
$c5_2_5_2_3=$_POST[c5_2_5_2_3];
$c5_2_5_3=$_POST[c5_2_5_3];
$c5_2_5_4=$_POST[c5_2_5_4];
$c5_2_6=$_POST[c5_2_6];
$c5_2_6_1=$_POST[c5_2_6_1];
$c5_2_6_2_1=$_POST[c5_2_6_2_1];
$c5_2_6_2_2=$_POST[c5_2_6_2_2];
$c5_2_6_2_3=$_POST[c5_2_6_2_3];
$c5_2_6_3=$_POST[c5_2_6_3];
$c5_2_6_4=$_POST[c5_2_6_4];
$c5_2_7=$_POST[c5_2_7];
$c5_2_7_1=$_POST[c5_2_7_1];
$c5_2_7_2_1=$_POST[c5_2_7_2_1];
$c5_2_7_2_2=$_POST[c5_2_7_2_2];
$c5_2_7_2_3=$_POST[c5_2_7_2_3];
$c5_2_7_3=$_POST[c5_2_7_3];
$c5_2_7_4=$_POST[c5_2_7_4];
$c5_2_8=$_POST[c5_2_8];
$c5_2_8_1=$_POST[c5_2_8_1];
$c5_2_8_2_1=$_POST[c5_2_8_2_1];
$c5_2_8_2_2=$_POST[c5_2_8_2_2];
$c5_2_8_2_3=$_POST[c5_2_8_2_3];
$c5_2_8_3=$_POST[c5_2_8_3];
$c5_2_8_4=$_POST[c5_2_8_4];
$c5_2_9=$_POST[c5_2_9];
$c5_2_9_1=$_POST[c5_2_9_1];
$c5_2_9_2_1=$_POST[c5_2_9_2_1];
$c5_2_9_2_2=$_POST[c5_2_9_2_2];
$c5_2_9_2_3=$_POST[c5_2_9_2_3];
$c5_2_9_3=$_POST[c5_2_9_3];
$c5_2_9_4=$_POST[c5_2_9_4];
$c5_2_10=$_POST[c5_2_10];
$c5_2_10_1=$_POST[c5_2_10_1];
$c5_2_10_2_1=$_POST[c5_2_10_2_1];
$c5_2_10_2_2=$_POST[c5_2_10_2_2];
$c5_2_10_2_3=$_POST[c5_2_10_2_3];
$c5_2_10_3=$_POST[c5_2_10_3];
$c5_2_10_4=$_POST[c5_2_10_4];
$c5_2_11=$_POST[c5_2_11];
$c5_2_11_1=$_POST[c5_2_11_1];
$c5_2_11_2_1=$_POST[c5_2_11_2_1];
$c5_2_11_2_2=$_POST[c5_2_11_2_2];
$c5_2_11_2_3=$_POST[c5_2_11_2_3];
$c5_2_11_3=$_POST[c5_2_11_3];
$c5_2_11_4=$_POST[c5_2_11_4];
$c5_2_12=$_POST[c5_2_12];
$c5_2_12_1_1=$_POST[c5_2_12_1_1];
$c5_2_12_1_2=$_POST[c5_2_12_1_2];
$c5_2_12_2_1=$_POST[c5_2_12_2_1];
$c5_2_12_2_2=$_POST[c5_2_12_2_2];
$c5_2_12_2_3=$_POST[c5_2_12_2_3];
$c5_2_12_3=$_POST[c5_2_12_3];
$c5_2_12_4=$_POST[c5_2_12_4];

if(!$_SESSION["HC"]){
?>
<script>
location='https://livingonnewpace.com/survey/index.php?curr=survey_profile';
</script>*/
/*<?php
	exit();
}


$query="select HC from survey_c2 where HC='$HC'";
$result=$mysqli->query($query);
$row=$result->fetch_object();
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
    public partial class Surveyc2 : ComponentBase
    {

        [Parameter]
        public string HC { get; set; }
string complete = "";
        chksurveyb2 formData = new chksurveyb2();
        class chksurveyb2
        {
            public bool c5_1_1 { get; set; }
            public bool c5_1_2 { get; set; }
            public bool c5_1_3 { get; set; }
            public bool c5_1_4 { get; set; }
            public bool c5_2_1 { get; set; }
            public bool c5_2_1_2_1 { get; set; }
            public bool c5_2_1_2_2 { get; set; }
            public bool c5_2_1_2_3 { get; set; }
            public bool c5_2_2 { get; set; }
            public bool c5_2_2_2_1 { get; set; }
            public bool c5_2_2_2_2 { get; set; }
            public bool c5_2_2_2_3 { get; set; }
            public bool c5_2_3 { get; set; }
            public bool c5_2_3_2_1 { get; set; }
            public bool c5_2_3_2_2 { get; set; }
            public bool c5_2_3_2_3 { get; set; }
            public bool c5_2_4 { get; set; }
            public bool c5_2_4_2_1 { get; set; }
            public bool c5_2_4_2_2 { get; set; }
            public bool c5_2_4_2_3 { get; set; }
            public bool c5_2_5 { get; set; }
            public bool c5_2_5_2_1 { get; set; }
            public bool c5_2_5_2_2 { get; set; }
            public bool c5_2_5_2_3 { get; set; }
            public bool c5_2_6 { get; set; }
            public bool c5_2_6_2_1 { get; set; }
            public bool c5_2_6_2_2 { get; set; }
            public bool c5_2_6_2_3 { get; set; }
            public bool c5_2_7 { get; set; }
            public bool c5_2_7_2_1 { get; set; }
            public bool c5_2_7_2_2 { get; set; }
            public bool c5_2_7_2_3 { get; set; }
            public bool c5_2_8 { get; set; }
            public bool c5_2_8_2_1 { get; set; }
            public bool c5_2_8_2_2 { get; set; }
            public bool c5_2_8_2_3 { get; set; }
            public bool c5_2_9 { get; set; }
            public bool c5_2_9_2_1 { get; set; }
            public bool c5_2_9_2_2 { get; set; }
            public bool c5_2_9_2_3 { get; set; }
            public bool c5_2_10 { get; set; }
            public bool c5_2_10_2_1 { get; set; }
            public bool c5_2_10_2_2 { get; set; }
            public bool c5_2_10_2_3 { get; set; }
            public bool c5_2_11 { get; set; }
            public bool c5_2_11_2_1 { get; set; }
            public bool c5_2_11_2_2 { get; set; }
            public bool c5_2_11_2_3 { get; set; }
            public bool c5_2_12 { get; set; }
            public bool c5_2_12_2_1 { get; set; }
            public bool c5_2_12_2_2 { get; set; }
            public bool c5_2_12_2_3 { get; set; }
            public survey_c2 surveyTemp = new survey_c2();

        }

        protected override async Task OnInitializedAsync()
        {
            await DBContext.OpenIndexedDb();
            string hc = configSurvey.HC_noId(HC);
            List<survey_c2> getAllSurPro = await DBContext.GetByIndex<string, survey_c2>("survey_c2", hc, null, "hc", false);

            if (getAllSurPro.Count() > 0)
            {

                formData.surveyTemp = getAllSurPro.FirstOrDefault();
            }

            formData.c5_1_1 = String.IsNullOrEmpty(formData.surveyTemp.c5_1_1) ? false : true;
            formData.c5_1_2 = String.IsNullOrEmpty(formData.surveyTemp.c5_1_2) ? false : true;
            formData.c5_1_3 = String.IsNullOrEmpty(formData.surveyTemp.c5_1_3) ? false : true;
            formData.c5_1_4 = String.IsNullOrEmpty(formData.surveyTemp.c5_1_4) ? false : true;
            formData.c5_2_1 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_1) ? false : true;
            formData.c5_2_1_2_1 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_1_2_1) ? false : true;
            formData.c5_2_1_2_2 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_1_2_2) ? false : true;
            formData.c5_2_1_2_3 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_1_2_3) ? false : true;
            formData.c5_2_2 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_2) ? false : true;
            formData.c5_2_2_2_1 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_2_2_1) ? false : true;
            formData.c5_2_2_2_2 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_2_2_2) ? false : true;
            formData.c5_2_2_2_3 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_2_2_3) ? false : true;
            formData.c5_2_3 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_3) ? false : true;
            formData.c5_2_3_2_1 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_3_2_1) ? false : true;
            formData.c5_2_3_2_2 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_3_2_2) ? false : true;
            formData.c5_2_3_2_3 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_3_2_3) ? false : true;
            formData.c5_2_4 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_4) ? false : true;
            formData.c5_2_4_2_1 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_4_2_1) ? false : true;
            formData.c5_2_4_2_2 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_4_2_2) ? false : true;
            formData.c5_2_4_2_3 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_4_2_3) ? false : true;
            formData.c5_2_5 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_5) ? false : true;
            formData.c5_2_5_2_1 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_5_2_1) ? false : true;
            formData.c5_2_5_2_2 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_5_2_2) ? false : true;
            formData.c5_2_5_2_3 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_5_2_3) ? false : true;
            formData.c5_2_6 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_6) ? false : true;
            formData.c5_2_6_2_1 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_6_2_1) ? false : true;
            formData.c5_2_6_2_2 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_6_2_2) ? false : true;
            formData.c5_2_6_2_3 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_6_2_3) ? false : true;
            formData.c5_2_7 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_7) ? false : true;
            formData.c5_2_7_2_1 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_7_2_1) ? false : true;
            formData.c5_2_7_2_2 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_7_2_2) ? false : true;
            formData.c5_2_7_2_3 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_7_2_3) ? false : true;
            formData.c5_2_8 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_8) ? false : true;
            formData.c5_2_8_2_1 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_8_2_1) ? false : true;
            formData.c5_2_8_2_2 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_8_2_2) ? false : true;
            formData.c5_2_8_2_3 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_8_2_3) ? false : true;
            formData.c5_2_9 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_9) ? false : true;
            formData.c5_2_9_2_1 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_9_2_1) ? false : true;
            formData.c5_2_9_2_2 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_9_2_2) ? false : true;
            formData.c5_2_9_2_3 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_9_2_3) ? false : true;
            formData.c5_2_10 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_10) ? false : true;
            formData.c5_2_10_2_1 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_10_2_1) ? false : true;
            formData.c5_2_10_2_2 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_10_2_2) ? false : true;
            formData.c5_2_10_2_3 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_10_2_3) ? false : true;
            formData.c5_2_11 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_11) ? false : true;
            formData.c5_2_11_2_1 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_11_2_1) ? false : true;
            formData.c5_2_11_2_2 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_11_2_2) ? false : true;
            formData.c5_2_11_2_3 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_11_2_3) ? false : true;
            formData.c5_2_12 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_12) ? false : true;
            formData.c5_2_12_2_1 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_12_2_1) ? false : true;
            formData.c5_2_12_2_2 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_12_2_2) ? false : true;
            formData.c5_2_12_2_3 = String.IsNullOrEmpty(formData.surveyTemp.c5_2_12_2_3) ? false : true;

        }
        protected async Task HandleValidSubmit(EditContext context)
        {
            int index = 0;
            //$query="update survey_a1 set a7_0='$a7_0[$i]',a7_1='$a7_1[$i]',a7_1_1='$a7_1_1[$i]',a7_1_2='$a7_1_2[$i]',a7_2='$a7_2[$i]',a7_2_1='$a7_2_1[$i]',a7_2_2='$a7_2_2[$i]',a7_3='$a7_3[$i]',a7_3_1='$a7_3_1[$i]',a7_3_2='$a7_3_2[$i]',a7_4='$a7_4[$i]',a7_4_1='$a7_4_1[$i]',a7_4_2='$a7_4_2[$i]',a7_5='$a7_5[$i]',a7_5_1='$a7_5_1[$i]',a7_5_2='$a7_5_2[$i]',a7_6='$a7_6[$i]',a7_6_1='$a7_6_1[$i]',a7_6_2='$a7_6_2[$i]',a7_7='$a7_7[$i]',a7_7_1='$a7_7_1[$i]',a7_7_2='$a7_7_2[$i]',a7_8='$a7_8[$i]',a7_8_1='$a7_8_1[$i]',a7_8_2='$a7_8_2[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";

            formData.surveyTemp.c5_1_1 = formData.c5_1_1 ? "1" : "";
            formData.surveyTemp.c5_1_2 = formData.c5_1_2 ? "2" : "";
            formData.surveyTemp.c5_1_3 = formData.c5_1_3 ? "3" : "";
            formData.surveyTemp.c5_1_4 = formData.c5_1_4 ? "4" : "";
            formData.surveyTemp.c5_2_1 = formData.c5_2_1 ? "1" : "";
            formData.surveyTemp.c5_2_1_2_1 = formData.c5_2_1_2_1 ? "1" : "";
            formData.surveyTemp.c5_2_1_2_2 = formData.c5_2_1_2_2 ? "2" : "";
            formData.surveyTemp.c5_2_1_2_3 = formData.c5_2_1_2_3 ? "3" : "";
            formData.surveyTemp.c5_2_2 = formData.c5_2_2 ? "2" : "";
            formData.surveyTemp.c5_2_2_2_1 = formData.c5_2_2_2_1 ? "1" : "";
            formData.surveyTemp.c5_2_2_2_2 = formData.c5_2_2_2_2 ? "2" : "";
            formData.surveyTemp.c5_2_2_2_3 = formData.c5_2_2_2_3 ? "3" : "";
            formData.surveyTemp.c5_2_3 = formData.c5_2_3 ? "3" : "";
            formData.surveyTemp.c5_2_3_2_1 = formData.c5_2_3_2_1 ? "1" : "";
            formData.surveyTemp.c5_2_3_2_2 = formData.c5_2_3_2_2 ? "2" : "";
            formData.surveyTemp.c5_2_3_2_3 = formData.c5_2_3_2_3 ? "3" : "";
            formData.surveyTemp.c5_2_4 = formData.c5_2_4 ? "4" : "";
            formData.surveyTemp.c5_2_4_2_1 = formData.c5_2_4_2_1 ? "1" : "";
            formData.surveyTemp.c5_2_4_2_2 = formData.c5_2_4_2_2 ? "2" : "";
            formData.surveyTemp.c5_2_4_2_3 = formData.c5_2_4_2_3 ? "3" : "";
            formData.surveyTemp.c5_2_5 = formData.c5_2_5 ? "5" : "";
            formData.surveyTemp.c5_2_5_2_1 = formData.c5_2_5_2_1 ? "1" : "";
            formData.surveyTemp.c5_2_5_2_2 = formData.c5_2_5_2_2 ? "2" : "";
            formData.surveyTemp.c5_2_5_2_3 = formData.c5_2_5_2_3 ? "3" : "";
            formData.surveyTemp.c5_2_6 = formData.c5_2_6 ? "6" : "";
            formData.surveyTemp.c5_2_6_2_1 = formData.c5_2_6_2_1 ? "1" : "";
            formData.surveyTemp.c5_2_6_2_2 = formData.c5_2_6_2_2 ? "2" : "";
            formData.surveyTemp.c5_2_6_2_3 = formData.c5_2_6_2_3 ? "3" : "";
            formData.surveyTemp.c5_2_7 = formData.c5_2_7 ? "7" : "";
            formData.surveyTemp.c5_2_7_2_1 = formData.c5_2_7_2_1 ? "1" : "";
            formData.surveyTemp.c5_2_7_2_2 = formData.c5_2_7_2_2 ? "2" : "";
            formData.surveyTemp.c5_2_7_2_3 = formData.c5_2_7_2_3 ? "3" : "";
            formData.surveyTemp.c5_2_8 = formData.c5_2_8 ? "8" : "";
            formData.surveyTemp.c5_2_8_2_1 = formData.c5_2_8_2_1 ? "1" : "";
            formData.surveyTemp.c5_2_8_2_2 = formData.c5_2_8_2_2 ? "2" : "";
            formData.surveyTemp.c5_2_8_2_3 = formData.c5_2_8_2_3 ? "3" : "";
            formData.surveyTemp.c5_2_9 = formData.c5_2_9 ? "9" : "";
            formData.surveyTemp.c5_2_9_2_1 = formData.c5_2_9_2_1 ? "1" : "";
            formData.surveyTemp.c5_2_9_2_2 = formData.c5_2_9_2_2 ? "2" : "";
            formData.surveyTemp.c5_2_9_2_3 = formData.c5_2_9_2_3 ? "3" : "";
            formData.surveyTemp.c5_2_10 = formData.c5_2_10 ? "10" : "";
            formData.surveyTemp.c5_2_10_2_1 = formData.c5_2_10_2_1 ? "1" : "";
            formData.surveyTemp.c5_2_10_2_2 = formData.c5_2_10_2_2 ? "2" : "";
            formData.surveyTemp.c5_2_10_2_3 = formData.c5_2_10_2_3 ? "3" : "";
            formData.surveyTemp.c5_2_11 = formData.c5_2_11 ? "11" : "";
            formData.surveyTemp.c5_2_11_2_1 = formData.c5_2_11_2_1 ? "1" : "";
            formData.surveyTemp.c5_2_11_2_2 = formData.c5_2_11_2_2 ? "2" : "";
            formData.surveyTemp.c5_2_11_2_3 = formData.c5_2_11_2_3 ? "3" : "";
            formData.surveyTemp.c5_2_12 = formData.c5_2_12 ? "12" : "";
            formData.surveyTemp.c5_2_12_2_1 = formData.c5_2_12_2_1 ? "1" : "";
            formData.surveyTemp.c5_2_12_2_2 = formData.c5_2_12_2_2 ? "2" : "";
            formData.surveyTemp.c5_2_12_2_3 = formData.c5_2_12_2_3 ? "3" : "";
            string hc = configSurvey.HC_noId(HC);
            formData.surveyTemp.HC = hc;
            formData.surveyTemp.survey_year = configSurvey.survey_year;
            formData.surveyTemp.survey_no = configSurvey.survey_no_num;
            //List<survey_b2> getAllSurPro = await DBContext.GetByIndex<string, survey_b2>("survey_b2", hc, null, "hc", false);
            //if(getAllSurPro.Count() > 0)
            //{
            await DBContext.UpdateItems<survey_c2>("survey_c2", new List<survey_c2>() {
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
$query1="insert into survey_c2 (HC,survey_year,survey_no,c5,c5_1_1,c5_1_2,c5_1_3,c5_1_4,c5_1_4_1,c5_2_1,c5_2_1_1,c5_2_1_2_1,c5_2_1_2_2,c5_2_1_2_3,c5_2_1_3,c5_2_1_4,c5_2_2,c5_2_2_1,c5_2_2_2_1,c5_2_2_2_2,c5_2_2_2_3,c5_2_2_3,c5_2_2_4,c5_2_3,c5_2_3_1,c5_2_3_2_1,c5_2_3_2_2,c5_2_3_2_3,c5_2_3_3,c5_2_3_4,c5_2_4,c5_2_4_1,c5_2_4_2_1,c5_2_4_2_2,c5_2_4_2_3,c5_2_4_3,c5_2_4_4,c5_2_5,c5_2_5_1,c5_2_5_2_1,c5_2_5_2_2,c5_2_5_2_3,c5_2_5_3,c5_2_5_4,c5_2_6,c5_2_6_1,c5_2_6_2_1,c5_2_6_2_2,c5_2_6_2_3,c5_2_6_3,c5_2_6_4,c5_2_7,c5_2_7_1,c5_2_7_2_1,c5_2_7_2_2,c5_2_7_2_3,c5_2_7_3,c5_2_7_4,c5_2_8,c5_2_8_1,c5_2_8_2_1,c5_2_8_2_2,c5_2_8_2_3,c5_2_8_3,c5_2_8_4,c5_2_9,c5_2_9_1,c5_2_9_2_1,c5_2_9_2_2,c5_2_9_2_3,c5_2_9_3,c5_2_9_4,c5_2_10,c5_2_10_1,c5_2_10_2_1,c5_2_10_2_2,c5_2_10_2_3,c5_2_10_3,c5_2_10_4,c5_2_11,c5_2_11_1,c5_2_11_2_1,c5_2_11_2_2,c5_2_11_2_3,c5_2_11_3,c5_2_11_4,c5_2_12,c5_2_12_1_1,c5_2_12_1_2,c5_2_12_2_1,c5_2_12_2_2,c5_2_12_2_3,c5_2_12_3,c5_2_12_4) values('$HC','$survey_year','$survey_no','$c5','$c5_1_1','$c5_1_2','$c5_1_3','$c5_1_4','$c5_1_4_1','$c5_2_1','$c5_2_1_1','$c5_2_1_2_1','$c5_2_1_2_2','$c5_2_1_2_3','$c5_2_1_3','$c5_2_1_4','$c5_2_2','$c5_2_2_1','$c5_2_2_2_1','$c5_2_2_2_2','$c5_2_2_2_3','$c5_2_2_3','$c5_2_2_4','$c5_2_3','$c5_2_3_1','$c5_2_3_2_1','$c5_2_3_2_2','$c5_2_3_2_3','$c5_2_3_3','$c5_2_3_4','$c5_2_4','$c5_2_4_1','$c5_2_4_2_1','$c5_2_4_2_2','$c5_2_4_2_3','$c5_2_4_3','$c5_2_4_4','$c5_2_5','$c5_2_5_1','$c5_2_5_2_1','$c5_2_5_2_2','$c5_2_5_2_3','$c5_2_5_3','$c5_2_5_4','$c5_2_6','$c5_2_6_1','$c5_2_6_2_1','$c5_2_6_2_2','$c5_2_6_2_3','$c5_2_6_3','$c5_2_6_4','$c5_2_7','$c5_2_7_1','$c5_2_7_2_1','$c5_2_7_2_2','$c5_2_7_2_3','$c5_2_7_3','$c5_2_7_4','$c5_2_8','$c5_2_8_1','$c5_2_8_2_1','$c5_2_8_2_2','$c5_2_8_2_3','$c5_2_8_3','$c5_2_8_4','$c5_2_9','$c5_2_9_1','$c5_2_9_2_1','$c5_2_9_2_2','$c5_2_9_2_3','$c5_2_9_3','$c5_2_9_4','$c5_2_10','$c5_2_10_1','$c5_2_10_2_1','$c5_2_10_2_2','$c5_2_10_2_3','$c5_2_10_3','$c5_2_10_4','$c5_2_11','$c5_2_11_1','$c5_2_11_2_1','$c5_2_11_2_2','$c5_2_11_2_3','$c5_2_11_3','$c5_2_11_4','$c5_2_12','$c5_2_12_1_1','$c5_2_12_1_2','$c5_2_12_2_1','$c5_2_12_2_2','$c5_2_12_2_3','$c5_2_12_3','$c5_2_12_4');";
$mysqli->query($query1);

$query1="update survey_c2 set c5='$c5',c5_1_1='$c5_1_1',c5_1_2='$c5_1_2',c5_1_3='$c5_1_3',c5_1_4='$c5_1_4',c5_1_4_1='$c5_1_4_1',c5_2_1='$c5_2_1',c5_2_1_1='$c5_2_1_1',c5_2_1_2_1='$c5_2_1_2_1',c5_2_1_2_2='$c5_2_1_2_2',c5_2_1_2_3='$c5_2_1_2_3',c5_2_1_3='$c5_2_1_3',c5_2_1_4='$c5_2_1_4',c5_2_2='$c5_2_2',c5_2_2_1='$c5_2_2_1',c5_2_2_2_1='$c5_2_2_2_1',c5_2_2_2_2='$c5_2_2_2_2',c5_2_2_2_3='$c5_2_2_2_3',c5_2_2_3='$c5_2_2_3',c5_2_2_4='$c5_2_2_4',c5_2_3='$c5_2_3',c5_2_3_1='$c5_2_3_1',c5_2_3_2_1='$c5_2_3_2_1',c5_2_3_2_2='$c5_2_3_2_2',c5_2_3_2_3='$c5_2_3_2_3',c5_2_3_3='$c5_2_3_3',c5_2_3_4='$c5_2_3_4',c5_2_4='$c5_2_4',c5_2_4_1='$c5_2_4_1',c5_2_4_2_1='$c5_2_4_2_1',c5_2_4_2_2='$c5_2_4_2_2',c5_2_4_2_3='$c5_2_4_2_3',c5_2_4_3='$c5_2_4_3',c5_2_4_4='$c5_2_4_4',c5_2_5='$c5_2_5',c5_2_5_1='$c5_2_5_1',c5_2_5_2_1='$c5_2_5_2_1',c5_2_5_2_2='$c5_2_5_2_2',c5_2_5_2_3='$c5_2_5_2_3',c5_2_5_3='$c5_2_5_3',c5_2_5_4='$c5_2_5_4',c5_2_6='$c5_2_6',c5_2_6_1='$c5_2_6_1',c5_2_6_2_1='$c5_2_6_2_1',c5_2_6_2_2='$c5_2_6_2_2',c5_2_6_2_3='$c5_2_6_2_3',c5_2_6_3='$c5_2_6_3',c5_2_6_4='$c5_2_6_4',c5_2_7='$c5_2_7',c5_2_7_1='$c5_2_7_1',c5_2_7_2_1='$c5_2_7_2_1',c5_2_7_2_2='$c5_2_7_2_2',c5_2_7_2_3='$c5_2_7_2_3',c5_2_7_3='$c5_2_7_3',c5_2_7_4='$c5_2_7_4',c5_2_8='$c5_2_8',c5_2_8_1='$c5_2_8_1',c5_2_8_2_1='$c5_2_8_2_1',c5_2_8_2_2='$c5_2_8_2_2',c5_2_8_2_3='$c5_2_8_2_3',c5_2_8_3='$c5_2_8_3',c5_2_8_4='$c5_2_8_4',c5_2_9='$c5_2_9',c5_2_9_1='$c5_2_9_1',c5_2_9_2_1='$c5_2_9_2_1',c5_2_9_2_2='$c5_2_9_2_2',c5_2_9_2_3='$c5_2_9_2_3',c5_2_9_3='$c5_2_9_3',c5_2_9_4='$c5_2_9_4',c5_2_10='$c5_2_10',c5_2_10_1='$c5_2_10_1',c5_2_10_2_1='$c5_2_10_2_1',c5_2_10_2_2='$c5_2_10_2_2',c5_2_10_2_3='$c5_2_10_2_3',c5_2_10_3='$c5_2_10_3',c5_2_10_4='$c5_2_10_4',c5_2_11='$c5_2_11',c5_2_11_1='$c5_2_11_1',c5_2_11_2_1='$c5_2_11_2_1',c5_2_11_2_2='$c5_2_11_2_2',c5_2_11_2_3='$c5_2_11_2_3',c5_2_11_3='$c5_2_11_3',c5_2_11_4='$c5_2_11_4',c5_2_12='$c5_2_12',c5_2_12_1_1='$c5_2_12_1_1',c5_2_12_1_2='$c5_2_12_1_2',c5_2_12_2_1='$c5_2_12_2_1',c5_2_12_2_2='$c5_2_12_2_2',c5_2_12_2_3='$c5_2_12_2_3',c5_2_12_3='$c5_2_12_3',c5_2_12_4='$c5_2_12_4' where HC='$HC'  and survey_year='$survey_year' and survey_no='$survey_no'";

$mysqli->query($query1);

//echo$query1."<br>";
$username=$_COOKIE[username_log];
$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 3 2/3')";
$result_log=$mysqli->query($log);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveyc3'
</script>*/