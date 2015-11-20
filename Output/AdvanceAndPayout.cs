namespace SalesiteIntegration.DataAccess.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ssdata.advanceandpayouts")]
    public partial class AdvanceAndPayout
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
				[Column("adp_id", Order = 0)]
        public int AdpId { get; set; }

        [Required]
        [StringLength(3)]
				[Column("adp_ownercode")]
        public string AdpOwnercode { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
				[Column("adp_salenum", Order = 1)]
        public int AdpSalenum { get; set; }

        [StringLength(10)]
				[Column("adp_type")]
        public string AdpType { get; set; }

        [StringLength(50)]
				[Column("adp_paidto")]
        public string AdpPaidto { get; set; }

				[Column("adp_amount")]
        public decimal? AdpAmount { get; set; }

				[Column("adp_paymentdate", TypeName = "date")]
        public DateTime? AdpPaymentdate { get; set; }

				[Column("adp_interestdate", TypeName = "date")]
        public DateTime? AdpInterestdate { get; set; }

				[Column("adp_interestrate")]
        public decimal? AdpInterestrate { get; set; }

				[Column("adp_overwrite")]
        public int? AdpOverwrite { get; set; }

				[Column("adp_interestamount")]
        public decimal? AdpInterestamount { get; set; }

        [StringLength(100)]
				[Column("adp_notes")]
        public string AdpNotes { get; set; }
    }
}
