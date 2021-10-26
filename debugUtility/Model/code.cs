namespace DebugUtility.Model
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("code")]
    public partial class code
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int i_id { get; set; }

        [Required]
        [StringLength(14)]
        public string cclass { get; set; }

        [Required]
        [StringLength(50)]
        public string cclass_engl { get; set; }

        [StringLength(14)]
        public string cclassany { get; set; }

        [StringLength(50)]
        public string cclassany_engl { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string ccode { get; set; }

        [StringLength(100)]
        public string ccode_name { get; set; }

        [StringLength(100)]
        public string ccode_engl { get; set; }

        public byte igrade { get; set; }

        public bool bproperty { get; set; }

        [Required]
        [StringLength(10)]
        public string cbook_type { get; set; }

        [Required]
        [StringLength(50)]
        public string cbook_type_engl { get; set; }

        [StringLength(6)]
        public string chelp { get; set; }

        [StringLength(8)]
        public string cexch_name { get; set; }

        [StringLength(6)]
        public string cmeasure { get; set; }

        public bool bperson { get; set; }

        public bool bcus { get; set; }

        public bool bsup { get; set; }

        public bool bdept { get; set; }

        public bool bitem { get; set; }

        [StringLength(2)]
        public string cass_item { get; set; }

        public bool br { get; set; }

        public bool be { get; set; }

        [StringLength(15)]
        public string cgather { get; set; }

        public bool bend { get; set; }

        public bool bexchange { get; set; }

        public bool bcash { get; set; }

        public bool bbank { get; set; }

        public bool bused { get; set; }

        public bool bd_c { get; set; }

        public DateTime? dbegin { get; set; }

        public DateTime? dend { get; set; }

        public byte? itrans { get; set; }

        public bool bclose { get; set; }

        [StringLength(10)]
        public string cother { get; set; }

        public int? iotherused { get; set; }

        public bool? bcDefine1 { get; set; }

        public bool? bcDefine2 { get; set; }

        public bool? bcDefine3 { get; set; }

        public bool? bcDefine4 { get; set; }

        public bool? bcDefine5 { get; set; }

        public bool? bcDefine6 { get; set; }

        public bool? bcDefine7 { get; set; }

        public bool? bcDefine8 { get; set; }

        public bool? bcDefine9 { get; set; }

        public bool? bcDefine10 { get; set; }

        public int iViewItem { get; set; }

        public bool bGCJS { get; set; }

        public bool bCashItem { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] pubufts { get; set; }

        public bool? bcDefine11 { get; set; }

        public bool? bcDefine12 { get; set; }

        public bool? bcDefine13 { get; set; }

        public bool? bcDefine14 { get; set; }

        public bool? bcDefine15 { get; set; }

        public bool? bcDefine16 { get; set; }

        public bool? bReport { get; set; }

        [StringLength(100)]
        public string cUserDefineType { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short iyear { get; set; }

        public DateTime? dModifyDate { get; set; }

        public bool bparacc { get; set; }
    }
}
