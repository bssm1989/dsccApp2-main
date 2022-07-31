using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DnetIndexedDb;
using DnetIndexedDb.Models;
using Microsoft.JSInterop;
//using static FirstBlazorApp.Models.compute_hc4;

namespace FirstBlazorApp.Models
{
    public class EmployeeOfflineDb : IndexedDbDatabaseModel
    {
        public EmployeeOfflineDb()
        {
            Name = "EmployeeData";
            Version =71;
            Stores = _stores;
        }
        private IndexedDbStore _tableFieldStore => new TStore<Employee>();
        private IndexedDbStore _tableFieldStore2 => new TStore<province>();
        private IndexedDbStore _tableFieldStore3 => new TStore<tambon>();
        private IndexedDbStore _tableFieldStore4 => new TStore<district>();
        private IndexedDbStore _tableFieldStore71 => new TStore<ch2_gis>();
        //private IndexedDbStore _tableFieldStore5 => new TStore<ch2_gis2>();
        //private IndexedDbStore _tableFieldStore6 => new TStore<compute_hc1>();
        //private IndexedDbStore _tableFieldStore7 => new TStore<compute_hc2>();
        //private IndexedDbStore _tableFieldStore8 => new TStore<compute_hc3>();
        //private IndexedDbStore _tableFieldStore9 => new TStore<compute_hc4>();
        //private IndexedDbStore _tableFieldStore11 => new TStore<employee>();
        //private IndexedDbStore _tableFieldStore12 => new TStore<hc_result>();
        //private IndexedDbStore _tableFieldStore13 => new TStore<hc_sum>();
        //private IndexedDbStore _tableFieldStore14 => new TStore<hc_sum1>();
        //private IndexedDbStore _tableFieldStore15 => new TStore<hc_sum2>();
        //private IndexedDbStore _tableFieldStore16 => new TStore<hc_sum3>();
        //private IndexedDbStore _tableFieldStore17 => new TStore<hc_sum4>();
        //private IndexedDbStore _tableFieldStore18 => new TStore<hc_sum5>();
        //private IndexedDbStore _tableFieldStore19 => new TStore<hc_sum6>();
        //private IndexedDbStore _tableFieldStore20 => new TStore<hc_sum_check1>();
        //private IndexedDbStore _tableFieldStore21 => new TStore<hc_sum_check2>();
        //private IndexedDbStore _tableFieldStore22 => new TStore<income>();
        //private IndexedDbStore _tableFieldStore23 => new TStore<income_edit>();
        //private IndexedDbStore _tableFieldStore24 => new TStore<income_eef>();
        //private IndexedDbStore _tableFieldStore25 => new TStore<insert_hc>();
        //private IndexedDbStore _tableFieldStore26 => new TStore<jun_finish>();
        //private IndexedDbStore _tableFieldStore27 => new TStore<jun_level_detail>();
        //private IndexedDbStore _tableFieldStore28 => new TStore<jun_location>();
        //private IndexedDbStore _tableFieldStore29 => new TStore<line_poor_rich>();
        //private IndexedDbStore _tableFieldStore30 => new TStore<livingon_tpmap>();
        //private IndexedDbStore _tableFieldStore31 => new TStore<livingon_tpmap2>();
        //private IndexedDbStore _tableFieldStore32 => new TStore<livingon_tpmap3>();
        //private IndexedDbStore _tableFieldStore33 => new TStore<livingon_tpmap4>();
        private IndexedDbStore _tableFieldStore34 => new TStore<log_file>();
        //private IndexedDbStore _tableFieldStore35 => new TStore<log_file_2>();
        //private IndexedDbStore _tableFieldStore36 => new TStore<mm>();
        //private IndexedDbStore _tableFieldStore37 => new TStore<poverty>();
        //private IndexedDbStore _tableFieldStore38 => new TStore<poverty_pattani>();
        private IndexedDbStore _tableFieldStore39 => new TStore<province>();
        //private IndexedDbStore _tableFieldStore40 => new TStore<region>();
        //private IndexedDbStore _tableFieldStore41 => new TStore<snapshot>();
        //private IndexedDbStore _tableFieldStore42 => new TStore<staff_jun>();
        //private IndexedDbStore _tableFieldStore43 => new TStore<survey_a1>();
        //private IndexedDbStore _tableFieldStore44 => new TStore<survey_a2>();
        //private IndexedDbStore _tableFieldStore45 => new TStore<survey_b1>();
        //private IndexedDbStore _tableFieldStore46 => new TStore<survey_b2>();
        //private IndexedDbStore _tableFieldStore47 => new TStore<survey_b3>();
        //private IndexedDbStore _tableFieldStore48 => new TStore<survey_c1>();
        //private IndexedDbStore _tableFieldStore49 => new TStore<survey_c2>();
        //private IndexedDbStore _tableFieldStore50 => new TStore<survey_check>();
        //private IndexedDbStore _tableFieldStore51 => new TStore<survey_d1>();
        //private IndexedDbStore _tableFieldStore52 => new TStore<survey_d2>();
        //private IndexedDbStore _tableFieldStore53 => new TStore<survey_d3>();
        //private IndexedDbStore _tableFieldStore54 => new TStore<survey_e1>();
        //private IndexedDbStore _tableFieldStore55 => new TStore<survey_e2>();
        //private IndexedDbStore _tableFieldStore56 => new TStore<survey_e3>();
        //private IndexedDbStore _tableFieldStore57 => new TStore<survey_f1>();
        private IndexedDbStore _tableFieldStore58 => new TStore<survey_profile>();
        private IndexedDbStore _tableFieldStore59 => new TStore<survey_staff>();
        //private IndexedDbStore _tableFieldStore60 => new TStore<surwaya_tmp>();
        private IndexedDbStore _tableFieldStore61 => new TStore<tambon>();
        //private IndexedDbStore _tableFieldStore62 => new TStore<tasaban>();
        //private IndexedDbStore _tableFieldStore63 => new TStore<tpmap>();
        //private IndexedDbStore _tableFieldStore64 => new TStore<tpmap_pattani>();
        //private IndexedDbStore _tableFieldStore65 => new TStore<tpmap_pattani2>();
        //private IndexedDbStore _tableFieldStore66 => new TStore<t_tambon>();
        //private IndexedDbStore _tableFieldStore67 => new TStore<update_hc>();
        private IndexedDbStore _tableFieldStore68 => new TStore<upload_pic>();
        private IndexedDbStore _tableFieldStore69 => new TStore<users>();
        private IndexedDbStore _tableFieldStore70 => new TStore<volunteer>();

        //private IndexedDbStore _tableFieldStore72 => new TStore<survey_f>();
        private IndexedDbStore _tableFieldStore73 => new TStore<const_prenme>();

        private IndexedDbStore _tableFieldStore74 => new TStore<person>();
private IndexedDbStore _tableFieldStore76 => new TStore<const_currlev   >();
private IndexedDbStore _tableFieldStore77 => new TStore<const_disability_type>();
private IndexedDbStore _tableFieldStore78 => new TStore<const_edulev    >();
private IndexedDbStore _tableFieldStore79 => new TStore<const_elderly_grp>();
private IndexedDbStore _tableFieldStore80 => new TStore<const_house_conditions>();
private IndexedDbStore _tableFieldStore81 => new TStore<const_occ       >();
private IndexedDbStore _tableFieldStore82 => new TStore<const_pertyp    >();
private IndexedDbStore _tableFieldStore83 => new TStore<const_plc       >();
private IndexedDbStore _tableFieldStore84 => new TStore<const_plcnmegen >();
private IndexedDbStore _tableFieldStore86 => new TStore<const_reg       >();
private IndexedDbStore _tableFieldStore87 => new TStore<const_reltyp    >();
private IndexedDbStore _tableFieldStore88 => new TStore<const_school    >();
private IndexedDbStore _tableFieldStore89 => new TStore<const_sex       >();
private IndexedDbStore _tableFieldStore90 => new TStore<const_stsmar    >();
private IndexedDbStore _tableFieldStore91 => new TStore<const_vaccination>();
        private List<IndexedDbStore> _stores => new List<IndexedDbStore>
        {
            _tableFieldStore,_tableFieldStore2,_tableFieldStore4,_tableFieldStore3,
            //_tableFieldStore5,
            //_tableFieldStore6,_tableFieldStore7,_tableFieldStore8,_tableFieldStore9,_tableFieldStore11,
            //_tableFieldStore12,_tableFieldStore13,_tableFieldStore14,_tableFieldStore15,_tableFieldStore16,_tableFieldStore17,
            //_tableFieldStore18,_tableFieldStore19,_tableFieldStore20,_tableFieldStore21,_tableFieldStore22,_tableFieldStore23,
            //_tableFieldStore24,_tableFieldStore25,_tableFieldStore26,_tableFieldStore27,_tableFieldStore28,_tableFieldStore29,
            //_tableFieldStore30,_tableFieldStore31,_tableFieldStore32,_tableFieldStore33,
            _tableFieldStore34,
            //_tableFieldStore35,
            //_tableFieldStore36,_tableFieldStore37,_tableFieldStore38,_tableFieldStore40,_tableFieldStore41,
            //_tableFieldStore42,_tableFieldStore43,_tableFieldStore44,_tableFieldStore45,_tableFieldStore46,_tableFieldStore47,
            //_tableFieldStore48,_tableFieldStore49,_tableFieldStore50,_tableFieldStore51,_tableFieldStore52,_tableFieldStore53,
            //_tableFieldStore54,_tableFieldStore55,_tableFieldStore56,_tableFieldStore57,
            _tableFieldStore58,
            _tableFieldStore59,
            //_tableFieldStore60,_tableFieldStore62,_tableFieldStore63,_tableFieldStore64,_tableFieldStore65,
            //_tableFieldStore66,_tableFieldStore67,
            _tableFieldStore68,_tableFieldStore69,_tableFieldStore70,
            _tableFieldStore71,
            //_tableFieldStore72,
            _tableFieldStore73,_tableFieldStore74,_tableFieldStore76,
                                                  _tableFieldStore77,
                                                  _tableFieldStore78,
                                                  _tableFieldStore79,
                                                  _tableFieldStore80,
                                                  _tableFieldStore81,
                                                  _tableFieldStore82,
                                                  _tableFieldStore83,
                                                  _tableFieldStore84,
                                                  _tableFieldStore86,
                                                  _tableFieldStore87,
                                                  _tableFieldStore88,
                                                  _tableFieldStore89,
                                                  _tableFieldStore90,
                                                  _tableFieldStore91
        };
    
}

        public class Employee
    {
        [IndexDbKey(AutoIncrement = true)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Last Name cannot have less than 3 characters and more than 20 characters in length")]
        public string Fullname { get; set; }
        public string Email { get; set; }
        [Required]
        [MaxLength(12)]
        [MinLength(1)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "UPRN must be numeric")]
        public string MobileNumber { get; set; }
        public DateTime? localUpdate { get; set; }
        public DateTime? ServerUpdate { get; set; }
        public string STATUS { get; set; }
        public string User { get; set; }

    }



    public class EmployeeContext : IndexedDbInterop
    {
        
        public EmployeeContext(IJSRuntime jSRuntime, IndexedDbOptions<EmployeeContext> options) : base(jSRuntime, options) { }
        public async Task Add(Employee employee)
        {
            Random r = new Random();
            int num = r.Next();
            var openResult = await this.OpenIndexedDb();


            employee.Id = num;
            employee.localUpdate = DateTime.Now;
            //var idMa
            //x = employee.Max(x = x.id);
            _ = toServer(employee);
            var result = await this.AddItems<Employee>("Employee", new List<Employee>() { employee });
        }
        public async Task loadDbFromServer()
        {

            using (var httpClient = new HttpClient())
            {
                // StringContent content = new StringContent(JsonConvert.SerializeObject(employees), Encoding.UTF8, "application/json");



                var response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/index.php?table=district");

                var openResult = await this.OpenIndexedDb();
                var contents = await response.Content.ReadAsStringAsync();
                List<district> DeserializedObjList = (List<district>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<district>));


                var db1Result1 = await this.DeleteAll("district");
                var db1Result2 = await this.AddItems<district>("district", DeserializedObjList);


                response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/index.php?table=tambon");


                contents = await response.Content.ReadAsStringAsync();
                List<tambon> DeserializedObjList2 = (List<tambon>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<tambon>));


                var db1Result3 = await this.DeleteAll("tambon");
                var db1Result4 = await this.AddItems<tambon>("tambon", DeserializedObjList2);


                response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/index.php?table=province");


                contents = await response.Content.ReadAsStringAsync();
                List<province> DeserializedObjList3 = (List<province>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<province>));


                var db1Result5 = await this.DeleteAll("province");
                var db1Result6 = await this.AddItems<province>("province", DeserializedObjList3);

                response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/index.php?table=const_prenme");contents = await response.Content.ReadAsStringAsync();
                List<const_prenme> DeserializedObjList5 = (List<const_prenme>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<const_prenme>));
                var db1Result7 = await this.DeleteAll("const_prenme");
                var db1Result8 = await this.AddItems<const_prenme>("const_prenme", DeserializedObjList5);

                response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/index.php?table=const_currlev"); contents = await response.Content.ReadAsStringAsync();
                List<const_currlev> DeserializedObjList6 = (List<const_currlev>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<const_currlev>));
                var db1Result9 = await this.DeleteAll("const_currlev");
                var db1Result10 = await this.AddItems<const_currlev>("const_currlev", DeserializedObjList6);
                response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/index.php?table=const_disability_type");
                contents = await response.Content.ReadAsStringAsync();
                List<const_disability_type> DeserializedObjList7 = (List<const_disability_type>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<const_disability_type>));
                var db1Result11 = await this.DeleteAll("const_disability_type");
                var db1Result12 = await this.AddItems<const_disability_type>("const_disability_type", DeserializedObjList7);


                response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/index.php?table=const_disability_type");
                contents = await response.Content.ReadAsStringAsync();
                List<const_disability_type> DeserializedObjList8 = (List<const_disability_type>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<const_disability_type>));
                var db1Result13 = await this.DeleteAll("const_disability_type");
                var db1Result14 = await this.AddItems<const_disability_type>("const_disability_type", DeserializedObjList8);

                response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/index.php?table=const_edulev"); contents = await response.Content.ReadAsStringAsync();
                List<const_edulev> DeserializedObjList9 = (List<const_edulev>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<const_edulev>));
                var db1Result15 = await this.DeleteAll("const_edulev");
                var db1Result16 = await this.AddItems<const_edulev>("const_edulev", DeserializedObjList9);
                response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/index.php?table=const_elderly_grp"); contents = await response.Content.ReadAsStringAsync();
                List<const_elderly_grp> DeserializedObjList10 = (List<const_elderly_grp>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<const_elderly_grp>));
                var db1Result17 = await this.DeleteAll("const_elderly_grp");
                var db1Result18 = await this.AddItems<const_elderly_grp>("const_elderly_grp", DeserializedObjList10);
                response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/index.php?table=const_house_conditions"); contents = await response.Content.ReadAsStringAsync();
                List<const_house_conditions> DeserializedObjList11 = (List<const_house_conditions>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<const_house_conditions>));
                var db1Result19 = await this.DeleteAll("const_house_conditions");
                var db1Result20 = await this.AddItems<const_house_conditions>("const_house_conditions", DeserializedObjList11);
                response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/index.php?table=const_occ"); contents = await response.Content.ReadAsStringAsync();
                List<const_occ> DeserializedObjList12 = (List<const_occ>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<const_occ>));
                var db1Result21 = await this.DeleteAll("const_occ");
                var db1Result22 = await this.AddItems<const_occ>("const_occ", DeserializedObjList12);
                response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/index.php?table=const_pertyp"); contents = await response.Content.ReadAsStringAsync();
                List<const_pertyp> DeserializedObjList13 = (List<const_pertyp>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<const_pertyp>));
                var db1Result23 = await this.DeleteAll("const_pertyp");
                var db1Result24 = await this.AddItems<const_pertyp>("const_pertyp", DeserializedObjList13);
                response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/index.php?table=const_plc"); contents = await response.Content.ReadAsStringAsync();
                List<const_plc> DeserializedObjList14 = (List<const_plc>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<const_plc>));
                var db1Result25 = await this.DeleteAll("const_plc");
                var db1Result26 = await this.AddItems<const_plc>("const_plc", DeserializedObjList14);
                response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/index.php?table=const_plcnmegen"); contents = await response.Content.ReadAsStringAsync();
                List<const_plcnmegen> DeserializedObjList15 = (List<const_plcnmegen>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<const_plcnmegen>));
                var db1Result27 = await this.DeleteAll("const_plcnmegen");
                var db1Result28 = await this.AddItems<const_plcnmegen>("const_plcnmegen", DeserializedObjList15);
              


                response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/index.php?table=const_reltyp"); contents = await response.Content.ReadAsStringAsync();
                List<const_reltyp> DeserializedObjList17 = (List<const_reltyp>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<const_reltyp>));
                var db1Result31 = await this.DeleteAll("const_reltyp");
                var db1Result32 = await this.AddItems<const_reltyp>("const_reltyp", DeserializedObjList17);

                response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/index.php?table=const_school"); contents = await response.Content.ReadAsStringAsync();
                List<const_school> DeserializedObjList18 = (List<const_school>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<const_school>));
                var db1Result33 = await this.DeleteAll("const_school");
                var db1Result34 = await this.AddItems<const_school>("const_school", DeserializedObjList18);

                response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/index.php?table=const_sex"); contents = await response.Content.ReadAsStringAsync();
                List<const_sex> DeserializedObjList19 = (List<const_sex>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<const_sex>));
                var db1Result35 = await this.DeleteAll("const_sex");
                var db1Result36 = await this.AddItems<const_sex>("const_sex", DeserializedObjList19);

                response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/index.php?table=const_stsmar"); contents = await response.Content.ReadAsStringAsync();
                List<const_stsmar> DeserializedObjList20 = (List<const_stsmar>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<const_stsmar>));
                var db1Result37 = await this.DeleteAll("const_stsmar");
                var db1Result38 = await this.AddItems<const_stsmar>("const_stsmar", DeserializedObjList20);

                response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/index.php?table=const_vaccination"); contents = await response.Content.ReadAsStringAsync();
                List<const_vaccination> DeserializedObjList21 = (List<const_vaccination>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<const_vaccination>));
                var db1Result39 = await this.DeleteAll("const_vaccination");
                var db1Result40 = await this.AddItems<const_vaccination>("const_vaccination", DeserializedObjList21);

                response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/index.php?table=const_reg"); contents = await response.Content.ReadAsStringAsync();
                List<const_reg> DeserializedObjList22 = (List<const_reg>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<const_reg>));
                var db1Result41 = await this.DeleteAll("const_reg");
                var db1Result42 = await this.AddItems<const_reg>("const_reg", DeserializedObjList22);


            }
        }
        public async Task loadUserFromServer(int id)
        {

            using (var httpClient = new HttpClient())
            {
                // StringContent content = new StringContent(JsonConvert.SerializeObject(employees), Encoding.UTF8, "application/json");



                var response = await httpClient.GetAsync("https://livingonnewpace.com/gis_bssm/blazoruser.php?id=" + id);

                //var openResult = await this.OpenIndexedDb();
                var contents =  await response.Content.ReadAsStringAsync();
                 contents ="["+ contents + "]";
              //  var contents = "{\"id\":3,\"username\":\"bssm1989@gmail.\",\"name\":\"\\\\u0e1a\\\\u0e31\\\\u0e2a\\\\u0e0b\\\\u0e32\\\\u0e21 \\\\u0e2d\\\\u0e38\\\\u0e21\\\\u0e32\\\\u0e25\\\\u0e35\",\"email\":\"bssm1989@gmail.com\",\"JUN\":\"94\"}";
                //var contents = "[{id:555}]";
                List<volunteer> DeserializedObjList = (List<volunteer>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<volunteer>));


                //var db1Result1 = await this.DeleteAll("district" );

                var db1Result2 = await this.AddItems<volunteer>("volunteer", DeserializedObjList);


            }
        }
        public async Task toServer(Employee employee)
        {

            using (var httpClient = new HttpClient())
            {
                // StringContent content = new StringContent(JsonConvert.SerializeObject(employees), Encoding.UTF8, "application/json");

                for (int i = 0; i < 100; i++)
                {
                    using (var response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/blazorTest.php?" +
                                       "id=" + i +
                                       "&FullName=" + employee.Fullname +
                                       "&Email=" + employee.Email +
                                       "&MobileNumber=" + employee.MobileNumber +
                                       "&localUpdate=" + employee.localUpdate +
                                       "&ServerUpdate=" + employee.ServerUpdate +
                                       "&User=" + employee.User +
                                       "&Status=" + employee.STATUS))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        //ReceivedEmployee = JsonConvert.DeserializeObject<Employee>(apiResponse);
                    }
                }


            }
        }
        public async Task toServerByHc(int? id)
        {


            var getByid = await GetByKey<int, survey_profile>("survey_profile", (int)id);

            if (getByid.id != null)
            {

            }
            using (var httpClient = new HttpClient())
            {
                // StringContent content = new StringContent(JsonConvert.SerializeObject(employees), Encoding.UTF8, "application/json");


                using (var response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/blazorTest.php?" +
                                   "&HC=" + getByid.HC +
                                    "&survey_year=" + getByid.survey_year +
                                    "&survey_no=" + getByid.survey_no +
                                    "&AGRI=" + getByid.AGRI +
                                    "&AGRI_NO=" + getByid.AGRI_NO +
                                    "&MBNO=" + getByid.MBNO +
                                    "&MB=" + getByid.MB +
                                    "&MM=" + getByid.MM +
                                    "&TMP=" + getByid.TMP +
                                    "&AMP=" + getByid.AMP +
                                    "&JUN=" + getByid.JUN +
                                    "&POSTCODE=" + getByid.POSTCODE +
                                    "&popid=" + getByid.popid +
                                    "&PREFIX=" + getByid.PREFIX +
                                    "&TEL=" + getByid.TEL +
                                    "&HHM=" + getByid.HHM +
                                    "&PP=" + getByid.PP +
                                    "&PPP=" + getByid.PPP +
                                    "&lat=" + getByid.lat +
                                    "&lng=" + getByid.lng +
                                    "&photo=" + getByid.photo +
                                    "&PERSON=" + getByid.PERSON +
                                    "&id=" + getByid.id +
                                    "&last_edit=" + getByid.last_edit +
                                    "&create_time=" + getByid.create_time +
                                    "&create_survey=" + getByid.create_survey +
                                    "&MM1=" + getByid.MM1 +
                                    "&PERSON_PREFIX=" + getByid.PERSON_PREFIX +
                                    "&PERSON_NAME=" + getByid.PERSON_NAME +
                                    "&PERSON_SNAME=" + getByid.PERSON_SNAME +
                                    "&PERSON_POPID=" + getByid.PERSON_POPID +
                                    "&HOST_PREFIX=" + getByid.HOST_PREFIX +
                                    "&HOST_NAME=" + getByid.HOST_NAME +
                                    "&HOST_SNAME=" + getByid.HOST_SNAME +
                                    "&HOST_POPID=" + getByid.HOST_POPID +
                                    "&NO1=" + getByid.NO1 +
                                    "&NO2=" + getByid.NO2 +
                                    "&NO3=" + getByid.NO3 +
                                    "&NO4=" + getByid.NO4 +
                                    "&NO5=" + getByid.NO5 +
                                    "&SURVEYER_PREFIX=" + getByid.SURVEYER_PREFIX +
                                    "&SURVEYER_NAME=" + getByid.SURVEYER_NAME +
                                    "&SURVEYER_SNAME=" + getByid.SURVEYER_SNAME +
                                    "&SURVEYER_TEL=" + getByid.SURVEYER_TEL +
                                    "&SURVEYER_DATE=" + getByid.SURVEYER_DATE +
                                    "&SURVEYER_TIME=" + getByid.SURVEYER_TIME +
                                    "&HOST_POPID1=" + getByid.HOST_POPID1 +
                                    "&PERSON_POPID1=" + getByid.PERSON_POPID1 +
                                    "&HC1=" + getByid.HC1 +
                                    "&status=" + getByid.status))



                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    getByid.status = "1";
                    await UpdateItems<survey_profile>("survey_profile", new List<survey_profile>() { getByid });

                    //ReceivedEmployee = JsonConvert.DeserializeObject<Employee>(apiResponse);
                }



            }
        }
        public async Task Delete(int id)
        {
            Employee emp = await GetByKey<int, Employee>("Employee", id);


            if (emp.Id> 0)
            {

                await this.DeleteByKey<int>("Employee", emp.Id);
            }




        }
        public async Task<List<province>> GetAll_survey1_provinces()
        {
            var openResult = await this.OpenIndexedDb();
            return await this.GetAll<province>("province");
        }
        public List<district> GetAll_survey1_district(int province_id)
        {
            var openResult = this.OpenIndexedDb();
            var result = this.GetAll<district>("district");
            return (List<district>)result.Result.Where(x => x.province_id == province_id);
        }
        public int randomNum()
        {
            Random r = new Random();
            int num = r.Next();
            return num;
        }
        public async Task<List<Employee>> GetAll()
        {

            var openResult = await this.OpenIndexedDb();
            Random r = new Random();
            int num = r.Next();


            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee { Id = num, Fullname = "" });

            //var idMa
            //x = employee.Max(x = x.id);
            var result = await this.AddItems<Employee>("Employee", emp);


            return await this.GetAll<Employee>("Employee");
        }
        public async Task<Employee> GetById(int id)
        {
            var openResult = await this.OpenIndexedDb();
            var emp = await this.GetAll<Employee>("Employee");
            var empById = emp.Where(x => x.Id == id);
            return (Employee)empById.First();
        }
        //public async Task getToHttp()
        //{

        //}
        public static  int GetVolunteers()
        { 
            return 555;
        }
        public async Task UpdateById(Employee emp)
        {
            await this.OpenIndexedDb();
            List<Employee> employees = await GetAll<Employee>("Employee");
            Employee emp1 = await GetByKey<int, Employee>("Employee", emp.Id);
            var resultx = "";
            if (emp.Id> 0)
            {

                resultx = await this.DeleteByKey<int>("Employee", emp.Id);
                var result = await this.AddItems<Employee>("Employee", new List<Employee>() { emp });
            }


            //var transaction = db.transaction("Employees", IDBTransaction.READ_WRITE);
            //var objectStore = transaction.objectStore("MyObjectStore");
            //var request = objectStore.add({ Name: Name, Email: Email, Location: Location});
            //request.onsuccess = function(e) {
            //    // do something when the add succeeded                              
            //};
            //transaction.oncomplete = function(e) {
            //    // do something after the transaction completed      
            //};
            //transaction.onabort = function(e) {
            //    // do something after the transaction aborted     
            //};
            //transaction.onerrort = function(e) {
            //    // do something after the transaction canceled    
            //};



            //var openResult = await this.OpenIndexedDb();
            //openResult.transaction =
            //string strConnString = "myconnectionstring"; // get it from Web.config file    
            //SqlTransaction objTrans = null;

            //using (SqlConnection objConn = new SqlConnection(strConnString))
            //{
            //    objConn.Open();
            //    objTrans = objConn.BeginTransaction();
            //        try
            //    {
            //        List<Employee> employees = await GetAll<Employee>("Employees");
            //        Employee emp1 = await GetByKey<int, Employee>("Employees", emp.Id);
            //        var resultx = "";
            //        if (emp.Id> 0)
            //        {

            //            resultx = await this.DeleteByKey<int>("Employees", emp.Id);
            //        }
            //        var result = await this.AddItems<Employee>("Employees", new List<Employee>() { emp });
            //        objTrans.Commit();
            //    }
            //    catch (Exception)
            //    {
            //        objTrans.Rollback();
            //    }
            //    finally
            //    {
            //        objConn.Close();
            //    }
            // }

        }

    }
  

}
