// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/EmployeeCRUD.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService {
  public static partial class EmployeeCRUD
  {
    static readonly string __ServiceName = "NorthWind.EmployeeCRUD";

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

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

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

    static readonly grpc::Marshaller<global::GrpcService.Empty> __Marshaller_NorthWind_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.Empty.Parser));
    static readonly grpc::Marshaller<global::GrpcService.Employees> __Marshaller_NorthWind_Employees = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.Employees.Parser));
    static readonly grpc::Marshaller<global::GrpcService.EmployeeFilter> __Marshaller_NorthWind_EmployeeFilter = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.EmployeeFilter.Parser));
    static readonly grpc::Marshaller<global::GrpcService.Employee> __Marshaller_NorthWind_Employee = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.Employee.Parser));

    static readonly grpc::Method<global::GrpcService.Empty, global::GrpcService.Employees> __Method_SelectAll = new grpc::Method<global::GrpcService.Empty, global::GrpcService.Employees>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SelectAll",
        __Marshaller_NorthWind_Empty,
        __Marshaller_NorthWind_Employees);

    static readonly grpc::Method<global::GrpcService.EmployeeFilter, global::GrpcService.Employee> __Method_SelectById = new grpc::Method<global::GrpcService.EmployeeFilter, global::GrpcService.Employee>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SelectById",
        __Marshaller_NorthWind_EmployeeFilter,
        __Marshaller_NorthWind_Employee);

    static readonly grpc::Method<global::GrpcService.Employee, global::GrpcService.Empty> __Method_Insert = new grpc::Method<global::GrpcService.Employee, global::GrpcService.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Insert",
        __Marshaller_NorthWind_Employee,
        __Marshaller_NorthWind_Empty);

    static readonly grpc::Method<global::GrpcService.Employee, global::GrpcService.Empty> __Method_Update = new grpc::Method<global::GrpcService.Employee, global::GrpcService.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_NorthWind_Employee,
        __Marshaller_NorthWind_Empty);

    static readonly grpc::Method<global::GrpcService.EmployeeFilter, global::GrpcService.Empty> __Method_Delete = new grpc::Method<global::GrpcService.EmployeeFilter, global::GrpcService.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_NorthWind_EmployeeFilter,
        __Marshaller_NorthWind_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.EmployeeCRUDReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of EmployeeCRUD</summary>
    [grpc::BindServiceMethod(typeof(EmployeeCRUD), "BindService")]
    public abstract partial class EmployeeCRUDBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Employees> SelectAll(global::GrpcService.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Employee> SelectById(global::GrpcService.EmployeeFilter request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Empty> Insert(global::GrpcService.Employee request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Empty> Update(global::GrpcService.Employee request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Empty> Delete(global::GrpcService.EmployeeFilter request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(EmployeeCRUDBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SelectAll, serviceImpl.SelectAll)
          .AddMethod(__Method_SelectById, serviceImpl.SelectById)
          .AddMethod(__Method_Insert, serviceImpl.Insert)
          .AddMethod(__Method_Update, serviceImpl.Update)
          .AddMethod(__Method_Delete, serviceImpl.Delete).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, EmployeeCRUDBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SelectAll, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Empty, global::GrpcService.Employees>(serviceImpl.SelectAll));
      serviceBinder.AddMethod(__Method_SelectById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.EmployeeFilter, global::GrpcService.Employee>(serviceImpl.SelectById));
      serviceBinder.AddMethod(__Method_Insert, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Employee, global::GrpcService.Empty>(serviceImpl.Insert));
      serviceBinder.AddMethod(__Method_Update, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Employee, global::GrpcService.Empty>(serviceImpl.Update));
      serviceBinder.AddMethod(__Method_Delete, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.EmployeeFilter, global::GrpcService.Empty>(serviceImpl.Delete));
    }

  }
}
#endregion
