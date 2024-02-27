// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> Model factory for models. </summary>
    public static partial class AIAnomalyDetectorModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="AnomalyDetector.TimeSeriesPoint"/>. </summary>
        /// <param name="timestamp"> Argument that indicates the time stamp of a data point (ISO8601 format). </param>
        /// <param name="value"> Measurement of that point. </param>
        /// <returns> A new <see cref="AnomalyDetector.TimeSeriesPoint"/> instance for mocking. </returns>
        public static TimeSeriesPoint TimeSeriesPoint(DateTimeOffset? timestamp = null, float value = default)
        {
            return new TimeSeriesPoint(timestamp, value, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyDetector.UnivariateLastDetectionResult"/>. </summary>
        /// <param name="period">
        /// Frequency extracted from the series. Zero means no recurrent pattern has been
        /// found.
        /// </param>
        /// <param name="suggestedWindow"> Suggested input series points needed for detecting the latest point. </param>
        /// <param name="expectedValue"> Expected value of the latest point. </param>
        /// <param name="upperMargin">
        /// Upper margin of the latest point. UpperMargin is used to calculate
        /// upperBoundary, which is equal to expectedValue + (100 - marginScale)*upperMargin.
        /// If the value of latest point is between upperBoundary and lowerBoundary, it
        /// should be treated as a normal value. Adjusting the marginScale value enables the anomaly
        /// status of the latest point to be changed.
        /// </param>
        /// <param name="lowerMargin">
        /// Lower margin of the latest point. LowerMargin is used to calculate
        /// lowerBoundary, which is equal to expectedValue - (100 - marginScale)*lowerMargin.
        /// </param>
        /// <param name="isAnomaly">
        /// Anomaly status of the latest point. True means the latest point is an anomaly,
        /// either in the negative direction or in the positive direction.
        /// </param>
        /// <param name="isNegativeAnomaly">
        /// Anomaly status of the latest point in a negative direction. True means the latest
        /// point is an anomaly and its real value is smaller than the expected one.
        /// </param>
        /// <param name="isPositiveAnomaly">
        /// Anomaly status of the latest point in a positive direction. True means the latest
        /// point is an anomaly and its real value is larger than the expected one.
        /// </param>
        /// <param name="severity">
        /// Severity score for the last input point. The larger the value is, the more
        /// severe the anomaly is. For normal points, the severity is always 0.
        /// </param>
        /// <returns> A new <see cref="AnomalyDetector.UnivariateLastDetectionResult"/> instance for mocking. </returns>
        public static UnivariateLastDetectionResult UnivariateLastDetectionResult(int period = default, int suggestedWindow = default, float expectedValue = default, float upperMargin = default, float lowerMargin = default, bool isAnomaly = default, bool isNegativeAnomaly = default, bool isPositiveAnomaly = default, float? severity = null)
        {
            return new UnivariateLastDetectionResult(
                period,
                suggestedWindow,
                expectedValue,
                upperMargin,
                lowerMargin,
                isAnomaly,
                isNegativeAnomaly,
                isPositiveAnomaly,
                severity,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyDetector.UnivariateChangePointDetectionOptions"/>. </summary>
        /// <param name="series">
        /// Time series data points. Points should be sorted by time stamp in ascending
        /// order to match the change point detection result.
        /// </param>
        /// <param name="granularity"> Granularity is used to verify whether the input series is valid. </param>
        /// <param name="customInterval">
        /// A custom interval is used to set a nonstandard time interval. For example, if the
        /// series is 5 minutes, the request can be set as {"granularity":"minutely",
        /// "customInterval":5}.
        /// </param>
        /// <param name="period">
        /// Argument that indicates the periodic value of a time series. If the value is null or
        /// not present, the API will determine the period automatically.
        /// </param>
        /// <param name="stableTrendWindow">
        /// Argument that indicates an advanced model parameter. A default stableTrendWindow value will
        /// be used in detection.
        /// </param>
        /// <param name="threshold">
        /// Argument that indicates an advanced model parameter between 0.0 and 1.0. The lower the
        /// value is, the larger the trend error is, which means less change point will
        /// be accepted.
        /// </param>
        /// <returns> A new <see cref="AnomalyDetector.UnivariateChangePointDetectionOptions"/> instance for mocking. </returns>
        public static UnivariateChangePointDetectionOptions UnivariateChangePointDetectionOptions(IEnumerable<TimeSeriesPoint> series = null, TimeGranularity granularity = default, int? customInterval = null, int? period = null, int? stableTrendWindow = null, float? threshold = null)
        {
            series ??= new List<TimeSeriesPoint>();

            return new UnivariateChangePointDetectionOptions(
                series?.ToList(),
                granularity,
                customInterval,
                period,
                stableTrendWindow,
                threshold,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyDetector.UnivariateChangePointDetectionResult"/>. </summary>
        /// <param name="period">
        /// Frequency extracted from the series. Zero means no recurrent pattern has been
        /// found.
        /// </param>
        /// <param name="isChangePoint">
        /// Change point properties for each input point. True means
        /// an anomaly (either negative or positive) has been detected. The index of the
        /// array is consistent with the input series.
        /// </param>
        /// <param name="confidenceScores"> Change point confidence of each point. </param>
        /// <returns> A new <see cref="AnomalyDetector.UnivariateChangePointDetectionResult"/> instance for mocking. </returns>
        public static UnivariateChangePointDetectionResult UnivariateChangePointDetectionResult(int? period = null, IEnumerable<bool> isChangePoint = null, IEnumerable<float> confidenceScores = null)
        {
            isChangePoint ??= new List<bool>();
            confidenceScores ??= new List<float>();

            return new UnivariateChangePointDetectionResult(period, isChangePoint?.ToList(), confidenceScores?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyDetector.MultivariateDetectionResult"/>. </summary>
        /// <param name="resultId"> Result identifier that's used to fetch the results of an inference call. </param>
        /// <param name="summary"> Multivariate anomaly detection status. </param>
        /// <param name="results"> Detection result for each time stamp. </param>
        /// <returns> A new <see cref="AnomalyDetector.MultivariateDetectionResult"/> instance for mocking. </returns>
        public static MultivariateDetectionResult MultivariateDetectionResult(Guid resultId = default, MultivariateBatchDetectionResultSummary summary = null, IEnumerable<AnomalyState> results = null)
        {
            results ??= new List<AnomalyState>();

            return new MultivariateDetectionResult(resultId, summary, results?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyDetector.MultivariateBatchDetectionResultSummary"/>. </summary>
        /// <param name="status"> Status of detection results. </param>
        /// <param name="errors"> Error message when detection fails. </param>
        /// <param name="variableStates"> Variable status. </param>
        /// <param name="setupInfo">
        /// Detection request for batch inference. This is an asynchronous inference that
        /// will need another API to get detection results.
        /// </param>
        /// <returns> A new <see cref="AnomalyDetector.MultivariateBatchDetectionResultSummary"/> instance for mocking. </returns>
        public static MultivariateBatchDetectionResultSummary MultivariateBatchDetectionResultSummary(MultivariateBatchDetectionStatus status = default, IEnumerable<ErrorResponse> errors = null, IEnumerable<VariableState> variableStates = null, MultivariateBatchDetectionOptions setupInfo = null)
        {
            errors ??= new List<ErrorResponse>();
            variableStates ??= new List<VariableState>();

            return new MultivariateBatchDetectionResultSummary(status, errors?.ToList(), variableStates?.ToList(), setupInfo, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyDetector.AnomalyState"/>. </summary>
        /// <param name="timestamp"> Time stamp for this anomaly. </param>
        /// <param name="value"> Detailed value of this anomalous time stamp. </param>
        /// <param name="errors"> Error message for the current time stamp. </param>
        /// <returns> A new <see cref="AnomalyDetector.AnomalyState"/> instance for mocking. </returns>
        public static AnomalyState AnomalyState(DateTimeOffset timestamp = default, AnomalyValue value = null, IEnumerable<ErrorResponse> errors = null)
        {
            errors ??= new List<ErrorResponse>();

            return new AnomalyState(timestamp, value, errors?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyDetector.AnomalyValue"/>. </summary>
        /// <param name="isAnomaly"> True if an anomaly is detected at the current time stamp. </param>
        /// <param name="severity">
        /// Indicates the significance of the anomaly. The higher the severity, the more
        /// significant the anomaly is.
        /// </param>
        /// <param name="score"> Raw anomaly score of severity, to help indicate the degree of abnormality. </param>
        /// <param name="interpretation"> Interpretation of this anomalous time stamp. </param>
        /// <returns> A new <see cref="AnomalyDetector.AnomalyValue"/> instance for mocking. </returns>
        public static AnomalyValue AnomalyValue(bool isAnomaly = default, float severity = default, float score = default, IEnumerable<AnomalyInterpretation> interpretation = null)
        {
            interpretation ??= new List<AnomalyInterpretation>();

            return new AnomalyValue(isAnomaly, severity, score, interpretation?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyDetector.AnomalyInterpretation"/>. </summary>
        /// <param name="variable"> Variable. </param>
        /// <param name="contributionScore">
        /// This score shows the percentage that contributes to the anomalous time stamp. It's a
        /// number between 0 and 1.
        /// </param>
        /// <param name="correlationChanges"> Correlation changes among the anomalous variables. </param>
        /// <returns> A new <see cref="AnomalyDetector.AnomalyInterpretation"/> instance for mocking. </returns>
        public static AnomalyInterpretation AnomalyInterpretation(string variable = null, float? contributionScore = null, CorrelationChanges correlationChanges = null)
        {
            return new AnomalyInterpretation(variable, contributionScore, correlationChanges, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyDetector.CorrelationChanges"/>. </summary>
        /// <param name="changedVariables"> Correlated variables that have correlation changes under an anomaly. </param>
        /// <returns> A new <see cref="AnomalyDetector.CorrelationChanges"/> instance for mocking. </returns>
        public static CorrelationChanges CorrelationChanges(IEnumerable<string> changedVariables = null)
        {
            changedVariables ??= new List<string>();

            return new CorrelationChanges(changedVariables?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyDetector.ModelInfo"/>. </summary>
        /// <param name="dataSource">
        /// Source link to the input data to indicate an accessible Azure Storage URI.
        /// It either points to an Azure Blob Storage folder or points to a CSV file in
        /// Azure Blob Storage, based on your data schema selection.
        /// </param>
        /// <param name="dataSchema">
        /// Data schema of the input data source. The default
        /// is OneTable.
        /// </param>
        /// <param name="startTime">
        /// Start date/time of training data, which should be
        /// in ISO 8601 format.
        /// </param>
        /// <param name="endTime">
        /// End date/time of training data, which should be
        /// in ISO 8601 format.
        /// </param>
        /// <param name="displayName">
        /// Display name of the model. Maximum length is 24
        /// characters.
        /// </param>
        /// <param name="slidingWindow">
        /// Number of previous time stamps that will be used to
        /// detect whether the time stamp is an anomaly or not.
        /// </param>
        /// <param name="alignPolicy"> Manner of aligning multiple variables. </param>
        /// <param name="status"> Model status. </param>
        /// <param name="errors"> Error messages after failure to create a model. </param>
        /// <param name="diagnosticsInfo"> Diagnostics information to help inspect the states of a model or variable. </param>
        /// <returns> A new <see cref="AnomalyDetector.ModelInfo"/> instance for mocking. </returns>
        public static ModelInfo ModelInfo(Uri dataSource = null, DataSchema? dataSchema = null, DateTimeOffset startTime = default, DateTimeOffset endTime = default, string displayName = null, int? slidingWindow = null, AlignPolicy alignPolicy = null, ModelStatus? status = null, IEnumerable<ErrorResponse> errors = null, DiagnosticsInfo diagnosticsInfo = null)
        {
            errors ??= new List<ErrorResponse>();

            return new ModelInfo(
                dataSource,
                dataSchema,
                startTime,
                endTime,
                displayName,
                slidingWindow,
                alignPolicy,
                status,
                errors?.ToList(),
                diagnosticsInfo,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyDetector.AnomalyDetectionModel"/>. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="createdTime"> Date and time (UTC) when the model was created. </param>
        /// <param name="lastUpdatedTime"> Date and time (UTC) when the model was last updated. </param>
        /// <param name="modelInfo">
        /// Training result of a model, including its status, errors, and diagnostics
        /// information.
        /// </param>
        /// <returns> A new <see cref="AnomalyDetector.AnomalyDetectionModel"/> instance for mocking. </returns>
        public static AnomalyDetectionModel AnomalyDetectionModel(Guid modelId = default, DateTimeOffset createdTime = default, DateTimeOffset lastUpdatedTime = default, ModelInfo modelInfo = null)
        {
            return new AnomalyDetectionModel(modelId, createdTime, lastUpdatedTime, modelInfo, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyDetector.MultivariateLastDetectionResult"/>. </summary>
        /// <param name="variableStates"> Variable status. </param>
        /// <param name="results"> Anomaly status and information. </param>
        /// <returns> A new <see cref="AnomalyDetector.MultivariateLastDetectionResult"/> instance for mocking. </returns>
        public static MultivariateLastDetectionResult MultivariateLastDetectionResult(IEnumerable<VariableState> variableStates = null, IEnumerable<AnomalyState> results = null)
        {
            variableStates ??= new List<VariableState>();
            results ??= new List<AnomalyState>();

            return new MultivariateLastDetectionResult(variableStates?.ToList(), results?.ToList(), serializedAdditionalRawData: null);
        }
    }
}
