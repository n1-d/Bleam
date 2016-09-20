namespace Bleam
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Graphical = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Disable_Spartan_Mode = new System.Windows.Forms.CheckBox();
            this.Hemi_SSAO = new System.Windows.Forms.CheckBox();
            this.Render_Lightmap_Shadows = new System.Windows.Forms.CheckBox();
            this.Exposure_Use_Light_Source = new System.Windows.Forms.CheckBox();
            this.Exposure_Use_Color_Source = new System.Windows.Forms.CheckBox();
            this.NoGore = new System.Windows.Forms.CheckBox();
            this.Effects_Distortion = new System.Windows.Forms.CheckBox();
            this.Misc = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.forge_map_box_value = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.Debug_Controller_Latency = new System.Windows.Forms.CheckBox();
            this.DebugShit = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Credit = new System.Windows.Forms.TabPage();
            this.Credits = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FoVNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFPSValue)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Graphical.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Misc.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DebugShit.SuspendLayout();
            this.Credit.SuspendLayout();
            this.SuspendLayout();
            // 
            // Max_FPS
            // 
            this.Max_FPS.Location = new System.Drawing.Point(12, 6);
            this.Max_FPS.Name = "Max_FPS";
            this.Max_FPS.Size = new System.Drawing.Size(272, 23);
            this.Max_FPS.TabIndex = 0;
            this.Max_FPS.Text = "Change Max FPS";
            this.Max_FPS.UseVisualStyleBackColor = true;
            this.Max_FPS.Click += new System.EventHandler(this.Max_FPS_Click);
            // 
            // hButton_Step3
            // 
            this.hButton_Step3.Location = new System.Drawing.Point(12, 35);
            this.hButton_Step3.Name = "hButton_Step3";
            this.hButton_Step3.Size = new System.Drawing.Size(272, 23);
            this.hButton_Step3.TabIndex = 1;
            this.hButton_Step3.Text = "Change FOV";
            this.hButton_Step3.UseVisualStyleBackColor = true;
            this.hButton_Step3.Click += new System.EventHandler(this.FOV_CHANGER_Click);
            // 
            // FoVNumber
            // 
            this.FoVNumber.Location = new System.Drawing.Point(290, 37);
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
            this.MaxFPSValue.Location = new System.Drawing.Point(290, 9);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Graphical);
            this.tabControl1.Controls.Add(this.Misc);
            this.tabControl1.Controls.Add(this.DebugShit);
            this.tabControl1.Controls.Add(this.Credit);
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(59, 18);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(425, 290);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Graphical
            // 
            this.Graphical.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Graphical.Controls.Add(this.Max_FPS);
            this.Graphical.Controls.Add(this.hButton_Step3);
            this.Graphical.Controls.Add(this.MaxFPSValue);
            this.Graphical.Controls.Add(this.FoVNumber);
            this.Graphical.Controls.Add(this.groupBox1);
            this.Graphical.Location = new System.Drawing.Point(4, 22);
            this.Graphical.Name = "Graphical";
            this.Graphical.Padding = new System.Windows.Forms.Padding(3);
            this.Graphical.Size = new System.Drawing.Size(417, 264);
            this.Graphical.TabIndex = 0;
            this.Graphical.Text = "Graphical";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Disable_Spartan_Mode);
            this.groupBox1.Controls.Add(this.Hemi_SSAO);
            this.groupBox1.Controls.Add(this.Render_Lightmap_Shadows);
            this.groupBox1.Controls.Add(this.Exposure_Use_Light_Source);
            this.groupBox1.Controls.Add(this.Exposure_Use_Color_Source);
            this.groupBox1.Controls.Add(this.NoGore);
            this.groupBox1.Controls.Add(this.Effects_Distortion);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 194);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toggles";
            // 
            // Disable_Spartan_Mode
            // 
            this.Disable_Spartan_Mode.Appearance = System.Windows.Forms.Appearance.Button;
            this.Disable_Spartan_Mode.AutoSize = true;
            this.Disable_Spartan_Mode.BackColor = System.Drawing.Color.Black;
            this.Disable_Spartan_Mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Disable_Spartan_Mode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Disable_Spartan_Mode.FlatAppearance.BorderSize = 10;
            this.Disable_Spartan_Mode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Disable_Spartan_Mode.ForeColor = System.Drawing.Color.Red;
            this.Disable_Spartan_Mode.Location = new System.Drawing.Point(85, 77);
            this.Disable_Spartan_Mode.Name = "Disable_Spartan_Mode";
            this.Disable_Spartan_Mode.Size = new System.Drawing.Size(122, 23);
            this.Disable_Spartan_Mode.TabIndex = 19;
            this.Disable_Spartan_Mode.Text = "Disable Spartan Mode";
            this.Disable_Spartan_Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Disable_Spartan_Mode.UseVisualStyleBackColor = false;
            // 
            // Hemi_SSAO
            // 
            this.Hemi_SSAO.Appearance = System.Windows.Forms.Appearance.Button;
            this.Hemi_SSAO.AutoSize = true;
            this.Hemi_SSAO.BackColor = System.Drawing.Color.Black;
            this.Hemi_SSAO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Hemi_SSAO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Hemi_SSAO.FlatAppearance.BorderSize = 10;
            this.Hemi_SSAO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Hemi_SSAO.ForeColor = System.Drawing.Color.Red;
            this.Hemi_SSAO.Location = new System.Drawing.Point(6, 77);
            this.Hemi_SSAO.Name = "Hemi_SSAO";
            this.Hemi_SSAO.Size = new System.Drawing.Size(73, 23);
            this.Hemi_SSAO.TabIndex = 18;
            this.Hemi_SSAO.Text = "Hemi SSAO";
            this.Hemi_SSAO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Hemi_SSAO.UseVisualStyleBackColor = false;
            // 
            // Render_Lightmap_Shadows
            // 
            this.Render_Lightmap_Shadows.Appearance = System.Windows.Forms.Appearance.Button;
            this.Render_Lightmap_Shadows.AutoSize = true;
            this.Render_Lightmap_Shadows.BackColor = System.Drawing.Color.Black;
            this.Render_Lightmap_Shadows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Render_Lightmap_Shadows.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Render_Lightmap_Shadows.FlatAppearance.BorderSize = 10;
            this.Render_Lightmap_Shadows.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Render_Lightmap_Shadows.ForeColor = System.Drawing.Color.Red;
            this.Render_Lightmap_Shadows.Location = new System.Drawing.Point(6, 48);
            this.Render_Lightmap_Shadows.Name = "Render_Lightmap_Shadows";
            this.Render_Lightmap_Shadows.Size = new System.Drawing.Size(145, 23);
            this.Render_Lightmap_Shadows.TabIndex = 17;
            this.Render_Lightmap_Shadows.Text = "Render Lightmap Shadows";
            this.Render_Lightmap_Shadows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Render_Lightmap_Shadows.UseVisualStyleBackColor = false;
            // 
            // Exposure_Use_Light_Source
            // 
            this.Exposure_Use_Light_Source.Appearance = System.Windows.Forms.Appearance.Button;
            this.Exposure_Use_Light_Source.AutoSize = true;
            this.Exposure_Use_Light_Source.BackColor = System.Drawing.Color.Black;
            this.Exposure_Use_Light_Source.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exposure_Use_Light_Source.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Exposure_Use_Light_Source.FlatAppearance.BorderSize = 10;
            this.Exposure_Use_Light_Source.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Exposure_Use_Light_Source.ForeColor = System.Drawing.Color.Red;
            this.Exposure_Use_Light_Source.Location = new System.Drawing.Point(157, 48);
            this.Exposure_Use_Light_Source.Name = "Exposure_Use_Light_Source";
            this.Exposure_Use_Light_Source.Size = new System.Drawing.Size(165, 23);
            this.Exposure_Use_Light_Source.TabIndex = 16;
            this.Exposure_Use_Light_Source.Text = "Exposures Use Lighting Source";
            this.Exposure_Use_Light_Source.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exposure_Use_Light_Source.UseVisualStyleBackColor = false;
            // 
            // Exposure_Use_Color_Source
            // 
            this.Exposure_Use_Color_Source.Appearance = System.Windows.Forms.Appearance.Button;
            this.Exposure_Use_Color_Source.AutoSize = true;
            this.Exposure_Use_Color_Source.BackColor = System.Drawing.Color.Black;
            this.Exposure_Use_Color_Source.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exposure_Use_Color_Source.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Exposure_Use_Color_Source.FlatAppearance.BorderSize = 10;
            this.Exposure_Use_Color_Source.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Exposure_Use_Color_Source.ForeColor = System.Drawing.Color.Red;
            this.Exposure_Use_Color_Source.Location = new System.Drawing.Point(226, 19);
            this.Exposure_Use_Color_Source.Name = "Exposure_Use_Color_Source";
            this.Exposure_Use_Color_Source.Size = new System.Drawing.Size(152, 23);
            this.Exposure_Use_Color_Source.TabIndex = 15;
            this.Exposure_Use_Color_Source.Text = "Exposures Use Color Source";
            this.Exposure_Use_Color_Source.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exposure_Use_Color_Source.UseVisualStyleBackColor = false;
            // 
            // NoGore
            // 
            this.NoGore.Appearance = System.Windows.Forms.Appearance.Button;
            this.NoGore.AutoSize = true;
            this.NoGore.BackColor = System.Drawing.Color.Black;
            this.NoGore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NoGore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NoGore.FlatAppearance.BorderSize = 10;
            this.NoGore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NoGore.ForeColor = System.Drawing.Color.Red;
            this.NoGore.Location = new System.Drawing.Point(112, 19);
            this.NoGore.Name = "NoGore";
            this.NoGore.Size = new System.Drawing.Size(108, 23);
            this.NoGore.TabIndex = 14;
            this.NoGore.Text = "Non-Violent Corpse";
            this.NoGore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoGore.UseVisualStyleBackColor = false;
            // 
            // Effects_Distortion
            // 
            this.Effects_Distortion.Appearance = System.Windows.Forms.Appearance.Button;
            this.Effects_Distortion.AutoSize = true;
            this.Effects_Distortion.BackColor = System.Drawing.Color.Black;
            this.Effects_Distortion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Effects_Distortion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Effects_Distortion.FlatAppearance.BorderSize = 10;
            this.Effects_Distortion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Effects_Distortion.ForeColor = System.Drawing.Color.Red;
            this.Effects_Distortion.Location = new System.Drawing.Point(6, 19);
            this.Effects_Distortion.Name = "Effects_Distortion";
            this.Effects_Distortion.Size = new System.Drawing.Size(100, 23);
            this.Effects_Distortion.TabIndex = 13;
            this.Effects_Distortion.Text = "Effects Distortion ";
            this.Effects_Distortion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Effects_Distortion.UseVisualStyleBackColor = false;
            this.Effects_Distortion.CheckedChanged += new System.EventHandler(this.Effects_Distortion_CheckedChanged);
            // 
            // Misc
            // 
            this.Misc.BackColor = System.Drawing.Color.Transparent;
            this.Misc.Controls.Add(this.button1);
            this.Misc.Controls.Add(this.label1);
            this.Misc.Controls.Add(this.forge_map_box_value);
            this.Misc.Controls.Add(this.groupBox2);
            this.Misc.Location = new System.Drawing.Point(4, 22);
            this.Misc.Name = "Misc";
            this.Misc.Padding = new System.Windows.Forms.Padding(3);
            this.Misc.Size = new System.Drawing.Size(417, 264);
            this.Misc.TabIndex = 1;
            this.Misc.Text = "Miscellaneous";
            this.Misc.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Forge Map Tutorial";
            // 
            // forge_map_box_value
            // 
            this.forge_map_box_value.Location = new System.Drawing.Point(111, 128);
            this.forge_map_box_value.Name = "forge_map_box_value";
            this.forge_map_box_value.Size = new System.Drawing.Size(295, 20);
            this.forge_map_box_value.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox15);
            this.groupBox2.Controls.Add(this.checkBox14);
            this.groupBox2.Controls.Add(this.checkBox13);
            this.groupBox2.Controls.Add(this.checkBox12);
            this.groupBox2.Controls.Add(this.checkBox11);
            this.groupBox2.Controls.Add(this.checkBox10);
            this.groupBox2.Controls.Add(this.checkBox9);
            this.groupBox2.Controls.Add(this.checkBox8);
            this.groupBox2.Controls.Add(this.Debug_Controller_Latency);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 115);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toggles";
            // 
            // checkBox15
            // 
            this.checkBox15.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox15.AutoSize = true;
            this.checkBox15.BackColor = System.Drawing.Color.Black;
            this.checkBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBox15.FlatAppearance.BorderSize = 10;
            this.checkBox15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox15.ForeColor = System.Drawing.Color.Red;
            this.checkBox15.Location = new System.Drawing.Point(126, 77);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(119, 23);
            this.checkBox15.TabIndex = 22;
            this.checkBox15.Text = "Debug Draw Widgets";
            this.checkBox15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox15.UseVisualStyleBackColor = false;
            // 
            // checkBox14
            // 
            this.checkBox14.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox14.AutoSize = true;
            this.checkBox14.BackColor = System.Drawing.Color.Black;
            this.checkBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBox14.FlatAppearance.BorderSize = 10;
            this.checkBox14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox14.ForeColor = System.Drawing.Color.Red;
            this.checkBox14.Location = new System.Drawing.Point(6, 77);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(114, 23);
            this.checkBox14.TabIndex = 21;
            this.checkBox14.Text = "Ignore Forge Budget";
            this.checkBox14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox14.UseVisualStyleBackColor = false;
            // 
            // checkBox13
            // 
            this.checkBox13.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox13.AutoSize = true;
            this.checkBox13.BackColor = System.Drawing.Color.Black;
            this.checkBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBox13.FlatAppearance.BorderSize = 10;
            this.checkBox13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox13.ForeColor = System.Drawing.Color.Red;
            this.checkBox13.Location = new System.Drawing.Point(302, 48);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(81, 23);
            this.checkBox13.TabIndex = 20;
            this.checkBox13.Text = "MP Map Intro";
            this.checkBox13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox13.UseVisualStyleBackColor = false;
            // 
            // checkBox12
            // 
            this.checkBox12.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox12.AutoSize = true;
            this.checkBox12.BackColor = System.Drawing.Color.Black;
            this.checkBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBox12.FlatAppearance.BorderSize = 10;
            this.checkBox12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox12.ForeColor = System.Drawing.Color.Red;
            this.checkBox12.Location = new System.Drawing.Point(185, 48);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(111, 23);
            this.checkBox12.TabIndex = 19;
            this.checkBox12.Text = "Kill Volumes Disable";
            this.checkBox12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox12.UseVisualStyleBackColor = false;
            // 
            // checkBox11
            // 
            this.checkBox11.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox11.AutoSize = true;
            this.checkBox11.BackColor = System.Drawing.Color.Black;
            this.checkBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBox11.FlatAppearance.BorderSize = 10;
            this.checkBox11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox11.ForeColor = System.Drawing.Color.Red;
            this.checkBox11.Location = new System.Drawing.Point(119, 48);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(60, 23);
            this.checkBox11.TabIndex = 18;
            this.checkBox11.Text = "IsTutorial";
            this.checkBox11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox11.UseVisualStyleBackColor = false;
            // 
            // checkBox10
            // 
            this.checkBox10.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox10.AutoSize = true;
            this.checkBox10.BackColor = System.Drawing.Color.Black;
            this.checkBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBox10.FlatAppearance.BorderSize = 10;
            this.checkBox10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox10.ForeColor = System.Drawing.Color.Red;
            this.checkBox10.Location = new System.Drawing.Point(6, 48);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(107, 23);
            this.checkBox10.TabIndex = 17;
            this.checkBox10.Text = "First Person Squish";
            this.checkBox10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox10.UseVisualStyleBackColor = false;
            // 
            // checkBox9
            // 
            this.checkBox9.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox9.AutoSize = true;
            this.checkBox9.BackColor = System.Drawing.Color.Black;
            this.checkBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBox9.FlatAppearance.BorderSize = 10;
            this.checkBox9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox9.ForeColor = System.Drawing.Color.Red;
            this.checkBox9.Location = new System.Drawing.Point(266, 19);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(124, 23);
            this.checkBox9.TabIndex = 16;
            this.checkBox9.Text = "Exclusive Mouse Input";
            this.checkBox9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox9.UseVisualStyleBackColor = false;
            // 
            // checkBox8
            // 
            this.checkBox8.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox8.AutoSize = true;
            this.checkBox8.BackColor = System.Drawing.Color.Black;
            this.checkBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkBox8.FlatAppearance.BorderSize = 10;
            this.checkBox8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox8.ForeColor = System.Drawing.Color.Red;
            this.checkBox8.Location = new System.Drawing.Point(149, 19);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(111, 23);
            this.checkBox8.TabIndex = 15;
            this.checkBox8.Text = "Clambering Enabled";
            this.checkBox8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox8.UseVisualStyleBackColor = false;
            // 
            // Debug_Controller_Latency
            // 
            this.Debug_Controller_Latency.Appearance = System.Windows.Forms.Appearance.Button;
            this.Debug_Controller_Latency.AutoSize = true;
            this.Debug_Controller_Latency.BackColor = System.Drawing.Color.Black;
            this.Debug_Controller_Latency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Debug_Controller_Latency.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Debug_Controller_Latency.FlatAppearance.BorderSize = 10;
            this.Debug_Controller_Latency.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Debug_Controller_Latency.ForeColor = System.Drawing.Color.Red;
            this.Debug_Controller_Latency.Location = new System.Drawing.Point(6, 19);
            this.Debug_Controller_Latency.Name = "Debug_Controller_Latency";
            this.Debug_Controller_Latency.Size = new System.Drawing.Size(137, 23);
            this.Debug_Controller_Latency.TabIndex = 14;
            this.Debug_Controller_Latency.Text = "Debug Controller Latency";
            this.Debug_Controller_Latency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Debug_Controller_Latency.UseVisualStyleBackColor = false;
            // 
            // DebugShit
            // 
            this.DebugShit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DebugShit.Controls.Add(this.groupBox3);
            this.DebugShit.Location = new System.Drawing.Point(4, 22);
            this.DebugShit.Name = "DebugShit";
            this.DebugShit.Padding = new System.Windows.Forms.Padding(3);
            this.DebugShit.Size = new System.Drawing.Size(417, 264);
            this.DebugShit.TabIndex = 3;
            this.DebugShit.Text = "Debug";
            // 
            // groupBox3
            // 
            this.groupBox3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 252);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toggles";
            // 
            // Credit
            // 
            this.Credit.BackColor = System.Drawing.Color.Transparent;
            this.Credit.Controls.Add(this.Credits);
            this.Credit.Location = new System.Drawing.Point(4, 22);
            this.Credit.Name = "Credit";
            this.Credit.Padding = new System.Windows.Forms.Padding(3);
            this.Credit.Size = new System.Drawing.Size(417, 264);
            this.Credit.TabIndex = 2;
            this.Credit.Text = "Credits";
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.ForeColor = System.Drawing.Color.Black;
            this.Credits.Location = new System.Drawing.Point(6, 108);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(327, 39);
            this.Credits.TabIndex = 11;
            this.Credits.Text = "Credits goto Xbox7887, Wunkolo, no1dead, 404Spartan, Lord Zedd\r\nGamecheat 13, Sho" +
    "ckfire, Personality, Bivi for all the addresses,\r\nand hard work. ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(394, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Set Forge Map";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // hForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 314);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "hForm";
            this.Text = "Bleam";
            ((System.ComponentModel.ISupportInitialize)(this.FoVNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFPSValue)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Graphical.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Misc.ResumeLayout(false);
            this.Misc.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.DebugShit.ResumeLayout(false);
            this.Credit.ResumeLayout(false);
            this.Credit.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Max_FPS;
		private System.Windows.Forms.Button hButton_Step3;
        private System.Windows.Forms.NumericUpDown FoVNumber;
        private System.Windows.Forms.NumericUpDown MaxFPSValue;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Graphical;
        private System.Windows.Forms.TabPage Misc;
        private System.Windows.Forms.CheckBox Effects_Distortion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Debug_Controller_Latency;
        private System.Windows.Forms.TabPage Credit;
        private System.Windows.Forms.Label Credits;
        private System.Windows.Forms.CheckBox Exposure_Use_Light_Source;
        private System.Windows.Forms.CheckBox Exposure_Use_Color_Source;
        private System.Windows.Forms.CheckBox NoGore;
        private System.Windows.Forms.CheckBox Disable_Spartan_Mode;
        private System.Windows.Forms.CheckBox Hemi_SSAO;
        private System.Windows.Forms.CheckBox Render_Lightmap_Shadows;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.TabPage DebugShit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox forge_map_box_value;
        private System.Windows.Forms.Button button1;
    }
}

