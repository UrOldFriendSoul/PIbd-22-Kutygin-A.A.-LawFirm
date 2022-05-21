
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemComponents = new System.Windows.Forms.ToolStripMenuItem();
            this.документыtoollStripMenuItem2ToolStripMenuItemDocuments = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemWarehouses = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFillWarehouse = new System.Windows.Forms.ToolStripButton();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonTakeOrderInWork = new System.Windows.Forms.Button();
            this.buttonOrderReady = new System.Windows.Forms.Button();
            this.buttonIssuedOrder = new System.Windows.Forms.Button();
            this.buttonRef = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(17, 55);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(879, 675);
            this.dataGridView.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton,
            this.toolStripMenuItemFillWarehouse});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1319, 34);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton
            // 
            this.toolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemComponents,
            this.документыtoollStripMenuItem2ToolStripMenuItemDocuments,
            this.ToolStripMenuItemWarehouses});
            this.toolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton.Image")));
            this.toolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton.Name = "toolStripDropDownButton";
            this.toolStripDropDownButton.Size = new System.Drawing.Size(141, 29);
            this.toolStripDropDownButton.Text = "Справочники";
            // 
            // toolStripMenuItemComponents
            // 
            this.toolStripMenuItemComponents.Name = "toolStripMenuItemComponents";
            this.toolStripMenuItemComponents.Size = new System.Drawing.Size(218, 34);
            this.toolStripMenuItemComponents.Text = "Компоненты";
            this.toolStripMenuItemComponents.Click += new System.EventHandler(this.КомпонентыToolStripMenuItemComponents_Click);
            // 
            // документыtoollStripMenuItem2ToolStripMenuItemDocuments
            // 
            this.документыtoollStripMenuItem2ToolStripMenuItemDocuments.Name = "документыtoollStripMenuItem2ToolStripMenuItemDocuments";
            this.документыtoollStripMenuItem2ToolStripMenuItemDocuments.Size = new System.Drawing.Size(218, 34);
            this.документыtoollStripMenuItem2ToolStripMenuItemDocuments.Text = "Документы";
            this.документыtoollStripMenuItem2ToolStripMenuItemDocuments.Click += new System.EventHandler(this.ДокументыToollStripMenuItemDocuments_Click);
            // 
            // ToolStripMenuItemWarehouses
            // 
            this.ToolStripMenuItemWarehouses.Name = "ToolStripMenuItemWarehouses";
            this.ToolStripMenuItemWarehouses.Size = new System.Drawing.Size(218, 34);
            this.ToolStripMenuItemWarehouses.Text = "Склады";
            this.ToolStripMenuItemWarehouses.Click += new System.EventHandler(this.ToolStripMenuItemWarehouses_Click);
            // 
            // toolStripMenuItemFillWarehouse
            // 
            this.toolStripMenuItemFillWarehouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItemFillWarehouse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemFillWarehouse.Image")));
            this.toolStripMenuItemFillWarehouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMenuItemFillWarehouse.Name = "toolStripMenuItemFillWarehouse";
            this.toolStripMenuItemFillWarehouse.Size = new System.Drawing.Size(156, 29);
            this.toolStripMenuItemFillWarehouse.Text = "Пополнить склад";
            this.toolStripMenuItemFillWarehouse.Click += new System.EventHandler(this.toolStripMenuItemFillWarehouse_Click);
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(944, 135);
            this.buttonCreateOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(323, 38);
            this.buttonCreateOrder.TabIndex = 2;
            this.buttonCreateOrder.Text = "Создать заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // buttonTakeOrderInWork
            // 
            this.buttonTakeOrderInWork.Location = new System.Drawing.Point(944, 248);
            this.buttonTakeOrderInWork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTakeOrderInWork.Name = "buttonTakeOrderInWork";
            this.buttonTakeOrderInWork.Size = new System.Drawing.Size(323, 38);
            this.buttonTakeOrderInWork.TabIndex = 3;
            this.buttonTakeOrderInWork.Text = "Отдать на выполнение";
            this.buttonTakeOrderInWork.UseVisualStyleBackColor = true;
            this.buttonTakeOrderInWork.Click += new System.EventHandler(this.buttonTakeOrderInWork_Click);
            // 
            // buttonOrderReady
            // 
            this.buttonOrderReady.Location = new System.Drawing.Point(944, 368);
            this.buttonOrderReady.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOrderReady.Name = "buttonOrderReady";
            this.buttonOrderReady.Size = new System.Drawing.Size(323, 38);
            this.buttonOrderReady.TabIndex = 4;
            this.buttonOrderReady.Text = "Заказ готов";
            this.buttonOrderReady.UseVisualStyleBackColor = true;
            this.buttonOrderReady.Click += new System.EventHandler(this.buttonOrderReady_Click);
            // 
            // buttonIssuedOrder
            // 
            this.buttonIssuedOrder.Location = new System.Drawing.Point(944, 473);
            this.buttonIssuedOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonIssuedOrder.Name = "buttonIssuedOrder";
            this.buttonIssuedOrder.Size = new System.Drawing.Size(323, 38);
            this.buttonIssuedOrder.TabIndex = 5;
            this.buttonIssuedOrder.Text = "Заказ выдан";
            this.buttonIssuedOrder.UseVisualStyleBackColor = true;
            this.buttonIssuedOrder.Click += new System.EventHandler(this.buttonIssuedOrder_Click);
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(944, 575);
            this.buttonRef.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(323, 38);
            this.buttonRef.TabIndex = 6;
            this.buttonRef.Text = "Обновить список";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 750);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.buttonIssuedOrder);
            this.Controls.Add(this.buttonOrderReady);
            this.Controls.Add(this.buttonTakeOrderInWork);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton;
        private ToolStripMenuItem toolStripMenuItemComponents;
        private Button buttonCreateOrder;
        private Button buttonTakeOrderInWork;
        private Button buttonOrderReady;
        private Button buttonIssuedOrder;
        private Button buttonRef;
        private ToolStripMenuItem документыtoollStripMenuItem2ToolStripMenuItemDocuments;
        private ToolStripButton toolStripMenuItemFillWarehouse;
        private ToolStripMenuItem ToolStripMenuItemWarehouses;
    }
}