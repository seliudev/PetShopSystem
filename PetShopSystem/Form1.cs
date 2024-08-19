namespace PetShopSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> breeds;
        private void Form1_Load(object sender, EventArgs e)
        {
            breeds = new List<string>() { "Golden Retriever (Dog)", "Pug (Dog)", "British Shorthair (Cat)", "Harz Roller (Bird)" };

            foreach (var breed in breeds)
            {
                lbxBreeds.Items.Add(breed);
            }
        }

        private void btnAddBreed_Click(object sender, EventArgs e)
        {
            if (tbxEnterBreed.Text.Length >= 2)
            {
                breeds.Add(tbxEnterBreed.Text);
                lbxBreeds.Items.Clear();
                tbxEnterBreed.Text = null;
            }
            else
            {
                MessageBox.Show("Please enter a correct animal breed! (A breed should be at least two characters.)");
            }

            foreach (var breed in breeds)
            {
                lbxBreeds.Items.Add(breed);
            }
        } 

        private void btnRemoveBreed_Click(object sender, EventArgs e)
        {
            if(lbxBreeds.SelectedItem != null)
            {
                breeds.Remove(lbxBreeds.SelectedItem.ToString());
                lbxBreeds.Items.Clear();

                foreach (var breed in breeds)
                {
                    lbxBreeds.Items.Add(breed);
                }
            }
            else
            {
                MessageBox.Show("Please select a breed to delete!");
            }
        }
    }
}
