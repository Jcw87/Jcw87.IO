using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Jcw87.IO
{
    public partial class BinaryReaderEndian : BinaryReader
    {
        private byte[] m_buffer2;
        private bool m_nativeEndian = true;
        private bool m_bigEndian = !BitConverter.IsLittleEndian;

        public BinaryReaderEndian(Stream input) : this(input, Encoding.UTF8) { }
        public BinaryReaderEndian(Stream input, Encoding encoding) : this(input, encoding, false) { }
        public BinaryReaderEndian(Stream input, Encoding encoding, bool leaveOpen) : base(input, encoding, leaveOpen)
        {
            var minBufferSize = encoding.GetMaxByteCount(1);  // max bytes per one char
            if (minBufferSize < 16) minBufferSize = 16;
            m_buffer2 = new byte[minBufferSize];
        }

        public bool BigEndian {
            get { return m_bigEndian; }
            set
            {
                m_bigEndian = value;
                m_nativeEndian = BitConverter.IsLittleEndian != m_bigEndian;
            }
        }

        public virtual int ReadInt24()
        {
            Array.Clear(m_buffer2, 0, 4);
            BaseStream.Read(m_buffer2, m_bigEndian ? 1 : 0, 3);
            if (!m_nativeEndian) Array.Reverse(m_buffer2, 0, 4);
            return BitConverter.ToInt32(m_buffer2, 0);
        }

        public virtual uint ReadUInt24()
        {
            Array.Clear(m_buffer2, 0, 4);
            BaseStream.Read(m_buffer2, m_bigEndian ? 1 : 0, 3);
            if (!m_nativeEndian) Array.Reverse(m_buffer2, 0, 4);
            return BitConverter.ToUInt32(m_buffer2, 0);
        }
    }
}
