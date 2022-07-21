namespace HW_6_Recipes
{
    partial class Form1
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
            System.Windows.Forms.Label recipeIDLabel;
            System.Windows.Forms.Label recipeNameLabel;
            System.Windows.Forms.Label mealTypeLabel;
            System.Windows.Forms.Label prepTimeLabel;
            System.Windows.Forms.Label cookTimeLabel;
            System.Windows.Forms.Label imageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.recipeIDTextBox = new System.Windows.Forms.TextBox();
            this.recipeNameTextBox = new System.Windows.Forms.TextBox();
            this.mealTypeTextBox = new System.Windows.Forms.TextBox();
            this.prepTimeTextBox = new System.Windows.Forms.TextBox();
            this.cookTimeTextBox = new System.Windows.Forms.TextBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.fillByNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.recipeNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.recipeNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipesDBDataSet = new HW_6_Recipes.RecipesDBDataSet();
            this.recipesTableAdapter = new HW_6_Recipes.RecipesDBDataSetTableAdapters.RecipesTableAdapter();
            this.tableAdapterManager = new HW_6_Recipes.RecipesDBDataSetTableAdapters.TableAdapterManager();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            recipeIDLabel = new System.Windows.Forms.Label();
            recipeNameLabel = new System.Windows.Forms.Label();
            mealTypeLabel = new System.Windows.Forms.Label();
            prepTimeLabel = new System.Windows.Forms.Label();
            cookTimeLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.fillByNameToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // recipeIDLabel
            // 
            recipeIDLabel.AutoSize = true;
            recipeIDLabel.Location = new System.Drawing.Point(108, 156);
            recipeIDLabel.Name = "recipeIDLabel";
            recipeIDLabel.Size = new System.Drawing.Size(84, 20);
            recipeIDLabel.TabIndex = 1;
            recipeIDLabel.Text = "Recipe ID:";
            // 
            // recipeNameLabel
            // 
            recipeNameLabel.AutoSize = true;
            recipeNameLabel.Location = new System.Drawing.Point(108, 188);
            recipeNameLabel.Name = "recipeNameLabel";
            recipeNameLabel.Size = new System.Drawing.Size(109, 20);
            recipeNameLabel.TabIndex = 3;
            recipeNameLabel.Text = "Recipe Name:";
            // 
            // mealTypeLabel
            // 
            mealTypeLabel.AutoSize = true;
            mealTypeLabel.Location = new System.Drawing.Point(108, 220);
            mealTypeLabel.Name = "mealTypeLabel";
            mealTypeLabel.Size = new System.Drawing.Size(85, 20);
            mealTypeLabel.TabIndex = 5;
            mealTypeLabel.Text = "Meal Type:";
            // 
            // prepTimeLabel
            // 
            prepTimeLabel.AutoSize = true;
            prepTimeLabel.Location = new System.Drawing.Point(108, 252);
            prepTimeLabel.Name = "prepTimeLabel";
            prepTimeLabel.Size = new System.Drawing.Size(84, 20);
            prepTimeLabel.TabIndex = 7;
            prepTimeLabel.Text = "Prep Time:";
            // 
            // cookTimeLabel
            // 
            cookTimeLabel.AutoSize = true;
            cookTimeLabel.Location = new System.Drawing.Point(108, 284);
            cookTimeLabel.Name = "cookTimeLabel";
            cookTimeLabel.Size = new System.Drawing.Size(88, 20);
            cookTimeLabel.TabIndex = 9;
            cookTimeLabel.Text = "Cook Time:";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(108, 316);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(58, 20);
            imageLabel.TabIndex = 11;
            imageLabel.Text = "Image:";
            // 
            // recipeIDTextBox
            // 
            this.recipeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipesBindingSource, "RecipeID", true));
            this.recipeIDTextBox.Location = new System.Drawing.Point(223, 153);
            this.recipeIDTextBox.Name = "recipeIDTextBox";
            this.recipeIDTextBox.Size = new System.Drawing.Size(380, 26);
            this.recipeIDTextBox.TabIndex = 2;
            // 
            // recipeNameTextBox
            // 
            this.recipeNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipesBindingSource, "RecipeName", true));
            this.recipeNameTextBox.Location = new System.Drawing.Point(223, 185);
            this.recipeNameTextBox.Name = "recipeNameTextBox";
            this.recipeNameTextBox.Size = new System.Drawing.Size(380, 26);
            this.recipeNameTextBox.TabIndex = 4;
            // 
            // mealTypeTextBox
            // 
            this.mealTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipesBindingSource, "MealType", true));
            this.mealTypeTextBox.Location = new System.Drawing.Point(223, 217);
            this.mealTypeTextBox.Name = "mealTypeTextBox";
            this.mealTypeTextBox.Size = new System.Drawing.Size(380, 26);
            this.mealTypeTextBox.TabIndex = 6;
            // 
            // prepTimeTextBox
            // 
            this.prepTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipesBindingSource, "PrepTime", true));
            this.prepTimeTextBox.Location = new System.Drawing.Point(223, 249);
            this.prepTimeTextBox.Name = "prepTimeTextBox";
            this.prepTimeTextBox.Size = new System.Drawing.Size(380, 26);
            this.prepTimeTextBox.TabIndex = 8;
            // 
            // cookTimeTextBox
            // 
            this.cookTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipesBindingSource, "CookTime", true));
            this.cookTimeTextBox.Location = new System.Drawing.Point(223, 281);
            this.cookTimeTextBox.Name = "cookTimeTextBox";
            this.cookTimeTextBox.Size = new System.Drawing.Size(380, 26);
            this.cookTimeTextBox.TabIndex = 10;
            // 
            // imageTextBox
            // 
            this.imageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipesBindingSource, "Image", true));
            this.imageTextBox.Location = new System.Drawing.Point(223, 313);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(380, 26);
            this.imageTextBox.TabIndex = 12;
            // 
            // picFood
            // 
            this.picFood.Location = new System.Drawing.Point(696, 103);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(415, 349);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFood.TabIndex = 13;
            this.picFood.TabStop = false;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(34, 575);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(105, 50);
            this.btnFirst.TabIndex = 14;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(158, 575);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(105, 50);
            this.btnPrevious.TabIndex = 15;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(283, 575);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 50);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(416, 575);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(105, 50);
            this.btnLast.TabIndex = 17;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(541, 575);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(105, 50);
            this.btnAddNew.TabIndex = 18;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(663, 575);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 50);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(789, 575);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 50);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(913, 575);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 50);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1037, 575);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 50);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(857, 458);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(105, 50);
            this.btnAddPicture.TabIndex = 23;
            this.btnAddPicture.Text = "Add Picture";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // fillByNameToolStrip
            // 
            this.fillByNameToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillByNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recipeNameToolStripLabel,
            this.recipeNameToolStripTextBox,
            this.fillByNameToolStripButton,
            this.toolStripButtonClear});
            this.fillByNameToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByNameToolStrip.Name = "fillByNameToolStrip";
            this.fillByNameToolStrip.Size = new System.Drawing.Size(1229, 34);
            this.fillByNameToolStrip.TabIndex = 24;
            this.fillByNameToolStrip.Text = "fillByNameToolStrip";
            // 
            // recipeNameToolStripLabel
            // 
            this.recipeNameToolStripLabel.Name = "recipeNameToolStripLabel";
            this.recipeNameToolStripLabel.Size = new System.Drawing.Size(119, 29);
            this.recipeNameToolStripLabel.Text = "Recipe Name:";
            // 
            // recipeNameToolStripTextBox
            // 
            this.recipeNameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.recipeNameToolStripTextBox.Name = "recipeNameToolStripTextBox";
            this.recipeNameToolStripTextBox.Size = new System.Drawing.Size(100, 34);
            // 
            // fillByNameToolStripButton
            // 
            this.fillByNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByNameToolStripButton.Name = "fillByNameToolStripButton";
            this.fillByNameToolStripButton.Size = new System.Drawing.Size(68, 29);
            this.fillByNameToolStripButton.Text = "Search";
            this.fillByNameToolStripButton.Click += new System.EventHandler(this.fillByNameToolStripButton_Click);
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClear.Image")));
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(115, 29);
            this.toolStripButtonClear.Text = "Clear Results";
            this.toolStripButtonClear.Click += new System.EventHandler(this.toolStripButtonClear_Click);
            // 
            // recipesBindingSource
            // 
            this.recipesBindingSource.DataMember = "Recipes";
            this.recipesBindingSource.DataSource = this.recipesDBDataSet;
            this.recipesBindingSource.CurrentChanged += new System.EventHandler(this.recipesBindingSource_CurrentChanged);
            // 
            // recipesDBDataSet
            // 
            this.recipesDBDataSet.DataSetName = "RecipesDBDataSet";
            this.recipesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recipesTableAdapter
            // 
            this.recipesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RecipesTableAdapter = this.recipesTableAdapter;
            this.tableAdapterManager.UpdateOrder = HW_6_Recipes.RecipesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 724);
            this.Controls.Add(this.fillByNameToolStrip);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.picFood);
            this.Controls.Add(recipeIDLabel);
            this.Controls.Add(this.recipeIDTextBox);
            this.Controls.Add(recipeNameLabel);
            this.Controls.Add(this.recipeNameTextBox);
            this.Controls.Add(mealTypeLabel);
            this.Controls.Add(this.mealTypeTextBox);
            this.Controls.Add(prepTimeLabel);
            this.Controls.Add(this.prepTimeTextBox);
            this.Controls.Add(cookTimeLabel);
            this.Controls.Add(this.cookTimeTextBox);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.imageTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.fillByNameToolStrip.ResumeLayout(false);
            this.fillByNameToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RecipesDBDataSet recipesDBDataSet;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private RecipesDBDataSetTableAdapters.RecipesTableAdapter recipesTableAdapter;
        private RecipesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox recipeIDTextBox;
        private System.Windows.Forms.TextBox recipeNameTextBox;
        private System.Windows.Forms.TextBox mealTypeTextBox;
        private System.Windows.Forms.TextBox prepTimeTextBox;
        private System.Windows.Forms.TextBox cookTimeTextBox;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.PictureBox picFood;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.ToolStrip fillByNameToolStrip;
        private System.Windows.Forms.ToolStripLabel recipeNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox recipeNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByNameToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

