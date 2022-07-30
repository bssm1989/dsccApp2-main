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

$a14=$_POST[a14];
$a15_0=$_POST[a15_0];
$a15_0_1=$_POST[a15_0_1];
$a15_0_1_1=$_POST[a15_0_1_1];
$a15_0_1_2=$_POST[a15_0_1_2];
$a15_0_1_3=$_POST[a15_0_1_3];
$a15_0_1_4=$_POST[a15_0_1_4];
$a15_0_1_5=$_POST[a15_0_1_5];
$a15_0_1_6=$_POST[a15_0_1_6];
$a15_0_1_7=$_POST[a15_0_1_7];
$a15_0_1_7_1=$_POST[a15_0_1_7_1];
$a15_0_2=$_POST[a15_0_2];
$a15_0_2_1=$_POST[a15_0_2_1];
$a15_0_2_2=$_POST[a15_0_2_2];
$a15_0_2_3=$_POST[a15_0_2_3];
$a15_0_2_4=$_POST[a15_0_2_4];
$a15_0_2_5=$_POST[a15_0_2_5];
$a15_0_2_6=$_POST[a15_0_2_6];
$a15_0_2_7=$_POST[a15_0_2_7];
$a15_0_2_7_1=$_POST[a15_0_2_7_1];
$a15_1=$_POST[a15_1];
$a15_2=$_POST[a15_2];
$a15_3=$_POST[a15_3];
$a15_4=$_POST[a15_4];
$a15_5=$_POST[a15_5];
$a15_6=$_POST[a15_6];
$a15_7=$_POST[a15_7];
$a15_8=$_POST[a15_8];
$a15_9=$_POST[a15_9];
$a15_10=$_POST[a15_10];
$a15_10_1=$_POST[a15_10_1];

if(!$_SESSION["HC"]){
?>
<script>
location='https://livingonnewpace.com/survey/index.php?curr=survey_profile';
</script>*/
/*<?php
	exit();
}
*/


using FirstBlazorApp.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static FirstBlazorApp.Pages.Surveypageone;

namespace FirstBlazorApp.Pages
{
	public partial class Surveya4 : ComponentBase
	{
		[Parameter]
		public string HC { get; set; }
string complete = "";
		List<survey_a1> recordSurveya1 = new List<survey_a1>();
		List<bool> checked1 = new List<bool>();
		List<string> checkedTitle = new List<string>();
		//public MultiSelectList recordDel { get; set; } = null;
		List<survey_profile> survey_Profiles = new List<survey_profile>();
		List<survey_a2> survey_A1s = new List<survey_a2>();
		public class modelSurA2
		{
			public survey_a2 survey_A1 { get; set; }
			public survey_a1 survey_A1_2 { get; set; }
			public string HC_NO_YEAR { get; set; }
			public bool del { get; set; }
			public string title { get; set; }
			public checkSurveya2 checkSurveya2 { get; set; }
		}
		public class checkSurveya2
		{
			public bool a14 { get; set; }
			public bool a15_0  { get; set; }
			public bool a15_0_1  { get; set; }
			public bool a15_0_1_1  { get; set; }
			public bool a15_0_1_2  { get; set; }
			public bool a15_0_1_3  { get; set; }
			public bool a15_0_1_4  { get; set; }
			public bool a15_0_1_5  { get; set; }
			public bool a15_0_1_6  { get; set; }
			public bool a15_0_1_7  { get; set; }
			public bool a15_0_2  { get; set; }
			public bool a15_0_2_1  { get; set; }
			public bool a15_0_2_2  { get; set; }
			public bool a15_0_2_3  { get; set; }
			public bool a15_0_2_4  { get; set; }
			public bool a15_0_2_5  { get; set; }
			public bool a15_0_2_6  { get; set; }
			public bool a15_0_2_7  { get; set; }
			public bool a15_1  { get; set; }
			public bool a15_2  { get; set; }
			public bool a15_3  { get; set; }
			public bool a15_4  { get; set; }
			public bool a15_5  { get; set; }
			public bool a15_6  { get; set; }
			public bool a15_7  { get; set; }
			public bool a15_8 { get; set; }
			public bool a15_9 { get; set; }
			public bool a15_10 { get; set; }
			public bool	 a14_1_1_1 { get; set; }
			public bool	 a14_1_1_2 { get; set; }
			public bool	 a14_1_1_3 { get; set; }
			public bool	 a14_1_1_4 { get; set; }
			public bool	 a14_1_1_5 { get; set; }
			public bool	 a14_1_1_6 { get; set; }
			public bool	 a14_1_1_7{ get; set; }
			public bool	 a14_1_2_1 { get; set; }
			public bool	 a14_1_2_2 { get; set; }
			public bool	 a14_1_2_3 { get; set; }
			public bool	 a14_1_2_4 { get; set; }
			public bool	 a14_1_2_5 { get; set; }
			public bool a14_1_2_6 { get; set; }
			public bool a14_1_2_7 { get; set; }



		}




		List<modelSurA2> listMoSurA2 = new List<modelSurA2>();
		List<modelSurA2> modelSurA2sByHc = new List<modelSurA2>();
		protected override async Task OnInitializedAsync()
		{
			await DBContext.OpenIndexedDb();

			var getallsurveya1 = await DBContext.GetAll<survey_a2>("survey_a2");
			var getallsurveya1_1 = await DBContext.GetAll<survey_a1>("survey_a1");
			List<survey_a2> querySurveya1 = new List<survey_a2>();
			int index_1=0;
			foreach (var item in getallsurveya1)
			{

				var hc_no_year = item.HC.Split('|');
				listMoSurA2.Add(new modelSurA2
				{
					survey_A1 = item,
					HC_NO_YEAR = hc_no_year[0] + "|" + hc_no_year[1] + "|" + hc_no_year[2],
					survey_A1_2 = getallsurveya1_1.ElementAt(index_1)
				}) ;
				index_1++;
			}
			
			var hc_year_no = configSurvey.HC_noId(HC);
			int index = 0;
			modelSurA2sByHc = listMoSurA2.Where(x => x.HC_NO_YEAR == hc_year_no).OrderBy(x => x.survey_A1.HC).ToList();

			foreach (var item in modelSurA2sByHc)
			{
				modelSurA2sByHc.ElementAt(index).checkSurveya2 = new checkSurveya2();
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0 = String.IsNullOrEmpty(item.survey_A1.a15_0) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_1 = String.IsNullOrEmpty(item.survey_A1.a15_0_1) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_1_1 = String.IsNullOrEmpty(item.survey_A1.a15_0_1_1) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_1_2 = String.IsNullOrEmpty(item.survey_A1.a15_0_1_2) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_1_3 = String.IsNullOrEmpty(item.survey_A1.a15_0_1_3) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_1_4 = String.IsNullOrEmpty(item.survey_A1.a15_0_1_4) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_1_5 = String.IsNullOrEmpty(item.survey_A1.a15_0_1_5) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_1_6 = String.IsNullOrEmpty(item.survey_A1.a15_0_1_6) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_1_7 = String.IsNullOrEmpty(item.survey_A1.a15_0_1_7) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_2 = String.IsNullOrEmpty(item.survey_A1.a15_0_2) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_2_1 = String.IsNullOrEmpty(item.survey_A1.a15_0_2_1) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_2_2 = String.IsNullOrEmpty(item.survey_A1.a15_0_2_2) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_2_3 = String.IsNullOrEmpty(item.survey_A1.a15_0_2_3) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_2_4 = String.IsNullOrEmpty(item.survey_A1.a15_0_2_4) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_2_5 = String.IsNullOrEmpty(item.survey_A1.a15_0_2_5) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_2_6 = String.IsNullOrEmpty(item.survey_A1.a15_0_2_6) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_2_7 = String.IsNullOrEmpty(item.survey_A1.a15_0_2_7) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_1 = item.survey_A1.a15_1==null|| item.survey_A1.a15_1<01 ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_2 = String.IsNullOrEmpty(item.survey_A1.a15_2) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_3 = String.IsNullOrEmpty(item.survey_A1.a15_3) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_4 = String.IsNullOrEmpty(item.survey_A1.a15_4) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_5 = String.IsNullOrEmpty(item.survey_A1.a15_5) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_6 = String.IsNullOrEmpty(item.survey_A1.a15_6) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_7 = String.IsNullOrEmpty(item.survey_A1.a15_7) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_8 = String.IsNullOrEmpty(item.survey_A1.a15_8) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_9 = String.IsNullOrEmpty(item.survey_A1.a15_9) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_10 = String.IsNullOrEmpty(item.survey_A1.a15_10) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_1_1 = String.IsNullOrEmpty(item.survey_A1.a14_1_1_1) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_1_2 = String.IsNullOrEmpty(item.survey_A1.a14_1_1_2) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_1_3 = String.IsNullOrEmpty(item.survey_A1.a14_1_1_3) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_1_4 = String.IsNullOrEmpty(item.survey_A1.a14_1_1_4) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_1_5 = String.IsNullOrEmpty(item.survey_A1.a14_1_1_5) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_1_6 = String.IsNullOrEmpty(item.survey_A1.a14_1_1_6) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_1_7 = String.IsNullOrEmpty(item.survey_A1.a14_1_1_7) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_2_1 = String.IsNullOrEmpty(item.survey_A1.a14_1_2_1) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_2_2 = String.IsNullOrEmpty(item.survey_A1.a14_1_2_2) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_2_3 = String.IsNullOrEmpty(item.survey_A1.a14_1_2_3) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_2_4 = String.IsNullOrEmpty(item.survey_A1.a14_1_2_4) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_2_5 = String.IsNullOrEmpty(item.survey_A1.a14_1_2_5) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_2_6 = String.IsNullOrEmpty(item.survey_A1.a14_1_2_6) ? false : true;
				modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_2_7 = String.IsNullOrEmpty(item.survey_A1.a14_1_2_7) ? false : true;
				index++;


			}
		}
		protected async Task HandleValidSubmit(EditContext context)
		{
			int index = 0;
			//$query="update survey_a1 set a7_0='$a7_0[$i]',a7_1='$a7_1[$i]',a7_1_1='$a7_1_1[$i]',a7_1_2='$a7_1_2[$i]',a7_2='$a7_2[$i]',a7_2_1='$a7_2_1[$i]',a7_2_2='$a7_2_2[$i]',a7_3='$a7_3[$i]',a7_3_1='$a7_3_1[$i]',a7_3_2='$a7_3_2[$i]',a7_4='$a7_4[$i]',a7_4_1='$a7_4_1[$i]',a7_4_2='$a7_4_2[$i]',a7_5='$a7_5[$i]',a7_5_1='$a7_5_1[$i]',a7_5_2='$a7_5_2[$i]',a7_6='$a7_6[$i]',a7_6_1='$a7_6_1[$i]',a7_6_2='$a7_6_2[$i]',a7_7='$a7_7[$i]',a7_7_1='$a7_7_1[$i]',a7_7_2='$a7_7_2[$i]',a7_8='$a7_8[$i]',a7_8_1='$a7_8_1[$i]',a7_8_2='$a7_8_2[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
			foreach (var item in modelSurA2sByHc)
			{
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_0			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0			? "0" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_0_1		 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_1		? "1" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_0_1_1		 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_1_1		? "1" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_0_1_2		 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_1_2		? "2" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_0_1_3		 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_1_3		? "3" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_0_1_4		 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_1_4		? "4" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_0_1_5		 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_1_5		? "5" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_0_1_6		 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_1_6		? "6" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_0_1_7		 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_1_7		? "7" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_0_2		 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_2		? "2" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_0_2_1		 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_2_1		? "1" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_0_2_2		 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_2_2		? "2" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_0_2_3		 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_2_3		? "3" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_0_2_4		 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_2_4		? "4" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_0_2_5		 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_2_5		? "5" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_0_2_6		 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_2_6		? "6" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_0_2_7		 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_0_2_7		? "7" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_1			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_1			? 1 : 0;
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_2			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_2			? "2" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_3			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_3			? "3" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_4			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_4			? "4" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_5			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_5			? "5" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_6			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_6			? "6" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_7			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_7			? "7" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_8			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_8			? "8" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_9			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_9			? "9" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a15_10			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a15_10			? "10" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a14_1_1_1			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_1_1			? "1" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a14_1_1_2			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_1_2			? "2" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a14_1_1_3			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_1_3			? "3" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a14_1_1_4			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_1_4			? "4" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a14_1_1_5			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_1_5			? "5" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a14_1_1_6			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_1_6			? "6" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a14_1_1_7			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_1_7			 ? "7" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a14_1_2_1			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_2_1			? "1" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a14_1_2_2			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_2_2			? "2" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a14_1_2_3			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_2_3			? "3" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a14_1_2_4			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_2_4			? "4" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a14_1_2_5			 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_2_5			? "5" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.a14_1_2_6				= modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_2_6		?"6" : ""; 
				modelSurA2sByHc.ElementAt(index).survey_A1.a14_1_2_7				= modelSurA2sByHc.ElementAt(index).checkSurveya2.a14_1_2_7		?"7" : ""; 
				//modelSurA2sByHc.ElementAt(index).survey_A1.a7_6 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a7_6"_" ?: "";
				await DBContext.UpdateItems<survey_a2>("survey_a2",
					new List<survey_a2>() { modelSurA2sByHc.ElementAt(index).survey_A1 });
				index++;
			}
			//$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 1 2/5')";
			await DBContext.AddItems<log_file>("log_file", new List<log_file> {
					new log_file {
						id=Convert.ToInt32(configSurvey.randomNum()),
						username= await JSRuntime.InvokeAsync<string>("localStorage.getItem", "name"),
						time1=configSurvey.timestam(),
						detail="แก้ไข $HC ตอนที่ 1 4/5')"
						} });
			complete = "เรียบร้อย";
			StateHasChanged();
		}
		private async Task gotoPage(string HC_nextPage)
		{
			NavigationManager.NavigateTo("/surveya5/" + HC_nextPage);
		}
	}
}

/*

$count=count($a1);
for($i=1;$i<=$count;$i++){//for($i=1;$i<=$count;$i++){
	$query="insert into survey_a2 (HC,survey_year,survey_no,a1,a14,a15_0,a15_0_1,a15_0_1_1,a15_0_1_2,a15_0_1_3,a15_0_1_4,a15_0_1_5,a15_0_1_6,a15_0_1_7,a15_0_1_7_1,a15_0_2,a15_0_2_1,a15_0_2_2,a15_0_2_3,a15_0_2_4,a15_0_2_5,a15_0_2_6,a15_0_2_7,a15_0_2_7_1,a15_1,a15_2,a15_3,a15_4,a15_5,a15_6,a15_7,a15_8,a15_9,a15_10,a15_10_1) values('$HC','$survey_year','$survey_no','$a1[$i]','$a14[$i]','$a15_0[$i]','$a15_0_1[$i]','$a15_0_1_1[$i]','$a15_0_1_2[$i]','$a15_0_1_3[$i]','$a15_0_1_4[$i]','$a15_0_1_5[$i]','$a15_0_1_6[$i]','$a15_0_1_7[$i]','$a15_0_1_7_1[$i]','$a15_0_2[$i]','$a15_0_2_1[$i]','$a15_0_2_2[$i]','$a15_0_2_3[$i]','$a15_0_2_4[$i]','$a15_0_2_5[$i]','$a15_0_2_6[$i]','$a15_0_2_7[$i]','$a15_0_2_7_1[$i]','$a15_1[$i]','$a15_2[$i]','$a15_3[$i]','$a15_4[$i]','$a15_5[$i]','$a15_6[$i]','$a15_7[$i]','$a15_8[$i]','$a15_9[$i]','$a15_10[$i]','$a15_10_1[$i]')";
//echo$query."<br>";
	$mysqli->query($query);
	
	$query="update survey_a2 set a14='$a14[$i]',a15_0='$a15_0[$i]',a15_0_1='$a15_0_1[$i]',a15_0_1_1='$a15_0_1_1[$i]',a15_0_1_2='$a15_0_1_2[$i]',a15_0_1_3='$a15_0_1_3[$i]',a15_0_1_4='$a15_0_1_4[$i]',a15_0_1_5='$a15_0_1_5[$i]',a15_0_1_6='$a15_0_1_6[$i]',a15_0_1_7='$a15_0_1_7[$i]',a15_0_1_7_1='$a15_0_1_7_1[$i]',a15_0_2='$a15_0_2[$i]',a15_0_2_1='$a15_0_2_1[$i]',a15_0_2_2='$a15_0_2_2[$i]',a15_0_2_3='$a15_0_2_3[$i]',a15_0_2_4='$a15_0_2_4[$i]',a15_0_2_5='$a15_0_2_5[$i]',a15_0_2_6='$a15_0_2_6[$i]',a15_0_2_7='$a15_0_2_7[$i]',a15_0_2_7_1='$a15_0_2_7_1[$i]',a15_1='$a15_1[$i]',a15_2='$a15_2[$i]',a15_3='$a15_3[$i]',a15_4='$a15_4[$i]',a15_5='$a15_5[$i]',a15_6='$a15_6[$i]',a15_7='$a15_7[$i]',a15_8='$a15_8[$i]',a15_9='$a15_9[$i]',a15_10='$a15_10[$i]',a15_10_1='$a15_10_1[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
	$mysqli->query($query);
//echo$query."<br>";
	$mysqli->query($query);
}

$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 1 4/5')";
$result_log=$mysqli->query($log);

$log="insert into update_hc ( HC) values('$HC')";
$result_log=$mysqli->query($log);
exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveya5'
</script>*/