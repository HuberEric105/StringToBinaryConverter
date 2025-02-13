using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit1Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            firstTB.Focus();
        }
        
        private void processBtn_Click(object sender, EventArgs e)
        {
            // Get the input string, convert it to upper case
            string input = firstTB.Text.ToUpper();
            string[] binaryValues = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'A':
                        binaryValues[i] = "00001";
                        break;
                    case 'B':
                        binaryValues[i] = "00010";
                        break;
                    case 'C':
                        binaryValues[i] = "00011";
                        break;
                    case 'D':
                        binaryValues[i] = "00100";
                        break;
                    case 'E':
                        binaryValues[i] = "00101";
                        break;
                    case 'F':
                        binaryValues[i] = "00110";
                        break;
                    case 'G':
                        binaryValues[i] = "00111";
                        break;
                    case 'H':
                        binaryValues[i] = "01000";
                        break;
                    case 'I':
                        binaryValues[i] = "01001";
                        break;
                    case 'J':
                        binaryValues[i] = "01010";
                        break;
                    case 'K':
                        binaryValues[i] = "01011";
                        break;
                    case 'L':
                        binaryValues[i] = "01100";
                        break;
                    case 'M':
                        binaryValues[i] = "01101";
                        break;
                    case 'N':
                        binaryValues[i] = "01110";
                        break;
                    case 'O':
                        binaryValues[i] = "01111";
                        break;
                    case 'P':
                        binaryValues[i] = "10000";
                        break;
                    case 'Q':
                        binaryValues[i] = "10001";
                        break;
                    case 'R':
                        binaryValues[i] = "10010";
                        break;
                    case 'S':
                        binaryValues[i] = "10011";
                        break;
                    case 'T':
                        binaryValues[i] = "10100";
                        break;
                    case 'U':
                        binaryValues[i] = "10101";
                        break;
                    case 'V':
                        binaryValues[i] = "10110";
                        break;
                    case 'W':
                        binaryValues[i] = "10111";
                        break;
                    case 'X':
                        binaryValues[i] = "11000";
                        break;
                    case 'Y':
                        binaryValues[i] = "11001";
                        break;
                    case 'Z':
                        binaryValues[i] = "11010";
                        break;
                    default:
                        binaryValues[i] = "";
                        break;
                }
            }
            binaryTB.Text = string.Join(" ", binaryValues);
            firstTB.Text = "";
            firstTB.Focus();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            binaryTB.Text = "";
            firstTB.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
