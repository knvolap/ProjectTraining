using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TMAPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApplyTheme();
        }
        bool isCheckBox;
        int x, y, width, height;
        int selectedRow;
        Stack<DataRow> undoStack = new Stack<DataRow>();
        Stack<DataRow> redoStack = new Stack<DataRow>();
        // Apply the selected theme
        private void ApplyTheme()
        {
            // Get the selected theme from settings
            string theme = Properties.Settings.Default.Theme;

            // Set the look-and-feel based on the selected theme
            if (theme == "2D")
            {
                // Set the 2D theme
                this.BackColor = SystemColors.Control;
                // Set other control styles as needed
            }
            else if (theme == "3D")
            {
                // Set the 3D theme
                this.BackColor = SystemColors.ControlDarkDark;
                // Set other control styles as needed
            }
        }

        private void ToolStripMenuItemTwo(object sender, EventArgs e)
        {
            // Set the theme
            Properties.Settings.Default.Theme = "2D";
            Properties.Settings.Default.Save();

            // Apply the theme
            ApplyTheme();
 
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void ToolStripMenuItemThree(object sender, EventArgs e)
        { 
            // Set the theme
            Properties.Settings.Default.Theme = "3D";
            Properties.Settings.Default.Save();
            ApplyTheme();
           
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {          
            if (isCheckBox == false)
            {
                var rectangle = new Rectangles();
                rectangle.Position = new Point(x, y);
                rectangle.Size = new Size(width, height);
                rectangle.Color = Color.Red;
                rectangle.Draw(e.Graphics);
            }
            else
            {
                var circle = new Circle();
                circle.Position = new Point(x, y);
                circle.Size = new Size(width, height);
                circle.Color = Color.Red;
                circle.Draw(e.Graphics);
            }
        }

        private void Add(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox3.Text)||
                string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox4.Text))
                return;
            
           dataGridView.Rows.Add(textBox1.Text, textBox3.Text, textBox2.Text, textBox4.Text);
        }

        private void Remove(object sender, EventArgs e)
        {
            selectedRow = dataGridView.CurrentCell.RowIndex;
            dataGridView.Rows.RemoveAt(selectedRow);
        }

        private void textBox_x(object sender, EventArgs e)
        {
            x = Convert.ToInt32(this.textBox1.Text);
        }

        private void textBox_y(object sender, EventArgs e)
        {
            y = Convert.ToInt32(this.textBox3.Text);
        }

        private void textBox_width(object sender, EventArgs e)
        {
            width = Convert.ToInt32(this.textBox2.Text);
        }

        private void textBox_height(object sender, EventArgs e)
        {
            height = Convert.ToInt32(this.textBox4.Text);
        }
             
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            var row  = dataGridView.Rows[selectedRow];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[1].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();     
        }
      
        public void datatablaToDataGrid(DataGridView dgv, DataTable datatable) 
        {
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                for (int j = 0; j < datatable.Columns.Count; j++)

                {
                    dgv.Rows[i].Cells[j].Value = datatable.Rows[i][j].ToString();
                }
            }
        }

        private void Undo(object sender, EventArgs e)
        {
          
        }

        private void Redo(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap printData = new Bitmap(dataGridView.Width, dataGridView.Height);
            dataGridView.DrawToBitmap(printData,new Rectangle (0, 0, dataGridView.Width, dataGridView.Height));
            e.Graphics.DrawImage(printData, 0, 0);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                isCheckBox = true;
            }
            else
            {
                isCheckBox = false;
            }    
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {           
        }
    }
}
