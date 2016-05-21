using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Reflection
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet("libro");
            dataSet.ReadXml("sample.xml");

            DataRow row = dataSet.Tables["book"].Rows[0];

            // Reflection
            Type bookType = typeof(Book);
            object[] arguments = new object[] { typeof(string), typeof(string), typeof(string), typeof(string) };

            Book result = Activator.CreateInstance(bookType, row.ItemArray) as Book;


            Console.WriteLine("Tablas: {0}", result.Title);

            dataSet.Dispose();
        }
    }
}
