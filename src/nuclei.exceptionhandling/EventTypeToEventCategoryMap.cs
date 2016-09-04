﻿//-----------------------------------------------------------------------
// <copyright company="TheNucleus">
// Copyright (c) TheNucleus. All rights reserved.
// Licensed under the Apache License, Version 2.0 license. See LICENCE.md file in the project root for full license information.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Nuclei.ExceptionHandling
{
    /// <summary>
    /// Defines methods that map an <see cref="EventType"/> to an ID number for error reporting
    /// purposes.
    /// </summary>
    internal static class EventTypeToEventCategoryMap
    {
        /// <summary>
        /// The table that maps an event type to an event category.
        /// </summary>
        private static readonly Dictionary<EventType, short> _eventTypeToEventCategoryMap =
            new Dictionary<EventType, short>
                {
                    { EventType.Exception, 0 }
                };

        /// <summary>
        /// Returns the event category for the given <see cref="EventType"/> value.
        /// </summary>
        /// <param name="type">The type of the event.</param>
        /// <returns>The requested category ID.</returns>
        [SuppressMessage(
            "Microsoft.Performance",
            "CA1811:AvoidUncalledPrivateCode",
            Justification = "This class is embedded in an user assembly and called from there. Hence all methods are internal.")]
        public static short EventCategory(EventType type)
        {
            return _eventTypeToEventCategoryMap[type];
        }
    }
}
