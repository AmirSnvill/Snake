namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            bleft = new Button();
            bup = new Button();
            bright = new Button();
            bdown = new Button();
            snhe = new Label();
            body = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(476, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // bleft
            // 
            bleft.Location = new Point(109, 15);
            bleft.Name = "bleft";
            bleft.Size = new Size(29, 29);
            bleft.TabIndex = 2;
            bleft.Text = ">";
            bleft.UseVisualStyleBackColor = true;
            bleft.Click += bleft_Click;
            // 
            // bup
            // 
            bup.Location = new Point(136, -2);
            bup.Name = "bup";
            bup.Size = new Size(29, 30);
            bup.TabIndex = 2;
            bup.Text = ">";
            bup.UseVisualStyleBackColor = true;
            bup.Click += bup_Click;
            // 
            // bright
            // 
            bright.Location = new Point(164, 16);
            bright.Name = "bright";
            bright.Size = new Size(29, 29);
            bright.TabIndex = 2;
            bright.Text = ">";
            bright.UseVisualStyleBackColor = true;
            bright.Click += bright_Click;
            // 
            // bdown
            // 
            bdown.Location = new Point(136, 33);
            bdown.Name = "bdown";
            bdown.Size = new Size(29, 29);
            bdown.TabIndex = 2;
            bdown.Text = ">";
            bdown.UseVisualStyleBackColor = true;
            bdown.Click += bdown_Click;
            // 
            // snhe
            // 
            snhe.BackColor = SystemColors.ButtonHighlight;
            snhe.Location = new Point(251, 262);
            snhe.Margin = new Padding(1);
            snhe.Name = "snhe";
            snhe.Size = new Size(25, 25);
            snhe.TabIndex = 0;
            snhe.Text = "::()";
            // 
            // body
            // 
            body.BackColor = SystemColors.ButtonHighlight;
            body.Location = new Point(224, 262);
            body.Margin = new Padding(1);
            body.Name = "body";
            body.Size = new Size(25, 25);
            body.TabIndex = 0;
            body.Click += body_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 453);
            Controls.Add(body);
            Controls.Add(bdown);
            Controls.Add(snhe);
            Controls.Add(bright);
            Controls.Add(bup);
            Controls.Add(bleft);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Button bleft;
        private Button bup;
        private Button bright;
        private Button bdown;
        private Label snhe;
        private Label body;
    }
}
