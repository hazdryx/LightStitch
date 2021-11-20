namespace Hazdryx.LightStitch.Utils
{
    internal static class ColorUtil
    {
        /// <summary>
        ///     Explodes a color into it's rgb components.
        /// </summary>
        /// <param name="color"></param>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        public static void Explode(int color, out int r, out int g, out int b)
        {
            r = (color >> 16) & 0xff; g = (color >> 8) & 0xff; b = color & 0xff;
        }
        /// <summary>
        ///     Impodes rgb into an argb32 color.
        /// </summary>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Implode(int r, int g, int b)
        {
            return 0xFF << 24 | (r << 16) | (g << 8) | b;
        }

        /// <summary>
        ///     Adds to colors together.
        /// </summary>
        /// <param name="color1"></param>
        /// <param name="color2"></param>
        /// <returns></returns>
        public static int Add(int color1, int color2)
        {
            Explode(color1, out int r1, out int g1, out int b1);
            Explode(color2, out int r2, out int g2, out int b2);

            int r = r2 + r1;
            int g = g2 + g1;
            int b = b2 + b1;

            return Implode(r > 255 ? 255 : r, g > 255 ? 255 : g, b > 255 ? 255 : b);
        }
        /// <summary>
        ///     Subtract two colors from eachother (color2 - color1)
        /// </summary>
        /// <param name="color1"></param>
        /// <param name="color2"></param>
        /// <returns></returns>
        public static int Sub(int color1, int color2)
        {
            Explode(color1, out int r1, out int g1, out int b1);
            Explode(color2, out int r2, out int g2, out int b2);

            int r = r2 - r1;
            int g = g2 - g1;
            int b = b2 - b1;

            return Implode(r < 0 ? 0 : r, g < 0 ? 0 : g, b < 0 ? 0 : b);
        }
        /// <summary>
        ///     Multiplies two colors together.
        /// </summary>
        /// <param name="color1"></param>
        /// <param name="color2"></param>
        /// <returns></returns>
        public static int Mul(int color1, int color2)
        {
            Explode(color1, out int r1, out int g1, out int b1);
            Explode(color2, out int r2, out int g2, out int b2);

            int r = r2 * r1 / 255;
            int g = g2 * g1 / 255;
            int b = b2 * b1 / 255;

            return Implode(r, g, b);
        }
    }
}
