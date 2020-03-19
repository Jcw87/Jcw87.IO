using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jcw87.IO
{
    public partial class BinaryWriterEndian : BinaryWriter
    {
        private byte[] m_buffer2;
        private bool m_nativeEndian = true;
        private bool m_bigEndian = !BitConverter.IsLittleEndian;

        public BinaryWriterEndian(Stream input) : this(input, Encoding.UTF8) { }
        public BinaryWriterEndian(Stream input, Encoding encoding) : this(input, encoding, false) { }
        public BinaryWriterEndian(Stream input, Encoding encoding, bool leaveOpen) : base(input, encoding, leaveOpen)
        {
            var minBufferSize = encoding.GetMaxByteCount(1);  // max bytes per one char
            if (minBufferSize < 16) minBufferSize = 16;
            m_buffer2 = new byte[minBufferSize];
        }

        public bool BigEndian
        {
            get { return m_bigEndian; }
            set
            {
                m_bigEndian = value;
                m_nativeEndian = BitConverter.IsLittleEndian != m_bigEndian;
            }
        }

        public virtual void WriteInt24(int value)
        {
            BitConverter2.GetBytes(value, m_buffer2, 0);
            if (!m_nativeEndian) Array.Reverse(m_buffer2, 0, 4);
            BaseStream.Write(m_buffer2, m_bigEndian ? 1 : 0, 3);
        }

        public virtual void WriteUInt24(uint value)
        {
            BitConverter2.GetBytes(value, m_buffer2, 0);
            if (!m_nativeEndian) Array.Reverse(m_buffer2, 0, 4);
            BaseStream.Write(m_buffer2, m_bigEndian ? 1 : 0, 3);
        }
    }
}
