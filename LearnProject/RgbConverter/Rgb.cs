namespace LearnProject.RgbConverter
{
    public static class Rgb
    {
        public static string GetHexRepresentation(int red, int green, int blue)
        {
            string hex;

            if (red < 0)
            {
                red = 0;
                hex = string.Format("{0:X2}{1:X2}{2:X2}", red, green, blue);
            }
            else if (green < 0)
            {
                green = 0;
                hex = string.Format("{0:X2}{1:X2}{2:X2}", red, green, blue);
            }
            else if (blue < 0)
            {
                blue = 0;
                hex = string.Format("{0:X2}{1:X2}{2:X2}", red, green, blue);
            }
            else if (red > 255)
            {
                red = 255;
                hex = string.Format("{0:X2}{1:X2}{2:X2}", red, green, blue);
            }
            else if (green > 255)
            {
                green = 255;
                hex = string.Format("{0:X2}{1:X2}{2:X2}", red, green, blue);
            }
            else if (blue > 255)
            {
                blue = 255;
                hex = string.Format("{0:X2}{1:X2}{2:X2}", red, green, blue);
            }
            else
            {
                hex = string.Format("{0:X2}{1:X2}{2:X2}", red, green, blue);
            }

            return hex;
        }
    }
}
