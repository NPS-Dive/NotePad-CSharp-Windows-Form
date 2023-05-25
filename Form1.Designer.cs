namespace WinFormsApp_06_DialogueBoxes
    {
    partial class Form1
        {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
            {
            if (disposing && (components != null))
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
            {
            textBox1 = new TextBox();
            BTNOpen = new Button();
            BTNSave = new Button();
            BTNFont = new Button();
            BTNColor = new Button();
            BTNFolder = new Button();
            colorDialog1 = new ColorDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            fontDialog1 = new FontDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(14, 10);
            textBox1.Margin = new Padding(5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(611, 515);
            textBox1.TabIndex = 0;
            textBox1.UseWaitCursor = true;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // BTNOpen
            // 
            BTNOpen.Font = new Font("Andalus", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTNOpen.Location = new Point(633, 12);
            BTNOpen.Name = "BTNOpen";
            BTNOpen.Size = new Size(155, 58);
            BTNOpen.TabIndex = 1;
            BTNOpen.Text = "Open";
            BTNOpen.UseVisualStyleBackColor = true;
            BTNOpen.Click += button1_Click;
            // 
            // BTNSave
            // 
            BTNSave.Font = new Font("Andalus", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTNSave.Location = new Point(633, 75);
            BTNSave.Name = "BTNSave";
            BTNSave.Size = new Size(155, 58);
            BTNSave.TabIndex = 2;
            BTNSave.Text = "Save";
            BTNSave.UseVisualStyleBackColor = true;
            BTNSave.Click += button2_Click;
            // 
            // BTNFont
            // 
            BTNFont.Font = new Font("Andalus", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTNFont.Location = new Point(633, 139);
            BTNFont.Name = "BTNFont";
            BTNFont.Size = new Size(155, 58);
            BTNFont.TabIndex = 3;
            BTNFont.Text = "Font";
            BTNFont.UseVisualStyleBackColor = true;
            BTNFont.Click += button3_Click;
            // 
            // BTNColor
            // 
            BTNColor.Font = new Font("Andalus", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTNColor.Location = new Point(633, 206);
            BTNColor.Name = "BTNColor";
            BTNColor.Size = new Size(155, 87);
            BTNColor.TabIndex = 4;
            BTNColor.Text = "BackGround Color";
            BTNColor.UseVisualStyleBackColor = true;
            BTNColor.Click += button4_Click;
            // 
            // BTNFolder
            // 
            BTNFolder.Font = new Font("Andalus", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTNFolder.Location = new Point(633, 299);
            BTNFolder.Name = "BTNFolder";
            BTNFolder.Size = new Size(155, 58);
            BTNFolder.TabIndex = 5;
            BTNFolder.Text = "Folder";
            BTNFolder.UseVisualStyleBackColor = true;
            BTNFolder.Click += button5_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 545);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 584);
            Controls.Add(label1);
            Controls.Add(BTNFolder);
            Controls.Add(BTNColor);
            Controls.Add(BTNFont);
            Controls.Add(BTNSave);
            Controls.Add(BTNOpen);
            Controls.Add(textBox1);
            ForeColor = Color.Green;
            Name = "Form1";
            Text = "NotePad | IPBSES";
            ResumeLayout(false);
            PerformLayout();
            }

        #endregion

        private TextBox textBox1;
        private Button BTNOpen;
        private Button BTNSave;
        private Button BTNFont;
        private Button BTNColor;
        private Button BTNFolder;
        private ColorDialog colorDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private FontDialog fontDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Label label1;
        }
    }