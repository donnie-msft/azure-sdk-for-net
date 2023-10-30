// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Custom activity type. </summary>
    public partial class CustomActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of CustomActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="command"> Command for custom activity Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="command"/> is null. </exception>
        public CustomActivity(string name, DataFactoryElement<string> command) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(command, nameof(command));

            Command = command;
            ExtendedProperties = new ChangeTrackingDictionary<string, BinaryData>();
            ActivityType = "Custom";
        }

        /// <summary> Initializes a new instance of CustomActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="command"> Command for custom activity Type: string (or Expression with resultType string). </param>
        /// <param name="resourceLinkedService"> Resource linked service reference. </param>
        /// <param name="folderPath"> Folder path for resource files Type: string (or Expression with resultType string). </param>
        /// <param name="referenceObjects"> Reference objects. </param>
        /// <param name="extendedProperties"> User defined property bag. There is no restriction on the keys or values that can be used. The user specified custom activity has the full responsibility to consume and interpret the content defined. </param>
        /// <param name="retentionTimeInDays"> The retention time for the files submitted for custom activity. Type: double (or Expression with resultType double). </param>
        /// <param name="autoUserSpecification"> Elevation level and scope for the user, default is nonadmin task. Type: string (or Expression with resultType double). </param>
        internal CustomActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, DataFactoryLinkedServiceReference linkedServiceName, PipelineActivityPolicy policy, DataFactoryElement<string> command, DataFactoryLinkedServiceReference resourceLinkedService, DataFactoryElement<string> folderPath, CustomActivityReferenceObject referenceObjects, IDictionary<string, BinaryData> extendedProperties, BinaryData retentionTimeInDays, DataFactoryElement<string> autoUserSpecification) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Command = command;
            ResourceLinkedService = resourceLinkedService;
            FolderPath = folderPath;
            ReferenceObjects = referenceObjects;
            ExtendedProperties = extendedProperties;
            RetentionTimeInDays = retentionTimeInDays;
            AutoUserSpecification = autoUserSpecification;
            ActivityType = activityType ?? "Custom";
        }

        /// <summary> Command for custom activity Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Command { get; set; }
        /// <summary> Resource linked service reference. </summary>
        public DataFactoryLinkedServiceReference ResourceLinkedService { get; set; }
        /// <summary> Folder path for resource files Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> FolderPath { get; set; }
        /// <summary> Reference objects. </summary>
        public CustomActivityReferenceObject ReferenceObjects { get; set; }
        /// <summary>
        /// User defined property bag. There is no restriction on the keys or values that can be used. The user specified custom activity has the full responsibility to consume and interpret the content defined.
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
        public IDictionary<string, BinaryData> ExtendedProperties { get; }
        /// <summary>
        /// The retention time for the files submitted for custom activity. Type: double (or Expression with resultType double).
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData RetentionTimeInDays { get; set; }
        /// <summary> Elevation level and scope for the user, default is nonadmin task. Type: string (or Expression with resultType double). </summary>
        public DataFactoryElement<string> AutoUserSpecification { get; set; }
    }
}
