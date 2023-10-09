namespace Hillel;

public struct Color
{
    private byte _r;
    private byte _g;
    private byte _b;
    private byte _opacity;

    /// <summary>
    /// Gets or sets the red component of the color. The value should be between 0 and 255.
    /// </summary>
    public byte R
    {
        get => _r;

        set
        {
            if (value < 0 || value > 255)
            {
                return;
                // throw new Exception("no valid value for Color. Use only values between 0 a 255");
            }

            _r = value;
        }
    }
/// <summary>
/// Gets or sets the green component of the color. The value should be between 0 and 255.
/// </summary>
    public byte G
    {
        get => _g;

        set
        {
            if (value < 0 || value > 255)
            {
                return;
                // throw new Exception("no valid value for Color. Use only values between 0 a 255");
            }

            _g = value;
        }
    }
/// <summary>
/// Gets or sets the blue component of the color. The value should be between 0 and 255.
/// </summary>
    public byte B
    {
        get => _b;

        set
        {
            if (value < 0 || value > 255)
            {
                return;
                // throw new Exception("no valid value for Color. Use only values between 0 a 255");
            }

            _b = value;
        }
    }
/// <summary>
/// Gets or sets the opacity of the color. The value should be between 0 and 255.
/// </summary>
    public byte opacity
    {
        get => opacity;

        set
        {
            if (value < 0 || value > 255)
            {
                return;
                //throw new Exception("no valid value for Color. Use only values between 0 a 255");
            }

            opacity = value;
        }
    }
/// <summary>
/// Initializes a new instance of the Color struct with default values (R=0, G=0, B=0, Opacity=0).
/// </summary>
    public Color()
    {
        _r = 0;
        _g = 0;
        _b = 0;
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
        _r = r;
        _g = g;
        _b = b;
        _opacity = o;
    }
}