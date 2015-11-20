namespace SalesiteIntegration.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ssdata.commish")]
    public partial class Commission
    {
		[Column("com_connum")]
        public int? ComConnum { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("com_salenum", Order = 0)]
        public int ComSalenum { get; set; }

        [Key]
        [StringLength(3)]
		[Column("com_ownercode", Order = 1)]
        public string ComOwnercode { get; set; }

		[Column("com_rate1")]
        public decimal? ComRate1 { get; set; }

		[Column("com_fixedamt1")]
        public decimal? ComFixedamt1 { get; set; }

		[Column("com_consignorproceeds1")]
        public decimal? ComConsignorproceeds1 { get; set; }

		[Column("com_rate2")]
        public decimal? ComRate2 { get; set; }

		[Column("com_fixedamt2")]
        public decimal? ComFixedamt2 { get; set; }

		[Column("com_consignorproceeds2")]
        public decimal? ComConsignorproceeds2 { get; set; }

		[Column("com_rate3")]
        public decimal? ComRate3 { get; set; }

		[Column("com_fixedamt3")]
        public decimal? ComFixedamt3 { get; set; }

		[Column("com_consignorproceeds3")]
        public decimal? ComConsignorproceeds3 { get; set; }

		[Column("com_rate4")]
        public decimal? ComRate4 { get; set; }

		[Column("com_fixedamt4")]
        public decimal? ComFixedamt4 { get; set; }

		[Column("com_consignorproceeds4")]
        public decimal? ComConsignorproceeds4 { get; set; }

		[Column("com_rate5")]
        public decimal? ComRate5 { get; set; }

		[Column("com_fixedamt5")]
        public decimal? ComFixedamt5 { get; set; }

		[Column("com_consignorproceeds5")]
        public decimal? ComConsignorproceeds5 { get; set; }

		[Column("com_minrate")]
        public decimal? ComMinrate { get; set; }

		[Column("com_minamt")]
        public decimal? ComMinamt { get; set; }

		[Column("com_smalllotproceeds")]
        public decimal? ComSmalllotproceeds { get; set; }

		[Column("com_advances")]
        public decimal? ComAdvances { get; set; }

		[Column("com_advancedate", TypeName = "date")]
        public DateTime? ComAdvancedate { get; set; }

		[Column("com_advanceint")]
        public int? ComAdvanceint { get; set; }

		[Column("com_counter")]
        public int? ComCounter { get; set; }

		[Column("com_contractamount1")]
        public decimal? ComContractamount1 { get; set; }

		[Column("com_contractamount2")]
        public decimal? ComContractamount2 { get; set; }

		[Column("com_contractamount3")]
        public decimal? ComContractamount3 { get; set; }

		[Column("com_contractamount4")]
        public decimal? ComContractamount4 { get; set; }

		[Column("com_contractamount5")]
        public decimal? ComContractamount5 { get; set; }

		[Column("com_addtodealsheet")]
        public int? ComAddtodealsheet { get; set; }
    }
}
