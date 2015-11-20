namespace SalesiteIntegration.DataAccess.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ssdata.podetail")]
    public partial class PoDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pod_salenum { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string pod_ponum { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pod_poorder { get; set; }

        [StringLength(100)]
        public string pod_repairdetail { get; set; }

        public decimal? pod_repairamt { get; set; }

        public int? pod_schdla1 { get; set; }

        public int? pod_schdla1mod { get; set; }

        [StringLength(75)]
        public string pod_lotdesc { get; set; }

        [StringLength(3)]
        public string pod_costtype { get; set; }

        public int? pod_lotnum { get; set; }

        [StringLength(50)]
        public string pod_lotnummod { get; set; }

        public int? pod_seqnum { get; set; }

        [StringLength(20)]
        public string pod_invoicenum { get; set; }

        public int? pod_dltflag { get; set; }

        public int? pod_counter { get; set; }

        [StringLength(3)]
        public string pod_ownercode { get; set; }

        [StringLength(3)]
        public string pod_currency { get; set; }
    }
}
