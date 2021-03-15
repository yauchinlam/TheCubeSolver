
namespace CubeSolver
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
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.Camera = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCamera
            // 
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(137, 4);
            this.cboCamera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(232, 21);
            this.cboCamera.TabIndex = 0;
            this.cboCamera.SelectedIndexChanged += new System.EventHandler(this.cboCamera_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(23, 399);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(61, 29);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Camera
            // 
            this.Camera.AutoSize = true;
            this.Camera.Location = new System.Drawing.Point(62, 7);
            this.Camera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Camera.Name = "Camera";
            this.Camera.Size = new System.Drawing.Size(43, 13);
            this.Camera.TabIndex = 3;
            this.Camera.Text = "Camera";
            this.Camera.Click += new System.EventHandler(this.Camera_Click);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(23, 34);
            this.pic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(373, 338);
            this.pic.TabIndex = 4;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(333, 399);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 443);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Camera);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.pic);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cube Solver v2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label Camera;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}