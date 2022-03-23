// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Data.Batch.Models
{
    internal partial class PoolNodeCountsListResult
    {
        internal static PoolNodeCountsListResult DeserializePoolNodeCountsListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PoolNodeCounts>> value = default;
            Optional<string> odataNextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PoolNodeCounts> array = new List<PoolNodeCounts>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PoolNodeCounts.DeserializePoolNodeCounts(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("odata.nextLink"))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PoolNodeCountsListResult(Optional.ToList(value), odataNextLink.Value);
        }
    }
}
