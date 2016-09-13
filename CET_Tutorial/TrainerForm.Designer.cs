namespace CET_Tutorial
{
	partial class hForm
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
            this.Max_FPS = new System.Windows.Forms.Button();
            this.hButton_Step3 = new System.Windows.Forms.Button();
            this.FoVNumber = new System.Windows.Forms.NumericUpDown();
            this.MaxFPSValue = new System.Windows.Forms.NumericUpDown();
            this.Credits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FoVNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFPSValue)).BeginInit();
            this.SuspendLayout();
            // 
            // Max_FPS
            // 
            this.Max_FPS.Location = new System.Drawing.Point(12, 12);
            this.Max_FPS.Name = "Max_FPS";
            this.Max_FPS.Size = new System.Drawing.Size(272, 23);
            this.Max_FPS.TabIndex = 0;
            this.Max_FPS.Text = "Change Max FPS";
            this.Max_FPS.UseVisualStyleBackColor = true;
            this.Max_FPS.Click += new System.EventHandler(this.Max_FPS_Click);
            // 
            // hButton_Step3
            // 
            this.hButton_Step3.Location = new System.Drawing.Point(12, 41);
            this.hButton_Step3.Name = "hButton_Step3";
            this.hButton_Step3.Size = new System.Drawing.Size(272, 23);
            this.hButton_Step3.TabIndex = 1;
            this.hButton_Step3.Text = "Change FOV";
            this.hButton_Step3.UseVisualStyleBackColor = true;
            this.hButton_Step3.Click += new System.EventHandler(this.FOV_CHANGER_Click);
            // 
            // FoVNumber
            // 
            this.FoVNumber.Location = new System.Drawing.Point(309, 44);
            this.FoVNumber.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.FoVNumber.Name = "FoVNumber";
            this.FoVNumber.Size = new System.Drawing.Size(120, 20);
            this.FoVNumber.TabIndex = 8;
            this.FoVNumber.Value = new decimal(new int[] {
            78,
            0,
            0,
            0});
            // 
            // MaxFPSValue
            // 
            this.MaxFPSValue.Location = new System.Drawing.Point(309, 15);
            this.MaxFPSValue.Maximum = new decimal(new int[] {
            144,
            0,
            0,
            0});
            this.MaxFPSValue.Name = "MaxFPSValue";
            this.MaxFPSValue.Size = new System.Drawing.Size(120, 20);
            this.MaxFPSValue.TabIndex = 9;
            this.MaxFPSValue.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.ForeColor = System.Drawing.Color.Gray;
            this.Credits.Location = new System.Drawing.Point(9, 83);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(416, 13);
            this.Credits.TabIndex = 10;
            this.Credits.Text = "Credits goto Xbox7887 for all the addresses and no1dead for making this shitty pr" +
    "ogram";
            // 
            // hForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 105);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.MaxFPSValue);
            this.Controls.Add(this.FoVNumber);
            this.Controls.Add(this.hButton_Step3);
            this.Controls.Add(this.Max_FPS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "hForm";
            this.Text = "FPS/FOV Unlocker";
            ((System.ComponentModel.ISupportInitialize)(this.FoVNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFPSValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Max_FPS;
		private System.Windows.Forms.Button hButton_Step3;
        private System.Windows.Forms.NumericUpDown FoVNumber;
        private System.Windows.Forms.NumericUpDown MaxFPSValue;
        private System.Windows.Forms.Label Credits;
    }
}

