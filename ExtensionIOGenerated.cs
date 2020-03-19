using System;
using System.IO;

namespace Jcw87.IO
{
    internal static class BitConverter2
    {
        public unsafe static void GetBytes(Int16 value, byte[] buffer, int offset)
        {
            if (buffer == null) throw new ArgumentNullException(nameof(buffer));
            if (offset < 0) throw new ArgumentOutOfRangeException(nameof(offset));
            if (buffer.Length - offset < sizeof(Int16)) throw new ArgumentException();

            fixed (byte* b = &buffer[offset]) *((Int16*)b) = value;
        }

        public unsafe static void GetBytes(Int32 value, byte[] buffer, int offset)
        {
            if (buffer == null) throw new ArgumentNullException(nameof(buffer));
            if (offset < 0) throw new ArgumentOutOfRangeException(nameof(offset));
            if (buffer.Length - offset < sizeof(Int32)) throw new ArgumentException();

            fixed (byte* b = &buffer[offset]) *((Int32*)b) = value;
        }

        public unsafe static void GetBytes(Int64 value, byte[] buffer, int offset)
        {
            if (buffer == null) throw new ArgumentNullException(nameof(buffer));
            if (offset < 0) throw new ArgumentOutOfRangeException(nameof(offset));
            if (buffer.Length - offset < sizeof(Int64)) throw new ArgumentException();

            fixed (byte* b = &buffer[offset]) *((Int64*)b) = value;
        }

        public unsafe static void GetBytes(UInt16 value, byte[] buffer, int offset)
        {
            if (buffer == null) throw new ArgumentNullException(nameof(buffer));
            if (offset < 0) throw new ArgumentOutOfRangeException(nameof(offset));
            if (buffer.Length - offset < sizeof(UInt16)) throw new ArgumentException();

            fixed (byte* b = &buffer[offset]) *((UInt16*)b) = value;
        }

        public unsafe static void GetBytes(UInt32 value, byte[] buffer, int offset)
        {
            if (buffer == null) throw new ArgumentNullException(nameof(buffer));
            if (offset < 0) throw new ArgumentOutOfRangeException(nameof(offset));
            if (buffer.Length - offset < sizeof(UInt32)) throw new ArgumentException();

            fixed (byte* b = &buffer[offset]) *((UInt32*)b) = value;
        }

        public unsafe static void GetBytes(UInt64 value, byte[] buffer, int offset)
        {
            if (buffer == null) throw new ArgumentNullException(nameof(buffer));
            if (offset < 0) throw new ArgumentOutOfRangeException(nameof(offset));
            if (buffer.Length - offset < sizeof(UInt64)) throw new ArgumentException();

            fixed (byte* b = &buffer[offset]) *((UInt64*)b) = value;
        }

        public unsafe static void GetBytes(Single value, byte[] buffer, int offset)
        {
            if (buffer == null) throw new ArgumentNullException(nameof(buffer));
            if (offset < 0) throw new ArgumentOutOfRangeException(nameof(offset));
            if (buffer.Length - offset < sizeof(Single)) throw new ArgumentException();

            fixed (byte* b = &buffer[offset]) *((Single*)b) = value;
        }

        public unsafe static void GetBytes(Double value, byte[] buffer, int offset)
        {
            if (buffer == null) throw new ArgumentNullException(nameof(buffer));
            if (offset < 0) throw new ArgumentOutOfRangeException(nameof(offset));
            if (buffer.Length - offset < sizeof(Double)) throw new ArgumentException();

            fixed (byte* b = &buffer[offset]) *((Double*)b) = value;
        }

    }

    public static class ExtensionIOGenerated
    {
        public static Int16 ReadInt16LE(this byte[] bytes, int offset)
        {
            var data = bytes.ReadBytes(offset, sizeof(Int16));
            if (!BitConverter.IsLittleEndian) Array.Reverse(data);
            return BitConverter.ToInt16(data, 0);
        }

        public static Int16 ReadInt16BE(this byte[] bytes, int offset)
        {
            var data = bytes.ReadBytes(offset, sizeof(Int16));
            if (BitConverter.IsLittleEndian) Array.Reverse(data);
            return BitConverter.ToInt16(data, 0);
        }

        public static void WriteLE(this byte[] bytes, int offset, Int16 value)
        {
            BitConverter2.GetBytes(value, bytes, offset);
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes, offset, sizeof(Int16));
        }

        public static void WriteBE(this byte[] bytes, int offset, Int16 value)
        {
            BitConverter2.GetBytes(value, bytes, offset);
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes, offset, sizeof(Int16));
        }

        public static Int16 ReadInt16LE(this Stream stream)
        {
            var bytes = new byte[sizeof(Int16)];
            stream.Read(bytes, 0, sizeof(Int16));
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes);
            return BitConverter.ToInt16(bytes, 0);
        }

        public static Int16 ReadInt16BE(this Stream stream)
        {
            var bytes = new byte[sizeof(Int16)];
            stream.Read(bytes, 0, sizeof(Int16));
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes);
            return BitConverter.ToInt16(bytes, 0);
        }

        public static void WriteLE(this Stream stream, Int16 value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes);
            stream.Write(bytes, 0, bytes.Length);
        }

        public static void WriteBE(this Stream stream, Int16 value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes);
            stream.Write(bytes, 0, bytes.Length);
        }

        public static Int32 ReadInt32LE(this byte[] bytes, int offset)
        {
            var data = bytes.ReadBytes(offset, sizeof(Int32));
            if (!BitConverter.IsLittleEndian) Array.Reverse(data);
            return BitConverter.ToInt32(data, 0);
        }

        public static Int32 ReadInt32BE(this byte[] bytes, int offset)
        {
            var data = bytes.ReadBytes(offset, sizeof(Int32));
            if (BitConverter.IsLittleEndian) Array.Reverse(data);
            return BitConverter.ToInt32(data, 0);
        }

        public static void WriteLE(this byte[] bytes, int offset, Int32 value)
        {
            BitConverter2.GetBytes(value, bytes, offset);
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes, offset, sizeof(Int32));
        }

        public static void WriteBE(this byte[] bytes, int offset, Int32 value)
        {
            BitConverter2.GetBytes(value, bytes, offset);
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes, offset, sizeof(Int32));
        }

        public static Int32 ReadInt32LE(this Stream stream)
        {
            var bytes = new byte[sizeof(Int32)];
            stream.Read(bytes, 0, sizeof(Int32));
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }

        public static Int32 ReadInt32BE(this Stream stream)
        {
            var bytes = new byte[sizeof(Int32)];
            stream.Read(bytes, 0, sizeof(Int32));
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }

        public static void WriteLE(this Stream stream, Int32 value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes);
            stream.Write(bytes, 0, bytes.Length);
        }

        public static void WriteBE(this Stream stream, Int32 value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes);
            stream.Write(bytes, 0, bytes.Length);
        }

        public static Int64 ReadInt64LE(this byte[] bytes, int offset)
        {
            var data = bytes.ReadBytes(offset, sizeof(Int64));
            if (!BitConverter.IsLittleEndian) Array.Reverse(data);
            return BitConverter.ToInt64(data, 0);
        }

        public static Int64 ReadInt64BE(this byte[] bytes, int offset)
        {
            var data = bytes.ReadBytes(offset, sizeof(Int64));
            if (BitConverter.IsLittleEndian) Array.Reverse(data);
            return BitConverter.ToInt64(data, 0);
        }

        public static void WriteLE(this byte[] bytes, int offset, Int64 value)
        {
            BitConverter2.GetBytes(value, bytes, offset);
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes, offset, sizeof(Int64));
        }

        public static void WriteBE(this byte[] bytes, int offset, Int64 value)
        {
            BitConverter2.GetBytes(value, bytes, offset);
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes, offset, sizeof(Int64));
        }

        public static Int64 ReadInt64LE(this Stream stream)
        {
            var bytes = new byte[sizeof(Int64)];
            stream.Read(bytes, 0, sizeof(Int64));
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes);
            return BitConverter.ToInt64(bytes, 0);
        }

        public static Int64 ReadInt64BE(this Stream stream)
        {
            var bytes = new byte[sizeof(Int64)];
            stream.Read(bytes, 0, sizeof(Int64));
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes);
            return BitConverter.ToInt64(bytes, 0);
        }

        public static void WriteLE(this Stream stream, Int64 value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes);
            stream.Write(bytes, 0, bytes.Length);
        }

        public static void WriteBE(this Stream stream, Int64 value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes);
            stream.Write(bytes, 0, bytes.Length);
        }

        public static UInt16 ReadUInt16LE(this byte[] bytes, int offset)
        {
            var data = bytes.ReadBytes(offset, sizeof(UInt16));
            if (!BitConverter.IsLittleEndian) Array.Reverse(data);
            return BitConverter.ToUInt16(data, 0);
        }

        public static UInt16 ReadUInt16BE(this byte[] bytes, int offset)
        {
            var data = bytes.ReadBytes(offset, sizeof(UInt16));
            if (BitConverter.IsLittleEndian) Array.Reverse(data);
            return BitConverter.ToUInt16(data, 0);
        }

        public static void WriteLE(this byte[] bytes, int offset, UInt16 value)
        {
            BitConverter2.GetBytes(value, bytes, offset);
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes, offset, sizeof(UInt16));
        }

        public static void WriteBE(this byte[] bytes, int offset, UInt16 value)
        {
            BitConverter2.GetBytes(value, bytes, offset);
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes, offset, sizeof(UInt16));
        }

        public static UInt16 ReadUInt16LE(this Stream stream)
        {
            var bytes = new byte[sizeof(UInt16)];
            stream.Read(bytes, 0, sizeof(UInt16));
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes);
            return BitConverter.ToUInt16(bytes, 0);
        }

        public static UInt16 ReadUInt16BE(this Stream stream)
        {
            var bytes = new byte[sizeof(UInt16)];
            stream.Read(bytes, 0, sizeof(UInt16));
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes);
            return BitConverter.ToUInt16(bytes, 0);
        }

        public static void WriteLE(this Stream stream, UInt16 value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes);
            stream.Write(bytes, 0, bytes.Length);
        }

        public static void WriteBE(this Stream stream, UInt16 value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes);
            stream.Write(bytes, 0, bytes.Length);
        }

        public static UInt32 ReadUInt32LE(this byte[] bytes, int offset)
        {
            var data = bytes.ReadBytes(offset, sizeof(UInt32));
            if (!BitConverter.IsLittleEndian) Array.Reverse(data);
            return BitConverter.ToUInt32(data, 0);
        }

        public static UInt32 ReadUInt32BE(this byte[] bytes, int offset)
        {
            var data = bytes.ReadBytes(offset, sizeof(UInt32));
            if (BitConverter.IsLittleEndian) Array.Reverse(data);
            return BitConverter.ToUInt32(data, 0);
        }

        public static void WriteLE(this byte[] bytes, int offset, UInt32 value)
        {
            BitConverter2.GetBytes(value, bytes, offset);
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes, offset, sizeof(UInt32));
        }

        public static void WriteBE(this byte[] bytes, int offset, UInt32 value)
        {
            BitConverter2.GetBytes(value, bytes, offset);
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes, offset, sizeof(UInt32));
        }

        public static UInt32 ReadUInt32LE(this Stream stream)
        {
            var bytes = new byte[sizeof(UInt32)];
            stream.Read(bytes, 0, sizeof(UInt32));
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes);
            return BitConverter.ToUInt32(bytes, 0);
        }

        public static UInt32 ReadUInt32BE(this Stream stream)
        {
            var bytes = new byte[sizeof(UInt32)];
            stream.Read(bytes, 0, sizeof(UInt32));
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes);
            return BitConverter.ToUInt32(bytes, 0);
        }

        public static void WriteLE(this Stream stream, UInt32 value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes);
            stream.Write(bytes, 0, bytes.Length);
        }

        public static void WriteBE(this Stream stream, UInt32 value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes);
            stream.Write(bytes, 0, bytes.Length);
        }

        public static UInt64 ReadUInt64LE(this byte[] bytes, int offset)
        {
            var data = bytes.ReadBytes(offset, sizeof(UInt64));
            if (!BitConverter.IsLittleEndian) Array.Reverse(data);
            return BitConverter.ToUInt64(data, 0);
        }

        public static UInt64 ReadUInt64BE(this byte[] bytes, int offset)
        {
            var data = bytes.ReadBytes(offset, sizeof(UInt64));
            if (BitConverter.IsLittleEndian) Array.Reverse(data);
            return BitConverter.ToUInt64(data, 0);
        }

        public static void WriteLE(this byte[] bytes, int offset, UInt64 value)
        {
            BitConverter2.GetBytes(value, bytes, offset);
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes, offset, sizeof(UInt64));
        }

        public static void WriteBE(this byte[] bytes, int offset, UInt64 value)
        {
            BitConverter2.GetBytes(value, bytes, offset);
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes, offset, sizeof(UInt64));
        }

        public static UInt64 ReadUInt64LE(this Stream stream)
        {
            var bytes = new byte[sizeof(UInt64)];
            stream.Read(bytes, 0, sizeof(UInt64));
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes);
            return BitConverter.ToUInt64(bytes, 0);
        }

        public static UInt64 ReadUInt64BE(this Stream stream)
        {
            var bytes = new byte[sizeof(UInt64)];
            stream.Read(bytes, 0, sizeof(UInt64));
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes);
            return BitConverter.ToUInt64(bytes, 0);
        }

        public static void WriteLE(this Stream stream, UInt64 value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes);
            stream.Write(bytes, 0, bytes.Length);
        }

        public static void WriteBE(this Stream stream, UInt64 value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes);
            stream.Write(bytes, 0, bytes.Length);
        }

        public static Single ReadSingleLE(this byte[] bytes, int offset)
        {
            var data = bytes.ReadBytes(offset, sizeof(Single));
            if (!BitConverter.IsLittleEndian) Array.Reverse(data);
            return BitConverter.ToSingle(data, 0);
        }

        public static Single ReadSingleBE(this byte[] bytes, int offset)
        {
            var data = bytes.ReadBytes(offset, sizeof(Single));
            if (BitConverter.IsLittleEndian) Array.Reverse(data);
            return BitConverter.ToSingle(data, 0);
        }

        public static void WriteLE(this byte[] bytes, int offset, Single value)
        {
            BitConverter2.GetBytes(value, bytes, offset);
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes, offset, sizeof(Single));
        }

        public static void WriteBE(this byte[] bytes, int offset, Single value)
        {
            BitConverter2.GetBytes(value, bytes, offset);
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes, offset, sizeof(Single));
        }

        public static Single ReadSingleLE(this Stream stream)
        {
            var bytes = new byte[sizeof(Single)];
            stream.Read(bytes, 0, sizeof(Single));
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes);
            return BitConverter.ToSingle(bytes, 0);
        }

        public static Single ReadSingleBE(this Stream stream)
        {
            var bytes = new byte[sizeof(Single)];
            stream.Read(bytes, 0, sizeof(Single));
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes);
            return BitConverter.ToSingle(bytes, 0);
        }

        public static void WriteLE(this Stream stream, Single value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes);
            stream.Write(bytes, 0, bytes.Length);
        }

        public static void WriteBE(this Stream stream, Single value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes);
            stream.Write(bytes, 0, bytes.Length);
        }

        public static Double ReadDoubleLE(this byte[] bytes, int offset)
        {
            var data = bytes.ReadBytes(offset, sizeof(Double));
            if (!BitConverter.IsLittleEndian) Array.Reverse(data);
            return BitConverter.ToDouble(data, 0);
        }

        public static Double ReadDoubleBE(this byte[] bytes, int offset)
        {
            var data = bytes.ReadBytes(offset, sizeof(Double));
            if (BitConverter.IsLittleEndian) Array.Reverse(data);
            return BitConverter.ToDouble(data, 0);
        }

        public static void WriteLE(this byte[] bytes, int offset, Double value)
        {
            BitConverter2.GetBytes(value, bytes, offset);
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes, offset, sizeof(Double));
        }

        public static void WriteBE(this byte[] bytes, int offset, Double value)
        {
            BitConverter2.GetBytes(value, bytes, offset);
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes, offset, sizeof(Double));
        }

        public static Double ReadDoubleLE(this Stream stream)
        {
            var bytes = new byte[sizeof(Double)];
            stream.Read(bytes, 0, sizeof(Double));
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes);
            return BitConverter.ToDouble(bytes, 0);
        }

        public static Double ReadDoubleBE(this Stream stream)
        {
            var bytes = new byte[sizeof(Double)];
            stream.Read(bytes, 0, sizeof(Double));
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes);
            return BitConverter.ToDouble(bytes, 0);
        }

        public static void WriteLE(this Stream stream, Double value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (!BitConverter.IsLittleEndian) Array.Reverse(bytes);
            stream.Write(bytes, 0, bytes.Length);
        }

        public static void WriteBE(this Stream stream, Double value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian) Array.Reverse(bytes);
            stream.Write(bytes, 0, bytes.Length);
        }

    }

    public partial class BinaryReaderEndian
    {
        public override Int16 ReadInt16()
        {
            BaseStream.Read(m_buffer2, 0, sizeof(Int16));
            if (!m_nativeEndian) Array.Reverse(m_buffer2, 0, sizeof(Int16));
            return BitConverter.ToInt16(m_buffer2, 0);
        }

        public override Int32 ReadInt32()
        {
            BaseStream.Read(m_buffer2, 0, sizeof(Int32));
            if (!m_nativeEndian) Array.Reverse(m_buffer2, 0, sizeof(Int32));
            return BitConverter.ToInt32(m_buffer2, 0);
        }

        public override Int64 ReadInt64()
        {
            BaseStream.Read(m_buffer2, 0, sizeof(Int64));
            if (!m_nativeEndian) Array.Reverse(m_buffer2, 0, sizeof(Int64));
            return BitConverter.ToInt64(m_buffer2, 0);
        }

        public override UInt16 ReadUInt16()
        {
            BaseStream.Read(m_buffer2, 0, sizeof(UInt16));
            if (!m_nativeEndian) Array.Reverse(m_buffer2, 0, sizeof(UInt16));
            return BitConverter.ToUInt16(m_buffer2, 0);
        }

        public override UInt32 ReadUInt32()
        {
            BaseStream.Read(m_buffer2, 0, sizeof(UInt32));
            if (!m_nativeEndian) Array.Reverse(m_buffer2, 0, sizeof(UInt32));
            return BitConverter.ToUInt32(m_buffer2, 0);
        }

        public override UInt64 ReadUInt64()
        {
            BaseStream.Read(m_buffer2, 0, sizeof(UInt64));
            if (!m_nativeEndian) Array.Reverse(m_buffer2, 0, sizeof(UInt64));
            return BitConverter.ToUInt64(m_buffer2, 0);
        }

        public override Single ReadSingle()
        {
            BaseStream.Read(m_buffer2, 0, sizeof(Single));
            if (!m_nativeEndian) Array.Reverse(m_buffer2, 0, sizeof(Single));
            return BitConverter.ToSingle(m_buffer2, 0);
        }

        public override Double ReadDouble()
        {
            BaseStream.Read(m_buffer2, 0, sizeof(Double));
            if (!m_nativeEndian) Array.Reverse(m_buffer2, 0, sizeof(Double));
            return BitConverter.ToDouble(m_buffer2, 0);
        }

    }

    public partial class BinaryWriterEndian
    {
        public override void Write(Int16 value)
        {
            BitConverter2.GetBytes(value, m_buffer2, 0);
            if (!m_nativeEndian) Array.Reverse(m_buffer2, 0, sizeof(Int16));
            BaseStream.Write(m_buffer2, 0, sizeof(Int16));
        }
        public override void Write(Int32 value)
        {
            BitConverter2.GetBytes(value, m_buffer2, 0);
            if (!m_nativeEndian) Array.Reverse(m_buffer2, 0, sizeof(Int32));
            BaseStream.Write(m_buffer2, 0, sizeof(Int32));
        }
        public override void Write(Int64 value)
        {
            BitConverter2.GetBytes(value, m_buffer2, 0);
            if (!m_nativeEndian) Array.Reverse(m_buffer2, 0, sizeof(Int64));
            BaseStream.Write(m_buffer2, 0, sizeof(Int64));
        }
        public override void Write(UInt16 value)
        {
            BitConverter2.GetBytes(value, m_buffer2, 0);
            if (!m_nativeEndian) Array.Reverse(m_buffer2, 0, sizeof(UInt16));
            BaseStream.Write(m_buffer2, 0, sizeof(UInt16));
        }
        public override void Write(UInt32 value)
        {
            BitConverter2.GetBytes(value, m_buffer2, 0);
            if (!m_nativeEndian) Array.Reverse(m_buffer2, 0, sizeof(UInt32));
            BaseStream.Write(m_buffer2, 0, sizeof(UInt32));
        }
        public override void Write(UInt64 value)
        {
            BitConverter2.GetBytes(value, m_buffer2, 0);
            if (!m_nativeEndian) Array.Reverse(m_buffer2, 0, sizeof(UInt64));
            BaseStream.Write(m_buffer2, 0, sizeof(UInt64));
        }
        public override void Write(Single value)
        {
            BitConverter2.GetBytes(value, m_buffer2, 0);
            if (!m_nativeEndian) Array.Reverse(m_buffer2, 0, sizeof(Single));
            BaseStream.Write(m_buffer2, 0, sizeof(Single));
        }
        public override void Write(Double value)
        {
            BitConverter2.GetBytes(value, m_buffer2, 0);
            if (!m_nativeEndian) Array.Reverse(m_buffer2, 0, sizeof(Double));
            BaseStream.Write(m_buffer2, 0, sizeof(Double));
        }
    }
}