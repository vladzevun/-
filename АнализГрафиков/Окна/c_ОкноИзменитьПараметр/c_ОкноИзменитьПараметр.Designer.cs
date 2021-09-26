
namespace АнализГрафиков.Окна.c_ОкноИзменитьПараметр
{
    partial class c_ОкноИзменитьПараметр
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
            this.ob_Описание = new System.Windows.Forms.Label();
            this.ob_Параметр = new System.Windows.Forms.NumericUpDown();
            this.ob_Отмена = new System.Windows.Forms.Button();
            this.ob_Ок = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ob_Параметр)).BeginInit();
            this.SuspendLayout();
            // 
            // ob_Описание
            // 
            this.ob_Описание.AutoSize = true;
            this.ob_Описание.Location = new System.Drawing.Point(12, 14);
            this.ob_Описание.MaximumSize = new System.Drawing.Size(220, 0);
            this.ob_Описание.Name = "ob_Описание";
            this.ob_Описание.Size = new System.Drawing.Size(43, 13);
            this.ob_Описание.TabIndex = 0;
            this.ob_Описание.Text = "(Пусто)";
            // 
            // ob_Параметр
            // 
            this.ob_Параметр.Location = new System.Drawing.Point(296, 11);
            this.ob_Параметр.Name = "ob_Параметр";
            this.ob_Параметр.Size = new System.Drawing.Size(120, 20);
            this.ob_Параметр.TabIndex = 3;
            // 
            // ob_Отмена
            // 
            this.ob_Отмена.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ob_Отмена.Location = new System.Drawing.Point(341, 66);
            this.ob_Отмена.Name = "ob_Отмена";
            this.ob_Отмена.Size = new System.Drawing.Size(75, 23);
            this.ob_Отмена.TabIndex = 2;
            this.ob_Отмена.Text = "Отмена";
            this.ob_Отмена.UseVisualStyleBackColor = true;
            // 
            // ob_Ок
            // 
            this.ob_Ок.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ob_Ок.Location = new System.Drawing.Point(260, 66);
            this.ob_Ок.Name = "ob_Ок";
            this.ob_Ок.Size = new System.Drawing.Size(75, 23);
            this.ob_Ок.TabIndex = 1;
            this.ob_Ок.Text = "Ок";
            this.ob_Ок.UseVisualStyleBackColor = true;
            // 
            // c_ОкноИзменитьПараметр
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 97);
            this.Controls.Add(this.ob_Ок);
            this.Controls.Add(this.ob_Отмена);
            this.Controls.Add(this.ob_Параметр);
            this.Controls.Add(this.ob_Описание);
            this.Name = "c_ОкноИзменитьПараметр";
            this.Text = "Изменить параметр";
            ((System.ComponentModel.ISupportInitialize)(this.ob_Параметр)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ob_Описание;
        private System.Windows.Forms.NumericUpDown ob_Параметр;
        private System.Windows.Forms.Button ob_Отмена;
        private System.Windows.Forms.Button ob_Ок;
    }
}