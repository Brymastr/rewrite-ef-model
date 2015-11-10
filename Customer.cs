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
				[Column("cst_rbanum")]
        public int? CstRbanum { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
				[Column("cst_salenum", Order = 0)]
        public int CstSalenum { get; set; }

				[Column("cst_saledate", TypeName = "date")]
        public DateTime? CstSaledate { get; set; }

        [Key]
        [StringLength(3)]
				[Column("cst_ownercode", Order = 1)]
        public string CstOwnercode { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
				[Column("cst_bidnum", Order = 2)]
        public int CstBidnum { get; set; }

				[Column("cst_exp_bidnum")]
        public int? CstExpBidnum { get; set; }

        [StringLength(150)]
				[Column("cst_coname")]
        public string CstConame { get; set; }

        [StringLength(1)]
				[Column("cst_exp_bidtype")]
        public string CstExpBidtype { get; set; }

        [StringLength(50)]
				[Column("cst_addr1")]
        public string CstAddr1 { get; set; }

        [StringLength(50)]
				[Column("cst_addr2")]
        public string CstAddr2 { get; set; }

        [StringLength(50)]
				[Column("cst_addr3")]
        public string CstAddr3 { get; set; }

        [StringLength(60)]
				[Column("cst_city")]
        public string CstCity { get; set; }

        [StringLength(20)]
				[Column("cst_postalzip")]
        public string CstPostalzip { get; set; }

        [StringLength(3)]
				[Column("cst_country")]
        public string CstCountry { get; set; }

        [StringLength(3)]
				[Column("cst_prov_state")]
        public string CstProvState { get; set; }

        [StringLength(75)]
				[Column("cst_f_name")]
        public string CstFName { get; set; }

        [StringLength(5)]
				[Column("cst_initial")]
        public string CstInitial { get; set; }

        [StringLength(75)]
				[Column("cst_l_name")]
        public string CstLName { get; set; }

        [StringLength(75)]
				[Column("cst_title")]
        public string CstTitle { get; set; }

        [StringLength(20)]
				[Column("cst_id_type")]
        public string CstIdType { get; set; }

        [StringLength(3)]
				[Column("cst_id_origin")]
        public string CstIdOrigin { get; set; }

        [StringLength(35)]
				[Column("cst_id_number")]
        public string CstIdNumber { get; set; }

        [StringLength(3)]
				[Column("cst_tel_route")]
        public string CstTelRoute { get; set; }

        [StringLength(8)]
				[Column("cst_tel_area")]
        public string CstTelArea { get; set; }

        [StringLength(15)]
				[Column("cst_tel_num")]
        public string CstTelNum { get; set; }

        [StringLength(8)]
				[Column("cst_fax_area")]
        public string CstFaxArea { get; set; }

        [StringLength(15)]
				[Column("cst_fax_num")]
        public string CstFaxNum { get; set; }

        [StringLength(8)]
				[Column("cst_cell_area")]
        public string CstCellArea { get; set; }

        [StringLength(15)]
				[Column("cst_cell_num")]
        public string CstCellNum { get; set; }

        [StringLength(8)]
				[Column("cst_res_area")]
        public string CstResArea { get; set; }

        [StringLength(15)]
				[Column("cst_res_num")]
        public string CstResNum { get; set; }

        [StringLength(20)]
				[Column("cst_ext")]
        public string CstExt { get; set; }

        [StringLength(25)]
				[Column("cst_other_num")]
        public string CstOtherNum { get; set; }

        [StringLength(75)]
				[Column("cst_email")]
        public string CstEmail { get; set; }

				[Column("cst_yr_added")]
        public int? CstYrAdded { get; set; }

				[Column("cst_last_active")]
        public int? CstLastActive { get; set; }

        [StringLength(1)]
				[Column("cst_mailing_status")]
        public string CstMailingStatus { get; set; }

        [StringLength(1)]
				[Column("cst_caution_status")]
        public string CstCautionStatus { get; set; }

				[Column("cst_prim_terr")]
        public int? CstPrimTerr { get; set; }

				[Column("cst_prim_bank")]
        public int? CstPrimBank { get; set; }

				[Column("cst_prim_industry")]
        public int? CstPrimIndustry { get; set; }

				[Column("cst_exp_bidissueddate")]
        public int? CstExpBidissueddate { get; set; }

        [StringLength(500)]
				[Column("cst_notes")]
        public string CstNotes { get; set; }

        [StringLength(50)]
				[Column("cst_buyervatid")]
        public string CstBuyervatid { get; set; }

        [StringLength(20)]
				[Column("cst_owntype")]
        public string CstOwntype { get; set; }

        [StringLength(25)]
				[Column("cst_owncountry")]
        public string CstOwncountry { get; set; }

        [StringLength(50)]
				[Column("cst_tax1type")]
        public string CstTax1type { get; set; }

        [StringLength(50)]
				[Column("cst_tax1state")]
        public string CstTax1state { get; set; }

        [StringLength(50)]
				[Column("cst_tax1number")]
        public string CstTax1number { get; set; }

        [StringLength(50)]
				[Column("cst_tax2type")]
        public string CstTax2type { get; set; }

        [StringLength(50)]
				[Column("cst_tax2state")]
        public string CstTax2state { get; set; }

        [StringLength(50)]
				[Column("cst_tax2number")]
        public string CstTax2number { get; set; }

        [StringLength(50)]
				[Column("cst_tax3type")]
        public string CstTax3type { get; set; }

        [StringLength(50)]
				[Column("cst_tax3state")]
        public string CstTax3state { get; set; }

        [StringLength(50)]
				[Column("cst_tax3number")]
        public string CstTax3number { get; set; }

        [StringLength(500)]
				[Column("cst_tax1note")]
        public string CstTax1note { get; set; }

        [StringLength(500)]
				[Column("cst_tax2note")]
        public string CstTax2note { get; set; }

        [StringLength(500)]
				[Column("cst_tax3note")]
        public string CstTax3note { get; set; }

        [StringLength(30)]
				[Column("cst_saletax")]
        public string CstSaletax { get; set; }

        [StringLength(3)]
				[Column("cst_sownercode")]
        public string CstSownercode { get; set; }

				[Column("cst_counter")]
        public int? CstCounter { get; set; }

				[Column("cst_donotcontact")]
        public int? CstDonotcontact { get; set; }

        [StringLength(3)]
				[Column("cst_fax_route")]
        public string CstFaxRoute { get; set; }

        [StringLength(3)]
				[Column("cst_cell_route")]
        public string CstCellRoute { get; set; }

        [StringLength(3)]
				[Column("cst_res_route")]
        public string CstResRoute { get; set; }

				[Column("cst_prefercommunication")]
        public int? CstPrefercommunication { get; set; }

				[Column("cst_report_donotsend")]
        public int? CstReportDonotsend { get; set; }

        [StringLength(75)]
				[Column("cst_altemail")]
        public string CstAltemail { get; set; }

        [StringLength(20)]
				[Column("cst_pan")]
        public string CstPan { get; set; }

        [StringLength(20)]
				[Column("cst_tan")]
        public string CstTan { get; set; }

				[Column("cst_stat_buysales")]
        public int? CstStatBuysales { get; set; }

				[Column("cst_stat_consales")]
        public int? CstStatConsales { get; set; }

				[Column("cst_stat_buyamount")]
        public decimal? CstStatBuyamount { get; set; }

				[Column("cst_stat_conamount")]
        public decimal? CstStatConamount { get; set; }

				[Column("cst_pur_threshold")]
        public decimal? CstPurThreshold { get; set; }

        [StringLength(255)]
				[Column("cst_industry_code")]
        public string CstIndustryCode { get; set; }

				[Column("cst_wt")]
        public int? CstWt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
				[Column("cst_change_sequence")]
        public long CstChangeSequence { get; set; }

        [StringLength(50)]
				[Column("cst_replica_id")]
        public string CstReplicaId { get; set; }

        [StringLength(3)]
				[Column("cst_customer_type")]
        public string CstCustomerType { get; set; }

				[Column("cst_per_party_id")]
        public int? CstPerPartyId { get; set; }

				[Column("cst_org_party_id")]
        public int? CstOrgPartyId { get; set; }

        [StringLength(1)]
				[Column("cst_loyalty_type")]
        public string CstLoyaltyType { get; set; }

				[Column("cst_customer_card_issue_date", TypeName = "date")]
        public DateTime? CstCustomerCardIssueDate { get; set; }

				[Column("cst_tax_verification_status")]
        public int? CstTaxVerificationStatus { get; set; }

				[Column("cst_tax_verification_date", TypeName = "date")]
        public DateTime? CstTaxVerificationDate { get; set; }

        [StringLength(7)]
				[Column("cst_last_updated_by")]
        public string CstLastUpdatedBy { get; set; }

        [StringLength(8)]
				[Column("cst_saletax_type")]
        public string CstSaletaxType { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
				[Column("cst_customer_party_id")]
        public int CstCustomerPartyId { get; set; }

				[Column("cst_customer_party_id_counter")]
        public int CstCustomerPartyIdCounter { get; set; }

				[Column("cst_per_party_rowversion")]
        public int CstPerPartyRowversion { get; set; }

				[Column("cst_org_party_rowversion")]
        public int CstOrgPartyRowversion { get; set; }

				[Column("cst_relationship_rowversion")]
        public int CstRelationshipRowversion { get; set; }

				[Column("cst_merge_victor_customer_id")]
        public int? CstMergeVictorCustomerId { get; set; }

				[Column("cst_b2b_relation_end_date")]
        public DateTime? CstB2bRelationEndDate { get; set; }

				[Column("cst_last_printed_date")]
        public DateTime? CstLastPrintedDate { get; set; }

        [Required]
        [StringLength(1)]
				[Column("cst_possible_duplicates_flag")]
        public string CstPossibleDuplicatesFlag { get; set; }

        [Required]
        [StringLength(1)]
				[Column("cst_customer_status")]
        public string CstCustomerStatus { get; set; }

        [StringLength(75)]
				[Column("cst_ushipkey")]
        public string CstUshipkey { get; set; }

				[Column("cst_columnchangebitmap")]
        public int CstColumnchangebitmap { get; set; }

        [StringLength(10)]
				[Column("cst_coname_prefix")]
        public string CstConamePrefix { get; set; }
    }
}
