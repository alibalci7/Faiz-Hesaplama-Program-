using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faiz_Hesaplama_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_faiz.Text = "Yıllık %";
            cmb_vade.Text = "Yıl";
            cmb_donem.Text = "Yıl";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToSingle(txt_Anapara.Text) > 0)
            {
                if (rd_Gelecek.Checked)
                    GelecekParaHesapla();
                if (rd_Simdi.Checked)
                    SimdikiParaHesapla();
            }
            else
            {
                MessageBox.Show("Anapara 0'dan büyük olmalıdır.");
            }

        }

        void SimdikiParaHesapla()
        {
            switch (cmb_vade.Text)
            {
                case "Yıl":
                    SimdikiPara_Yillik();
                    break;
                case "Ay":
                    SimdikiPara_Aylik();
                    break;
                case "Gün":
                    SimdikiPara_Gunluk();
                    break;
                default:
                    break;
            }
        }

        void GelecekParaHesapla()
        {
            switch (cmb_vade.Text)
            {
                case "Yıl":
                    FaizHesabi_Yillik();
                    break;
                case "Ay":
                    FaizHesabı_Aylik();
                    break;
                case "Gün":
                    FaizHesabı_Gunluk();
                    break;
                default:
                    break;
            }
        }

        float FaizHesabı(float faiz)
        {
            switch (cmb_faiz.Text)
            {
                case "Yıllık %":
                    switch (cmb_donem.Text)
                    {
                        case "Ay":
                            faiz /= 12;
                            break;
                        case "Gün":
                            if (rd_365.Checked)
                                faiz /= 365;
                            if (rd_360.Checked)
                                faiz /= 360;
                            break;
                    }
                    break;
                case "Aylık %":
                    switch (cmb_donem.Text)
                    {
                        case "Yıl":
                            faiz *= 12;
                            break;
                        case "Gün":
                            if (rd_365.Checked)
                                faiz /= 30;
                            if (rd_360.Checked)
                                faiz /= 30;
                            break;
                    }
                    break;
                case "Günlük %":
                    switch (cmb_donem.Text)
                    {
                        case "Yıl":
                            if (rd_365.Checked)
                                faiz *= 365;
                            if (rd_360.Checked)
                                faiz *= 360;
                            break;
                        case "Ay":
                            faiz *= 30;
                            break;
                    }
                    break;
            }
            return faiz;
        }

        void FaizHesabi_Yillik()
        {
            float anapara = Convert.ToSingle(txt_Anapara.Text);
            float faiz = Convert.ToSingle(txt_faiz.Text);
            faiz /= 100;
            float vade = Convert.ToSingle(txt_vade.Text);
            float donem = Convert.ToSingle(txt_donem.Text);
            float faizlipara = 0;
            float sayi = 1;

            faiz = FaizHesabı(faiz);

            switch (cmb_donem.Text)
            {
                case "Yıl":
                    if (vade < donem)
                    {
                        MessageBox.Show("Vade süresi donem süresinden küçük olamaz.");
                    }
                    else if (donem == 1)
                    {
                        while (vade > 0)
                        {
                            sayi *= (1 + faiz);
                            vade--;
                        }
                        faizlipara = anapara * sayi;
                        MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                    }
                    else if (donem == vade)
                    {
                        faizlipara = anapara + (anapara * faiz * vade);
                        MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                    }
                    else if (vade % donem == 0)
                    {
                        float tekrar = vade / donem;
                        faizlipara = anapara;
                        while (tekrar > 0)
                        {
                            faizlipara += (faizlipara * faiz * donem);
                            tekrar--;
                        }
                        MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Vade süresi hesap donemleri süresinin katlarından olmalıdır.");
                    }

                    break;
                case "Ay":
                    if ((vade * 12) < donem)
                    {
                        MessageBox.Show("Vade süresi donem süresinden küçük olamaz.");
                    }
                    else if (donem == 12)
                    {
                        faiz = Convert.ToSingle(txt_faiz.Text);
                        faiz /= 100;
                        while (vade > 0)
                        {
                            sayi *= (1 + faiz);
                            vade--;
                        }
                        faizlipara = anapara * sayi;
                        MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                    }
                    else if (donem == (vade * 12))
                    {
                        faizlipara = anapara + (anapara * faiz * donem);
                        MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                    }
                    else if ((vade * 12) % donem == 0)
                    {
                        float tekrar = (vade * 12) / donem;
                        faizlipara = anapara;
                        while (tekrar > 0)
                        {
                            faizlipara += (faizlipara * faiz * donem);
                            tekrar--;
                        }
                        MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Vade süresi hesap donemleri süresinin katlarından olmalıdır.");
                    }

                    break;
                case "Gün":
                    if (rd_360.Checked)
                    {
                        if ((vade * 360) < donem)
                        {
                            MessageBox.Show("Vade süresi donem süresinden küçük olamaz.");
                        }
                        else if (donem == 360)
                        {
                            faiz = Convert.ToSingle(txt_faiz.Text);
                            faiz /= 100;
                            while (vade > 0)
                            {
                                sayi *= (1 + faiz);
                                vade--;
                            }
                            faizlipara = anapara * sayi;
                            MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                        }
                        else if (donem == (vade * 360))
                        {
                            faizlipara = anapara + (anapara * faiz * donem);
                            MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                        }
                        else if ((vade * 360) % donem == 0)
                        {
                            float tekrar = (vade * 360) / donem;
                            faizlipara = anapara;
                            while (tekrar > 0)
                            {
                                faizlipara += (faizlipara * (faiz) * donem);
                                tekrar--;
                            }
                            MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Vade süresi hesap donemleri süresinin katlarından olmalıdır.");
                        }
                    }
                    if (rd_365.Checked)
                    {
                        if ((vade * 365) < donem)
                        {
                            MessageBox.Show("Vade süresi donem süresinden küçük olamaz.");
                        }
                        else if (donem == 365)
                        {
                            vade *= 365;
                            while (vade > 0)
                            {
                                sayi *= (1 + faiz);
                                vade--;
                            }
                            faizlipara = anapara * sayi;
                            MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                        }
                        else if (donem == (vade * 365))
                        {
                            faizlipara = anapara + (anapara * faiz * donem);
                            MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                        }
                        else if ((vade * 365) % donem == 0)
                        {
                            float tekrar = (vade * 365) / donem;
                            faizlipara = anapara;
                            while (tekrar > 0)
                            {
                                faizlipara += (faizlipara * faiz * donem);
                                tekrar--;
                            }
                            MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Vade süresi hesap donemleri süresinin katlarından olmalıdır.");
                        }
                    }
                    break;
            }
        }

        void FaizHesabı_Aylik()
        {
            float anapara = Convert.ToSingle(txt_Anapara.Text);
            float faiz = Convert.ToSingle(txt_faiz.Text);
            faiz /= 100;
            float vade = Convert.ToSingle(txt_vade.Text);
            float donem = Convert.ToSingle(txt_donem.Text);
            float faizlipara = 0;
            float sayi = 1;

            faiz = FaizHesabı(faiz);

            switch (cmb_donem.Text)
            {
                case "Yıl":
                    MessageBox.Show("Vade aylık iken donem yıllık seçilemez.");
                    break;
                case "Ay":
                    if (vade < donem)
                    {
                        MessageBox.Show("Vade süresi donem süresinden küçük olamaz.");
                    }
                    else if (donem == 12)
                    {
                        faiz = Convert.ToSingle(txt_faiz.Text);
                        faiz /= 100;
                        vade /= 12;
                        while (vade > 0)
                        {
                            sayi *= (1 + faiz);
                            vade--;
                        }
                        faizlipara = anapara * sayi;
                        MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                    }
                    else if (donem == vade)
                    {
                        faizlipara = anapara + (anapara * faiz * vade);
                        MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                    }
                    else if (vade % donem == 0)
                    {
                        float tekrar = vade / donem;
                        faizlipara = anapara;
                        while (tekrar > 0)
                        {
                            faizlipara += (faizlipara * faiz * donem);
                            tekrar--;
                        }
                        MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Vade süresi hesap donemleri süresinin katlarından olmalıdır.");
                    }

                    break;
                case "Gün":
                    if (rd_360.Checked)
                    {
                        if ((vade * 30) < donem)
                        {
                            MessageBox.Show("Vade süresi donem süresinden küçük olamaz.");
                        }
                        else if (donem == 30)
                        {
                            vade *= 30;
                            while (vade > 0)
                            {
                                sayi *= (1 + faiz);
                                vade--;
                            }
                            faizlipara = anapara * sayi;
                            MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                        }
                        else if (donem == (vade * 30))
                        {
                            faizlipara = anapara + (anapara * faiz * vade);
                            MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                        }
                        else if ((vade * 30) % donem == 0)
                        {
                            float tekrar = (vade * 30) / donem;
                            faizlipara = anapara;
                            while (tekrar > 0)
                            {
                                faizlipara += (faizlipara * faiz * donem);
                                tekrar--;
                            }
                            MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Vade süresi hesap donemleri süresinin katlarından olmalıdır.");
                        }
                    }
                    if (rd_365.Checked)
                    {
                        if ((vade * 30) < donem)
                        {
                            MessageBox.Show("Vade süresi donem süresinden küçük olamaz.");
                        }
                        else if (donem == 30)
                        {
                            vade *= 30;
                            while (vade > 0)
                            {
                                sayi *= (1 + faiz);
                                vade--;
                            }
                            faizlipara = anapara * sayi;
                            MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                        }
                        else if (donem == (vade * 30))
                        {
                            faizlipara = anapara + (anapara * faiz * vade);
                            MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                        }
                        else if ((vade * 30) % donem == 0)
                        {
                            float tekrar = (vade * 30) / donem;
                            faizlipara = anapara;
                            while (tekrar > 0)
                            {
                                faizlipara += (faizlipara * faiz * donem);
                                tekrar--;
                            }
                            MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Vade süresi hesap donemleri süresinin katlarından olmalıdır.");
                        }
                    }
                    break;
            }
        }

        void FaizHesabı_Gunluk()
        {
            float anapara = Convert.ToSingle(txt_Anapara.Text);
            float faiz = Convert.ToSingle(txt_faiz.Text);
            faiz /= 100;
            float vade = Convert.ToSingle(txt_vade.Text);
            float donem = Convert.ToSingle(txt_donem.Text);
            float faizlipara = 0;
            float sayi = 1;

            faiz = FaizHesabı(faiz);

            switch (cmb_donem.Text)
            {
                case "Yıl":
                    MessageBox.Show("Vade günlük iken donem yıllık seçilemez.");
                    break;
                case "Ay":
                    MessageBox.Show("Vade günlük iken donem aylık seçilemez.");

                    break;
                case "Gün":
                    if (rd_360.Checked)
                    {
                        if (vade < donem)
                        {
                            MessageBox.Show("Vade süresi donem süresinden küçük olamaz.");
                        }
                        else if (donem == 1)
                        {
                            while (vade > 0)
                            {
                                sayi *= (1 + faiz);
                                vade--;
                            }
                            faizlipara = anapara * sayi;
                            MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                        }
                        else if (donem == vade)
                        {
                            faizlipara = anapara + (anapara * faiz * vade);
                            MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                        }
                        else if (vade % donem == 0)
                        {
                            float tekrar = vade / donem;
                            faizlipara = anapara;
                            while (tekrar > 0)
                            {
                                faizlipara += (faizlipara * faiz * donem);
                                tekrar--;
                            }
                            MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Vade süresi hesap donemleri süresinin katlarından olmalıdır.");
                        }
                    }
                    if (rd_365.Checked)
                    {
                        if (vade < donem)
                        {
                            MessageBox.Show("Vade süresi donem süresinden küçük olamaz.");
                        }
                        else if (donem == 1)
                        {
                            while (vade > 0)
                            {
                                sayi *= (1 + faiz);
                                vade--;
                            }
                            faizlipara = anapara * sayi;
                            MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                        }
                        else if (donem == vade)
                        {
                            faizlipara = anapara + (anapara * faiz * vade);
                            MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                        }
                        else if (vade % donem == 0)
                        {
                            float tekrar = vade / donem;
                            faizlipara = anapara;
                            while (tekrar > 0)
                            {
                                faizlipara += (faizlipara * faiz * donem);
                                tekrar--;
                            }
                            MessageBox.Show("Faizi ile birlikte toplam paranız: " + faizlipara.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Vade süresi hesap donemleri süresinin katlarından olmalıdır.");
                        }
                    }
                    break;
            }
        }

        void SimdikiPara_Yillik()
        {
            float anapara = 0;
            float faiz = Convert.ToSingle(txt_faiz.Text);
            faiz /= 100;
            float vade = Convert.ToSingle(txt_vade.Text);
            float donem = Convert.ToSingle(txt_donem.Text);
            float faizlipara = Convert.ToSingle(txt_Anapara.Text);
            float sayi = 1;

            faiz = FaizHesabı(faiz);

            switch (cmb_donem.Text)
            {
                case "Yıl":
                    if (vade < donem)
                    {
                        MessageBox.Show("Vade süresi donem süresinden küçük olamaz.");
                    }
                    else if (donem == 1)
                    {
                        while (vade > 0)
                        {
                            sayi *= (1 + faiz);
                            vade--;
                        }
                        anapara = faizlipara / sayi;
                        MessageBox.Show("Anaparanız: " + anapara.ToString());
                    }
                    else if (donem == vade)
                    {
                        anapara = faizlipara / (1 + (faiz * vade));
                        MessageBox.Show("Anaparanız: " + anapara.ToString());
                    }
                    else if (vade % donem == 0)
                    {
                        float tekrar = vade / donem;
                        anapara = faizlipara;
                        while (tekrar > 0)
                        {
                            anapara /= (1 + (faiz * donem));
                            tekrar--;
                        }
                        MessageBox.Show("Anaparanız: " + anapara.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Vade süresi hesap donemleri süresinin katlarından olmalıdır.");
                    }

                    break;
                case "Ay":
                    if ((vade * 12) < donem)
                    {
                        MessageBox.Show("Vade süresi donem süresinden küçük olamaz.");
                    }
                    else if (donem == 12)
                    {
                        faiz = Convert.ToSingle(txt_faiz.Text);
                        faiz /= 100;
                        while (vade > 0)
                        {
                            sayi *= (1 + faiz);
                            vade--;
                        }
                        anapara = faizlipara / sayi;
                        MessageBox.Show("Anaparanız: " + anapara.ToString());
                    }
                    else if (donem == (vade * 12))
                    {
                        anapara = faizlipara / (1 + (faiz * donem));
                        MessageBox.Show("Anaparanız: " + anapara.ToString());
                    }
                    else if ((vade * 12) % donem == 0)
                    {
                        float tekrar = (vade * 12) / donem;
                        anapara = faizlipara;
                        while (tekrar > 0)
                        {
                            anapara = anapara / (1 + (faiz * donem));
                            tekrar--;
                        }
                        MessageBox.Show("Anaparanız: " + anapara.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Vade süresi hesap donemleri süresinin katlarından olmalıdır.");
                    }

                    break;
                case "Gün":
                    if (rd_360.Checked)
                    {
                        if ((vade * 360) < donem)
                        {
                            MessageBox.Show("Vade süresi donem süresinden küçük olamaz.");
                        }
                        else if (donem == 360)
                        {
                            faiz = Convert.ToSingle(txt_faiz.Text);
                            faiz /= 100;
                            while (vade > 0)
                            {
                                sayi *= (1 + faiz);
                                vade--;
                            }
                            anapara = faizlipara / sayi;
                            MessageBox.Show("Anaparanız: " + anapara.ToString());
                        }
                        else if (donem == (vade * 360))
                        {
                            anapara = faizlipara / (1 + (faiz * vade));
                            MessageBox.Show("Anaparanız: " + anapara.ToString());
                        }
                        else if ((vade * 360) % donem == 0)
                        {
                            float tekrar = (vade * 360) / donem;
                            anapara = faizlipara;
                            while (tekrar > 0)
                            {
                                anapara = anapara / (1 + (faiz * donem));
                                tekrar--;
                            }
                            MessageBox.Show("Anaparanız: " + anapara.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Vade süresi hesap donemleri süresinin katlarından olmalıdır.");
                        }
                    }
                    if (rd_365.Checked)
                    {
                        if ((vade * 365) < donem)
                        {
                            MessageBox.Show("Vade süresi donem süresinden küçük olamaz.");
                        }
                        else if (donem == 365)
                        {
                            faiz = Convert.ToSingle(txt_faiz.Text);
                            faiz /= 100;
                            while (vade > 0)
                            {
                                sayi *= (1 + faiz);
                                vade--;
                            }
                            anapara = faizlipara / sayi;
                            MessageBox.Show("Anaparanız: " + anapara.ToString());
                        }
                        else if (donem == (vade * 365))
                        {
                            anapara = faizlipara / (1 + (faiz * vade));
                            MessageBox.Show("Anaparanız: " + anapara.ToString());
                        }
                        else if ((vade * 365) % donem == 0)
                        {
                            float tekrar = (vade * 365) / donem;
                            anapara = faizlipara;
                            while (tekrar > 0)
                            {
                                anapara = anapara / (1 + (faiz * donem));
                                tekrar--;
                            }
                            MessageBox.Show("Anaparanız: " + anapara.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Vade süresi hesap donemleri süresinin katlarından olmalıdır.");
                        }
                    }
                    break;
            }
        }

        void SimdikiPara_Aylik()
        {
            float anapara = 0;
            float faiz = Convert.ToSingle(txt_faiz.Text);
            faiz /= 100;
            float vade = Convert.ToSingle(txt_vade.Text);
            float donem = Convert.ToSingle(txt_donem.Text);
            float faizlipara = Convert.ToSingle(txt_Anapara.Text);
            float sayi = 1;

            faiz = FaizHesabı(faiz);

            switch (cmb_donem.Text)
            {
                case "Yıl":
                    MessageBox.Show("Vade süresi aylik iken dönem süresi yıllık seçilemez.");
                    break;
                case "Ay":
                    if (vade < donem)
                    {
                        MessageBox.Show("Vade süresi donem süresinden küçük olamaz.");
                    }
                    else if (donem == 12)
                    {
                        vade *= 30;
                        while (vade > 0)
                        {
                            sayi *= (1 + faiz);
                            vade--;
                        }
                        anapara = faizlipara / sayi;
                        MessageBox.Show("Anaparanız: " + anapara.ToString());
                    }
                    else if (donem == vade)
                    {
                        anapara /= (1 + (faiz * donem));
                        MessageBox.Show("Anaparanız: " + anapara.ToString());
                    }
                    else if (vade % donem == 0)
                    {
                        float tekrar = vade / donem;
                        anapara = faizlipara;
                        while (tekrar > 0)
                        {
                            anapara /= (1 + (faiz * donem));
                            tekrar--;
                        }
                        MessageBox.Show("Anaparanız: " + anapara.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Vade süresi hesap donemleri süresinin katlarından olmalıdır.");
                    }

                    break;
                case "Gün":
                    if (rd_360.Checked)
                    {
                        if ((vade * 30) < donem)
                        {
                            MessageBox.Show("Vade süresi donem süresinden küçük olamaz.");
                        }
                        else if (donem == 30)
                        {
                            faiz = Convert.ToSingle(txt_faiz.Text);
                            faiz /= 1200;
                            while (vade > 0)
                            {
                                sayi *= (1 + faiz);
                                vade--;
                            }
                            anapara = faizlipara / sayi;
                            MessageBox.Show("Anaparanız: " + anapara.ToString());
                        }
                        else if (donem == (vade * 30))
                        {
                            anapara = faizlipara / (1 + (faiz * donem));
                            MessageBox.Show("Anaparanız: " + anapara.ToString());
                        }
                        else if ((vade * 30) % donem == 0)
                        {
                            float tekrar = (vade * 30) / donem;
                            anapara = faizlipara;
                            while (tekrar > 0)
                            {
                                anapara /= (1 + (faiz * donem));
                                tekrar--;
                            }
                            MessageBox.Show("Anaparanız: " + anapara.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Vade süresi hesap donemleri süresinin katlarından olmalıdır.");
                        }
                    }
                    if (rd_365.Checked)
                    {
                        if ((vade * 30) < donem)
                        {
                            MessageBox.Show("Vade süresi donem süresinden küçük olamaz.");
                        }
                        else if (donem == 30)
                        {
                            vade *= 30;
                            while (vade > 0)
                            {
                                sayi *= (1 + faiz);
                                vade--;
                            }
                            anapara = faizlipara / sayi;
                            MessageBox.Show("Anaparanız: " + anapara.ToString());
                        }
                        else if (donem == (vade * 30))
                        {
                            anapara = faizlipara / (1 + (faiz * donem));
                            MessageBox.Show("Anaparanız: " + anapara.ToString());
                        }
                        else if ((vade * 30) % donem == 0)
                        {
                            float tekrar = (vade * 30) / donem;
                            anapara = faizlipara;
                            while (tekrar > 0)
                            {
                                anapara /= (1 + (faiz * donem));
                                tekrar--;
                            }
                            MessageBox.Show("Anaparanız: " + anapara.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Vade süresi hesap donemleri süresinin katlarından olmalıdır.");
                        }
                    }
                    break;
            }
        }

        void SimdikiPara_Gunluk()
        {
            float anapara = 0;
            float faiz = Convert.ToSingle(txt_faiz.Text);
            faiz /= 100;
            float vade = Convert.ToSingle(txt_vade.Text);
            float donem = Convert.ToSingle(txt_donem.Text);
            float faizlipara = Convert.ToSingle(txt_Anapara.Text);
            float sayi = 1;

            faiz = FaizHesabı(faiz);

            switch (cmb_donem.Text)
            {
                case "Yıl":
                    MessageBox.Show("Vade süresi günlük iken dönem süresi yıllık seçilemez.");
                    break;
                case "Ay":
                    MessageBox.Show("Vade süresi günlük iken dönem süresi aylik seçilemez.");
                    break;
                case "Gün":
                    if (rd_360.Checked)
                    {
                        if (vade < donem)
                        {
                            MessageBox.Show("Vade süresi donem süresinden küçük olamaz.");
                        }
                        else if (donem == 1)
                        {
                            while (vade > 0)
                            {
                                sayi *= (1 + faiz);
                                vade--;
                            }
                            anapara = faizlipara / sayi;
                            MessageBox.Show("Anaparanız: " + anapara.ToString());
                        }
                        else if (donem == vade)
                        {
                            anapara = faizlipara / (1 + (faiz * vade));
                            MessageBox.Show("Anaparanız: " + anapara.ToString());
                        }
                        else if (vade % donem == 0)
                        {
                            float tekrar = vade / donem;
                            anapara = faizlipara;
                            while (tekrar > 0)
                            {
                                anapara = anapara / (1 + (faiz * donem));
                                tekrar--;
                            }
                            MessageBox.Show("Anaparanız: " + anapara.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Vade süresi hesap donemleri süresinin katlarından olmalıdır.");
                        }
                    }
                    if (rd_365.Checked)
                    {
                        if (vade < donem)
                        {
                            MessageBox.Show("Vade süresi donem süresinden küçük olamaz.");
                        }
                        else if (donem == 1)
                        {
                            while (vade > 0)
                            {
                                sayi *= (1 + faiz);
                                vade--;
                            }
                            anapara = faizlipara / sayi;
                            MessageBox.Show("Anaparanız: " + anapara.ToString());
                        }
                        else if (donem == vade)
                        {
                            anapara = faizlipara / (1 + (faiz * vade));
                            MessageBox.Show("Anaparanız: " + anapara.ToString());
                        }
                        else if (vade % donem == 0)
                        {
                            float tekrar = vade / donem;
                            anapara = faizlipara;
                            while (tekrar > 0)
                            {
                                anapara = anapara / (1 + (faiz * donem));
                                tekrar--;
                            }
                            MessageBox.Show("Anaparanız: " + anapara.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Vade süresi hesap donemleri süresinin katlarından olmalıdır.");
                        }
                    }
                    break;
            }
        }

    }
}
