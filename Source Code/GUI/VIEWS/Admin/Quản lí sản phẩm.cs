using ShopNow.Source_Code.BUS.SERVICES;

namespace ShopNow.Source_Code.GUI.VIEWS.Admin
{
    public partial class Quản_lí_sản_phẩm : Form
    {
        public Quản_lí_sản_phẩm()
        {
            InitializeComponent();
        }

        private void Quản_lí_sản_phẩm_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml(ServicesGlobalVariables.GlobalBackColor);

        }
    }
}
