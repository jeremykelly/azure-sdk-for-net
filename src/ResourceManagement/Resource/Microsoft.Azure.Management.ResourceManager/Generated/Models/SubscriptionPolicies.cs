// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Subscription policies.
    /// </summary>
    public partial class SubscriptionPolicies
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionPolicies class.
        /// </summary>
        public SubscriptionPolicies() { }

        /// <summary>
        /// Initializes a new instance of the SubscriptionPolicies class.
        /// </summary>
        /// <param name="locationPlacementId">The subscription location placement Id.</param>
        /// <param name="quotaId">The subscription quota Id.</param>
        /// <param name="spendingLimit">The subscription spending limit. Possible values include: 'On', 'Off', 'CurrentPeriodOff'</param>
        public SubscriptionPolicies(string locationPlacementId = default(string), string quotaId = default(string), string spendingLimit = default(string))
        {
            LocationPlacementId = locationPlacementId;
            QuotaId = quotaId;
            SpendingLimit = spendingLimit;
        }

        /// <summary>
        /// Gets or sets the subscription location placement Id.
        /// </summary>
        [JsonProperty(PropertyName = "locationPlacementId")]
        public string LocationPlacementId { get; set; }

        /// <summary>
        /// Gets or sets the subscription quota Id.
        /// </summary>
        [JsonProperty(PropertyName = "quotaId")]
        public string QuotaId { get; set; }

        /// <summary>
        /// Gets or sets the subscription spending limit. Possible values
        /// include: 'On', 'Off', 'CurrentPeriodOff'
        /// </summary>
        [JsonProperty(PropertyName = "spendingLimit")]
        public string SpendingLimit { get; set; }

    }
}
