using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClickerProject
{
    public partial class hire : Form
    {
        CCClass a = new CCClass();
        Boolean nerd;
        Boolean programmer;
        Boolean hackerman;
        public hire()
        {
            InitializeComponent();
        }

        private void Hire_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            a.hire(nerd = true, programmer, hackerman);

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
