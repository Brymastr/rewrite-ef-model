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
				[Column("sal_connum")]
        public int? SalConnum { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
				[Column("sal_salenum", Order = 0)]
        public int SalSalenum { get; set; }

        [StringLength(8)]
				[Column("sal_salesrep")]
        public string SalSalesrep { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
				[Column("sal_reporder", Order = 1)]
        public int SalReporder { get; set; }

				[Column("sal_repalloc")]
        public decimal? SalRepalloc { get; set; }

        [Key]
        [StringLength(3)]
				[Column("sal_ownercode", Order = 2)]
        public string SalOwnercode { get; set; }

				[Column("sal_rbacstnum")]
        public int? SalRbacstnum { get; set; }

				[Column("sal_reclock")]
        public int? SalReclock { get; set; }

        [StringLength(8)]
				[Column("sal_curuser")]
        public string SalCuruser { get; set; }

				[Column("sal_saledate", TypeName = "date")]
        public DateTime? SalSaledate { get; set; }

        [StringLength(35)]
				[Column("sal_saleloc")]
        public string SalSaleloc { get; set; }

				[Column("sal_counter")]
        public int? SalCounter { get; set; }
    }
}
