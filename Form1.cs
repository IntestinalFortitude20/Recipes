using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_6_Recipes
{
    public partial class Form1 : Form
    {

        DataRowView currentRecipe;
        bool AddingNewRecipe = false;
        RecipesDBDataSet.RecipesRow newRecipe;

        public Form1()
        {
            InitializeComponent();
        }

        private void recipesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.recipesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.recipesDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recipesDBDataSet.Recipes' table. You can move, or remove it, as needed.
            this.recipesTableAdapter.Fill(this.recipesDBDataSet.Recipes);

            btnSave.Enabled = false;
            btnCancel.Enabled = false;

        }

        private void recipesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            currentRecipe = (DataRowView)recipesBindingSource.Current;

            if (currentRecipe != null)
            {
                if (currentRecipe.Row["Image"].ToString() != "")
                {
                    picFood.Image = Image.FromFile(currentRecipe.Row["Image"].ToString());
                }
                else
                {
                    picFood.Image = null;
                }
            }
        }
         
        private void btnFirst_Click(object sender, EventArgs e)
        {
            recipesBindingSource.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            recipesBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            recipesBindingSource.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            recipesBindingSource.MoveLast();
        }

        private void fillByNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.recipesTableAdapter.FillByName(this.recipesDBDataSet.Recipes, recipeNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {
            //refill the dataset
            this.recipesTableAdapter.Fill(this.recipesDBDataSet.Recipes);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddingNewRecipe = true;

            // create new recipe row in memory
            newRecipe = recipesDBDataSet.Recipes.NewRecipesRow();

            //attach newRecipe to the dataset
            recipesDBDataSet.Recipes.AddRecipesRow(newRecipe);

            //"move last" to show the newest entry
            recipesBindingSource.MoveLast();

            //update picFood box to be empty for the "add picture" button
            picFood.Image = null;


            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //isolate ID of the current recipe
            int recipeID = (int)currentRecipe.Row["RecipeID"];

            recipesTableAdapter.DeleteRecipe(recipeID);
            recipesBindingSource.RemoveCurrent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (AddingNewRecipe)
            {
                newRecipe.RecipeName = recipeNameTextBox.Text;
                newRecipe.MealType = mealTypeTextBox.Text;
                newRecipe.PrepTime = prepTimeTextBox.Text;
                newRecipe.CookTime = cookTimeTextBox.Text;

                //add picture
                string[] splitStrings = openFileDialog1.FileName.Split('\\');
                string picName = splitStrings[splitStrings.GetUpperBound(0)];
                newRecipe.Image = picName;

                //refresh record by moving the binding source back and next
                recipesBindingSource.MovePrevious();
                recipesBindingSource.MoveNext();

                AddingNewRecipe = false;

            }
            else //update existing record
            {
                currentRecipe.Row["RecipeName"] = recipeNameTextBox.Text;
                currentRecipe.Row["MealType"] = mealTypeTextBox.Text;
                currentRecipe.Row["PrepTime"] = prepTimeTextBox.Text;
                currentRecipe.Row["CookTime"] = cookTimeTextBox.Text;
            }

            recipesBindingSource.EndEdit();
            recipesTableAdapter.Update(recipesDBDataSet); // synchronize db in debug folder
            
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            recipesBindingSource.CancelEdit();

            if (AddingNewRecipe)
            {
                recipesBindingSource.RemoveCurrent();
            }

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
