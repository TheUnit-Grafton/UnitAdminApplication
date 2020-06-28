using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class IssueModel
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string Description { get; set; }

    }
}
