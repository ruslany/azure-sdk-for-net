// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    internal partial class FileRange
    {
        internal static FileRange DeserializeFileRange(XElement element)
        {
            long start = default;
            long end = default;
            if (element.Element("Start") is XElement startElement)
            {
                start = (long)startElement;
            }
            if (element.Element("End") is XElement endElement)
            {
                end = (long)endElement;
            }
            return new FileRange(start, end);
        }
    }
}