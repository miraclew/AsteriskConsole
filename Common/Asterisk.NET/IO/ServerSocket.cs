using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Asterisk.NET.IO
{
	/// <summary>
	/// ServerSocket using standard socket classes.
	/// </summary>
	public class ServerSocket
	{
		private TcpListener tcpListener;
		private Encoding encoding;

		public ServerSocket(int port, IPAddress bindAddress, Encoding encoding)
		{
			this.encoding = encoding;
			tcpListener = new TcpListener(new IPEndPoint(bindAddress, port));
			tcpListener.Start();
		}
		
		public IO.SocketConnection Accept()
		{
			TcpClient tcpClient = tcpListener.AcceptTcpClient();
			return new IO.SocketConnection(tcpClient, encoding);
		}
		
		public void Close()
		{
			tcpListener.Stop();
		}
	}
}
