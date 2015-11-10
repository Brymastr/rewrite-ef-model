namespace SalesiteIntegration.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ssdata.contract")]
    public partial class Contract
    {
				[Column("con_rbacstnum")]
        public int? ConRbacstnum { get; set; }

        [Key]
        [StringLength(3)]
				[Column("con_ownercode", Order = 0)]
        public string ConOwnercode { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
				[Column("con_salenum", Order = 1)]
        public int ConSalenum { get; set; }

				[Column("con_saledate", TypeName = "date")]
        public DateTime? ConSaledate { get; set; }

				[Column("con_num")]
        public int? ConNum { get; set; }

        [StringLength(1)]
				[Column("con_type")]
        public string ConType { get; set; }

				[Column("con_signed")]
        public int? ConSigned { get; set; }

				[Column("con_datesigned", TypeName = "date")]
        public DateTime? ConDatesigned { get; set; }

				[Column("con_payoutdate", TypeName = "date")]
        public DateTime? ConPayoutdate { get; set; }

				[Column("con_payout_in_days")]
        public int? ConPayoutInDays { get; set; }

				[Column("con_decl_sign_date")]
        public int? ConDeclSignDate { get; set; }

				[Column("con_advances")]
        public decimal? ConAdvances { get; set; }

				[Column("con_deliverydate", TypeName = "date")]
        public DateTime? ConDeliverydate { get; set; }

				[Column("con_r_budget")]
        public decimal? ConRBudget { get; set; }

				[Column("con_r_surchargerate")]
        public decimal? ConRSurchargerate { get; set; }

				[Column("con_r_surchargeamt")]
        public decimal? ConRSurchargeamt { get; set; }

        [StringLength(50)]
				[Column("con_r_auth")]
        public string ConRAuth { get; set; }

				[Column("con_r_per")]
        public int? ConRPer { get; set; }

				[Column("con_r_increase")]
        public decimal? ConRIncrease { get; set; }

				[Column("con_r_signed")]
        public int? ConRSigned { get; set; }

        [StringLength(50)]
				[Column("con_r_notes")]
        public string ConRNotes { get; set; }

        [StringLength(255)]
				[Column("con_r_desc")]
        public string ConRDesc { get; set; }

				[Column("con_h_est")]
        public decimal? ConHEst { get; set; }

				[Column("con_h_surchargerate")]
        public decimal? ConHSurchargerate { get; set; }

				[Column("con_h_surchargeamt")]
        public decimal? ConHSurchargeamt { get; set; }

        [StringLength(50)]
				[Column("con_h_auth")]
        public string ConHAuth { get; set; }

				[Column("con_h_per")]
        public int? ConHPer { get; set; }

				[Column("con_h_increase")]
        public decimal? ConHIncrease { get; set; }

				[Column("con_h_signed")]
        public int? ConHSigned { get; set; }

        [StringLength(50)]
				[Column("con_h_notes")]
        public string ConHNotes { get; set; }

        [StringLength(255)]
				[Column("con_h_desc")]
        public string ConHDesc { get; set; }

				[Column("con_o_recvbudget")]
        public decimal? ConORecvbudget { get; set; }

        [StringLength(255)]
				[Column("con_o_recvdesc")]
        public string ConORecvdesc { get; set; }

				[Column("con_rbaregion")]
        public int? ConRbaregion { get; set; }

				[Column("con_rbaofficenum")]
        public int? ConRbaofficenum { get; set; }

				[Column("con_reclock")]
        public int? ConReclock { get; set; }

        [StringLength(8)]
				[Column("con_curuser")]
        public string ConCuruser { get; set; }

				[Column("con_docfees")]
        public decimal? ConDocfees { get; set; }

        [StringLength(35)]
				[Column("con_saleloc")]
        public string ConSaleloc { get; set; }

				[Column("con_counter")]
        public int? ConCounter { get; set; }

				[Column("con_searchfees")]
        public decimal? ConSearchfees { get; set; }

				[Column("con_advertisementcost")]
        public decimal? ConAdvertisementcost { get; set; }

        [StringLength(255)]
				[Column("con_notes")]
        public string ConNotes { get; set; }

				[Column("con_entrydate", TypeName = "date")]
        public DateTime? ConEntrydate { get; set; }

        [StringLength(10)]
				[Column("con_enteredby")]
        public string ConEnteredby { get; set; }

        [Required]
        [StringLength(1)]
				[Column("con_outed")]
        public string ConOuted { get; set; }

        [StringLength(3)]
				[Column("con_moved_to_ownercode")]
        public string ConMovedToOwnercode { get; set; }

        [StringLength(40)]
				[Column("con_guid")]
        public string ConGuid { get; set; }

        [StringLength(40)]
				[Column("con_event_guid")]
        public string ConEventGuid { get; set; }
    }
}
