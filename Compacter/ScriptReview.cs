using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compacter
{
    public partial class ScriptReview : Form
    {
        public ScriptReview()
        {
            InitializeComponent();
        }

        public ScriptReview(string scriptPath) : this()
        {
            string script = File.ReadAllText(scriptPath);
            tbScript.Text = script;
        }

        private void ScriptReview_Load(object sender, EventArgs e)
        {
            // Make sure the No has focus as to prevent accidental click on Yes
            btnNo.Focus();
        }
    }
}
