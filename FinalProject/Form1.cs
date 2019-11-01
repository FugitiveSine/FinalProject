using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace FinalProject
{
    
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
        }
        int time = 0;
        int jumpDistance = 10;
        int A = 0;
        int B = 0;
        int C = 0;
        int D = 0;
        int E = 0;
        int F = 0;
        int G = 0;
        int H = 0;
        int counter = 0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D) {


                Point myPointRight = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y + 0);
                pictureBox1.Location = myPointRight;

                Point myPointRight1 = new Point(pictureBox12.Location.X + 10, pictureBox12.Location.Y + 0);
                pictureBox12.Location = myPointRight1;

                Point myPointRight2 = new Point(pictureBox13.Location.X + 10, pictureBox13.Location.Y + 0);
                pictureBox13.Location = myPointRight2;

                Point myPointRight3 = new Point(pictureBox14.Location.X + 10, pictureBox14.Location.Y + 0);
                pictureBox14.Location = myPointRight3;

                Point myPointRight4 = new Point(pictureBox15.Location.X + 10, pictureBox15.Location.Y + 0);
                pictureBox15.Location = myPointRight4;

                Point myPointRight5 = new Point(pictureBox16.Location.X + 10, pictureBox16.Location.Y + 0);
                pictureBox16.Location = myPointRight5;



            }

            if (e.KeyCode == Keys.A)
            {

                
                Point myPointRight = new Point(pictureBox1.Location.X  -10, pictureBox1.Location.Y + 0);
                pictureBox1.Location = myPointRight;

                Point myPointRight1 = new Point(pictureBox12.Location.X -10, pictureBox12.Location.Y + 0);
                pictureBox12.Location = myPointRight1;

                Point myPointRight2 = new Point(pictureBox13.Location.X - 10, pictureBox13.Location.Y + 0);
                pictureBox13.Location = myPointRight2;

                Point myPointRight3 = new Point(pictureBox14.Location.X -10, pictureBox14.Location.Y + 0);
                pictureBox14.Location = myPointRight3;

                Point myPointRight4 = new Point(pictureBox15.Location.X -10, pictureBox15.Location.Y + 0);
                pictureBox15.Location = myPointRight4;

                Point myPointRight5 = new Point(pictureBox16.Location.X -10, pictureBox16.Location.Y + 0);
                pictureBox16.Location = myPointRight5;



            }

            if (e.KeyCode == Keys. W)
            {


               
                timer2.Start();



            }






        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           //tail collision

            //meteor 1
            Point myPointFall = new Point(pictureBox2.Location.X + 0, pictureBox2.Location.Y + A);
                pictureBox2.Location = myPointFall;
            if (pictureBox2.Bounds.IntersectsWith(pictureBox12.Bounds)) {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);
                

               
                   
            }
            //meteor 2
            Point myPointFall2 = new Point(pictureBox3.Location.X + 0, pictureBox3.Location.Y + B);
            pictureBox3.Location = myPointFall2;
            if (pictureBox3.Bounds.IntersectsWith(pictureBox12.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose" + " your highscore is " + counter);


            }
            //meteor 3
            Point myPointFall3 = new Point(pictureBox4.Location.X + 0, pictureBox4.Location.Y + C);
            pictureBox4.Location = myPointFall3;
            if (pictureBox4.Bounds.IntersectsWith(pictureBox12.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose" + " your highscore is " + counter);


            }
            //meteor 4
            Point myPointFall4 = new Point(pictureBox5.Location.X + 0, pictureBox5.Location.Y + D);
            pictureBox5.Location = myPointFall4;
            if (pictureBox5.Bounds.IntersectsWith(pictureBox12.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose" + " your highscore is " + counter);


            }

            //meteor 5
            Point myPointFall5 = new Point(pictureBox6.Location.X + 0, pictureBox6.Location.Y + E);
            pictureBox6.Location = myPointFall5;
            if (pictureBox6.Bounds.IntersectsWith(pictureBox12.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose" + " your highscore is " + counter);


            }
            //meteor 6
            Point myPointFall7 = new Point(pictureBox7.Location.X + 0, pictureBox7.Location.Y + F);
            pictureBox7.Location = myPointFall7;
            if (pictureBox7.Bounds.IntersectsWith(pictureBox12.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose" + " your highscore is " + counter);


            }
            //meteor 7
            Point myPointFall8 = new Point(pictureBox8.Location.X + 0, pictureBox8.Location.Y + G);
            pictureBox8.Location = myPointFall8;
            if (pictureBox8.Bounds.IntersectsWith(pictureBox12.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose" + " your highscore is " + counter);


            }
            //meteor 8
            Point myPointFall9 = new Point(pictureBox9.Location.X + 0, pictureBox9.Location.Y + H);
            pictureBox9.Location = myPointFall9;
            if (pictureBox9.Bounds.IntersectsWith(pictureBox12.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose" + " your highscore is " + counter);


            }
            //body collision
            //meteor 1
            if (pictureBox2.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }
            //meteor 2
            if (pictureBox3.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }
            //meteor 3
            if (pictureBox4.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }
            //meteor 4
            if (pictureBox5.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 5
            if (pictureBox6.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 6
            if (pictureBox7.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 7
            if (pictureBox8.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 8
            if (pictureBox9.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }
            //head collision
            //meteor 1
            if (pictureBox2.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 2
            if (pictureBox3.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 3
            if (pictureBox4.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }
            //meteor 4
            if (pictureBox5.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 5
            if (pictureBox6.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 6
            if (pictureBox7.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 7
            if (pictureBox8.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 8
            if (pictureBox9.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }
            //noggin
            //meteor 1
            if (pictureBox2.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 2
            if (pictureBox3.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 3
            if (pictureBox4.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 4
            if (pictureBox5.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

              //meteor 5
            if (pictureBox6.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 6
            if (pictureBox7.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 7
            if (pictureBox8.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 8
            if (pictureBox9.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }
            //nose
            //meteor 1
            if (pictureBox2.Bounds.IntersectsWith(pictureBox16.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 2
            if (pictureBox3.Bounds.IntersectsWith(pictureBox16.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 3
            if (pictureBox4.Bounds.IntersectsWith(pictureBox16.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 4
            if (pictureBox5.Bounds.IntersectsWith(pictureBox16.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 5
            if (pictureBox6.Bounds.IntersectsWith(pictureBox16.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 6
            if (pictureBox7.Bounds.IntersectsWith(pictureBox16.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 7
            if (pictureBox8.Bounds.IntersectsWith(pictureBox16.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }

            //meteor 8
            if (pictureBox9.Bounds.IntersectsWith(pictureBox16.Bounds))
            {
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("you lose," + " your highscore is " + counter);

            }















            //meteor 1 restart
            if (pictureBox2.Location.Y > 600)
            {

                Point myPointFal = new Point(124, -92);
                pictureBox2.Location = myPointFal;

            }
            //meteor 2 restart
            if (pictureBox3.Location.Y > 600) {

                Point myPointFal2 = new Point(250, -92);
                pictureBox3.Location = myPointFal2;


            }
            //meteor 3 restart
            if (pictureBox4.Location.Y > 600)
            {

                Point myPointFal3 = new Point(376, -92);
                pictureBox4.Location = myPointFal3;


            }
            //meteor 4 restart
            if (pictureBox5.Location.Y > 600)
            {

                Point myPointFal4 = new Point(513, -92);
                pictureBox5.Location = myPointFal4;


            }
            //meteor 5 restart
            if (pictureBox6.Location.Y > 600)
            {

                Point myPointFal5 = new Point(766, -92);
                pictureBox6.Location = myPointFal5;


            }
            //meteor 6 restart
            if (pictureBox7.Location.Y > 600)
            {

                Point myPointFal6 = new Point(642, -92);
                pictureBox7.Location = myPointFal6;


            }
            //meteor 7 restart
            if (pictureBox8.Location.Y > 600)
            {

                Point myPointFal7 = new Point(881, -92);
                pictureBox8.Location = myPointFal7;


            }
            //meteor 8 restart
            if (pictureBox9.Location.Y > 600)
            {

                Point myPointFal8 = new Point(995, -92);
                pictureBox9.Location = myPointFal8;


            }
            











        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();
            timer3.Start();
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            Point myPointFall = new Point(pictureBox1.Location.X + 0, pictureBox1.Location.Y - jumpDistance );
            pictureBox1.Location = myPointFall;
            jumpDistance--;

            if (jumpDistance <= -11) {
                jumpDistance = 10;

                timer2.Stop();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            //pictureBox2 (321, 22);





        }
        Random ran = new Random();
        int num = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {

            counter++;
            label2.Text = counter.ToString();


            num = ran.Next(1, 9);
            if (num == 1)
            {

                A = 10;
            }
            else if (num == 2)
            {

                B = 10;
            }
            else if (num == 3)
            {
                C = 10;
            }
            else if (num == 4)
            {
                D = 10;
            }
            else if (num == 5)
            {
                E = 10;
            }
            else if (num == 6)
            {
                F = 10;
            }
            else if (num == 7)
            {
                G = 10;
            }
            else if (num == 8) {
                H = 10;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            A = 0;
            B = 0;
            C = 0;
            D = 0;
            E = 0;
            F = 0;
            G = 0;           
            H = 0;








            //meteor 1
            Point myPointFall = new Point(124, -92);
            pictureBox2.Location = myPointFall;
            //meteor 2
            Point myPointFall2 = new Point(250, -92);
            pictureBox3.Location = myPointFall2;
            //meteor 3
            Point myPointFall3 = new Point(376, -92);
            pictureBox4.Location = myPointFall3;
            //meteor 4
            Point myPointFall4 = new Point(513, -92);
            pictureBox5.Location = myPointFall4;
            //meteor 5
            Point myPointFall5 = new Point(766, -92);
            pictureBox6.Location = myPointFall5;
            //meteor 6
            Point myPointFall6 = new Point(642, -92);
            pictureBox7.Location = myPointFall6;
            //meteor 7
            Point myPointFall7 = new Point(881, -92);
            pictureBox8.Location = myPointFall7;
            //meteor 8
            Point myPointFall8 = new Point(995, -92);
            pictureBox9.Location = myPointFall8;


            //dinoo
            Point myPointDino = new Point(204, 453);
            pictureBox1.Location = myPointDino;


            counter = 0;
            label2.Text = counter.ToString();


            //Tail
            Point myPointTail = new Point(271, 480);
            pictureBox12.Location = myPointTail;

            Point myPointTail2 = new Point(271, 441);
            pictureBox1.Location = myPointTail2;


            //Body
            Point myPointBody = new Point(336, 472);
            pictureBox13.Location = myPointBody;

            Point myPointBody2 = new Point(271, 441);
            pictureBox1.Location = myPointBody2;


            //Head
            Point myPointHead = new Point(417, 459);
            pictureBox14.Location = myPointHead;

            Point myPointHead2 = new Point(271, 441);
            pictureBox1.Location = myPointHead2;


            //Noggin
            Point myPointNoggin = new Point(429, 448);
            pictureBox15.Location = myPointNoggin;

            Point myPointNoggin2 = new Point(271, 441);
            pictureBox1.Location = myPointNoggin2;

            //Nose
            Point myPointNose = new Point(476, 474);
            pictureBox16.Location = myPointNose;

            Point myPointNose2 = new Point(271, 441);
            pictureBox1.Location = myPointNose2;

















        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {



            if (pictureBox10.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                MessageBox.Show("YOU LOSE!!!GET BACK ON THE SCREEN AND CLICK RESET YOU CHEATING PEICE OF GARBAGE ");
            }
            if (pictureBox11.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                MessageBox.Show("YOU LOSE!!!GET BACK ON THE SCREEN AND CLICK RESET YOU CHEATING PEICE OF GARBAGE");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
