namespace SchoolEF6.DestopApp
{
    partial class Teachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teachers));
            System.Windows.Forms.Label standardIdLabel;
            System.Windows.Forms.Label teacherIdLabel;
            System.Windows.Forms.Label teacherNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label standardIdLabel1;
            System.Windows.Forms.Label standardNameLabel;
            this.teacherBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.teacherBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.standardIdTextBox = new System.Windows.Forms.TextBox();
            this.teacherIdTextBox = new System.Windows.Forms.TextBox();
            this.teacherNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.standardIdTextBox1 = new System.Windows.Forms.TextBox();
            this.standardNameTextBox = new System.Windows.Forms.TextBox();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            standardIdLabel = new System.Windows.Forms.Label();
            teacherIdLabel = new System.Windows.Forms.Label();
            teacherNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            standardIdLabel1 = new System.Windows.Forms.Label();
            standardNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingNavigator)).BeginInit();
            this.teacherBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherBindingNavigator
            // 
            this.teacherBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.teacherBindingNavigator.BindingSource = this.teacherBindingSource;
            this.teacherBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.teacherBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.teacherBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.teacherBindingNavigatorSaveItem});
            this.teacherBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.teacherBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.teacherBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.teacherBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.teacherBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.teacherBindingNavigator.Name = "teacherBindingNavigator";
            this.teacherBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.teacherBindingNavigator.Size = new System.Drawing.Size(611, 27);
            this.teacherBindingNavigator.TabIndex = 0;
            this.teacherBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // teacherBindingNavigatorSaveItem
            // 
            this.teacherBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.teacherBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("teacherBindingNavigatorSaveItem.Image")));
            this.teacherBindingNavigatorSaveItem.Name = "teacherBindingNavigatorSaveItem";
            this.teacherBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.teacherBindingNavigatorSaveItem.Text = "Save Data";
            this.teacherBindingNavigatorSaveItem.Click += new System.EventHandler(this.teacherBindingNavigatorSaveItem_Click);
            // 
            // standardIdLabel
            // 
            standardIdLabel.AutoSize = true;
            standardIdLabel.Location = new System.Drawing.Point(12, 29);
            standardIdLabel.Name = "standardIdLabel";
            standardIdLabel.Size = new System.Drawing.Size(77, 15);
            standardIdLabel.TabIndex = 1;
            standardIdLabel.Text = "Standard Id:";
            // 
            // standardIdTextBox
            // 
            this.standardIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "StandardId", true));
            this.standardIdTextBox.Location = new System.Drawing.Point(111, 26);
            this.standardIdTextBox.Name = "standardIdTextBox";
            this.standardIdTextBox.Size = new System.Drawing.Size(100, 25);
            this.standardIdTextBox.TabIndex = 2;
            // 
            // teacherIdLabel
            // 
            teacherIdLabel.AutoSize = true;
            teacherIdLabel.Location = new System.Drawing.Point(12, 60);
            teacherIdLabel.Name = "teacherIdLabel";
            teacherIdLabel.Size = new System.Drawing.Size(72, 15);
            teacherIdLabel.TabIndex = 3;
            teacherIdLabel.Text = "Teacher Id:";
            // 
            // teacherIdTextBox
            // 
            this.teacherIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "TeacherId", true));
            this.teacherIdTextBox.Location = new System.Drawing.Point(111, 57);
            this.teacherIdTextBox.Name = "teacherIdTextBox";
            this.teacherIdTextBox.Size = new System.Drawing.Size(100, 25);
            this.teacherIdTextBox.TabIndex = 4;
            // 
            // teacherNameLabel
            // 
            teacherNameLabel.AutoSize = true;
            teacherNameLabel.Location = new System.Drawing.Point(12, 91);
            teacherNameLabel.Name = "teacherNameLabel";
            teacherNameLabel.Size = new System.Drawing.Size(93, 15);
            teacherNameLabel.TabIndex = 5;
            teacherNameLabel.Text = "Teacher Name:";
            // 
            // teacherNameTextBox
            // 
            this.teacherNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "TeacherName", true));
            this.teacherNameTextBox.Location = new System.Drawing.Point(111, 88);
            this.teacherNameTextBox.Name = "teacherNameTextBox";
            this.teacherNameTextBox.Size = new System.Drawing.Size(100, 25);
            this.teacherNameTextBox.TabIndex = 6;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(254, 32);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(76, 15);
            descriptionLabel.TabIndex = 7;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Standard.Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(358, 29);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 25);
            this.descriptionTextBox.TabIndex = 8;
            // 
            // standardIdLabel1
            // 
            standardIdLabel1.AutoSize = true;
            standardIdLabel1.Location = new System.Drawing.Point(254, 63);
            standardIdLabel1.Name = "standardIdLabel1";
            standardIdLabel1.Size = new System.Drawing.Size(77, 15);
            standardIdLabel1.TabIndex = 9;
            standardIdLabel1.Text = "Standard Id:";
            // 
            // standardIdTextBox1
            // 
            this.standardIdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Standard.StandardId", true));
            this.standardIdTextBox1.Location = new System.Drawing.Point(358, 60);
            this.standardIdTextBox1.Name = "standardIdTextBox1";
            this.standardIdTextBox1.Size = new System.Drawing.Size(100, 25);
            this.standardIdTextBox1.TabIndex = 10;
            // 
            // standardNameLabel
            // 
            standardNameLabel.AutoSize = true;
            standardNameLabel.Location = new System.Drawing.Point(254, 94);
            standardNameLabel.Name = "standardNameLabel";
            standardNameLabel.Size = new System.Drawing.Size(98, 15);
            standardNameLabel.TabIndex = 11;
            standardNameLabel.Text = "Standard Name:";
            // 
            // standardNameTextBox
            // 
            this.standardNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Standard.StandardName", true));
            this.standardNameTextBox.Location = new System.Drawing.Point(358, 91);
            this.standardNameTextBox.Name = "standardNameTextBox";
            this.standardNameTextBox.Size = new System.Drawing.Size(100, 25);
            this.standardNameTextBox.TabIndex = 12;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(SchoolEF6.DAL.Teacher);
            this.teacherBindingSource.CurrentItemChanged += new System.EventHandler(this.teacherBindingSource_CurrentItemChanged);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(SchoolEF6.DAL.Course);
            // 
            // courseDataGridView
            // 
            this.courseDataGridView.AutoGenerateColumns = false;
            this.courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.courseDataGridView.DataSource = this.courseBindingSource;
            this.courseDataGridView.Location = new System.Drawing.Point(15, 173);
            this.courseDataGridView.Name = "courseDataGridView";
            this.courseDataGridView.RowTemplate.Height = 27;
            this.courseDataGridView.Size = new System.Drawing.Size(579, 276);
            this.courseDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CourseId";
            this.dataGridViewTextBoxColumn1.HeaderText = "CourseId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CourseName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CourseName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn3.HeaderText = "Location";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 473);
            this.Controls.Add(this.courseDataGridView);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(standardIdLabel1);
            this.Controls.Add(this.standardIdTextBox1);
            this.Controls.Add(standardNameLabel);
            this.Controls.Add(this.standardNameTextBox);
            this.Controls.Add(standardIdLabel);
            this.Controls.Add(this.standardIdTextBox);
            this.Controls.Add(teacherIdLabel);
            this.Controls.Add(this.teacherIdTextBox);
            this.Controls.Add(teacherNameLabel);
            this.Controls.Add(this.teacherNameTextBox);
            this.Controls.Add(this.teacherBindingNavigator);
            this.Name = "Teachers";
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.Teachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingNavigator)).EndInit();
            this.teacherBindingNavigator.ResumeLayout(false);
            this.teacherBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.BindingNavigator teacherBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton teacherBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox standardIdTextBox;
        private System.Windows.Forms.TextBox teacherIdTextBox;
        private System.Windows.Forms.TextBox teacherNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox standardIdTextBox1;
        private System.Windows.Forms.TextBox standardNameTextBox;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.DataGridView courseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;


    }
}