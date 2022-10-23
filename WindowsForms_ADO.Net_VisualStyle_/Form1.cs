using System.Linq;
using System.Windows.Forms;

namespace WindowsForms_ADO.Net_VisualStyle_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (var u = new UserDataBaseEntities())
            {
                dataGridViewUser.DataSource = u.Users.ToList();
            }
        }
    }
}
