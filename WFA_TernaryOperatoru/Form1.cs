using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TernaryOperatoru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //TERNARY OPERATORU
        //Tek satirda ufak bir karar mekanizmasi ile yolunuza devam etmek istiyorsaniz,
        //soru isareti operatoru size bu pratikligi saglar. Yazim formati;
        // kontrolEdilecekDeger (KarsilastirmaOperatoru) ? Durumun Olumlu Olma Durumu : "Durumun Olumsuz Olma Durumu;

        private void Button1_Click(object sender, EventArgs e)
        {
            string deger = textBox1.Text;

            this.Text = deger == "bilge adam" ? "Girilen Değer Bilge Adam" : "Kullanıcı Farklı Bir Değer Girdi";

            //MessageBox.Show(deger == "bilge adam" ? "Girilen Değer Bilge Adam" : "Kullanıcı Farklı Bir Değer Girdi");

            // Eğer kullanıcı bir değer girerse mb içerisinde p değeri gösteriniz. girmezde default bir değer gösteriniz.!!!




            MessageBox.Show(string.IsNullOrWhiteSpace(textBox1.Text) ? "Default değer" : textBox1.Text);
            MessageBox.Show(textBox1.Text.Length > 0 ? textBox1.Text : "default bir değer");
            MessageBox.Show(textBox1.Text != "" ? textBox1.Text : "default değer");
         
            

        }
    }
}
