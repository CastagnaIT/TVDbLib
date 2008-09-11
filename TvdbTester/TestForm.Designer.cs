﻿namespace TvdbTester
{
  partial class TestForm
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
      this.cmdTest1 = new System.Windows.Forms.Button();
      this.cmdTestZip = new System.Windows.Forms.Button();
      this.cmdInit = new System.Windows.Forms.Button();
      this.cmdEnd = new System.Windows.Forms.Button();
      this.lvSeries = new System.Windows.Forms.ListView();
      this.chProperty = new System.Windows.Forms.ColumnHeader();
      this.chValue = new System.Windows.Forms.ColumnHeader();
      this.bcSeriesBanner = new TvdbTester.BannerControl();
      this.bcActors = new TvdbTester.BannerControl();
      this.txtSeriesId = new System.Windows.Forms.TextBox();
      this.txtSeriesId2 = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.Episodes = new System.Windows.Forms.GroupBox();
      this.cbOrdering = new System.Windows.Forms.ComboBox();
      this.cmdGetEpisodes = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.Episodes.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdTest1
      // 
      this.cmdTest1.Location = new System.Drawing.Point(22, 67);
      this.cmdTest1.Name = "cmdTest1";
      this.cmdTest1.Size = new System.Drawing.Size(137, 23);
      this.cmdTest1.TabIndex = 0;
      this.cmdTest1.Text = "Test 1";
      this.cmdTest1.UseVisualStyleBackColor = true;
      this.cmdTest1.Click += new System.EventHandler(this.cmdTest1_Click);
      // 
      // cmdTestZip
      // 
      this.cmdTestZip.Location = new System.Drawing.Point(77, 96);
      this.cmdTestZip.Name = "cmdTestZip";
      this.cmdTestZip.Size = new System.Drawing.Size(82, 23);
      this.cmdTestZip.TabIndex = 2;
      this.cmdTestZip.Text = "Test Zip";
      this.cmdTestZip.UseVisualStyleBackColor = true;
      this.cmdTestZip.Click += new System.EventHandler(this.cmdTestZip_Click);
      // 
      // cmdInit
      // 
      this.cmdInit.Location = new System.Drawing.Point(22, 9);
      this.cmdInit.Name = "cmdInit";
      this.cmdInit.Size = new System.Drawing.Size(137, 23);
      this.cmdInit.TabIndex = 3;
      this.cmdInit.Text = "Initialise";
      this.cmdInit.UseVisualStyleBackColor = true;
      this.cmdInit.Click += new System.EventHandler(this.cmdInit_Click);
      // 
      // cmdEnd
      // 
      this.cmdEnd.Location = new System.Drawing.Point(22, 293);
      this.cmdEnd.Name = "cmdEnd";
      this.cmdEnd.Size = new System.Drawing.Size(137, 23);
      this.cmdEnd.TabIndex = 4;
      this.cmdEnd.Text = "End";
      this.cmdEnd.UseVisualStyleBackColor = true;
      this.cmdEnd.Click += new System.EventHandler(this.cmdEnd_Click);
      // 
      // lvSeries
      // 
      this.lvSeries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProperty,
            this.chValue});
      this.lvSeries.FullRowSelect = true;
      this.lvSeries.Location = new System.Drawing.Point(180, 96);
      this.lvSeries.Name = "lvSeries";
      this.lvSeries.Size = new System.Drawing.Size(348, 363);
      this.lvSeries.TabIndex = 5;
      this.lvSeries.UseCompatibleStateImageBehavior = false;
      this.lvSeries.View = System.Windows.Forms.View.Details;
      // 
      // chProperty
      // 
      this.chProperty.Text = "Property";
      this.chProperty.Width = 139;
      // 
      // chValue
      // 
      this.chValue.Text = "Value";
      this.chValue.Width = 200;
      // 
      // bcSeriesBanner
      // 
      this.bcSeriesBanner.BackColor = System.Drawing.SystemColors.ControlDark;
      this.bcSeriesBanner.BannerImage = null;
      this.bcSeriesBanner.BannerImages = null;
      this.bcSeriesBanner.DefaultImage = null;
      this.bcSeriesBanner.ImageSizeMode = System.Windows.Forms.ImageLayout.Zoom;
      this.bcSeriesBanner.Index = 0;
      this.bcSeriesBanner.LoadingBackgroundColor = System.Drawing.Color.Transparent;
      this.bcSeriesBanner.LoadingImage = null;
      this.bcSeriesBanner.Location = new System.Drawing.Point(180, 9);
      this.bcSeriesBanner.Name = "bcSeriesBanner";
      this.bcSeriesBanner.Size = new System.Drawing.Size(348, 81);
      this.bcSeriesBanner.TabIndex = 6;
      this.bcSeriesBanner.UnavailableImage = null;
      // 
      // bcActors
      // 
      this.bcActors.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.bcActors.BannerImage = null;
      this.bcActors.BannerImages = null;
      this.bcActors.DefaultImage = null;
      this.bcActors.ImageSizeMode = System.Windows.Forms.ImageLayout.Zoom;
      this.bcActors.Index = 0;
      this.bcActors.LoadingBackgroundColor = System.Drawing.Color.Black;
      this.bcActors.LoadingImage = global::TvdbTester.Properties.Resources.loader4;
      this.bcActors.Location = new System.Drawing.Point(543, 9);
      this.bcActors.Name = "bcActors";
      this.bcActors.Size = new System.Drawing.Size(300, 450);
      this.bcActors.TabIndex = 1;
      this.bcActors.UnavailableImage = null;
      // 
      // txtSeriesId
      // 
      this.txtSeriesId.Location = new System.Drawing.Point(22, 98);
      this.txtSeriesId.Name = "txtSeriesId";
      this.txtSeriesId.Size = new System.Drawing.Size(49, 20);
      this.txtSeriesId.TabIndex = 7;
      this.txtSeriesId.Text = "73255";
      // 
      // txtSeriesId2
      // 
      this.txtSeriesId2.Location = new System.Drawing.Point(10, 37);
      this.txtSeriesId2.Name = "txtSeriesId2";
      this.txtSeriesId2.Size = new System.Drawing.Size(46, 20);
      this.txtSeriesId2.TabIndex = 8;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(62, 37);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(41, 20);
      this.textBox1.TabIndex = 8;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(109, 37);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(49, 20);
      this.textBox2.TabIndex = 8;
      // 
      // Episodes
      // 
      this.Episodes.Controls.Add(this.cbOrdering);
      this.Episodes.Controls.Add(this.cmdGetEpisodes);
      this.Episodes.Controls.Add(this.label3);
      this.Episodes.Controls.Add(this.label2);
      this.Episodes.Controls.Add(this.label1);
      this.Episodes.Controls.Add(this.txtSeriesId2);
      this.Episodes.Controls.Add(this.textBox2);
      this.Episodes.Controls.Add(this.textBox1);
      this.Episodes.Location = new System.Drawing.Point(6, 125);
      this.Episodes.Name = "Episodes";
      this.Episodes.Size = new System.Drawing.Size(168, 100);
      this.Episodes.TabIndex = 9;
      this.Episodes.TabStop = false;
      this.Episodes.Text = "Episodes";
      // 
      // cbOrdering
      // 
      this.cbOrdering.FormattingEnabled = true;
      this.cbOrdering.Location = new System.Drawing.Point(10, 63);
      this.cbOrdering.Name = "cbOrdering";
      this.cbOrdering.Size = new System.Drawing.Size(64, 21);
      this.cbOrdering.TabIndex = 11;
      // 
      // cmdGetEpisodes
      // 
      this.cmdGetEpisodes.Location = new System.Drawing.Point(80, 63);
      this.cmdGetEpisodes.Name = "cmdGetEpisodes";
      this.cmdGetEpisodes.Size = new System.Drawing.Size(78, 23);
      this.cmdGetEpisodes.TabIndex = 10;
      this.cmdGetEpisodes.Text = "Get Episode";
      this.cmdGetEpisodes.UseVisualStyleBackColor = true;
      this.cmdGetEpisodes.Click += new System.EventHandler(this.cmdGetEpisodes_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(106, 21);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(45, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "Episode";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(59, 21);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(43, 13);
      this.label2.TabIndex = 9;
      this.label2.Text = "Season";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 21);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(36, 13);
      this.label1.TabIndex = 9;
      this.label1.Text = "Series";
      // 
      // TestForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(855, 485);
      this.Controls.Add(this.Episodes);
      this.Controls.Add(this.txtSeriesId);
      this.Controls.Add(this.bcSeriesBanner);
      this.Controls.Add(this.lvSeries);
      this.Controls.Add(this.cmdEnd);
      this.Controls.Add(this.cmdInit);
      this.Controls.Add(this.cmdTestZip);
      this.Controls.Add(this.bcActors);
      this.Controls.Add(this.cmdTest1);
      this.Name = "TestForm";
      this.Text = "TestForm";
      this.Episodes.ResumeLayout(false);
      this.Episodes.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button cmdTest1;
    private BannerControl bcActors;
    private System.Windows.Forms.Button cmdTestZip;
    private System.Windows.Forms.Button cmdInit;
    private System.Windows.Forms.Button cmdEnd;
    private System.Windows.Forms.ListView lvSeries;
    private System.Windows.Forms.ColumnHeader chProperty;
    private System.Windows.Forms.ColumnHeader chValue;
    private BannerControl bcSeriesBanner;
    private System.Windows.Forms.TextBox txtSeriesId;
    private System.Windows.Forms.TextBox txtSeriesId2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.GroupBox Episodes;
    private System.Windows.Forms.ComboBox cbOrdering;
    private System.Windows.Forms.Button cmdGetEpisodes;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
  }
}