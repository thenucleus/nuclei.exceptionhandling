//-----------------------------------------------------------------------
// <copyright company="TheNucleus">
// Copyright (c) TheNucleus. All rights reserved.
// Licensed under the Apache License, Version 2.0 license. See LICENCE.md file in the project root for full license information.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Globalization;

namespace Nuclei.ExceptionHandling.Samples
{
    public sealed class TestExceptionProcessor
    {
        /// <summary>
        /// Processes the given exception.
        /// </summary>
        /// <param name="exception">The exception to process.</param>
        public void Process(Exception exception)
        {
            string text = string.Empty;
            if (exception != null)
            {
                text = string.Format(
                    CultureInfo.InvariantCulture,
                    "Fatal exception occurred during application execution. Exception message was: {0}",
                    exception);
            }
            else
            {
                text = string.Format(
                    CultureInfo.InvariantCulture,
                    "Fatal exception occurred during application execution. No exception or stack trace provided.");
            }

            Console.WriteLine(text);
        }
    }
}
