namespace IgraciTimovi
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputIgraci = new System.Windows.Forms.ListBox();
            this.actionNoviIgrac = new System.Windows.Forms.Button();
            this.inputIgrac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.actionNoviTim = new System.Windows.Forms.Button();
            this.outputIgraciUTimu = new System.Windows.Forms.ListBox();
            this.inputTim = new System.Windows.Forms.TextBox();
            this.outputTimovi = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.actionIgracUTim = new System.Windows.Forms.Button();
            this.actionIgracVan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputIgraci);
            this.groupBox1.Controls.Add(this.actionNoviIgrac);
            this.groupBox1.Controls.Add(this.inputIgrac);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 516);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Igraci";
            // 
            // outputIgraci
            // 
            this.outputIgraci.FormattingEnabled = true;
            this.outputIgraci.Location = new System.Drawing.Point(9, 48);
            this.outputIgraci.Name = "outputIgraci";
            this.outputIgraci.Size = new System.Drawing.Size(311, 459);
            this.outputIgraci.TabIndex = 3;
            // 
            // actionNoviIgrac
            // 
            this.actionNoviIgrac.Location = new System.Drawing.Point(245, 20);
            this.actionNoviIgrac.Name = "actionNoviIgrac";
            this.actionNoviIgrac.Size = new System.Drawing.Size(75, 23);
            this.actionNoviIgrac.TabIndex = 2;
            this.actionNoviIgrac.Text = "Dodaj";
            this.actionNoviIgrac.UseVisualStyleBackColor = true;
            this.actionNoviIgrac.Click += new System.EventHandler(this.actionNoviIgrac_Click);
            // 
            // inputIgrac
            // 
            this.inputIgrac.Location = new System.Drawing.Point(36, 22);
            this.inputIgrac.Name = "inputIgrac";
            this.inputIgrac.Size = new System.Drawing.Size(203, 20);
            this.inputIgrac.TabIndex = 1;
            this.inputIgrac.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputIgrac_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.actionNoviTim);
            this.groupBox2.Controls.Add(this.outputIgraciUTimu);
            this.groupBox2.Controls.Add(this.inputTim);
            this.groupBox2.Controls.Add(this.outputTimovi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(434, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 516);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Timovi";
            // 
            // actionNoviTim
            // 
            this.actionNoviTim.Location = new System.Drawing.Point(245, 20);
            this.actionNoviTim.Name = "actionNoviTim";
            this.actionNoviTim.Size = new System.Drawing.Size(75, 23);
            this.actionNoviTim.TabIndex = 5;
            this.actionNoviTim.Text = "Dodaj";
            this.actionNoviTim.UseVisualStyleBackColor = true;
            this.actionNoviTim.Click += new System.EventHandler(this.actionNoviTim_Click);
            // 
            // outputIgraciUTimu
            // 
            this.outputIgraciUTimu.FormattingEnabled = true;
            this.outputIgraciUTimu.Location = new System.Drawing.Point(6, 250);
            this.outputIgraciUTimu.Name = "outputIgraciUTimu";
            this.outputIgraciUTimu.Size = new System.Drawing.Size(314, 264);
            this.outputIgraciUTimu.TabIndex = 1;
            // 
            // inputTim
            // 
            this.inputTim.Location = new System.Drawing.Point(36, 22);
            this.inputTim.Name = "inputTim";
            this.inputTim.Size = new System.Drawing.Size(203, 20);
            this.inputTim.TabIndex = 4;
            this.inputTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTim_KeyDown);
            // 
            // outputTimovi
            // 
            this.outputTimovi.FormattingEnabled = true;
            this.outputTimovi.Location = new System.Drawing.Point(6, 45);
            this.outputTimovi.Name = "outputTimovi";
            this.outputTimovi.Size = new System.Drawing.Size(314, 199);
            this.outputTimovi.TabIndex = 0;
            this.outputTimovi.SelectedIndexChanged += new System.EventHandler(this.outputTimovi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime";
            // 
            // actionIgracUTim
            // 
            this.actionIgracUTim.Location = new System.Drawing.Point(361, 322);
            this.actionIgracUTim.Name = "actionIgracUTim";
            this.actionIgracUTim.Size = new System.Drawing.Size(55, 54);
            this.actionIgracUTim.TabIndex = 2;
            this.actionIgracUTim.Text = ">";
            this.actionIgracUTim.UseVisualStyleBackColor = true;
            this.actionIgracUTim.Click += new System.EventHandler(this.actionIgracUTim_Click);
            // 
            // actionIgracVan
            // 
            this.actionIgracVan.Location = new System.Drawing.Point(361, 407);
            this.actionIgracVan.Name = "actionIgracVan";
            this.actionIgracVan.Size = new System.Drawing.Size(55, 54);
            this.actionIgracVan.TabIndex = 3;
            this.actionIgracVan.Text = "<";
            this.actionIgracVan.UseVisualStyleBackColor = true;
            this.actionIgracVan.Click += new System.EventHandler(this.actionIgracVan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 540);
            this.Controls.Add(this.actionIgracVan);
            this.Controls.Add(this.actionIgracUTim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox outputIgraci;
        private System.Windows.Forms.Button actionNoviIgrac;
        private System.Windows.Forms.TextBox inputIgrac;
        private System.Windows.Forms.Button actionNoviTim;
        private System.Windows.Forms.ListBox outputIgraciUTimu;
        private System.Windows.Forms.TextBox inputTim;
        private System.Windows.Forms.ListBox outputTimovi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button actionIgracUTim;
        private System.Windows.Forms.Button actionIgracVan;
    }
}

