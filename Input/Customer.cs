namespace SalesiteIntegration.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ssdata.customer")]
    public partial class Customer
    {
        public int? cst_rbanum { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cst_salenum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? cst_saledate { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string cst_ownercode { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cst_bidnum { get; set; }

        public int? cst_exp_bidnum { get; set; }

        [StringLength(150)]
        public string cst_coname { get; set; }

        [StringLength(1)]
        public string cst_exp_bidtype { get; set; }

        [StringLength(50)]
        public string cst_addr1 { get; set; }

        [StringLength(50)]
        public string cst_addr2 { get; set; }

        [StringLength(50)]
        public string cst_addr3 { get; set; }

        [StringLength(60)]
        public string cst_city { get; set; }

        [StringLength(20)]
        public string cst_postalzip { get; set; }

        [StringLength(3)]
        public string cst_country { get; set; }

        [StringLength(3)]
        public string cst_prov_state { get; set; }

        [StringLength(75)]
        public string cst_f_name { get; set; }

        [StringLength(5)]
        public string cst_initial { get; set; }

        [StringLength(75)]
        public string cst_l_name { get; set; }

        [StringLength(75)]
        public string cst_title { get; set; }

        [StringLength(20)]
        public string cst_id_type { get; set; }

        [StringLength(3)]
        public string cst_id_origin { get; set; }

        [StringLength(35)]
        public string cst_id_number { get; set; }

        [StringLength(3)]
        public string cst_tel_route { get; set; }

        [StringLength(8)]
        public string cst_tel_area { get; set; }

        [StringLength(15)]
        public string cst_tel_num { get; set; }

        [StringLength(8)]
        public string cst_fax_area { get; set; }

        [StringLength(15)]
        public string cst_fax_num { get; set; }

        [StringLength(8)]
        public string cst_cell_area { get; set; }

        [StringLength(15)]
        public string cst_cell_num { get; set; }

        [StringLength(8)]
        public string cst_res_area { get; set; }

        [StringLength(15)]
        public string cst_res_num { get; set; }

        [StringLength(20)]
        public string cst_ext { get; set; }

        [StringLength(25)]
        public string cst_other_num { get; set; }

        [StringLength(75)]
        public string cst_email { get; set; }

        public int? cst_yr_added { get; set; }

        public int? cst_last_active { get; set; }

        [StringLength(1)]
        public string cst_mailing_status { get; set; }

        [StringLength(1)]
        public string cst_caution_status { get; set; }

        public int? cst_prim_terr { get; set; }

        public int? cst_prim_bank { get; set; }

        public int? cst_prim_industry { get; set; }

        public int? cst_exp_bidissueddate { get; set; }

        [StringLength(500)]
        public string cst_notes { get; set; }

        [StringLength(50)]
        public string cst_buyervatid { get; set; }

        [StringLength(20)]
        public string cst_owntype { get; set; }

        [StringLength(25)]
        public string cst_owncountry { get; set; }

        [StringLength(50)]
        public string cst_tax1type { get; set; }

        [StringLength(50)]
        public string cst_tax1state { get; set; }

        [StringLength(50)]
        public string cst_tax1number { get; set; }

        [StringLength(50)]
        public string cst_tax2type { get; set; }

        [StringLength(50)]
        public string cst_tax2state { get; set; }

        [StringLength(50)]
        public string cst_tax2number { get; set; }

        [StringLength(50)]
        public string cst_tax3type { get; set; }

        [StringLength(50)]
        public string cst_tax3state { get; set; }

        [StringLength(50)]
        public string cst_tax3number { get; set; }

        [StringLength(500)]
        public string cst_tax1note { get; set; }

        [StringLength(500)]
        public string cst_tax2note { get; set; }

        [StringLength(500)]
        public string cst_tax3note { get; set; }

        [StringLength(30)]
        public string cst_saletax { get; set; }

        [StringLength(3)]
        public string cst_sownercode { get; set; }

        public int? cst_counter { get; set; }

        public int? cst_donotcontact { get; set; }

        [StringLength(3)]
        public string cst_fax_route { get; set; }

        [StringLength(3)]
        public string cst_cell_route { get; set; }

        [StringLength(3)]
        public string cst_res_route { get; set; }

        public int? cst_prefercommunication { get; set; }

        public int? cst_report_donotsend { get; set; }

        [StringLength(75)]
        public string cst_altemail { get; set; }

        [StringLength(20)]
        public string cst_pan { get; set; }

        [StringLength(20)]
        public string cst_tan { get; set; }

        public int? cst_stat_buysales { get; set; }

        public int? cst_stat_consales { get; set; }

        public decimal? cst_stat_buyamount { get; set; }

        public decimal? cst_stat_conamount { get; set; }

        public decimal? cst_pur_threshold { get; set; }

        [StringLength(255)]
        public string cst_industry_code { get; set; }

        public int? cst_wt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long cst_change_sequence { get; set; }

        [StringLength(50)]
        public string cst_replica_id { get; set; }

        [StringLength(3)]
        public string cst_customer_type { get; set; }

        public int? cst_per_party_id { get; set; }

        public int? cst_org_party_id { get; set; }

        [StringLength(1)]
        public string cst_loyalty_type { get; set; }

        [Column(TypeName = "date")]
        public DateTime? cst_customer_card_issue_date { get; set; }

        public int? cst_tax_verification_status { get; set; }

        [Column(TypeName = "date")]
        public DateTime? cst_tax_verification_date { get; set; }

        [StringLength(7)]
        public string cst_last_updated_by { get; set; }

        [StringLength(8)]
        public string cst_saletax_type { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int cst_customer_party_id { get; set; }

        public int cst_customer_party_id_counter { get; set; }

        public int cst_per_party_rowversion { get; set; }

        public int cst_org_party_rowversion { get; set; }

        public int cst_relationship_rowversion { get; set; }

        public int? cst_merge_victor_customer_id { get; set; }

        public DateTime? cst_b2b_relation_end_date { get; set; }

        public DateTime? cst_last_printed_date { get; set; }

        [Required]
        [StringLength(1)]
        public string cst_possible_duplicates_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string cst_customer_status { get; set; }

        [StringLength(75)]
        public string cst_ushipkey { get; set; }

        public int cst_columnchangebitmap { get; set; }

        [StringLength(10)]
        public string cst_coname_prefix { get; set; }
    }
}
