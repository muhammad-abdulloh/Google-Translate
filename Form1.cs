using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Google_Translate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    
        //    WebClient webClient = new WebClient();
        //    webClient.Encoding = Encoding.UTF8;
        //    try
        //    {
        //        string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", textBox1.Text, comboBox1.Text + "|" + comboBox2.Text);
        //        string result = webClient.DownloadString(url);
        //        result = result.Substring(result.IndexOf("<span title=\">") + "<span title=\">".Length);
        //        result = result.Substring(result.IndexOf(">") + 1);
        //        result = result.Substring(0, result.IndexOf("</span>"));
        //        textBox2.Text = result.Trim();

        //        //int bas = result.IndexOf("TRANSLATED_TEXT='") + "TRANSLATED_TEXT='".Length;
        //        //int bit = result.Substring(bas).IndexOf("';var");
        //        //result = result.Substring(bas, bit);
        //        //textBox2.Text = result.Trim();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    
        //}
        */

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {


            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;

            
            
            try
            {
                string url = string.Format("https://mytransapi.pythonanywhere.com/api/v1/get-only-text/{0}/{1}/?text={2}",
                    comboBox1.Text.Trim(), comboBox2.Text.Trim(), textBox1.Text.Trim());
                //string result = webClient.DownloadString(url);

                HttpClient client = new HttpClient();
                string res = client.GetStringAsync(url).Result;
                
                textBox2.Text = res.Trim();

                MessageBox.Show(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("sda");
            }
        }


    }
}





































/*//result = result.Substring(result.IndexOf("<span title=\"") + "<span title=\"".Length);
                //result = result.Substring(result.IndexOf(">") + 1);
                //result = result.Substring(0, result.IndexOf("</span>"));
                //textBox2.Text = result.Trim();

                //res = res.Substring(res.IndexOf("<span title=\"") + "<span title=\"".Length);
                //res = res.Substring(res.IndexOf(">") + 1);
                //res = res.Substring(0, res.IndexOf("</span>"));*/