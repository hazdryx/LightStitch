using System.Drawing;

using Hazdryx.Drawing;

namespace Hazdryx.LightStitch
{
    /// <summary>
    ///     A basic light source which contains an image and a color.
    /// </summary>
    public class LightSource
    {
        /// <summary>
        ///     Gets or sets the color multiplier.
        /// </summary>
        public Color Color { get; set; } = Color.White;
        public FastBitmap Baked { get; }

        internal LightSource(FastBitmap baked)
        {
            Baked = baked;
        }
    }
}
