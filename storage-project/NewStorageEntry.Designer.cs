namespace storage_project
{
    partial class NewStorageEntry
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.TextBox();
            this.itemCode = new System.Windows.Forms.TextBox();
            this.itemWeight = new System.Windows.Forms.TextBox();
            this.itemVolume = new System.Windows.Forms.TextBox();
            this.endOfItemStoraging = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.itemOwner = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.itemNumberOfRack = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(142, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(491, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите данные о товаре для его заполнения в базу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Код товара";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вес товара";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Объём товара";
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(146, 72);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(100, 20);
            this.itemName.TabIndex = 5;
            // 
            // itemCode
            // 
            this.itemCode.Location = new System.Drawing.Point(146, 111);
            this.itemCode.Name = "itemCode";
            this.itemCode.Size = new System.Drawing.Size(100, 20);
            this.itemCode.TabIndex = 6;
            // 
            // itemWeight
            // 
            this.itemWeight.Location = new System.Drawing.Point(146, 151);
            this.itemWeight.Name = "itemWeight";
            this.itemWeight.Size = new System.Drawing.Size(100, 20);
            this.itemWeight.TabIndex = 7;
            // 
            // itemVolume
            // 
            this.itemVolume.Location = new System.Drawing.Point(146, 186);
            this.itemVolume.Name = "itemVolume";
            this.itemVolume.Size = new System.Drawing.Size(100, 20);
            this.itemVolume.TabIndex = 8;
            // 
            // endOfItemStoraging
            // 
            this.endOfItemStoraging.Location = new System.Drawing.Point(146, 223);
            this.endOfItemStoraging.Name = "endOfItemStoraging";
            this.endOfItemStoraging.Size = new System.Drawing.Size(200, 20);
            this.endOfItemStoraging.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(42, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дата окончания срока хранения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Владелец";
            // 
            // itemOwner
            // 
            this.itemOwner.Location = new System.Drawing.Point(146, 324);
            this.itemOwner.Name = "itemOwner";
            this.itemOwner.Size = new System.Drawing.Size(100, 20);
            this.itemOwner.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(603, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 103);
            this.button1.TabIndex = 13;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 103);
            this.button2.TabIndex = 14;
            this.button2.Text = "Ввести товар в базу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Номер полки";
            // 
            // itemNumberOfRack
            // 
            this.itemNumberOfRack.Location = new System.Drawing.Point(146, 267);
            this.itemNumberOfRack.Name = "itemNumberOfRack";
            this.itemNumberOfRack.Size = new System.Drawing.Size(100, 20);
            this.itemNumberOfRack.TabIndex = 16;
            // 
            // NewStorageEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.itemNumberOfRack);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.itemOwner);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.endOfItemStoraging);
            this.Controls.Add(this.itemVolume);
            this.Controls.Add(this.itemWeight);
            this.Controls.Add(this.itemCode);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewStorageEntry";
            this.Text = "NewStorageEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.TextBox itemCode;
        private System.Windows.Forms.TextBox itemWeight;
        private System.Windows.Forms.TextBox itemVolume;
        private System.Windows.Forms.DateTimePicker endOfItemStoraging;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox itemOwner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox itemNumberOfRack;
    }
}