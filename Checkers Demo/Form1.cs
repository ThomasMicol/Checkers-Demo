using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers_Demo
{
    public partial class Form1 : Form, ICheckerView
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        public void DrawGameLevel(ILevelData levelData)
        {
            throw new NotImplementedException();
        }

        public void DrawMainMenu()
        {
            throw new NotImplementedException();
        }
    }
}
