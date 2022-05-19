using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using MailKit.Net.Pop3;
using MailKit.Net.Smtp;
using MimeKit;

namespace NT106_M21_Group7_LyThuyet5_5
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Form sendMailForm = new SendMail();
            sendMailForm.Show();
        }

        private void btnRecv_Click(object sender, EventArgs e)
        {
            Form recvMailForm = new RecvMail();
            recvMailForm.Show();
        }
    }
}
