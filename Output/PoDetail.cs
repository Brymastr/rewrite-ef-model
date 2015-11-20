namespace SalesiteIntegration.DataAccess.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ssdata.podetail")]
    public partial class PoDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("pod_salenum", Order = 0)]
        public int PodSalenum { get; set; }

        [Key]
        [StringLength(25)]
		[Column("pod_ponum", Order = 1)]
        public string PodPonum { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("pod_poorder", Order = 2)]
        public int PodPoorder { get; set; }

        [StringLength(100)]
		[Column("pod_repairdetail")]
        public string PodRepairdetail { get; set; }

		[Column("pod_repairamt")]
        public decimal? PodRepairamt { get; set; }

		[Column("pod_schdla1")]
        public int? PodSchdla1 { get; set; }

		[Column("pod_schdla1mod")]
        public int? PodSchdla1mod { get; set; }

        [StringLength(75)]
		[Column("pod_lotdesc")]
        public string PodLotdesc { get; set; }

        [StringLength(3)]
		[Column("pod_costtype")]
        public string PodCosttype { get; set; }

		[Column("pod_lotnum")]
        public int? PodLotnum { get; set; }

        [StringLength(50)]
		[Column("pod_lotnummod")]
        public string PodLotnummod { get; set; }

		[Column("pod_seqnum")]
        public int? PodSeqnum { get; set; }

        [StringLength(20)]
		[Column("pod_invoicenum")]
        public string PodInvoicenum { get; set; }

		[Column("pod_dltflag")]
        public int? PodDltflag { get; set; }

		[Column("pod_counter")]
        public int? PodCounter { get; set; }

        [StringLength(3)]
		[Column("pod_ownercode")]
        public string PodOwnercode { get; set; }

        [StringLength(3)]
		[Column("pod_currency")]
        public string PodCurrency { get; set; }
    }
}
