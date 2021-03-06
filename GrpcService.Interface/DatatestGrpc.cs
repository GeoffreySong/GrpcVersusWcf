// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: datatest.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace GrpcService.Interface {
  public static partial class DataTest
  {
    static readonly string __ServiceName = "datatest.DataTest";

    static readonly grpc::Marshaller<global::GrpcService.Interface.EmptyMessge> __Marshaller_EmptyMessge = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Interface.EmptyMessge.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Interface.DataRequest> __Marshaller_DataRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Interface.DataRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Interface.DataResponse> __Marshaller_DataResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Interface.DataResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcService.Interface.EmptyMessge, global::GrpcService.Interface.EmptyMessge> __Method_Warmup = new grpc::Method<global::GrpcService.Interface.EmptyMessge, global::GrpcService.Interface.EmptyMessge>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Warmup",
        __Marshaller_EmptyMessge,
        __Marshaller_EmptyMessge);

    static readonly grpc::Method<global::GrpcService.Interface.DataRequest, global::GrpcService.Interface.DataResponse> __Method_GetTestData = new grpc::Method<global::GrpcService.Interface.DataRequest, global::GrpcService.Interface.DataResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetTestData",
        __Marshaller_DataRequest,
        __Marshaller_DataResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.Interface.DatatestReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DataTest</summary>
    public abstract partial class DataTestBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Interface.EmptyMessge> Warmup(global::GrpcService.Interface.EmptyMessge request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Interface.DataResponse> GetTestData(global::GrpcService.Interface.DataRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DataTest</summary>
    public partial class DataTestClient : grpc::ClientBase<DataTestClient>
    {
      /// <summary>Creates a new client for DataTest</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DataTestClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DataTest that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DataTestClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DataTestClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DataTestClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcService.Interface.EmptyMessge Warmup(global::GrpcService.Interface.EmptyMessge request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Warmup(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.Interface.EmptyMessge Warmup(global::GrpcService.Interface.EmptyMessge request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Warmup, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.Interface.EmptyMessge> WarmupAsync(global::GrpcService.Interface.EmptyMessge request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return WarmupAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.Interface.EmptyMessge> WarmupAsync(global::GrpcService.Interface.EmptyMessge request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Warmup, null, options, request);
      }
      public virtual global::GrpcService.Interface.DataResponse GetTestData(global::GrpcService.Interface.DataRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetTestData(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.Interface.DataResponse GetTestData(global::GrpcService.Interface.DataRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetTestData, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.Interface.DataResponse> GetTestDataAsync(global::GrpcService.Interface.DataRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetTestDataAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.Interface.DataResponse> GetTestDataAsync(global::GrpcService.Interface.DataRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetTestData, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DataTestClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DataTestClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DataTestBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Warmup, serviceImpl.Warmup)
          .AddMethod(__Method_GetTestData, serviceImpl.GetTestData).Build();
    }

  }
}
#endregion
