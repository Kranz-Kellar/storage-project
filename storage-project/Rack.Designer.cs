
using System.Windows.Forms;

namespace storage_project
{
    partial class Storage : Form
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
            this.inputEcxel = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.deleteEntity = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 538);
            this.dataGridView1.TabIndex = 0;
            // 
            // inputEcxel
            // 
            this.inputEcxel.Location = new System.Drawing.Point(689, 428);
            this.inputEcxel.Name = "inputEcxel";
            this.inputEcxel.Size = new System.Drawing.Size(92, 58);
            this.inputEcxel.TabIndex = 1;
            this.inputEcxel.Text = "Вывод в EXCEL";
            this.inputEcxel.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(689, 492);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(92, 58);
            this.exit.TabIndex = 2;
            this.exit.Text = "Назад";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // deleteEntity
            // 
            this.deleteEntity.Location = new System.Drawing.Point(689, 364);
            this.deleteEntity.Name = "deleteEntity";
            this.deleteEntity.Size = new System.Drawing.Size(92, 58);
            this.deleteEntity.TabIndex = 3;
            this.deleteEntity.Text = "Удаление выделенной записи";
            this.deleteEntity.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Вывод всего от поставщика";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(689, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteEntity);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.inputEcxel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Storage";
            this.Text = "Storage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button inputEcxel;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button deleteEntity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}