using Hazdryx.Drawing;

namespace Hazdryx.LightStitch.WinForm
{
    public partial class Main : Form
    {
        public Scene Scene { get; }

        public Main()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            Scene = Scene.FromImage(FastBitmap.FromFile("./examples/off.png"));
            LightSource left = Scene.AddLightSource("left", FastBitmap.FromFile("./examples/on.left.png"));
            left.Color = 0xFF0000;

            LightSource right = Scene.AddLightSource("right", FastBitmap.FromFile("./examples/on.right.png"));
            right.Color = 0x00FF00;

            LightSource back = Scene.AddLightSource("back", FastBitmap.FromFile("./examples/on.back.png"));
            back.Color = 0x0000FF;

            FastBitmap target = Scene.CreateRenderTarget();
            Scene.RenderTo(target);

            view.Image = target.BaseBitmap;
        }
    }
}