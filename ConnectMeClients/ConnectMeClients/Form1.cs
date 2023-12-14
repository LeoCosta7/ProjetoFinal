using ClientMe;
using ConnectMeClients.Util;

namespace ConnectMeClients
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer updateTimer;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCreateClient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClientName.Text))
            {
                ClientsManagerUtil clientsManagerUtil = new ClientsManagerUtil();
                FormClient formClient = new FormClient();

                clientsManagerUtil.InitializeGrpcConnection();

                await clientsManagerUtil.RequestClient(new RequestClient { ClientName = txtClientName.Text }, formClient);

                //Setando informações do respectivo cliente
                formClient.lblUsername.Text = txtClientName.Text;
                formClient.btnStatus.BackColor = Color.LimeGreen;
                txtClientName.Text = "";

                formClient.Show();
            }
            else
                MessageBox.Show("Insert a Name");
        }
    }
}