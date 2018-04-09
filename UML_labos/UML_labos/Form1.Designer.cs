namespace UML_labos
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.actionAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputItems = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.actionAddToBill = new System.Windows.Forms.Button();
            this.outputBill = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(6, 45);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(100, 20);
            this.inputName.TabIndex = 1;
            // 
            // inputPrice
            // 
            this.inputPrice.Location = new System.Drawing.Point(6, 93);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(100, 20);
            this.inputPrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cijena";
            // 
            // inputQuantity
            // 
            this.inputQuantity.Location = new System.Drawing.Point(6, 140);
            this.inputQuantity.Name = "inputQuantity";
            this.inputQuantity.Size = new System.Drawing.Size(100, 20);
            this.inputQuantity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kolicina";
            // 
            // actionAdd
            // 
            this.actionAdd.Location = new System.Drawing.Point(112, 138);
            this.actionAdd.Name = "actionAdd";
            this.actionAdd.Size = new System.Drawing.Size(75, 23);
            this.actionAdd.TabIndex = 6;
            this.actionAdd.Text = "Dodaj";
            this.actionAdd.UseVisualStyleBackColor = true;
            this.actionAdd.Click += new System.EventHandler(this.actionAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputItems);
            this.groupBox1.Controls.Add(this.inputPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputName);
            this.groupBox1.Controls.Add(this.actionAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputQuantity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 456);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artikli";
            // 
            // outputItems
            // 
            this.outputItems.FormattingEnabled = true;
            this.outputItems.Location = new System.Drawing.Point(6, 173);
            this.outputItems.Name = "outputItems";
            this.outputItems.Size = new System.Drawing.Size(342, 277);
            this.outputItems.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outputBill);
            this.groupBox2.Location = new System.Drawing.Point(417, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 456);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Racun";
            // 
            // actionAddToBill
            // 
            this.actionAddToBill.Location = new System.Drawing.Point(372, 267);
            this.actionAddToBill.Name = "actionAddToBill";
            this.actionAddToBill.Size = new System.Drawing.Size(39, 37);
            this.actionAddToBill.TabIndex = 11;
            this.actionAddToBill.Text = ">";
            this.actionAddToBill.UseVisualStyleBackColor = true;
            this.actionAddToBill.Click += new System.EventHandler(this.actionAddToBill_Click);
            // 
            // outputBill
            // 
            this.outputBill.FormattingEnabled = true;
            this.outputBill.Location = new System.Drawing.Point(6, 19);
            this.outputBill.Name = "outputBill";
            this.outputBill.Size = new System.Drawing.Size(390, 433);
            this.outputBill.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 480);
            this.Controls.Add(this.actionAddToBill);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button actionAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox outputItems;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button actionAddToBill;
        private System.Windows.Forms.ListBox outputBill;
    }
}

