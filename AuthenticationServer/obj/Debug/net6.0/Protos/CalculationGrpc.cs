// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/calculation.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace AuthenticationServer {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Calculation
  {
    static readonly string __ServiceName = "calculation.Calculation";

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
    static readonly grpc::Marshaller<global::AuthenticationServer.InputNumbers> __Marshaller_calculation_InputNumbers = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::AuthenticationServer.InputNumbers.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::AuthenticationServer.CalculationResult> __Marshaller_calculation_CalculationResult = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::AuthenticationServer.CalculationResult.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::AuthenticationServer.InputNumbers, global::AuthenticationServer.CalculationResult> __Method_PerformAddition = new grpc::Method<global::AuthenticationServer.InputNumbers, global::AuthenticationServer.CalculationResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PerformAddition",
        __Marshaller_calculation_InputNumbers,
        __Marshaller_calculation_CalculationResult);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::AuthenticationServer.InputNumbers, global::AuthenticationServer.CalculationResult> __Method_PerformSubtraction = new grpc::Method<global::AuthenticationServer.InputNumbers, global::AuthenticationServer.CalculationResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PerformSubtraction",
        __Marshaller_calculation_InputNumbers,
        __Marshaller_calculation_CalculationResult);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::AuthenticationServer.InputNumbers, global::AuthenticationServer.CalculationResult> __Method_PerformMultiplication = new grpc::Method<global::AuthenticationServer.InputNumbers, global::AuthenticationServer.CalculationResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PerformMultiplication",
        __Marshaller_calculation_InputNumbers,
        __Marshaller_calculation_CalculationResult);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::AuthenticationServer.InputNumbers, global::AuthenticationServer.CalculationResult> __Method_PerformDivision = new grpc::Method<global::AuthenticationServer.InputNumbers, global::AuthenticationServer.CalculationResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PerformDivision",
        __Marshaller_calculation_InputNumbers,
        __Marshaller_calculation_CalculationResult);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::AuthenticationServer.InputNumbers, global::AuthenticationServer.CalculationResult> __Method_PerformModulus = new grpc::Method<global::AuthenticationServer.InputNumbers, global::AuthenticationServer.CalculationResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PerformModulus",
        __Marshaller_calculation_InputNumbers,
        __Marshaller_calculation_CalculationResult);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AuthenticationServer.CalculationReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Calculation</summary>
    [grpc::BindServiceMethod(typeof(Calculation), "BindService")]
    public abstract partial class CalculationBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::AuthenticationServer.CalculationResult> PerformAddition(global::AuthenticationServer.InputNumbers request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::AuthenticationServer.CalculationResult> PerformSubtraction(global::AuthenticationServer.InputNumbers request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::AuthenticationServer.CalculationResult> PerformMultiplication(global::AuthenticationServer.InputNumbers request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::AuthenticationServer.CalculationResult> PerformDivision(global::AuthenticationServer.InputNumbers request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::AuthenticationServer.CalculationResult> PerformModulus(global::AuthenticationServer.InputNumbers request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CalculationBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_PerformAddition, serviceImpl.PerformAddition)
          .AddMethod(__Method_PerformSubtraction, serviceImpl.PerformSubtraction)
          .AddMethod(__Method_PerformMultiplication, serviceImpl.PerformMultiplication)
          .AddMethod(__Method_PerformDivision, serviceImpl.PerformDivision)
          .AddMethod(__Method_PerformModulus, serviceImpl.PerformModulus).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CalculationBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_PerformAddition, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::AuthenticationServer.InputNumbers, global::AuthenticationServer.CalculationResult>(serviceImpl.PerformAddition));
      serviceBinder.AddMethod(__Method_PerformSubtraction, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::AuthenticationServer.InputNumbers, global::AuthenticationServer.CalculationResult>(serviceImpl.PerformSubtraction));
      serviceBinder.AddMethod(__Method_PerformMultiplication, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::AuthenticationServer.InputNumbers, global::AuthenticationServer.CalculationResult>(serviceImpl.PerformMultiplication));
      serviceBinder.AddMethod(__Method_PerformDivision, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::AuthenticationServer.InputNumbers, global::AuthenticationServer.CalculationResult>(serviceImpl.PerformDivision));
      serviceBinder.AddMethod(__Method_PerformModulus, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::AuthenticationServer.InputNumbers, global::AuthenticationServer.CalculationResult>(serviceImpl.PerformModulus));
    }

  }
}
#endregion