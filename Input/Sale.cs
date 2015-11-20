namespace SalesiteIntegration.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ssdata.salevars")]
    public partial class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sv_salenum { get; set; }

        [StringLength(50)]
        public string sv_office { get; set; }

        [Column(TypeName = "date")]
        public DateTime? sv_saledate { get; set; }

        public int? sv_saledays { get; set; }

        [Column(TypeName = "date")]
        public DateTime? sv_dfltdate { get; set; }

        public int? sv_dfltdays { get; set; }

        public int? sv_rr_surcharge { get; set; }

        public int? sv_haul_surcharge { get; set; }

        public decimal? sv_doc_fee { get; set; }

        public int? sv_mincomrt { get; set; }

        public decimal? sv_mincomamt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? sv_eqremovedate { get; set; }

        [StringLength(150)]
        public string sv_notes { get; set; }

        [StringLength(4)]
        public string sv_currency { get; set; }

        [StringLength(30)]
        public string sv_addr1 { get; set; }

        [StringLength(30)]
        public string sv_addr2 { get; set; }

        [StringLength(25)]
        public string sv_addr3 { get; set; }

        [StringLength(30)]
        public string sv_city { get; set; }

        [StringLength(25)]
        public string sv_prov { get; set; }

        [StringLength(25)]
        public string sv_country { get; set; }

        [StringLength(15)]
        public string sv_postal { get; set; }

        [StringLength(3)]
        public string sv_rt_code { get; set; }

        [StringLength(5)]
        public string sv_tel_area { get; set; }

        [StringLength(15)]
        public string sv_tel_num { get; set; }

        [StringLength(5)]
        public string sv_fax_area { get; set; }

        [StringLength(15)]
        public string sv_fax_num { get; set; }

        [StringLength(20)]
        public string sv_tax1_cat { get; set; }

        [StringLength(30)]
        public string sv_tax1_desc { get; set; }

        public decimal? sv_tax1_rate { get; set; }

        public int? sv_tax1_default { get; set; }

        [Column(TypeName = "date")]
        public DateTime? sv_tax1_chgdate { get; set; }

        public int? sv_tax1_pretax { get; set; }

        public int? sv_tax1_calc { get; set; }

        [StringLength(20)]
        public string sv_tax2_cat { get; set; }

        [StringLength(30)]
        public string sv_tax2_desc { get; set; }

        public decimal? sv_tax2_rate { get; set; }

        public int? sv_tax2_default { get; set; }

        [Column(TypeName = "date")]
        public DateTime? sv_tax2_chgdate { get; set; }

        public int? sv_tax2_pretax { get; set; }

        public int? sv_tax2_calc { get; set; }

        [StringLength(20)]
        public string sv_tax3_cat { get; set; }

        [StringLength(30)]
        public string sv_tax3_desc { get; set; }

        public decimal? sv_tax3_rate { get; set; }

        public int? sv_tax3_default { get; set; }

        [Column(TypeName = "date")]
        public DateTime? sv_tax3_chgdate { get; set; }

        public int? sv_tax3_pretax { get; set; }

        public int? sv_tax3_calc { get; set; }

        [StringLength(20)]
        public string sv_tax4_cat { get; set; }

        [StringLength(30)]
        public string sv_tax4_desc { get; set; }

        public int? sv_tax4_rate { get; set; }

        public int? sv_tax4_default { get; set; }

        [Column(TypeName = "date")]
        public DateTime? sv_tax4_chgdate { get; set; }

        public int? sv_tax4_pretax { get; set; }

        public int? sv_tax4_calc { get; set; }

        [StringLength(25)]
        public string sv_shipto { get; set; }

        [StringLength(25)]
        public string sv_invoiceto { get; set; }

        [StringLength(15)]
        public string sv_supptax1_desc { get; set; }

        public decimal? sv_supptax1_rate { get; set; }

        [StringLength(50)]
        public string sv_supptax2_desc { get; set; }

        public int? sv_supptax2_rate { get; set; }

        [StringLength(50)]
        public string sv_supptax3_desc { get; set; }

        public int? sv_supptax3_rate { get; set; }

        public int? sv_lotflag { get; set; }

        [StringLength(5)]
        public string sv_tocurrency { get; set; }

        [StringLength(30)]
        public string sv_rba_tax { get; set; }

        [StringLength(1)]
        public string sv_country_version { get; set; }

        public int? sv_counter { get; set; }

        public decimal? sv_slamount { get; set; }

        public decimal? sv_slrate { get; set; }

        public int? sv_sltax1 { get; set; }

        public int? sv_sltax2 { get; set; }

        public int? sv_sltax3 { get; set; }

        public int? sv_sltax4 { get; set; }

        public decimal? sv_prxcapamt { get; set; }

        public decimal? sv_prxrate { get; set; }

        public decimal? sv_intcapamt { get; set; }

        public decimal? sv_intrate { get; set; }

        public int? sv_minprxbidnum { get; set; }

        public int? sv_maxprxbidnum { get; set; }

        public int? sv_minintbidnum { get; set; }

        public int? sv_maxintbidnum { get; set; }

        public int? sv_prxintfeetax1 { get; set; }

        public int? sv_prxintfeetax2 { get; set; }

        public int? sv_prxintfeetax3 { get; set; }

        public int? sv_prxintfeetax4 { get; set; }

        [StringLength(50)]
        public string sv_replyaddress { get; set; }

        public int? sv_auction_type { get; set; }

        [StringLength(255)]
        public string sv_owner_faxemailmsg { get; set; }

        [StringLength(255)]
        public string sv_buyer_faxemailmsg { get; set; }

        public int? sv_taxrecap { get; set; }

        [StringLength(1)]
        public string sv_tal_sale { get; set; }

        [StringLength(50)]
        public string sv_tal_timetext { get; set; }

        [StringLength(1)]
        public string sv_tal_transfer_on { get; set; }

        [StringLength(1)]
        public string sv_tal_results_on { get; set; }

        public decimal? sv_cst_pur_threshold { get; set; }

        [StringLength(255)]
        public string sv_buyer_faxemailmsg2 { get; set; }

        [StringLength(255)]
        public string sv_buyer_faxemailmsg3 { get; set; }

        public decimal? sv_bfrate { get; set; }

        public decimal? sv_bfcapamt { get; set; }

        public int? sv_invoice { get; set; }

        [StringLength(20)]
        public string sv_mvdealernum { get; set; }

        public int? sv_dataquality { get; set; }

        public int? sv_bandwidth { get; set; }

        public int? sv_con_entry_allowed { get; set; }

        public int? sv_con_polling_enabled { get; set; }

        public int? sv_sfa_integration_seq { get; set; }

        public int? sv_sfa_integration_bitmap { get; set; }

        public DateTime? sv_lotflag_timestamp { get; set; }

        public int? sv_taxengine { get; set; }
    }
}
