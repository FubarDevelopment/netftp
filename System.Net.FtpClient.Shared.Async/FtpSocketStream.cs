using System;
using System.IO;
using System.Net.Sockets;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Net.FtpClient {
    /// <summary>
    /// Stream class used for talking. Used by FtpClient, extended by FtpDataStream
    /// </summary>
    public partial class FtpSocketStream {
        /// <summary>
        /// Asynchronously accepts a connection from a listening socket
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public IAsyncResult BeginAccept(AsyncCallback callback, object state) {
            if (m_socket != null)
                return m_socket.BeginAccept(callback, state);
            return null;
        }

        /// <summary>
        /// Completes a BeginAccept() operation
        /// </summary>
        /// <param name="ar">IAsyncResult returned from BeginAccept</param>
        public void EndAccept(IAsyncResult ar) {
            if (m_socket != null) {
                m_socket = m_socket.EndAccept(ar);
                m_netStream = new NetworkStream(m_socket);
            }
        }
    }
}
