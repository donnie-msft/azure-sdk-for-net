// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Data.Batch.Models
{
    internal static partial class SubtaskStateExtensions
    {
        public static string ToSerialString(this SubtaskState value) => value switch
        {
            SubtaskState.Preparing => "preparing",
            SubtaskState.Running => "running",
            SubtaskState.Completed => "completed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SubtaskState value.")
        };

        public static SubtaskState ToSubtaskState(this string value)
        {
            if (string.Equals(value, "preparing", StringComparison.InvariantCultureIgnoreCase)) return SubtaskState.Preparing;
            if (string.Equals(value, "running", StringComparison.InvariantCultureIgnoreCase)) return SubtaskState.Running;
            if (string.Equals(value, "completed", StringComparison.InvariantCultureIgnoreCase)) return SubtaskState.Completed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SubtaskState value.");
        }
    }
}
