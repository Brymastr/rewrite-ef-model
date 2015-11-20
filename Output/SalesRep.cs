namespace SalesiteIntegration.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ssdata.salesreps")]
    public partial class salesrep
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("rep_salenum", Order = 0)]
        public int RepSalenum { get; set; }

		[Column("rep_order")]
        public int? RepOrder { get; set; }

        [Key]
        [StringLength(8)]
		[Column("rep_empcode", Order = 1)]
        public string RepEmpcode { get; set; }

        [StringLength(20)]
		[Column("rep_fname")]
        public string RepFname { get; set; }

        [StringLength(30)]
		[Column("rep_lname")]
        public string RepLname { get; set; }

		[Column("rep_counter")]
        public int? RepCounter { get; set; }
    }
}
