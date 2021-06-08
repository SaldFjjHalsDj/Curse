namespace CurseWork_SAD
{
    partial class ClientForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияПоЗаполнениюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОКлиентеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаявкуНаПеревозкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.накладныеНаЗаказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.неоплаченныеЗаказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Place_start = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Place_finish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Details = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Volume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияПоЗаполнениюToolStripMenuItem,
            this.информацияОКлиентеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.помощьToolStripMenuItem.Text = "Инструменты";
            // 
            // информацияПоЗаполнениюToolStripMenuItem
            // 
            this.информацияПоЗаполнениюToolStripMenuItem.Name = "информацияПоЗаполнениюToolStripMenuItem";
            this.информацияПоЗаполнениюToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.информацияПоЗаполнениюToolStripMenuItem.Text = "Информация";
            this.информацияПоЗаполнениюToolStripMenuItem.Click += new System.EventHandler(this.информацияПоЗаполнениюToolStripMenuItem_Click);
            // 
            // информацияОКлиентеToolStripMenuItem
            // 
            this.информацияОКлиентеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаявкуНаПеревозкуToolStripMenuItem,
            this.накладныеНаЗаказыToolStripMenuItem,
            this.неоплаченныеЗаказыToolStripMenuItem});
            this.информацияОКлиентеToolStripMenuItem.Name = "информацияОКлиентеToolStripMenuItem";
            this.информацияОКлиентеToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.информацияОКлиентеToolStripMenuItem.Text = "Информация о клиенте";
            // 
            // добавитьЗаявкуНаПеревозкуToolStripMenuItem
            // 
            this.добавитьЗаявкуНаПеревозкуToolStripMenuItem.Name = "добавитьЗаявкуНаПеревозкуToolStripMenuItem";
            this.добавитьЗаявкуНаПеревозкуToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.добавитьЗаявкуНаПеревозкуToolStripMenuItem.Text = "Создать заявку на перевозку";
            this.добавитьЗаявкуНаПеревозкуToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаявкуНаПеревозкуToolStripMenuItem_Click);
            // 
            // накладныеНаЗаказыToolStripMenuItem
            // 
            this.накладныеНаЗаказыToolStripMenuItem.Name = "накладныеНаЗаказыToolStripMenuItem";
            this.накладныеНаЗаказыToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.накладныеНаЗаказыToolStripMenuItem.Text = "Показать накладные";
            this.накладныеНаЗаказыToolStripMenuItem.Click += new System.EventHandler(this.накладныеНаЗаказыToolStripMenuItem_Click);
            // 
            // неоплаченныеЗаказыToolStripMenuItem
            // 
            this.неоплаченныеЗаказыToolStripMenuItem.Name = "неоплаченныеЗаказыToolStripMenuItem";
            this.неоплаченныеЗаказыToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.неоплаченныеЗаказыToolStripMenuItem.Text = "Показать неоплаченные заказы";
            this.неоплаченныеЗаказыToolStripMenuItem.Click += new System.EventHandler(this.неоплаченныеЗаказыToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(690, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(690, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Date,
            this.Place_start,
            this.Place_finish,
            this.Details,
            this.Weight,
            this.Volume,
            this.Amount});
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewOrders.Location = new System.Drawing.Point(12, 27);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(778, 411);
            this.listViewOrders.TabIndex = 4;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "Заказ";
            // 
            // Date
            // 
            this.Date.Text = "Дата отправки";
            // 
            // Place_start
            // 
            this.Place_start.Text = "Место отправления";
            // 
            // Place_finish
            // 
            this.Place_finish.Text = "Место прибытия";
            // 
            // Details
            // 
            this.Details.Text = "Описание";
            // 
            // Weight
            // 
            this.Weight.Text = "Вес";
            // 
            // Volume
            // 
            this.Volume.Text = "Объем";
            // 
            // Amount
            // 
            this.Amount.Text = "Количество";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияПоЗаполнениюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОКлиентеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem накладныеНаЗаказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem неоплаченныеЗаказыToolStripMenuItem;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Place_start;
        private System.Windows.Forms.ColumnHeader Place_finish;
        private System.Windows.Forms.ColumnHeader Details;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.ColumnHeader Volume;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаявкуНаПеревозкуToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader ID;
    }
}