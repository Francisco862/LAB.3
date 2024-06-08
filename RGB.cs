using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RGB
{
    private int R_value;
    private int G_value;
    private int B_value;

    public RGB(int r_value, int g_value, int b_value)
    {
        R_value = r_value;
        G_value = g_value;
        B_value = b_value;
    }
    public int R
    {
        get { return R_value; }
        set { R_value = value; }
    }
    public int G
    {
        get { return G_value; }
        set { G_value = value; }
    }
    public int B
    {
        get { return B_value; }
        set { B_value = value; }
    }
}
