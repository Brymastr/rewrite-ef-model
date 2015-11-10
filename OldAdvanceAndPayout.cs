namespace SalesiteIntegration.DataAccess.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ssdata.advanceandpayouts")]
    public partial class AdvanceAndPayout
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int adp_id { get; set; }

        [Required]
        [StringLength(3)]
        public string adp_ownercode { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int adp_salenum { get; set; }

        [StringLength(10)]
        public string adp_type { get; set; }

        [StringLength(50)]
        public string adp_paidto { get; set; }

        public decimal? adp_amount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? adp_paymentdate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? adp_interestdate { get; set; }

        public decimal? adp_interestrate { get; set; }

        public int? adp_overwrite { get; set; }

        public decimal? adp_interestamount { get; set; }

        [StringLength(100)]
        public string adp_notes { get; set; }
    }
}
