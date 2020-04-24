namespace Assignment_structure
{
    partial class datagrid
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noproductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.developmenttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planneddowntimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedprotimehrsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mcbdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeoverproductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeoverreelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchcoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessworkersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialissuesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabletcrashingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startuptimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleaningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaldowntimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalminavailableproDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualproductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reworkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defectsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalrejectinsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualoutputDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualityrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetoutputshiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.performancerateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productDataSet1 = new Assignment_structure.productDataSet1();
            this.productDataSet = new Assignment_structure.productDataSet();
            this.oeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oeeTableAdapter = new Assignment_structure.productDataSetTableAdapters.oeeTableAdapter();
            this.oeeTableAdapter1 = new Assignment_structure.productDataSet1TableAdapters.oeeTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn,
            this.noproductionDataGridViewTextBoxColumn,
            this.developmenttimeDataGridViewTextBoxColumn,
            this.planneddowntimeDataGridViewTextBoxColumn,
            this.plannedprotimehrsDataGridViewTextBoxColumn,
            this.totalminDataGridViewTextBoxColumn,
            this.mcbdDataGridViewTextBoxColumn,
            this.changeoverproductionDataGridViewTextBoxColumn,
            this.changeoverreelDataGridViewTextBoxColumn,
            this.batchcoDataGridViewTextBoxColumn,
            this.lessworkersDataGridViewTextBoxColumn,
            this.materialissuesDataGridViewTextBoxColumn,
            this.tabletcrashingDataGridViewTextBoxColumn,
            this.startuptimeDataGridViewTextBoxColumn,
            this.cleaningDataGridViewTextBoxColumn,
            this.miscDataGridViewTextBoxColumn,
            this.totaldowntimeDataGridViewTextBoxColumn,
            this.totalminavailableproDataGridViewTextBoxColumn,
            this.availabilityrateDataGridViewTextBoxColumn,
            this.actualproductionDataGridViewTextBoxColumn,
            this.reworkDataGridViewTextBoxColumn,
            this.defectsDataGridViewTextBoxColumn,
            this.sampleDataGridViewTextBoxColumn,
            this.totalrejectinsDataGridViewTextBoxColumn,
            this.actualoutputDataGridViewTextBoxColumn,
            this.qualityrateDataGridViewTextBoxColumn,
            this.targetoutputshiftDataGridViewTextBoxColumn,
            this.performancerateDataGridViewTextBoxColumn,
            this.oEEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oeeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(25, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(2000, 477);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "start_time";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "start_time";
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            // 
            // endtimeDataGridViewTextBoxColumn
            // 
            this.endtimeDataGridViewTextBoxColumn.DataPropertyName = "end_time";
            this.endtimeDataGridViewTextBoxColumn.HeaderText = "end_time";
            this.endtimeDataGridViewTextBoxColumn.Name = "endtimeDataGridViewTextBoxColumn";
            // 
            // noproductionDataGridViewTextBoxColumn
            // 
            this.noproductionDataGridViewTextBoxColumn.DataPropertyName = "no_production";
            this.noproductionDataGridViewTextBoxColumn.HeaderText = "no_production";
            this.noproductionDataGridViewTextBoxColumn.Name = "noproductionDataGridViewTextBoxColumn";
            // 
            // developmenttimeDataGridViewTextBoxColumn
            // 
            this.developmenttimeDataGridViewTextBoxColumn.DataPropertyName = "development_time";
            this.developmenttimeDataGridViewTextBoxColumn.HeaderText = "development_time";
            this.developmenttimeDataGridViewTextBoxColumn.Name = "developmenttimeDataGridViewTextBoxColumn";
            // 
            // planneddowntimeDataGridViewTextBoxColumn
            // 
            this.planneddowntimeDataGridViewTextBoxColumn.DataPropertyName = "planned_downtime";
            this.planneddowntimeDataGridViewTextBoxColumn.HeaderText = "planned_downtime";
            this.planneddowntimeDataGridViewTextBoxColumn.Name = "planneddowntimeDataGridViewTextBoxColumn";
            // 
            // plannedprotimehrsDataGridViewTextBoxColumn
            // 
            this.plannedprotimehrsDataGridViewTextBoxColumn.DataPropertyName = "planned_pro_time_hrs";
            this.plannedprotimehrsDataGridViewTextBoxColumn.HeaderText = "planned_pro_time_hrs";
            this.plannedprotimehrsDataGridViewTextBoxColumn.Name = "plannedprotimehrsDataGridViewTextBoxColumn";
            // 
            // totalminDataGridViewTextBoxColumn
            // 
            this.totalminDataGridViewTextBoxColumn.DataPropertyName = "total_min";
            this.totalminDataGridViewTextBoxColumn.HeaderText = "total_min";
            this.totalminDataGridViewTextBoxColumn.Name = "totalminDataGridViewTextBoxColumn";
            // 
            // mcbdDataGridViewTextBoxColumn
            // 
            this.mcbdDataGridViewTextBoxColumn.DataPropertyName = "mc_bd";
            this.mcbdDataGridViewTextBoxColumn.HeaderText = "mc_bd";
            this.mcbdDataGridViewTextBoxColumn.Name = "mcbdDataGridViewTextBoxColumn";
            // 
            // changeoverproductionDataGridViewTextBoxColumn
            // 
            this.changeoverproductionDataGridViewTextBoxColumn.DataPropertyName = "changeover_production";
            this.changeoverproductionDataGridViewTextBoxColumn.HeaderText = "changeover_production";
            this.changeoverproductionDataGridViewTextBoxColumn.Name = "changeoverproductionDataGridViewTextBoxColumn";
            // 
            // changeoverreelDataGridViewTextBoxColumn
            // 
            this.changeoverreelDataGridViewTextBoxColumn.DataPropertyName = "changeover_reel";
            this.changeoverreelDataGridViewTextBoxColumn.HeaderText = "changeover_reel";
            this.changeoverreelDataGridViewTextBoxColumn.Name = "changeoverreelDataGridViewTextBoxColumn";
            // 
            // batchcoDataGridViewTextBoxColumn
            // 
            this.batchcoDataGridViewTextBoxColumn.DataPropertyName = "batch_co";
            this.batchcoDataGridViewTextBoxColumn.HeaderText = "batch_co";
            this.batchcoDataGridViewTextBoxColumn.Name = "batchcoDataGridViewTextBoxColumn";
            // 
            // lessworkersDataGridViewTextBoxColumn
            // 
            this.lessworkersDataGridViewTextBoxColumn.DataPropertyName = "less_workers";
            this.lessworkersDataGridViewTextBoxColumn.HeaderText = "less_workers";
            this.lessworkersDataGridViewTextBoxColumn.Name = "lessworkersDataGridViewTextBoxColumn";
            // 
            // materialissuesDataGridViewTextBoxColumn
            // 
            this.materialissuesDataGridViewTextBoxColumn.DataPropertyName = "material_issues";
            this.materialissuesDataGridViewTextBoxColumn.HeaderText = "material_issues";
            this.materialissuesDataGridViewTextBoxColumn.Name = "materialissuesDataGridViewTextBoxColumn";
            // 
            // tabletcrashingDataGridViewTextBoxColumn
            // 
            this.tabletcrashingDataGridViewTextBoxColumn.DataPropertyName = "tablet_crashing";
            this.tabletcrashingDataGridViewTextBoxColumn.HeaderText = "tablet_crashing";
            this.tabletcrashingDataGridViewTextBoxColumn.Name = "tabletcrashingDataGridViewTextBoxColumn";
            // 
            // startuptimeDataGridViewTextBoxColumn
            // 
            this.startuptimeDataGridViewTextBoxColumn.DataPropertyName = "startup_time";
            this.startuptimeDataGridViewTextBoxColumn.HeaderText = "startup_time";
            this.startuptimeDataGridViewTextBoxColumn.Name = "startuptimeDataGridViewTextBoxColumn";
            // 
            // cleaningDataGridViewTextBoxColumn
            // 
            this.cleaningDataGridViewTextBoxColumn.DataPropertyName = "cleaning";
            this.cleaningDataGridViewTextBoxColumn.HeaderText = "cleaning";
            this.cleaningDataGridViewTextBoxColumn.Name = "cleaningDataGridViewTextBoxColumn";
            // 
            // miscDataGridViewTextBoxColumn
            // 
            this.miscDataGridViewTextBoxColumn.DataPropertyName = "misc";
            this.miscDataGridViewTextBoxColumn.HeaderText = "misc";
            this.miscDataGridViewTextBoxColumn.Name = "miscDataGridViewTextBoxColumn";
            // 
            // totaldowntimeDataGridViewTextBoxColumn
            // 
            this.totaldowntimeDataGridViewTextBoxColumn.DataPropertyName = "total_downtime";
            this.totaldowntimeDataGridViewTextBoxColumn.HeaderText = "total_downtime";
            this.totaldowntimeDataGridViewTextBoxColumn.Name = "totaldowntimeDataGridViewTextBoxColumn";
            // 
            // totalminavailableproDataGridViewTextBoxColumn
            // 
            this.totalminavailableproDataGridViewTextBoxColumn.DataPropertyName = "total_min_available_pro";
            this.totalminavailableproDataGridViewTextBoxColumn.HeaderText = "total_min_available_pro";
            this.totalminavailableproDataGridViewTextBoxColumn.Name = "totalminavailableproDataGridViewTextBoxColumn";
            // 
            // availabilityrateDataGridViewTextBoxColumn
            // 
            this.availabilityrateDataGridViewTextBoxColumn.DataPropertyName = "availability_rate";
            this.availabilityrateDataGridViewTextBoxColumn.HeaderText = "availability_rate";
            this.availabilityrateDataGridViewTextBoxColumn.Name = "availabilityrateDataGridViewTextBoxColumn";
            // 
            // actualproductionDataGridViewTextBoxColumn
            // 
            this.actualproductionDataGridViewTextBoxColumn.DataPropertyName = "actual_production";
            this.actualproductionDataGridViewTextBoxColumn.HeaderText = "actual_production";
            this.actualproductionDataGridViewTextBoxColumn.Name = "actualproductionDataGridViewTextBoxColumn";
            // 
            // reworkDataGridViewTextBoxColumn
            // 
            this.reworkDataGridViewTextBoxColumn.DataPropertyName = "rework";
            this.reworkDataGridViewTextBoxColumn.HeaderText = "rework";
            this.reworkDataGridViewTextBoxColumn.Name = "reworkDataGridViewTextBoxColumn";
            // 
            // defectsDataGridViewTextBoxColumn
            // 
            this.defectsDataGridViewTextBoxColumn.DataPropertyName = "defects";
            this.defectsDataGridViewTextBoxColumn.HeaderText = "defects";
            this.defectsDataGridViewTextBoxColumn.Name = "defectsDataGridViewTextBoxColumn";
            // 
            // sampleDataGridViewTextBoxColumn
            // 
            this.sampleDataGridViewTextBoxColumn.DataPropertyName = "sample";
            this.sampleDataGridViewTextBoxColumn.HeaderText = "sample";
            this.sampleDataGridViewTextBoxColumn.Name = "sampleDataGridViewTextBoxColumn";
            // 
            // totalrejectinsDataGridViewTextBoxColumn
            // 
            this.totalrejectinsDataGridViewTextBoxColumn.DataPropertyName = "total_rejectins";
            this.totalrejectinsDataGridViewTextBoxColumn.HeaderText = "total_rejectins";
            this.totalrejectinsDataGridViewTextBoxColumn.Name = "totalrejectinsDataGridViewTextBoxColumn";
            // 
            // actualoutputDataGridViewTextBoxColumn
            // 
            this.actualoutputDataGridViewTextBoxColumn.DataPropertyName = "actual_output";
            this.actualoutputDataGridViewTextBoxColumn.HeaderText = "actual_output";
            this.actualoutputDataGridViewTextBoxColumn.Name = "actualoutputDataGridViewTextBoxColumn";
            // 
            // qualityrateDataGridViewTextBoxColumn
            // 
            this.qualityrateDataGridViewTextBoxColumn.DataPropertyName = "quality_rate";
            this.qualityrateDataGridViewTextBoxColumn.HeaderText = "quality_rate";
            this.qualityrateDataGridViewTextBoxColumn.Name = "qualityrateDataGridViewTextBoxColumn";
            // 
            // targetoutputshiftDataGridViewTextBoxColumn
            // 
            this.targetoutputshiftDataGridViewTextBoxColumn.DataPropertyName = "target_output_shift";
            this.targetoutputshiftDataGridViewTextBoxColumn.HeaderText = "target_output_shift";
            this.targetoutputshiftDataGridViewTextBoxColumn.Name = "targetoutputshiftDataGridViewTextBoxColumn";
            // 
            // performancerateDataGridViewTextBoxColumn
            // 
            this.performancerateDataGridViewTextBoxColumn.DataPropertyName = "performance_rate";
            this.performancerateDataGridViewTextBoxColumn.HeaderText = "performance_rate";
            this.performancerateDataGridViewTextBoxColumn.Name = "performancerateDataGridViewTextBoxColumn";
            // 
            // oEEDataGridViewTextBoxColumn
            // 
            this.oEEDataGridViewTextBoxColumn.DataPropertyName = "OEE";
            this.oEEDataGridViewTextBoxColumn.HeaderText = "OEE";
            this.oEEDataGridViewTextBoxColumn.Name = "oEEDataGridViewTextBoxColumn";
            // 
            // oeeBindingSource1
            // 
            this.oeeBindingSource1.DataMember = "oee";
            this.oeeBindingSource1.DataSource = this.productDataSet1;
            // 
            // productDataSet1
            // 
            this.productDataSet1.DataSetName = "productDataSet1";
            this.productDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productDataSet
            // 
            this.productDataSet.DataSetName = "productDataSet";
            this.productDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oeeBindingSource
            // 
            this.oeeBindingSource.DataMember = "oee";
            this.oeeBindingSource.DataSource = this.productDataSet;
            // 
            // oeeTableAdapter
            // 
            this.oeeTableAdapter.ClearBeforeFill = true;
            // 
            // oeeTableAdapter1
            // 
            this.oeeTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(718, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "PERFOMANCE DATA GRID";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(932, 668);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back To Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // datagrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1541, 895);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "datagrid";
            this.Text = "datagrid";
            this.Load += new System.EventHandler(this.Datagrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private productDataSet productDataSet;
        private System.Windows.Forms.BindingSource oeeBindingSource;
        private productDataSetTableAdapters.oeeTableAdapter oeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noproductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn developmenttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planneddowntimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedprotimehrsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mcbdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeoverproductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeoverreelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchcoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessworkersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialissuesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabletcrashingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startuptimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleaningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaldowntimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalminavailableproDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availabilityrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualproductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reworkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defectsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalrejectinsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualoutputDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualityrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetoutputshiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn performancerateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oEEDataGridViewTextBoxColumn;
        private productDataSet1 productDataSet1;
        private System.Windows.Forms.BindingSource oeeBindingSource1;
        private productDataSet1TableAdapters.oeeTableAdapter oeeTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}