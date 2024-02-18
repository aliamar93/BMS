using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelView
{
    public class AMStamp
    {
        public int Id { get; set; }

        public int StdUId { get; set; }

        public byte[] Stamp { get; set; }

        public DateTime? StampTime { get; set; }

        public string StampString { get; set; }

        public bool? IsActive { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? Status { get; set; }

        public string Comments { get; set; }
    }
}
