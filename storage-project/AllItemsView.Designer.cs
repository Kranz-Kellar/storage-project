namespace storage_project
{
    partial class AllItemsView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.itemCode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.itemEndDateStoraging = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemNumberOfRack = new System.Windows.Forms.TextBox();
            this.itemStartDateStoraging = new System.Windows.Forms.TextBox();
            this.itemSupplier = new System.Windows.Forms.TextBox();
            this.itemVolume = new System.Windows.Forms.TextBox();
            this.itemWeight = new System.Windows.Forms.TextBox();
            this.itemName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 326);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(953, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemCode
            // 
            this.itemCode.Location = new System.Drawing.Point(20, 36);
            this.itemCode.Name = "itemCode";
            this.itemCode.Size = new System.Drawing.Size(269, 20);
            this.itemCode.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.itemEndDateStoraging);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.itemNumberOfRack);
            this.groupBox1.Controls.Add(this.itemStartDateStoraging);
            this.groupBox1.Controls.Add(this.itemSupplier);
            this.groupBox1.Controls.Add(this.itemVolume);
            this.groupBox1.Controls.Add(this.itemWeight);
            this.groupBox1.Controls.Add(this.itemName);
            this.groupBox1.Controls.Add(this.itemCode);
            this.groupBox1.Location = new System.Drawing.Point(542, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 326);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Описание товара";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(308, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 130);
            this.button3.TabIndex = 19;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 132);
            this.button2.TabIndex = 18;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // itemEndDateStoraging
            // 
            this.itemEndDateStoraging.Location = new System.Drawing.Point(162, 284);
            this.itemEndDateStoraging.Name = "itemEndDateStoraging";
            this.itemEndDateStoraging.Size = new System.Drawing.Size(127, 20);
            this.itemEndDateStoraging.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Дата окончания хранения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата начала хранения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Номер стеллажа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Поставщик";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Объём товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Вес товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Наименование товара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Код товара";
            // 
            // itemNumberOfRack
            // 
            this.itemNumberOfRack.Location = new System.Drawing.Point(20, 243);
            this.itemNumberOfRack.Name = "itemNumberOfRack";
            this.itemNumberOfRack.Size = new System.Drawing.Size(269, 20);
            this.itemNumberOfRack.TabIndex = 8;
            // 
            // itemStartDateStoraging
            // 
            this.itemStartDateStoraging.Location = new System.Drawing.Point(20, 284);
            this.itemStartDateStoraging.Name = "itemStartDateStoraging";
            this.itemStartDateStoraging.Size = new System.Drawing.Size(136, 20);
            this.itemStartDateStoraging.TabIndex = 7;
            // 
            // itemSupplier
            // 
            this.itemSupplier.Location = new System.Drawing.Point(20, 200);
            this.itemSupplier.Name = "itemSupplier";
            this.itemSupplier.Size = new System.Drawing.Size(269, 20);
            this.itemSupplier.TabIndex = 6;
            // 
            // itemVolume
            // 
            this.itemVolume.Location = new System.Drawing.Point(20, 157);
            this.itemVolume.Name = "itemVolume";
            this.itemVolume.Size = new System.Drawing.Size(269, 20);
            this.itemVolume.TabIndex = 5;
            // 
            // itemWeight
            // 
            this.itemWeight.Location = new System.Drawing.Point(20, 114);
            this.itemWeight.Name = "itemWeight";
            this.itemWeight.Size = new System.Drawing.Size(269, 20);
            this.itemWeight.TabIndex = 4;
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(20, 75);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(269, 20);
            this.itemName.TabIndex = 3;
            // 
            // AllItemsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AllItemsView";
            this.Text = "AllItemsView";
            this.Load += new System.EventHandler(this.AllItemsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox itemCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox itemEndDateStoraging;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemNumberOfRack;
        private System.Windows.Forms.TextBox itemStartDateStoraging;
        private System.Windows.Forms.TextBox itemSupplier;
        private System.Windows.Forms.TextBox itemVolume;
        private System.Windows.Forms.TextBox itemWeight;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.Button button3;
    }
}