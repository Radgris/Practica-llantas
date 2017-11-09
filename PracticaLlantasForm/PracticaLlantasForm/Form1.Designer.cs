namespace PracticaLlantasForm
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
            this.comboBoxrin = new System.Windows.Forms.ComboBox();
            this.comboBoxdibujo = new System.Windows.Forms.ComboBox();
            this.comboBoxvelocidad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxrin
            // 
            this.comboBoxrin.FormattingEnabled = true;
            this.comboBoxrin.Location = new System.Drawing.Point(13, 51);
            this.comboBoxrin.Name = "comboBoxrin";
            this.comboBoxrin.Size = new System.Drawing.Size(121, 21);
            this.comboBoxrin.TabIndex = 0;
            // 
            // comboBoxdibujo
            // 
            this.comboBoxdibujo.FormattingEnabled = true;
            this.comboBoxdibujo.Location = new System.Drawing.Point(13, 101);
            this.comboBoxdibujo.Name = "comboBoxdibujo";
            this.comboBoxdibujo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxdibujo.TabIndex = 1;
            // 
            // comboBoxvelocidad
            // 
            this.comboBoxvelocidad.FormattingEnabled = true;
            this.comboBoxvelocidad.Location = new System.Drawing.Point(13, 151);
            this.comboBoxvelocidad.Name = "comboBoxvelocidad";
            this.comboBoxvelocidad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxvelocidad.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 496);
            this.Controls.Add(this.comboBoxvelocidad);
            this.Controls.Add(this.comboBoxdibujo);
            this.Controls.Add(this.comboBoxrin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxrin;
        private System.Windows.Forms.ComboBox comboBoxdibujo;
        private System.Windows.Forms.ComboBox comboBoxvelocidad;
    }
}

