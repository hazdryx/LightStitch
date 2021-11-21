using Hazdryx.Drawing;

namespace Hazdryx.LightStitch.WinForm
{
    public partial class LightSourceEditor : UserControl
    {
        public event EventHandler? SourceUpdated;

        public LightSource? Source { get; set; }
        public string HeaderText
        {
            get => header.Text;
            set => header.Text = value;
        }

        public LightSourceEditor()
        {
            InitializeComponent();
        }

        private void OnColorChange(object sender, MouseEventArgs args)
        {
            FastColor.Explode(Source.Color, out int r, out int g, out int b);
            TrackBar trackBar = (TrackBar) sender;
            if (trackBar.Name == "r")
            {
                r = trackBar.Value;
            }
            else if (trackBar.Name == "g")
            {
                g = trackBar.Value;
            }
            else if (trackBar.Name == "b")
            {
                b = trackBar.Value;
            }
            Source.Color = FastColor.Implode(0xff, r, g, b);
            SourceUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}
