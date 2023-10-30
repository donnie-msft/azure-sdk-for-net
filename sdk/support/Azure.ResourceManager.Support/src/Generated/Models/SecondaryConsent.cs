// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> This property indicates secondary consent for the support ticket. </summary>
    public partial class SecondaryConsent
    {
        /// <summary> Initializes a new instance of SecondaryConsent. </summary>
        public SecondaryConsent()
        {
        }

        /// <summary> Initializes a new instance of SecondaryConsent. </summary>
        /// <param name="userConsent"> User consent value provided. </param>
        /// <param name="secondaryConsentType"> The service name for which the secondary consent is being provided. The value needs to be retrieved from the Problem Classification API response. </param>
        internal SecondaryConsent(UserConsent? userConsent, string secondaryConsentType)
        {
            UserConsent = userConsent;
            SecondaryConsentType = secondaryConsentType;
        }

        /// <summary> User consent value provided. </summary>
        public UserConsent? UserConsent { get; set; }
        /// <summary> The service name for which the secondary consent is being provided. The value needs to be retrieved from the Problem Classification API response. </summary>
        public string SecondaryConsentType { get; set; }
    }
}
