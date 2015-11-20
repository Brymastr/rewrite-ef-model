namespace SalesiteIntegration.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ssdata.lot")]
    public partial class Lot
    {
		[Column("lot_num")]
        public int? LotNum { get; set; }

        [StringLength(1)]
		[Column("lot_nummod")]
        public string LotNummod { get; set; }

        [Key]
        [StringLength(3)]
		[Column("lot_ownercode", Order = 0)]
        public string LotOwnercode { get; set; }

		[Column("lot_contractnum")]
        public int? LotContractnum { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("lot_salenum", Order = 1)]
        public int LotSalenum { get; set; }

		[Column("lot_bidnum")]
        public int? LotBidnum { get; set; }

		[Column("lot_seqnum")]
        public int? LotSeqnum { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("lot_schdla1", Order = 2)]
        public int LotSchdla1 { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("lot_schdla1mod", Order = 3)]
        public int LotSchdla1mod { get; set; }

		[Column("lot_compschdla")]
        public int? LotCompschdla { get; set; }

		[Column("lot_compmod")]
        public int? LotCompmod { get; set; }

		[Column("lot_apprnum")]
        public int? LotApprnum { get; set; }

		[Column("lot_itemnumapprsys")]
        public decimal? LotItemnumapprsys { get; set; }

		[Column("lot_yrofmanuf")]
        public int? LotYrofmanuf { get; set; }

        [StringLength(25)]
		[Column("lot_manuf_aliase")]
        public string LotManufAliase { get; set; }

        [StringLength(15)]
		[Column("lot_model_name")]
        public string LotModelName { get; set; }

        [StringLength(35)]
		[Column("lot_model_desc")]
        public string LotModelDesc { get; set; }

        [StringLength(5)]
		[Column("lot_eqgrpcode")]
        public string LotEqgrpcode { get; set; }

        [StringLength(35)]
		[Column("lot_eqtype")]
        public string LotEqtype { get; set; }

        [StringLength(19)]
		[Column("lot_sn_vin")]
        public string LotSnVin { get; set; }

        [StringLength(500)]
		[Column("lot_completewithdesc")]
        public string LotCompletewithdesc { get; set; }

        [StringLength(30)]
		[Column("lot_shortdescline1")]
        public string LotShortdescline1 { get; set; }

        [StringLength(30)]
		[Column("lot_shortdescline2")]
        public string LotShortdescline2 { get; set; }

        [StringLength(35)]
		[Column("lot_eqisat")]
        public string LotEqisat { get; set; }

        [StringLength(35)]
		[Column("lot_eqshipto")]
        public string LotEqshipto { get; set; }

        [StringLength(35)]
		[Column("lot_shippercarrier")]
        public string LotShippercarrier { get; set; }

        [StringLength(1)]
		[Column("lot_contractschedule")]
        public string LotContractschedule { get; set; }

        [StringLength(50)]
		[Column("lot_comoditycode")]
        public string LotComoditycode { get; set; }

        [StringLength(30)]
		[Column("lot_ucr")]
        public string LotUcr { get; set; }

		[Column("lot_odo")]
        public int? LotOdo { get; set; }

        [StringLength(4)]
		[Column("lot_hrs_mi_km")]
        public string LotHrsMiKm { get; set; }

        [StringLength(25)]
		[Column("lot_shortcond")]
        public string LotShortcond { get; set; }

		[Column("lot_rrest")]
        public decimal? LotRrest { get; set; }

        [StringLength(3)]
		[Column("lot_rrcurrency")]
        public string LotRrcurrency { get; set; }

		[Column("lot_haulest")]
        public decimal? LotHaulest { get; set; }

        [StringLength(3)]
		[Column("lot_haulcurrency")]
        public string LotHaulcurrency { get; set; }

        [StringLength(50)]
		[Column("lot_customsdoctype")]
        public string LotCustomsdoctype { get; set; }

        [StringLength(50)]
		[Column("lot_exportdocnum")]
        public string LotExportdocnum { get; set; }

        [StringLength(50)]
		[Column("lot_exportdate")]
        public string LotExportdate { get; set; }

        [StringLength(50)]
		[Column("lot_exportitemnum")]
        public string LotExportitemnum { get; set; }

        [StringLength(50)]
		[Column("lot_importdocnum")]
        public string LotImportdocnum { get; set; }

        [StringLength(50)]
		[Column("lot_importitemnum")]
        public string LotImportitemnum { get; set; }

        [StringLength(50)]
		[Column("lot_importdocissuedate")]
        public string LotImportdocissuedate { get; set; }

        [StringLength(50)]
		[Column("lot_customsoffice")]
        public string LotCustomsoffice { get; set; }

        [StringLength(50)]
		[Column("lot_inyarddate")]
        public string LotInyarddate { get; set; }

        [StringLength(50)]
		[Column("lot_customsref")]
        public string LotCustomsref { get; set; }

		[Column("lot_weight")]
        public decimal? LotWeight { get; set; }

        [StringLength(3)]
		[Column("lot_weight_unit")]
        public string LotWeightUnit { get; set; }

		[Column("lot_height")]
        public decimal? LotHeight { get; set; }

        [StringLength(3)]
		[Column("lot_height_unit")]
        public string LotHeightUnit { get; set; }

		[Column("lot_width")]
        public decimal? LotWidth { get; set; }

        [StringLength(3)]
		[Column("lot_width_unit")]
        public string LotWidthUnit { get; set; }

		[Column("lot_length")]
        public decimal? LotLength { get; set; }

        [StringLength(3)]
		[Column("lot_length_units")]
        public string LotLengthUnits { get; set; }

		[Column("lot_eqref")]
        public int? LotEqref { get; set; }

        [StringLength(25)]
		[Column("lot_manufname")]
        public string LotManufname { get; set; }

        [StringLength(20)]
		[Column("lot_ownereqid")]
        public string LotOwnereqid { get; set; }

		[Column("lot_eqnumapprsys")]
        public int? LotEqnumapprsys { get; set; }

		[Column("lot_unused")]
        public int? LotUnused { get; set; }

		[Column("lot_kitted")]
        public int? LotKitted { get; set; }

		[Column("lot_glidered")]
        public int? LotGlidered { get; set; }

		[Column("lot_isvehicle")]
        public int? LotIsvehicle { get; set; }

		[Column("lot_numoftitles")]
        public int? LotNumoftitles { get; set; }

        [StringLength(50)]
		[Column("lot_numofitems")]
        public string LotNumofitems { get; set; }

        [StringLength(15)]
		[Column("lot_userreffield")]
        public string LotUserreffield { get; set; }

        [StringLength(1)]
		[Column("lot_clean")]
        public string LotClean { get; set; }

        [StringLength(1)]
		[Column("lot_sp")]
        public string LotSp { get; set; }

        [StringLength(1)]
		[Column("lot_glass")]
        public string LotGlass { get; set; }

        [StringLength(1)]
		[Column("lot_tires")]
        public string LotTires { get; set; }

        [StringLength(1)]
		[Column("lot_seat")]
        public string LotSeat { get; set; }

        [StringLength(25)]
		[Column("lot_key")]
        public string LotKey { get; set; }

        [StringLength(1)]
		[Column("lot_detail")]
        public string LotDetail { get; set; }

        [StringLength(1)]
		[Column("lot_tax1")]
        public string LotTax1 { get; set; }

        [StringLength(1)]
		[Column("lot_tax2")]
        public string LotTax2 { get; set; }

        [StringLength(1)]
		[Column("lot_tax3")]
        public string LotTax3 { get; set; }

        [StringLength(1)]
		[Column("lot_tax4")]
        public string LotTax4 { get; set; }

        [StringLength(500)]
		[Column("lot_condnotes")]
        public string LotCondnotes { get; set; }

        [StringLength(500)]
		[Column("lot_additional_rr")]
        public string LotAdditionalRr { get; set; }

		[Column("lot_inyard")]
        public int? LotInyard { get; set; }

		[Column("lot_sn_checked")]
        public int? LotSnChecked { get; set; }

		[Column("lot_isfueled")]
        public int? LotIsfueled { get; set; }

		[Column("lot_titleinhand")]
        public int? LotTitleinhand { get; set; }

		[Column("lot_titlechecked")]
        public int? LotTitlechecked { get; set; }

		[Column("lot_epa")]
        public int? LotEpa { get; set; }

		[Column("lot_cemarked")]
        public int? LotCemarked { get; set; }

		[Column("lot_cecert")]
        public int? LotCecert { get; set; }

		[Column("lot_isoutofsale")]
        public int? LotIsoutofsale { get; set; }

        [StringLength(500)]
		[Column("lot_outofsalenote")]
        public string LotOutofsalenote { get; set; }

		[Column("lot_buyerrbacstnum")]
        public int? LotBuyerrbacstnum { get; set; }

        [StringLength(50)]
		[Column("lot_buyeridentcode")]
        public string LotBuyeridentcode { get; set; }

		[Column("lot_iscollapsedsale")]
        public int? LotIscollapsedsale { get; set; }

        [StringLength(500)]
		[Column("lot_collapsedsalenote")]
        public string LotCollapsedsalenote { get; set; }

		[Column("lot_soldinvnum")]
        public int? LotSoldinvnum { get; set; }

		[Column("lot_soldprice")]
        public decimal? LotSoldprice { get; set; }

		[Column("lot_shootprice")]
        public decimal? LotShootprice { get; set; }

		[Column("lot_concensus_value")]
        public decimal? LotConcensusValue { get; set; }

		[Column("lot_reclock")]
        public int? LotReclock { get; set; }

        [StringLength(8)]
		[Column("lot_curuser")]
        public string LotCuruser { get; set; }

		[Column("lot_lastupdate", TypeName = "date")]
        public DateTime? LotLastupdate { get; set; }

		[Column("lot_recdeletetag")]
        public int? LotRecdeletetag { get; set; }

        [StringLength(1)]
		[Column("lot_vehflagorglotdata")]
        public string LotVehflagorglotdata { get; set; }

        [StringLength(35)]
		[Column("lot_saleloc")]
        public string LotSaleloc { get; set; }

		[Column("lot_saledate", TypeName = "date")]
        public DateTime? LotSaledate { get; set; }

		[Column("lot_day")]
        public int? LotDay { get; set; }

        [StringLength(500)]
		[Column("lot_catnotes")]
        public string LotCatnotes { get; set; }

        [StringLength(500)]
		[Column("lot_ownnotes")]
        public string LotOwnnotes { get; set; }

        [StringLength(500)]
		[Column("lot_auctnotes")]
        public string LotAuctnotes { get; set; }

        [StringLength(10)]
		[Column("lot_shootby")]
        public string LotShootby { get; set; }

        [StringLength(50)]
		[Column("lot_authby")]
        public string LotAuthby { get; set; }

		[Column("lot_ucrubber")]
        public int? LotUcrubber { get; set; }

		[Column("lot_uctrack")]
        public int? LotUctrack { get; set; }

		[Column("lot_titled")]
        public int? LotTitled { get; set; }

		[Column("lot_numtitles")]
        public int? LotNumtitles { get; set; }

		[Column("lot_billofsale")]
        public int? LotBillofsale { get; set; }

		[Column("lot_islate")]
        public int? LotIslate { get; set; }

		[Column("lot_printflag")]
        public int? LotPrintflag { get; set; }

		[Column("lot_printyear")]
        public int? LotPrintyear { get; set; }

        [StringLength(35)]
		[Column("lot_origin")]
        public string LotOrigin { get; set; }

		[Column("lot_counter")]
        public int? LotCounter { get; set; }

        [StringLength(19)]
		[Column("lot_licenseplate")]
        public string LotLicenseplate { get; set; }

        [StringLength(25)]
		[Column("lot_enginenumber")]
        public string LotEnginenumber { get; set; }

		[Column("lot_tinflag")]
        public int? LotTinflag { get; set; }

		[Column("lot_miscflag")]
        public int? LotMiscflag { get; set; }

		[Column("lot_rrclean")]
        public decimal? LotRrclean { get; set; }

		[Column("lot_rrsp")]
        public decimal? LotRrsp { get; set; }

		[Column("lot_rrglass")]
        public decimal? LotRrglass { get; set; }

		[Column("lot_rrtires")]
        public decimal? LotRrtires { get; set; }

		[Column("lot_rrseat")]
        public decimal? LotRrseat { get; set; }

		[Column("lot_rrdetail")]
        public decimal? LotRrdetail { get; set; }

		[Column("lot_rrtin")]
        public decimal? LotRrtin { get; set; }

		[Column("lot_rrmisc")]
        public decimal? LotRrmisc { get; set; }

		[Column("lot_consensus_forced")]
        public decimal? LotConsensusForced { get; set; }

        [StringLength(70)]
		[Column("lot_deletereason")]
        public string LotDeletereason { get; set; }

		[Column("lot_checkout")]
        public int? LotCheckout { get; set; }

		[Column("lot_checkout_date", TypeName = "date")]
        public DateTime? LotCheckoutDate { get; set; }

		[Column("lot_inyard_date", TypeName = "date")]
        public DateTime? LotInyardDate { get; set; }

		[Column("lot_timestamp")]
        public DateTime? LotTimestamp { get; set; }

		[Column("lot_declared_value")]
        public decimal? LotDeclaredValue { get; set; }

		[Column("lot_importduty_paid")]
        public decimal? LotImportdutyPaid { get; set; }

		[Column("lot_import_dutyrate")]
        public decimal? LotImportDutyrate { get; set; }

        [StringLength(1)]
		[Column("lot_tal_flag")]
        public string LotTalFlag { get; set; }

        [StringLength(10)]
		[Column("lot_tal_close_date")]
        public string LotTalCloseDate { get; set; }

        [StringLength(15)]
		[Column("lot_tal_close_time")]
        public string LotTalCloseTime { get; set; }

        [StringLength(10)]
		[Column("lot_admission_status")]
        public string LotAdmissionStatus { get; set; }

        [StringLength(1)]
		[Column("lot_olr_flag")]
        public string LotOlrFlag { get; set; }

        [StringLength(40)]
		[Column("lot_inventoryid")]
        public string LotInventoryid { get; set; }

        [StringLength(40)]
		[Column("lot_updatedby")]
        public string LotUpdatedby { get; set; }

        [StringLength(20)]
		[Column("lot_talupdate")]
        public string LotTalupdate { get; set; }

        [StringLength(3)]
		[Column("lot_eqgrpweb")]
        public string LotEqgrpweb { get; set; }

        [StringLength(35)]
		[Column("lot_eqsubtype")]
        public string LotEqsubtype { get; set; }

		[Column("lot_rrflag")]
        public int LotRrflag { get; set; }

		[Column("lot_eei_publish_to_web")]
        public int LotEeiPublishToWeb { get; set; }

		[Column("lot_eei_asset_xml_consistent")]
        public int LotEeiAssetXmlConsistent { get; set; }

		[Column("lot_eei_number_photos")]
        public short LotEeiNumberPhotos { get; set; }

        [Required]
        [StringLength(1)]
		[Column("lot_eei_inspection_complete")]
        public string LotEeiInspectionComplete { get; set; }

		[Column("lot_eei_fields_locked")]
        public int LotEeiFieldsLocked { get; set; }

        [StringLength(64000)]
		[Column("lot_eei_asset_xml")]
        public string LotEeiAssetXml { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("lot_change_sequence")]
        public long LotChangeSequence { get; set; }

        [StringLength(50)]
		[Column("lot_replica_id")]
        public string LotReplicaId { get; set; }

		[Column("lot_warranty_eligible")]
        public int LotWarrantyEligible { get; set; }

		[Column("lot_wrpreapproval")]
        public int LotWrpreapproval { get; set; }

		[Column("lot_pipreapproval")]
        public int LotPipreapproval { get; set; }

		[Column("lot_cipreapproval")]
        public int LotCipreapproval { get; set; }

		[Column("lot_insurance_eligible")]
        public int LotInsuranceEligible { get; set; }

        [StringLength(48)]
		[Column("lot_eei_asset_photo_filename")]
        public string LotEeiAssetPhotoFilename { get; set; }

        [StringLength(50)]
		[Column("lot_model_desclt")]
        public string LotModelDesclt { get; set; }

        [StringLength(500)]
		[Column("lot_completewithdesclt")]
        public string LotCompletewithdesclt { get; set; }

        [StringLength(20)]
		[Column("lot_color")]
        public string LotColor { get; set; }

		[Column("lot_eei_partial_transfer")]
        public int? LotEeiPartialTransfer { get; set; }

		[Column("lot_transferred")]
        public int? LotTransferred { get; set; }

		[Column("lot_gatepassprinted")]
        public int? LotGatepassprinted { get; set; }

        [StringLength(10)]
		[Column("lot_taxjurisdiction")]
        public string LotTaxjurisdiction { get; set; }

        [StringLength(20)]
		[Column("lot_contractid")]
        public string LotContractid { get; set; }

        [StringLength(64)]
		[Column("lot_snlocation")]
        public string LotSnlocation { get; set; }

        [StringLength(40)]
		[Column("lot_asset_guid")]
        public string LotAssetGuid { get; set; }

        [StringLength(5)]
		[Column("lot_asset_quickid")]
        public string LotAssetQuickid { get; set; }

		[Column("lot_csu_lock")]
        public int? LotCsuLock { get; set; }

        [StringLength(3)]
		[Column("lot_shipfromcountry")]
        public string LotShipfromcountry { get; set; }

        [StringLength(20)]
		[Column("lot_shipfrompostalcode")]
        public string LotShipfrompostalcode { get; set; }
    }
}
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