﻿//-----------------------------------------------------------------------
// <copyright company="TheNucleus">
// Copyright (c) TheNucleus. All rights reserved.
// Licensed under the Apache License, Version 2.0 license. See LICENCE.md file in the project root for full license information.
// </copyright>
//-----------------------------------------------------------------------
//// GENERATED_CODE_HEADER
namespace Nuclei.ExceptionHandling
{
    /// <summary>
    /// Defines the possible exit results for a guarded execution of a method.
    /// </summary>
    //// GENERATED_CODE_ATTRIBUTE
    internal enum GuardResult
    {
        /// <summary>
        /// There was no exit result. Not normally a valid value.
        /// </summary>
        None,

        /// <summary>
        /// The method executed successfully.
        /// </summary>
        Success,

        /// <summary>
        /// The method execution failed at some point with an unhandled exception.
        /// </summary>
        Failure,
    }
}
