using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Linq;
using System.IO;

namespace Clipper01
{
    public partial class Form1 : Form
    {
        XDocument doc;
        DirectoryInfo di;


        public Form1()
        {
            InitializeComponent();
            di = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

            listView1.View = View.Details;
            listView1.GridLines = true;

            listView1.Columns.Add("Title");
            listView1.Columns[0].Width = 90;
            listView1.Columns.Add("Body");
            listView1.Columns[1].Width = 180;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                doc = XDocument.Load(di.FullName + "\\Clippings");
                button1.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
            }
            catch (Exception aException)
            {
                MessageBox.Show(aException.Message, "Load XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IEnumerable<XElement> clippings = doc.Elements();
            foreach (XElement aClippings in clippings.Elements())
            {

            }
        }
    }
}
