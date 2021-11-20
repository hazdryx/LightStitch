using System;
using System.Collections.Generic;
using System.Drawing;

using Hazdryx.Drawing;

namespace Hazdryx.LightStitch
{
    /// <summary>
    ///     A LightStitch scene used for manipulating dynamic lighting.
    /// </summary>
    public class Scene
    {
        /// <summary>
        ///     Gets the Off image used.
        /// </summary>
        public FastBitmap Off { get; }
        /// <summary>
        ///     Gets the baked light sources.
        /// </summary>
        private Dictionary<string, LightSource> LightSources { get; } = new Dictionary<string, LightSource>();

        private Scene(FastBitmap off)
        {
            Off = off;
        }

        /// <summary>
        ///     Adds a light source to the 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="image"></param>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public LightSource AddLightSource(string name, FastBitmap image)
        {
            // Check for errors.
            if (LightSources.ContainsKey(name))
            {
                throw new InvalidOperationException("Duplicate light source names.");
            }
            if (image.Width != Off.Width || image.Height != Off.Height)
            {
                throw new ArgumentException("Invalid light source dimensions.");
            }

            // Bake the light source.
            FastBitmap baked = new FastBitmap(image.Width, image.Height);
            for (int i = 0; i < baked.Length; i++)
            {
                int c1 = Off.GetI(i);
                int c2 = image.GetI(i);

                int r = ((c2 >> 16) & 0xff) - ((c1 >> 16) & 0xff);
                int g = ((c2 >> 8) & 0xff) - ((c1 >> 8) & 0xff);
                int b = (c2 & 0xff) - (c1 & 0xff);

                baked.SetI(i, (0xff << 24) | (r << 16) | (g << 8) | b);
            }

            // Add light source.
            LightSource light = new LightSource(baked);
            LightSources.Add(name, light);
            return light;
        }
        /// <summary>
        ///     Gets a light source by name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public LightSource GetLightSource(string name)
        {
            return LightSources[name];
        }

        /// <summary>
        ///     Creates a new Scene from a FastBitmap.
        /// </summary>
        /// <param name="off"></param>
        /// <returns></returns>
        public static Scene FromImage(FastBitmap off)
        {
            return new Scene((FastBitmap) off.Clone());
        }
        /// <summary>
        ///     Creates a new Scene from an Image.
        /// </summary>
        /// <param name="off"></param>
        /// <returns></returns>
        public static Scene FromImage(Image off)
        {
            return new Scene(new FastBitmap(off));
        }
    }
}
