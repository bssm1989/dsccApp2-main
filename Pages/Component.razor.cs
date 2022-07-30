
using FirstBlazorApp.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using static FirstBlazorApp.Pages.Surveypageone;
using static FirstBlazorApp.Pages.Surveya5;

namespace FirstBlazorApp.Pages
{
	public partial class Component : ComponentBase
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
			public survey_b1 survey_A1 { get; set; }

			public checkSurveya2 checkSurveya2 { get; set; }
		}
		public class checkSurveya2
		{

			public bool b7_2_1 { get; set; }
			public bool b7_2_2 { get; set; }
			public bool b7_3_1 { get; set; }
			public bool b7_3_2 { get; set; }
			public bool b2_4_1 { get; set; }
			public bool b2_4_2 { get; set; }
			public bool b2_4_3 { get; set; }
			public bool b2_4_4 { get; set; }
			//public bool a16_8 { get; set; }
			//public bool a16_9 { get; set; }
			//public bool a16_10 { get; set; }


		}
		public survey_b1 survey_b1_1 { get; set; }
		checkSurveya2 checkSurveya3 = new checkSurveya2();
		// when there are chec
		modelSurA2 surveyb1 = new modelSurA2();

		List<modelSurA2> listMoSurA2 = new List<modelSurA2>();
		List<modelSurA2> modelSurA2sByHc = new List<modelSurA2>();
		protected override async Task OnInitializedAsync()
		{
			await DBContext.OpenIndexedDb();

			var getallsurveya1 = await DBContext.GetAll<survey_b1>("survey_b1");
			//var getallsurveya1_1 = await DBContext.GetAll<survey_a1>("survey_a1");

			var hc_year_no = configSurvey.HC_noId(HC);

			if (getallsurveya1 == null)
			{
				surveyb1.survey_A1 = new survey_b1();


			}
			else if (getallsurveya1.Where(x => x.HC == hc_year_no).Count() > 0)
			{

				surveyb1.survey_A1 = getallsurveya1.Where(x => x.HC == hc_year_no).First();
			}
			else
			{
				surveyb1.survey_A1 = new survey_b1();
			}





			surveyb1.checkSurveya2 = new checkSurveya2();
			surveyb1.checkSurveya2.b7_2_1 = String.IsNullOrEmpty(surveyb1.survey_A1.b7_2_1) ? false : true;
			surveyb1.checkSurveya2.b7_2_2 = String.IsNullOrEmpty(surveyb1.survey_A1.b7_2_2) ? false : true;
			surveyb1.checkSurveya2.b7_3_1 = String.IsNullOrEmpty(surveyb1.survey_A1.b7_3_1) ? false : true;
			surveyb1.checkSurveya2.b7_3_2 = String.IsNullOrEmpty(surveyb1.survey_A1.b7_3_2) ? false : true;
			surveyb1.checkSurveya2.b2_4_1 = String.IsNullOrEmpty(surveyb1.survey_A1.b2_4_1) ? false : true;
			surveyb1.checkSurveya2.b2_4_2 = String.IsNullOrEmpty(surveyb1.survey_A1.b2_4_2) ? false : true;
			surveyb1.checkSurveya2.b2_4_3 = String.IsNullOrEmpty(surveyb1.survey_A1.b2_4_3) ? false : true;
			surveyb1.checkSurveya2.b2_4_4 = String.IsNullOrEmpty(surveyb1.survey_A1.b2_4_4) ? false : true;
			//surveyb1.checkSurveya2.b2_4_4 = String.IsNullOrEmpty(surveyb1.b2_4_4) ? false : true;
			surveyb1.survey_A1.b1_1 = "";
			surveyb1.survey_A1.b1_2 = "";




		}
		protected async Task HandleValidSubmit(EditContext context)
		{
			int index = 0;
			//$query="update survey_a1 set a7_0='$a7_0[$i]',a7_1='$a7_1[$i]',a7_1_1='$a7_1_1[$i]',a7_1_2='$a7_1_2[$i]',a7_2='$a7_2[$i]',a7_2_1='$a7_2_1[$i]',a7_2_2='$a7_2_2[$i]',a7_3='$a7_3[$i]',a7_3_1='$a7_3_1[$i]',a7_3_2='$a7_3_2[$i]',a7_4='$a7_4[$i]',a7_4_1='$a7_4_1[$i]',a7_4_2='$a7_4_2[$i]',a7_5='$a7_5[$i]',a7_5_1='$a7_5_1[$i]',a7_5_2='$a7_5_2[$i]',a7_6='$a7_6[$i]',a7_6_1='$a7_6_1[$i]',a7_6_2='$a7_6_2[$i]',a7_7='$a7_7[$i]',a7_7_1='$a7_7_1[$i]',a7_7_2='$a7_7_2[$i]',a7_8='$a7_8[$i]',a7_8_1='$a7_8_1[$i]',a7_8_2='$a7_8_2[$i]' where HC='$HC' and a1='$a1[$i]' and survey_year='$survey_year' and survey_no='$survey_no'";
			foreach (var item in modelSurA2sByHc)
			{
				modelSurA2sByHc.ElementAt(index).survey_A1.b7_2_1 = modelSurA2sByHc.ElementAt(index).checkSurveya2.b7_2_1 ? "0" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.b7_2_2 = modelSurA2sByHc.ElementAt(index).checkSurveya2.b7_2_2 ? "1" : "0";
				modelSurA2sByHc.ElementAt(index).survey_A1.b7_3_1 = modelSurA2sByHc.ElementAt(index).checkSurveya2.b7_3_1 ? "2" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.b7_3_2 = modelSurA2sByHc.ElementAt(index).checkSurveya2.b7_3_2 ? "3" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.b2_4_1 = modelSurA2sByHc.ElementAt(index).checkSurveya2.b2_4_1 ? "4" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.b2_4_2 = modelSurA2sByHc.ElementAt(index).checkSurveya2.b2_4_2 ? "5" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.b2_4_3 = modelSurA2sByHc.ElementAt(index).checkSurveya2.b2_4_3 ? "6" : "";
				modelSurA2sByHc.ElementAt(index).survey_A1.b2_4_4 = modelSurA2sByHc.ElementAt(index).checkSurveya2.b2_4_4 ? "7" : "";
				//modelSurA2sByHc.ElementAt(index).survey_A1.		  = modelSurA2sByHc.ElementAt(index).checkSurveya2.a16_8 ? "8" : "";
				//modelSurA2sByHc.ElementAt(index).survey_A1.a16_9 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a16_9 ? "9" : "";
				//modelSurA2sByHc.ElementAt(index).survey_A1.a16_10 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a16_10 ? "10" : "";
				//modelSurA2sByHc.ElementAt(index).survey_A1.a7_6 = modelSurA2sByHc.ElementAt(index).checkSurveya2.a7_6"_" ?: "";
				await DBContext.UpdateItems<survey_b1>("survey_b1",
					new List<survey_b1>() { modelSurA2sByHc.ElementAt(index).survey_A1 });
				index++;
			}
			//$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','แก้ไข $HC ตอนที่ 1 2/5')";
			//await DBContext.AddItems<log_file>("log_file", new List<log_file> {
			//		new log_file {
			//			id=Convert.ToInt32(configSurvey.randomNum()),
			//			username= await JSRuntime.InvokeAsync<string>("localStorage.getItem", "name"),
			//			time1=configSurvey.timestam(),
			//			detail="แก้ไข $HC ตอนที่  5/5')"
			//			} });
			StateHasChanged();
		}
		private async Task gotoPage(string HC_nextPage)
		{
			NavigationManager.NavigateTo("/surveyb2/" + HC_nextPage);
		}
	}
}

