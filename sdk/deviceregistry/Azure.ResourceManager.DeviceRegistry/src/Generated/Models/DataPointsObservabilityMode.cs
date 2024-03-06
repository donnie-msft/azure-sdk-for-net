// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    /// <summary> An indication of how the data point should be mapped to OpenTelemetry. </summary>
    public readonly partial struct DataPointsObservabilityMode : IEquatable<DataPointsObservabilityMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataPointsObservabilityMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataPointsObservabilityMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "none";
        private const string CounterValue = "counter";
        private const string GaugeValue = "gauge";
        private const string HistogramValue = "histogram";
        private const string LogValue = "log";

        /// <summary> No mapping to OpenTelemetry. </summary>
        public static DataPointsObservabilityMode None { get; } = new DataPointsObservabilityMode(NoneValue);
        /// <summary> Map as counter to OpenTelemetry. </summary>
        public static DataPointsObservabilityMode Counter { get; } = new DataPointsObservabilityMode(CounterValue);
        /// <summary> Map as gauge to OpenTelemetry. </summary>
        public static DataPointsObservabilityMode Gauge { get; } = new DataPointsObservabilityMode(GaugeValue);
        /// <summary> Map as histogram to OpenTelemetry. </summary>
        public static DataPointsObservabilityMode Histogram { get; } = new DataPointsObservabilityMode(HistogramValue);
        /// <summary> Map as log to OpenTelemetry. </summary>
        public static DataPointsObservabilityMode Log { get; } = new DataPointsObservabilityMode(LogValue);
        /// <summary> Determines if two <see cref="DataPointsObservabilityMode"/> values are the same. </summary>
        public static bool operator ==(DataPointsObservabilityMode left, DataPointsObservabilityMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataPointsObservabilityMode"/> values are not the same. </summary>
        public static bool operator !=(DataPointsObservabilityMode left, DataPointsObservabilityMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataPointsObservabilityMode"/>. </summary>
        public static implicit operator DataPointsObservabilityMode(string value) => new DataPointsObservabilityMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataPointsObservabilityMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataPointsObservabilityMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
