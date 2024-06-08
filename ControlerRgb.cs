using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RGBController
{
    public static void rgbInit(RGB rgb, int r, int g, int b)
    {
        rgb.R = r;
        rgb.G = g;
        rgb.B = b;
    }
    public static void rgbDisplay(RGB rgb)
    {
        Console.WriteLine($"({rgb.R},{rgb.G},{rgb.B})");
    }
    public static RGB colorMix(RGB rgb1, RGB rgb2)
    {
        int r = (rgb1.R + rgb2.R) / 2;
        int g = (rgb1.G + rgb2.G) / 2;
        int b = (rgb1.B + rgb2.B) / 2;

        return new RGB(r, g, b);
    }
}