namespace DebugUtility.Modle
{
    extern alias EF;

    using DebugUtility.UI;
    using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

    public partial class AccInformation_Year
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string cSysID { get; set; }

        [StringLength(5)]
        public string cID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string cName { get; set; }

        [StringLength(30)]
        public string cCaption { get; set; }

        [StringLength(20)]
        public string cType { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int iYear { get; set; }

        [StringLength(200)]
        public string cValue { get; set; }

        [StringLength(100)]
        public string cDefault { get; set; }

        public bool bVisible { get; set; }

        public bool bEnable { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] pubufts { get; set; }
    }
}
