namespace Hillel;

public struct Color
{
    private byte _red;
    private byte _green;
    private byte _blue;
    private byte _opacity;

    /// <summary>
    /// Gets or sets the red component of the color. The value should be between 0 and 255.
    /// </summary>
    public byte R
    {
        get => _red;

        set => _red = value;
    }

    /// <summary>
    /// Gets or sets the green component of the color. The value should be between 0 and 255.
    /// </summary>
    public byte G
    {
        get => _green;

        set => _green = value;
    }

    /// <summary>
    /// Gets or sets the blue component of the color. The value should be between 0 and 255.
    /// </summary>
    public byte B
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
    /// Initializes a new instance of the Color struct with default values (R=0, G=0, B=0, Opacity=0).
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
    /// <param name="r">Gets or sets the red component of the color. The value should be between 0 and 255.</param>
    /// <param name="g">Gets or sets the green component of the color. The value should be between 0 and 255.</param>
    /// <param name="b">Gets or sets the blue component of the color. The value should be between 0 and 255.</param>
    /// <param name="o"></param>
    public Color(byte r, byte g, byte b, byte o)
    {
        _red = r;
        _green = g;
        _blue = b;
        _opacity = o;
    }
}