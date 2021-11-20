using System;
using System.Drawing;

using Hazdryx.Drawing;
using Hazdryx.LightStitch.Utils;

namespace Hazdryx.LightStitch
{
    /// <summary>
    ///     A basic light source which contains an image and a color.
    /// </summary>
    public class LightSource : IDisposable
    {
        /// <summary>
        ///     Gets or sets whether this light source is on.
        /// </summary>
        public bool On { get; set; } = true;
        /// <summary>
        ///     Gets or sets the color multiplier.
        /// </summary>
        public Color Color { get; set; } = Color.White;
        public FastBitmap Baked { get; }

        internal LightSource(FastBitmap baked)
        {
            Baked = baked;
        }

        /// <summary>
        ///     Renders this light source to the target.
        /// </summary>
        /// <param name="target"></param>
        public virtual void RenderTo(FastBitmap target)
        {
            if (target.Width != Baked.Width || target.Height != Baked.Height)
            {
                throw new ArgumentException("Invalid dimensions for render target");
            }

            if (!On) return;
            for (int i = 0; i < target.Length; i++)
            {
                target.SetI(i, ColorUtil.Add(target.GetI(i), Baked.GetI(i)));
            }
        }

        /// <summary>
        ///     Disposes of the baked image and any other
        ///     resources.
        /// </summary>
        public void Dispose()
        {
            Baked.Dispose();
        }
    }
}
