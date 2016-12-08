namespace Spelet123
{
    partial class GameForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMap = new System.Windows.Forms.Panel();
            this.tlpMap = new System.Windows.Forms.TableLayoutPanel();
            this.btnStepTest = new System.Windows.Forms.Button();
            this.tlpInventory = new System.Windows.Forms.TableLayoutPanel();
            this.btnMagnifier = new System.Windows.Forms.Button();
            this.btnHand = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statistics1 = new ctlGameScreenLibrary.Statistics();
            this.description1 = new ctlGameScreenLibrary.Description();
            this.panelMap.SuspendLayout();
            this.tlpMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(680, 486);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 63);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Main Menu";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelMap
            // 
            this.panelMap.BackColor = System.Drawing.SystemColors.Window;
            this.panelMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMap.Controls.Add(this.tlpMap);
            this.panelMap.Location = new System.Drawing.Point(12, 30);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(330, 330);
            this.panelMap.TabIndex = 1;
            // 
            // tlpMap
            // 
            this.tlpMap.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tlpMap.ColumnCount = 9;
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.Controls.Add(this.btnStepTest, 4, 4);
            this.tlpMap.Location = new System.Drawing.Point(0, 0);
            this.tlpMap.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMap.Name = "tlpMap";
            this.tlpMap.RowCount = 9;
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMap.Size = new System.Drawing.Size(326, 326);
            this.tlpMap.TabIndex = 0;
            // 
            // btnStepTest
            // 
            this.btnStepTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStepTest.Location = new System.Drawing.Point(149, 149);
            this.btnStepTest.Name = "btnStepTest";
            this.btnStepTest.Size = new System.Drawing.Size(28, 28);
            this.btnStepTest.TabIndex = 0;
            this.btnStepTest.Text = "X";
            this.btnStepTest.UseVisualStyleBackColor = true;
            this.btnStepTest.Click += new System.EventHandler(this.btnStepTest_Click);
            // 
            // tlpInventory
            // 
            this.tlpInventory.BackColor = System.Drawing.SystemColors.Window;
            this.tlpInventory.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tlpInventory.ColumnCount = 5;
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tlpInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0032F));
            this.tlpInventory.Location = new System.Drawing.Point(368, 214);
            this.tlpInventory.Name = "tlpInventory";
            this.tlpInventory.RowCount = 3;
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpInventory.Size = new System.Drawing.Size(406, 146);
            this.tlpInventory.TabIndex = 3;
            // 
            // btnMagnifier
            // 
            this.btnMagnifier.Location = new System.Drawing.Point(368, 387);
            this.btnMagnifier.Name = "btnMagnifier";
            this.btnMagnifier.Size = new System.Drawing.Size(219, 70);
            this.btnMagnifier.TabIndex = 5;
            this.btnMagnifier.Text = "Förstoringsglas";
            this.btnMagnifier.UseVisualStyleBackColor = true;
            // 
            // btnHand
            // 
            this.btnHand.Location = new System.Drawing.Point(368, 486);
            this.btnHand.Name = "btnHand";
            this.btnHand.Size = new System.Drawing.Size(219, 63);
            this.btnHand.TabIndex = 6;
            this.btnHand.Text = "Hand";
            this.btnHand.UseVisualStyleBackColor = true;
            // 
            // btnExitGame
            // 
            this.btnExitGame.Location = new System.Drawing.Point(680, 387);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(92, 70);
            this.btnExitGame.TabIndex = 7;
            this.btnExitGame.Text = "Exit Game";
            this.btnExitGame.UseVisualStyleBackColor = true;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Map";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Statistics";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Description";
            //
            // statistics1
            // 
            this.statistics1.Location = new System.Drawing.Point(368, 30);
            this.statistics1.Name = "statistics1";
            this.statistics1.Size = new System.Drawing.Size(406, 149);
            this.statistics1.StatHealth = 0;
            this.statistics1.StatSteps = 0;
            this.statistics1.StatWater = 0;
            this.statistics1.TabIndex = 12;
            // 
            // description1
            // 
            this.description1.Location = new System.Drawing.Point(14, 387);
            this.description1.Name = "description1";
            this.description1.Size = new System.Drawing.Size(328, 162);
            this.description1.TabIndex = 13;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.description1);
            this.Controls.Add(this.statistics1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.btnHand);
            this.Controls.Add(this.btnMagnifier);
            this.Controls.Add(this.tlpInventory);
            this.Controls.Add(this.panelMap);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hem igen";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.panelMap.ResumeLayout(false);
            this.tlpMap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.TableLayoutPanel tlpMap;
        private System.Windows.Forms.TableLayoutPanel tlpInventory;
        private System.Windows.Forms.Button btnMagnifier;
        private System.Windows.Forms.Button btnHand;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ctlGameScreenLibrary.Statistics statistics1;
        private System.Windows.Forms.Button btnStepTest;
        private ctlGameScreenLibrary.Description description1;
    }
}