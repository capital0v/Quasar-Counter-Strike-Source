using Quasar.Features;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quasar.UserControls
{
    public partial class Changer_UC : UserControl
    {

        private Functions _functions;
        internal Changer_UC(Functions functions)
        {
            InitializeComponent();

            _functions = functions;
        }

        private void nickname_button_Click(object sender, EventArgs e)
        {
            _functions.ChangeNickname(nickname_textbox.Text);
        }

        private void clantag_button_Click(object sender, EventArgs e)
        {
            _functions.ChangeClantag(clantag_textbox.Text);
        }
    }
}
