namespace OBDII_SerialTest
{
    partial class CrcTestForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.outputTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate CRC8";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(12, 12);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(184, 20);
            this.inputTB.TabIndex = 1;
            // 
            // outputTB
            // 
            this.outputTB.Location = new System.Drawing.Point(12, 67);
            this.outputTB.Name = "outputTB";
            this.outputTB.Size = new System.Drawing.Size(184, 20);
            this.outputTB.TabIndex = 2;
            // 
            // CrcTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 99);
            this.Controls.Add(this.outputTB);
            this.Controls.Add(this.inputTB);
            this.Controls.Add(this.button1);
            this.Name = "CrcTestForm";
            this.Text = "CrcTestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.TextBox outputTB;
    }
}