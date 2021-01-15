// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Iot.TimeSeriesInsights;

namespace Azure.Iot.TimeSeriesInsights.Models
{
    /// <summary> Response of Get Availability operation. When environment has no data, availability property is null. </summary>
    public partial class AvailabilityResponse
    {
        /// <summary> Initializes a new instance of AvailabilityResponse. </summary>
        internal AvailabilityResponse()
        {
        }

        /// <summary> Initializes a new instance of AvailabilityResponse. </summary>
        /// <param name="availability"> Event availability information when environment contains events. When environment has no data yet, this property is null or not present. </param>
        internal AvailabilityResponse(EventAvailability availability)
        {
            Availability = availability;
        }

        /// <summary> Event availability information when environment contains events. When environment has no data yet, this property is null or not present. </summary>
        public EventAvailability Availability { get; }
    }
}