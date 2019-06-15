namespace manageBooks.Vista
{
    partial class _2OptionDialog
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
            this.lbMensaje = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Location = new System.Drawing.Point(172, 75);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbMensaje.Size = new System.Drawing.Size(0, 13);
            this.lbMensaje.TabIndex = 0;
            this.lbMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(60, 163);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 40);
            this.bt1.TabIndex = 1;
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(220, 163);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 40);
            this.bt2.TabIndex = 2;
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // _2OptionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 224);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.lbMensaje);
            this.Name = "_2OptionDialog";
            this.Text = "_2OptionDialog";
            this.Load += new System.EventHandler(this._2OptionDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
    }
}