namespace SalesiteIntegration.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ssdata.customersiteuses")]
    public partial class CustomerSiteUses
    {
        [Key]
        [Column(Order = 0)]
        public int cstsiteuse_party_site_use_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cstsiteuse_salenum { get; set; }

        public int cstsiteuse_rowversion { get; set; }

        public int cstsiteuse_sitelocation_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cstsiteuse_customer_party_id_counter { get; set; }

        [Required]
        [StringLength(30)]
        public string cstsiteuse_site_use_type { get; set; }

        [Required]
        [StringLength(1)]
        public string cstsiteuse_primary_per_type { get; set; }

        [Required]
        [StringLength(1)]
        public string cstsiteuse_status { get; set; }

        public int cstsiteuse_columnchangebitmap { get; set; }
    }
}
