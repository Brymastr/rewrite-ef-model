namespace SalesiteIntegration.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ssdata.customercontactpoint")]
    public partial class CustomerContactPoint
    {
        [Key]
		[Column("cstcontact_contact_point_id", Order = 0)]
        public int CstcontactContactPointId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("cstcontact_salenum", Order = 1)]
        public int CstcontactSalenum { get; set; }

		[Column("cstcontact_customer_party_id")]
        public int CstcontactCustomerPartyId { get; set; }

		[Column("cstcontact_rowversion")]
        public int CstcontactRowversion { get; set; }

		[Column("cstcontact_partytype")]
        public short CstcontactPartytype { get; set; }

        [Required]
        [StringLength(6)]
		[Column("cstcontact_type")]
        public string CstcontactType { get; set; }

        [Required]
        [StringLength(1)]
		[Column("cstcontact_primary_contact_flag")]
        public string CstcontactPrimaryContactFlag { get; set; }

        [StringLength(75)]
		[Column("cstcontact_email")]
        public string CstcontactEmail { get; set; }

        [StringLength(3)]
		[Column("cstcontact_phone_route")]
        public string CstcontactPhoneRoute { get; set; }

        [StringLength(8)]
		[Column("cstcontact_phone_area")]
        public string CstcontactPhoneArea { get; set; }

        [StringLength(15)]
		[Column("cstcontact_phone_num")]
        public string CstcontactPhoneNum { get; set; }

        [StringLength(20)]
		[Column("cstcontact_phone_extension")]
        public string CstcontactPhoneExtension { get; set; }

        [Required]
        [StringLength(1)]
		[Column("cstcontact_validflag")]
        public string CstcontactValidflag { get; set; }

		[Column("cstcontact_specialtyuse_bitmap")]
        public int CstcontactSpecialtyuseBitmap { get; set; }

		[Column("cstcontact_last_updated_date")]
        public DateTime CstcontactLastUpdatedDate { get; set; }

        [Required]
        [StringLength(1)]
		[Column("cstcontact_status")]
        public string CstcontactStatus { get; set; }

		[Column("cstcontact_columnchangebitmap")]
        public int CstcontactColumnchangebitmap { get; set; }
    }
}
