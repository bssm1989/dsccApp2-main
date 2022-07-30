using FirstBlazorApp.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static FirstBlazorApp.Pages.Surveypageone;

namespace FirstBlazorApp.Pages
{
	public partial class Surveya1 : ComponentBase
	{

		[Parameter]
		public string HC { get; set; }
string complete = "";
		List<survey_a1> recordSurveya1 = new List<survey_a1>();
		List<bool> checked1 = new List<bool>();
		List<string> checkedTitle = new List<string>();
		/// <summary>
        /// public MultiSelectList recordDel { get; set; } = null;
        /// </summary>
		List<survey_profile> survey_Profiles = new List<survey_profile>();
		List<survey_a1> survey_A1s = new List<survey_a1>();
		public class modelSurA1
		{
			public survey_a1 survey_A1{ get; set; }
			public bool del {  get; set; }
			public string title { get; set; }
			public string HC { get; set; }
			public string index { get; set; }
		}
		List<modelSurA1> listMoSurA1=new List<modelSurA1>();
		protected override async Task OnInitializedAsync()
		{
			await DBContext.OpenIndexedDb();
			survey_Profiles = await DBContext.GetByIndex<string, survey_profile>("survey_profile",  HC, null, "hc", false);
			List<survey_a1> checkCutList=new List<survey_a1>();
			if (survey_Profiles.Count >0)
			{
				//var getAllSurveya1 = await DBContext.GetByIndex<string, survey_a1>("survey_a1", survey_Profiles.First().HC, null, "hc", false);
				var getAllSurveya1 = await DBContext.GetAll< survey_a1>("survey_a1");

				var getListByHc=getAllSurveya1.Where(x=>x.HC.Contains(HC)).ToList();	
				var surProFirst = survey_Profiles.First();
				if (getListByHc.Count < Convert.ToInt32(surProFirst.NO1) + Convert.ToInt32(surProFirst.NO4))
					for (int i = 1; i <= Convert.ToInt32(surProFirst.NO1) + Convert.ToInt32(surProFirst.NO4); i++)
					{
						if (getAllSurveya1.Count != 0)
						{

							 checkCutList = getListByHc.Where(x=>x.id==i).ToList();
							if(checkCutList.Count <1)

                            {
								await DBContext.AddItems<survey_a1>("survey_a1", new List<survey_a1>(){
								new survey_a1()
								{

									HC=configSurvey.survey_no(HC,i),
									id=i,
										survey_no =configSurvey.survey_no(HC,i),
									survey_year = configSurvey.survey_year
								}
										});
								await DBContext.AddItems<survey_a2>("survey_a2",
								new List<survey_a2>(){
									new survey_a2()
											{

												HC=configSurvey.survey_no(HC,i),
													survey_no =configSurvey.survey_no_num,
												survey_year = configSurvey.survey_year
											}
										});
							}
						
						}
						else
						{
							await DBContext.AddItems<survey_a1>("survey_a1", new List<survey_a1>(){
									new survey_a1()
									{

										HC=configSurvey.survey_no(HC,i),
										id=i,
											survey_no =configSurvey.survey_no(HC,i),
										survey_year = configSurvey.survey_year
									}
										});
							await DBContext.AddItems<survey_a2>("survey_a2", 
								new List<survey_a2>(){
									new survey_a2()
											{

												HC=configSurvey.survey_no(HC,i),
													survey_no =configSurvey.survey_no_num,
												survey_year = configSurvey.survey_year
											}
										});
						}

					
					}
				getAllSurveya1 = await DBContext.GetAll<survey_a1>("survey_a1");

				getListByHc = getAllSurveya1.Where(x => x.HC.Contains(HC)).ToList();


				//survey_A1s = await DBContext.GetByIndex<string, survey_a1>("survey_a1", survey_Profiles.First().HC, null, "hc", false);
				int index = 0;
				foreach (var item in getListByHc)
                {
					index++;
					listMoSurA1.Add(new modelSurA1
					{
						survey_A1 = item,
						del = false,
						title = "ลบ คนที่" + index
					}); 

                }
			}
			//	_ = survey_A1s.in;

			//survey_profile = await DBContext.GetAll<survey_profile>("survey_profile");
			//provinces1 = await DBContext.GetAll<province>("province");
		}
		public async Task delAllsurveyA1()
		{

			await DBContext.OpenIndexedDb();
			survey_A1s = await DBContext.GetByIndex<string, survey_a1>("survey_a1", HC, null, "hc", false);
            foreach (var item in survey_A1s)
            {

			await DBContext.DeleteByKey<int>("survey_a1",item.id);
            }
		}
		protected async Task HandleValidSubmit(EditContext context)
		{
			await DBContext.OpenIndexedDb();
			int i = 0;
			foreach (var item in listMoSurA1)
			{ i++;
                if (item.del)
                {
				await DBContext.DeleteByKey<string>("survey_a1", item.survey_A1.HC);
				await DBContext.DeleteByKey<string>("survey_a2", item.survey_A1.HC);

                }
                else
                {
					await DBContext.UpdateItems<survey_a1>("survey_a1", new List<survey_a1>() { item.survey_A1 });
					//			$mysqli->//	1		$query1="insert into survey_a1(HC,survey_year,survey_no,a1,a2,popid,a3,a4,a5,a6,a2_b) values('$HC','$survey_year','$survey_no','$a1[$i]','$a2[$i]','$popid[$i]','$a3[$i]','$a4[$i]','$a5[$i]','$a6[$i]','$a2_b[$i]');";
					//			$mysqli->query($query1);
					////echo$query1."<br>";

					//		2	$query1="insert into survey_a2(HC,survey_year,survey_no,a1,a5) values('$HC','$survey_year','$survey_no','$a1[$i]','$a5[$i]');";
					//			$mysqli->query($query1);
					
					await DBContext.UpdateItems<survey_a2>("survey_a2", new List<survey_a2>() {
						new survey_a2{
							HC=configSurvey.survey_no(HC,i),
							survey_year=configSurvey.survey_year,
							survey_no=configSurvey.survey_no_num,
							a1=item.survey_A1.a1,
							a5=item.survey_A1.a5
						} }) ;

			//		3	$query1="update survey_a1 set a2='$a2[$i]',popid='$popid[$i]',a3='$a3[$i]',a4='$a4[$i]',a5='$a5[$i]',a6='$a6[$i]',a2_b='$a2_b[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
			//			$mysqli->query($query1);

			//		4	$query1="update survey_a2 set a5='$a5[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
			//			$mysqli->query($query1);

                }
			}
			//for($i=1;$i<=$count;$i++){
			//	if($del[$i]){//if($del[$i]){
			//	1	$query="delete from survey_a1 where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
			//		$result=$mysqli->query($query);

			//	2	$query="delete from survey_a2 where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
			//		$result=$mysqli->query($query);
			//	}else{//if($del[$i]){
			//		if($a2[$i]){//if($a1[$i]){
			//	1		$query1="insert into survey_a1(HC,survey_year,survey_no,a1,a2,popid,a3,a4,a5,a6,a2_b) values('$HC','$survey_year','$survey_no','$a1[$i]','$a2[$i]','$popid[$i]','$a3[$i]','$a4[$i]','$a5[$i]','$a6[$i]','$a2_b[$i]');";
			//			$mysqli->query($query1);
			////echo$query1."<br>";

			//		2	$query1="insert into survey_a2(HC,survey_year,survey_no,a1,a5) values('$HC','$survey_year','$survey_no','$a1[$i]','$a5[$i]');";
			//			$mysqli->query($query1);


			//		3	$query1="update survey_a1 set a2='$a2[$i]',popid='$popid[$i]',a3='$a3[$i]',a4='$a4[$i]',a5='$a5[$i]',a6='$a6[$i]',a2_b='$a2_b[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
			//			$mysqli->query($query1);

			//		4	$query1="update survey_a2 set a5='$a5[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";

			////echo$query1."<br>";
			//		}
			//	}//if($del[$i]){
			//}
			//_ = survey_A1s;
			//NavigationManager.NavigateTo("index2");

			//$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 1 1/5')";
			await DBContext.AddItems<log_file>("log_file", new List<log_file> {
					new log_file {
						id=Convert.ToInt32(configSurvey.randomNum()),
						username= await JSRuntime.InvokeAsync<string>("localStorage.getItem", "name"),
						time1=configSurvey.timestam(),
						detail="แก้ไข "+HC+" ตอนที่ 1 1/5"
						} });
			complete = "เรียบร้อย";
			//$result_log=$mysqli->query($log);

			//$log="insert into update_hc ( HC) values('$HC')";
			//$result_log=$mysqli->query($log);

			//$query_up="select ch1 from survey_staff where  HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";



			//$result_up=$mysqli->query($query_up);
			//if($result_up->ch1){
			//	$query_up1="update survey_staff set ch1_st='".date("U")."' where  HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
			//	$result_up1=$mysqli->query($query_up1);
			//}
		}
		private async Task gotoPage(string HC_nextPage)
		{
			NavigationManager.NavigateTo("/surveya2/" + HC_nextPage);

		}

	}
	
}
/*<?php
session_start();
error_reporting(E_ALL & ~E_DEPRECATED & ~E_STRICT & ~E_NOTICE &  ~E_WARNING);
//phpinfo();
require_once ("config.php");
require_once ("function.php");
$next=str_replace("'","\'",$_POST["next"]);
$username=$_COOKIE[username_log];

if($next){
$mysqli=mcon($mysql["host"], $mysql["user"], $mysql["pass"], $mysql["dbname"],$mysql["charset"]);

$a1=$_POST[a1];
$a2=$_POST[a2];
$a2_b=$_POST[date1];
$popid=$_POST[popid];
$a3=$_POST[a3];
$a4=$_POST[a4];
$a5=$_POST[a5];
$a6=$_POST[a6];
$HC=$_SESSION[HC];
$del=$_POST[del];

if(!$_SESSION["HC"]){
?>
<script>
location='https://livingonnewpace.com/survey/index.php?curr=survey_profile';
</script>*/
/*<?php
	exit();
}

$count=count($a1);


exec("/usr/bin/wget -O /dev/null  https://livingonnewpace.com/survey/hc_sum/hc_sum_real.php?HC=$HC;");
//exit();


$mysqli->close();
}
?>
<script>
	location='index.php?curr=surveya2'
</script>*/