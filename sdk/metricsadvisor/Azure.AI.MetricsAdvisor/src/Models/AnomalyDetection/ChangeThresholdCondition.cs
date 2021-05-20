﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary>
    /// A condition used for anomaly detection. Using the value of a previously ingested data
    /// point as reference, sets bounds to specify the range in which data points are expected
    /// to be. Points with unexpected values will be considered an anomaly according to the
    /// rules set by the <see cref="SuppressCondition"/>.
    /// </summary>
    public partial class ChangeThresholdCondition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeThresholdCondition"/> class.
        /// </summary>
        public ChangeThresholdCondition()
        {
        }

        /// <summary>
        /// When set to N, sets as reference the data point that's N positions before the current
        /// point. Value must be at least 1.
        /// </summary>
        public int ShiftPoint { get; set; }

        /// <summary>
        /// Compared to the previous point, the current point is an anomaly if the percentage of change is more than this value.
        /// </summary>
        public double ChangePercentage { get; set; }

        /// <summary>
        /// Sets whether to detect data within the range or outside the range. If you want to detect fluctuations, select false.
        /// If you want to detect flat lines in your data, select true.
        /// </summary>
        [CodeGenMember("WithinRange")]
        public bool IsWithinRange { get; set; }

        /// <summary>
        /// A point is considered an anomaly only when the deviation occurs in the specified direction.
        /// </summary>
        public AnomalyDetectorDirection AnomalyDetectorDirection { get; set; }

        /// <summary>
        /// The <see cref="Models.SuppressCondition"/> to be applied to every unexpected data point.
        /// </summary>
        public SuppressCondition SuppressCondition { get; set; }

        internal ChangeThresholdConditionPatch GetPatchModel() => new ChangeThresholdConditionPatch()
        {
            ShiftPoint = ShiftPoint,
            ChangePercentage = ChangePercentage,
            WithinRange = IsWithinRange,
            AnomalyDetectorDirection = AnomalyDetectorDirection,
            SuppressCondition = SuppressCondition.GetPatchModel()
        };
    }
}
