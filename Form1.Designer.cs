namespace calculator
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
            
            
            openMenue = new Label();
            modeLabel = new Label();
            menue = new ListBox();
            SuspendLayout();
            changeToNormal();
            
            // 
            // openMenue
            // 
            openMenue.AutoSize = true;
            openMenue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openMenue.ForeColor = SystemColors.ButtonHighlight;
            openMenue.Location = new Point(430, 9);
            openMenue.Name = "openMenue";
            openMenue.Size = new Size(46, 31);
            openMenue.TabIndex = 26;
            openMenue.Text = "\U0001f7f0";
            openMenue.Click += openMenue_Click;
            // 
            // modeLabel
            // 
            modeLabel.AutoSize = true;
            modeLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modeLabel.ForeColor = SystemColors.ButtonHighlight;
            modeLabel.Location = new Point(368, 9);
            modeLabel.Name = "modeLabel";
            modeLabel.Size = new Size(56, 31);
            modeLabel.TabIndex = 27;
            modeLabel.Text = "רגיל";
            // 
            // menue
            // 
            menue.BackColor = Color.FromArgb(44, 44, 44);
            menue.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menue.ForeColor = Color.White;
            menue.FormattingEnabled = true;
            menue.Visible = false;
            menue.ItemHeight = 41;
            menue.Items.AddRange(new object[] { "  רגיל", " מתכנת  " });
            //add event handler to the menue options
            menue.SelectedIndexChanged += new EventHandler(menue_SelectedIndexChanged);
            menue.Location = new Point(274, 54);
            menue.Name = "menue";
            menue.RightToLeft = RightToLeft.Yes;
            menue.Size = new Size(214, 701);
            menue.TabIndex = 31;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(488, 778);
            Controls.Add(menue);
            Controls.Add(modeLabel);
            Controls.Add(openMenue);
            Controls.Add(solution);
            Controls.Add(solve);
            Controls.Add(delete);
            Controls.Add(clear);
            Controls.Add(clearE);
            Controls.Add(precent);
            Controls.Add(devide);
            Controls.Add(root);
            Controls.Add(pow);
            Controls.Add(oneDevide);
            Controls.Add(multi);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(sub);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(add);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(equals);
            Controls.Add(dot);
            Controls.Add(zero);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void menue_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change the mode label
            modeLabel.Text = menue.SelectedItem.ToString().Trim();
            //change the mode
            if (menue.SelectedItem.ToString().Trim() == "רגיל")
            {
                mode = Emode.regular;
                menue.Visible = false;
                changeToNormal();
            }
            else if (menue.SelectedItem.ToString().Trim() == "מתכנת")
            {
                mode = Emode.programmer;
                menue.Visible = false;
                changeToProggremmer();
            }
        }

        private void changeToNormal()
        {

            button1 = new Button();
            zero = new Button();
            dot = new Button();
            equals = new Button();
            one = new Button();
            two = new Button();
            three = new Button();
            add = new Button();
            four = new Button();
            five = new Button();
            six = new Button();
            sub = new Button();
            seven = new Button();
            eight = new Button();
            nine = new Button();
            multi = new Button();
            devide = new Button();
            root = new Button();
            pow = new Button();
            oneDevide = new Button();
            delete = new Button();
            clear = new Button();
            clearE = new Button();
            precent = new Button();
            solve = new TextBox();
            solution = new TextBox();
            Button[] buttons = { button1, zero, dot, equals, one, two, three, add, four, five, six, sub, seven, eight, nine, multi, oneDevide, pow, root, devide, precent, clearE, clear, delete };
            EventHandler[] eventButtons = { button1_Click, zero_Click, dot_Click, equals_Click, one_Click, two_Click, three_Click, add_Click, four_Click, five_Click, six_Click, sub_Click, seven_Click, eight_Click, nine_Click, multi_Click, oneDevide_Click, pow_Click, root_Click, devide_Click, precent_Click, clearE_Click, clear_Click, delete_Click };
            string[] textButton = {"+/-", "0", ".", "=", "1", "2", "3", "+", "4", "5", "6", "-", "7", "8", "9", "x", "1/x", "x^2", "√", "/", "%", "CE", "C", "⌫" }; 
            //organize the buttons: 6 rows and 4 columns
            int x = 12, y = 198, width = 111, height = 86;
            for(int i = 0;i<6;i++)
            {
                for(int j = 0;j<4;j++)
                {
                    //the higher row will be: %, CE, C, ⌫
                    //the second row will be: 1/x, x^2, √, /
                    //the third row will be: 7, 8, 9, *
                    //the fourth row will be: 4, 5, 6, -
                    //the fifth row will be: 1, 2, 3, +
                    //the sixth row will be: +/-, 0, ., =
                    //the button in 2 the first ros and the button in 1 last column will be in color: 50, 50, 50
                    //all the other buttons will be in color: 59, 59, 59

                    buttons[i * 4 + j].Location = new Point(x + j * (width + 6), y + (5 - i) * (height + 6));
                    buttons[i * 4 + j].Size = new Size(width, height);
                    buttons[i * 4 + j].Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    buttons[i * 4 + j].ForeColor = Color.White;
                    if (i == 0 && j == 3)
                        buttons[i * 4 + j].BackColor = Color.FromArgb(194, 185, 134);

                    else if (i >= 4 || j == 3)
                        buttons[i * 4 + j].BackColor = Color.FromArgb(50, 50, 50);
                    else
                        buttons[i * 4 + j].BackColor = Color.FromArgb(59, 59, 59);
                    //round the corners of the buttons
                    //how to round the corners of a button: https://stackoverflow.com/questions/18822067/how-to-make-a-button-have-rounded-corners
                    float radius = 20;
                    System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                    path.AddArc(0, 0, radius, radius, 180, 90);
                    path.AddArc(buttons[i * 4 + j].Width - radius, 0, radius, radius, 270, 90);
                    path.AddArc(buttons[i * 4 + j].Width - radius, buttons[i * 4 + j].Height - radius, radius, radius, 0, 90);
                    path.AddArc(0, buttons[i * 4 + j].Height - radius, radius, radius, 90, 90);
                    buttons[i * 4 + j].Region = new Region(path);
                    
                    buttons[i * 4 + j].FlatStyle = FlatStyle.Flat;
                    buttons[i * 4 + j].FlatAppearance.BorderSize = 0;
                    buttons[i * 4 + j].Text = textButton[i * 4 + j];
                    buttons[i * 4 + j].TextAlign = ContentAlignment.MiddleCenter;
                    buttons[i * 4 + j].Click += eventButtons[i * 4 + j];
                    Controls.Add(buttons[i * 4 + j]);

                }
            }



            // 
            // solve
            // 
            solve.BackColor = Color.FromArgb(32, 32, 32);
            solve.BorderStyle = BorderStyle.None;
            solve.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            solve.ForeColor = Color.White;
            solve.Location = new Point(12, 112);
            solve.Name = "solve";
            solve.RightToLeft = RightToLeft.No;
            solve.Size = new Size(444, 80);
            solve.TabIndex = 24;
            solve.Text = "0";
            solve.TextAlign = HorizontalAlignment.Right;
            solve.TextChanged += textBox1_TextChanged;
            // 
            // solution
            // 
            solution.BackColor = Color.FromArgb(32, 32, 32);
            solution.BorderStyle = BorderStyle.None;
            solution.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            solution.ForeColor = Color.White;
            solution.Location = new Point(12, 82);
            solution.Name = "solution";
            solution.RightToLeft = RightToLeft.No;
            solution.Size = new Size(435, 24);
            solution.TabIndex = 25;
            solution.TextAlign = HorizontalAlignment.Right;
            solution.TextChanged += textBox3_TextChanged;
        }

        #endregion

        private Button button1;
        private Button zero;
        private Button dot;
        private Button equals;
        private Button one;
        private Button two;
        private Button three;
        private Button add;
        private Button four;
        private Button five;
        private Button six;
        private Button sub;
        private Button seven;
        private Button eight;
        private Button nine;
        private Button multi;
        private Button devide;
        private Button root;
        private Button pow;
        private Button oneDevide;
        private Button delete;
        private Button clear;
        private Button clearE;
        private Button precent;
        private TextBox solve;
        private TextBox solution;
        private Label openMenue;
        private Label modeLabel;
        private ListBox menue;
    }
}
