using System;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcService.Interface;

namespace GreeterServer
{
	internal class MyServiceImpl : DataTest.DataTestBase
	{
		public override Task<EmptyMessge> Warmup(EmptyMessge request, ServerCallContext context)
		{
			return Task.FromResult(new EmptyMessge());
		}
		public override Task<DataResponse> GetTestData(DataRequest request, ServerCallContext context)
		{
			var response = new GrpcService.Interface.DataResponse();
			for (var i = 1u; i <= 10000; i++)
			{
				var guid = Guid.NewGuid().ToString();
				response.Data.Add(new DataRecord { Id = i, Name = guid, Description = guid });
			}

			return Task.FromResult(response);
		}
	}

	class Program
	{
		const int Port = 9001;

		public static void Main(string[] args)
		{
			Server server = new Server
			{
				Services = { DataTest.BindService(new MyServiceImpl()) },
				Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
			};
			server.Start();

			Console.WriteLine("grpc server listening on port " + Port);
			Console.WriteLine("Press any key to stop the server...");
			Console.ReadKey();

			server.ShutdownAsync().Wait();
		}
	}
}
