using Frontend.Client;
using Frontend.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace Frontend
{
    public partial class Principal : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public Principal(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

            var LoginOrRegisterUI = this._serviceProvider.GetRequiredService<LoginOrRegisterUI>();
            LoginOrRegisterUI.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var adminUI = _serviceProvider.GetRequiredService<AdminUI>();
            this.Hide();
            adminUI.Show();
        }
    }
}
