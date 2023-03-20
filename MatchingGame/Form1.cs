using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", "D", "D", "k", "k", "o", "o",
            ";", ";", "s", "s", "E", "E", "x", "x"
        };
  
        public Form1()
        {
            InitializeComponent();
        }
    }
}
