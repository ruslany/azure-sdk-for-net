// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics
{
    /// <summary> The HealthcareRelation. </summary>
    internal partial class HealthcareRelationInternal
    {
        /// <summary> Initializes a new instance of HealthcareRelationInternal. </summary>
        /// <param name="relationType"> Type of relation. Examples include: `DosageOfMedication` or &apos;FrequencyOfMedication&apos;, etc. </param>
        /// <param name="bidirectional"> If true the relation between the entities is bidirectional, otherwise directionality is source to target. </param>
        /// <param name="source"> Reference link to the source entity. </param>
        /// <param name="target"> Reference link to the target entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relationType"/>, <paramref name="source"/>, or <paramref name="target"/> is null. </exception>
        internal HealthcareRelationInternal(string relationType, bool bidirectional, string source, string target)
        {
            if (relationType == null)
            {
                throw new ArgumentNullException(nameof(relationType));
            }
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }

            RelationType = relationType;
            Bidirectional = bidirectional;
            Source = source;
            Target = target;
        }

        /// <summary> Type of relation. Examples include: `DosageOfMedication` or &apos;FrequencyOfMedication&apos;, etc. </summary>
        public string RelationType { get; }
        /// <summary> If true the relation between the entities is bidirectional, otherwise directionality is source to target. </summary>
        public bool Bidirectional { get; }
        /// <summary> Reference link to the source entity. </summary>
        public string Source { get; }
        /// <summary> Reference link to the target entity. </summary>
        public string Target { get; }
    }
}