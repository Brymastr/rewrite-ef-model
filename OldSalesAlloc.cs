namespace SalesiteIntegration.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ssdata.salesalloc")]
    public partial class SalesAlloc
    {
        public int? sal_connum { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sal_salenum { get; set; }

        [StringLength(8)]
        public string sal_salesrep { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sal_reporder { get; set; }

        public decimal? sal_repalloc { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string sal_ownercode { get; set; }

        public int? sal_rbacstnum { get; set; }

        public int? sal_reclock { get; set; }

        [StringLength(8)]
        public string sal_curuser { get; set; }

        [Column(TypeName = "date")]
        public DateTime? sal_saledate { get; set; }

        [StringLength(35)]
        public string sal_saleloc { get; set; }

        public int? sal_counter { get; set; }
    }
}
