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
namespace Quanlisothu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblthoigian.Text = String.Format("Bây giờ là {0}:{1}:{2:} ngày {3} tháng {4} năm {5}",
                                           DateTime.Now.Hour,
                                           DateTime.Now.Minute,
                                           DateTime.Now.Second,
                                           DateTime.Now.Day,
                                           DateTime.Now.Month,
                                           DateTime.Now.Year);
        }

        private void mnuLoad_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("Thumoi.txt");
            if (reader == null) return;
            string input = null;
            while ((input=reader.ReadLine())!=null)
            {
                lstThumoi.Items.Add(input);
            }
            reader.Close();

            using (StreamReader rs = new StreamReader("Danhsachthu.txt"))
            {
            input=null;
            while ((input= rs.ReadLine())!=null)
            {
                lstDanhsach.Items.Add(input);
            }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("Danhsachthu.txt");

            if (writer == null) return;

            foreach (var item in lstDanhsach.Items)
                writer.WriteLine(item.ToString());

                writer.Close();
        }
        private void ListBox_MouseDown(object sender,MouseEventArgs e)
        {
            ListBox lb=(ListBox)sender;
            int index = lb.IndexFromPoint(e.X, e.Y);

            lb.DoDragDrop(lb.Items[index].ToString(), DragDropEffects.Copy);
        }
        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) 
               e.Effect = DragDropEffects.Copy;
            else
               e.Effect = DragDropEffects.Move;
        }
    }
    }

 