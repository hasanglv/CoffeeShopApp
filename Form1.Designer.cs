
namespace Coffe_Shop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idtext = new System.Windows.Forms.TextBox();
            this.namecombo = new System.Windows.Forms.ComboBox();
            this.typecombo = new System.Windows.Forms.ComboBox();
            this.quantitycombo = new System.Windows.Forms.ComboBox();
            this.paytext = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecoffee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insert = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(529, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coffee Shop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name Coffee :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(31, 614);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 45);
            this.label5.TabIndex = 4;
            this.label5.Text = "Payment :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(31, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 45);
            this.label6.TabIndex = 5;
            this.label6.Text = "Type :";
            // 
            // idtext
            // 
            this.idtext.BackColor = System.Drawing.Color.LightCyan;
            this.idtext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idtext.Location = new System.Drawing.Point(294, 198);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(308, 34);
            this.idtext.TabIndex = 6;
            this.idtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idtext_KeyPress);
            // 
            // namecombo
            // 
            this.namecombo.BackColor = System.Drawing.Color.LightCyan;
            this.namecombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.namecombo.FormattingEnabled = true;
            this.namecombo.Items.AddRange(new object[] {
            "AMERICANO",
            "LATTE",
            "MOCHA",
            "CAPPUCCINO",
            "ESPRESSO",
            "FLAT WHITE",
            "AU LAIT",
            "MACCHIATO",
            "RISTRETTO",
            "LUNGO"});
            this.namecombo.Location = new System.Drawing.Point(294, 308);
            this.namecombo.Name = "namecombo";
            this.namecombo.Size = new System.Drawing.Size(308, 36);
            this.namecombo.TabIndex = 7;
            // 
            // typecombo
            // 
            this.typecombo.BackColor = System.Drawing.Color.LightCyan;
            this.typecombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typecombo.FormattingEnabled = true;
            this.typecombo.Items.AddRange(new object[] {
            "FRAPP",
            "ICE",
            "HOT"});
            this.typecombo.Location = new System.Drawing.Point(294, 402);
            this.typecombo.Name = "typecombo";
            this.typecombo.Size = new System.Drawing.Size(308, 36);
            this.typecombo.TabIndex = 8;
            // 
            // quantitycombo
            // 
            this.quantitycombo.BackColor = System.Drawing.Color.LightCyan;
            this.quantitycombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantitycombo.FormattingEnabled = true;
            this.quantitycombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.quantitycombo.Location = new System.Drawing.Point(294, 505);
            this.quantitycombo.Name = "quantitycombo";
            this.quantitycombo.Size = new System.Drawing.Size(308, 36);
            this.quantitycombo.TabIndex = 9;
            // 
            // paytext
            // 
            this.paytext.BackColor = System.Drawing.Color.LightCyan;
            this.paytext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paytext.Location = new System.Drawing.Point(294, 626);
            this.paytext.Name = "paytext";
            this.paytext.Size = new System.Drawing.Size(308, 34);
            this.paytext.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.namecoffee,
            this.type,
            this.quantity,
            this.payment});
            this.dataGridView1.Location = new System.Drawing.Point(677, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(683, 337);
            this.dataGridView1.TabIndex = 11;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // namecoffee
            // 
            this.namecoffee.HeaderText = "Name Coffee";
            this.namecoffee.MinimumWidth = 6;
            this.namecoffee.Name = "namecoffee";
            this.namecoffee.Width = 125;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.Width = 125;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.Width = 125;
            // 
            // payment
            // 
            this.payment.HeaderText = "Payment  ";
            this.payment.MinimumWidth = 6;
            this.payment.Name = "payment";
            this.payment.Width = 125;
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.LightGreen;
            this.Insert.Location = new System.Drawing.Point(729, 559);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(135, 52);
            this.Insert.TabIndex = 12;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Location = new System.Drawing.Point(983, 559);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 52);
            this.button2.TabIndex = 13;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.Location = new System.Drawing.Point(1269, 668);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 53);
            this.button3.TabIndex = 14;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1402, 719);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.paytext);
            this.Controls.Add(this.quantitycombo);
            this.Controls.Add(this.typecombo);
            this.Controls.Add(this.namecombo);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "Form1";
            this.Text = "Coffee Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.ComboBox namecombo;
        private System.Windows.Forms.ComboBox typecombo;
        private System.Windows.Forms.ComboBox quantitycombo;
        private System.Windows.Forms.TextBox paytext;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecoffee;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
    }
}

