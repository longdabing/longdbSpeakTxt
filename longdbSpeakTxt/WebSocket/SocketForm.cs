using longdbSpeakTxt.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace longdbSpeakTxt.WebSocket
{
    public partial class SocketForm : Form
    {
        private readonly ClientWebSocket _webSocket = new ClientWebSocket();
  
        public SocketForm()
        {
            InitializeComponent();
        }

        private async void btnsend_Click(object sender, EventArgs e)
        {
          await  WebSocket();
        }


        public async Task WebSocket()
        {
            try
            {
                if (_webSocket != null && _webSocket.State == WebSocketState.Open)
                {
                    byte[] bytedata = new byte[1024];
                    //构造信息。
                    MessageModel message = new MessageModel();
                    message.RoomId = txtroom.Text.Trim();
                    message.DataType = DataType.String;
                    message.SendType = SendType.Broadcast;
                    message.Data = txtmsg.Text;
                    message.SenderName = "龙大饼";
                    string tempstr = JsonConvert.SerializeObject(message);
                    bytedata = Encoding.UTF8.GetBytes(tempstr);
                    await _webSocket.SendAsync(new ArraySegment<byte>(bytedata), WebSocketMessageType.Text, true, CancellationToken.None); //发送数据
                    var result = new byte[1024];
                    while (true)//循环开起来后，只能发生一次，第二次就报异常了。2020.6.10
                    {
                        result = new byte[1024];
                        await _webSocket.ReceiveAsync(new ArraySegment<byte>(result), CancellationToken.None);//接受数据


                        var rmsg = Encoding.UTF8.GetString(result, 0, result.Length);
                        dataGridView1.Rows.Add(new string[] { rmsg });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常:" + ex.ToString());
            }
        }

        private async void btnopen_Click(object sender, EventArgs e)
        {
            //建立连接
            if (_webSocket != null && _webSocket.State != WebSocketState.Open)
            {
                var url = txturl.Text.Trim();
                await _webSocket.ConnectAsync(new Uri(url), CancellationToken.None);
            }
        }
    }
}
