namespace SalesiteIntegration.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ssdata.customersitelocation")]
    public partial class customersitelocation
    {
        [Key]
        [Column(Order = 0)]
        public int cstsitelocation_party_site_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cstsitelocation_salenum { get; set; }

        public int cstsitelocation_site_rowversion { get; set; }

        public int cstsitelocation_location_id { get; set; }

        public int cstsitelocation_location_rowversion { get; set; }

        public int cstsitelocation_customer_party_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cstsitelocation_customer_party_id_counter { get; set; }

        public short cstsitelocation_partytype { get; set; }

        [Required]
        [StringLength(50)]
        public string cstsitelocation_address1 { get; set; }

        [StringLength(50)]
        public string cstsitelocation_address2 { get; set; }

        [StringLength(50)]
        public string cstsitelocation_address3 { get; set; }

        [StringLength(50)]
        public string cstsitelocation_address4 { get; set; }

        [Required]
        [StringLength(60)]
        public string cstsitelocation_city { get; set; }

        [StringLength(60)]
        public string cstsitelocation_county { get; set; }

        [StringLength(3)]
        public string cstsitelocation_prov_state { get; set; }

        [StringLength(20)]
        public string cstsitelocation_postal_zip { get; set; }

        [Required]
        [StringLength(3)]
        public string cstsitelocation_country { get; set; }

        [StringLength(16)]
        public string cstsitelocation_address_validation_status { get; set; }

        public decimal? cstsitelocation_latitude { get; set; }

        public decimal? cstsitelocation_longitude { get; set; }

        [Required]
        [StringLength(1)]
        public string cstsitelocation_externally_validated_flag { get; set; }

        public int cstsitelocation_specialtyuse_bitmap { get; set; }

        public DateTime cstsitelocation_last_updated_date { get; set; }

        [Required]
        [StringLength(1)]
        public string cstsitelocation_status { get; set; }

        public int cstsitelocation_columnchangebitmap { get; set; }
    }
}
