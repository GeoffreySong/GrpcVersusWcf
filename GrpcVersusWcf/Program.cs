using Grpc.Core;
using GrpcService.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GrpcVersusWcf
{
	class Program
	{
		public static void Main(string[] args)
		{
			WarmupGrpc();
			WarmupWcf();
			Thread.Sleep(30000);
			RunTest(act1: () =>
					{
						GetDataGrpc();
					},
					act2: () =>
					{
						GetDataWcf();
					});

			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

		public static void RunTest(Action act1, Action act2)
		{
			var stopWatch = new Stopwatch();
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine($" Iteration {i}");
				stopWatch.Restart();
				act1();
				stopWatch.Stop();
				var act1Time = stopWatch.ElapsedMilliseconds;
				Console.WriteLine($"Test 1: {act1Time.ToString()}");

				stopWatch.Restart();
				act2();
				stopWatch.Stop();
				var act2Time = stopWatch.ElapsedMilliseconds;
				Console.WriteLine($"Test 2: {act2Time.ToString()}");
				Thread.Sleep(10000);
			}
		}

		public static void WarmupGrpc() {
			Channel channel = new Channel("127.0.0.1:9001", ChannelCredentials.Insecure);
			var client = new DataTest.DataTestClient(channel);
			client.Warmup(new EmptyMessge());
		}
		public static void GetDataGrpc() {
			Channel channel = new Channel("127.0.0.1:9001", ChannelCredentials.Insecure);
			var client = new DataTest.DataTestClient(channel);
			var response = client.GetTestData(new DataRequest { Type = DataRequest.Types.DataType.User });

			if (response != null && response.Data != null)
			{
				Console.WriteLine("Total GRPC Data Records: {0}", response.Data.Count);
			}
		}

		public static void WarmupWcf() {
			var client = new WcfReference.TestServiceClient("TestServicePoint");
			client.Warmup(new WcfReference.EmptyMessage());
		}
		public static void GetDataWcf() {
			var client = new WcfReference.TestServiceClient("TestServicePoint");
			var response = client.GetTestData(new WcfReference.DataRequest { Type = WcfReference.DataType.CLIENT });

			if (response != null && response.Data != null)
			{
				Console.WriteLine("Total WCF Data Records: {0}", response.Data.Count);
			}
		}
	}
}
