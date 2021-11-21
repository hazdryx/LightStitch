using System;
using Hazdryx.Drawing;

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
        ///     Gets or sets the color multiplier in rgb24.
        /// </summary>
        public int Color { get; set; } = 0xFFFFFF;
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
                int color = FastColor.Add(target.GetI(i), FastColor.Mul(Baked.GetI(i), Color));
                color = FastColor.SetAlpha(color, 0xff);
                target.SetI(i, color);
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
