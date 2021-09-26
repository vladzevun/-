
namespace АнализГрафиков.Окна.c_ОкноПоискаГепов
{
    partial class c_ОкноПоискаГепов
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
            this.ob_Поиск = new System.Windows.Forms.Button();
            this.ob_Отмена = new System.Windows.Forms.Button();
            this.ob_ПоискГепов_ИгноритьЭталон = new System.Windows.Forms.CheckBox();
            this.ob_ПоискГепов_КритерийСхожестиГеповТекст = new System.Windows.Forms.Label();
            this.ob_ПоискГепов_КритерийСхожестиГепов = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ob_ПоискГепов_МножительСреднего = new System.Windows.Forms.NumericUpDown();
            this.ob_ПоискГепов_ЧислоДелений = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.ob_ПоискГепов_КритерийГепа = new System.Windows.Forms.NumericUpDown();
            this.ob_ВсплывающаяПодсказка = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ob_ПоискГепов_КритерийСхожестиГепов)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_ПоискГепов_МножительСреднего)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_ПоискГепов_ЧислоДелений)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_ПоискГепов_КритерийГепа)).BeginInit();
            this.SuspendLayout();
            // 
            // ob_Поиск
            // 
            this.ob_Поиск.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ob_Поиск.Location = new System.Drawing.Point(259, 147);
            this.ob_Поиск.Name = "ob_Поиск";
            this.ob_Поиск.Size = new System.Drawing.Size(78, 23);
            this.ob_Поиск.TabIndex = 1;
            this.ob_Поиск.Text = "Поиск";
            this.ob_Поиск.UseVisualStyleBackColor = true;
            // 
            // ob_Отмена
            // 
            this.ob_Отмена.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ob_Отмена.Location = new System.Drawing.Point(343, 147);
            this.ob_Отмена.Name = "ob_Отмена";
            this.ob_Отмена.Size = new System.Drawing.Size(78, 23);
            this.ob_Отмена.TabIndex = 2;
            this.ob_Отмена.Text = "Отмена";
            this.ob_Отмена.UseVisualStyleBackColor = true;
            // 
            // ob_ПоискГепов_ИгноритьЭталон
            // 
            this.ob_ПоискГепов_ИгноритьЭталон.AutoSize = true;
            this.ob_ПоискГепов_ИгноритьЭталон.Location = new System.Drawing.Point(343, 101);
            this.ob_ПоискГепов_ИгноритьЭталон.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ob_ПоискГепов_ИгноритьЭталон.Name = "ob_ПоискГепов_ИгноритьЭталон";
            this.ob_ПоискГепов_ИгноритьЭталон.Size = new System.Drawing.Size(15, 14);
            this.ob_ПоискГепов_ИгноритьЭталон.TabIndex = 6;
            this.ob_ПоискГепов_ИгноритьЭталон.UseVisualStyleBackColor = true;
            this.ob_ПоискГепов_ИгноритьЭталон.CheckedChanged += new System.EventHandler(this.e_ПоискГепов_ИгноритьЭталон_CheckedChanged);
            // 
            // ob_ПоискГепов_КритерийСхожестиГеповТекст
            // 
            this.ob_ПоискГепов_КритерийСхожестиГеповТекст.AutoSize = true;
            this.ob_ПоискГепов_КритерийСхожестиГеповТекст.Location = new System.Drawing.Point(7, 125);
            this.ob_ПоискГепов_КритерийСхожестиГеповТекст.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ob_ПоискГепов_КритерийСхожестиГеповТекст.Name = "ob_ПоискГепов_КритерийСхожестиГеповТекст";
            this.ob_ПоискГепов_КритерийСхожестиГеповТекст.Size = new System.Drawing.Size(88, 13);
            this.ob_ПоискГепов_КритерийСхожестиГеповТекст.TabIndex = 97;
            this.ob_ПоискГепов_КритерийСхожестиГеповТекст.Text = "Схожесть гэпов";
            // 
            // ob_ПоискГепов_КритерийСхожестиГепов
            // 
            this.ob_ПоискГепов_КритерийСхожестиГепов.DecimalPlaces = 2;
            this.ob_ПоискГепов_КритерийСхожестиГепов.Location = new System.Drawing.Point(343, 121);
            this.ob_ПоискГепов_КритерийСхожестиГепов.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ob_ПоискГепов_КритерийСхожестиГепов.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ob_ПоискГепов_КритерийСхожестиГепов.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.ob_ПоискГепов_КритерийСхожестиГепов.Name = "ob_ПоискГепов_КритерийСхожестиГепов";
            this.ob_ПоискГепов_КритерийСхожестиГепов.Size = new System.Drawing.Size(78, 20);
            this.ob_ПоискГепов_КритерийСхожестиГепов.TabIndex = 7;
            this.ob_ПоискГепов_КритерийСхожестиГепов.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 79);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(162, 13);
            this.label17.TabIndex = 94;
            this.label17.Text = "Множитель для среднего гепа";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 53);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(293, 13);
            this.label16.TabIndex = 95;
            this.label16.Text = "Дней в промежутке по которому считается средний геп";
            // 
            // ob_ПоискГепов_МножительСреднего
            // 
            this.ob_ПоискГепов_МножительСреднего.DecimalPlaces = 2;
            this.ob_ПоискГепов_МножительСреднего.Location = new System.Drawing.Point(343, 75);
            this.ob_ПоискГепов_МножительСреднего.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ob_ПоискГепов_МножительСреднего.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ob_ПоискГепов_МножительСреднего.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.ob_ПоискГепов_МножительСреднего.Name = "ob_ПоискГепов_МножительСреднего";
            this.ob_ПоискГепов_МножительСреднего.Size = new System.Drawing.Size(78, 20);
            this.ob_ПоискГепов_МножительСреднего.TabIndex = 5;
            this.ob_ПоискГепов_МножительСреднего.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ob_ПоискГепов_ЧислоДелений
            // 
            this.ob_ПоискГепов_ЧислоДелений.Location = new System.Drawing.Point(343, 49);
            this.ob_ПоискГепов_ЧислоДелений.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ob_ПоискГепов_ЧислоДелений.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ob_ПоискГепов_ЧислоДелений.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.ob_ПоискГепов_ЧислоДелений.Name = "ob_ПоискГепов_ЧислоДелений";
            this.ob_ПоискГепов_ЧислоДелений.Size = new System.Drawing.Size(78, 20);
            this.ob_ПоискГепов_ЧислоДелений.TabIndex = 4;
            this.ob_ПоискГепов_ЧислоДелений.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 27);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(296, 13);
            this.label15.TabIndex = 91;
            this.label15.Text = "Критерий, по которому считаеться, что являеться гепом";
            // 
            // ob_ПоискГепов_КритерийГепа
            // 
            this.ob_ПоискГепов_КритерийГепа.DecimalPlaces = 2;
            this.ob_ПоискГепов_КритерийГепа.Location = new System.Drawing.Point(343, 23);
            this.ob_ПоискГепов_КритерийГепа.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ob_ПоискГепов_КритерийГепа.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ob_ПоискГепов_КритерийГепа.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.ob_ПоискГепов_КритерийГепа.Name = "ob_ПоискГепов_КритерийГепа";
            this.ob_ПоискГепов_КритерийГепа.Size = new System.Drawing.Size(78, 20);
            this.ob_ПоискГепов_КритерийГепа.TabIndex = 3;
            this.ob_ПоискГепов_КритерийГепа.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ob_ВсплывающаяПодсказка
            // 
            this.ob_ВсплывающаяПодсказка.AutoPopDelay = 20000;
            this.ob_ВсплывающаяПодсказка.InitialDelay = 500;
            this.ob_ВсплывающаяПодсказка.ReshowDelay = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Игнорить ли эталон";
            // 
            // c_ОкноПоискаГепов
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ob_ПоискГепов_ИгноритьЭталон);
            this.Controls.Add(this.ob_ПоискГепов_КритерийСхожестиГеповТекст);
            this.Controls.Add(this.ob_ПоискГепов_КритерийСхожестиГепов);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ob_ПоискГепов_МножительСреднего);
            this.Controls.Add(this.ob_ПоискГепов_ЧислоДелений);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ob_ПоискГепов_КритерийГепа);
            this.Controls.Add(this.ob_Поиск);
            this.Controls.Add(this.ob_Отмена);
            this.Name = "c_ОкноПоискаГепов";
            this.Text = "Поиск гепов в главной серии";
            ((System.ComponentModel.ISupportInitialize)(this.ob_ПоискГепов_КритерийСхожестиГепов)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_ПоискГепов_МножительСреднего)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_ПоискГепов_ЧислоДелений)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_ПоискГепов_КритерийГепа)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ob_Поиск;
        private System.Windows.Forms.Button ob_Отмена;
        private System.Windows.Forms.CheckBox ob_ПоискГепов_ИгноритьЭталон;
        private System.Windows.Forms.Label ob_ПоискГепов_КритерийСхожестиГеповТекст;
        private System.Windows.Forms.NumericUpDown ob_ПоискГепов_КритерийСхожестиГепов;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown ob_ПоискГепов_МножительСреднего;
        private System.Windows.Forms.NumericUpDown ob_ПоискГепов_ЧислоДелений;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown ob_ПоискГепов_КритерийГепа;
        private System.Windows.Forms.ToolTip ob_ВсплывающаяПодсказка;
        private System.Windows.Forms.Label label1;
    }
}