namespace SalesiteIntegration.DataAccess.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ssdata.pocostsheets")]
    public partial class PocostSheet
    {
        [Column(TypeName = "date")]
        public DateTime? po_date { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string po_num { get; set; }

        [StringLength(20)]
        public string po_author { get; set; }

        [StringLength(50)]
        public string po_suppliername { get; set; }

        [StringLength(8)]
        public string po_suppliercode { get; set; }

        [StringLength(50)]
        public string po_suppaddr1 { get; set; }

        [StringLength(50)]
        public string po_suppaddr2 { get; set; }

        [StringLength(50)]
        public string po_suppcity { get; set; }

        [StringLength(50)]
        public string po_suppprov { get; set; }

        [StringLength(50)]
        public string po_supppostal { get; set; }

        [StringLength(50)]
        public string po_suppcountry { get; set; }

        [StringLength(50)]
        public string po_suppcontact { get; set; }

        [StringLength(50)]
        public string po_supptel { get; set; }

        [StringLength(50)]
        public string po_shipto { get; set; }

        [StringLength(50)]
        public string po_invoiceto { get; set; }

        [StringLength(3)]
        public string po_ownercode { get; set; }

        [StringLength(150)]
        public string po_ownername { get; set; }

        [StringLength(25)]
        public string po_invno { get; set; }

        [StringLength(3)]
        public string po_currency { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int po_salenum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? po_saledate { get; set; }

        [StringLength(35)]
        public string po_saleloc { get; set; }

        public int? po_compgen { get; set; }

        public int? po_chargebacks { get; set; }

        public int? po_void { get; set; }

        public int? po_counter { get; set; }
    }
}
