namespace ReportTransfer.DAL.Model.U8
{
    using Castle.MicroKernel.SubSystems.Conversion;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class GL_accsum
    {
        [Key]
        public int i_id { get; set; }

        [Required]
        [StringLength(40)]
        public string ccode { get; set; }

        [StringLength(8)]
        public string cexch_name { get; set; }

        public byte iperiod { get; set; }

        [Required]
        [StringLength(2)]
        public string cbegind_c { get; set; }

        [Required]
        [StringLength(2)]
        public string cbegind_c_engl { get; set; }

        //期初余额
        [Column(TypeName = "money")]
        public decimal mb { get; set; }

        [Column(TypeName = "money")]
        public decimal md { get; set; }

        [Column(TypeName = "money")]
        public decimal mc { get; set; }

        //期末方向
        [Required]
        [StringLength(2)]
        public string cendd_c { get; set; }

        [Required]
        [StringLength(2)]
        public string cendd_c_engl { get; set; }

        //期末余额
        [Column(TypeName = "money")]
        public decimal me { get; set; }

        [Column(TypeName = "money")]
        public decimal mb_f { get; set; }

        [Column(TypeName = "money")]
        public decimal md_f { get; set; }

        [Column(TypeName = "money")]
        public decimal mc_f { get; set; }

        [Column(TypeName = "money")]
        public decimal me_f { get; set; }

        public double nb_s { get; set; }

        public double nd_s { get; set; }

        public double nc_s { get; set; }

        public double ne_s { get; set; }

        public int iyear { get; set; }

        public int? iYPeriod { get; set; }
    }
}
