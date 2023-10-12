namespace Hillel;

/// <summary>
/// Represents a color with red, green, blue, and opacity components.
/// </summary>
public struct Color
{
    private byte _red;
    private byte _green;
    private byte _blue;
    private byte _opacity;

    /// <summary>
    /// Gets or sets the red component of the color. The value should be between 0 and 255.
    /// </summary>
    public byte Red
    {
        get => _red;

        set => _red = value;
    }

    /// <summary>
    /// Gets or sets the green component of the color. The value should be between 0 and 255.
    /// </summary>
    public byte Green
    {
        get => _green;

        set => _green = value;
    }

    /// <summary>
    /// Gets or sets the blue component of the color. The value should be between 0 and 255.
    /// </summary>
    public byte Blue
    {
        get => _blue;

        set => _blue = value;
    }

    /// <summary>
    /// Gets or sets the opacity of the color. The value should be between 0 and 255.
    /// </summary>
    public byte Opacity
    {
        get => _opacity;

        set => _opacity = value;
    }

    /// <summary>
    /// Initializes a new instance of the Color struct with default values (Red=0, Green=0, Blue=0, Opacity=0).
    /// </summary>
    public Color()
    {
        _red = 0;
        _green = 0;
        _blue = 0;
        _opacity = 0;
    }

    /// <summary>
    /// Initializes a new instance of the Color struct with specified values for R, G, B, and Opacity.
    /// </summary>
    /// <param name="red">Gets or sets the red component of the color. The value should be between 0 and 255.</param>
    /// <param name="green">Gets or sets the green component of the color. The value should be between 0 and 255.</param>
    /// <param name="blue">Gets or sets the blue component of the color. The value should be between 0 and 255.</param>
    /// <param name="opacity">Gets or sets the opacity component of the color. The value should be between 0 and 100.</param>
    public Color(byte red, byte green, byte blue, byte opacity)
    {
        _red = red;
        _green = green;
        _blue = blue;
        _opacity = opacity;
    }

    /// <summary>
    /// Initializes a new instance of the Color struct with a specified opacity value and default red, green, and blue components.
    /// </summary>
    /// <param name="opacity">The opacity component of the color. The value should be between 0 and 255.</param>
    public Color(byte opacity):this()
    {
        _opacity = opacity;
    }
}