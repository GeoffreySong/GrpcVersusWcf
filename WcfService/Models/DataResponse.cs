using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService.Models
{
    public class DataResponse
    {
		public DataResponse()
		{
			Data = new List<DataRecord>();
		}
        public ICollection<DataRecord> Data { get; set; }
    }
}
