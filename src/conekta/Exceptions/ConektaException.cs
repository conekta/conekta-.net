using System;
using System.Runtime.Serialization;

namespace Conekta.Exceptions
{
  /// <summary>
  /// Conekta exception.
  /// </summary>
  public class ConektaException : Exception
  {
    #region :: Constructors ::

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Conekta.Exceptions.ConektaException"/> class.
    /// </summary>
    public ConektaException() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Conekta.Exceptions.ConektaException"/> class.
    /// </summary>
    /// <param name="message">Message.</param>
    public ConektaException(string message) : base(message) { }


    /// <summary>
    /// Initializes a new instance of the <see cref="T:Conekta.Exceptions.ConektaException"/> class.
    /// </summary>
    /// <param name="message">Message.</param>
    /// <param name="innerException">Inner exception.</param>
    public ConektaException(string message, Exception innerException) : base(message, innerException) { }

    protected ConektaException(SerializationInfo info, StreamingContext context) : base(info, context) { }

    #endregion
  }
}
