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
        [Column(Order = 0)]
        public int cstcontact_contact_point_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cstcontact_salenum { get; set; }

        public int cstcontact_customer_party_id { get; set; }

        public int cstcontact_rowversion { get; set; }

        public short cstcontact_partytype { get; set; }

        [Required]
        [StringLength(6)]
        public string cstcontact_type { get; set; }

        [Required]
        [StringLength(1)]
        public string cstcontact_primary_contact_flag { get; set; }

        [StringLength(75)]
        public string cstcontact_email { get; set; }

        [StringLength(3)]
        public string cstcontact_phone_route { get; set; }

        [StringLength(8)]
        public string cstcontact_phone_area { get; set; }

        [StringLength(15)]
        public string cstcontact_phone_num { get; set; }

        [StringLength(20)]
        public string cstcontact_phone_extension { get; set; }

        [Required]
        [StringLength(1)]
        public string cstcontact_validflag { get; set; }

        public int cstcontact_specialtyuse_bitmap { get; set; }

        public DateTime cstcontact_last_updated_date { get; set; }

        [Required]
        [StringLength(1)]
        public string cstcontact_status { get; set; }

        public int cstcontact_columnchangebitmap { get; set; }
    }
}
