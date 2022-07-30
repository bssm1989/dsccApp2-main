/*<?php
session_start();
error_reporting(E_ALL & ~E_DEPRECATED & ~E_STRICT & ~E_NOTICE &  ~E_WARNING);
//phpinfo();
//exit();
require_once ("config.php");
require_once ("function.php");
$next=str_replace("'","\'",$_POST["next"]);
$username=$_COOKIE[username_log];

if($next){
$mysqli=mcon($mysql["host"], $mysql["user"], $mysql["pass"], $mysql["dbname"],$mysql["charset"]);

$HC=$_SESSION["HC"];
$a1=$_POST[a1];

$a16_0=$_POST[a16_0];
$a16_1=$_POST[a16_1];
$a16_2=$_POST[a16_2];
$a16_3=$_POST[a16_3];
$a16_4=$_POST[a16_4];
$a16_5=$_POST[a16_5];
$a16_6=$_POST[a16_6];
$a16_7=$_POST[a16_7];
$a16_8=$_POST[a16_8];
$a16_9=$_POST[a16_9];
$a16_10=$_POST[a16_10];
$a16_10_1=$_POST[a16_10_1];
$a17_1=$_POST[a17_1];
$a17_2=$_POST[a17_2];
$a17_3_1=$_POST[a17_3_1];
$a17_3_2=$_POST[a17_3_2];

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
    public partial class Surveya5 : ComponentBase
    {

        [Parameter]
        public string HC { get; set; }
string complete = "";
        List<chksurveyb2> formData = new List<chksurveyb2>();
        class chksurveyb2
        {
            public bool a16_0 {get;set;}
        public bool a16_1 {get;set;}
    public bool a16_2 {get;set;}
public bool a16_3 { get; set; }
public bool a16_4 { get; set; }
public bool a16_5 { get; set; }
public bool a16_6 { get; set; }
public bool a16_7 { get; set; }
public bool a16_8 { get; set; }
public bool a16_9 { get; set; }
public bool a16_10 { get; set; }
public survey_a2 surveyTemp = new survey_a2();
            

        }
string hc_id = "";
        protected override async Task OnInitializedAsync()
        {
            await DBContext.OpenIndexedDb();

            //List<survey_a2> getAllSurPro = await DBContext.GetByIndex<string, survey_a2>("survey_a2", hc, null, "hc", false);
            List<survey_a2> getAllSurPro = await DBContext.GetAll< survey_a2>("survey_a2");
            List<survey_a2> getByHc=getAllSurPro.Where(x=>x.HC.Contains(HC)).ToList();
            if (getByHc.Count() > 0)
            {
                int indexSurvey=0;
                foreach (var item in getByHc)
                {
                    formData.Add(new chksurveyb2());
                    formData.ElementAt(indexSurvey).a16_0 = true;
                    //formData.ElementAt(indexSurvey) = new chksurveyb2();
                    formData.ElementAt(indexSurvey).surveyTemp = item;
                    formData.ElementAt(indexSurvey).a16_0 = String.IsNullOrEmpty(item.a16_0) ? false : true;
                    formData.ElementAt(indexSurvey).a16_1 = String.IsNullOrEmpty(item.a16_1) ? false : true;
                    formData.ElementAt(indexSurvey).a16_2 = String.IsNullOrEmpty(item.a16_2) ? false : true;
                    formData.ElementAt(indexSurvey).a16_3 = String.IsNullOrEmpty(item.a16_3) ? false : true;
                    formData.ElementAt(indexSurvey).a16_4 = String.IsNullOrEmpty(item.a16_4) ? false : true;
                    formData.ElementAt(indexSurvey).a16_5 = String.IsNullOrEmpty(item.a16_5) ? false : true;
                    formData.ElementAt(indexSurvey).a16_6 = String.IsNullOrEmpty(item.a16_6) ? false : true;
                    formData.ElementAt(indexSurvey).a16_7 = String.IsNullOrEmpty(item.a16_7) ? false : true;
                    formData.ElementAt(indexSurvey).a16_8 = String.IsNullOrEmpty(item.a16_8) ? false : true;
                    formData.ElementAt(indexSurvey).a16_9 = String.IsNullOrEmpty(item.a16_9) ? false : true;
                    formData.ElementAt(indexSurvey).a16_10= String.IsNullOrEmpty(item.a16_10) ? false : true;
                    indexSurvey++;
                 
                }
        
            }



        }
        protected async Task HandleValidSubmit(EditContext context)
        {
            int index = 0;
            //$query="update survey_a1 set a7_0='$a7_0[$i]',a7_1='$a7_1[$i]',a7_1_1='$a7_1_1[$i]',a7_1_2='$a7_1_2[$i]',a7_2='$a7_2[$i]',a7_2_1='$a7_2_1[$i]',a7_2_2='$a7_2_2[$i]',a7_3='$a7_3[$i]',a7_3_1='$a7_3_1[$i]',a7_3_2='$a7_3_2[$i]',a7_4='$a7_4[$i]',a7_4_1='$a7_4_1[$i]',a7_4_2='$a7_4_2[$i]',a7_5='$a7_5[$i]',a7_5_1='$a7_5_1[$i]',a7_5_2='$a7_5_2[$i]',a7_6='$a7_6[$i]',a7_6_1='$a7_6_1[$i]',a7_6_2='$a7_6_2[$i]',a7_7='$a7_7[$i]',a7_7_1='$a7_7_1[$i]',a7_7_2='$a7_7_2[$i]',a7_8='$a7_8[$i]',a7_8_1='$a7_8_1[$i]',a7_8_2='$a7_8_2[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";

            foreach (var item in formData)
            {
                formData.ElementAt(index).surveyTemp.a16_0 = item.a16_0 ? "0" : "";
                formData.ElementAt(index).surveyTemp.a16_1 = item.a16_1 ? "1" : "";
                formData.ElementAt(index).surveyTemp.a16_2 = item.a16_2 ? "2" : "";
                formData.ElementAt(index).surveyTemp.a16_3 = item.a16_3 ? "3" : "";
                formData.ElementAt(index).surveyTemp.a16_4 = item.a16_4 ? "4" : "";
                formData.ElementAt(index).surveyTemp.a16_5 = item.a16_5 ? "5" : "";
                formData.ElementAt(index).surveyTemp.a16_6 = item.a16_6 ? "6" : "";
                formData.ElementAt(index).surveyTemp.a16_7 = item.a16_7 ? "7" : "";
                formData.ElementAt(index).surveyTemp.a16_8 = item.a16_8 ? "8" : "";
                formData.ElementAt(index).surveyTemp.a16_9 = item.a16_9 ? "9" : "";
                formData.ElementAt(index).surveyTemp.a16_10= item.a16_10 ? "10" : "";
              
                await DBContext.UpdateItems<survey_a2>("survey_a2", new List<survey_a2>() {
                formData.ElementAt(index).surveyTemp
             });
                index++;
            }



            //List<survey_b2> getAllSurPro = await DBContext.GetByIndex<string, survey_b2>("survey_b2", hc, null, "hc", false);
            //if(getAllSurPro.Count() > 0)
            //{


            //else
            //{
            //    getAdd=await DBContext.AddItems<survey_b2>("survey_b2", new List<survey_b2>() {
            //            formData.survey_B2
            //});
            //}

            //$query_up1 = "update survey_staff set ch1_sp='".date("U")."' where  HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
            var getallSurveyStaff = await DBContext.GetAll<survey_staff>("survey_staff");
            hc_id = getallSurveyStaff.Where(x => x.HC.Contains(HC)).FirstOrDefault().HC;
            if (hc_id != null)
            {
                var updateStaff = await DBContext.GetByIndex<string, survey_staff>("survey_staff", hc_id, "", "hc", false);
                var firstStaff=updateStaff.FirstOrDefault();
                if (firstStaff != null)
                {
                    firstStaff.ch1_sp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

                    await DBContext.UpdateItems<survey_staff>("survey_staff",new List<survey_staff>() { firstStaff });
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
$count=count($a1);
for($i=1;$i<=$count;$i++){//for($i=1;$i<=$count;$i++){
	$query="update survey_a2 set a16_0='$a16_0[$i]',a16_1='$a16_1[$i]',a16_2='$a16_2[$i]',a16_3='$a16_3[$i]',a16_4='$a16_4[$i]',a16_5='$a16_5[$i]',a16_6='$a16_6[$i]',a16_7='$a16_7[$i]',a16_8='$a16_8[$i]',a16_9='$a16_9[$i]',a16_10='$a16_10[$i]',a16_10_1='$a16_10_1[$i]',a17_1='$a17_1[$i]',a17_2='$a17_2[$i]',a17_3_1='$a17_3_1[$i]',a17_3_2='$a17_3_2[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
//	echo$query."<br>";
	$mysqli->query($query);
}

$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 1 5/5')";
$result_log=$mysqli->query($log);

$query_up1="update survey_staff set ch1_sp='".date("U")."' where  HC='$HC' and survey_year='$survey_year' and survey_no='$survey_no'";
$result_up1=$mysqli->query($query_up1);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveyb1'
</script>*/