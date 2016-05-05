﻿using System;
using System.Collections.Generic;
using Ini.EventLoggers;
using Ini.Specification;
using Ini.Util;
using Ini.Validation;
using Ini.Configuration.Base;

namespace Ini.Configuration.Values
{
    /// <summary>
    /// Element of type <see cref="long"/>.
    /// </summary>
    public class LongValue : ValueBase<long>
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="LongValue"/> class
        /// with an initial value.
        /// </summary>
        public LongValue(long value) : base(value)
        {
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Creates an instance of self from the given string value.
        /// </summary>
        /// <returns>The new instance.</returns>
        /// <param name="value">The string.</param>
        /// <typeparam name="LongValue">The type of self.</typeparam>
        public override LongValue FromString<LongValue>(string value)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Validation

        /// <summary>
        /// Determines whether the element conforms to the given option specification.
        /// </summary>
        /// <param name="optionSpec">The option specification.</param>
        /// <param name="mode">The validation mode.</param>
        /// <param name="eventLog">The validation event log.</param>
        /// <returns></returns>
        public override bool IsValid(OptionSpec optionSpec, ConfigValidationMode mode, IConfigValidatorEventLogger eventLog = null)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}