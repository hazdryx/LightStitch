using Hazdryx.Drawing;

namespace Hazdryx.LightStitch.WinForm
{
    public partial class Main : Form
    {
        public Scene Scene { get; }
        public FastBitmap RenderTarget { get; }

        public Main()
        {
            InitializeComponent();
            Scene = Scene.FromImage(FastBitmap.FromFile("./examples/off.png"));
            leftEditor.Source = Scene.AddLightSource("left", FastBitmap.FromFile("./examples/on.left.png"));
            backEditor.Source = Scene.AddLightSource("back", FastBitmap.FromFile("./examples/on.back.png"));
            rightEditor.Source = Scene.AddLightSource("right", FastBitmap.FromFile("./examples/on.right.png"));

            RenderTarget = Scene.CreateRenderTarget();
            Scene.RenderTo(RenderTarget);
            view.Image = RenderTarget.BaseBitmap;

            leftEditor.SourceUpdated += _SourceUpdated;
            backEditor.SourceUpdated += _SourceUpdated;
            rightEditor.SourceUpdated += _SourceUpdated;
        }

        private void _SourceUpdated(object? sender, EventArgs e)
        {
            Scene.RenderTo(RenderTarget);
            view.Image = RenderTarget.BaseBitmap;
        }
    }
}