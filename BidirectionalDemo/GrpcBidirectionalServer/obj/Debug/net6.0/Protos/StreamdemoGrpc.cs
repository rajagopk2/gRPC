// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/streamdemo.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcBidirectionalServer {
  public static partial class StreamDemo
  {
    static readonly string __ServiceName = "streamdemo.StreamDemo";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcBidirectionalServer.MultipleTest> __Marshaller_streamdemo_MultipleTest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcBidirectionalServer.MultipleTest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcBidirectionalServer.MultipleTest, global::GrpcBidirectionalServer.MultipleTest> __Method_BidirectionalStreamingDemo = new grpc::Method<global::GrpcBidirectionalServer.MultipleTest, global::GrpcBidirectionalServer.MultipleTest>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "BidirectionalStreamingDemo",
        __Marshaller_streamdemo_MultipleTest,
        __Marshaller_streamdemo_MultipleTest);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcBidirectionalServer.StreamdemoReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of StreamDemo</summary>
    [grpc::BindServiceMethod(typeof(StreamDemo), "BindService")]
    public abstract partial class StreamDemoBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task BidirectionalStreamingDemo(grpc::IAsyncStreamReader<global::GrpcBidirectionalServer.MultipleTest> requestStream, grpc::IServerStreamWriter<global::GrpcBidirectionalServer.MultipleTest> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(StreamDemoBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_BidirectionalStreamingDemo, serviceImpl.BidirectionalStreamingDemo).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, StreamDemoBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_BidirectionalStreamingDemo, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::GrpcBidirectionalServer.MultipleTest, global::GrpcBidirectionalServer.MultipleTest>(serviceImpl.BidirectionalStreamingDemo));
    }

  }
}
#endregion
