using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			mayinlariEkle();
			buttonlariOlustur();

		}
		
		bool oyunBittiMi = false;
		bool ilkAcilisMi = true;
		int ilkSure;
		int sure;
		int mayinsayisi;
		Form2 f2;
		List<int> bosyerler = new List<int>();
		public static List<Point> mayinLokasyonlari = new List<Point>();
		public static int[] mayinlar;

		void buttonlariOlustur()
		{

			int buttonSayac = 0;
			int i,
			j;

			for (i = 0; i < 5; i++)
			{
				for (j = 0; j < 5; j++)
				{

					buttonSayac++;
					Button btn = new Button();
					btn.Name = "" + buttonSayac;
					btn.BackColor = Color.Gray;
					btn.Size = new Size(30, 30);
					btn.Location = new Point(35 * j, 35 * i);
					btn.ForeColor = Color.White;
					if (mayinlar.Contains(buttonSayac))
					{
						mayinLokasyonlari.Add(btn.Location);
					}
					else
					{
						bosyerler.Add(buttonSayac);
					}
					btn.Click += btn_click;
					panel1.Controls.Add(btn);

				}
			}

		}

		private void btn_click(object sender, EventArgs e)
		{
			if (ilkAcilisMi == false && oyunBittiMi == false)
			{
				
				Button tiklanan = (Button)sender;
				tiklanan.Text = etraftakiMayinSayisiniBul(tiklanan).ToString();
				if (mayinlar.Contains(Convert.ToInt32(tiklanan.Name)))
				{
					tiklanan.BackColor = Color.Red;
					oyunBittiMi = true;
					timer1.Enabled = false;
					MessageBox.Show("Oyun Bitti");
				}
				else
				{
					tiklanan.BackColor = Color.Green;
					sureyiBaslat();
					bosyerler.Remove(Convert.ToInt32(tiklanan.Name));
					if (bosyerler.Count == 0)
					{
						oyunBittiMi = true;
						timer1.Enabled = false;
						MessageBox.Show("Oyunu Kazandınız");

					}
				}

			}
		}
		void mayinlariEkle()
		{
			mayinsayisi = Convert.ToInt32(mayinNumeric.Value);
			mayinlar = new int[mayinsayisi];
			Random rnd = new Random();
			int eklenen = 0;
			while (eklenen < mayinsayisi)
			{
				int sayi = rnd.Next(1, 26);
				if (!mayinlar.Contains(sayi))
				{
					mayinlar[eklenen] = sayi;
					eklenen++;
				}
			}

		}

		public static int etraftakiMayinSayisiniBul(Button tiklanan)
		{
			int sayac = 0;
			if (mayinLokasyonlari.Contains(new Point(tiklanan.Location.X + 35, tiklanan.Location.Y)))
			{
				sayac++;
			}
			if (mayinLokasyonlari.Contains(new Point(tiklanan.Location.X - 35, tiklanan.Location.Y)))
			{
				sayac++;
			}
			if (mayinLokasyonlari.Contains(new Point(tiklanan.Location.X, tiklanan.Location.Y + 35)))
			{
				sayac++;
			}
			if (mayinLokasyonlari.Contains(new Point(tiklanan.Location.X, tiklanan.Location.Y - 35)))
			{
				sayac++;
			}
			if (mayinLokasyonlari.Contains(new Point(tiklanan.Location.X + 35, tiklanan.Location.Y + 35)))
			{
				sayac++;
			}
			if (mayinLokasyonlari.Contains(new Point(tiklanan.Location.X - 35, tiklanan.Location.Y + 35)))
			{
				sayac++;
			}
			if (mayinLokasyonlari.Contains(new Point(tiklanan.Location.X + 35, tiklanan.Location.Y - 35)))
			{
				sayac++;
			}
			if (mayinLokasyonlari.Contains(new Point(tiklanan.Location.X - 35, tiklanan.Location.Y - 35)))
			{
				sayac++;
			}

			return sayac;
		}

		private void basla_Click(object sender, EventArgs e)
		{
			

			if (ilkAcilisMi == true)
			{
				sistemiBaslat();
				sureyiBaslat();
				f2 = new Form2();
				f2.Show();
				ilkAcilisMi = false;

			}
			else
			{
				DialogResult diyalog = MessageBox.Show("Yeni oyun başlatmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
				if (diyalog == DialogResult.Yes)
				{
					sistemiBaslat();
					for (int i = 1; i <= 25; i++)
					{
						Button buton = (Button)(this.Controls.Find("" + i, true)[0]);
						buton.BackColor = Color.Gray;
						buton.Text = "";
					}

					if (f2 != null)
					{
						f2.Close();

					}
					oyunBittiMi = false;
					sureyiBaslat();
					f2 = new Form2();
					f2.Show();

				}
				else if (diyalog == DialogResult.No)
				{

				}
			}

		}

		void sistemiBaslat()
		{
			bosyerler.Clear();
			mayinLokasyonlari.Clear();
			mayinlariEkle();
			buttonlariOlustur();
			ilkSure = Convert.ToInt32(sureNumeric.Value);
		}
		void sureyiBaslat()
		{
			sure = ilkSure;
			lblsure.Text = "Kalan Süre :" + sure.ToString();
			timer1.Enabled = true;
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			sure--;
			lblsure.Text = "Kalan Süre :" + sure.ToString();

			if (sure == 0)
			{
				timer1.Enabled = false;
				oyunBittiMi = true;
				MessageBox.Show("Süre Bitti");
			}

		}
		
	}
}