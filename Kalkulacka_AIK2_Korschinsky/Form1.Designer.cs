namespace kalkuládora
{
    partial class kalkulacka
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
        private void InitializeComponent()
        {
            zadanitextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            delenibutton = new Button();
            CEbutton = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            C_button = new Button();
            nasobenibutton = new Button();
            odcitanibutton = new Button();
            scitanibutton = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            nulabutton = new Button();
            rovnasebutton = new Button();
            prikladTextBox = new TextBox();
            SuspendLayout();
            // 
            // zadanitextBox
            // 
            zadanitextBox.BackColor = SystemColors.HighlightText;
            zadanitextBox.BorderStyle = BorderStyle.FixedSingle;
            zadanitextBox.Enabled = false;
            zadanitextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            zadanitextBox.Location = new Point(22, 38);
            zadanitextBox.Name = "zadanitextBox";
            zadanitextBox.Size = new Size(230, 29);
            zadanitextBox.TabIndex = 0;
            zadanitextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Location = new Point(22, 73);
            button1.Name = "button1";
            button1.Size = new Size(37, 41);
            button1.TabIndex = 1;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = false;
            button1.Click += nulabutton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Location = new Point(65, 73);
            button2.Name = "button2";
            button2.Size = new Size(37, 41);
            button2.TabIndex = 2;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = false;
            button2.Click += nulabutton_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 192);
            button3.Location = new Point(108, 73);
            button3.Name = "button3";
            button3.Size = new Size(37, 41);
            button3.TabIndex = 3;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = false;
            button3.Click += nulabutton_Click;
            // 
            // delenibutton
            // 
            delenibutton.BackColor = Color.FromArgb(224, 224, 224);
            delenibutton.Location = new Point(215, 73);
            delenibutton.Name = "delenibutton";
            delenibutton.Size = new Size(37, 41);
            delenibutton.TabIndex = 4;
            delenibutton.Text = "/";
            delenibutton.UseVisualStyleBackColor = false;
            delenibutton.Click += delenibutton_Click;
            // 
            // CEbutton
            // 
            CEbutton.BackColor = Color.Red;
            CEbutton.Location = new Point(65, 308);
            CEbutton.Name = "CEbutton";
            CEbutton.Size = new Size(37, 41);
            CEbutton.TabIndex = 5;
            CEbutton.Text = "CE";
            CEbutton.TextImageRelation = TextImageRelation.TextAboveImage;
            CEbutton.UseVisualStyleBackColor = false;
            CEbutton.Click += CEbutton_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 192, 192);
            button6.Location = new Point(22, 120);
            button6.Name = "button6";
            button6.Size = new Size(37, 41);
            button6.TabIndex = 6;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = false;
            button6.Click += nulabutton_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 192, 192);
            button7.Location = new Point(65, 120);
            button7.Name = "button7";
            button7.Size = new Size(37, 41);
            button7.TabIndex = 7;
            button7.Text = "5";
            button7.UseVisualStyleBackColor = false;
            button7.Click += nulabutton_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 192, 192);
            button8.Location = new Point(108, 120);
            button8.Name = "button8";
            button8.Size = new Size(37, 41);
            button8.TabIndex = 8;
            button8.Text = "6";
            button8.UseVisualStyleBackColor = false;
            button8.Click += nulabutton_Click;
            // 
            // C_button
            // 
            C_button.BackColor = Color.Red;
            C_button.Location = new Point(22, 308);
            C_button.Name = "C_button";
            C_button.Size = new Size(37, 41);
            C_button.TabIndex = 9;
            C_button.Text = "C";
            C_button.UseVisualStyleBackColor = false;
            C_button.Click += C_button_Click;
            // 
            // nasobenibutton
            // 
            nasobenibutton.BackColor = Color.FromArgb(224, 224, 224);
            nasobenibutton.Location = new Point(215, 120);
            nasobenibutton.Name = "nasobenibutton";
            nasobenibutton.Size = new Size(37, 41);
            nasobenibutton.TabIndex = 10;
            nasobenibutton.Text = "*";
            nasobenibutton.UseVisualStyleBackColor = false;
            nasobenibutton.Click += nasobenibutton_Click;
            // 
            // odcitanibutton
            // 
            odcitanibutton.BackColor = Color.FromArgb(224, 224, 224);
            odcitanibutton.Location = new Point(215, 167);
            odcitanibutton.Name = "odcitanibutton";
            odcitanibutton.Size = new Size(37, 41);
            odcitanibutton.TabIndex = 11;
            odcitanibutton.Text = "-";
            odcitanibutton.UseVisualStyleBackColor = false;
            odcitanibutton.Click += odcitanibutton_Click;
            // 
            // scitanibutton
            // 
            scitanibutton.BackColor = Color.Lavender;
            scitanibutton.Location = new Point(215, 214);
            scitanibutton.Name = "scitanibutton";
            scitanibutton.Size = new Size(37, 88);
            scitanibutton.TabIndex = 12;
            scitanibutton.Text = "+";
            scitanibutton.UseVisualStyleBackColor = false;
            scitanibutton.Click += scitanibutton_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(255, 192, 192);
            button13.Location = new Point(22, 167);
            button13.Name = "button13";
            button13.Size = new Size(37, 41);
            button13.TabIndex = 13;
            button13.Text = "1";
            button13.UseVisualStyleBackColor = false;
            button13.Click += nulabutton_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(255, 192, 192);
            button14.Location = new Point(65, 167);
            button14.Name = "button14";
            button14.Size = new Size(37, 41);
            button14.TabIndex = 14;
            button14.Text = "2";
            button14.UseVisualStyleBackColor = false;
            button14.Click += nulabutton_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(255, 192, 192);
            button15.Location = new Point(108, 167);
            button15.Name = "button15";
            button15.Size = new Size(37, 41);
            button15.TabIndex = 15;
            button15.Text = "3";
            button15.UseVisualStyleBackColor = false;
            button15.Click += nulabutton_Click;
            // 
            // nulabutton
            // 
            nulabutton.BackColor = Color.FromArgb(255, 192, 192);
            nulabutton.Location = new Point(22, 214);
            nulabutton.Name = "nulabutton";
            nulabutton.Size = new Size(37, 41);
            nulabutton.TabIndex = 16;
            nulabutton.Text = "0";
            nulabutton.UseVisualStyleBackColor = false;
            nulabutton.Click += nulabutton_Click;
            // 
            // rovnasebutton
            // 
            rovnasebutton.BackColor = Color.Lime;
            rovnasebutton.BackgroundImageLayout = ImageLayout.None;
            rovnasebutton.FlatStyle = FlatStyle.Popup;
            rovnasebutton.Location = new Point(22, 261);
            rovnasebutton.Name = "rovnasebutton";
            rovnasebutton.Size = new Size(187, 41);
            rovnasebutton.TabIndex = 17;
            rovnasebutton.Text = "=";
            rovnasebutton.UseVisualStyleBackColor = false;
            rovnasebutton.Click += rovnasebutton_Click;
            // 
            // prikladTextBox
            // 
            prikladTextBox.Enabled = false;
            prikladTextBox.Location = new Point(152, 9);
            prikladTextBox.Name = "prikladTextBox";
            prikladTextBox.Size = new Size(100, 23);
            prikladTextBox.TabIndex = 18;
            prikladTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // kalkulacka
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(284, 361);
            Controls.Add(prikladTextBox);
            Controls.Add(rovnasebutton);
            Controls.Add(nulabutton);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(scitanibutton);
            Controls.Add(odcitanibutton);
            Controls.Add(nasobenibutton);
            Controls.Add(C_button);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(CEbutton);
            Controls.Add(delenibutton);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(zadanitextBox);
            Name = "kalkulacka";
            Text = "kalkulačka";
            Load += kalkulacka_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox zadanitextBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button delenibutton;
        private Button CEbutton;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button C_button;
        private Button nasobenibutton;
        private Button odcitanibutton;
        private Button scitanibutton;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button nulabutton;
        private Button rovnasebutton;
        private TextBox prikladTextBox;
    }
}
