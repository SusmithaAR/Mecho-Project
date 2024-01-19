using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EDMS.Models
{
    [Table("tblBranch")]
    [Index(nameof(BranchName), IsUnique = true)]
    public class Branch
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("AutoId")]
        public int AutoId { set; get; }


        [Column("BranchName")]
        public string BranchName { get; set; } = String.Empty;


        [Column("BranchCode")]
        public string BranchCode { get; set; } = String.Empty;


        [Column("BranchDesc")]
        public string? BranchDesc { get; set; }

    }
}

