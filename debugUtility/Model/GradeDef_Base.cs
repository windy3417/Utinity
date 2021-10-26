namespace DebugUtility.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class GradeDef_Base
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string KEYWORD { get; set; }

        public int? LGRADE { get; set; }

        public int? LGRADELEN { get; set; }

        [StringLength(40)]
        public string CODINGRULE { get; set; }

        public int iSerial { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int iYear { get; set; }
    }
}
