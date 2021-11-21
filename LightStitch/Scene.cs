using System;
using System.Collections.Generic;
using System.Drawing;

using Hazdryx.Drawing;

namespace Hazdryx.LightStitch
{
    /// <summary>
    ///     A LightStitch scene used for manipulating dynamic lighting.
    /// </summary>
    public class Scene : IDisposable
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
                int color = FastColor.Sub(Off.GetI(i), image.GetI(i));
                color = FastColor.SetAlpha(color, 0xff);
                baked.SetI(i, color);
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
        ///     Removes a light source by name.
        /// </summary>
        /// <param name="name"></param>
        public void RemoveLightSource(string name)
        {
            if (LightSources.ContainsKey(name))
            {
                LightSource light = LightSources[name];
                light.Dispose();
                LightSources.Remove(name);
            }
        }

        /// <summary>
        ///     Creates a blank FastBitmap which can be used
        ///     as a render target for this Scene.
        /// </summary>
        /// <returns></returns>
        public FastBitmap CreateRenderTarget()
        {
            return new FastBitmap(Off.Width, Off.Height);
        }
        /// <summary>
        ///     Renders the scene to the target.
        /// </summary>
        /// <param name="target"></param>
        public void RenderTo(FastBitmap target)
        {
            // Validate
            if (target.Width != Off.Width || target.Height != Off.Height)
            {
                throw new ArgumentException("Invalid dimensions for render target");
            }

            // Render off to target
            Off.CopyTo(target);

            // Render light sources.
            foreach (KeyValuePair<string, LightSource> light in LightSources)
            {
                light.Value.RenderTo(target);
            }
        }

        /// <summary>
        ///     Disposes of all the light sources.
        /// </summary>
        public void Dispose()
        {
            foreach (KeyValuePair<string, LightSource> light in LightSources)
            {
                light.Value.Dispose();
            }
            LightSources.Clear();
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
