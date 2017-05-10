using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iUniversity
{
    public partial class EditUser : Form
    {
        public EditUser(User user)
        {
            InitializeComponent();
            LabelUserId.Text = user.Id.ToString();
            TextBoxUserName.Text = user.Name;
            TextBoxUserPatronumyc.Text = user.Patromumyc;
            TextBoxUserSurname.Text = user.Surname;
            ComboBoxUserJob.Text = user.Job;
        }

        private void SaveUserBtn_Click(object sender, EventArgs e)
        {
            var userId = Int32.Parse(LabelUserId.Text);

            var parent = (Form1)this.Owner;

            foreach (object id in parent.Users)
            {
                var user = (User)id;

                if (user.Id == userId)
                {
                    user.Name = TextBoxUserName.Text;
                    user.Surname = TextBoxUserSurname.Text;
                    user.Patromumyc = TextBoxUserPatronumyc.Text;
                    user.Job = ComboBoxUserJob.Text;

                    parent.RedrawDeansUsersList();
                    parent.ReDrawMainUsersList();
                }
            }
        }
    }
}
