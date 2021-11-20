using System;
using System.Collections.Generic;

using Hazdryx.Drawing;

namespace Hazdryx.LightStitch
{
    /// <summary>
    ///     A context in which to build a LightStitch environment.
    /// </summary>
    public class LightStitchContext
    {
        /// <summary>
        ///     Gets the off state image.
        /// </summary>
        public FastBitmap OffState;

        public LightStitchContext(FastBitmap offState)
        {
            if (offState == null)
            {
                throw new ArgumentNullException(nameof(offState));
            }
            this.OffState = offState;
        }
    }
}
