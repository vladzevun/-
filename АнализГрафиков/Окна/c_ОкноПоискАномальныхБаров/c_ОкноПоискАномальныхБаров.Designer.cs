
namespace АнализГрафиков.Окна.c_ОкноПоискАномальныхБаров
{
    partial class c_ОкноПоискАномальныхБаров
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
            this.ob_ВсплывающаяПодсказка = new System.Windows.Forms.ToolTip(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.ob_АномальныеБары_КритерийРасхождения = new System.Windows.Forms.NumericUpDown();
            this.ob_Поиск = new System.Windows.Forms.Button();
            this.ob_Отмена = new System.Windows.Forms.Button();
            this.ob_АномальныеБары_ИгнорироватьНулевыеБары = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ob_АномальныеБары_КритерийНулевогоБараТекст = new System.Windows.Forms.Label();
            this.ob_АномальныеБары_КритерийНулевогоБара = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ob_АномальныеБары_КритерийРасхождения)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_АномальныеБары_КритерийНулевогоБара)).BeginInit();
            this.SuspendLayout();
            // 
            // ob_ВсплывающаяПодсказка
            // 
            this.ob_ВсплывающаяПодсказка.AutoPopDelay = 20000;
            this.ob_ВсплывающаяПодсказка.InitialDelay = 500;
            this.ob_ВсплывающаяПодсказка.ReshowDelay = 100;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 18);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(196, 13);
            this.label14.TabIndex = 62;
            this.label14.Text = "Критерий расхожение между барами";
            // 
            // ob_АномальныеБары_КритерийРасхождения
            // 
            this.ob_АномальныеБары_КритерийРасхождения.DecimalPlaces = 2;
            this.ob_АномальныеБары_КритерийРасхождения.Location = new System.Drawing.Point(339, 14);
            this.ob_АномальныеБары_КритерийРасхождения.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ob_АномальныеБары_КритерийРасхождения.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ob_АномальныеБары_КритерийРасхождения.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.ob_АномальныеБары_КритерийРасхождения.Name = "ob_АномальныеБары_КритерийРасхождения";
            this.ob_АномальныеБары_КритерийРасхождения.Size = new System.Drawing.Size(78, 20);
            this.ob_АномальныеБары_КритерийРасхождения.TabIndex = 3;
            this.ob_АномальныеБары_КритерийРасхождения.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ob_Поиск
            // 
            this.ob_Поиск.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ob_Поиск.Location = new System.Drawing.Point(255, 90);
            this.ob_Поиск.Name = "ob_Поиск";
            this.ob_Поиск.Size = new System.Drawing.Size(78, 23);
            this.ob_Поиск.TabIndex = 1;
            this.ob_Поиск.Text = "Поиск";
            this.ob_Поиск.UseVisualStyleBackColor = true;
            // 
            // ob_Отмена
            // 
            this.ob_Отмена.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ob_Отмена.Location = new System.Drawing.Point(339, 90);
            this.ob_Отмена.Name = "ob_Отмена";
            this.ob_Отмена.Size = new System.Drawing.Size(78, 23);
            this.ob_Отмена.TabIndex = 2;
            this.ob_Отмена.Text = "Отмена";
            this.ob_Отмена.UseVisualStyleBackColor = true;
            // 
            // ob_АномальныеБары_ИгнорироватьНулевыеБары
            // 
            this.ob_АномальныеБары_ИгнорироватьНулевыеБары.AutoSize = true;
            this.ob_АномальныеБары_ИгнорироватьНулевыеБары.Location = new System.Drawing.Point(339, 42);
            this.ob_АномальныеБары_ИгнорироватьНулевыеБары.Name = "ob_АномальныеБары_ИгнорироватьНулевыеБары";
            this.ob_АномальныеБары_ИгнорироватьНулевыеБары.Size = new System.Drawing.Size(15, 14);
            this.ob_АномальныеБары_ИгнорироватьНулевыеБары.TabIndex = 4;
            this.ob_АномальныеБары_ИгнорироватьНулевыеБары.UseVisualStyleBackColor = true;
            this.ob_АномальныеБары_ИгнорироватьНулевыеБары.CheckedChanged += new System.EventHandler(this.e_АномальныеБары_ИгнорироватьНулевыеБары_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Игнорировать нулевые бары";
            // 
            // ob_АномальныеБары_КритерийНулевогоБараТекст
            // 
            this.ob_АномальныеБары_КритерийНулевогоБараТекст.AutoSize = true;
            this.ob_АномальныеБары_КритерийНулевогоБараТекст.Location = new System.Drawing.Point(15, 68);
            this.ob_АномальныеБары_КритерийНулевогоБараТекст.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ob_АномальныеБары_КритерийНулевогоБараТекст.Name = "ob_АномальныеБары_КритерийНулевогоБараТекст";
            this.ob_АномальныеБары_КритерийНулевогоБараТекст.Size = new System.Drawing.Size(131, 13);
            this.ob_АномальныеБары_КритерийНулевогоБараТекст.TabIndex = 68;
            this.ob_АномальныеБары_КритерийНулевогоБараТекст.Text = "Критерий нулевого бара";
            // 
            // ob_АномальныеБары_КритерийНулевогоБара
            // 
            this.ob_АномальныеБары_КритерийНулевогоБара.DecimalPlaces = 2;
            this.ob_АномальныеБары_КритерийНулевогоБара.Location = new System.Drawing.Point(339, 64);
            this.ob_АномальныеБары_КритерийНулевогоБара.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ob_АномальныеБары_КритерийНулевогоБара.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ob_АномальныеБары_КритерийНулевогоБара.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.ob_АномальныеБары_КритерийНулевогоБара.Name = "ob_АномальныеБары_КритерийНулевогоБара";
            this.ob_АномальныеБары_КритерийНулевогоБара.Size = new System.Drawing.Size(78, 20);
            this.ob_АномальныеБары_КритерийНулевогоБара.TabIndex = 5;
            this.ob_АномальныеБары_КритерийНулевогоБара.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // c_ОкноПоискАномальныхБаров
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 118);
            this.Controls.Add(this.ob_АномальныеБары_КритерийНулевогоБараТекст);
            this.Controls.Add(this.ob_АномальныеБары_КритерийНулевогоБара);
            this.Controls.Add(this.ob_АномальныеБары_ИгнорироватьНулевыеБары);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ob_Поиск);
            this.Controls.Add(this.ob_Отмена);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ob_АномальныеБары_КритерийРасхождения);
            this.Name = "c_ОкноПоискАномальныхБаров";
            this.Text = "Поиск аномальных баров в главной серии";
            ((System.ComponentModel.ISupportInitialize)(this.ob_АномальныеБары_КритерийРасхождения)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ob_АномальныеБары_КритерийНулевогоБара)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ob_ВсплывающаяПодсказка;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown ob_АномальныеБары_КритерийРасхождения;
        private System.Windows.Forms.Button ob_Поиск;
        private System.Windows.Forms.Button ob_Отмена;
        private System.Windows.Forms.CheckBox ob_АномальныеБары_ИгнорироватьНулевыеБары;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ob_АномальныеБары_КритерийНулевогоБараТекст;
        private System.Windows.Forms.NumericUpDown ob_АномальныеБары_КритерийНулевогоБара;
    }
}