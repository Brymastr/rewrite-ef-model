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
		[Column("cstsiteuse_party_site_use_id", Order = 0)]
        public int CstsiteusePartySiteUseId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("cstsiteuse_salenum", Order = 1)]
        public int CstsiteuseSalenum { get; set; }

		[Column("cstsiteuse_rowversion")]
        public int CstsiteuseRowversion { get; set; }

		[Column("cstsiteuse_sitelocation_id")]
        public int CstsiteuseSitelocationId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("cstsiteuse_customer_party_id_counter", Order = 2)]
        public int CstsiteuseCustomerPartyIdCounter { get; set; }

        [Required]
        [StringLength(30)]
		[Column("cstsiteuse_site_use_type")]
        public string CstsiteuseSiteUseType { get; set; }

        [Required]
        [StringLength(1)]
		[Column("cstsiteuse_primary_per_type")]
        public string CstsiteusePrimaryPerType { get; set; }

        [Required]
        [StringLength(1)]
		[Column("cstsiteuse_status")]
        public string CstsiteuseStatus { get; set; }

		[Column("cstsiteuse_columnchangebitmap")]
        public int CstsiteuseColumnchangebitmap { get; set; }
    }
}
