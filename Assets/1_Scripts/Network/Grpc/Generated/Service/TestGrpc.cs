// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: test.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Service.Test {
  public static partial class Test
  {
    static readonly string __ServiceName = "service.test.Test";

    static readonly grpc::Marshaller<global::Service.Test.IKnowRequest> __Marshaller_service_test_IKnowRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Service.Test.IKnowRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Service.Test.IKnowResponse> __Marshaller_service_test_IKnowResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Service.Test.IKnowResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Service.Test.IDontKnowRequest> __Marshaller_service_test_IDontKnowRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Service.Test.IDontKnowRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Service.Test.IDontKnowResponse> __Marshaller_service_test_IDontKnowResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Service.Test.IDontKnowResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Service.Test.IKnowRequest, global::Service.Test.IKnowResponse> __Method_IKnow = new grpc::Method<global::Service.Test.IKnowRequest, global::Service.Test.IKnowResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "IKnow",
        __Marshaller_service_test_IKnowRequest,
        __Marshaller_service_test_IKnowResponse);

    static readonly grpc::Method<global::Service.Test.IDontKnowRequest, global::Service.Test.IDontKnowResponse> __Method_IDontKnow = new grpc::Method<global::Service.Test.IDontKnowRequest, global::Service.Test.IDontKnowResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "IDontKnow",
        __Marshaller_service_test_IDontKnowRequest,
        __Marshaller_service_test_IDontKnowResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Service.Test.TestReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Test</summary>
    public partial class TestClient : grpc::ClientBase<TestClient>
    {
      /// <summary>Creates a new client for Test</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TestClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Test that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TestClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TestClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TestClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Service.Test.IKnowResponse IKnow(global::Service.Test.IKnowRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return IKnow(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Service.Test.IKnowResponse IKnow(global::Service.Test.IKnowRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_IKnow, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Service.Test.IKnowResponse> IKnowAsync(global::Service.Test.IKnowRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return IKnowAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Service.Test.IKnowResponse> IKnowAsync(global::Service.Test.IKnowRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_IKnow, null, options, request);
      }
      public virtual global::Service.Test.IDontKnowResponse IDontKnow(global::Service.Test.IDontKnowRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return IDontKnow(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Service.Test.IDontKnowResponse IDontKnow(global::Service.Test.IDontKnowRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_IDontKnow, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Service.Test.IDontKnowResponse> IDontKnowAsync(global::Service.Test.IDontKnowRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return IDontKnowAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Service.Test.IDontKnowResponse> IDontKnowAsync(global::Service.Test.IDontKnowRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_IDontKnow, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TestClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TestClient(configuration);
      }
    }

  }
}
#endregion
