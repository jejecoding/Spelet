using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ctlGameScreenLibrary
{
    public partial class Description : UserControl
    {
        Color foregroundColor;
        Color backgroundColor;
        string descriptionText;
        
        public string DescriptionText
        {
            get
            {
                return descriptionText;
            }
            set
            {
                descriptionText = value;
                lblDesc.Text = descriptionText;
            }
        }

        public Color ForegroundColor
        {
            get
            {
                return foregroundColor;
            }
            set
            {
                foregroundColor = value;
                lblDesc.ForeColor = foregroundColor;
            }
        }

        public Color BackgroundColor
        {
            get
            {
                return backgroundColor;
            }
            set
            {
                backgroundColor = value;
                lblDesc.BackColor = backgroundColor;
            }
        }

        public Description()
        {
            InitializeComponent();
        }
    }
}
