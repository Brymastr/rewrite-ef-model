namespace SalesiteIntegration.DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ssdata.contract")]
    public partial class Contract
    {
        public int? con_rbacstnum { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string con_ownercode { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int con_salenum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? con_saledate { get; set; }

        public int? con_num { get; set; }

        [StringLength(1)]
        public string con_type { get; set; }

        public int? con_signed { get; set; }

        [Column(TypeName = "date")]
        public DateTime? con_datesigned { get; set; }

        [Column(TypeName = "date")]
        public DateTime? con_payoutdate { get; set; }

        public int? con_payout_in_days { get; set; }

        public int? con_decl_sign_date { get; set; }

        public decimal? con_advances { get; set; }

        [Column(TypeName = "date")]
        public DateTime? con_deliverydate { get; set; }

        public decimal? con_r_budget { get; set; }

        public decimal? con_r_surchargerate { get; set; }

        public decimal? con_r_surchargeamt { get; set; }

        [StringLength(50)]
        public string con_r_auth { get; set; }

        public int? con_r_per { get; set; }

        public decimal? con_r_increase { get; set; }

        public int? con_r_signed { get; set; }

        [StringLength(50)]
        public string con_r_notes { get; set; }

        [StringLength(255)]
        public string con_r_desc { get; set; }

        public decimal? con_h_est { get; set; }

        public decimal? con_h_surchargerate { get; set; }

        public decimal? con_h_surchargeamt { get; set; }

        [StringLength(50)]
        public string con_h_auth { get; set; }

        public int? con_h_per { get; set; }

        public decimal? con_h_increase { get; set; }

        public int? con_h_signed { get; set; }

        [StringLength(50)]
        public string con_h_notes { get; set; }

        [StringLength(255)]
        public string con_h_desc { get; set; }

        public decimal? con_o_recvbudget { get; set; }

        [StringLength(255)]
        public string con_o_recvdesc { get; set; }

        public int? con_rbaregion { get; set; }

        public int? con_rbaofficenum { get; set; }

        public int? con_reclock { get; set; }

        [StringLength(8)]
        public string con_curuser { get; set; }

        public decimal? con_docfees { get; set; }

        [StringLength(35)]
        public string con_saleloc { get; set; }

        public int? con_counter { get; set; }

        public decimal? con_searchfees { get; set; }

        public decimal? con_advertisementcost { get; set; }

        [StringLength(255)]
        public string con_notes { get; set; }

        [Column(TypeName = "date")]
        public DateTime? con_entrydate { get; set; }

        [StringLength(10)]
        public string con_enteredby { get; set; }

        [Required]
        [StringLength(1)]
        public string con_outed { get; set; }

        [StringLength(3)]
        public string con_moved_to_ownercode { get; set; }

        [StringLength(40)]
        public string con_guid { get; set; }

        [StringLength(40)]
        public string con_event_guid { get; set; }
    }
}
