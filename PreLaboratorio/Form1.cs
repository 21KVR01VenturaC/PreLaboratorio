namespace PreLaboratorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,
            textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text); //Aquí lo que hacemos es pasar los datos de los TextBox al DataGridView
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = "";
            textBox6.Text = ""; textBox7.Text = ""; textBox8.Text = ""; textBox8.Text = ""; textBox10.Text = "";
            textBox11.Text = "";//Aquí a la hora de presionar el botón y haber pasado la información a la tabla, el texto que contiene cada TextBox se borrará
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;
            dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
            dataGridView1.CurrentRow.Cells[2].Value = textBox3.Text;
            dataGridView1.CurrentRow.Cells[3].Value = textBox4.Text;
            dataGridView1.CurrentRow.Cells[4].Value = textBox5.Text;
            dataGridView1.CurrentRow.Cells[5].Value = textBox6.Text;
            dataGridView1.CurrentRow.Cells[6].Value = textBox7.Text;
            dataGridView1.CurrentRow.Cells[7].Value = textBox8.Text;
            dataGridView1.CurrentRow.Cells[8].Value = textBox9.Text;
            dataGridView1.CurrentRow.Cells[9].Value = textBox10.Text;
            dataGridView1.CurrentRow.Cells[10].Value = textBox11.Text;
            //Con este botón, modificaré la fila seleccionada
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = "";
            textBox6.Text = ""; textBox7.Text = ""; textBox8.Text = ""; textBox8.Text = ""; textBox10.Text = "";
            textBox11.Text = "";//Aquí a la hora de presionar el botón y haber modificado la fila seleccionada, el texto que contiene cada TextBox se borrará
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

            textBox1.Text = fila.Cells[0].Value.ToString();
            textBox2.Text = fila.Cells[1].Value.ToString();
            textBox3.Text = fila.Cells[2].Value.ToString();
            textBox4.Text = fila.Cells[3].Value.ToString();
            textBox5.Text = fila.Cells[4].Value.ToString();
            textBox6.Text = fila.Cells[5].Value.ToString();
            textBox7.Text = fila.Cells[6].Value.ToString();
            textBox8.Text = fila.Cells[7].Value.ToString();
            textBox9.Text = fila.Cells[8].Value.ToString();
            textBox10.Text = fila.Cells[9].Value.ToString();
            textBox11.Text = fila.Cells[10].Value.ToString();
            //A la hora de presionar una fila de la tabla, los datos de la fila se pasaran a los TextBox
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            //Aquí eliminaré la fila seleccionada
        }
    }
}
