using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Automation.DTO
{
    public class DepartmentInsertDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}