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
            Scene.AddLightSource("left", FastBitmap.FromFile("./examples/on.left.png"));
            LightSource source = Scene.AddLightSource("right", FastBitmap.FromFile("./examples/on.right.png"));
            Scene.AddLightSource("back", FastBitmap.FromFile("./examples/on.back.png"));

            view.Image = source.Baked.BaseBitmap;
        }
    }
}