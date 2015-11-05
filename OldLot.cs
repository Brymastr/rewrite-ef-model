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
        public int? lot_num { get; set; }

        [StringLength(1)]
        public string lot_nummod { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string lot_ownercode { get; set; }

        public int? lot_contractnum { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lot_salenum { get; set; }

        public int? lot_bidnum { get; set; }

        public int? lot_seqnum { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lot_schdla1 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lot_schdla1mod { get; set; }

        public int? lot_compschdla { get; set; }

        public int? lot_compmod { get; set; }

        public int? lot_apprnum { get; set; }

        public decimal? lot_itemnumapprsys { get; set; }

        public int? lot_yrofmanuf { get; set; }

        [StringLength(25)]
        public string lot_manuf_aliase { get; set; }

        [StringLength(15)]
        public string lot_model_name { get; set; }

        [StringLength(35)]
        public string lot_model_desc { get; set; }

        [StringLength(5)]
        public string lot_eqgrpcode { get; set; }

        [StringLength(35)]
        public string lot_eqtype { get; set; }

        [StringLength(19)]
        public string lot_sn_vin { get; set; }

        [StringLength(500)]
        public string lot_completewithdesc { get; set; }

        [StringLength(30)]
        public string lot_shortdescline1 { get; set; }

        [StringLength(30)]
        public string lot_shortdescline2 { get; set; }

        [StringLength(35)]
        public string lot_eqisat { get; set; }

        [StringLength(35)]
        public string lot_eqshipto { get; set; }

        [StringLength(35)]
        public string lot_shippercarrier { get; set; }

        [StringLength(1)]
        public string lot_contractschedule { get; set; }

        [StringLength(50)]
        public string lot_comoditycode { get; set; }

        [StringLength(30)]
        public string lot_ucr { get; set; }

        public int? lot_odo { get; set; }

        [StringLength(4)]
        public string lot_hrs_mi_km { get; set; }

        [StringLength(25)]
        public string lot_shortcond { get; set; }

        public decimal? lot_rrest { get; set; }

        [StringLength(3)]
        public string lot_rrcurrency { get; set; }

        public decimal? lot_haulest { get; set; }

        [StringLength(3)]
        public string lot_haulcurrency { get; set; }

        [StringLength(50)]
        public string lot_customsdoctype { get; set; }

        [StringLength(50)]
        public string lot_exportdocnum { get; set; }

        [StringLength(50)]
        public string lot_exportdate { get; set; }

        [StringLength(50)]
        public string lot_exportitemnum { get; set; }

        [StringLength(50)]
        public string lot_importdocnum { get; set; }

        [StringLength(50)]
        public string lot_importitemnum { get; set; }

        [StringLength(50)]
        public string lot_importdocissuedate { get; set; }

        [StringLength(50)]
        public string lot_customsoffice { get; set; }

        [StringLength(50)]
        public string lot_inyarddate { get; set; }

        [StringLength(50)]
        public string lot_customsref { get; set; }

        public decimal? lot_weight { get; set; }

        [StringLength(3)]
        public string lot_weight_unit { get; set; }

        public decimal? lot_height { get; set; }

        [StringLength(3)]
        public string lot_height_unit { get; set; }

        public decimal? lot_width { get; set; }

        [StringLength(3)]
        public string lot_width_unit { get; set; }

        public decimal? lot_length { get; set; }

        [StringLength(3)]
        public string lot_length_units { get; set; }

        public int? lot_eqref { get; set; }

        [StringLength(25)]
        public string lot_manufname { get; set; }

        [StringLength(20)]
        public string lot_ownereqid { get; set; }

        public int? lot_eqnumapprsys { get; set; }

        public int? lot_unused { get; set; }

        public int? lot_kitted { get; set; }

        public int? lot_glidered { get; set; }

        public int? lot_isvehicle { get; set; }

        public int? lot_numoftitles { get; set; }

        [StringLength(50)]
        public string lot_numofitems { get; set; }

        [StringLength(15)]
        public string lot_userreffield { get; set; }

        [StringLength(1)]
        public string lot_clean { get; set; }

        [StringLength(1)]
        public string lot_sp { get; set; }

        [StringLength(1)]
        public string lot_glass { get; set; }

        [StringLength(1)]
        public string lot_tires { get; set; }

        [StringLength(1)]
        public string lot_seat { get; set; }

        [StringLength(25)]
        public string lot_key { get; set; }

        [StringLength(1)]
        public string lot_detail { get; set; }

        [StringLength(1)]
        public string lot_tax1 { get; set; }

        [StringLength(1)]
        public string lot_tax2 { get; set; }

        [StringLength(1)]
        public string lot_tax3 { get; set; }

        [StringLength(1)]
        public string lot_tax4 { get; set; }

        [StringLength(500)]
        public string lot_condnotes { get; set; }

        [StringLength(500)]
        public string lot_additional_rr { get; set; }

        public int? lot_inyard { get; set; }

        public int? lot_sn_checked { get; set; }

        public int? lot_isfueled { get; set; }

        public int? lot_titleinhand { get; set; }

        public int? lot_titlechecked { get; set; }

        public int? lot_epa { get; set; }

        public int? lot_cemarked { get; set; }

        public int? lot_cecert { get; set; }

        public int? lot_isoutofsale { get; set; }

        [StringLength(500)]
        public string lot_outofsalenote { get; set; }

        public int? lot_buyerrbacstnum { get; set; }

        [StringLength(50)]
        public string lot_buyeridentcode { get; set; }

        public int? lot_iscollapsedsale { get; set; }

        [StringLength(500)]
        public string lot_collapsedsalenote { get; set; }

        public int? lot_soldinvnum { get; set; }

        public decimal? lot_soldprice { get; set; }

        public decimal? lot_shootprice { get; set; }

        public decimal? lot_concensus_value { get; set; }

        public int? lot_reclock { get; set; }

        [StringLength(8)]
        public string lot_curuser { get; set; }

        [Column(TypeName = "date")]
        public DateTime? lot_lastupdate { get; set; }

        public int? lot_recdeletetag { get; set; }

        [StringLength(1)]
        public string lot_vehflagorglotdata { get; set; }

        [StringLength(35)]
        public string lot_saleloc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? lot_saledate { get; set; }

        public int? lot_day { get; set; }

        [StringLength(500)]
        public string lot_catnotes { get; set; }

        [StringLength(500)]
        public string lot_ownnotes { get; set; }

        [StringLength(500)]
        public string lot_auctnotes { get; set; }

        [StringLength(10)]
        public string lot_shootby { get; set; }

        [StringLength(50)]
        public string lot_authby { get; set; }

        public int? lot_ucrubber { get; set; }

        public int? lot_uctrack { get; set; }

        public int? lot_titled { get; set; }

        public int? lot_numtitles { get; set; }

        public int? lot_billofsale { get; set; }

        public int? lot_islate { get; set; }

        public int? lot_printflag { get; set; }

        public int? lot_printyear { get; set; }

        [StringLength(35)]
        public string lot_origin { get; set; }

        public int? lot_counter { get; set; }

        [StringLength(19)]
        public string lot_licenseplate { get; set; }

        [StringLength(25)]
        public string lot_enginenumber { get; set; }

        public int? lot_tinflag { get; set; }

        public int? lot_miscflag { get; set; }

        public decimal? lot_rrclean { get; set; }

        public decimal? lot_rrsp { get; set; }

        public decimal? lot_rrglass { get; set; }

        public decimal? lot_rrtires { get; set; }

        public decimal? lot_rrseat { get; set; }

        public decimal? lot_rrdetail { get; set; }

        public decimal? lot_rrtin { get; set; }

        public decimal? lot_rrmisc { get; set; }

        public decimal? lot_consensus_forced { get; set; }

        [StringLength(70)]
        public string lot_deletereason { get; set; }

        public int? lot_checkout { get; set; }

        [Column(TypeName = "date")]
        public DateTime? lot_checkout_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? lot_inyard_date { get; set; }

        public DateTime? lot_timestamp { get; set; }

        public decimal? lot_declared_value { get; set; }

        public decimal? lot_importduty_paid { get; set; }

        public decimal? lot_import_dutyrate { get; set; }

        [StringLength(1)]
        public string lot_tal_flag { get; set; }

        [StringLength(10)]
        public string lot_tal_close_date { get; set; }

        [StringLength(15)]
        public string lot_tal_close_time { get; set; }

        [StringLength(10)]
        public string lot_admission_status { get; set; }

        [StringLength(1)]
        public string lot_olr_flag { get; set; }

        [StringLength(40)]
        public string lot_inventoryid { get; set; }

        [StringLength(40)]
        public string lot_updatedby { get; set; }

        [StringLength(20)]
        public string lot_talupdate { get; set; }

        [StringLength(3)]
        public string lot_eqgrpweb { get; set; }

        [StringLength(35)]
        public string lot_eqsubtype { get; set; }

        public int lot_rrflag { get; set; }

        public int lot_eei_publish_to_web { get; set; }

        public int lot_eei_asset_xml_consistent { get; set; }

        public short lot_eei_number_photos { get; set; }

        [Required]
        [StringLength(1)]
        public string lot_eei_inspection_complete { get; set; }

        public int lot_eei_fields_locked { get; set; }

        [StringLength(64000)]
        public string lot_eei_asset_xml { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long lot_change_sequence { get; set; }

        [StringLength(50)]
        public string lot_replica_id { get; set; }

        public int lot_warranty_eligible { get; set; }

        public int lot_wrpreapproval { get; set; }

        public int lot_pipreapproval { get; set; }

        public int lot_cipreapproval { get; set; }

        public int lot_insurance_eligible { get; set; }

        [StringLength(48)]
        public string lot_eei_asset_photo_filename { get; set; }

        [StringLength(50)]
        public string lot_model_desclt { get; set; }

        [StringLength(500)]
        public string lot_completewithdesclt { get; set; }

        [StringLength(20)]
        public string lot_color { get; set; }

        public int? lot_eei_partial_transfer { get; set; }

        public int? lot_transferred { get; set; }

        public int? lot_gatepassprinted { get; set; }

        [StringLength(10)]
        public string lot_taxjurisdiction { get; set; }

        [StringLength(20)]
        public string lot_contractid { get; set; }

        [StringLength(64)]
        public string lot_snlocation { get; set; }

        [StringLength(40)]
        public string lot_asset_guid { get; set; }

        [StringLength(5)]
        public string lot_asset_quickid { get; set; }

        public int? lot_csu_lock { get; set; }

        [StringLength(3)]
        public string lot_shipfromcountry { get; set; }

        [StringLength(20)]
        public string lot_shipfrompostalcode { get; set; }
    }
}
