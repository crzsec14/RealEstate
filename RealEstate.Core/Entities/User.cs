using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Core.Entities
{
    public class User
    {
        public int usrId { get; set; }
        public string usrName { get; set; }
        public string usrPassword { get; set; }
        public DateTime? usrCreatedDate { get; set; }
        public DateTime? usrUpdateDate { get; set; }
    }
}
