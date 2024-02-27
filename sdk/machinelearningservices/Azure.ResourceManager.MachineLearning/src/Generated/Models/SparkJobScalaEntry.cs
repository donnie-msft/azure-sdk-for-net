// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The SparkJobScalaEntry. </summary>
    public partial class SparkJobScalaEntry : SparkJobEntry
    {
        /// <summary> Initializes a new instance of <see cref="SparkJobScalaEntry"/>. </summary>
        /// <param name="className"> [Required] Scala class name used as entry point. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="className"/> is null. </exception>
        public SparkJobScalaEntry(string className)
        {
            if (className == null)
            {
                throw new ArgumentNullException(nameof(className));
            }

            ClassName = className;
            SparkJobEntryType = SparkJobEntryType.SparkJobScalaEntry;
        }

        /// <summary> Initializes a new instance of <see cref="SparkJobScalaEntry"/>. </summary>
        /// <param name="sparkJobEntryType"> [Required] Type of the job's entry point. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="className"> [Required] Scala class name used as entry point. </param>
        internal SparkJobScalaEntry(SparkJobEntryType sparkJobEntryType, IDictionary<string, BinaryData> serializedAdditionalRawData, string className) : base(sparkJobEntryType, serializedAdditionalRawData)
        {
            ClassName = className;
            SparkJobEntryType = sparkJobEntryType;
        }

        /// <summary> Initializes a new instance of <see cref="SparkJobScalaEntry"/> for deserialization. </summary>
        internal SparkJobScalaEntry()
        {
        }

        /// <summary> [Required] Scala class name used as entry point. </summary>
        public string ClassName { get; set; }
    }
}
