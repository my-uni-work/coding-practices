﻿using System;
using System.IO;

namespace Ini.EventLoggers
{
	/// <summary>
    /// An implementation of <see cref="IConfigValidatorEventLogger"/> that writes a text writer.
	/// </summary>
    public class ConfigValidatorEventLogger : IConfigValidatorEventLogger
	{
        /// <summary>
        /// The output stream to write event logs to.
        /// </summary>
        protected TextWriter writer;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigValidatorEventLogger"/> class.
        /// </summary>
        /// <param name="writer">The output stream to write event logs to.</param>
        public ConfigValidatorEventLogger(TextWriter writer)
        {
            this.writer = writer;
        }

        #region IConfigValidationBase implementation

        /// <summary>
        /// Configuration can not be validated without a specification.
        /// </summary>
        public virtual void NoSpecification()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Configuration can not be validated without a valid specification.
        /// </summary>
        public virtual void SpecificationNotValid()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IConfigValidatorEventLogger implementation

        /// <summary>
        /// Specification for the given section was not found when validating configuration.
        /// </summary>
        /// <param name="identifier">The section's identifier.</param>
        public virtual void NoSectionSpecification(string identifier)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Specification for the given option was not found when validating configuration.
        /// </summary>
        /// <param name="identifier">The option's identifier.</param>
        public virtual void NoOptionSpecification(string identifier)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The given option's value type does not conform to the specification.
        /// </summary>
        /// <param name="sectionIdentifier">The containing section's identifier.</param>
        /// <param name="optionIdentifier">The involved option's identifier.</param>
        /// <param name="specificationType">The option's value type from specification.</param>
        /// <param name="optionType">The option's value type.</param>
        public virtual void ValueTypeMismatch(string sectionIdentifier, string optionIdentifier, Type specificationType, Type optionType)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The given option is mandatory but it doesn't contain a value.
        /// </summary>
        /// <param name="sectionIdentifier">The containing section's identifier.</param>
        /// <param name="optionIdentifier">The involved option's identifier.</param>
        public virtual void NoValue(string sectionIdentifier, string optionIdentifier)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The given option is declared as single-value but it contains multiple values.
        /// </summary>
        /// <param name="sectionIdentifier">The containing section's identifier.</param>
        /// <param name="optionIdentifier">The involved option's identifier.</param>
        public virtual void TooManyValues(string sectionIdentifier, string optionIdentifier)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The given option contains a link that references a removed option (target).
        /// </summary>
        /// <param name="sectionIdentifier">The containing section's identifier.</param>
        /// <param name="optionIdentifier">The involved option's identifier.</param>
        /// <param name="link">The affected link.</param>
        public virtual void LinkInconsistent(string sectionIdentifier, string optionIdentifier, Ini.Configuration.Base.ILink link)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The given option contains a value that is not allowed.
        /// </summary>
        /// <param name="sectionIdentifier">The containing section's identifier.</param>
        /// <param name="optionIdentifier">The involved option's identifier.</param>
        /// <param name="value">The affected value.</param>
        public virtual void ValueNotAllowed(string sectionIdentifier, string optionIdentifier, Ini.Configuration.Base.IValue value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The given option contains a value that is out of range.
        /// </summary>
        /// <param name="sectionIdentifier">The containing section's identifier.</param>
        /// <param name="optionIdentifier">The involved option's identifier.</param>
        /// <param name="value">The affected value.</param>
        public virtual void ValueOutOfRange(string sectionIdentifier, string optionIdentifier, Ini.Configuration.Base.IValue value)
        {
            throw new NotImplementedException();
        }

        #endregion
	}
}
