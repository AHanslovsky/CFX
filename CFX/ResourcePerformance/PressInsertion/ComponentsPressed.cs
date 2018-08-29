/*
Copyright 2018 TE Connectivity

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
-------------------------------------------------------------------------
*/
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.ResourcePerformance.PressInsertion
{
    /// <summary>
    /// Sent periodically by a Press Fit machine to indicate the number of presses which were
    /// successfully or unsuccessfully completed during the sample time window.
    /// <code language="none">
    /// {
    ///   "StartTime": "2018-04-06T08:06:46.4471059-04:00",
    ///   "EndTime": "2018-04-06T08:16:46.4471059-04:00",
    ///   "TotalComponentsPressed": 10,
    ///   "TotalComponentsNotPressed": 2
    /// }
    /// </code>
    /// </summary>
    public class ComponentsPressed : CFXMessage
    {
        /// <summary>
        /// The start of the sample period
        /// </summary>
        public DateTime StartTime
        {
            get;
            set;
        }

        /// <summary>
        /// The end of the sample period
        /// </summary>
        public DateTime EndTime
        {
            get;
            set;
        }

        /// <summary>
        /// The total number of components that were successfully pressed during the sample period
        /// </summary>
        public int TotalComponentsPressed { get; set; }

        /// <summary>
        /// The total number of components that were not successfully pressed during the sample period
        /// </summary>
        public int TotalComponentsNotPressed { get; set; }
    }
}
