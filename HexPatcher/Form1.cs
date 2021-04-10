using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexPatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream outStream = File.Open("libil2cpp.so", FileMode.Open);
            outStream.Seek(0x100000, SeekOrigin.Begin);
            outStream.WriteByte(0x1E);
            outStream.WriteByte(0xFF);
            outStream.WriteByte(0x2F);
            outStream.WriteByte(0xE1);

            outStream.Seek(0x123456, SeekOrigin.Begin);
            outStream.WriteByte(0x00);
            outStream.WriteByte(0x00);
            outStream.WriteByte(0xA0);
            outStream.WriteByte(0xE3);
            outStream.WriteByte(0x1E);
            outStream.WriteByte(0xFF);
            outStream.WriteByte(0x2F);
            outStream.WriteByte(0xE1);
            outStream.Close();
        }
    }
}
