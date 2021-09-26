
namespace АнализГрафиков.Окна.c_ОкноДвойныхБаров
{
    partial class c_ОкноДвойныхБаров
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
            this.ob_ЗаменятьБарамиСдвига = new System.Windows.Forms.Button();
            this.ob_ЗаменитьБарамиСерии = new System.Windows.Forms.Button();
            this.ob_Продолжить = new System.Windows.Forms.Button();
            this.ob_Отмена = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ob_ЗаменятьБарамиСдвига
            // 
            this.ob_ЗаменятьБарамиСдвига.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ob_ЗаменятьБарамиСдвига.Location = new System.Drawing.Point(10, 70);
            this.ob_ЗаменятьБарамиСдвига.Name = "ob_ЗаменятьБарамиСдвига";
            this.ob_ЗаменятьБарамиСдвига.Size = new System.Drawing.Size(109, 39);
            this.ob_ЗаменятьБарамиСдвига.TabIndex = 0;
            this.ob_ЗаменятьБарамиСдвига.Text = "Заменить барами сдвига";
            this.ob_ЗаменятьБарамиСдвига.UseVisualStyleBackColor = true;
            this.ob_ЗаменятьБарамиСдвига.Click += new System.EventHandler(this.ob_ЗаменятьБарамиСдвига_Click);
            // 
            // ob_ЗаменитьБарамиСерии
            // 
            this.ob_ЗаменитьБарамиСерии.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ob_ЗаменитьБарамиСерии.Location = new System.Drawing.Point(125, 70);
            this.ob_ЗаменитьБарамиСерии.Name = "ob_ЗаменитьБарамиСерии";
            this.ob_ЗаменитьБарамиСерии.Size = new System.Drawing.Size(109, 39);
            this.ob_ЗаменитьБарамиСерии.TabIndex = 0;
            this.ob_ЗаменитьБарамиСерии.Text = "Заменить барами серии";
            this.ob_ЗаменитьБарамиСерии.UseVisualStyleBackColor = true;
            this.ob_ЗаменитьБарамиСерии.Click += new System.EventHandler(this.ob_ЗаменитьБарамиСерии_Click);
            // 
            // ob_Продолжить
            // 
            this.ob_Продолжить.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ob_Продолжить.Location = new System.Drawing.Point(241, 70);
            this.ob_Продолжить.Name = "ob_Продолжить";
            this.ob_Продолжить.Size = new System.Drawing.Size(109, 39);
            this.ob_Продолжить.TabIndex = 0;
            this.ob_Продолжить.Text = "Продолжить (не рекомендуется)";
            this.ob_Продолжить.UseVisualStyleBackColor = true;
            this.ob_Продолжить.Click += new System.EventHandler(this.ob_Продолжить_Click);
            // 
            // ob_Отмена
            // 
            this.ob_Отмена.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ob_Отмена.Location = new System.Drawing.Point(356, 70);
            this.ob_Отмена.Name = "ob_Отмена";
            this.ob_Отмена.Size = new System.Drawing.Size(109, 39);
            this.ob_Отмена.TabIndex = 0;
            this.ob_Отмена.Text = "Отмена";
            this.ob_Отмена.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.MaximumSize = new System.Drawing.Size(500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "В главной серии присутсуют двойные бары. Для корректной работы программы нужно из" +
    "бавится от них";
            // 
            // c_ОкноДвойныхБаров
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 121);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ob_Отмена);
            this.Controls.Add(this.ob_Продолжить);
            this.Controls.Add(this.ob_ЗаменитьБарамиСерии);
            this.Controls.Add(this.ob_ЗаменятьБарамиСдвига);
            this.Name = "c_ОкноДвойныхБаров";
            this.Text = "Найдены двойные бары";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ob_ЗаменятьБарамиСдвига;
        private System.Windows.Forms.Button ob_ЗаменитьБарамиСерии;
        private System.Windows.Forms.Button ob_Продолжить;
        private System.Windows.Forms.Button ob_Отмена;
        private System.Windows.Forms.Label label1;
    }
}