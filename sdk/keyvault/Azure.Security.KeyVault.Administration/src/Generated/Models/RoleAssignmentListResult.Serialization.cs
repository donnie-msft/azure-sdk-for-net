// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Security.KeyVault.Administration;

namespace Azure.Security.KeyVault.Administration.Models
{
    internal partial class RoleAssignmentListResult
    {
        internal static RoleAssignmentListResult DeserializeRoleAssignmentListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<KeyVaultRoleAssignment> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KeyVaultRoleAssignment> array = new List<KeyVaultRoleAssignment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KeyVaultRoleAssignment.DeserializeKeyVaultRoleAssignment(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new RoleAssignmentListResult(value ?? new ChangeTrackingList<KeyVaultRoleAssignment>(), nextLink.Value);
        }
    }
}
