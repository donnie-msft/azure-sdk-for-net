// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> An object containing more specific information about the error. As per Microsoft One API guidelines - https://github.com/Microsoft/api-guidelines/blob/vNext/Guidelines.md#7102-error-condition-responses. </summary>
    internal partial class InnerErrorModel
    {
        /// <summary> Initializes a new instance of <see cref="InnerErrorModel"/>. </summary>
        /// <param name="code"> One of a server-defined set of error codes. </param>
        /// <param name="message"> Error message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        public InnerErrorModel(InnerErrorCode code, string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            Code = code;
            Message = message;
            Details = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="InnerErrorModel"/>. </summary>
        /// <param name="code"> One of a server-defined set of error codes. </param>
        /// <param name="message"> Error message. </param>
        /// <param name="details"> Error details. </param>
        /// <param name="target"> Error target. </param>
        /// <param name="innererror"> An object containing more specific information than the current object about the error. </param>
        internal InnerErrorModel(InnerErrorCode code, string message, IDictionary<string, string> details, string target, InnerErrorModel innererror)
        {
            Code = code;
            Message = message;
            Details = details;
            Target = target;
            Innererror = innererror;
        }

        /// <summary> One of a server-defined set of error codes. </summary>
        public InnerErrorCode Code { get; set; }
        /// <summary> Error message. </summary>
        public string Message { get; set; }
        /// <summary> Error details. </summary>
        public IDictionary<string, string> Details { get; }
        /// <summary> Error target. </summary>
        public string Target { get; set; }
        /// <summary> An object containing more specific information than the current object about the error. </summary>
        public InnerErrorModel Innererror { get; set; }
    }
}
