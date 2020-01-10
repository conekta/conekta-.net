using System;
using System.Runtime.Serialization;
using System.Net;

namespace Conekta.Exceptions
{
  /// <summary>
  /// Conekta http exception.
  /// </summary>
  public class ConektaHttpException : Exception
  {
    #region :: Properties ::

    /// <summary>
    /// Gets the http status code.
    /// </summary>
    /// <value>The http status code.</value>
    public HttpStatusCode HttpStatusCode { get; }

    #endregion

    #region :: Constructor ::

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Conekta.Exceptions.ConektaHttpException"/> class.
    /// </summary>
    public ConektaHttpException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Conekta.Exceptions.ConektaHttpException"/> class.
    /// </summary>
    /// <param name="message">Message.</param>
    public ConektaHttpException(string message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Conekta.Exceptions.ConektaHttpException"/> class.
    /// </summary>
    /// <param name="message">Message.</param>
    /// <param name="httpStatusCode">Http status code.</param>
    public ConektaHttpException(string message, HttpStatusCode httpStatusCode)
      : base(message) => HttpStatusCode = httpStatusCode;

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Conekta.Exceptions.ConektaHttpException"/> class.
    /// </summary>
    /// <param name="message">Message.</param>
    /// <param name="innerException">Inner exception.</param>
    public ConektaHttpException(string message, Exception innerException) : base(message, innerException)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Conekta.Exceptions.ConektaHttpException"/> class.
    /// </summary>
    /// <param name="info">Info.</param>
    /// <param name="context">Context.</param>
    protected ConektaHttpException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    #endregion
  }
}
