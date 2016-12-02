namespace ctlGameScreenLibrary
{
    partial class Description
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
            this.lblDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.BackColor = System.Drawing.Color.Black;
            this.lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesc.ForeColor = System.Drawing.Color.Lime;
            this.lblDesc.Location = new System.Drawing.Point(0, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(328, 162);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "This text is a description for the biome you are in";
            // 
            // Description
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDesc);
            this.Name = "Description";
            this.Size = new System.Drawing.Size(328, 162);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDesc;
    }
}
