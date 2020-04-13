// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NameRequestService.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Generated {
  public static partial class NameRequestService
  {
    static readonly string __ServiceName = "NameRequestService";

    static readonly grpc::Marshaller<global::Generated.Name> __Marshaller_Name = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Generated.Name.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Generated.EmptyMessage> __Marshaller_EmptyMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Generated.EmptyMessage.Parser.ParseFrom);

    static readonly grpc::Method<global::Generated.Name, global::Generated.EmptyMessage> __Method_OutputName = new grpc::Method<global::Generated.Name, global::Generated.EmptyMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "OutputName",
        __Marshaller_Name,
        __Marshaller_EmptyMessage);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Generated.NameRequestServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of NameRequestService</summary>
    [grpc::BindServiceMethod(typeof(NameRequestService), "BindService")]
    public abstract partial class NameRequestServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Generated.EmptyMessage> OutputName(global::Generated.Name request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for NameRequestService</summary>
    public partial class NameRequestServiceClient : grpc::ClientBase<NameRequestServiceClient>
    {
      /// <summary>Creates a new client for NameRequestService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public NameRequestServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for NameRequestService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public NameRequestServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected NameRequestServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected NameRequestServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Generated.EmptyMessage OutputName(global::Generated.Name request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OutputName(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Generated.EmptyMessage OutputName(global::Generated.Name request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_OutputName, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Generated.EmptyMessage> OutputNameAsync(global::Generated.Name request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OutputNameAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Generated.EmptyMessage> OutputNameAsync(global::Generated.Name request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_OutputName, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override NameRequestServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new NameRequestServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(NameRequestServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_OutputName, serviceImpl.OutputName).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, NameRequestServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_OutputName, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Generated.Name, global::Generated.EmptyMessage>(serviceImpl.OutputName));
    }

  }
}
#endregion