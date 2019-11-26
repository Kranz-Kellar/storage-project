namespace storage_project
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addNewItem = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addNewItem
            // 
            this.addNewItem.Location = new System.Drawing.Point(13, 322);
            this.addNewItem.Name = "addNewItem";
            this.addNewItem.Size = new System.Drawing.Size(150, 23);
            this.addNewItem.TabIndex = 1;
            this.addNewItem.Text = "Добавить новый товар";
            this.addNewItem.UseVisualStyleBackColor = true;
            this.addNewItem.Click += new System.EventHandler(this.addNewItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(303, 303);
            this.listBox1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addNewItem);
            this.Name = "MainForm";
            this.Text = "Складской учёт";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addNewItem;
        private System.Windows.Forms.ListBox listBox1;
    }
}

