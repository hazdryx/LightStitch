using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Hazdryx.LightStitch.Utils;

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
            ColorUtil.Explode(Source.Color, out int r, out int g, out int b);
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
            Source.Color = ColorUtil.Implode(r, g, b);
            SourceUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}
