// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ConnectMeServer {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Greeter
  {
    static readonly string __ServiceName = "greet.Greeter";

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
    static readonly grpc::Marshaller<global::ConnectMeServer.RequestClientConnect> __Marshaller_greet_RequestClientConnect = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ConnectMeServer.RequestClientConnect.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ConnectMeServer.ResponseClientConnect> __Marshaller_greet_ResponseClientConnect = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ConnectMeServer.ResponseClientConnect.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ConnectMeServer.RequestClientConsumer> __Marshaller_greet_RequestClientConsumer = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ConnectMeServer.RequestClientConsumer.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ConnectMeServer.ResponseClientConsumer> __Marshaller_greet_ResponseClientConsumer = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ConnectMeServer.ResponseClientConsumer.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ConnectMeServer.RequestConnection> __Marshaller_greet_RequestConnection = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ConnectMeServer.RequestConnection.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ConnectMeServer.ResponseConnection> __Marshaller_greet_ResponseConnection = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ConnectMeServer.ResponseConnection.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ConnectMeServer.RequestClientConnect, global::ConnectMeServer.ResponseClientConnect> __Method_ConnectClient = new grpc::Method<global::ConnectMeServer.RequestClientConnect, global::ConnectMeServer.ResponseClientConnect>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "ConnectClient",
        __Marshaller_greet_RequestClientConnect,
        __Marshaller_greet_ResponseClientConnect);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ConnectMeServer.RequestClientConsumer, global::ConnectMeServer.ResponseClientConsumer> __Method_ConsumerClient = new grpc::Method<global::ConnectMeServer.RequestClientConsumer, global::ConnectMeServer.ResponseClientConsumer>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "ConsumerClient",
        __Marshaller_greet_RequestClientConsumer,
        __Marshaller_greet_ResponseClientConsumer);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ConnectMeServer.RequestConnection, global::ConnectMeServer.ResponseConnection> __Method_handleConnection = new grpc::Method<global::ConnectMeServer.RequestConnection, global::ConnectMeServer.ResponseConnection>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "handleConnection",
        __Marshaller_greet_RequestConnection,
        __Marshaller_greet_ResponseConnection);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ConnectMeServer.GreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Greeter</summary>
    [grpc::BindServiceMethod(typeof(Greeter), "BindService")]
    public abstract partial class GreeterBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task ConnectClient(grpc::IAsyncStreamReader<global::ConnectMeServer.RequestClientConnect> requestStream, grpc::IServerStreamWriter<global::ConnectMeServer.ResponseClientConnect> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task ConsumerClient(grpc::IAsyncStreamReader<global::ConnectMeServer.RequestClientConsumer> requestStream, grpc::IServerStreamWriter<global::ConnectMeServer.ResponseClientConsumer> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task handleConnection(grpc::IAsyncStreamReader<global::ConnectMeServer.RequestConnection> requestStream, grpc::IServerStreamWriter<global::ConnectMeServer.ResponseConnection> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(GreeterBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ConnectClient, serviceImpl.ConnectClient)
          .AddMethod(__Method_ConsumerClient, serviceImpl.ConsumerClient)
          .AddMethod(__Method_handleConnection, serviceImpl.handleConnection).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GreeterBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ConnectClient, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::ConnectMeServer.RequestClientConnect, global::ConnectMeServer.ResponseClientConnect>(serviceImpl.ConnectClient));
      serviceBinder.AddMethod(__Method_ConsumerClient, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::ConnectMeServer.RequestClientConsumer, global::ConnectMeServer.ResponseClientConsumer>(serviceImpl.ConsumerClient));
      serviceBinder.AddMethod(__Method_handleConnection, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::ConnectMeServer.RequestConnection, global::ConnectMeServer.ResponseConnection>(serviceImpl.handleConnection));
    }

  }
}
#endregion
