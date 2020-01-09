namespace Conekta.Enumerations
{
  /// <summary>
  /// API Versions.
  /// </summary>
  public class APIVersion : Enumeration
  {
    #region :: Public Fields ::

    /// <summary>
    /// Version 1.0.0.
    /// </summary>
    public static APIVersion V1 = new APIVersion("1.0.0", "Version 1");

    /// <summary>
    /// Version 2.0.0.
    /// </summary>
    public static APIVersion V2 = new APIVersion("2.0.0", "Version 2");

    #endregion

    #region :: Constructors ::

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Conekta.Enumerations.APIVersion"/> class.
    /// </summary>
    /// <param name="value">Value.</param>
    /// <param name="displayName">Display name.</param>
    private APIVersion(string value, string displayName) : base(value, displayName) { }

    #endregion
  }
}
