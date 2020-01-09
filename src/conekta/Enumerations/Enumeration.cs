using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Conekta.Enumerations
{
  /// <summary>
  /// Enumeration.
  /// </summary>
  public abstract class Enumeration : IComparable
  {
    #region :: Properties ::

    /// <summary>
    /// Gets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name { get; private set; }

    /// <summary>
    /// Gets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    public string Id { get; private set; }

    #endregion

    #region :: Constructor ::

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Conekta.Enumerations.Enumeration"/> class.
    /// </summary>
    /// <param name="id">Identifier.</param>
    /// <param name="name">Name.</param>
    protected Enumeration(string id, string name)
    {
      Id = id;
      Name = name;
    }

    #endregion

    #region :: Methods ::

    /// <summary>
    /// Compares to.
    /// </summary>
    /// <returns>The to.</returns>
    /// <param name="other">Other.</param>
    public int CompareTo(object other) =>
      string.Compare(Id, ((Enumeration)other).Id, StringComparison.CurrentCulture);

    #endregion

    #region :: Static Methods ::

    /// <summary>
    /// Gets all.
    /// </summary>
    /// <returns>The all.</returns>
    /// <typeparam name="T">The 1st type parameter.</typeparam>
    public static IEnumerable<T> GetAll<T>() where T : Enumeration
    {
      var fields = typeof(T).GetFields(BindingFlags.Public |
                                       BindingFlags.Static |
                                       BindingFlags.DeclaredOnly);

      return fields.Select(f => f.GetValue(null)).Cast<T>();
    }

    #endregion

    #region :: Overrides ::

    /// <summary>
    /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:Conekta.Enumerations.Enumeration"/>.
    /// </summary>
    /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:Conekta.Enumerations.Enumeration"/>.</returns>
    public override string ToString() => Name;

    /// <summary>
    /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="T:Conekta.Enumerations.Enumeration"/>.
    /// </summary>
    /// <param name="obj">The <see cref="object"/> to compare with the current <see cref="T:Conekta.Enumerations.Enumeration"/>.</param>
    /// <returns><c>true</c> if the specified <see cref="object"/> is equal to the current
    /// <see cref="T:Conekta.Enumerations.Enumeration"/>; otherwise, <c>false</c>.</returns>
    public override bool Equals(object obj)
    {
      if (!(obj is Enumeration otherValue))
      {
        return false;
      }

      var typeMatches = GetType().Equals(obj.GetType());
      var valueMatches = Id.Equals(otherValue.Id);

      return typeMatches && valueMatches;
    }

    /// <summary>
    /// Serves as a hash function for a <see cref="T:Conekta.Enumerations.Enumeration"/> object.
    /// </summary>
    /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a hash table.</returns>
    public override int GetHashCode() => HashCode.Combine(Name, Id);

    #endregion
  }
}
