using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakediş
{
  public class WorkOrder
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime FinishedDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public double ManOfDay { get; set; }
    }
}
