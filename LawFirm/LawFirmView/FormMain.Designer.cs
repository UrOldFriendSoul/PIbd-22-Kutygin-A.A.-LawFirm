
namespace LawFirmView
{
    partial class FormMain
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonTakeOrderInWork = new System.Windows.Forms.Button();
            this.buttonOrderReady = new System.Windows.Forms.Button();
            this.buttonIssuedOrder = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemComponents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWarehouses = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFillWarehouses = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemReports = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDocumentList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDocumentsComponents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOrderList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWarehouseReports = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWarehouseList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWarehouseComponents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOrdersGroupedByDate = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 29);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(770, 408);
            this.dataGridView.TabIndex = 1;
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(818, 54);
            this.buttonCreateOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(206, 35);
            this.buttonCreateOrder.TabIndex = 2;
            this.buttonCreateOrder.Text = "Создать заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // buttonTakeOrderInWork
            // 
            this.buttonTakeOrderInWork.Location = new System.Drawing.Point(818, 136);
            this.buttonTakeOrderInWork.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTakeOrderInWork.Name = "buttonTakeOrderInWork";
            this.buttonTakeOrderInWork.Size = new System.Drawing.Size(206, 35);
            this.buttonTakeOrderInWork.TabIndex = 3;
            this.buttonTakeOrderInWork.Text = "Отдать на выполнение";
            this.buttonTakeOrderInWork.UseVisualStyleBackColor = true;
            this.buttonTakeOrderInWork.Click += new System.EventHandler(this.buttonTakeOrderInWork_Click);
            // 
            // buttonOrderReady
            // 
            this.buttonOrderReady.Location = new System.Drawing.Point(818, 222);
            this.buttonOrderReady.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOrderReady.Name = "buttonOrderReady";
            this.buttonOrderReady.Size = new System.Drawing.Size(206, 35);
            this.buttonOrderReady.TabIndex = 4;
            this.buttonOrderReady.Text = "Заказ готов";
            this.buttonOrderReady.UseVisualStyleBackColor = true;
            this.buttonOrderReady.Click += new System.EventHandler(this.buttonOrderReady_Click);
            // 
            // buttonIssuedOrder
            // 
            this.buttonIssuedOrder.Location = new System.Drawing.Point(818, 305);
            this.buttonIssuedOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIssuedOrder.Name = "buttonIssuedOrder";
            this.buttonIssuedOrder.Size = new System.Drawing.Size(206, 35);
            this.buttonIssuedOrder.TabIndex = 5;
            this.buttonIssuedOrder.Text = "Заказ выдан";
            this.buttonIssuedOrder.UseVisualStyleBackColor = true;
            this.buttonIssuedOrder.Click += new System.EventHandler(this.buttonIssuedOrder_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(818, 388);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(206, 35);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Обновить список";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHelp,
            this.toolStripMenuItemFillWarehouses,
            this.toolStripMenuItemReports,
            this.toolStripMenuItemWarehouseReports});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1059, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemComponents,
            this.toolStripMenuItemDocument,
            this.toolStripMenuItemWarehouses});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(117, 24);
            this.toolStripMenuItemHelp.Text = "Справочники";
            // 
            // toolStripMenuItemComponents
            // 
            this.toolStripMenuItemComponents.Name = "toolStripMenuItemComponents";
            this.toolStripMenuItemComponents.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemComponents.Text = "Компоненты";
            this.toolStripMenuItemComponents.Click += new System.EventHandler(this.toolStripMenuItemComponents_Click);
            // 
            // toolStripMenuItemDocument
            // 
            this.toolStripMenuItemDocument.Name = "toolStripMenuItemDocument";
            this.toolStripMenuItemDocument.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemDocument.Text = "Документы";
            this.toolStripMenuItemDocument.Click += new System.EventHandler(this.toolStripMenuItemDocument_Click);
            // 
            // toolStripMenuItemWarehouses
            // 
            this.toolStripMenuItemWarehouses.Name = "toolStripMenuItemWarehouses";
            this.toolStripMenuItemWarehouses.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemWarehouses.Text = "Склады";
            this.toolStripMenuItemWarehouses.Click += new System.EventHandler(this.toolStripMenuItemWarehouses_Click);
            // 
            // toolStripMenuItemFillWarehouses
            // 
            this.toolStripMenuItemFillWarehouses.Name = "toolStripMenuItemFillWarehouses";
            this.toolStripMenuItemFillWarehouses.Size = new System.Drawing.Size(154, 24);
            this.toolStripMenuItemFillWarehouses.Text = "Пополнить склады";
            this.toolStripMenuItemFillWarehouses.Click += new System.EventHandler(this.toolStripMenuItemFillWarehouses_Click);
            // 
            // toolStripMenuItemReports
            // 
            this.toolStripMenuItemReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDocumentList,
            this.toolStripMenuItemDocumentsComponents,
            this.toolStripMenuItemOrderList});
            this.toolStripMenuItemReports.Name = "toolStripMenuItemReports";
            this.toolStripMenuItemReports.Size = new System.Drawing.Size(73, 24);
            this.toolStripMenuItemReports.Text = "Отчеты";
            // 
            // toolStripMenuItemDocumentList
            // 
            this.toolStripMenuItemDocumentList.Name = "toolStripMenuItemDocumentList";
            this.toolStripMenuItemDocumentList.Size = new System.Drawing.Size(276, 26);
            this.toolStripMenuItemDocumentList.Text = "Список документов";
            this.toolStripMenuItemDocumentList.Click += new System.EventHandler(this.toolStripMenuItemDocumentList_Click);
            // 
            // toolStripMenuItemDocumentsComponents
            // 
            this.toolStripMenuItemDocumentsComponents.Name = "toolStripMenuItemDocumentsComponents";
            this.toolStripMenuItemDocumentsComponents.Size = new System.Drawing.Size(295, 26);
            this.toolStripMenuItemDocumentsComponents.Text = "Документы и их компоненты";
            this.toolStripMenuItemDocumentsComponents.Click += new System.EventHandler(this.toolStripMenuItemDocumentsComponents_Click);
            // 
            // toolStripMenuItemOrderList
            // 
            this.toolStripMenuItemOrderList.Name = "toolStripMenuItemOrderList";
            this.toolStripMenuItemOrderList.Size = new System.Drawing.Size(276, 26);
            this.toolStripMenuItemOrderList.Text = "Список заказов";
            this.toolStripMenuItemOrderList.Click += new System.EventHandler(this.toolStripMenuItemOrderList_Click);
            // 
            // toolStripMenuItemWarehouseReports
            // 
            this.toolStripMenuItemWarehouseReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemWarehouseList,
            this.toolStripMenuItemWarehouseComponents,
            this.toolStripMenuItemOrdersGroupedByDate});
            this.toolStripMenuItemWarehouseReports.Name = "toolStripMenuItemWarehouseReports";
            this.toolStripMenuItemWarehouseReports.Size = new System.Drawing.Size(156, 24);
            this.toolStripMenuItemWarehouseReports.Text = "Отчеты по складам";
            // 
            // toolStripMenuItemWarehouseList
            // 
            this.toolStripMenuItemWarehouseList.Name = "toolStripMenuItemWarehouseList";
            this.toolStripMenuItemWarehouseList.Size = new System.Drawing.Size(303, 26);
            this.toolStripMenuItemWarehouseList.Text = "Список складов";
            this.toolStripMenuItemWarehouseList.Click += new System.EventHandler(this.toolStripMenuItemWarehouseList_Click);
            // 
            // toolStripMenuItemWarehouseComponents
            // 
            this.toolStripMenuItemWarehouseComponents.Name = "toolStripMenuItemWarehouseComponents";
            this.toolStripMenuItemWarehouseComponents.Size = new System.Drawing.Size(303, 26);
            this.toolStripMenuItemWarehouseComponents.Text = "Загруженность складов";
            this.toolStripMenuItemWarehouseComponents.Click += new System.EventHandler(this.toolStripMenuItemWarehouseComponents_Click);
            // 
            // toolStripMenuItemOrdersGroupedByDate
            // 
            this.toolStripMenuItemOrdersGroupedByDate.Name = "toolStripMenuItemOrdersGroupedByDate";
            this.toolStripMenuItemOrdersGroupedByDate.Size = new System.Drawing.Size(303, 26);
            this.toolStripMenuItemOrdersGroupedByDate.Text = "Общий отчет по всем заказам";
            this.toolStripMenuItemOrdersGroupedByDate.Click += new System.EventHandler(this.toolStripMenuItemOrdersGroupedByDate_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 434);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonIssuedOrder);
            this.Controls.Add(this.buttonOrderReady);
            this.Controls.Add(this.buttonTakeOrderInWork);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "Юридическая фирма";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonTakeOrderInWork;
        private System.Windows.Forms.Button buttonOrderReady;
        private System.Windows.Forms.Button buttonIssuedOrder;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDocument;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemComponents;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReports;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDocumentList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDocumentsComponents;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOrderList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWarehouses;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFillWarehouses;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWarehouseReports;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWarehouseList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWarehouseComponents;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOrdersGroupedByDate;
    }
}