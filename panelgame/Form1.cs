using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace AvoidGrenade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        Random g = new Random();
        Random b = new Random();

        Random xL = new Random();
        Random yL = new Random();
        int count = 0;
        SoundPlayer player = new SoundPlayer(@"D:\Kali_Linux\bomb.wav");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.Size = new Size(60, 60);
            panel.Location = new Point(xL.Next(0, 500), yL.Next(0, 220));
            panel.BackColor = Color.FromArgb(r.Next(0, 256), g.Next(0, 256), b.Next(0, 256));
            this.Controls.Add(panel);
            count++;
            label2.Text = count.ToString();
            if (panel.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                player.Play();
                MessageBox.Show("Oyun bitdi! Yekun nəticə: " + count.ToString(), "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                count = 0;
                label2.Text = count.ToString();
                while (this.Controls.Count > 5)
                {
                    this.Controls.RemoveAt(5);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(xL.Next(0, 500), yL.Next(0, 220));
        }
    }
}