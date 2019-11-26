namespace storage_project
{
    partial class AddNewItemForm
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
            this.itemName = new System.Windows.Forms.TextBox();
            this.itemWeight = new System.Windows.Forms.TextBox();
            this.itemVolume = new System.Windows.Forms.TextBox();
            this.itemAmount = new System.Windows.Forms.TextBox();
            this.itemSupplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(44, 32);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(194, 20);
            this.itemName.TabIndex = 0;
            // 
            // itemWeight
            // 
            this.itemWeight.Location = new System.Drawing.Point(44, 83);
            this.itemWeight.Name = "itemWeight";
            this.itemWeight.Size = new System.Drawing.Size(194, 20);
            this.itemWeight.TabIndex = 1;
            // 
            // itemVolume
            // 
            this.itemVolume.Location = new System.Drawing.Point(44, 135);
            this.itemVolume.Name = "itemVolume";
            this.itemVolume.Size = new System.Drawing.Size(194, 20);
            this.itemVolume.TabIndex = 2;
            // 
            // itemAmount
            // 
            this.itemAmount.Location = new System.Drawing.Point(44, 183);
            this.itemAmount.Name = "itemAmount";
            this.itemAmount.Size = new System.Drawing.Size(194, 20);
            this.itemAmount.TabIndex = 3;
            // 
            // itemSupplier
            // 
            this.itemSupplier.Location = new System.Drawing.Point(44, 232);
            this.itemSupplier.Name = "itemSupplier";
            this.itemSupplier.Size = new System.Drawing.Size(194, 20);
            this.itemSupplier.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Наименование товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вес товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Объём товара";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество товара";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Поставщик";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemSupplier);
            this.Controls.Add(this.itemAmount);
            this.Controls.Add(this.itemVolume);
            this.Controls.Add(this.itemWeight);
            this.Controls.Add(this.itemName);
            this.Name = "AddNewItemForm";
            this.Text = "AddNewItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.TextBox itemWeight;
        private System.Windows.Forms.TextBox itemVolume;
        private System.Windows.Forms.TextBox itemAmount;
        private System.Windows.Forms.TextBox itemSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}