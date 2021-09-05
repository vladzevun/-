
namespace АнализГрафиков
{
    partial class c_ГлавнаяФорма
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
            this.c_ИсследовательГрафиков1 = new АнализГрафиков.c_ИсследовательГрафиков.c_ИсследовательГрафиков();
            this.SuspendLayout();
            // 
            // c_ИсследовательГрафиков1
            // 
            this.c_ИсследовательГрафиков1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_ИсследовательГрафиков1.AutoSize = true;
            this.c_ИсследовательГрафиков1.Location = new System.Drawing.Point(11, 10);
            this.c_ИсследовательГрафиков1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.c_ИсследовательГрафиков1.MinimumSize = new System.Drawing.Size(1081, 588);
            this.c_ИсследовательГрафиков1.Name = "c_ИсследовательГрафиков1";
            this.c_ИсследовательГрафиков1.Size = new System.Drawing.Size(1081, 588);
            this.c_ИсследовательГрафиков1.TabIndex = 0;
            // 
            // c_ГлавнаяФорма
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 604);
            this.Controls.Add(this.c_ИсследовательГрафиков1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(859, 535);
            this.Name = "c_ГлавнаяФорма";
            this.Text = "Анализ Графиков";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private c_ИсследовательГрафиков.c_ИсследовательГрафиков c_ИсследовательГрафиков1;
    }
}

