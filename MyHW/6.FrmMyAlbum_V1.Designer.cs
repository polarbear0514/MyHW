
namespace MyHW
{
    partial class FrmMyAlbum_V1
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
            System.Windows.Forms.Label pictureIdLabel;
            System.Windows.Forms.Label areaIdLabel1;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label pictureLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMyAlbum_V1));
            System.Windows.Forms.Label areaNameLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureIdTextBox = new System.Windows.Forms.TextBox();
            this.areaIdTextBox1 = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureDataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pictureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maDataSet1 = new MyHW.MADataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaTableAdapter1 = new MyHW.MADataSetTableAdapters.AreaTableAdapter();
            this.pictureTableAdapter1 = new MyHW.MADataSetTableAdapters.PictureTableAdapter();
            this.tableAdapterManager = new MyHW.MADataSetTableAdapters.TableAdapterManager();
            this.areaNameTextBox = new System.Windows.Forms.TextBox();
            pictureIdLabel = new System.Windows.Forms.Label();
            areaIdLabel1 = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            pictureLabel = new System.Windows.Forms.Label();
            areaNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBindingNavigator)).BeginInit();
            this.pictureBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "My Album";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 324);
            this.panel1.TabIndex = 5;
            // 
            // pictureIdLabel
            // 
            pictureIdLabel.AutoSize = true;
            pictureIdLabel.Location = new System.Drawing.Point(608, 99);
            pictureIdLabel.Name = "pictureIdLabel";
            pictureIdLabel.Size = new System.Drawing.Size(53, 12);
            pictureIdLabel.TabIndex = 10;
            pictureIdLabel.Text = "Picture Id:";
            // 
            // pictureIdTextBox
            // 
            this.pictureIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pictureBindingSource, "PictureId", true));
            this.pictureIdTextBox.Location = new System.Drawing.Point(675, 96);
            this.pictureIdTextBox.Name = "pictureIdTextBox";
            this.pictureIdTextBox.Size = new System.Drawing.Size(209, 22);
            this.pictureIdTextBox.TabIndex = 11;
            // 
            // areaIdLabel1
            // 
            areaIdLabel1.AutoSize = true;
            areaIdLabel1.Location = new System.Drawing.Point(608, 127);
            areaIdLabel1.Name = "areaIdLabel1";
            areaIdLabel1.Size = new System.Drawing.Size(43, 12);
            areaIdLabel1.TabIndex = 12;
            areaIdLabel1.Text = "Area Id:";
            // 
            // areaIdTextBox1
            // 
            this.areaIdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pictureBindingSource, "AreaId", true));
            this.areaIdTextBox1.Location = new System.Drawing.Point(675, 124);
            this.areaIdTextBox1.Name = "areaIdTextBox1";
            this.areaIdTextBox1.Size = new System.Drawing.Size(209, 22);
            this.areaIdTextBox1.TabIndex = 13;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(608, 155);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(61, 12);
            descriptionLabel.TabIndex = 14;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pictureBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(675, 152);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(209, 22);
            this.descriptionTextBox.TabIndex = 15;
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.Location = new System.Drawing.Point(608, 180);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new System.Drawing.Size(40, 12);
            pictureLabel.TabIndex = 16;
            pictureLabel.Text = "Picture:";
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pictureBindingSource, "Picture", true));
            this.picturePictureBox.Location = new System.Drawing.Point(675, 180);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(209, 213);
            this.picturePictureBox.TabIndex = 17;
            this.picturePictureBox.TabStop = false;
            // 
            // pictureDataGridView
            // 
            this.pictureDataGridView.AutoGenerateColumns = false;
            this.pictureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pictureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn1});
            this.pictureDataGridView.DataSource = this.pictureBindingSource;
            this.pictureDataGridView.Location = new System.Drawing.Point(143, 99);
            this.pictureDataGridView.Name = "pictureDataGridView";
            this.pictureDataGridView.RowTemplate.Height = 24;
            this.pictureDataGridView.Size = new System.Drawing.Size(450, 324);
            this.pictureDataGridView.TabIndex = 17;
            // 
            // pictureBindingNavigator
            // 
            this.pictureBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pictureBindingNavigator.BindingSource = this.pictureBindingSource;
            this.pictureBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pictureBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pictureBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pictureBindingNavigatorSaveItem});
            this.pictureBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pictureBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pictureBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pictureBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pictureBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pictureBindingNavigator.Name = "pictureBindingNavigator";
            this.pictureBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pictureBindingNavigator.Size = new System.Drawing.Size(923, 25);
            this.pictureBindingNavigator.TabIndex = 18;
            this.pictureBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pictureBindingNavigatorSaveItem
            // 
            this.pictureBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pictureBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pictureBindingNavigatorSaveItem.Image")));
            this.pictureBindingNavigatorSaveItem.Name = "pictureBindingNavigatorSaveItem";
            this.pictureBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pictureBindingNavigatorSaveItem.Text = "儲存資料";
            // 
            // pictureBindingSource
            // 
            this.pictureBindingSource.DataMember = "Picture";
            this.pictureBindingSource.DataSource = this.maDataSet1;
            // 
            // maDataSet1
            // 
            this.maDataSet1.DataSetName = "MADataSet";
            this.maDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PictureId";
            this.dataGridViewTextBoxColumn1.HeaderText = "PictureId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AreaId";
            this.dataGridViewTextBoxColumn2.HeaderText = "AreaId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Picture";
            this.dataGridViewImageColumn1.HeaderText = "Picture";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.maDataSet1;
            // 
            // areaTableAdapter1
            // 
            this.areaTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureTableAdapter1
            // 
            this.pictureTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreaTableAdapter = this.areaTableAdapter1;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PictureTableAdapter = this.pictureTableAdapter1;
            this.tableAdapterManager.UpdateOrder = MyHW.MADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // areaNameLabel
            // 
            areaNameLabel.AutoSize = true;
            areaNameLabel.Location = new System.Drawing.Point(608, 70);
            areaNameLabel.Name = "areaNameLabel";
            areaNameLabel.Size = new System.Drawing.Size(60, 12);
            areaNameLabel.TabIndex = 20;
            areaNameLabel.Text = "Area Name:";
            // 
            // areaNameTextBox
            // 
            this.areaNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.areaBindingSource, "AreaName", true));
            this.areaNameTextBox.Location = new System.Drawing.Point(675, 67);
            this.areaNameTextBox.Name = "areaNameTextBox";
            this.areaNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.areaNameTextBox.TabIndex = 21;
            // 
            // FrmMyAlbum_V1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(areaNameLabel);
            this.Controls.Add(this.areaNameTextBox);
            this.Controls.Add(this.pictureBindingNavigator);
            this.Controls.Add(this.pictureDataGridView);
            this.Controls.Add(pictureIdLabel);
            this.Controls.Add(this.pictureIdTextBox);
            this.Controls.Add(areaIdLabel1);
            this.Controls.Add(this.areaIdTextBox1);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(pictureLabel);
            this.Controls.Add(this.picturePictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmMyAlbum_V1";
            this.Text = "FrmMyAlbum_V1";
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBindingNavigator)).EndInit();
            this.pictureBindingNavigator.ResumeLayout(false);
            this.pictureBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MADataSet maDataSet1;
        private MADataSetTableAdapters.AreaTableAdapter areaTableAdapter1;
        private MADataSetTableAdapters.PictureTableAdapter pictureTableAdapter1;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private MADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource pictureBindingSource;
        private System.Windows.Forms.TextBox pictureIdTextBox;
        private System.Windows.Forms.TextBox areaIdTextBox1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox picturePictureBox;
        private System.Windows.Forms.DataGridView pictureDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.BindingNavigator pictureBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pictureBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox areaNameTextBox;
    }
}