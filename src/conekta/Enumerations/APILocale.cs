namespace Conekta.Enumerations
{
  /// <summary>
  /// API Locales.
  /// </summary>
  public class APILocale : Enumeration
  {
    #region :: Public Fields ::

    /// <summary>
    /// Spanish language.
    /// </summary>
    public static APILocale Spanish = new APILocale("es", "Spanish");

    /// <summary>
    /// English language.
    /// </summary>
    public static APILocale English = new APILocale("en", "English");

    #endregion

    #region :: Constructors ::

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Conekta.Enumerations.APILocale"/> class.
    /// </summary>
    /// <param name="value">Value.</param>
    /// <param name="displayName">Display name.</param>
    private APILocale(string value, string displayName) : base(value, displayName) { }

    #endregion
  }
}
