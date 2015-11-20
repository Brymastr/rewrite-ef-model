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
		[Column("cstsitelocation_party_site_id", Order = 0)]
        public int CstsitelocationPartySiteId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("cstsitelocation_salenum", Order = 1)]
        public int CstsitelocationSalenum { get; set; }

		[Column("cstsitelocation_site_rowversion")]
        public int CstsitelocationSiteRowversion { get; set; }

		[Column("cstsitelocation_location_id")]
        public int CstsitelocationLocationId { get; set; }

		[Column("cstsitelocation_location_rowversion")]
        public int CstsitelocationLocationRowversion { get; set; }

		[Column("cstsitelocation_customer_party_id")]
        public int CstsitelocationCustomerPartyId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("cstsitelocation_customer_party_id_counter", Order = 2)]
        public int CstsitelocationCustomerPartyIdCounter { get; set; }

		[Column("cstsitelocation_partytype")]
        public short CstsitelocationPartytype { get; set; }

        [Required]
        [StringLength(50)]
		[Column("cstsitelocation_address1")]
        public string CstsitelocationAddress1 { get; set; }

        [StringLength(50)]
		[Column("cstsitelocation_address2")]
        public string CstsitelocationAddress2 { get; set; }

        [StringLength(50)]
		[Column("cstsitelocation_address3")]
        public string CstsitelocationAddress3 { get; set; }

        [StringLength(50)]
		[Column("cstsitelocation_address4")]
        public string CstsitelocationAddress4 { get; set; }

        [Required]
        [StringLength(60)]
		[Column("cstsitelocation_city")]
        public string CstsitelocationCity { get; set; }

        [StringLength(60)]
		[Column("cstsitelocation_county")]
        public string CstsitelocationCounty { get; set; }

        [StringLength(3)]
		[Column("cstsitelocation_prov_state")]
        public string CstsitelocationProvState { get; set; }

        [StringLength(20)]
		[Column("cstsitelocation_postal_zip")]
        public string CstsitelocationPostalZip { get; set; }

        [Required]
        [StringLength(3)]
		[Column("cstsitelocation_country")]
        public string CstsitelocationCountry { get; set; }

        [StringLength(16)]
		[Column("cstsitelocation_address_validation_status")]
        public string CstsitelocationAddressValidationStatus { get; set; }

		[Column("cstsitelocation_latitude")]
        public decimal? CstsitelocationLatitude { get; set; }

		[Column("cstsitelocation_longitude")]
        public decimal? CstsitelocationLongitude { get; set; }

        [Required]
        [StringLength(1)]
		[Column("cstsitelocation_externally_validated_flag")]
        public string CstsitelocationExternallyValidatedFlag { get; set; }

		[Column("cstsitelocation_specialtyuse_bitmap")]
        public int CstsitelocationSpecialtyuseBitmap { get; set; }

		[Column("cstsitelocation_last_updated_date")]
        public DateTime CstsitelocationLastUpdatedDate { get; set; }

        [Required]
        [StringLength(1)]
		[Column("cstsitelocation_status")]
        public string CstsitelocationStatus { get; set; }

		[Column("cstsitelocation_columnchangebitmap")]
        public int CstsitelocationColumnchangebitmap { get; set; }
    }
}
