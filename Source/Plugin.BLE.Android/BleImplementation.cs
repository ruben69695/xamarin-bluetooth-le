using System;
using Plugin.BLE.Abstractions;
using Plugin.BLE.Abstractions.Contracts;

// ReSharper disable once CheckNamespace
namespace Plugin.BLE
{
    class BleImplementation : IBluetoothLE
    {
        public BleImplementation()
        {
            Trace.TraceImplementation = Console.WriteLine;
        }
    }
}