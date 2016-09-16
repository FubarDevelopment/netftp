using System.Net.Sockets;
using System.Threading.Tasks;

namespace System.Net.FtpClient
{
    /// <summary>
    /// Stream class used for talking. Used by FtpClient, extended by FtpDataStream
    /// </summary>
    public partial class FtpSocketStream {
#if NET45
        public async Task AcceptAsync() {
            m_socket = await Task<Socket>.Factory.FromAsync(
                                             (callback, state) => ((Socket) state).BeginAccept(callback, state),
                                             asyncResult => ((Socket) asyncResult.AsyncState).EndAccept(asyncResult),
                                             state: m_socket).ConfigureAwait(false);
            m_netStream = new NetworkStream(m_socket);
        }
#else
        public async Task AcceptAsync() {
            m_socket = await m_socket.AcceptAsync().ConfigureAwait(false);
            m_netStream = new NetworkStream(m_socket);
        }
#endif
    }
}
