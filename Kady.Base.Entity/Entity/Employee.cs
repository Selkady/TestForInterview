using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kady.Base.Entity
{
    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    {
        public class EmployeeMetadata
        {
            [Required]
            public string Name { get; set; }

        }
    }
}
