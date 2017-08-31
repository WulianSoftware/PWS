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
namespace 進銷
{
   
    public partial class 主頁面 : Form
    {
        
        Class1 OT = new Class1();
        string file = Application.StartupPath.ToString().Replace(@"\bin\Debug", "").Replace(@"\app.publish", "");
        public int time1=0;
        public int time2=5;
        public 主頁面()
        {
            InitializeComponent();
            Closing += new CancelEventHandler(主頁面_Closing);
        }
        private void 主頁面_Closing(object sender, CancelEventArgs e)
        {
            DialogResult dt = new DialogResult();

            dt = MessageBox.Show(this, "確定關閉？", "關閉視窗通知", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
            
        //    panel2.Controls.Clear();
        //    PSWE.出貨管理系統.type = "E";
        //    PSWE.出貨管理系統 F1 = new PSWE.出貨管理系統();
        //    F1.MdiParent = this;            
        //    panel2.Controls.Add(F1);
        //    F1.Show();
        //    panel1.BackColor = Color.Red;
        //    label1.Text = "出貨管理系統";
            
        //    timer3.Enabled = true;
        //}
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    panel2.Controls.Clear();
        //    進貨管理系統.type = "I";
        //    進貨管理系統 F2 = new 進貨管理系統();
        //    F2.MdiParent = this;            
        //    panel2.Controls.Add(F2);
        //    F2.Show();
        //    panel1.BackColor = Color.PowderBlue;
        //    timer3.Enabled = true;
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    panel2.Controls.Clear();
        //    WindowsFormsApplication5.報價單 F3 = new WindowsFormsApplication5.報價單();
        //    F3.MdiParent = this;
        //    panel2.Controls.Add(F3);
        //    F3.Show();
        //    panel1.BackColor = Color.Plum;
        //    timer3.Enabled = true;
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    panel2.Controls.Clear();
        //    psw.AR_mainpage F1 = new psw.AR_mainpage();
        //    F1.MdiParent = this;
        //    panel2.Controls.Add(F1);
        //    F1.Show();
        //    panel1.BackColor = Color.Purple;
        //    timer3.Enabled = true;
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    panel2.Controls.Clear();
        //    AP.AP_mainpage F1 = new AP.AP_mainpage();
        //    F1.MdiParent = this;
        //    panel2.Controls.Add(F1);
        //    F1.Show();
        //    panel1.BackColor = Color.PaleVioletRed;
        //    timer3.Enabled = true;
        //}

        //private void button9_Click(object sender, EventArgs e)
        //{
        //    panel2.Controls.Clear();
        //    PSW1.Product F8 = new PSW1.Product();
        //    F8.MdiParent = this;
        //    panel2.Controls.Add(F8);
        //    F8.Show();
        //    timer3.Enabled = true;
        //}

        

        //public void timer1_Tick(object sender, EventArgs e)
        //{
        //    time1++;
        //    string Date = "";
        //    string Today = DateTime.Today.ToShortDateString();
        //        if (time1 == 1)
        //        {
        //        StreamReader sr = new StreamReader(file+@"\Date.txt");
        //        Date = sr.ReadLine();
        //        sr.Close();
        //        if (Today == Date)
        //        {
                   
        //        }
        //        else
        //        {
                    
        //            StreamWriter sw = new StreamWriter(file+@"\Date.txt");
        //            sw.Write(Today);
        //            sw.Close();
        //            sw = new StreamWriter(file+@"\E流水號.txt");
        //            sw.Write(1);
        //            sw.Close();
        //            sw = new StreamWriter(file + @"\I流水號.txt");
        //            sw.Write(1);
        //            sw.Close();
        //        }
        //        timer1.Enabled = false;
                
        //    }
        //}

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    panel2.Controls.Clear();
        //    WindowsFormsApplication1.PAR_mainpage F5= new WindowsFormsApplication1.PAR_mainpage();
        //    F5.MdiParent = this;
        //    panel2.Controls.Add(F5);
        //    F5.Show();
        //    panel1.BackColor = Color.SeaGreen;
        //    timer3.Enabled = true;
        //}
        
        //private void timer2_Tick(object sender, EventArgs e)
        //{
            
        //    PSWE.出貨管理系統 F1 = new PSWE.出貨管理系統();
        //    if (F1.toolStripStatusLabel1.Text.IndexOf("成功") != -1)
        //    {
        //        time2++;
        //        if (time2 == 5)
        //        {
        //            F1.toolStripStatusLabel1.Text = F1.toolStripStatusLabel1.Text.Replace("新增成功", "");
        //            F1.toolStripStatusLabel1.Text = F1.toolStripStatusLabel1.Text.Replace("修改成功", "");
        //            F1.toolStripStatusLabel1.Text = F1.toolStripStatusLabel1.Text.Replace("刪除成功", "");
        //            timer2.Enabled = false;
        //        }               
        //    }
                    
        //}

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    panel2.Controls.Clear();
        //    PSW1.Company_Info F6 = new PSW1.Company_Info();
        //    F6.MdiParent = this;
        //    panel2.Controls.Add(F6);
        //    F6.Show();
        //    panel1.BackColor = Color.SeaGreen;
        //    timer3.Enabled = true;
        //}

        //private void button8_Click(object sender, EventArgs e)
        //{
        //    panel2.Controls.Clear();
        //    PSW1.Personnel F7 = new PSW1.Personnel();
        //    F7.MdiParent = this;
        //    panel2.Controls.Add(F7);
        //    F7.Show();
        //    timer3.Enabled = true;
        //}

        //private void timer3_Tick(object sender, EventArgs e)
        //{

        //    PSW1.Company_Info_SelCF.selvalue = "";
        //    PSW1.Personnel_Sel.SerNo = "";
        //    PSWE.出貨商品查詢.SerNo = "";
        //    PSWE.出貨查詢.SerNo = "";
        //    PSWE.出貨客戶查詢.SerNo = "";
        //    進貨商品查詢.SerNo = "";
        //    進貨客戶查詢.SerNo = "";
        //    進貨查詢.SerNo = "";
        //    timer3.Enabled = false;
        //}
    }
}
