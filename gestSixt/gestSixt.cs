using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestSixt
{
    public partial class frm_gestSixt : MaterialSkin.Controls.MaterialForm
    {
        public frm_gestSixt()
        {
            InitializeComponent();
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme
                (
                    MaterialSkin.Primary.Orange500, MaterialSkin.Primary.Orange400, MaterialSkin.Primary.Red300,
                    MaterialSkin.Accent.DeepOrange400,
                    MaterialSkin.TextShade.BLACK
                );
        }

        private void frm_gestSixt_Load(object sender, EventArgs e)
        {

        }
    }
}
