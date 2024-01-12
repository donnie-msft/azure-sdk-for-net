// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Workloads
{
    public partial class SapCentralServerInstanceResource : IJsonModel<SapCentralServerInstanceData>
    {
        void IJsonModel<SapCentralServerInstanceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        SapCentralServerInstanceData IJsonModel<SapCentralServerInstanceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SapCentralServerInstanceData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<SapCentralServerInstanceData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        SapCentralServerInstanceData IPersistableModel<SapCentralServerInstanceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SapCentralServerInstanceData>(data, options);
        }

        string IPersistableModel<SapCentralServerInstanceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
