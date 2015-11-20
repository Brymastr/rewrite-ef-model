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
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int rep_salenum { get; set; }

        public int? rep_order { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string rep_empcode { get; set; }

        [StringLength(20)]
        public string rep_fname { get; set; }

        [StringLength(30)]
        public string rep_lname { get; set; }

        public int? rep_counter { get; set; }
    }
}
