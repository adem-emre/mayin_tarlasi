using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            hileyiGoster();
        }

        void hileyiGoster()
        {

            int buttonSayac = 0;
            int i, j;

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    buttonSayac++;
                    Button btn = new Button();
                    btn.Name = "" + buttonSayac;
                    if (Form1.mayinlar.Contains(buttonSayac))
                    {
                        btn.BackColor = Color.Red;
                    }
                    else
                    {
                        btn.BackColor = Color.Green;
                    }
                    
                    btn.Size = new Size(30, 30);
                    btn.Location = new Point(35 * j, 35 * i);
                    btn.ForeColor = Color.White;
                    btn.Text = Form1.etraftakiMayinSayisiniBul(btn).ToString();
                    panel1.Controls.Add(btn);


                }
            }
        }
    }
}
