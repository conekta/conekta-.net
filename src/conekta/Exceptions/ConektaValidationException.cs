using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Conekta.Exceptions
{
  /// <summary>
  /// Conekta validation exception.
  /// </summary>
  public class ConektaValidationException : Exception
  {
    #region :: Properties ::

    /// <summary>
    /// Gets the validation erros.
    /// </summary>
    /// <value>The validation erros.</value>
    public List<string> ValidationErros { get; }

    #endregion

    #region :: Constructors ::

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Conekta.Exceptions.ConektaValidationException"/> class.
    /// </summary>
    public ConektaValidationException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Conekta.Exceptions.ConektaValidationException"/> class.
    /// </summary>
    /// <param name="message">Message.</param>
    /// <param name="validationErros">Validation erros.</param>
    public ConektaValidationException(string message, List<string> validationErros) : base(message) =>
      ValidationErros = validationErros;

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Conekta.Exceptions.ConektaValidationException"/> class.
    /// </summary>
    /// <param name="message">Message.</param>
    public ConektaValidationException(string message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Conekta.Exceptions.ConektaValidationException"/> class.
    /// </summary>
    /// <param name="message">Message.</param>
    /// <param name="innerException">Inner exception.</param>
    public ConektaValidationException(string message, Exception innerException) : base(message, innerException)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Conekta.Exceptions.ConektaValidationException"/> class.
    /// </summary>
    /// <param name="info">Info.</param>
    /// <param name="context">Context.</param>
    protected ConektaValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    #endregion
  }
}
