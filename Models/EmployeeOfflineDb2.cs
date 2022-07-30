using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DnetIndexedDb;
using DnetIndexedDb.Models;
using Microsoft.JSInterop;
using static FirstBlazorApp.Models.compute_hc4;

namespace FirstBlazorApp.Models
{
    public class EmployeeOfflineDb2 : IndexedDbDatabaseModel
    {
        public EmployeeOfflineDb2()
        {
            Name = "EmployeeData2";
            Version = 63;
            Stores = _stores;
        }
        private IndexedDbStore _tableFieldStore => new TStore<Employee2345>();
        private IndexedDbStore _tableFieldStore2 => new TStore<province_2>();
        private IndexedDbStore _tableFieldStore3 => new TStore<tambon_2>();
        private IndexedDbStore _tableFieldStore4 => new TStore<district_2>();
        private IndexedDbStore _tableFieldStore71 => new TStore<ch2_gis_2>();
        private IndexedDbStore _tableFieldStore5 => new TStore<ch2_gis2_2>();
        private IndexedDbStore _tableFieldStore6 => new TStore<compute_hc1_2>();
        private IndexedDbStore _tableFieldStore7 => new TStore<compute_hc2_2>();
        private IndexedDbStore _tableFieldStore8 => new TStore<compute_hc3_2>();
        private IndexedDbStore _tableFieldStore9 => new TStore<compute_hc4_2>();
        private IndexedDbStore _tableFieldStore11 => new TStore<employee_2>();
        private IndexedDbStore _tableFieldStore12 => new TStore<hc_result_2>();
        private IndexedDbStore _tableFieldStore13 => new TStore<hc_sum_2>();
        private IndexedDbStore _tableFieldStore14 => new TStore<hc_sum1_2>();
        private IndexedDbStore _tableFieldStore15 => new TStore<hc_sum2_2>();
        private IndexedDbStore _tableFieldStore16 => new TStore<hc_sum3_2>();
        private IndexedDbStore _tableFieldStore17 => new TStore<hc_sum4_2>();
        private IndexedDbStore _tableFieldStore18 => new TStore<hc_sum5_2>();
        private IndexedDbStore _tableFieldStore19 => new TStore<hc_sum6_2>();
        private IndexedDbStore _tableFieldStore20 => new TStore<hc_sum_check1_2>();
        private IndexedDbStore _tableFieldStore21 => new TStore<hc_sum_check2_2>();
        private IndexedDbStore _tableFieldStore22 => new TStore<income_2>();
        private IndexedDbStore _tableFieldStore23 => new TStore<income_edit_2>();
        private IndexedDbStore _tableFieldStore24 => new TStore<income_eef_2>();
        private IndexedDbStore _tableFieldStore25 => new TStore<insert_hc_2>();
        private IndexedDbStore _tableFieldStore26 => new TStore<jun_finish_2>();
        private IndexedDbStore _tableFieldStore27 => new TStore<jun_level_detail_2>();
        private IndexedDbStore _tableFieldStore28 => new TStore<jun_location_2>();
        private IndexedDbStore _tableFieldStore29 => new TStore<line_poor_rich_2>();
        private IndexedDbStore _tableFieldStore30 => new TStore<livingon_tpmap_2>();
        private IndexedDbStore _tableFieldStore31 => new TStore<livingon_tpmap2_2>();
        private IndexedDbStore _tableFieldStore32 => new TStore<livingon_tpmap3_2>();
        private IndexedDbStore _tableFieldStore33 => new TStore<livingon_tpmap4_2>();
        private IndexedDbStore _tableFieldStore34 => new TStore<log_file_2>();
        private IndexedDbStore _tableFieldStore35 => new TStore<log_file__2>();
        private IndexedDbStore _tableFieldStore36 => new TStore<mm_2>();
        private IndexedDbStore _tableFieldStore37 => new TStore<poverty_2>();
        private IndexedDbStore _tableFieldStore38 => new TStore<poverty_pattani_2>();
        private IndexedDbStore _tableFieldStore39 => new TStore<province_2>();
        private IndexedDbStore _tableFieldStore40 => new TStore<region_2>();
        private IndexedDbStore _tableFieldStore41 => new TStore<snapshot_2>();
        private IndexedDbStore _tableFieldStore42 => new TStore<staff_jun_2>();
        private IndexedDbStore _tableFieldStore43 => new TStore<survey_a1_2>();
        private IndexedDbStore _tableFieldStore44 => new TStore<survey_a2_2>();
        private IndexedDbStore _tableFieldStore45 => new TStore<survey_b1_2>();
        private IndexedDbStore _tableFieldStore46 => new TStore<survey_b2_2>();
        private IndexedDbStore _tableFieldStore47 => new TStore<survey_b3_2>();
        private IndexedDbStore _tableFieldStore48 => new TStore<survey_c1_2>();
        private IndexedDbStore _tableFieldStore49 => new TStore<survey_c2_2>();
        private IndexedDbStore _tableFieldStore50 => new TStore<survey_check_2>();
        private IndexedDbStore _tableFieldStore51 => new TStore<survey_d1_2>();
        private IndexedDbStore _tableFieldStore52 => new TStore<survey_d2_2>();
        private IndexedDbStore _tableFieldStore53 => new TStore<survey_d3_2>();
        private IndexedDbStore _tableFieldStore54 => new TStore<survey_e1_2>();
        private IndexedDbStore _tableFieldStore55 => new TStore<survey_e2_2>();
        private IndexedDbStore _tableFieldStore56 => new TStore<survey_e3_2>();
        private IndexedDbStore _tableFieldStore57 => new TStore<survey_f1_2>();
        private IndexedDbStore _tableFieldStore58 => new TStore<survey_profile_2>();
        private IndexedDbStore _tableFieldStore59 => new TStore<survey_staff_2>();
        private IndexedDbStore _tableFieldStore60 => new TStore<surwaya_tmp_2>();
        private IndexedDbStore _tableFieldStore61 => new TStore<tambon_2>();
        private IndexedDbStore _tableFieldStore62 => new TStore<tasaban_2>();
        private IndexedDbStore _tableFieldStore63 => new TStore<tpmap_2>();
        private IndexedDbStore _tableFieldStore64 => new TStore<tpmap_pattani_2>();
        private IndexedDbStore _tableFieldStore65 => new TStore<tpmap_pattani2_2>();
        private IndexedDbStore _tableFieldStore66 => new TStore<t_tambon_2>();
        private IndexedDbStore _tableFieldStore67 => new TStore<update_hc_2>();
        private IndexedDbStore _tableFieldStore68 => new TStore<upload_pic_2>();
        private IndexedDbStore _tableFieldStore69 => new TStore<users_2>();
        private IndexedDbStore _tableFieldStore70 => new TStore<volunteer_2>();

        private IndexedDbStore _tableFieldStore72 => new TStore<survey_f_2>();
        private List<IndexedDbStore> _stores => new List<IndexedDbStore>
        {
            _tableFieldStore,_tableFieldStore2,_tableFieldStore4,_tableFieldStore3,_tableFieldStore5,
            _tableFieldStore6,_tableFieldStore7,_tableFieldStore8,_tableFieldStore9,_tableFieldStore11,
            _tableFieldStore12,_tableFieldStore13,_tableFieldStore14,_tableFieldStore15,_tableFieldStore16,_tableFieldStore17,
            _tableFieldStore18,_tableFieldStore19,_tableFieldStore20,_tableFieldStore21,_tableFieldStore22,_tableFieldStore23,
            _tableFieldStore24,_tableFieldStore25,_tableFieldStore26,_tableFieldStore27,_tableFieldStore28,_tableFieldStore29,
            _tableFieldStore30,_tableFieldStore31,_tableFieldStore32,_tableFieldStore33,_tableFieldStore34,_tableFieldStore35,
            _tableFieldStore36,_tableFieldStore37,_tableFieldStore38,_tableFieldStore40,_tableFieldStore41,
            _tableFieldStore42,_tableFieldStore43,_tableFieldStore44,_tableFieldStore45,_tableFieldStore46,_tableFieldStore47,
            _tableFieldStore48,_tableFieldStore49,_tableFieldStore50,_tableFieldStore51,_tableFieldStore52,_tableFieldStore53,
            _tableFieldStore54,_tableFieldStore55,_tableFieldStore56,_tableFieldStore57,_tableFieldStore58,_tableFieldStore59,
            _tableFieldStore60,_tableFieldStore62,_tableFieldStore63,_tableFieldStore64,_tableFieldStore65,
            _tableFieldStore66,_tableFieldStore67,_tableFieldStore68,_tableFieldStore69,_tableFieldStore70,_tableFieldStore71,_tableFieldStore72

        };
    
}

        public class Employee2345
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


    public class EmployeeContext2 : IndexedDbInterop
    {

        public EmployeeContext2(IJSRuntime jSRuntime, IndexedDbOptions<EmployeeContext2> options) : base(jSRuntime, options) { }
    }

           
}
