namespace ClassViewer
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftPanel = new System.Windows.Forms.Panel();
            this.methodPickLbl = new System.Windows.Forms.Label();
            this.objectPickLbl = new System.Windows.Forms.Label();
            this.methodPicker = new System.Windows.Forms.ComboBox();
            this.objectPicker = new System.Windows.Forms.ComboBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.infoTbx = new System.Windows.Forms.TextBox();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.leftPanel.Controls.Add(this.methodPickLbl);
            this.leftPanel.Controls.Add(this.objectPickLbl);
            this.leftPanel.Controls.Add(this.methodPicker);
            this.leftPanel.Controls.Add(this.objectPicker);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(242, 450);
            this.leftPanel.TabIndex = 0;
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint);
            // 
            // methodPickLbl
            // 
            this.methodPickLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.methodPickLbl.Location = new System.Drawing.Point(43, 103);
            this.methodPickLbl.Name = "methodPickLbl";
            this.methodPickLbl.Size = new System.Drawing.Size(135, 31);
            this.methodPickLbl.TabIndex = 3;
            this.methodPickLbl.Text = "Choose Method";
            this.methodPickLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // objectPickLbl
            // 
            this.objectPickLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objectPickLbl.Location = new System.Drawing.Point(43, 22);
            this.objectPickLbl.Name = "objectPickLbl";
            this.objectPickLbl.Size = new System.Drawing.Size(135, 26);
            this.objectPickLbl.TabIndex = 2;
            this.objectPickLbl.Text = "Choose Object";
            this.objectPickLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // methodPicker
            // 
            this.methodPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodPicker.FormattingEnabled = true;
            this.methodPicker.Location = new System.Drawing.Point(43, 134);
            this.methodPicker.Name = "methodPicker";
            this.methodPicker.Size = new System.Drawing.Size(135, 24);
            this.methodPicker.TabIndex = 1;
            this.methodPicker.SelectedIndexChanged += new System.EventHandler(this.methodPicker_SelectedIndexChanged);
            // 
            // objectPicker
            // 
            this.objectPicker.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.objectPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.objectPicker.FormattingEnabled = true;
            this.objectPicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.objectPicker.Location = new System.Drawing.Point(43, 51);
            this.objectPicker.Name = "objectPicker";
            this.objectPicker.Size = new System.Drawing.Size(135, 24);
            this.objectPicker.TabIndex = 0;
            this.objectPicker.SelectedIndexChanged += new System.EventHandler(this.objectPicker_SelectedIndexChanged);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rightPanel.Controls.Add(this.infoTbx);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(242, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(558, 450);
            this.rightPanel.TabIndex = 1;
            // 
            // infoTbx
            // 
            this.infoTbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTbx.Location = new System.Drawing.Point(0, 0);
            this.infoTbx.Multiline = true;
            this.infoTbx.Name = "infoTbx";
            this.infoTbx.ReadOnly = true;
            this.infoTbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoTbx.Size = new System.Drawing.Size(558, 450);
            this.infoTbx.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "Form1";
            this.Text = "ClassViewer";
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox infoTbx;

        private System.Windows.Forms.Label methodPickLbl;

        private System.Windows.Forms.Label objectPickLbl;

        private System.Windows.Forms.ComboBox objectPicker;
        private System.Windows.Forms.ComboBox methodPicker;

        private System.Windows.Forms.Panel rightPanel;

        private System.Windows.Forms.Panel leftPanel;

        #endregion
    }
}