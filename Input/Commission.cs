namespace SalesiteIntegration.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ssdata.commish")]
    public partial class commish
    {
        public int? com_connum { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int com_salenum { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string com_ownercode { get; set; }

        public decimal? com_rate1 { get; set; }

        public decimal? com_fixedamt1 { get; set; }

        public decimal? com_consignorproceeds1 { get; set; }

        public decimal? com_rate2 { get; set; }

        public decimal? com_fixedamt2 { get; set; }

        public decimal? com_consignorproceeds2 { get; set; }

        public decimal? com_rate3 { get; set; }

        public decimal? com_fixedamt3 { get; set; }

        public decimal? com_consignorproceeds3 { get; set; }

        public decimal? com_rate4 { get; set; }

        public decimal? com_fixedamt4 { get; set; }

        public decimal? com_consignorproceeds4 { get; set; }

        public decimal? com_rate5 { get; set; }

        public decimal? com_fixedamt5 { get; set; }

        public decimal? com_consignorproceeds5 { get; set; }

        public decimal? com_minrate { get; set; }

        public decimal? com_minamt { get; set; }

        public decimal? com_smalllotproceeds { get; set; }

        public decimal? com_advances { get; set; }

        [Column(TypeName = "date")]
        public DateTime? com_advancedate { get; set; }

        public int? com_advanceint { get; set; }

        public int? com_counter { get; set; }

        public decimal? com_contractamount1 { get; set; }

        public decimal? com_contractamount2 { get; set; }

        public decimal? com_contractamount3 { get; set; }

        public decimal? com_contractamount4 { get; set; }

        public decimal? com_contractamount5 { get; set; }

        public int? com_addtodealsheet { get; set; }
    }
}
