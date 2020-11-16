using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketOrdering
{
    public partial class seats : Form
    {
        List<int> choosen = new List<int>();
        List<int> taken = new List<int>();
        public seats()
        {
            InitializeComponent();
        }
        

        private void seats_Load(object sender, EventArgs e)
        {
            taken.Add(104);
            taken.Add(70);
            taken.Add(30);

            updateTaken();
        }
        private void updateTaken()
        {
            foreach (Button b in panel1.Controls)
            {
                foreach (int i in taken)
                {
                    if (b.Text == i + "")
                    {
                        b.BackColor = Color.Red; //this means taken
                    }
                }
            }
        }
        private void updateChoosen()
        {
            foreach (Button b in panel1.Controls)
            {
                foreach (int i in choosen)
                {
                    if (b.Text == i + "")
                    {
                        b.BackColor = Color.Yellow; //this means selected

                    }
                }
            }
        }
        private bool isntTaken(int seat)
        {
            foreach(int i in taken)
            {
                if(i == seat)
                {
                    return false;
                }
            }
            return true;
        }
        private bool isntSelected(int seat)
        {
            foreach (int i in choosen)
            {
                if(i == seat)
                {
                    return false;
                }
            }
            return true;
        }
        private void clear_Click(object sender, EventArgs e)
        {
            
            choosen.Clear();
            foreach(Button b in panel1.Controls)
            {
                b.BackColor = Color.Gainsboro;
            }
            updateTaken();
        }
        
        private void seat1_Click(object sender, EventArgs e)
        {
            int seat = 1;
            if (isntTaken(seat) && isntSelected(seat) && choosen.Count < 4)
            {
                choosen.Add(seat);
            }
            updateChoosen();
            
            
        }

        private void seat2_Click(object sender, EventArgs e)
        {
          int seat = 2;
          if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
          choosen.Add(seat);
          }
            updateChoosen();
        }

        private void seat3_Click(object sender, EventArgs e)
        {
          int seat = 3;
          if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
          choosen.Add(seat);
          }
            updateChoosen();
        }

        private void seat4_Click(object sender, EventArgs e)
        {
          int seat = 4;
          if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
          choosen.Add(seat);
          }
            updateChoosen();
        }

        private void seat5_Click(object sender, EventArgs e)
        {
          int seat = 5;
          if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
          choosen.Add(seat);
          }
            updateChoosen();
        }

        private void seat6_Click(object sender, EventArgs e)
        {
          int seat = 6;
          if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
          choosen.Add(seat);
          }
            updateChoosen();
        }

        private void seat7_Click(object sender, EventArgs e)
        {
          int seat = 7;
          if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
          choosen.Add(seat);
          }
            updateChoosen();
        }

        private void seat8_Click(object sender, EventArgs e)
        {
          int seat = 8;
          if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
          choosen.Add(seat);
          }
            updateChoosen();
        }

        private void seat9_Click(object sender, EventArgs e)
        {
          int seat = 9;
          if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
          choosen.Add(seat);
          }
            updateChoosen();
        }

        private void seat10_Click(object sender, EventArgs e)
        {
           int seat = 10;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat11_Click(object sender, EventArgs e)
        {
           int seat = 11;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat12_Click(object sender, EventArgs e)
        {
           int seat = 12;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat13_Click(object sender, EventArgs e)
        {
           int seat = 13;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat14_Click(object sender, EventArgs e)
        {
           int seat = 14;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();

        }

        private void seat15_Click(object sender, EventArgs e)
        {
           int seat = 15;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat16_Click(object sender, EventArgs e)
        {
           int seat = 16;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat17_Click(object sender, EventArgs e)
        {
           int seat = 17;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat18_Click(object sender, EventArgs e)
        {
           int seat = 18;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat19_Click(object sender, EventArgs e)
        {
           int seat = 19;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat20_Click(object sender, EventArgs e)
        {
           int seat = 20;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat21_Click(object sender, EventArgs e)
        {
           int seat = 21;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat22_Click(object sender, EventArgs e)
        {
           int seat = 22;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();

        }

        private void seat23_Click(object sender, EventArgs e)
        {
           int seat = 23;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat24_Click(object sender, EventArgs e)
        {
           int seat = 24;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat25_Click(object sender, EventArgs e)
        {
           int seat = 25;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat26_Click(object sender, EventArgs e)
        {
           int seat = 26;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat27_Click(object sender, EventArgs e)
        {
           int seat = 27;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat28_Click(object sender, EventArgs e)
        {
           int seat = 28;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat29_Click(object sender, EventArgs e)
        {
           int seat = 29;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat30_Click(object sender, EventArgs e)
        {
           int seat = 30;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat31_Click(object sender, EventArgs e)
        {
           int seat = 31;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat32_Click(object sender, EventArgs e)
        {
           int seat = 32;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat33_Click(object sender, EventArgs e)
        {
           int seat = 33;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat34_Click(object sender, EventArgs e)
        {
           int seat = 34;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat35_Click(object sender, EventArgs e)
        {
           int seat = 35;
           if(isntTaken(seat) && isntSelected(seat)){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat36_Click(object sender, EventArgs e)
        {
           int seat = 36;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat37_Click(object sender, EventArgs e)
        {
           int seat = 37;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat38_Click(object sender, EventArgs e)
        {
           int seat = 38;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat39_Click(object sender, EventArgs e)
        {
           int seat = 39;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat40_Click(object sender, EventArgs e)
        {
           int seat = 40;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat41_Click(object sender, EventArgs e)
        {
           int seat = 41;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat42_Click(object sender, EventArgs e)
        {
           int seat = 42;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat43_Click(object sender, EventArgs e)
        {
           int seat = 43;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat44_Click(object sender, EventArgs e)
        {
           int seat = 44;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat45_Click(object sender, EventArgs e)
        {
           int seat = 45;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat46_Click(object sender, EventArgs e)
        {
           int seat = 46;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat47_Click(object sender, EventArgs e)
        {
           int seat = 47;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat48_Click(object sender, EventArgs e)
        {
           int seat = 48;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat49_Click(object sender, EventArgs e)
        {
           int seat = 49;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat50_Click(object sender, EventArgs e)
        {
           int seat = 50;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat51_Click(object sender, EventArgs e)
        {
           int seat = 51;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat52_Click(object sender, EventArgs e)
        {
           int seat = 52;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat53_Click(object sender, EventArgs e)
        {
           int seat = 53;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat54_Click(object sender, EventArgs e)
        {
           int seat = 54;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat55_Click(object sender, EventArgs e)
        {
           int seat = 55;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat56_Click(object sender, EventArgs e)
        {
           int seat = 56;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat57_Click(object sender, EventArgs e)
        {
           int seat = 57;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }
        private void seat58_Click(object sender, EventArgs e)
        {
           int seat = 58;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }
        private void seat59_Click(object sender, EventArgs e)
        {
           int seat = 59;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat60_Click(object sender, EventArgs e)
        {
           int seat = 60;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat61_Click(object sender, EventArgs e)
        {
           int seat = 61;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat62_Click(object sender, EventArgs e)
        {
           int seat = 62;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat63_Click(object sender, EventArgs e)
        {
           int seat = 63;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat64_Click(object sender, EventArgs e)
        {
           int seat = 64;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat65_Click(object sender, EventArgs e)
        {
           int seat = 65;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat66_Click(object sender, EventArgs e)
        {
           int seat = 66;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat67_Click(object sender, EventArgs e)
        {
           int seat = 67;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat68_Click(object sender, EventArgs e)
        {
           int seat = 68;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat69_Click(object sender, EventArgs e)
        {
           int seat = 69;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat70_Click(object sender, EventArgs e)
        {
           int seat = 70;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat71_Click(object sender, EventArgs e)
        {
           int seat = 71;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat72_Click(object sender, EventArgs e)
        {
           int seat = 72;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat73_Click(object sender, EventArgs e)
        {
           int seat = 73;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat74_Click(object sender, EventArgs e)
        {
           int seat = 74;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat75_Click(object sender, EventArgs e)
        {
           int seat = 75;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat76_Click(object sender, EventArgs e)
        {
           int seat = 76;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat77_Click(object sender, EventArgs e)
        {
           int seat = 77;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat78_Click(object sender, EventArgs e)
        {
           int seat = 78;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat79_Click(object sender, EventArgs e)
        {
           int seat = 79;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat80_Click(object sender, EventArgs e)
        {
           int seat = 80;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat81_Click(object sender, EventArgs e)
        {
           int seat = 81;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat82_Click(object sender, EventArgs e)
        {
           int seat = 82;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat83_Click(object sender, EventArgs e)
        {
           int seat = 83;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat84_Click(object sender, EventArgs e)
        {
           int seat = 84;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat85_Click(object sender, EventArgs e)
        {
           int seat = 85;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat86_Click(object sender, EventArgs e)
        {
           int seat = 86;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat87_Click(object sender, EventArgs e)
        {
           int seat = 87;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat88_Click(object sender, EventArgs e)
        {
           int seat = 88;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat89_Click(object sender, EventArgs e)
        {
           int seat = 89;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat90_Click(object sender, EventArgs e)
        {
           int seat = 90;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat91_Click(object sender, EventArgs e)
        {
           int seat = 91;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat92_Click(object sender, EventArgs e)
        {
           int seat = 92;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat93_Click(object sender, EventArgs e)
        {
           int seat = 93;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat94_Click(object sender, EventArgs e)
        {
           int seat = 94;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat95_Click(object sender, EventArgs e)
        {
           int seat = 95;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat96_Click(object sender, EventArgs e)
        {
           int seat = 96;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat97_Click(object sender, EventArgs e)
        {
           int seat = 97;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat98_Click(object sender, EventArgs e)
        {
           int seat = 98;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
        }

        private void seat99_Click(object sender, EventArgs e)
        {
           int seat = 99;
           if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
           choosen.Add(seat);
           }
            updateChoosen();
            Console.WriteLine(sender.ToString());
        }
        private void seat100_Click(object sender, EventArgs e)
        {
            int seat = 100;
            if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
            choosen.Add(seat);
            }
            updateChoosen();
            Console.WriteLine(sender.ToString());
        }

        private void seat101_Click(object sender, EventArgs e)
        {
            int seat = 101;
            if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
            choosen.Add(seat);
            }
            updateChoosen();
        }

        private void seat102_Click(object sender, EventArgs e)
        {
            int seat = 102;
            if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
            choosen.Add(seat);
            }
            updateChoosen();
        }

        private void seat103_Click(object sender, EventArgs e)
        {
            int seat = 103;
            if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
            choosen.Add(seat);
            }
            updateChoosen();
        }

        private void seat104_Click(object sender, EventArgs e)
        {
            int seat = 104;
            if(isntTaken(seat) && isntSelected(seat) && choosen.Count < 4){
            choosen.Add(seat);
            }
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
