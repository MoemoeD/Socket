using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class frmServer : Form
    {
        private static Socket socketWatch = null;

        private static Dictionary<string, Socket> clientConnectionItems = new Dictionary<string, Socket> { };

        public frmServer()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress address = IPAddress.Parse("127.0.0.1");

            IPEndPoint point = new IPEndPoint(address, 8098);

            socketWatch.Bind(point);

            socketWatch.Listen(20);

            Thread threadWatch = new Thread(watchConnecting);

            threadWatch.IsBackground = true;

            threadWatch.Start();

            txtMessage.Text += "Start...\r\n";
        }

        private void watchConnecting()
        {
            Socket connection = null;

            while (true)
            {
                try
                {
                    connection = socketWatch.Accept();
                }
                catch (Exception ex)
                {
                    txtMessage.Text += ex.Message + "\r\n";
                    break;
                }

                IPAddress clientIP = (connection.RemoteEndPoint as IPEndPoint).Address;
                int clientPort = (connection.RemoteEndPoint as IPEndPoint).Port;

                string sendMsg = "连接服务端成功！\r\n" + "本地IP:" + clientIP + "，本地端口" + clientPort.ToString();
                byte[] arrSendMsg = Encoding.UTF8.GetBytes(sendMsg);
                connection.Send(arrSendMsg);

                string remoteEndPoint = connection.RemoteEndPoint.ToString();
                txtMessage.Text += "成功与" + remoteEndPoint + "客户端建立连接\r\n";
                clientConnectionItems.Add(remoteEndPoint, connection);

                IPEndPoint netpoint = connection.RemoteEndPoint as IPEndPoint;

                ParameterizedThreadStart pts = new ParameterizedThreadStart(recv);
                Thread thread = new Thread(pts);
                //设置为后台线程，随着主线程退出而退出 
                thread.IsBackground = true;
                //启动线程     
                thread.Start(connection);
            }
        }

        private void recv(object socketclientpara)
        {
            Socket socketServer = socketclientpara as Socket;

            while (true)
            {
                //创建一个内存缓冲区，其大小为1024*1024字节  即1M     
                byte[] arrServerRecMsg = new byte[1024 * 1024];
                //将接收到的信息存入到内存缓冲区，并返回其字节数组的长度    
                try
                {
                    int length = socketServer.Receive(arrServerRecMsg);

                    //将机器接受到的字节数组转换为人可以读懂的字符串     
                    string strSRecMsg = Encoding.UTF8.GetString(arrServerRecMsg, 0, length);

                    //将发送的字符串信息附加到文本框txtMsg上     
                    txtMessage.Text += "客户端:" + socketServer.RemoteEndPoint + ",time:" + DateTime.Now + "\r\n" + strSRecMsg + "\r\n\n";


                    socketServer.Send(Encoding.UTF8.GetBytes("测试server 是否可以发送数据给client "));
                }
                catch (Exception ex)
                {
                    clientConnectionItems.Remove(socketServer.RemoteEndPoint.ToString());

                    txtMessage.Text += "Client Count:" + clientConnectionItems.Count + "\r\n";


                    //提示套接字监听异常  
                    txtMessage.Text += "客户端" + socketServer.RemoteEndPoint + "已经中断连接" + "\r\n" + ex.Message + "\r\n" + ex.StackTrace + "\r\n";

                    //关闭之前accept出来的和客户端进行通信的套接字 
                    socketServer.Close();
                    break;
                }
            }
        }
    }
}
