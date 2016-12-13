namespace lab3
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.main = new System.Windows.Forms.TabPage();
            this.buttonEstabilish = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChangeMac = new System.Windows.Forms.Button();
            this.interfaces = new System.Windows.Forms.TabPage();
            this.listViewInterface = new System.Windows.Forms.ListView();
            this.columnNane = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.table = new System.Windows.Forms.TabPage();
            this.DelRotingRecord = new System.Windows.Forms.Button();
            this.buttonAddRoutingRecord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gateway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxGateway = new System.Windows.Forms.TextBox();
            this.textBoxDest = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxMac = new lab3.TextBoxValidating();
            this.tabControl.SuspendLayout();
            this.main.SuspendLayout();
            this.interfaces.SuspendLayout();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.main);
            this.tabControl.Controls.Add(this.interfaces);
            this.tabControl.Controls.Add(this.table);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(452, 276);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // main
            // 
            this.main.Controls.Add(this.buttonReset);
            this.main.Controls.Add(this.textBoxMac);
            this.main.Controls.Add(this.buttonEstabilish);
            this.main.Controls.Add(this.buttonSave);
            this.main.Controls.Add(this.label1);
            this.main.Controls.Add(this.buttonChangeMac);
            this.main.Location = new System.Drawing.Point(4, 25);
            this.main.Name = "main";
            this.main.Padding = new System.Windows.Forms.Padding(3);
            this.main.Size = new System.Drawing.Size(444, 247);
            this.main.TabIndex = 0;
            this.main.Text = "Основная";
            this.main.UseVisualStyleBackColor = true;
            // 
            // buttonEstabilish
            // 
            this.buttonEstabilish.Location = new System.Drawing.Point(12, 131);
            this.buttonEstabilish.Name = "buttonEstabilish";
            this.buttonEstabilish.Size = new System.Drawing.Size(303, 41);
            this.buttonEstabilish.TabIndex = 4;
            this.buttonEstabilish.Text = "Востановить конфигурацию из файла";
            this.buttonEstabilish.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 74);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(303, 38);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить конфигурацию в файл";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "MAC адрес";
            // 
            // buttonChangeMac
            // 
            this.buttonChangeMac.Location = new System.Drawing.Point(267, 22);
            this.buttonChangeMac.Name = "buttonChangeMac";
            this.buttonChangeMac.Size = new System.Drawing.Size(120, 23);
            this.buttonChangeMac.TabIndex = 0;
            this.buttonChangeMac.Text = "Изменить";
            this.buttonChangeMac.UseVisualStyleBackColor = true;
            this.buttonChangeMac.Click += new System.EventHandler(this.buttonChangeMac_Click);
            // 
            // interfaces
            // 
            this.interfaces.Controls.Add(this.listViewInterface);
            this.interfaces.Location = new System.Drawing.Point(4, 25);
            this.interfaces.Name = "interfaces";
            this.interfaces.Padding = new System.Windows.Forms.Padding(3);
            this.interfaces.Size = new System.Drawing.Size(444, 247);
            this.interfaces.TabIndex = 1;
            this.interfaces.Text = "Интерфейсы";
            this.interfaces.UseVisualStyleBackColor = true;
            // 
            // listViewInterface
            // 
            this.listViewInterface.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNane,
            this.columnIP});
            this.listViewInterface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewInterface.Location = new System.Drawing.Point(3, 3);
            this.listViewInterface.MultiSelect = false;
            this.listViewInterface.Name = "listViewInterface";
            this.listViewInterface.Size = new System.Drawing.Size(438, 241);
            this.listViewInterface.TabIndex = 0;
            this.listViewInterface.UseCompatibleStateImageBehavior = false;
            this.listViewInterface.View = System.Windows.Forms.View.Details;
            this.listViewInterface.DoubleClick += new System.EventHandler(this.listViewInterface_DoubleClick);
            // 
            // columnNane
            // 
            this.columnNane.Text = "Название интерфейса";
            this.columnNane.Width = 170;
            // 
            // columnIP
            // 
            this.columnIP.Text = "IP адрес";
            this.columnIP.Width = 237;
            // 
            // table
            // 
            this.table.Controls.Add(this.DelRotingRecord);
            this.table.Controls.Add(this.buttonAddRoutingRecord);
            this.table.Controls.Add(this.label3);
            this.table.Controls.Add(this.label2);
            this.table.Controls.Add(this.dataGridView1);
            this.table.Controls.Add(this.textBoxGateway);
            this.table.Controls.Add(this.textBoxDest);
            this.table.Location = new System.Drawing.Point(4, 25);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(444, 247);
            this.table.TabIndex = 2;
            this.table.Text = "Таблица маршрутизации";
            this.table.UseVisualStyleBackColor = true;
            // 
            // DelRotingRecord
            // 
            this.DelRotingRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DelRotingRecord.Location = new System.Drawing.Point(242, 210);
            this.DelRotingRecord.Name = "DelRotingRecord";
            this.DelRotingRecord.Size = new System.Drawing.Size(178, 34);
            this.DelRotingRecord.TabIndex = 6;
            this.DelRotingRecord.Text = "Удалить строку";
            this.DelRotingRecord.UseVisualStyleBackColor = true;
            this.DelRotingRecord.Click += new System.EventHandler(this.DelRotingRecord_Click);
            // 
            // buttonAddRoutingRecord
            // 
            this.buttonAddRoutingRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddRoutingRecord.Location = new System.Drawing.Point(25, 211);
            this.buttonAddRoutingRecord.Name = "buttonAddRoutingRecord";
            this.buttonAddRoutingRecord.Size = new System.Drawing.Size(170, 33);
            this.buttonAddRoutingRecord.TabIndex = 5;
            this.buttonAddRoutingRecord.Text = "Добавить строку";
            this.buttonAddRoutingRecord.UseVisualStyleBackColor = true;
            this.buttonAddRoutingRecord.Click += new System.EventHandler(this.buttonAddRoutingRecord_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Шлюз";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Адрес назначения";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dest,
            this.mask,
            this.gateway,
            this.metric});
            this.dataGridView1.Location = new System.Drawing.Point(0, 59);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(444, 140);
            this.dataGridView1.TabIndex = 2;
            // 
            // dest
            // 
            this.dest.HeaderText = "Адрес назначения";
            this.dest.Name = "dest";
            this.dest.ReadOnly = true;
            // 
            // mask
            // 
            this.mask.HeaderText = "Маска";
            this.mask.Name = "mask";
            this.mask.ReadOnly = true;
            // 
            // gateway
            // 
            this.gateway.HeaderText = "Шлюз";
            this.gateway.Name = "gateway";
            this.gateway.ReadOnly = true;
            // 
            // metric
            // 
            this.metric.HeaderText = "Метрика";
            this.metric.Name = "metric";
            this.metric.ReadOnly = true;
            // 
            // textBoxGateway
            // 
            this.textBoxGateway.Location = new System.Drawing.Point(159, 34);
            this.textBoxGateway.Name = "textBoxGateway";
            this.textBoxGateway.Size = new System.Drawing.Size(100, 22);
            this.textBoxGateway.TabIndex = 1;
            this.textBoxGateway.TextChanged += new System.EventHandler(this.textBoxGateway_TextChanged);
            // 
            // textBoxDest
            // 
            this.textBoxDest.Location = new System.Drawing.Point(159, 6);
            this.textBoxDest.Name = "textBoxDest";
            this.textBoxDest.Size = new System.Drawing.Size(100, 22);
            this.textBoxDest.TabIndex = 0;
            this.textBoxDest.TextChanged += new System.EventHandler(this.textBoxDest_TextChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(12, 190);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(303, 37);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Сбросить к заводским настройкам";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxMac
            // 
            this.textBoxMac.Location = new System.Drawing.Point(95, 26);
            this.textBoxMac.Name = "textBoxMac";
            this.textBoxMac.Size = new System.Drawing.Size(151, 22);
            this.textBoxMac.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 276);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Система администрирования роутера";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.form_Load);
            this.tabControl.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.interfaces.ResumeLayout(false);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage main;
        private System.Windows.Forms.TabPage interfaces;
        private System.Windows.Forms.TabPage table;
        private System.Windows.Forms.Button buttonEstabilish;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChangeMac;
        private System.Windows.Forms.ListView listViewInterface;
        private System.Windows.Forms.ColumnHeader columnNane;
        private System.Windows.Forms.ColumnHeader columnIP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxGateway;
        private System.Windows.Forms.TextBox textBoxDest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dest;
        private System.Windows.Forms.DataGridViewTextBoxColumn mask;
        private System.Windows.Forms.DataGridViewTextBoxColumn gateway;
        private System.Windows.Forms.DataGridViewTextBoxColumn metric;
        private TextBoxValidating textBoxMac;
        private System.Windows.Forms.Button DelRotingRecord;
        private System.Windows.Forms.Button buttonAddRoutingRecord;
        private System.Windows.Forms.Button buttonReset;
    }
}

