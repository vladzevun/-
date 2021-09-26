
namespace АнализГрафиков.Окна.c_ОкноВыбораДаты
{
    partial class c_ОкноВыбораДаты
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
            this.ob_Год = new System.Windows.Forms.NumericUpDown();
            this.ob_Месяц = new System.Windows.Forms.NumericUpDown();
            this.ob_День = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ob_Час = new System.Windows.Forms.NumericUpDown();
            this.ob_Минута = new System.Windows.Forms.NumericUpDown();
            this.ob_Секунда = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ob_ПерейтиКДате = new System.Windows.Forms.Button();
            this.ob_Отмена = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ob_Год)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_Месяц)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_День)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_Час)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_Минута)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_Секунда)).BeginInit();
            this.SuspendLayout();
            // 
            // ob_Год
            // 
            this.ob_Год.Location = new System.Drawing.Point(5, 23);
            this.ob_Год.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.ob_Год.Name = "ob_Год";
            this.ob_Год.Size = new System.Drawing.Size(74, 20);
            this.ob_Год.TabIndex = 0;
            // 
            // ob_Месяц
            // 
            this.ob_Месяц.Location = new System.Drawing.Point(85, 23);
            this.ob_Месяц.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.ob_Месяц.Name = "ob_Месяц";
            this.ob_Месяц.Size = new System.Drawing.Size(74, 20);
            this.ob_Месяц.TabIndex = 0;
            // 
            // ob_День
            // 
            this.ob_День.Location = new System.Drawing.Point(165, 23);
            this.ob_День.Maximum = new decimal(new int[] {
            366,
            0,
            0,
            0});
            this.ob_День.Name = "ob_День";
            this.ob_День.Size = new System.Drawing.Size(74, 20);
            this.ob_День.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Год";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Месяц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "День";
            // 
            // ob_Час
            // 
            this.ob_Час.Location = new System.Drawing.Point(5, 65);
            this.ob_Час.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.ob_Час.Name = "ob_Час";
            this.ob_Час.Size = new System.Drawing.Size(74, 20);
            this.ob_Час.TabIndex = 0;
            // 
            // ob_Минута
            // 
            this.ob_Минута.Location = new System.Drawing.Point(85, 65);
            this.ob_Минута.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.ob_Минута.Name = "ob_Минута";
            this.ob_Минута.Size = new System.Drawing.Size(74, 20);
            this.ob_Минута.TabIndex = 0;
            // 
            // ob_Секунда
            // 
            this.ob_Секунда.Location = new System.Drawing.Point(165, 65);
            this.ob_Секунда.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.ob_Секунда.Name = "ob_Секунда";
            this.ob_Секунда.Size = new System.Drawing.Size(74, 20);
            this.ob_Секунда.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Час";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Минута";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Секунда";
            // 
            // ob_ПерейтиКДате
            // 
            this.ob_ПерейтиКДате.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ob_ПерейтиКДате.Location = new System.Drawing.Point(84, 91);
            this.ob_ПерейтиКДате.Name = "ob_ПерейтиКДате";
            this.ob_ПерейтиКДате.Size = new System.Drawing.Size(75, 23);
            this.ob_ПерейтиКДате.TabIndex = 5;
            this.ob_ПерейтиКДате.Text = "Перейти";
            this.ob_ПерейтиКДате.UseVisualStyleBackColor = true;
            // 
            // ob_Отмена
            // 
            this.ob_Отмена.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ob_Отмена.Location = new System.Drawing.Point(165, 91);
            this.ob_Отмена.Name = "ob_Отмена";
            this.ob_Отмена.Size = new System.Drawing.Size(75, 23);
            this.ob_Отмена.TabIndex = 4;
            this.ob_Отмена.Text = "Отмена";
            this.ob_Отмена.UseVisualStyleBackColor = true;
            // 
            // c_ОкноВыбораДаты
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 123);
            this.Controls.Add(this.ob_ПерейтиКДате);
            this.Controls.Add(this.ob_Отмена);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ob_Секунда);
            this.Controls.Add(this.ob_День);
            this.Controls.Add(this.ob_Минута);
            this.Controls.Add(this.ob_Месяц);
            this.Controls.Add(this.ob_Час);
            this.Controls.Add(this.ob_Год);
            this.Name = "c_ОкноВыбораДаты";
            this.Text = "Выберете дату";
            ((System.ComponentModel.ISupportInitialize)(this.ob_Год)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_Месяц)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_День)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_Час)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_Минута)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_Секунда)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ob_Год;
        private System.Windows.Forms.NumericUpDown ob_Месяц;
        private System.Windows.Forms.NumericUpDown ob_День;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ob_Час;
        private System.Windows.Forms.NumericUpDown ob_Минута;
        private System.Windows.Forms.NumericUpDown ob_Секунда;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ob_ПерейтиКДате;
        private System.Windows.Forms.Button ob_Отмена;
    }
}