using System;
using System.Threading.Tasks;
using WcfService.Models;

namespace WcfService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TestService" in both code and config file together.
    public class TestService : ITestService
    {
		public EmptyMessage Warmup(EmptyMessage request){
			return new EmptyMessage();
		}
        public DataResponse GetTestData(DataRequest request)
        {
            var response = new DataResponse();
            for (var i = 1u; i <= 10000; i++)
            {
                var guid = Guid.NewGuid().ToString();
                response.Data.Add(new DataRecord { Id = i, Name = guid, Description = guid });
            }

            return response;
        }
    }
}
