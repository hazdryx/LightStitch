namespace Hazdryx.LightStitch.WinForm
{
    partial class LightSourceEditor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.header = new System.Windows.Forms.Label();
            this.r = new System.Windows.Forms.TrackBar();
            this.g = new System.Windows.Forms.TrackBar();
            this.b = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(571, 42);
            this.header.TabIndex = 0;
            this.header.Text = "label1";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // r
            // 
            this.r.Dock = System.Windows.Forms.DockStyle.Left;
            this.r.Location = new System.Drawing.Point(0, 42);
            this.r.Maximum = 255;
            this.r.Name = "r";
            this.r.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.r.Size = new System.Drawing.Size(56, 507);
            this.r.TabIndex = 1;
            this.r.TickFrequency = 255;
            this.r.Value = 255;
            this.r.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnColorChange);
            // 
            // g
            // 
            this.g.Dock = System.Windows.Forms.DockStyle.Left;
            this.g.Location = new System.Drawing.Point(56, 42);
            this.g.Maximum = 255;
            this.g.Name = "g";
            this.g.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.g.Size = new System.Drawing.Size(56, 507);
            this.g.TabIndex = 2;
            this.g.TickFrequency = 255;
            this.g.Value = 255;
            this.g.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnColorChange);
            // 
            // b
            // 
            this.b.Dock = System.Windows.Forms.DockStyle.Left;
            this.b.Location = new System.Drawing.Point(112, 42);
            this.b.Maximum = 255;
            this.b.Name = "b";
            this.b.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.b.Size = new System.Drawing.Size(56, 507);
            this.b.TabIndex = 3;
            this.b.TickFrequency = 255;
            this.b.Value = 255;
            this.b.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnColorChange);
            // 
            // LightSourceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.b);
            this.Controls.Add(this.g);
            this.Controls.Add(this.r);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LightSourceEditor";
            this.Size = new System.Drawing.Size(571, 549);
            ((System.ComponentModel.ISupportInitialize)(this.r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label header;
        private TrackBar r;
        private TrackBar g;
        private TrackBar b;
    }
}
