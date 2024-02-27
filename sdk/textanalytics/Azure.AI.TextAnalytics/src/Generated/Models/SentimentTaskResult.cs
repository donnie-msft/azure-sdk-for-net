// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The SentimentTaskResult. </summary>
    internal partial class SentimentTaskResult : AnalyzeTextTaskResult
    {
        /// <summary> Initializes a new instance of <see cref="SentimentTaskResult"/>. </summary>
        /// <param name="results"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="results"/> is null. </exception>
        internal SentimentTaskResult(SentimentResponse results)
        {
            if (results == null)
            {
                throw new ArgumentNullException(nameof(results));
            }

            Results = results;
            Kind = AnalyzeTextTaskResultsKind.SentimentAnalysisResults;
        }

        /// <summary> Initializes a new instance of <see cref="SentimentTaskResult"/>. </summary>
        /// <param name="kind"> Enumeration of supported Text Analysis task results. </param>
        /// <param name="results"></param>
        internal SentimentTaskResult(AnalyzeTextTaskResultsKind kind, SentimentResponse results) : base(kind)
        {
            Results = results;
            Kind = kind;
        }

        /// <summary> Gets the results. </summary>
        public SentimentResponse Results { get; }
    }
}
