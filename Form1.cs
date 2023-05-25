namespace WinFormsApp_06_DialogueBoxes
    {
    public partial class Form1 : Form
        {
        public Form1 ()
            {
            InitializeComponent();
            }
        String fileName;
        private void textBox1_TextChanged ( object sender, EventArgs e )
            {

            }

        private void button1_Click ( object sender, EventArgs e )
            {
            openFileDialog1.Filter = " txt File (*.txt)|*.txt| Word File (*.doc)|*.doc| new Word File (*.docx)|*.docx| All file (*.*)|*.*";
            openFileDialog1.Title = "IPBSES NotePad open dialogue ...";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                fileName = openFileDialog1.FileName;
                textBox1.Text = System.IO.File.ReadAllText(fileName);
                }
            }

        private void button5_Click ( object sender, EventArgs e )
            {
            folderBrowserDialog1.Description = "Select Folder ...";
            folderBrowserDialog1.ShowNewFolderButton = true;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                label1.Text = folderBrowserDialog1.SelectedPath;
                }
            }

        private void button4_Click ( object sender, EventArgs e )
            {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                textBox1.BackColor = colorDialog1.Color;
                }
            }

        private void button3_Click ( object sender, EventArgs e )
            {
            fontDialog1.ShowColor = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
                }
            }

        private void button6_Click ( object sender, EventArgs e )
            {
            }

        private void button2_Click ( object sender, EventArgs e )
            {
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = " txt File (*.txt)|*.txt| Word File (*.doc)|*.doc| new Word File (*.docx)|*.docx| All file (*.*)|*.*";
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.Title = "IPBSES NotePad Save Dialogue ...";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                fileName = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(fileName, textBox1.Text);
                }

            }
        }
    }