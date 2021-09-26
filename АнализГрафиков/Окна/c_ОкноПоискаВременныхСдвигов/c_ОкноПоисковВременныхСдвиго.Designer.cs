
namespace АнализГрафиков.Окна.c_ОкноПоискаВременныхСдвигов
{
    partial class c_ОкноПоисковВременныхСдвигов
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
            this.components = new System.ComponentModel.Container();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.ob_ЧислоБаров = new System.Windows.Forms.NumericUpDown();
            this.ob_МножительСреднегоДляВысоты = new System.Windows.Forms.NumericUpDown();
            this.ob_Поиск = new System.Windows.Forms.Button();
            this.ob_Отмена = new System.Windows.Forms.Button();
            this.ob_ВсплывающаяПодсказка = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ob_ЧислоБаров)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_МножительСреднегоДляВысоты)).BeginInit();
            this.SuspendLayout();
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(11, 39);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(179, 13);
            this.label22.TabIndex = 86;
            this.label22.Text = "Множитель средней высоты бара";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 13);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(159, 13);
            this.label21.TabIndex = 85;
            this.label21.Text = "Число баров на один сегмент";
            // 
            // ob_ЧислоБаров
            // 
            this.ob_ЧислоБаров.Location = new System.Drawing.Point(338, 9);
            this.ob_ЧислоБаров.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ob_ЧислоБаров.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ob_ЧислоБаров.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.ob_ЧислоБаров.Name = "ob_ЧислоБаров";
            this.ob_ЧислоБаров.Size = new System.Drawing.Size(78, 20);
            this.ob_ЧислоБаров.TabIndex = 3;
            this.ob_ЧислоБаров.Value = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            // 
            // ob_МножительСреднегоДляВысоты
            // 
            this.ob_МножительСреднегоДляВысоты.DecimalPlaces = 2;
            this.ob_МножительСреднегоДляВысоты.Location = new System.Drawing.Point(338, 35);
            this.ob_МножительСреднегоДляВысоты.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ob_МножительСреднегоДляВысоты.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ob_МножительСреднегоДляВысоты.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.ob_МножительСреднегоДляВысоты.Name = "ob_МножительСреднегоДляВысоты";
            this.ob_МножительСреднегоДляВысоты.Size = new System.Drawing.Size(78, 20);
            this.ob_МножительСреднегоДляВысоты.TabIndex = 4;
            this.ob_МножительСреднегоДляВысоты.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ob_Поиск
            // 
            this.ob_Поиск.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ob_Поиск.Location = new System.Drawing.Point(254, 61);
            this.ob_Поиск.Name = "ob_Поиск";
            this.ob_Поиск.Size = new System.Drawing.Size(78, 23);
            this.ob_Поиск.TabIndex = 1;
            this.ob_Поиск.Text = "Поиск";
            this.ob_Поиск.UseVisualStyleBackColor = true;
            // 
            // ob_Отмена
            // 
            this.ob_Отмена.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ob_Отмена.Location = new System.Drawing.Point(338, 61);
            this.ob_Отмена.Name = "ob_Отмена";
            this.ob_Отмена.Size = new System.Drawing.Size(78, 23);
            this.ob_Отмена.TabIndex = 2;
            this.ob_Отмена.Text = "Отмена";
            this.ob_Отмена.UseVisualStyleBackColor = true;
            // 
            // ob_ВсплывающаяПодсказка
            // 
            this.ob_ВсплывающаяПодсказка.AutoPopDelay = 20000;
            this.ob_ВсплывающаяПодсказка.InitialDelay = 500;
            this.ob_ВсплывающаяПодсказка.ReshowDelay = 100;
            // 
            // c_ОкноПоисковВременныхСдвигов
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 90);
            this.Controls.Add(this.ob_Поиск);
            this.Controls.Add(this.ob_Отмена);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.ob_ЧислоБаров);
            this.Controls.Add(this.ob_МножительСреднегоДляВысоты);
            this.Name = "c_ОкноПоисковВременныхСдвигов";
            this.Text = "Поиск временных сдвигов в главной серии";
            ((System.ComponentModel.ISupportInitialize)(this.ob_ЧислоБаров)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_МножительСреднегоДляВысоты)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown ob_ЧислоБаров;
        private System.Windows.Forms.NumericUpDown ob_МножительСреднегоДляВысоты;
        private System.Windows.Forms.Button ob_Поиск;
        private System.Windows.Forms.Button ob_Отмена;
        private System.Windows.Forms.ToolTip ob_ВсплывающаяПодсказка;
    }
}