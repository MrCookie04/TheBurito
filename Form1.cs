using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Underground_Maze
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label144_Click(object sender, EventArgs e)
        {

        }
        
        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            //Show Message Box an close the program.
            MessageBox.Show("Congratulations!");
            Close();
        }
        /// <summary>
        /// Move the pointer to a point 10 pixels down and to the right
        /// of the starting point in the upper-left corner of the maze.
        /// </summary>
        private void MoveToStart()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            //When the cursor collishion with wall
            //the call will begin MoveToStart() method.
            MoveToStart();
        }
    }
}