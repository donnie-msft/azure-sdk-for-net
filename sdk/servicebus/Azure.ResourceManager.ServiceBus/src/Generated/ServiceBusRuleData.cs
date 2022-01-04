// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class representing the ServiceBusRule data model. </summary>
    public partial class ServiceBusRuleData : Resource
    {
        /// <summary> Initializes a new instance of ServiceBusRuleData. </summary>
        public ServiceBusRuleData()
        {
        }

        /// <summary> Initializes a new instance of ServiceBusRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The system meta data relating to this resource. </param>
        /// <param name="action"> Represents the filter actions which are allowed for the transformation of a message that have been matched by a filter expression. </param>
        /// <param name="filterType"> Filter type that is evaluated against a BrokeredMessage. </param>
        /// <param name="sqlFilter"> Properties of sqlFilter. </param>
        /// <param name="correlationFilter"> Properties of correlationFilter. </param>
        internal ServiceBusRuleData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, FilterAction action, FilterType? filterType, SqlFilter sqlFilter, CorrelationFilter correlationFilter) : base(id, name, type)
        {
            SystemData = systemData;
            Action = action;
            FilterType = filterType;
            SqlFilter = sqlFilter;
            CorrelationFilter = correlationFilter;
        }

        /// <summary> The system meta data relating to this resource. </summary>
        public SystemData SystemData { get; }
        /// <summary> Represents the filter actions which are allowed for the transformation of a message that have been matched by a filter expression. </summary>
        public FilterAction Action { get; set; }
        /// <summary> Filter type that is evaluated against a BrokeredMessage. </summary>
        public FilterType? FilterType { get; set; }
        /// <summary> Properties of sqlFilter. </summary>
        public SqlFilter SqlFilter { get; set; }
        /// <summary> Properties of correlationFilter. </summary>
        public CorrelationFilter CorrelationFilter { get; set; }
    }
}
