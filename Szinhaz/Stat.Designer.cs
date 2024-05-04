namespace Szinhaz
{
    partial class Stat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            osszesfoglalas = new Label();
            vaneures = new Label();
            tizes = new Label();
            Osszes = new Button();
            UresSor = new Button();
            Tiznel = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // osszesfoglalas
            // 
            osszesfoglalas.AutoSize = true;
            osszesfoglalas.Location = new Point(135, 29);
            osszesfoglalas.Name = "osszesfoglalas";
            osszesfoglalas.Size = new Size(0, 15);
            osszesfoglalas.TabIndex = 0;
            // 
            // vaneures
            // 
            vaneures.AutoSize = true;
            vaneures.Location = new Point(135, 80);
            vaneures.Name = "vaneures";
            vaneures.Size = new Size(0, 15);
            vaneures.TabIndex = 1;
            // 
            // tizes
            // 
            tizes.AutoSize = true;
            tizes.Location = new Point(135, 129);
            tizes.Name = "tizes";
            tizes.Size = new Size(0, 15);
            tizes.TabIndex = 2;
            // 
            // Osszes
            // 
            Osszes.Location = new Point(12, 20);
            Osszes.Name = "Osszes";
            Osszes.Size = new Size(117, 32);
            Osszes.TabIndex = 3;
            Osszes.Text = "Osszes foglaltság";
            Osszes.UseVisualStyleBackColor = true;
            Osszes.Click += Osszes_Click;
            // 
            // UresSor
            // 
            UresSor.Location = new Point(12, 73);
            UresSor.Name = "UresSor";
            UresSor.Size = new Size(117, 29);
            UresSor.TabIndex = 4;
            UresSor.Text = "Van-e üres sor?";
            UresSor.UseVisualStyleBackColor = true;
            UresSor.Click += UresSor_Click;
            // 
            // Tiznel
            // 
            Tiznel.Location = new Point(12, 114);
            Tiznel.Name = "Tiznel";
            Tiznel.Size = new Size(117, 53);
            Tiznel.TabIndex = 5;
            Tiznel.Text = "10-nél több foglalásó sor sb száma";
            Tiznel.UseVisualStyleBackColor = true;
            Tiznel.Click += Tiznel_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(279, 144);
            Exit.Name = "Exit";
            Exit.Size = new Size(75, 23);
            Exit.TabIndex = 6;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Stat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 179);
            Controls.Add(Exit);
            Controls.Add(Tiznel);
            Controls.Add(UresSor);
            Controls.Add(Osszes);
            Controls.Add(tizes);
            Controls.Add(vaneures);
            Controls.Add(osszesfoglalas);
            Name = "Stat";
            Text = "Stat";
            Load += Stat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label osszesfoglalas;
        private Label vaneures;
        private Label tizes;
        private Button Osszes;
        private Button UresSor;
        private Button Tiznel;
        private Button Exit;
    }
}