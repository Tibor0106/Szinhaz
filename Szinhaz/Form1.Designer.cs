namespace Szinhaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            sor = new TextBox();
            oszlop = new TextBox();
            Foglaltsag = new Button();
            Stat = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 34);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "Sor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 73);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Oszlop:";
            // 
            // sor
            // 
            sor.Location = new Point(90, 31);
            sor.Name = "sor";
            sor.Size = new Size(51, 23);
            sor.TabIndex = 2;
            // 
            // oszlop
            // 
            oszlop.Location = new Point(90, 65);
            oszlop.Name = "oszlop";
            oszlop.Size = new Size(51, 23);
            oszlop.TabIndex = 3;
            // 
            // Foglaltsag
            // 
            Foglaltsag.Location = new Point(35, 214);
            Foglaltsag.Name = "Foglaltsag";
            Foglaltsag.Size = new Size(121, 59);
            Foglaltsag.TabIndex = 5;
            Foglaltsag.Text = "Foglaltság";
            Foglaltsag.UseVisualStyleBackColor = true;
            Foglaltsag.Click += Foglaltsag_Click;
            // 
            // Stat
            // 
            Stat.Location = new Point(194, 214);
            Stat.Name = "Stat";
            Stat.Size = new Size(121, 59);
            Stat.TabIndex = 6;
            Stat.Text = "Statisztika";
            Stat.UseVisualStyleBackColor = true;
            Stat.Click += Stat_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(352, 214);
            Exit.Name = "Exit";
            Exit.Size = new Size(121, 59);
            Exit.TabIndex = 7;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(513, 295);
            Controls.Add(Exit);
            Controls.Add(Stat);
            Controls.Add(Foglaltsag);
            Controls.Add(oszlop);
            Controls.Add(sor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Adatfelvitel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox sor;
        private TextBox oszlop;
        private Button Foglaltsag;
        private Button Stat;
        private Button Exit;
    }
}
