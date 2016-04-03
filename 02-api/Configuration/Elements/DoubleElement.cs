﻿using System;
using System.Collections.Generic;
using Ini.Backlogs;
using Ini.Schema;
using Ini.Util;

namespace Ini.Configuration.Elements
{
    /// <summary>
	/// Element of type <see cref="double"/>.
    /// </summary>
    public class DoubleElement : Element<double>
    {
		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="Ini.Configuration.Elements.DoubleElement"/> class.
		/// </summary>
		public DoubleElement(double value) : base(value)
		{
		}

		#endregion

		#region Validation

        /// <summary>
		/// Determines whether the element conforms to the given option specification.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="definition"></param>
        /// <param name="backlog"></param>
        /// <returns></returns>
        public override bool IsValid(ValidationMode mode, OptionSpec definition, IValidationBacklog backlog = null)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}