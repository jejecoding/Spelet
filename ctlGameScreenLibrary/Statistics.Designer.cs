namespace ctlGameScreenLibrary
{
    partial class Statistics
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlpStats = new System.Windows.Forms.TableLayoutPanel();
            this.lblStat5 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lblWater = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.tmrPlaytime = new System.Windows.Forms.Timer(this.components);
            this.tlpStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpStats
            // 
            this.tlpStats.BackColor = System.Drawing.SystemColors.Window;
            this.tlpStats.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tlpStats.ColumnCount = 1;
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStats.Controls.Add(this.lblStat5, 0, 4);
            this.tlpStats.Controls.Add(this.lblTime, 0, 3);
            this.tlpStats.Controls.Add(this.lblSteps, 0, 2);
            this.tlpStats.Controls.Add(this.lblWater, 0, 1);
            this.tlpStats.Controls.Add(this.lblHealth, 0, 0);
            this.tlpStats.Location = new System.Drawing.Point(0, 0);
            this.tlpStats.Margin = new System.Windows.Forms.Padding(0);
            this.tlpStats.Name = "tlpStats";
            this.tlpStats.RowCount = 5;
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpStats.Size = new System.Drawing.Size(406, 149);
            this.tlpStats.TabIndex = 3;
            // 
            // lblStat5
            // 
            this.lblStat5.AutoSize = true;
            this.lblStat5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStat5.Location = new System.Drawing.Point(5, 118);
            this.lblStat5.Name = "lblStat5";
            this.lblStat5.Size = new System.Drawing.Size(396, 29);
            this.lblStat5.TabIndex = 4;
            this.lblStat5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Location = new System.Drawing.Point(5, 89);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(396, 27);
            this.lblTime.TabIndex = 3;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSteps.Location = new System.Drawing.Point(5, 60);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(396, 27);
            this.lblSteps.TabIndex = 2;
            this.lblSteps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWater.Location = new System.Drawing.Point(5, 31);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(396, 27);
            this.lblWater.TabIndex = 1;
            this.lblWater.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHealth.Location = new System.Drawing.Point(5, 2);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(396, 27);
            this.lblHealth.TabIndex = 0;
            this.lblHealth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrPlaytime
            // 
            this.tmrPlaytime.Tick += new System.EventHandler(this.tmrPlaytime_Tick);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpStats);
            this.Name = "Statistics";
            this.Size = new System.Drawing.Size(406, 149);
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.tlpStats.ResumeLayout(false);
            this.tlpStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private System.Windows.Forms.Label lblStat5;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Timer tmrPlaytime;
    }
}
