using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using System.Windows.Forms;

namespace _1706020012_ThachHuynhDung
{
    public partial class Form1 : Form
    {
        ClsPhong Phong = new ClsPhong();

        List<ClsPhong> dsPhong = new List<ClsPhong>();
        BindingList<ClsPhong> bindingList;
        BindingSource source;
        public Form1()
        {
            InitializeComponent();
            bindingList = new BindingList<ClsPhong>(dsPhong);
            source = new BindingSource(bindingList, null);
            DgPhong.DataSource = source;
        }
        public void ClearData()
        {
            Maphong.Text = "";
            Tenphong.Text = "";
            Sogiuong.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Phong.Maphong = int.Parse(Maphong.Text.ToString());
            Phong.Tenphong = Tenphong.Text;
            Phong.Sogiuong = int.Parse(Sogiuong.Text.ToString());
            source.Add(Phong);
            Phong = new ClsPhong();
            ClearData();
            DgPhong.Refresh();
        }

        private void Dongia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Phong.Dongia = double.Parse(Dongia.Text.ToString());
            }
            catch
            { }
        }

        private void Trangthai_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                ClsPhong currentNhanvien = (ClsPhong)source[DgPhong.CurrentRowIndex];
                source.RemoveAt(DgPhong.CurrentRowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Edit_Click(object sender, EventArgs e)
        {

            Phong.Tenphong = Tenphong.Text;
            //source.Add(Phong);
            source[DgPhong.CurrentRowIndex] = Phong;
            Phong = new ClsPhong();
            ClearData();
            DgPhong.Refresh();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Json Files|*.json|All Files|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string sFileName = save.FileName;
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                var json = serializer.Serialize(Phong);
                StreamWriter writer;
                writer = new StreamWriter(sFileName);
                writer.Write(json);
                writer.Close();
                MessageBox.Show("Saved !");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Phong.Ma_Trangthai = 0;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                Phong.Ma_Trangthai = 1;
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Json Files|*.json|All Files|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string sFileName = open.FileName;
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                StreamReader reader = new StreamReader(sFileName);
                string json = reader.ReadToEnd();
                reader.Close();
                var deserializeObject = serializer.Deserialize<List<ClsPhong>>(json);
                source.Clear();
                foreach (var element in deserializeObject)
                {
                    source.Add(element);
                }
                MessageBox.Show("Load OK !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(dsPhong.Count == 0)
            {
                MessageBox.Show("No Data");
            }
           else
            {
                List<ClsPhong> Lietke = new List<ClsPhong>();
                foreach(var ele in dsPhong)
                {
                    if(ele.Ma_Trangthai == 0)
                    {
                        Lietke.Add(ele);
                    }
                }
                BindingList<ClsPhong> BlistLietke = new BindingList<ClsPhong>(Lietke);
                BindingSource sourceLietke = new BindingSource(BlistLietke, null);
                DgPhong.DataSource = sourceLietke;
            }
        }

        private void Tinhtong_Click(object sender, EventArgs e)
        {
            
        }
    }
}
