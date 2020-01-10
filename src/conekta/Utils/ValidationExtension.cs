using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Conekta.Exceptions;

namespace Conekta.Utils
{
  /// <summary>
  /// Validation extension.
  /// </summary>
  internal static class ValidationExtension
  {
    #region :: Static Methods ::

    /// <summary>
    /// Validates the class.
    /// </summary>
    /// <returns>The class.</returns>
    /// <param name="value">Value.</param>
    /// <typeparam name="T">The 1st type parameter.</typeparam>
    public static T Validate<T>(this T value) where T : class
    {
      var result = InternalValidate(value);

      if (result.Count > 0)
      {
        throw new ConektaValidationException($"Validation erros at {value.GetType().Name}", result);
      }

      return value;
    }

    #endregion

    #region :: Private Static Methods ::

    /// <summary>
    /// Internals validation.
    /// </summary>
    /// <returns>List with validation errors</returns>
    /// <param name="objectToValidate">Object to validate.</param>
    private static List<string> InternalValidate(object objectToValidate)
    {
      var errors = new List<string>();

      var context = new ValidationContext(objectToValidate, serviceProvider: null, items: null);
      var results = new List<ValidationResult>();

      var isValid = Validator.TryValidateObject(objectToValidate, context, results);

      if (!isValid)
      {
        foreach (var validationResult in results)
        {
          errors.Add(validationResult.ErrorMessage);
        }
      }

      return errors;
    }

    #endregion
  }
}
