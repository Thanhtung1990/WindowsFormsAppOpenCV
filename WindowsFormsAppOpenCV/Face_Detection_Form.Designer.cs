namespace WindowsFormsAppOpenCV
{
    partial class Face_Detection_Form
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
            this.components = new System.ComponentModel.Container();
            this.camera_Box = new Emgu.CV.UI.ImageBox();
            this.lbl_cameraBox = new System.Windows.Forms.Label();
            this.btn_detect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.camera_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // camera_Box
            // 
            this.camera_Box.Location = new System.Drawing.Point(12, 48);
            this.camera_Box.Name = "camera_Box";
            this.camera_Box.Size = new System.Drawing.Size(265, 258);
            this.camera_Box.TabIndex = 2;
            this.camera_Box.TabStop = false;
            // 
            // lbl_cameraBox
            // 
            this.lbl_cameraBox.AutoSize = true;
            this.lbl_cameraBox.Location = new System.Drawing.Point(108, 22);
            this.lbl_cameraBox.Name = "lbl_cameraBox";
            this.lbl_cameraBox.Size = new System.Drawing.Size(69, 13);
            this.lbl_cameraBox.TabIndex = 3;
            this.lbl_cameraBox.Text = "Camera View";
            // 
            // btn_detect
            // 
            this.btn_detect.Location = new System.Drawing.Point(73, 312);
            this.btn_detect.Name = "btn_detect";
            this.btn_detect.Size = new System.Drawing.Size(141, 23);
            this.btn_detect.TabIndex = 4;
            this.btn_detect.Text = "Detect and Recognite";
            this.btn_detect.UseVisualStyleBackColor = true;
            this.btn_detect.Click += new System.EventHandler(this.btn_detect_Click);
            // 
            // Face_Detection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_detect);
            this.Controls.Add(this.lbl_cameraBox);
            this.Controls.Add(this.camera_Box);
            this.Name = "Face_Detection_Form";
            this.Text = "Face_Detection_Form";
            ((System.ComponentModel.ISupportInitialize)(this.camera_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox camera_Box;
        private System.Windows.Forms.Label lbl_cameraBox;
        private System.Windows.Forms.Button btn_detect;
    }
}