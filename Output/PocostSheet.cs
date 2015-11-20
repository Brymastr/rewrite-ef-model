namespace SalesiteIntegration.DataAccess.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ssdata.pocostsheets")]
    public partial class PocostSheet
    {
		[Column("po_date", TypeName = "date")]
        public DateTime? PoDate { get; set; }

        [Key]
        [StringLength(25)]
		[Column("po_num", Order = 0)]
        public string PoNum { get; set; }

        [StringLength(20)]
		[Column("po_author")]
        public string PoAuthor { get; set; }

        [StringLength(50)]
		[Column("po_suppliername")]
        public string PoSuppliername { get; set; }

        [StringLength(8)]
		[Column("po_suppliercode")]
        public string PoSuppliercode { get; set; }

        [StringLength(50)]
		[Column("po_suppaddr1")]
        public string PoSuppaddr1 { get; set; }

        [StringLength(50)]
		[Column("po_suppaddr2")]
        public string PoSuppaddr2 { get; set; }

        [StringLength(50)]
		[Column("po_suppcity")]
        public string PoSuppcity { get; set; }

        [StringLength(50)]
		[Column("po_suppprov")]
        public string PoSuppprov { get; set; }

        [StringLength(50)]
		[Column("po_supppostal")]
        public string PoSupppostal { get; set; }

        [StringLength(50)]
		[Column("po_suppcountry")]
        public string PoSuppcountry { get; set; }

        [StringLength(50)]
		[Column("po_suppcontact")]
        public string PoSuppcontact { get; set; }

        [StringLength(50)]
		[Column("po_supptel")]
        public string PoSupptel { get; set; }

        [StringLength(50)]
		[Column("po_shipto")]
        public string PoShipto { get; set; }

        [StringLength(50)]
		[Column("po_invoiceto")]
        public string PoInvoiceto { get; set; }

        [StringLength(3)]
		[Column("po_ownercode")]
        public string PoOwnercode { get; set; }

        [StringLength(150)]
		[Column("po_ownername")]
        public string PoOwnername { get; set; }

        [StringLength(25)]
		[Column("po_invno")]
        public string PoInvno { get; set; }

        [StringLength(3)]
		[Column("po_currency")]
        public string PoCurrency { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("po_salenum", Order = 1)]
        public int PoSalenum { get; set; }

		[Column("po_saledate", TypeName = "date")]
        public DateTime? PoSaledate { get; set; }

        [StringLength(35)]
		[Column("po_saleloc")]
        public string PoSaleloc { get; set; }

		[Column("po_compgen")]
        public int? PoCompgen { get; set; }

		[Column("po_chargebacks")]
        public int? PoChargebacks { get; set; }

		[Column("po_void")]
        public int? PoVoid { get; set; }

		[Column("po_counter")]
        public int? PoCounter { get; set; }
    }
}
