using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z2Client
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;

        public Form1()
        {
            InitializeComponent();
            ConnectToServer();
            Task.Run(() => ReceiveMessages());
        }

        private void ConnectToServer()
        {
            try
            {
                client = new TcpClient();
                client.Connect("127.0.0.1", 7000);
                stream = client.GetStream();
                labelStatus.Text = "������: ����������";
                MessageBox.Show("���������� � �������");
            }
            catch (Exception ex)
            {
                MessageBox.Show("�� ������� ������������ � �������: " + ex.Message);
                labelStatus.Text = "������: �� ����������";
            }
        }

        private async Task ReceiveMessages()
        {
            byte[] buffer = new byte[256];
            int bytesRead;

            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Invoke((Action)(() =>
                {
                    listBoxMessages.Items.Add("������: " + message);
                }));

                Array.Clear(buffer, 0, buffer.Length);
            }
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            string message = richTextBoxMessage.Text;
            if (!string.IsNullOrWhiteSpace(message))
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                await stream.WriteAsync(data, 0, data.Length);

                listBoxMessages.Items.Add("��: " + message);
                richTextBoxMessage.Clear();
            }
        }
    }
}