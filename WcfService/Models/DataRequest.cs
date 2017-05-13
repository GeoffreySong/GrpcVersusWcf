using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService.Models
{
    public class DataRequest
    {
        public DataType Type { get; set; }
    }

    public enum DataType
    {
        USER = 0,
        COMPANY,
        CLIENT
    }
}
