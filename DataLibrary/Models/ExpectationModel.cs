using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DataLibrary.Extensions.Enums;

namespace DataLibrary.Models
{
    public class ExpectationModel
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string Description { get; set; }
        public ExpectationType Type { get; set; }
    }
}
