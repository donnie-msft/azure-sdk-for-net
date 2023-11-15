// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Removes words that are too long or too short. This token filter is implemented using Apache Lucene. </summary>
    public partial class LengthTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of LengthTokenFilter. </summary>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public LengthTokenFilter(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            ODataType = "#Microsoft.Azure.Search.LengthTokenFilter";
        }

        /// <summary> Initializes a new instance of LengthTokenFilter. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="minLength"> The minimum length in characters. Default is 0. Maximum is 300. Must be less than the value of max. </param>
        /// <param name="maxLength"> The maximum length in characters. Default and maximum is 300. </param>
        internal LengthTokenFilter(string oDataType, string name, int? minLength, int? maxLength) : base(oDataType, name)
        {
            MinLength = minLength;
            MaxLength = maxLength;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.LengthTokenFilter";
        }
    }
}
