// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/order - Copy.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PRN231_ProjectMain {
  public static partial class Orderer
  {
    static readonly string __ServiceName = "order.Orderer";

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
    static readonly grpc::Marshaller<global::PRN231_ProjectMain.GetListOrderByUserIdReq> __Marshaller_order_GetListOrderByUserIdReq = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PRN231_ProjectMain.GetListOrderByUserIdReq.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PRN231_ProjectMain.LstOrderRepl> __Marshaller_order_LstOrderRepl = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PRN231_ProjectMain.LstOrderRepl.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PRN231_ProjectMain.AddOrderByUserIdReq> __Marshaller_order_AddOrderByUserIdReq = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PRN231_ProjectMain.AddOrderByUserIdReq.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PRN231_ProjectMain.CRUDRepl> __Marshaller_product_CRUDRepl = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PRN231_ProjectMain.CRUDRepl.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PRN231_ProjectMain.GetOrderInfoByOrderIdReq> __Marshaller_order_GetOrderInfoByOrderIdReq = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PRN231_ProjectMain.GetOrderInfoByOrderIdReq.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PRN231_ProjectMain.LstOrderInfoRepl> __Marshaller_order_LstOrderInfoRepl = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PRN231_ProjectMain.LstOrderInfoRepl.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PRN231_ProjectMain.GetListOrderByUserIdReq, global::PRN231_ProjectMain.LstOrderRepl> __Method_GetListOrderByUserId = new grpc::Method<global::PRN231_ProjectMain.GetListOrderByUserIdReq, global::PRN231_ProjectMain.LstOrderRepl>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetListOrderByUserId",
        __Marshaller_order_GetListOrderByUserIdReq,
        __Marshaller_order_LstOrderRepl);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PRN231_ProjectMain.AddOrderByUserIdReq, global::PRN231_ProjectMain.CRUDRepl> __Method_AddOrderByUserId = new grpc::Method<global::PRN231_ProjectMain.AddOrderByUserIdReq, global::PRN231_ProjectMain.CRUDRepl>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddOrderByUserId",
        __Marshaller_order_AddOrderByUserIdReq,
        __Marshaller_product_CRUDRepl);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PRN231_ProjectMain.GetOrderInfoByOrderIdReq, global::PRN231_ProjectMain.LstOrderInfoRepl> __Method_GetOrderInfoByOrderId = new grpc::Method<global::PRN231_ProjectMain.GetOrderInfoByOrderIdReq, global::PRN231_ProjectMain.LstOrderInfoRepl>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetOrderInfoByOrderId",
        __Marshaller_order_GetOrderInfoByOrderIdReq,
        __Marshaller_order_LstOrderInfoRepl);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PRN231_ProjectMain.OrderCopyReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Orderer</summary>
    [grpc::BindServiceMethod(typeof(Orderer), "BindService")]
    public abstract partial class OrdererBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PRN231_ProjectMain.LstOrderRepl> GetListOrderByUserId(global::PRN231_ProjectMain.GetListOrderByUserIdReq request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PRN231_ProjectMain.CRUDRepl> AddOrderByUserId(global::PRN231_ProjectMain.AddOrderByUserIdReq request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PRN231_ProjectMain.LstOrderInfoRepl> GetOrderInfoByOrderId(global::PRN231_ProjectMain.GetOrderInfoByOrderIdReq request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(OrdererBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetListOrderByUserId, serviceImpl.GetListOrderByUserId)
          .AddMethod(__Method_AddOrderByUserId, serviceImpl.AddOrderByUserId)
          .AddMethod(__Method_GetOrderInfoByOrderId, serviceImpl.GetOrderInfoByOrderId).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, OrdererBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetListOrderByUserId, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PRN231_ProjectMain.GetListOrderByUserIdReq, global::PRN231_ProjectMain.LstOrderRepl>(serviceImpl.GetListOrderByUserId));
      serviceBinder.AddMethod(__Method_AddOrderByUserId, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PRN231_ProjectMain.AddOrderByUserIdReq, global::PRN231_ProjectMain.CRUDRepl>(serviceImpl.AddOrderByUserId));
      serviceBinder.AddMethod(__Method_GetOrderInfoByOrderId, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PRN231_ProjectMain.GetOrderInfoByOrderIdReq, global::PRN231_ProjectMain.LstOrderInfoRepl>(serviceImpl.GetOrderInfoByOrderId));
    }

  }
}
#endregion