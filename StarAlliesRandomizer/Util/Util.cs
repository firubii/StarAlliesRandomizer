using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crc32C;

namespace StarAlliesRandomizer.Util
{

    public enum Endianness
    {
        Big,
        Little
    }

    // From https://stackoverflow.com/questions/1440392/use-byte-as-key-in-dictionary
    public class ByteArrayComparer : EqualityComparer<byte[]>
    {
        public static bool Equal(byte[] left, byte[] right)
        {
            return new ByteArrayComparer().Equals(left, right);
        }

        public override bool Equals(byte[] left, byte[] right)
        {
            if (left == null || right == null)
            {
                return left == right;
            }
            if (left.Length != right.Length)
            {
                return false;
            }
            for (int i = 0; i < left.Length; i++)
            {
                if (left[i] != right[i])
                {
                    return false;
                }
            }
            return true;
        }
        public override int GetHashCode(byte[] key)
        {
            if (key == null)
                throw new ArgumentNullException("key");
            int sum = 0;
            foreach (byte cur in key)
            {
                sum += cur;
            }
            return sum;
        }
    }

    public static class HashCalculator
    {
        public static byte[] Calculate(string str)
        {
            byte[] hash;
            Crc32CAlgorithm crc = new Crc32CAlgorithm();
            hash = crc.ComputeHash(Encoding.UTF8.GetBytes(str));
            //Invert the hash, since Hal does that for some reason
            for (int i = 0; i < hash.Length; i++)
                hash[i] = (byte)(255 - hash[i]);
            return hash;
        }
    }

    public static class ReadUtil
    {
        public static string ReadString(EndianBinaryReader reader)
        {
            uint offset = reader.ReadUInt32();
            long pos = reader.BaseStream.Position;

            reader.BaseStream.Seek(offset, SeekOrigin.Begin);
            string str = Encoding.UTF8.GetString(reader.ReadBytes(reader.ReadInt32()));
            reader.BaseStream.Seek(pos, SeekOrigin.Begin);

            return str;
        }
    }

    public static class WriteUtil
    {
        public static void WriteString(EndianBinaryWriter writer, string str)
        {
            writer.Write(str.Length);
            writer.Write(Encoding.UTF8.GetBytes(str));
            writer.Write(0);
            while ((writer.BaseStream.Length & 0xF) != 0x0
                && (writer.BaseStream.Length & 0xF) != 0x4
                && (writer.BaseStream.Length & 0xF) != 0x8
                && (writer.BaseStream.Length & 0xF) != 0xC)
                writer.Write((byte)0);
        }
    }
}
