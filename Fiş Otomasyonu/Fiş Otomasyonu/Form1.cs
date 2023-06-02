

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace Fiş_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {


                var image = new Bitmap(openFileDialog1.FileName);
                var ocr = new TesseractEngine("./tessdata","tur");
                       
               /* var ocr = new TesseractEngine("./tessdata", "tur");*/
                var sonuc = ocr.Process(image).GetText();
                richTextBox1.Text = sonuc;

                txtBox_shopping_name.Text = matchShopName(sonuc);
                txtBox_total.Text = matchTotal(sonuc);
                txtBox_depart_no.Text = matchTaxDepartNo(sonuc);
                txtBox_Date.Text = matchDate(sonuc);
            }
        }
        string matchDate(string txt)
        {
            string pattern = @"(\d{1,2})[\/.](\d{1,2})[\/.](\d{2,4})";
            MatchCollection match = Regex.Matches(txt, pattern);

            if (match.Count > 0)
            {
                return match[0].Value;
            }
            else
            {
                return "Tarih bulunamadı.";
            }
        }
        string matchShopName(string txt)
        {

            string pattern = @"[\p{L}\p{N}]+";
            MatchCollection match = Regex.Matches(txt, pattern);
            if (match.Count > 0)
            {
                return match[0].Value;
            }
            else
            {
                return "Mağaza Adı bulunamadı.";
            }

            
              
           
        }
        string matchTotal(string txt)
        {
            string pattern = @"\b(?:tutarı|toplam[^\d]*|toplam tutar[^\d]*):\s*([\d.,]+)\s*(?:TL)?\b";
            MatchCollection match = Regex.Matches(txt, pattern);
            if (match.Count>0)
            {
                return match[0].Value;
            }
            else
            {
                return "Toplam tutar bulunamadı.";
            }



        }
        string matchTaxDepartNo(string txt)
        {
            

            string pattern = @"\b\d{10,11}\b";
            MatchCollection match = Regex.Matches(txt, pattern);

            if (match.Count > 0)
            {
                return match[0].Value;
            }
            else
            {
                return "Vergi No bulunamadı.";
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
