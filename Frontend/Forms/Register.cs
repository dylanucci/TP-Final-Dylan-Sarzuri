using Frontend.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class Register : Form
    {
        private readonly IApiClient _client;
        public Register(IApiClient client)
        {
            _client = client;
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
