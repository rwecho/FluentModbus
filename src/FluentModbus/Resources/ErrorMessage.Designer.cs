﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FluentModbus {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ErrorMessage {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessage() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SWS.FluentModbus.Resources.ErrorMessage", typeof(ErrorMessage).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid use of broadcast: Unit identifier &apos;0&apos; can only be used for write operations..
        /// </summary>
        internal static string Modbus_InvalidUseOfBroadcast {
            get {
                return ResourceManager.GetString("Modbus_InvalidUseOfBroadcast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value is invalid. Valid values are in the range of 0 - 65535..
        /// </summary>
        internal static string Modbus_InvalidValueUShort {
            get {
                return ResourceManager.GetString("Modbus_InvalidValueUShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The function code received in the query is not an allowable action for the server. This may be because the function code is only applicable to newer devices, and was not implemented in the unit selected. It could also indicate that the server is in the wrong state to process a request of this type, for example because it is unconfigured and is being asked to return register values..
        /// </summary>
        internal static string ModbusClient_0x01_IllegalFunction {
            get {
                return ResourceManager.GetString("ModbusClient_0x01_IllegalFunction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The data address received in the query is not an allowable address for the server. More specifically, the combination of reference number and transfer length is invalid..
        /// </summary>
        internal static string ModbusClient_0x02_IllegalDataAddress {
            get {
                return ResourceManager.GetString("ModbusClient_0x02_IllegalDataAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A value contained in the query data field is not an allowable value for server. This indicates a fault in the structure of the remainder of a complex request, such as that the implied length is incorrect..
        /// </summary>
        internal static string ModbusClient_0x03_IllegalDataValue {
            get {
                return ResourceManager.GetString("ModbusClient_0x03_IllegalDataValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The quantity of registers is out of range (1..123). Make sure to request a minimum of one register. If you use the generic overload methods, please note that a single register consists of 2 bytes. If, for example, 1 x int32 value is requested, this results in a read operation of 2 registers..
        /// </summary>
        internal static string ModbusClient_0x03_IllegalDataValue_0x7B {
            get {
                return ResourceManager.GetString("ModbusClient_0x03_IllegalDataValue_0x7B", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The quantity of registers is out of range (1..125). Make sure to request a minimum of one register. If you use the generic overload methods, please note that a single register consists of 2 bytes. If, for example, 1 x int32 value is requested, this results in a read operation of 2 registers..
        /// </summary>
        internal static string ModbusClient_0x03_IllegalDataValue_0x7D {
            get {
                return ResourceManager.GetString("ModbusClient_0x03_IllegalDataValue_0x7D", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The quantity of coils is out of range (1..2000)..
        /// </summary>
        internal static string ModbusClient_0x03_IllegalDataValue_0x7D0 {
            get {
                return ResourceManager.GetString("ModbusClient_0x03_IllegalDataValue_0x7D0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unrecoverable error occurred while the server was attempting to perform the requested action..
        /// </summary>
        internal static string ModbusClient_0x04_ServerDeviceFailure {
            get {
                return ResourceManager.GetString("ModbusClient_0x04_ServerDeviceFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The server has accepted the request and is processing it, but a long duration of time will be required to do so..
        /// </summary>
        internal static string ModbusClient_0x05_Acknowledge {
            get {
                return ResourceManager.GetString("ModbusClient_0x05_Acknowledge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The server is engaged in processing a long–duration program command..
        /// </summary>
        internal static string ModbusClient_0x06_ServerDeviceBusy {
            get {
                return ResourceManager.GetString("ModbusClient_0x06_ServerDeviceBusy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The server attempted to read record file, but detected a parity error in the memory..
        /// </summary>
        internal static string ModbusClient_0x08_MemoryParityError {
            get {
                return ResourceManager.GetString("ModbusClient_0x08_MemoryParityError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The gateway was unable to allocate an internal communication path from the input port to the output port for processing the request..
        /// </summary>
        internal static string ModbusClient_0x0A_GatewayPathUnavailable {
            get {
                return ResourceManager.GetString("ModbusClient_0x0A_GatewayPathUnavailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No response was obtained from the target device.
        /// </summary>
        internal static string ModbusClient_0x0B_GatewayTargetDeviceFailedToRespond {
            get {
                return ResourceManager.GetString("ModbusClient_0x0B_GatewayTargetDeviceFailedToRespond", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Array length must be equal to two bytes..
        /// </summary>
        internal static string ModbusClient_ArrayLengthMustBeEqualToTwo {
            get {
                return ResourceManager.GetString("ModbusClient_ArrayLengthMustBeEqualToTwo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Array length must be greater than two bytes and even..
        /// </summary>
        internal static string ModbusClient_ArrayLengthMustBeGreaterThanTwoAndEven {
            get {
                return ResourceManager.GetString("ModbusClient_ArrayLengthMustBeGreaterThanTwoAndEven", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The exception code received from the server is invalid..
        /// </summary>
        internal static string ModbusClient_InvalidExceptionCode {
            get {
                return ResourceManager.GetString("ModbusClient_InvalidExceptionCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The protocol identifier is invalid..
        /// </summary>
        internal static string ModbusClient_InvalidProtocolIdentifier {
            get {
                return ResourceManager.GetString("ModbusClient_InvalidProtocolIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The responsed function code is invalid..
        /// </summary>
        internal static string ModbusClient_InvalidResponseFunctionCode {
            get {
                return ResourceManager.GetString("ModbusClient_InvalidResponseFunctionCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The response message length is invalid..
        /// </summary>
        internal static string ModbusClient_InvalidResponseMessageLength {
            get {
                return ResourceManager.GetString("ModbusClient_InvalidResponseMessageLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The unit identifier is invalid. Valid node addresses are in the range of 0 - 247. Use address &apos;0&apos; to broadcast write command to all available servers..
        /// </summary>
        internal static string ModbusClient_InvalidUnitIdentifier {
            get {
                return ResourceManager.GetString("ModbusClient_InvalidUnitIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Quantity must be a positive integer number. Choose the &apos;count&apos; parameter such that an even number of bytes is requested..
        /// </summary>
        internal static string ModbusClient_QuantityMustBePositiveInteger {
            get {
                return ResourceManager.GetString("ModbusClient_QuantityMustBePositiveInteger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The TCP connection closed unexpectedly..
        /// </summary>
        internal static string ModbusClient_TcpConnectionClosedUnexpectedly {
            get {
                return ResourceManager.GetString("ModbusClient_TcpConnectionClosedUnexpectedly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not connect within the specified time..
        /// </summary>
        internal static string ModbusClient_TcpConnectTimeout {
            get {
                return ResourceManager.GetString("ModbusClient_TcpConnectTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown {0} Modbus error received..
        /// </summary>
        internal static string ModbusClient_Unknown_Error {
            get {
                return ResourceManager.GetString("ModbusClient_Unknown_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The unit identifier is invalid. Valid node addresses are in the range of 1 - 247..
        /// </summary>
        internal static string ModbusServer_InvalidUnitIdentifier {
            get {
                return ResourceManager.GetString("ModbusServer_InvalidUnitIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No unit found for the specified unit identifier..
        /// </summary>
        internal static string ModbusServer_UnitIdentifierNotFound {
            get {
                return ResourceManager.GetString("ModbusServer_UnitIdentifierNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no valid request available..
        /// </summary>
        internal static string ModbusTcpRequestHandler_NoValidRequestAvailable {
            get {
                return ResourceManager.GetString("ModbusTcpRequestHandler_NoValidRequestAvailable", resourceCulture);
            }
        }
    }
}
