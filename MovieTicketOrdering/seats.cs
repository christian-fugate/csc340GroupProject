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
            
            foreach (Button b in panel1.Controls)
            {
                foreach(int i in taken)
                {
                    if(b.Text == i + "")
                    {
                        b.BackColor = Color.Red; //this means taken
                    }
                }
            }
        }
        
        private void seat1_Click(object sender, EventArgs e)
        {
            choosen.Add(1);
            sender.ToString();
            Console.WriteLine(sender.ToString());
        }

        private void seat2_Click(object sender, EventArgs e)
        {
            choosen.Add(2);
        }

        private void seat3_Click(object sender, EventArgs e)
        {
            choosen.Add(2);
        }

        private void seat4_Click(object sender, EventArgs e)
        {
            choosen.Add(4);
        }

        private void seat5_Click(object sender, EventArgs e)
        {
            choosen.Add(5);
        }

        private void seat6_Click(object sender, EventArgs e)
        {
            choosen.Add(6);
        }

        private void seat7_Click(object sender, EventArgs e)
        {
            choosen.Add(7);
        }

        private void seat8_Click(object sender, EventArgs e)
        {
            choosen.Add(8);
        }

        private void seat9_Click(object sender, EventArgs e)
        {
            choosen.Add(9);
        }

        private void seat10_Click(object sender, EventArgs e)
        {
            choosen.Add(10);
        }

        private void seat11_Click(object sender, EventArgs e)
        {
            choosen.Add(11);
        }

        private void seat12_Click(object sender, EventArgs e)
        {
            choosen.Add(12);
        }

        private void seat13_Click(object sender, EventArgs e)
        {
            choosen.Add(13);
        }

        private void seat14_Click(object sender, EventArgs e)
        {
            choosen.Add(14);
        }

        private void seat15_Click(object sender, EventArgs e)
        {
            choosen.Add(15);
        }

        private void seat16_Click(object sender, EventArgs e)
        {
            choosen.Add(16);
        }

        private void seat17_Click(object sender, EventArgs e)
        {
            choosen.Add(17);
        }

        private void seat18_Click(object sender, EventArgs e)
        {
            choosen.Add(18);
        }

        private void seat19_Click(object sender, EventArgs e)
        {
            choosen.Add(19);
        }

        private void seat20_Click(object sender, EventArgs e)
        {
            choosen.Add(20);
        }

        private void seat21_Click(object sender, EventArgs e)
        {
            choosen.Add(21);
        }

        private void seat22_Click(object sender, EventArgs e)
        {
            choosen.Add(22);
        }

        private void seat23_Click(object sender, EventArgs e)
        {
            choosen.Add(23);
        }

        private void seat24_Click(object sender, EventArgs e)
        {
            choosen.Add(24);
        }

        private void seat25_Click(object sender, EventArgs e)
        {
            choosen.Add(25);
        }

        private void seat26_Click(object sender, EventArgs e)
        {
            choosen.Add(26);
        }

        private void seat27_Click(object sender, EventArgs e)
        {
            choosen.Add(27);
        }

        private void seat28_Click(object sender, EventArgs e)
        {
            choosen.Add(28);
        }

        private void seat29_Click(object sender, EventArgs e)
        {
            choosen.Add(29);
        }

        private void seat30_Click(object sender, EventArgs e)
        {
            choosen.Add(30);
        }

        private void seat31_Click(object sender, EventArgs e)
        {
            choosen.Add(31);
        }

        private void seat32_Click(object sender, EventArgs e)
        {
            choosen.Add(32);
        }

        private void seat33_Click(object sender, EventArgs e)
        {
            choosen.Add(33);
        }

        private void seat34_Click(object sender, EventArgs e)
        {
            choosen.Add(34);
        }

        private void seat35_Click(object sender, EventArgs e)
        {
            choosen.Add(35);
        }

        private void seat36_Click(object sender, EventArgs e)
        {
            choosen.Add(36);
        }

        private void seat37_Click(object sender, EventArgs e)
        {
            choosen.Add(37);
        }

        private void seat38_Click(object sender, EventArgs e)
        {
            choosen.Add(38);
        }

        private void seat39_Click(object sender, EventArgs e)
        {
            choosen.Add(39);
        }

        private void seat40_Click(object sender, EventArgs e)
        {
            choosen.Add(40);
        }

        private void seat41_Click(object sender, EventArgs e)
        {
            choosen.Add(41);
        }

        private void seat42_Click(object sender, EventArgs e)
        {
            choosen.Add(42);
        }

        private void seat43_Click(object sender, EventArgs e)
        {
            choosen.Add(43);
        }

        private void seat44_Click(object sender, EventArgs e)
        {
            choosen.Add(44);
        }

        private void seat45_Click(object sender, EventArgs e)
        {
            choosen.Add(45);
        }

        private void seat46_Click(object sender, EventArgs e)
        {
            choosen.Add(46);
        }

        private void seat47_Click(object sender, EventArgs e)
        {
            choosen.Add(47);
        }

        private void seat48_Click(object sender, EventArgs e)
        {
            choosen.Add(48);
        }

        private void seat49_Click(object sender, EventArgs e)
        {
            choosen.Add(49);
        }

        private void seat50_Click(object sender, EventArgs e)
        {
            choosen.Add(50);
        }

        private void seat51_Click(object sender, EventArgs e)
        {
            choosen.Add(51);
        }

        private void seat52_Click(object sender, EventArgs e)
        {
            choosen.Add(52);
        }

        private void seat53_Click(object sender, EventArgs e)
        {
            choosen.Add(53);
        }

        private void seat54_Click(object sender, EventArgs e)
        {
            choosen.Add(54);
        }

        private void seat55_Click(object sender, EventArgs e)
        {
            choosen.Add(55);
        }

        private void seat56_Click(object sender, EventArgs e)
        {
            choosen.Add(56);
        }

        private void seat57_Click(object sender, EventArgs e)
        {
            choosen.Add(57);
        }
        private void seat58_Click(object sender, EventArgs e)
        {
            choosen.Add(58);
        }
        private void seat59_Click(object sender, EventArgs e)
        {
            choosen.Add(59);
        }

        private void seat60_Click(object sender, EventArgs e)
        {
            choosen.Add(60);
        }

        private void seat61_Click(object sender, EventArgs e)
        {
            choosen.Add(61);
        }

        private void seat62_Click(object sender, EventArgs e)
        {
            choosen.Add(62);
        }

        private void seat63_Click(object sender, EventArgs e)
        {
            choosen.Add(63);
        }

        private void seat64_Click(object sender, EventArgs e)
        {
            choosen.Add(64);
        }

        private void seat65_Click(object sender, EventArgs e)
        {
            choosen.Add(65);
        }

        private void seat66_Click(object sender, EventArgs e)
        {
            choosen.Add(66);
        }

        private void seat67_Click(object sender, EventArgs e)
        {
            choosen.Add(67);
        }

        private void seat68_Click(object sender, EventArgs e)
        {
            choosen.Add(68);
        }

        private void seat69_Click(object sender, EventArgs e)
        {
            choosen.Add(69);
        }

        private void seat70_Click(object sender, EventArgs e)
        {
            choosen.Add(70);
        }

        private void seat71_Click(object sender, EventArgs e)
        {
            choosen.Add(71);
        }

        private void seat72_Click(object sender, EventArgs e)
        {
            choosen.Add(72);
        }

        private void seat73_Click(object sender, EventArgs e)
        {
            choosen.Add(73);
        }

        private void seat74_Click(object sender, EventArgs e)
        {
            choosen.Add(74);
        }

        private void seat75_Click(object sender, EventArgs e)
        {
            choosen.Add(75);
        }

        private void seat76_Click(object sender, EventArgs e)
        {
            choosen.Add(76);
        }

        private void seat77_Click(object sender, EventArgs e)
        {
            choosen.Add(77);
        }

        private void seat78_Click(object sender, EventArgs e)
        {
            choosen.Add(78);
        }

        private void seat79_Click(object sender, EventArgs e)
        {
            choosen.Add(79);
        }

        private void seat80_Click(object sender, EventArgs e)
        {
            choosen.Add(80);
        }

        private void seat81_Click(object sender, EventArgs e)
        {
            choosen.Add(81);
        }

        private void seat82_Click(object sender, EventArgs e)
        {
            choosen.Add(82);
        }

        private void seat83_Click(object sender, EventArgs e)
        {
            choosen.Add(83);
        }

        private void seat84_Click(object sender, EventArgs e)
        {
            choosen.Add(84);
        }

        private void seat85_Click(object sender, EventArgs e)
        {
            choosen.Add(85);
        }

        private void seat86_Click(object sender, EventArgs e)
        {
            choosen.Add(86);
        }

        private void seat87_Click(object sender, EventArgs e)
        {
            choosen.Add(87);
        }

        private void seat88_Click(object sender, EventArgs e)
        {
            choosen.Add(88);
        }

        private void seat89_Click(object sender, EventArgs e)
        {
            choosen.Add(89);
        }

        private void seat90_Click(object sender, EventArgs e)
        {
            choosen.Add(90);
        }

        private void seat91_Click(object sender, EventArgs e)
        {
            choosen.Add(91);
        }

        private void seat92_Click(object sender, EventArgs e)
        {
            choosen.Add(92);
        }

        private void seat93_Click(object sender, EventArgs e)
        {
            choosen.Add(93);
        }

        private void seat94_Click(object sender, EventArgs e)
        {
            choosen.Add(94);
        }

        private void seat95_Click(object sender, EventArgs e)
        {
            choosen.Add(95);
        }

        private void seat96_Click(object sender, EventArgs e)
        {
            choosen.Add(96);
        }

        private void seat97_Click(object sender, EventArgs e)
        {
            choosen.Add(97);
        }

        private void seat98_Click(object sender, EventArgs e)
        {
            choosen.Add(98);
        }

        private void seat99_Click(object sender, EventArgs e)
        {
            choosen.Add(99);
            Console.WriteLine(sender.ToString());
        }
        private void seat100_Click(object sender, EventArgs e)
        {
            choosen.Add(100);
            Console.WriteLine(sender.ToString());
        }

        private void seat101_Click(object sender, EventArgs e)
        {
            choosen.Add(101);
        }

        private void seat102_Click(object sender, EventArgs e)
        {
            choosen.Add(102);
        }

        private void seat103_Click(object sender, EventArgs e)
        {
            choosen.Add(103);
        }

        private void seat104_Click(object sender, EventArgs e)
        {
            choosen.Add(104);
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
