namespace Hazdryx.LightStitch.WinForm
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.view = new System.Windows.Forms.PictureBox();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.leftEditor = new Hazdryx.LightStitch.WinForm.LightSourceEditor();
            this.backEditor = new Hazdryx.LightStitch.WinForm.LightSourceEditor();
            this.rightEditor = new Hazdryx.LightStitch.WinForm.LightSourceEditor();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.Black;
            this.view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view.Location = new System.Drawing.Point(0, 0);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(1478, 664);
            this.view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.view.TabIndex = 0;
            this.view.TabStop = false;
            // 
            // table
            // 
            this.table.ColumnCount = 3;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table.Controls.Add(this.leftEditor, 0, 0);
            this.table.Controls.Add(this.backEditor, 1, 0);
            this.table.Controls.Add(this.rightEditor, 2, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.table.Location = new System.Drawing.Point(0, 664);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Size = new System.Drawing.Size(1478, 192);
            this.table.TabIndex = 1;
            // 
            // leftEditor
            // 
            this.leftEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.leftEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftEditor.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leftEditor.HeaderText = "Left Light";
            this.leftEditor.Location = new System.Drawing.Point(0, 0);
            this.leftEditor.Margin = new System.Windows.Forms.Padding(0);
            this.leftEditor.Name = "leftEditor";
            this.leftEditor.Size = new System.Drawing.Size(492, 192);
            this.leftEditor.Source = null;
            this.leftEditor.TabIndex = 0;
            // 
            // backEditor
            // 
            this.backEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.backEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backEditor.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backEditor.HeaderText = "Back Light";
            this.backEditor.Location = new System.Drawing.Point(492, 0);
            this.backEditor.Margin = new System.Windows.Forms.Padding(0);
            this.backEditor.Name = "backEditor";
            this.backEditor.Size = new System.Drawing.Size(492, 192);
            this.backEditor.Source = null;
            this.backEditor.TabIndex = 1;
            // 
            // rightEditor
            // 
            this.rightEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.rightEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightEditor.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rightEditor.HeaderText = "Right Light";
            this.rightEditor.Location = new System.Drawing.Point(984, 0);
            this.rightEditor.Margin = new System.Windows.Forms.Padding(0);
            this.rightEditor.Name = "rightEditor";
            this.rightEditor.Size = new System.Drawing.Size(494, 192);
            this.rightEditor.Source = null;
            this.rightEditor.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 856);
            this.Controls.Add(this.view);
            this.Controls.Add(this.table);
            this.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LightStitch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox view;
        private TableLayoutPanel table;
        private LightSourceEditor leftEditor;
        private LightSourceEditor backEditor;
        private LightSourceEditor rightEditor;
    }
}