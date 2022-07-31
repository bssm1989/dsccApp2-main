

using System;
using System.ComponentModel.DataAnnotations;
using DnetIndexedDb;

namespace FirstBlazorApp.Models
{

    //public class Province_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int Id { get; set; }
    //    public string Fullname { get; set; }


    //}


    //public class district_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string district_id { get; set; }

    //    public int province_id { get; set; }

    //    public string district_name_thai { get; set; }

    //    public string district_name_eng { get; set; }

    //    public int comment { get; set; }

    //}
    //public class tambon_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]

    //    public string tambon_id { get; set; }
    //    public string province_id { get; set; }
    //    public string district_id { get; set; }
    //    public string tambon_name_thai { get; set; }
    //    public string tambon_name_eng { get; set; }
    //    public string comment { get; set; }
    //    public string lat { get; set; }
    //    public string lng { get; set; }
    //}
    //public class province_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]

    //    public string province_id { get; set; }
    //    public int region_id { get; set; }
    //    public string province_name_thai { get; set; }
    //    public string province_name_eng { get; set; }
    //    public string comment { get; set; }
    //}
    //public class Amper_2
    //{
    //    public int Id { get; set; }
    //    public string Fullname { get; set; }

    //}
    //public class compute_hc1_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string JUN { get; set; }
    //    public string AMP { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string ch { get; set; }
    //    public string level { get; set; }
    //}

    public class ch2_gis_2
    {
        [IndexDbKey(AutoIncrement = true)]
        public string HC { get; set; }
        public string JUN { get; set; }
        public string AMP { get; set; }
        public string TMP { get; set; }
        public string mm { get; set; }
        public string ch2_lat { get; set; }
        public string ch2_lng { get; set; }
        public string gis_lat { get; set; }
        public string gis_lng { get; set; }
        public string flag { get; set; }
        public string n_lat { get; set; }
        public string n_lng { get; set; }
        public string address { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
    }
    //public class ch2_gis2_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string JUN { get; set; }
    //    public string AMP { get; set; }
    //    public string TMP { get; set; }
    //    public string mm { get; set; }
    //    public string ch2_lat { get; set; }
    //    public string ch2_lng { get; set; }
    //    public string gis_lat { get; set; }
    //    public string gis_lng { get; set; }
    //    public string flag { get; set; }
    //    public string n_lat { get; set; }
    //    public string n_lng { get; set; }
    //    public string address { get; set; }
    //    public int? time1 { get; set; }
    //}

    //public class compute_hc2_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string JUN { get; set; }
    //    public string AMP { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string ch { get; set; }
    //    public string level { get; set; }
    //}
    //public class compute_hc3_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string JUN { get; set; }
    //    public string AMP { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string ch { get; set; }
    //    public string level { get; set; }
    //}
    //public class compute_hc4_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string JUN { get; set; }
    //    public string AMP { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string ch { get; set; }
    //    public string level { get; set; }
    //}
    //public class employee_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int? Id { get; set; }
    //    public string Fullname { get; set; }
    //    public string Email { get; set; }
    //    public string MobileNumber { get; set; }
    //}

    //public class hc_result_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int? id { get; set; }
    //    public string detail { get; set; }
    //    public string min { get; set; }
    //    public string max { get; set; }
    //}
    //public class hc_sum_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string MBNO { get; set; }
    //    public string MB { get; set; }
    //    public string MM { get; set; }
    //    public string TMP { get; set; }
    //    public string AMP { get; set; }
    //    public string JUN { get; set; }
    //    public string ch1 { get; set; }
    //    public string ch2 { get; set; }
    //    public string ch3 { get; set; }
    //    public string ch4 { get; set; }
    //    public string ch5 { get; set; }
    //}
    //public class hc_sum1_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string MBNO { get; set; }
    //    public string MB { get; set; }
    //    public string MM { get; set; }
    //    public string TMP { get; set; }
    //    public string AMP { get; set; }
    //    public string JUN { get; set; }
    //    public string ch1 { get; set; }
    //    public string ch2 { get; set; }
    //    public string ch3 { get; set; }
    //    public string ch4 { get; set; }
    //    public string ch5 { get; set; }
    //}
    //public class hc_sum2_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string MBNO { get; set; }
    //    public string MB { get; set; }
    //    public string MM { get; set; }
    //    public string TMP { get; set; }
    //    public string AMP { get; set; }
    //    public string JUN { get; set; }
    //    public string ch1 { get; set; }
    //    public string ch1_1 { get; set; }
    //    public string ch1_2 { get; set; }
    //    public string ch1_3 { get; set; }
    //    public string ch2 { get; set; }
    //    public string ch2_1 { get; set; }
    //    public string ch2_2 { get; set; }
    //    public string ch2_3 { get; set; }
    //    public string ch3 { get; set; }
    //    public string ch3_1 { get; set; }
    //    public string ch3_2 { get; set; }
    //    public string ch3_3 { get; set; }
    //    public string ch4 { get; set; }
    //    public string ch4_1 { get; set; }
    //    public string ch4_2 { get; set; }
    //    public string ch4_3 { get; set; }
    //    public string ch4_4 { get; set; }
    //    public string ch5 { get; set; }
    //    public string ch5_1 { get; set; }
    //    public string ch5_2 { get; set; }
    //    public string ch5_3 { get; set; }
    //    public string ch5_4 { get; set; }
    //}
    //public class hc_sum3_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string MBNO { get; set; }
    //    public string MB { get; set; }
    //    public string MM { get; set; }
    //    public string TMP { get; set; }
    //    public string AMP { get; set; }
    //    public string JUN { get; set; }
    //    public string ch1 { get; set; }
    //    public string ch1_1 { get; set; }
    //    public string ch1_2 { get; set; }
    //    public string ch1_3 { get; set; }
    //    public string ch2 { get; set; }
    //    public string ch2_1 { get; set; }
    //    public string ch2_2 { get; set; }
    //    public string ch2_3 { get; set; }
    //    public string ch3 { get; set; }
    //    public string ch3_1 { get; set; }
    //    public string ch3_2 { get; set; }
    //    public string ch3_3 { get; set; }
    //    public string ch4 { get; set; }
    //    public string ch4_1 { get; set; }
    //    public string ch4_2 { get; set; }
    //    public string ch4_3 { get; set; }
    //    public string ch4_4 { get; set; }
    //    public string ch5 { get; set; }
    //    public string ch5_1 { get; set; }
    //    public string ch5_2 { get; set; }
    //    public string ch5_3 { get; set; }
    //    public string ch5_4 { get; set; }
    //}
    //public class hc_sum4_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string MBNO { get; set; }
    //    public string MB { get; set; }
    //    public string MM { get; set; }
    //    public string TMP { get; set; }
    //    public string AMP { get; set; }
    //    public string JUN { get; set; }
    //    public string ch1 { get; set; }
    //    public string ch1_1 { get; set; }
    //    public string ch1_2 { get; set; }
    //    public string ch1_3 { get; set; }
    //    public string ch1_4 { get; set; }
    //    public string ch1_5 { get; set; }
    //    public string ch1_6 { get; set; }
    //    public string ch1_7 { get; set; }
    //    public string ch1_8 { get; set; }
    //    public string ch1_9 { get; set; }
    //    public string ch2 { get; set; }
    //    public string ch2_1 { get; set; }
    //    public string ch2_2 { get; set; }
    //    public string ch2_3 { get; set; }
    //    public string ch2_4 { get; set; }
    //    public string ch2_5 { get; set; }
    //    public string ch2_6 { get; set; }
    //    public string ch2_7 { get; set; }
    //    public string ch2_8 { get; set; }
    //    public string ch2_9 { get; set; }
    //    public string ch2_10 { get; set; }
    //    public string ch2_11 { get; set; }
    //    public string ch2_12 { get; set; }
    //    public string ch3 { get; set; }
    //    public string ch3_1 { get; set; }
    //    public string ch3_2 { get; set; }
    //    public string ch3_3 { get; set; }
    //    public string ch3_4 { get; set; }
    //    public string ch3_5 { get; set; }
    //    public string ch3_6 { get; set; }
    //    public string ch4 { get; set; }
    //    public string ch4_1 { get; set; }
    //    public string ch4_2 { get; set; }
    //    public string ch4_3 { get; set; }
    //    public string ch4_4 { get; set; }
    //    public string ch5 { get; set; }
    //    public string ch5_1 { get; set; }
    //    public string ch5_2 { get; set; }
    //    public string ch5_3 { get; set; }
    //    public string ch5_4 { get; set; }
    //    public string ch5_5 { get; set; }
    //    public string ch5_6 { get; set; }
    //    public string ch5_7 { get; set; }
    //    public string ch5_8 { get; set; }
    //    public string ch5_9 { get; set; }
    //    public string ch5_10 { get; set; }
    //}
    //public class hc_sum5_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string MBNO { get; set; }
    //    public string MB { get; set; }
    //    public string MM { get; set; }
    //    public string TMP { get; set; }
    //    public string AMP { get; set; }
    //    public string JUN { get; set; }
    //    public string ch1 { get; set; }
    //    public string ch1_1 { get; set; }
    //    public string ch1_2 { get; set; }
    //    public string ch1_3 { get; set; }
    //    public string ch1_4 { get; set; }
    //    public string ch1_5 { get; set; }
    //    public string ch1_6 { get; set; }
    //    public string ch1_7 { get; set; }
    //    public string ch1_8 { get; set; }
    //    public string ch1_9 { get; set; }
    //    public string ch2 { get; set; }
    //    public string ch2_1 { get; set; }
    //    public string ch2_2 { get; set; }
    //    public string ch2_3 { get; set; }
    //    public string ch2_4 { get; set; }
    //    public string ch2_5 { get; set; }
    //    public string ch2_6 { get; set; }
    //    public string ch2_7 { get; set; }
    //    public string ch2_8 { get; set; }
    //    public string ch2_9 { get; set; }
    //    public string ch2_10 { get; set; }
    //    public string ch2_11 { get; set; }
    //    public string ch2_12 { get; set; }
    //    public string ch3 { get; set; }
    //    public string ch3_1 { get; set; }
    //    public string ch3_2 { get; set; }
    //    public string ch3_3 { get; set; }
    //    public string ch3_4 { get; set; }
    //    public string ch3_5 { get; set; }
    //    public string ch3_6 { get; set; }
    //    public string ch4 { get; set; }
    //    public string ch4_1 { get; set; }
    //    public string ch4_2 { get; set; }
    //    public string ch4_3 { get; set; }
    //    public string ch4_4 { get; set; }
    //    public string ch5 { get; set; }
    //    public string ch5_1 { get; set; }
    //    public string ch5_2 { get; set; }
    //    public string ch5_3 { get; set; }
    //    public string ch5_4 { get; set; }
    //    public string ch5_5 { get; set; }
    //    public string ch5_6 { get; set; }
    //    public string ch5_7 { get; set; }
    //    public string ch5_8 { get; set; }
    //    public string ch5_9 { get; set; }
    //    public string ch5_10 { get; set; }
    //}
    //public class hc_sum6_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string MBNO { get; set; }
    //    public string MB { get; set; }
    //    public string MM { get; set; }
    //    public string TMP { get; set; }
    //    public string AMP { get; set; }
    //    public string JUN { get; set; }
    //    public string ch1 { get; set; }
    //    public string ch1_1 { get; set; }
    //    public string ch1_2 { get; set; }
    //    public string ch1_3 { get; set; }
    //    public string ch1_4 { get; set; }
    //    public string ch1_5 { get; set; }
    //    public string ch1_6 { get; set; }
    //    public string ch1_7 { get; set; }
    //    public string ch1_8 { get; set; }
    //    public string ch1_9 { get; set; }
    //    public string ch2 { get; set; }
    //    public string ch2_1 { get; set; }
    //    public string ch2_2 { get; set; }
    //    public string ch2_3 { get; set; }
    //    public string ch2_4 { get; set; }
    //    public string ch2_5 { get; set; }
    //    public string ch2_6 { get; set; }
    //    public string ch2_7 { get; set; }
    //    public string ch2_8 { get; set; }
    //    public string ch2_9 { get; set; }
    //    public string ch2_10 { get; set; }
    //    public string ch2_11 { get; set; }
    //    public string ch2_12 { get; set; }
    //    public string ch3 { get; set; }
    //    public string ch3_1 { get; set; }
    //    public string ch3_2 { get; set; }
    //    public string ch3_3 { get; set; }
    //    public string ch3_4 { get; set; }
    //    public string ch3_5 { get; set; }
    //    public string ch3_6 { get; set; }
    //    public string ch4 { get; set; }
    //    public string ch4_1 { get; set; }
    //    public string ch4_2 { get; set; }
    //    public string ch4_3 { get; set; }
    //    public string ch4_4 { get; set; }
    //    public string ch5 { get; set; }
    //    public string ch5_1 { get; set; }
    //    public string ch5_2 { get; set; }
    //    public string ch5_3 { get; set; }
    //    public string ch5_4 { get; set; }
    //    public string ch5_5 { get; set; }
    //    public string ch5_6 { get; set; }
    //    public string ch5_7 { get; set; }
    //    public string ch5_8 { get; set; }
    //    public string ch5_9 { get; set; }
    //    public string ch5_10 { get; set; }
    //}
    //public class hc_sum_check1_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int? id { get; set; }
    //    public string JUN { get; set; }
    //    public int? status { get; set; }
    //}

    //public class hc_sum_check2_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int? id { get; set; }
    //    public string JUN { get; set; }
    //    public int? status { get; set; }
    //}
    //public class income_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string JUN { get; set; }
    //    public string AMP { get; set; }
    //    public string TMP { get; set; }
    //    public string mm { get; set; }
    //    public string MBNO { get; set; }
    //    public string a2 { get; set; }
    //    public int? no1 { get; set; }
    //    public int? no2 { get; set; }
    //}
    //public class income_edit_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string JUN { get; set; }
    //    public string AMP { get; set; }
    //    public string TMP { get; set; }
    //    public string mm { get; set; }
    //    public string MBNO { get; set; }
    //    public string a2 { get; set; }
    //    public int? no1 { get; set; }
    //    public int? no2 { get; set; }
    //}

    //public class income_eef_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string JUN { get; set; }
    //    public string AMP { get; set; }
    //    public string TMP { get; set; }
    //    public string mm { get; set; }
    //}
    //public class insert_hc_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //}
    //public class jun_finish_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string JUN { get; set; }
    //    public string date1 { get; set; }
    //    public string stat { get; set; }
    //    public int? date2 { get; set; }
    //}
    //public class jun_level_detail_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string JUN { get; set; }
    //    public string detail { get; set; }
    //    public int? lv { get; set; }
    //}
    //public class jun_location_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string JUN { get; set; }
    //    public string lat { get; set; }
    //    public string lng { get; set; }
    //}
    //public class line_poor_rich_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string JUN { get; set; }
    //    public string survey_year { get; set; }
    //    public string poor { get; set; }
    //    public string level1 { get; set; }
    //    public string level2 { get; set; }
    //    public int? survey_no { get; set; }
    //}



    //public class log_file__2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int? id { get; set; }
    //    public string username { get; set; }
    //    public string detail { get; set; }
    //    public int? time1 { get; set; }
    //}
    //public class log_file_2_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int? id { get; set; }
    //    public string username { get; set; }
    //    public string detail { get; set; }
    //    public int? time1 { get; set; }
    //}
    //public class mm_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string mcode { get; set; }
    //    public string mname { get; set; }
    //    public string mno { get; set; }
    //    public string mtype { get; set; }
    //    public string pcode { get; set; }
    //    public string pname { get; set; }
    //    public string acode { get; set; }
    //    public string aname { get; set; }
    //    public string tcode { get; set; }
    //    public string tname { get; set; }
    //    public string orgcode { get; set; }
    //    public string orgname { get; set; }
    //    public string orgtype { get; set; }
    //    public string remark { get; set; }
    //    public string lastupdate { get; set; }
    //    public string lat { get; set; }
    //    public string longti { get; set; }
    //    public string postcode { get; set; }
    //}
    //public class poverty_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int? id { get; set; }
    //    public string lat { get; set; }
    //    public string lng { get; set; }
    //    public string images { get; set; }
    //    public string house_no { get; set; }
    //    public string village_name { get; set; }
    //    public string province { get; set; }
    //    public string district { get; set; }
    //    public string sub_district { get; set; }
    //    public string h_title { get; set; }
    //    public string h_first_name { get; set; }
    //    public string h_last_name { get; set; }
    //    public string h_occupation { get; set; }
    //    public string remark { get; set; }
    //    public string house_code { get; set; }
    //    public int? createBy { get; set; }
    //    public int? last_edit { get; set; }
    //    public int? create_time { get; set; }
    //    public int? village_no { get; set; }
    //    public int? members_m { get; set; }
    //    public int? members_f { get; set; }
    //    public int? income_primary { get; set; }
    //    public int? income_secondary { get; set; }
    //    public int? income_other { get; set; }
    //    public int? income_self { get; set; }
    //}
    //public class poverty_pattani_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int? id { get; set; }
    //    public string house_code { get; set; }
    //    public string house_no { get; set; }
    //    public string village_name { get; set; }
    //    public string sub_district { get; set; }
    //    public string district { get; set; }
    //    public string province { get; set; }
    //    public string h_title { get; set; }
    //    public string h_first_name { get; set; }
    //    public string h_last_name { get; set; }
    //    public string h_occupation { get; set; }
    //    public string images { get; set; }
    //    public string createBy { get; set; }
    //    public string remark { get; set; }
    //    public int? village_no { get; set; }
    //    public int? members_m { get; set; }
    //    public int? members_f { get; set; }
    //    public int? income_a { get; set; }
    //    public int? income_b { get; set; }
    //    public int? income_c { get; set; }
    //    public int? income_d { get; set; }
    //    public double? lat { get; set; }
    //    public double? lng { get; set; }
    //}

    //public class region_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string regionField { get; set; }
    //    public string comment { get; set; }
    //    public int? region_id { get; set; }
    //}
    //public class snapshot_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int? id { get; set; }
    //    public string change_table { get; set; }
    //    public string change_type { get; set; }
    //    public string change_index { get; set; }
    //    public int? change_id { get; set; }
    //    public int? change_time { get; set; }
    //}
    //public class staff_jun_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string username { get; set; }
    //    public string JUN { get; set; }
    //}
    //public class survey_a1_2
    //{
    //    public int id { get; set; }
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string a1 { get; set; }
    //    public string a2 { get; set; }
    //    public string a2_b { get; set; }
    //    public string popid { get; set; }
    //    public string a3 { get; set; }
    //    public string a4 { get; set; }
    //    public string a5 { get; set; }
    //    public string a6 { get; set; }
    //    public string a7_0 { get; set; }
    //    public string a7_1 { get; set; }
    //    public string a7_1_1 { get; set; }
    //    public string a7_1_2 { get; set; }
    //    public string a7_2 { get; set; }
    //    public string a7_2_1 { get; set; }
    //    public string a7_2_2 { get; set; }
    //    public string a7_3 { get; set; }
    //    public string a7_3_1 { get; set; }
    //    public string a7_3_2 { get; set; }
    //    public string a7_4 { get; set; }
    //    public string a7_4_1 { get; set; }
    //    public string a7_4_2 { get; set; }
    //    public string a7_5 { get; set; }
    //    public string a7_5_1 { get; set; }
    //    public string a7_5_2 { get; set; }
    //    public string a7_6 { get; set; }
    //    public string a7_6_1 { get; set; }
    //    public string a7_6_2 { get; set; }
    //    public string a7_7 { get; set; }
    //    public string a7_7_1 { get; set; }
    //    public string a7_7_2 { get; set; }
    //    public string a7_8 { get; set; }
    //    public string a7_8_1 { get; set; }
    //    public string a7_8_2 { get; set; }
    //    public string a9 { get; set; }
    //    public string a10 { get; set; }
    //    public string a11 { get; set; }
    //    public string a12 { get; set; }
    //    public string a13 { get; set; }
    //}
    //public class survey_a2_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string a1 { get; set; }
    //    public string a5 { get; set; }
    //    public string a14 { get; set; }
    //    public string a15_0 { get; set; }
    //    public string a15_0_1 { get; set; }
    //    public string a15_0_1_1 { get; set; }
    //    public string a15_0_1_2 { get; set; }
    //    public string a15_0_1_3 { get; set; }
    //    public string a15_0_1_4 { get; set; }
    //    public string a15_0_1_5 { get; set; }
    //    public string a15_0_1_6 { get; set; }
    //    public string a15_0_1_7 { get; set; }
    //    public string a15_0_1_7_1 { get; set; }
    //    public string a15_0_2 { get; set; }
    //    public string a15_0_2_1 { get; set; }
    //    public string a15_0_2_2 { get; set; }
    //    public string a15_0_2_3 { get; set; }
    //    public string a15_0_2_4 { get; set; }
    //    public string a15_0_2_5 { get; set; }
    //    public string a15_0_2_6 { get; set; }
    //    public string a15_0_2_7 { get; set; }
    //    public string a15_0_2_7_1 { get; set; }
    //    public string a15_2 { get; set; }
    //    public string a15_3 { get; set; }
    //    public string a15_4 { get; set; }
    //    public string a15_5 { get; set; }
    //    public string a15_6 { get; set; }
    //    public string a15_7 { get; set; }
    //    public string a15_8 { get; set; }
    //    public string a15_9 { get; set; }
    //    public string a15_10 { get; set; }
    //    public string a15_10_1 { get; set; }
    //    public string a16_0 { get; set; }
    //    public string a16_1 { get; set; }
    //    public string a16_2 { get; set; }
    //    public string a16_3 { get; set; }
    //    public string a16_4 { get; set; }
    //    public string a16_5 { get; set; }
    //    public string a16_6 { get; set; }
    //    public string a16_7 { get; set; }
    //    public string a16_8 { get; set; }
    //    public string a16_9 { get; set; }
    //    public string a16_10 { get; set; }
    //    public string a16_10_1 { get; set; }
    //    public string a17_1 { get; set; }
    //    public string a17_2 { get; set; }
    //    public string a17_3_1 { get; set; }
    //    public string a17_3_2 { get; set; }
    //    public int? a15_1 { get; set; }
    //}
    //public class survey_b1_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string b1_1 { get; set; }
    //    public string b1_2 { get; set; }
    //    public string b2 { get; set; }
    //    public string b2_2 { get; set; }
    //    public string b2_3 { get; set; }
    //    public string b2_4_1 { get; set; }
    //    public string b2_4_1_1 { get; set; }
    //    public string b2_4_1_2 { get; set; }
    //    public string b2_4_1_3 { get; set; }
    //    public string b2_4_2 { get; set; }
    //    public string b2_4_2_1 { get; set; }
    //    public string b2_4_2_2 { get; set; }
    //    public string b2_4_2_3 { get; set; }
    //    public string b2_4_3 { get; set; }
    //    public string b2_4_3_1 { get; set; }
    //    public string b2_4_3_2 { get; set; }
    //    public string b2_4_3_3 { get; set; }
    //    public string b2_4_4 { get; set; }
    //    public string b2_4_4_1 { get; set; }
    //    public string b2_4_4_2 { get; set; }
    //    public string b2_4_4_3 { get; set; }
    //    public string b3 { get; set; }
    //    public string b4_1 { get; set; }
    //    public string b4_2 { get; set; }
    //    public string b4_3 { get; set; }
    //    public string b4_4 { get; set; }
    //    public string b5_1 { get; set; }
    //    public string b5_2 { get; set; }
    //    public string b6_1 { get; set; }
    //    public string b6_2 { get; set; }
    //    public string b6_3 { get; set; }
    //    public string b7_1 { get; set; }
    //    public string b7_1_1 { get; set; }
    //    public string b7_2 { get; set; }
    //    public string b7_2_1 { get; set; }
    //    public string b7_2_1_1 { get; set; }
    //    public string b7_2_2 { get; set; }
    //    public string b7_2_2_1 { get; set; }
    //    public string b7_3 { get; set; }
    //    public string b7_3_1 { get; set; }
    //    public string b7_3_1_1 { get; set; }
    //    public string b7_3_2 { get; set; }
    //    public string b7_3_2_1 { get; set; }
    //}
    //public class survey_b2_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string b8_0 { get; set; }
    //    public string b8_1 { get; set; }
    //    public string b8_1_1 { get; set; }
    //    public string b8_1_2 { get; set; }
    //    public string b8_1_3 { get; set; }
    //    public string b8_1_4 { get; set; }
    //    public string b8_1_1_1 { get; set; }
    //    public string b8_1_1_2 { get; set; }
    //    public string b8_1_1_3 { get; set; }
    //    public string b8_1_1_4 { get; set; }
    //    public string b8_1_1_5 { get; set; }
    //    public string b8_1_1_6 { get; set; }
    //    public string b8_2 { get; set; }
    //    public string b8_2_1 { get; set; }
    //    public string b8_2_2 { get; set; }
    //    public string b8_2_3 { get; set; }
    //    public string b8_2_4 { get; set; }
    //    public string b8_3 { get; set; }
    //    public string b8_3_1 { get; set; }
    //    public string b8_3_2 { get; set; }
    //    public string b8_3_3 { get; set; }
    //    public string b8_3_4 { get; set; }
    //    public string b8_4 { get; set; }
    //    public string b8_5 { get; set; }
    //    public string b8_5_1 { get; set; }
    //    public string b8_5_2 { get; set; }
    //    public string b8_5_3 { get; set; }
    //    public string b8_5_4 { get; set; }
    //    public string b8_5_5 { get; set; }
    //    public string b8_5_6 { get; set; }
    //    public string b8_6 { get; set; }
    //    public string b8_6_1 { get; set; }
    //    public string b8_6_2 { get; set; }
    //    public string b8_6_3 { get; set; }
    //    public string b8_6_4 { get; set; }
    //    public string b9_1 { get; set; }
    //    public string b9_2 { get; set; }
    //    public string b9_3 { get; set; }
    //    public string b9_4 { get; set; }
    //    public string b9_5 { get; set; }
    //    public string b9_6 { get; set; }
    //    public string b9_6_1 { get; set; }
    //    public string b10 { get; set; }
    //    public string b10_1 { get; set; }
    //    public string b10_2 { get; set; }
    //    public string b10_3 { get; set; }
    //    public string b10_4 { get; set; }
    //    public string b10_5 { get; set; }
    //    public string b10_6 { get; set; }
    //    public string b10_7 { get; set; }
    //    public string b10_7_1 { get; set; }
    //}
    //public class tpmap_pattani_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int? id { get; set; }
    //    public string MBNO { get; set; }
    //    public string MM { get; set; }
    //    public string TMP1 { get; set; }
    //    public string TMP { get; set; }
    //    public string AMP1 { get; set; }
    //    public string AMP { get; set; }
    //    public string PREFIX { get; set; }
    //    public string name { get; set; }
    //    public string sname { get; set; }
    //    public int? MB { get; set; }
    //}
    //public class tpmap_pattani2_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int? id { get; set; }
    //    public string MBNO { get; set; }
    //    public string MM { get; set; }
    //    public string TMP { get; set; }
    //    public string AMP1 { get; set; }
    //    public string AMP { get; set; }
    //    public string PREFIX { get; set; }
    //    public string name { get; set; }
    //    public string sname { get; set; }
    //    public int? MMNO { get; set; }
    //}
    //public class t_tambon_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int? id { get; set; }
    //    public int? TMP { get; set; }
    //}
    //public class update_hc_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //}
    //public class upload_pic_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string username { get; set; }
    //    public string JUN { get; set; }
    //    public string AMP { get; set; }
    //    public string TMP { get; set; }
    //    public string file_type { get; set; }
    //    public string detail { get; set; }
    //    public int? time1 { get; set; }
    //}
    //public class users_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int? id { get; set; }
    //    public string email { get; set; }
    //    public string pwd { get; set; }
    //    public string level { get; set; }
    //    public string sid { get; set; }
    //    public string create_pwd { get; set; }
    //    public string title { get; set; }
    //    public string first_name_th { get; set; }
    //    public string last_name_th { get; set; }
    //    public string pre_pwd { get; set; }
    //    public string building_no { get; set; }
    //    public string village_no { get; set; }
    //    public string province { get; set; }
    //    public string district { get; set; }
    //    public string sub_district { get; set; }
    //    public string phone { get; set; }
    //    public int? last_login { get; set; }
    //    public int? last_edit { get; set; }
    //    public int? create_time { get; set; }
    //}
    //public class volunteer_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int? id { get; set; }
    //    public string username { get; set; }
    //    public string password { get; set; }
    //    public string name { get; set; }
    //    public string tel { get; set; }
    //    public string email { get; set; }
    //    public string fb { get; set; }
    //    public string line { get; set; }
    //    public string JUN { get; set; }
    //    public string level { get; set; }
    //    public int? last_edit { get; set; }
    //    public int? create_time { get; set; }
    //}


    //public class livingon_tpmap_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int? id { get; set; }
    //    public string HC { get; set; }
    //    public string comment { get; set; }
    //}
    //public class livingon_tpmap2_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int? id { get; set; }
    //    public string HC { get; set; }
    //    public string name { get; set; }
    //    public int? idtpmap { get; set; }
    //}
    //public class livingon_tpmap4_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int? id { get; set; }
    //    public string HC { get; set; }
    //    public string name { get; set; }
    //    public string MBNO { get; set; }
    //    public string MB { get; set; }
    //    public string TMP { get; set; }
    //    public string AMP { get; set; }
    //    public string PREFIX { get; set; }
    //    public string name1 { get; set; }
    //    public string sname1 { get; set; }
    //    public int? idtpmap { get; set; }
    //}
    //public class livingon_tpmap3_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int? id { get; set; }
    //    public string HC { get; set; }
    //    public string name { get; set; }
    //    public string MBNO { get; set; }
    //    public string MB { get; set; }
    //    public string TMP { get; set; }
    //    public string AMP { get; set; }
    //    public string PREFIX { get; set; }
    //    public string name1 { get; set; }
    //    public string sname1 { get; set; }
    //    public int? idtpmap { get; set; }
    //}
    //public class survey_b3_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string b11_1 { get; set; }
    //    public string b11_1_1 { get; set; }
    //    public string b11_2 { get; set; }
    //    public string b11_2_1 { get; set; }
    //    public string b12_1 { get; set; }
    //    public string b12_2 { get; set; }
    //    public string b12_3 { get; set; }
    //    public string b12_4 { get; set; }
    //    public string b12_5 { get; set; }
    //    public string b12_6 { get; set; }
    //    public string b12_7 { get; set; }
    //    public string b12_8 { get; set; }
    //    public string b12_9 { get; set; }
    //    public string b12_10 { get; set; }
    //    public string b12_11 { get; set; }
    //    public string b12_12 { get; set; }
    //    public string b12_12_1 { get; set; }
    //    public string b13_1 { get; set; }
    //    public string b13_2 { get; set; }
    //    public string b13_3 { get; set; }
    //    public string b13_4 { get; set; }
    //    public string b13_5 { get; set; }
    //    public string b13_6 { get; set; }
    //    public string b13_7 { get; set; }
    //    public string b13_8 { get; set; }
    //    public string b13_9 { get; set; }
    //    public string b13_10 { get; set; }
    //    public string b13_11 { get; set; }
    //    public string b13_12 { get; set; }
    //    public string b13_12_1 { get; set; }
    //    public string b14 { get; set; }
    //    public string b15 { get; set; }
    //}
    //public class survey_c1_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string c1_1_0 { get; set; }
    //    public string c1_1_1 { get; set; }
    //    public string c1_1_1_1 { get; set; }
    //    public string c1_1_1_2 { get; set; }
    //    public string c1_1_2 { get; set; }
    //    public string c1_1_2_1 { get; set; }
    //    public string c1_1_2_2 { get; set; }
    //    public string c1_1_3 { get; set; }
    //    public string c1_1_3_1 { get; set; }
    //    public string c1_1_3_2 { get; set; }
    //    public string c1_1_4 { get; set; }
    //    public string c1_1_4_1 { get; set; }
    //    public string c1_1_4_2 { get; set; }
    //    public string c1_2_0 { get; set; }
    //    public string c1_2_1 { get; set; }
    //    public string c1_2_1_1 { get; set; }
    //    public string c1_2_1_2 { get; set; }
    //    public string c1_2_2 { get; set; }
    //    public string c1_2_2_1 { get; set; }
    //    public string c1_2_2_2 { get; set; }
    //    public string c1_2_3 { get; set; }
    //    public string c1_2_3_1 { get; set; }
    //    public string c1_2_3_2 { get; set; }
    //    public string c1_3_0 { get; set; }
    //    public string c1_3_1 { get; set; }
    //    public string c1_3_1_1 { get; set; }
    //    public string c1_3_1_2 { get; set; }
    //    public string c1_3_2 { get; set; }
    //    public string c1_3_2_1 { get; set; }
    //    public string c1_3_2_2 { get; set; }
    //    public string c2 { get; set; }
    //    public string c3_1 { get; set; }
    //    public string c3_1_1 { get; set; }
    //    public string c3_1_2 { get; set; }
    //    public string c3_1_3 { get; set; }
    //    public string c3_2 { get; set; }
    //    public string c3_2_1 { get; set; }
    //    public string c3_3 { get; set; }
    //    public string c3_3_1 { get; set; }
    //    public string c3_4 { get; set; }
    //    public string c3_4_1 { get; set; }
    //    public string c3_5 { get; set; }
    //    public string c3_5_1 { get; set; }
    //    public string c3_6 { get; set; }
    //    public string c3_6_1 { get; set; }
    //    public string c3_7 { get; set; }
    //    public string c3_7_1 { get; set; }
    //    public string c3_8 { get; set; }
    //    public string c3_8_1 { get; set; }
    //    public string c3_9 { get; set; }
    //    public string c3_9_1 { get; set; }
    //    public string c3_10 { get; set; }
    //    public string c3_10_1 { get; set; }
    //    public string c3_10_2 { get; set; }
    //    public string c4 { get; set; }
    //    public string c4_1 { get; set; }
    //    public string c4_1_1 { get; set; }
    //    public string c4_2 { get; set; }
    //    public string c4_2_1 { get; set; }
    //    public string c4_3 { get; set; }
    //    public string c4_3_1 { get; set; }
    //    public string c4_4 { get; set; }
    //    public string c4_4_1 { get; set; }
    //    public string c4_5 { get; set; }
    //    public string c4_5_1 { get; set; }
    //    public string c4_6 { get; set; }
    //    public string c4_6_1 { get; set; }
    //    public string c4_6_2 { get; set; }
    //    public string c6 { get; set; }
    //    public string c6_1 { get; set; }
    //    public string c6_2 { get; set; }
    //    public string c6_3 { get; set; }
    //    public string c6_4 { get; set; }
    //    public string c6_5 { get; set; }
    //    public string c6_6 { get; set; }
    //    public string c6_7 { get; set; }
    //    public string c6_8 { get; set; }
    //    public string c6_9 { get; set; }
    //    public string c6_10 { get; set; }
    //    public string c6_11 { get; set; }
    //    public string c6_11_1 { get; set; }
    //}
    //public class survey_c2_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string c5 { get; set; }
    //    public string c5_1_1 { get; set; }
    //    public string c5_1_2 { get; set; }
    //    public string c5_1_3 { get; set; }
    //    public string c5_1_4 { get; set; }
    //    public string c5_1_4_1 { get; set; }
    //    public string c5_2_1 { get; set; }
    //    public string c5_2_1_1 { get; set; }
    //    public string c5_2_1_2_1 { get; set; }
    //    public string c5_2_1_2_2 { get; set; }
    //    public string c5_2_1_2_3 { get; set; }
    //    public string c5_2_1_3 { get; set; }
    //    public string c5_2_1_4 { get; set; }
    //    public string c5_2_2 { get; set; }
    //    public string c5_2_2_1 { get; set; }
    //    public string c5_2_2_2_1 { get; set; }
    //    public string c5_2_2_2_2 { get; set; }
    //    public string c5_2_2_2_3 { get; set; }
    //    public string c5_2_2_3 { get; set; }
    //    public string c5_2_2_4 { get; set; }
    //    public string c5_2_3 { get; set; }
    //    public string c5_2_3_1 { get; set; }
    //    public string c5_2_3_2_1 { get; set; }
    //    public string c5_2_3_2_2 { get; set; }
    //    public string c5_2_3_2_3 { get; set; }
    //    public string c5_2_3_3 { get; set; }
    //    public string c5_2_3_4 { get; set; }
    //    public string c5_2_4 { get; set; }
    //    public string c5_2_4_1 { get; set; }
    //    public string c5_2_4_2_1 { get; set; }
    //    public string c5_2_4_2_2 { get; set; }
    //    public string c5_2_4_2_3 { get; set; }
    //    public string c5_2_4_3 { get; set; }
    //    public string c5_2_4_4 { get; set; }
    //    public string c5_2_5 { get; set; }
    //    public string c5_2_5_1 { get; set; }
    //    public string c5_2_5_2_1 { get; set; }
    //    public string c5_2_5_2_2 { get; set; }
    //    public string c5_2_5_2_3 { get; set; }
    //    public string c5_2_5_3 { get; set; }
    //    public string c5_2_5_4 { get; set; }
    //    public string c5_2_6 { get; set; }
    //    public string c5_2_6_1 { get; set; }
    //    public string c5_2_6_2_1 { get; set; }
    //    public string c5_2_6_2_2 { get; set; }
    //    public string c5_2_6_2_3 { get; set; }
    //    public string c5_2_6_3 { get; set; }
    //    public string c5_2_6_4 { get; set; }
    //    public string c5_2_7 { get; set; }
    //    public string c5_2_7_1 { get; set; }
    //    public string c5_2_7_2_1 { get; set; }
    //    public string c5_2_7_2_2 { get; set; }
    //    public string c5_2_7_2_3 { get; set; }
    //    public string c5_2_7_3 { get; set; }
    //    public string c5_2_7_4 { get; set; }
    //    public string c5_2_8 { get; set; }
    //    public string c5_2_8_1 { get; set; }
    //    public string c5_2_8_2_1 { get; set; }
    //    public string c5_2_8_2_2 { get; set; }
    //    public string c5_2_8_2_3 { get; set; }
    //    public string c5_2_8_3 { get; set; }
    //    public string c5_2_8_4 { get; set; }
    //    public string c5_2_9 { get; set; }
    //    public string c5_2_9_1 { get; set; }
    //    public string c5_2_9_2_1 { get; set; }
    //    public string c5_2_9_2_2 { get; set; }
    //    public string c5_2_9_2_3 { get; set; }
    //    public string c5_2_9_3 { get; set; }
    //    public string c5_2_9_4 { get; set; }
    //    public string c5_2_10 { get; set; }
    //    public string c5_2_10_1 { get; set; }
    //    public string c5_2_10_2_1 { get; set; }
    //    public string c5_2_10_2_2 { get; set; }
    //    public string c5_2_10_2_3 { get; set; }
    //    public string c5_2_10_3 { get; set; }
    //    public string c5_2_10_4 { get; set; }
    //    public string c5_2_11 { get; set; }
    //    public string c5_2_11_1 { get; set; }
    //    public string c5_2_11_2_1 { get; set; }
    //    public string c5_2_11_2_2 { get; set; }
    //    public string c5_2_11_2_3 { get; set; }
    //    public string c5_2_11_3 { get; set; }
    //    public string c5_2_11_4 { get; set; }
    //    public string c5_2_12 { get; set; }
    //    public string c5_2_12_1_1 { get; set; }
    //    public string c5_2_12_1_2 { get; set; }
    //    public string c5_2_12_2_1 { get; set; }
    //    public string c5_2_12_2_2 { get; set; }
    //    public string c5_2_12_2_3 { get; set; }
    //    public string c5_2_12_3 { get; set; }
    //    public string c5_2_12_4 { get; set; }
    //}
    //public class survey_check_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string username { get; set; }
    //    public string r1 { get; set; }
    //    public string r2 { get; set; }
    //    public string r3 { get; set; }
    //    public string r4 { get; set; }
    //    public string r5 { get; set; }
    //    public string r6 { get; set; }
    //    public string r7 { get; set; }
    //    public string r8 { get; set; }
    //    public string r9 { get; set; }
    //    public int? time1 { get; set; }
    //}
    //public class survey_d2_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string d4 { get; set; }
    //    public string d4_1 { get; set; }
    //    public string d4_1_1 { get; set; }
    //    public string d4_1_2 { get; set; }
    //    public string d4_2 { get; set; }
    //    public string d4_2_1 { get; set; }
    //    public string d4_2_2 { get; set; }
    //    public string d4_3 { get; set; }
    //    public string d4_3_1 { get; set; }
    //    public string d4_3_2 { get; set; }
    //    public string d4_4 { get; set; }
    //    public string d4_4_1 { get; set; }
    //    public string d4_4_2 { get; set; }
    //    public string d4_5 { get; set; }
    //    public string d4_5_1 { get; set; }
    //    public string d4_5_2 { get; set; }
    //    public string d4_6 { get; set; }
    //    public string d4_6_1 { get; set; }
    //    public string d4_6_2 { get; set; }
    //    public string d4_7 { get; set; }
    //    public string d4_7_1 { get; set; }
    //    public string d4_7_2 { get; set; }
    //    public string d4_8 { get; set; }
    //    public string d4_8_1 { get; set; }
    //    public string d4_8_2 { get; set; }
    //    public string d4_9 { get; set; }
    //    public string d4_9_1 { get; set; }
    //    public string d4_9_2 { get; set; }
    //    public string d4_10 { get; set; }
    //    public string d4_10_1 { get; set; }
    //    public string d4_10_2 { get; set; }
    //    public string d4_11 { get; set; }
    //    public string d4_11_1 { get; set; }
    //    public string d4_11_2 { get; set; }
    //}
    //public class survey_d3_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string d5 { get; set; }
    //    public string d5_1 { get; set; }
    //    public string d5_1_1 { get; set; }
    //    public string d5_1_2 { get; set; }
    //    public string d5_2 { get; set; }
    //    public string d5_2_1 { get; set; }
    //    public string d5_2_2 { get; set; }
    //    public string d5_3 { get; set; }
    //    public string d5_3_1 { get; set; }
    //    public string d5_3_2 { get; set; }
    //    public string d5_4 { get; set; }
    //    public string d5_4_1 { get; set; }
    //    public string d5_4_2 { get; set; }
    //    public string d5_5 { get; set; }
    //    public string d5_5_1 { get; set; }
    //    public string d5_5_2 { get; set; }
    //    public string d5_6 { get; set; }
    //    public string d5_6_1 { get; set; }
    //    public string d5_6_2 { get; set; }
    //    public string d5_7 { get; set; }
    //    public string d5_7_1 { get; set; }
    //    public string d5_7_2 { get; set; }
    //    public string d5_8 { get; set; }
    //    public string d5_8_1 { get; set; }
    //    public string d5_8_2 { get; set; }
    //    public string d5_9 { get; set; }
    //    public string d5_9_1 { get; set; }
    //    public string d5_9_2 { get; set; }
    //    public string d5_10 { get; set; }
    //    public string d5_10_1 { get; set; }
    //    public string d5_10_2 { get; set; }
    //    public string d5_11 { get; set; }
    //    public string d5_11_1 { get; set; }
    //    public string d5_11_2 { get; set; }
    //}

    //public class survey_e1_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string e1_1_1 { get; set; }
    //    public string e1_1_2 { get; set; }
    //    public string e1_1_3 { get; set; }
    //    public string e1_2_1 { get; set; }
    //    public string e1_2_2 { get; set; }
    //    public string e1_2_3 { get; set; }
    //    public string e1_3_1 { get; set; }
    //    public string e1_3_2 { get; set; }
    //    public string e1_3_3 { get; set; }
    //    public string e1_4_1 { get; set; }
    //    public string e1_4_2 { get; set; }
    //    public string e1_4_3 { get; set; }
    //    public string e1_5_1 { get; set; }
    //    public string e1_5_2 { get; set; }
    //    public string e1_5_3 { get; set; }
    //    public string e1_6_4 { get; set; }
    //    public string e1_6_1 { get; set; }
    //    public string e1_6_2 { get; set; }
    //    public string e1_6_3 { get; set; }
    //}

    //public class survey_e2_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string e2_1_1 { get; set; }
    //    public string e2_1_2 { get; set; }
    //    public string e2_1_3 { get; set; }
    //    public string e2_1_4 { get; set; }
    //    public string e2_2_1 { get; set; }
    //    public string e2_2_2 { get; set; }
    //    public string e2_2_3 { get; set; }
    //    public string e2_2_4 { get; set; }
    //    public string e2_3_1 { get; set; }
    //    public string e2_3_2 { get; set; }
    //    public string e2_3_3 { get; set; }
    //    public string e2_3_4 { get; set; }
    //    public string e2_4_1 { get; set; }
    //    public string e2_4_2 { get; set; }
    //    public string e2_4_3 { get; set; }
    //    public string e2_4_4 { get; set; }
    //    public string e2_5_5 { get; set; }
    //    public string e2_5_1 { get; set; }
    //    public string e2_5_2 { get; set; }
    //    public string e2_5_3 { get; set; }
    //    public string e2_5_4 { get; set; }
    //}
    //public class survey_e3_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string e3 { get; set; }
    //    public string e4 { get; set; }
    //    public string e5 { get; set; }
    //    public string e6 { get; set; }
    //    public string e7_1 { get; set; }
    //    public string e7_2 { get; set; }
    //    public string e7_3 { get; set; }
    //    public string e7_4 { get; set; }
    //    public string e7_5 { get; set; }
    //    public string e7_6 { get; set; }
    //    public string e7_7 { get; set; }
    //    public string e7_8 { get; set; }
    //    public string e7_9 { get; set; }
    //    public string e7_10 { get; set; }
    //    public string e7_11 { get; set; }
    //    public string e7_11_1 { get; set; }
    //    public string e8 { get; set; }
    //    public string e8_1_1 { get; set; }
    //    public string e8_1_2 { get; set; }
    //    public string e8_1_3 { get; set; }
    //    public string e8_1_4 { get; set; }
    //    public string e8_1_4_1 { get; set; }
    //    public string e8_2_1 { get; set; }
    //    public string e8_2_2 { get; set; }
    //    public string e8_2_3 { get; set; }
    //    public string e8_2_4 { get; set; }
    //    public string e8_2_5 { get; set; }
    //    public string e8_2_6 { get; set; }
    //    public string e8_2_7 { get; set; }
    //    public string e8_2_8 { get; set; }
    //    public string e8_2_9 { get; set; }
    //    public string e8_2_10 { get; set; }
    //    public string e8_2_11 { get; set; }
    //    public string e8_2_11_1 { get; set; }
    //    public string e9_1 { get; set; }
    //    public string e9_2 { get; set; }
    //    public string e9_3 { get; set; }
    //    public string e9_4 { get; set; }
    //    public string e10_1 { get; set; }
    //    public string e10_2 { get; set; }
    //    public string e10_3 { get; set; }
    //    public string e10_4 { get; set; }
    //}
    //public class survey_f1_2
    //{
    //    public string r1 { get; set; }
    //    public string r2 { get; set; }
    //    public string r3 { get; set; }
    //    public string r4 { get; set; }
    //    public string r5 { get; set; }
    //    public string r6 { get; set; }
    //    public string r7 { get; set; }
    //    public string r8 { get; set; }
    //    public string r9 { get; set; }
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string comment1 { get; set; }
    //    public string comment2 { get; set; }
    //}
    //public class survey_profile_2
    //{
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string AGRI { get; set; }
    //    public string AGRI_NO { get; set; }
    //    public string MBNO { get; set; }
    //    public string MB { get; set; }
    //    public string MM { get; set; }
    //    public string TMP { get; set; }
    //    public string AMP { get; set; }
    //    public string JUN { get; set; }
    //    public string POSTCODE { get; set; }
    //    public string popid { get; set; }
    //    public string PREFIX { get; set; }
    //    public string TEL { get; set; }
    //    public string HHM { get; set; }
    //    public string PP { get; set; }
    //    public string PPP { get; set; }
    //    public string lat { get; set; }
    //    public string lng { get; set; }
    //    public string photo { get; set; }
    //    public string PERSON { get; set; }
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int? id { get; set; }
    //    public int? last_edit { get; set; }
    //    public int? create_time { get; set; }
    //    public int? create_survey { get; set; }
    //    public string MM1 { get; set; }
    //    public string PERSON_PREFIX { get; set; }
    //    public string PERSON_NAME { get; set; }
    //    public string PERSON_SNAME { get; set; }
    //    public string PERSON_POPID { get; set; }
    //    public string HOST_PREFIX { get; set; }
    //    public string HOST_NAME { get; set; }
    //    public string HOST_SNAME { get; set; }
    //    public string HOST_POPID { get; set; }
    //    public int? NO1 { get; set; }
    //    public int? NO2 { get; set; }
    //    public int? NO3 { get; set; }
    //    public int? NO4 { get; set; }
    //    public int? NO5 { get; set; }
    //    public string SURVEYER_PREFIX { get; set; }
    //    public string SURVEYER_NAME { get; set; }
    //    public string SURVEYER_SNAME { get; set; }
    //    public string SURVEYER_TEL { get; set; }
    //    public string SURVEYER_DATE { get; set; }
    //    public string SURVEYER_TIME { get; set; }
    //    public string HOST_POPID1 { get; set; }
    //    public string PERSON_POPID1 { get; set; }
    //    public string HC1 { get; set; }
    //    public string status { get; set; }


    //}
    //public class survey_f_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string f2 { get; set; }
    //    public string f1_1 { get; set; }
    //    public string f1_2 { get; set; }
    //    public string f1_2_1 { get; set; }
    //    public string f1_3 { get; set; }
    //    public string f1_3_1 { get; set; }
    //    public string f2_1 { get; set; }
    //    public string f2_2 { get; set; }
    //    public string f2_2_1 { get; set; }
    //    public string f2_2_2 { get; set; }
    //    public string f2_2_3 { get; set; }
    //    public string f2_2_4 { get; set; }
    //    public string f2_2_5 { get; set; }
    //    public string f2_2_5_1 { get; set; }
    //    public string f2_3_1 { get; set; }
    //    public string f2_3_2 { get; set; }
    //    public string f2_3_3 { get; set; }
    //    public string f2_3_4 { get; set; }
    //    public string f2_3_5 { get; set; }
    //    public string f2_3_6 { get; set; }
    //    public string f2_3_7 { get; set; }
    //    public string f2_3_8 { get; set; }
    //    public string f2_3_9 { get; set; }
    //    public string f2_3_10 { get; set; }
    //    public string f2_3_10_1 { get; set; }
    //    public string f2_4_1 { get; set; }
    //    public string f2_4_2 { get; set; }
    //    public string f2_4_3 { get; set; }
    //    public string f2_4_4 { get; set; }
    //    public string f2_4_5 { get; set; }
    //    public string f2_4_6 { get; set; }
    //    public string f2_4_7 { get; set; }
    //    public string f2_4_8 { get; set; }
    //    public string f2_4_8_1 { get; set; }
    //}
    //public class survey_staff_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string staff { get; set; }
    //    public int? ch1_st { get; set; }
    //    public int? ch1_sp { get; set; }
    //    public int? ch2_st { get; set; }
    //    public int? ch2_sp { get; set; }
    //    public int? ch3_st { get; set; }
    //    public int? ch3_sp { get; set; }
    //    public int? ch4_st { get; set; }
    //    public int? ch4_sp { get; set; }
    //    public int? ch5_st { get; set; }
    //    public int? ch5_sp { get; set; }
    //}
    //public class surwaya_tmp_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string a1 { get; set; }
    //    public string a2 { get; set; }
    //    public string popid { get; set; }
    //    public string a3 { get; set; }
    //    public string a4 { get; set; }
    //    public string a5 { get; set; }
    //    public string a6 { get; set; }
    //    public string a9 { get; set; }
    //    public string a10 { get; set; }
    //    public string a11 { get; set; }
    //    public string a12 { get; set; }
    //    public string a13 { get; set; }
    //    public string a14 { get; set; }
    //    public string a15 { get; set; }
    //    public string a16 { get; set; }
    //    public string a17 { get; set; }
    //    public string a7_8 { get; set; }
    //}
    //public class tasaban_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public int? id { get; set; }
    //    public string JUN { get; set; }
    //    public string AMP { get; set; }
    //    public string name { get; set; }
    //    public int? level { get; set; }
    //}
    //public class tpmap_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string JUN { get; set; }
    //    public int? goal { get; set; }
    //}
    //public class survey_d1_2
    //{
    //    [IndexDbKey(AutoIncrement = true)]
    //    public string HC { get; set; }
    //    public string survey_year { get; set; }
    //    public string survey_no { get; set; }
    //    public string d1_1 { get; set; }
    //    public string d1_2 { get; set; }
    //    public string d2 { get; set; }
    //    public string d2_3 { get; set; }
    //    public string d2_3_1 { get; set; }
    //    public string d3 { get; set; }
    //    public string d3_1 { get; set; }
    //    public string d3_2 { get; set; }
    //    public string d3_3 { get; set; }
    //    public string d3_3_1 { get; set; }
    //}
    public class person
    {
        [IndexDbKey(AutoIncrement = true)]
        public string id { get; set; }
        public string HC { get; set; }
        public string JUN { get; set; }
        public string AMP { get; set; }
        public string TMP { get; set; }
        public int perid { get; set; }
        public string pid { get; set; }
        public string preid { get; set; }
        public string nme { get; set; }
        public string surnme { get; set; }
        public DateTime? brtdte { get; set; }
        public int age { get; set; }
        [Range(typeof(string), "1", "1", ErrorMessage = "Male gender is required.")]
        public string sex { get; set; } = "1";
        public string reg { get; set; }
        public string stsmar { get; set; }
        public int numchi { get; set; }
        public int numchistd { get; set; }
        public string edulev { get; set; }
        public string currlevid { get; set; }
        public string blood_type { get; set; }
        public string occid { get; set; }
        public string add_occid { get; set; }
        public float sal { get; set; }
        public string roladr { get; set; }
        public string rolvllsoi { get; set; }
        public string rolvllno { get; set; }
        public string rolplcid { get; set; }
        public string tel { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string house_conid { get; set; }
        public string picname1 { get; set; }
        public string picname2 { get; set; }
        public string[] congenital_disease { get; set; }
        public string congenital_disease_oth { get; set; }
        public string[] medical_permis { get; set; }
        public string medical_permis_oth { get; set; }
        public string medical_permis_office { get; set; }
        public string vaccination_id { get; set; }
        public string num_covid { get; set; }
        public string pertypid { get; set; }
        public string elderly_grpid { get; set; }
        public string distypid { get; set; }
        public string hav_attendant { get; set; }
        public string main_attendant_nme { get; set; }
        public string main_attendant_surnme { get; set; }
        public DateTime? main_attendant_brtdte { get; set; }
        public string main_attendant_rel { get; set; }
        public string main_attendant_occid { get; set; }
        public float main_attendant_sal { get; set; }
        public string main_attendant_tel { get; set; }
        public string optid { get; set; }
        public string alive { get; set; }
        public string percmm { get; set; }
        public int savofc { get; set; }
        public string savdte { get; set; }
        public int updofc { get; set; }
        public int upddte { get; set; }
    }
}

