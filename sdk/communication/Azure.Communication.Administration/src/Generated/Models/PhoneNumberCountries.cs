// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Administration.Models
{
    /// <summary> Represents a wrapper around a list of countries. </summary>
    internal partial class PhoneNumberCountries
    {
        /// <summary> Initializes a new instance of PhoneNumberCountries. </summary>
        internal PhoneNumberCountries()
        {
            Countries = new ChangeTrackingList<PhoneNumberCountry>();
        }

        /// <summary> Initializes a new instance of PhoneNumberCountries. </summary>
        /// <param name="countries"> Represents the underlying list of countries. </param>
        /// <param name="nextLink"> Represents the URL link to the next page. </param>
        internal PhoneNumberCountries(IReadOnlyList<PhoneNumberCountry> countries, string nextLink)
        {
            Countries = countries;
            NextLink = nextLink;
        }

        /// <summary> Represents the underlying list of countries. </summary>
        public IReadOnlyList<PhoneNumberCountry> Countries { get; }
        /// <summary> Represents the URL link to the next page. </summary>
        public string NextLink { get; }
    }
}