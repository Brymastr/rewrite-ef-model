namespace SalesiteIntegration.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ssdata.salevars")]
    public partial class SaleVars
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("sv_salenum")]
        public int SvSalenum { get; set; }

        [StringLength(50)]
		[Column("sv_office")]
        public string SvOffice { get; set; }

		[Column("sv_saledate", TypeName = "date")]
        public DateTime? SvSaledate { get; set; }

		[Column("sv_saledays")]
        public int? SvSaledays { get; set; }

		[Column("sv_dfltdate", TypeName = "date")]
        public DateTime? SvDfltdate { get; set; }

		[Column("sv_dfltdays")]
        public int? SvDfltdays { get; set; }

		[Column("sv_rr_surcharge")]
        public int? SvRrSurcharge { get; set; }

		[Column("sv_haul_surcharge")]
        public int? SvHaulSurcharge { get; set; }

		[Column("sv_doc_fee")]
        public decimal? SvDocFee { get; set; }

		[Column("sv_mincomrt")]
        public int? SvMincomrt { get; set; }

		[Column("sv_mincomamt")]
        public decimal? SvMincomamt { get; set; }

		[Column("sv_eqremovedate", TypeName = "date")]
        public DateTime? SvEqremovedate { get; set; }

        [StringLength(150)]
		[Column("sv_notes")]
        public string SvNotes { get; set; }

        [StringLength(4)]
		[Column("sv_currency")]
        public string SvCurrency { get; set; }

        [StringLength(30)]
		[Column("sv_addr1")]
        public string SvAddr1 { get; set; }

        [StringLength(30)]
		[Column("sv_addr2")]
        public string SvAddr2 { get; set; }

        [StringLength(25)]
		[Column("sv_addr3")]
        public string SvAddr3 { get; set; }

        [StringLength(30)]
		[Column("sv_city")]
        public string SvCity { get; set; }

        [StringLength(25)]
		[Column("sv_prov")]
        public string SvProv { get; set; }

        [StringLength(25)]
		[Column("sv_country")]
        public string SvCountry { get; set; }

        [StringLength(15)]
		[Column("sv_postal")]
        public string SvPostal { get; set; }

        [StringLength(3)]
		[Column("sv_rt_code")]
        public string SvRtCode { get; set; }

        [StringLength(5)]
		[Column("sv_tel_area")]
        public string SvTelArea { get; set; }

        [StringLength(15)]
		[Column("sv_tel_num")]
        public string SvTelNum { get; set; }

        [StringLength(5)]
		[Column("sv_fax_area")]
        public string SvFaxArea { get; set; }

        [StringLength(15)]
		[Column("sv_fax_num")]
        public string SvFaxNum { get; set; }

        [StringLength(20)]
		[Column("sv_tax1_cat")]
        public string SvTax1Cat { get; set; }

        [StringLength(30)]
		[Column("sv_tax1_desc")]
        public string SvTax1Desc { get; set; }

		[Column("sv_tax1_rate")]
        public decimal? SvTax1Rate { get; set; }

		[Column("sv_tax1_default")]
        public int? SvTax1Default { get; set; }

		[Column("sv_tax1_chgdate", TypeName = "date")]
        public DateTime? SvTax1Chgdate { get; set; }

		[Column("sv_tax1_pretax")]
        public int? SvTax1Pretax { get; set; }

		[Column("sv_tax1_calc")]
        public int? SvTax1Calc { get; set; }

        [StringLength(20)]
		[Column("sv_tax2_cat")]
        public string SvTax2Cat { get; set; }

        [StringLength(30)]
		[Column("sv_tax2_desc")]
        public string SvTax2Desc { get; set; }

		[Column("sv_tax2_rate")]
        public decimal? SvTax2Rate { get; set; }

		[Column("sv_tax2_default")]
        public int? SvTax2Default { get; set; }

		[Column("sv_tax2_chgdate", TypeName = "date")]
        public DateTime? SvTax2Chgdate { get; set; }

		[Column("sv_tax2_pretax")]
        public int? SvTax2Pretax { get; set; }

		[Column("sv_tax2_calc")]
        public int? SvTax2Calc { get; set; }

        [StringLength(20)]
		[Column("sv_tax3_cat")]
        public string SvTax3Cat { get; set; }

        [StringLength(30)]
		[Column("sv_tax3_desc")]
        public string SvTax3Desc { get; set; }

		[Column("sv_tax3_rate")]
        public decimal? SvTax3Rate { get; set; }

		[Column("sv_tax3_default")]
        public int? SvTax3Default { get; set; }

		[Column("sv_tax3_chgdate", TypeName = "date")]
        public DateTime? SvTax3Chgdate { get; set; }

		[Column("sv_tax3_pretax")]
        public int? SvTax3Pretax { get; set; }

		[Column("sv_tax3_calc")]
        public int? SvTax3Calc { get; set; }

        [StringLength(20)]
		[Column("sv_tax4_cat")]
        public string SvTax4Cat { get; set; }

        [StringLength(30)]
		[Column("sv_tax4_desc")]
        public string SvTax4Desc { get; set; }

		[Column("sv_tax4_rate")]
        public int? SvTax4Rate { get; set; }

		[Column("sv_tax4_default")]
        public int? SvTax4Default { get; set; }

		[Column("sv_tax4_chgdate", TypeName = "date")]
        public DateTime? SvTax4Chgdate { get; set; }

		[Column("sv_tax4_pretax")]
        public int? SvTax4Pretax { get; set; }

		[Column("sv_tax4_calc")]
        public int? SvTax4Calc { get; set; }

        [StringLength(25)]
		[Column("sv_shipto")]
        public string SvShipto { get; set; }

        [StringLength(25)]
		[Column("sv_invoiceto")]
        public string SvInvoiceto { get; set; }

        [StringLength(15)]
		[Column("sv_supptax1_desc")]
        public string SvSupptax1Desc { get; set; }

		[Column("sv_supptax1_rate")]
        public decimal? SvSupptax1Rate { get; set; }

        [StringLength(50)]
		[Column("sv_supptax2_desc")]
        public string SvSupptax2Desc { get; set; }

		[Column("sv_supptax2_rate")]
        public int? SvSupptax2Rate { get; set; }

        [StringLength(50)]
		[Column("sv_supptax3_desc")]
        public string SvSupptax3Desc { get; set; }

		[Column("sv_supptax3_rate")]
        public int? SvSupptax3Rate { get; set; }

		[Column("sv_lotflag")]
        public int? SvLotflag { get; set; }

        [StringLength(5)]
		[Column("sv_tocurrency")]
        public string SvTocurrency { get; set; }

        [StringLength(30)]
		[Column("sv_rba_tax")]
        public string SvRbaTax { get; set; }

        [StringLength(1)]
		[Column("sv_country_version")]
        public string SvCountryVersion { get; set; }

		[Column("sv_counter")]
        public int? SvCounter { get; set; }

		[Column("sv_slamount")]
        public decimal? SvSlamount { get; set; }

		[Column("sv_slrate")]
        public decimal? SvSlrate { get; set; }

		[Column("sv_sltax1")]
        public int? SvSltax1 { get; set; }

		[Column("sv_sltax2")]
        public int? SvSltax2 { get; set; }

		[Column("sv_sltax3")]
        public int? SvSltax3 { get; set; }

		[Column("sv_sltax4")]
        public int? SvSltax4 { get; set; }

		[Column("sv_prxcapamt")]
        public decimal? SvPrxcapamt { get; set; }

		[Column("sv_prxrate")]
        public decimal? SvPrxrate { get; set; }

		[Column("sv_intcapamt")]
        public decimal? SvIntcapamt { get; set; }

		[Column("sv_intrate")]
        public decimal? SvIntrate { get; set; }

		[Column("sv_minprxbidnum")]
        public int? SvMinprxbidnum { get; set; }

		[Column("sv_maxprxbidnum")]
        public int? SvMaxprxbidnum { get; set; }

		[Column("sv_minintbidnum")]
        public int? SvMinintbidnum { get; set; }

		[Column("sv_maxintbidnum")]
        public int? SvMaxintbidnum { get; set; }

		[Column("sv_prxintfeetax1")]
        public int? SvPrxintfeetax1 { get; set; }

		[Column("sv_prxintfeetax2")]
        public int? SvPrxintfeetax2 { get; set; }

		[Column("sv_prxintfeetax3")]
        public int? SvPrxintfeetax3 { get; set; }

		[Column("sv_prxintfeetax4")]
        public int? SvPrxintfeetax4 { get; set; }

        [StringLength(50)]
		[Column("sv_replyaddress")]
        public string SvReplyaddress { get; set; }

		[Column("sv_auction_type")]
        public int? SvAuctionType { get; set; }

        [StringLength(255)]
		[Column("sv_owner_faxemailmsg")]
        public string SvOwnerFaxemailmsg { get; set; }

        [StringLength(255)]
		[Column("sv_buyer_faxemailmsg")]
        public string SvBuyerFaxemailmsg { get; set; }

		[Column("sv_taxrecap")]
        public int? SvTaxrecap { get; set; }

        [StringLength(1)]
		[Column("sv_tal_sale")]
        public string SvTalSale { get; set; }

        [StringLength(50)]
		[Column("sv_tal_timetext")]
        public string SvTalTimetext { get; set; }

        [StringLength(1)]
		[Column("sv_tal_transfer_on")]
        public string SvTalTransferOn { get; set; }

        [StringLength(1)]
		[Column("sv_tal_results_on")]
        public string SvTalResultsOn { get; set; }

		[Column("sv_cst_pur_threshold")]
        public decimal? SvCstPurThreshold { get; set; }

        [StringLength(255)]
		[Column("sv_buyer_faxemailmsg2")]
        public string SvBuyerFaxemailmsg2 { get; set; }

        [StringLength(255)]
		[Column("sv_buyer_faxemailmsg3")]
        public string SvBuyerFaxemailmsg3 { get; set; }

		[Column("sv_bfrate")]
        public decimal? SvBfrate { get; set; }

		[Column("sv_bfcapamt")]
        public decimal? SvBfcapamt { get; set; }

		[Column("sv_invoice")]
        public int? SvInvoice { get; set; }

        [StringLength(20)]
		[Column("sv_mvdealernum")]
        public string SvMvdealernum { get; set; }

		[Column("sv_dataquality")]
        public int? SvDataquality { get; set; }

		[Column("sv_bandwidth")]
        public int? SvBandwidth { get; set; }

		[Column("sv_con_entry_allowed")]
        public int? SvConEntryAllowed { get; set; }

		[Column("sv_con_polling_enabled")]
        public int? SvConPollingEnabled { get; set; }

		[Column("sv_sfa_integration_seq")]
        public int? SvSfaIntegrationSeq { get; set; }

		[Column("sv_sfa_integration_bitmap")]
        public int? SvSfaIntegrationBitmap { get; set; }

		[Column("sv_lotflag_timestamp")]
        public DateTime? SvLotflagTimestamp { get; set; }

		[Column("sv_taxengine")]
        public int? SvTaxengine { get; set; }
    }
}
