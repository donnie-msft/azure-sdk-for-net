// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that validates connection to Azure SQL Database Managed Instance. </summary>
    public partial class ConnectToTargetSqlMITaskInput
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ConnectToTargetSqlMITaskInput"/>. </summary>
        /// <param name="targetConnectionInfo"> Connection information for target SQL Server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetConnectionInfo"/> is null. </exception>
        public ConnectToTargetSqlMITaskInput(SqlConnectionInfo targetConnectionInfo)
        {
            if (targetConnectionInfo == null)
            {
                throw new ArgumentNullException(nameof(targetConnectionInfo));
            }

            TargetConnectionInfo = targetConnectionInfo;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToTargetSqlMITaskInput"/>. </summary>
        /// <param name="targetConnectionInfo"> Connection information for target SQL Server. </param>
        /// <param name="collectLogins"> Flag for whether to collect logins from target SQL MI server. </param>
        /// <param name="collectAgentJobs"> Flag for whether to collect agent jobs from target SQL MI server. </param>
        /// <param name="validateSsisCatalogOnly"> Flag for whether to validate SSIS catalog is reachable on the target SQL MI server. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectToTargetSqlMITaskInput(SqlConnectionInfo targetConnectionInfo, bool? collectLogins, bool? collectAgentJobs, bool? validateSsisCatalogOnly, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetConnectionInfo = targetConnectionInfo;
            CollectLogins = collectLogins;
            CollectAgentJobs = collectAgentJobs;
            ValidateSsisCatalogOnly = validateSsisCatalogOnly;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToTargetSqlMITaskInput"/> for deserialization. </summary>
        internal ConnectToTargetSqlMITaskInput()
        {
        }

        /// <summary> Connection information for target SQL Server. </summary>
        public SqlConnectionInfo TargetConnectionInfo { get; set; }
        /// <summary> Flag for whether to collect logins from target SQL MI server. </summary>
        public bool? CollectLogins { get; set; }
        /// <summary> Flag for whether to collect agent jobs from target SQL MI server. </summary>
        public bool? CollectAgentJobs { get; set; }
        /// <summary> Flag for whether to validate SSIS catalog is reachable on the target SQL MI server. </summary>
        public bool? ValidateSsisCatalogOnly { get; set; }
    }
}
