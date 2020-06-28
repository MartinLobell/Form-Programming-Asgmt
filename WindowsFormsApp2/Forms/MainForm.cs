//Assignment 4
//Martin Lobell
//2020-04-29

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApp2.Enumerations;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        private AnimalManager m_animalManager = new AnimalManager();
        public RecipeManager m_foodManager = new RecipeManager();
        bool hasSaved;
        string m_fileName;
        FileFormats m_fileFmt = FileFormats.txt;
        string latestSaved = "";

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
            UpdateGUI();
        }

        /// <summary>
        /// Sets the form on startup.
        /// </summary>
        public void InitializeGUI()
        {
            CategoryBox.DataSource = Enum.GetValues(typeof(Category));
            GenderBox.DataSource = Enum.GetValues(typeof(Gender));
            ObjectBox.DataSource = Enum.GetValues(typeof(Mammals));
            GenderBox.SelectedIndex = 0;
            CategoryBox.SelectedIndex = 0;
            ObjectBox.SelectedIndex = 0;
            label7.Text = "ID\t    Name\t  Age\t  Gender\t  Special characteristics";

            m_animalManager.DeleteAll();
            listBox1.Items.Clear();
            foodList.DataSource = null;
            eaterBox.Text = "";

            hasSaved = false;
        }

        /// <summary>
        /// Creates array from the list of animal objects, prints every object and returns the array.
        /// </summary>
        private string[] printAnimals(List<Animal> animals)
        {
            string[] arr = new string[animals.Count];
            int count = 0;
            foreach (Animal i in animals)
            {
                arr[count] = i.ToString();
                count++;
            }
            return arr;
        }

        private string[] printFoods(List<Recipe> recipes)
        {
            string[] arr = new string[recipes.Count];
            int count = 0;
            foreach (Recipe i in recipes)
            {
                arr[count] = i.ToString();
                count++;
            }
            return arr;
        }

        /// <summary>
        /// Resets the forms input fields when animal has been added.
        /// Loops through the Animallist and lists them in the information box in the GUI.
        /// </summary>
        public void UpdateGUI()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            infoBox.Items.Clear();

            List<Animal> list = new List<Animal>();
            for (int i = 0; i < m_animalManager.Count; i++)
            {
                list.Add(m_animalManager.GetAt(i));
            }
            infoBox.Items.AddRange(printAnimals(list));

            List<Recipe> foodList = new List<Recipe>();
            for (int i = 0; i < m_foodManager.Count; i++)
            {
                foodList.Add(m_foodManager.GetAt(i));
            }
            listBox1.Items.AddRange(printFoods(foodList));
        }

        /// <summary>
        /// If all input is valid, add animal - show error message otherwise.
        /// </summary>
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
                AddAnimalItem();
            else
                MessageBox.Show("Fill out all the boxes with valid input!");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            m_animalManager.DeleteAt(infoBox.SelectedIndex);
            UpdateGUI();
        }

        private void addFoodBtn_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm();
            if (foodForm.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(foodForm.GetString());
                m_foodManager.m_foodList.Add(foodForm.GetRecipe());
            }
            else
                MessageBox.Show("Something went wrong!");
        }

        private void addStaffBtn_Click(object sender, EventArgs e)
        {
            StaffForm staffForm = new StaffForm();
            if (staffForm.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(staffForm.GetString());
            }
        }

        /// <summary>
        /// Switch between category-based input depending on which one's selected.
        /// </summary>
        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryBox.SelectedIndex == 0)
            {
                ObjectBox.DataSource = Enum.GetValues(typeof(Mammals));
                label3.Text = "No of teeth";
            }
            else
            {
                ObjectBox.DataSource = Enum.GetValues(typeof(Insects));
                label3.Text = "No of eyes";
            }
        }

        /// <summary>
        /// Switch between species-based input depending on which one's selected.
        /// </summary>
        private void ObjectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = ObjectBox.SelectedItem.ToString();

            if (item == "Cat")
            {
                label4.Text = "Amount of whiskers";
            }
            else if (item == "Deer")
            {
                label4.Text = "Antler height";
            }
            else if (item == "Dog")
            {
                label4.Text = "Tail length";
            }
            else if (item == "Lion")
            {
                label4.Text = "Mane awersomeness";
            }
            else if (item == "Bee")
            {
                label4.Text = "Sting sharpness";
            }
            else if (item == "Butterfly")
            {
                label4.Text = "Wing strokes per minute";
            }
        }

        /// <summary>
        /// Check if all textboxes have been filled and that no integers are negative.
        /// </summary>
        private bool ValidateInput()
        {
            int number1 = int.Parse(textBox2.Text);
            int number2 = int.Parse(textBox3.Text);
            int number3 = int.Parse(textBox4.Text);

            bool ok = (!string.IsNullOrEmpty(textBox1.Text)) &
                (!string.IsNullOrEmpty(textBox2.Text)) &
                (!string.IsNullOrEmpty(textBox3.Text)) &
                (!string.IsNullOrEmpty(textBox4.Text)) &
                (number1 > -1) &
                (number2 > -1) &
                (number3 > -1);
            return ok;
        }

        /// <summary>
        /// Get values for all parameters for the constructor and instantiate object with is.
        /// </summary>
        private void AddAnimalItem()
        {
            string name = textBox1.Text;
            string age = textBox2.Text;
            Gender gender = (Gender)GenderBox.SelectedIndex;
            Category category = (Category)CategoryBox.SelectedIndex;

            string item = ObjectBox.SelectedItem.ToString();
            Animal animalItem = null;

            switch (item)
            {
                case "Cat":
                    animalItem = new Cat(name, Int32.Parse(age), gender, category, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text));
                    break;
                case "Deer":
                    animalItem = new Deer(name, Int32.Parse(age), gender, category, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text));
                    break;
                case "Dog":
                    animalItem = new Dog(name, Int32.Parse(age), gender, category, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text));
                    break;
                case "Lion":
                    animalItem = new Lion(name, Int32.Parse(age), gender, category, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text));
                    break;
                case "Bee":
                    animalItem = new Bee(name, Int32.Parse(age), gender, category, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text));
                    break;
                case "Butterfly":
                    animalItem = new Butterfly(name, Int32.Parse(age), gender, category, Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text));
                    break;
            }

            m_animalManager.AddAnimal(animalItem);

            /*
                Hämtar ättypen i strängformat och skriver ut korresponderande ord till gränssnittet
            */
            string animalEat = animalItem.GetEaterType().ToString();
            switch (animalEat)
            {
                case "Herbivore":
                    eaterBox.Text = "Vegetarian";
                    break;
                case "Carnivore":
                    eaterBox.Text = "Meat eater";
                    break;
                case "Omnivore":
                    eaterBox.Text = "All eater";
                    break;
            }

            /*
                Hämtar tillhörande matschema till den sorts djur som just lagts till och
                visar upp matinstruktionerna i gränssnittets matinstruktionsruta
            */
            FoodSchedule animalsFood = animalItem.GetFoodSchedule();

            if (animalsFood != null)
            {
                foodList.DataSource = null;
                foodList.DataSource = animalsFood.FoodDescriptionList;
            }

            foodList.DisplayMember = "FoodDescription";
            UpdateGUI();
            hasSaved = false;
        }

        private bool AskIfSure()
        {
            if ((m_fileName != String.Empty) && (m_fileName != "Untitled"))
            {
                if (MessageBox.Show("You have unsaved data.\nAre you sure you want to proceed?", "Caption", MessageBoxButtons.YesNo) == DialogResult.No)
                    return false;
                else
                    return true;
            }
            else
                return true;
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            if (hasSaved == false)
            {
                if (AskIfSure())
                    Close();
            }
            else
                Close();
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            if (hasSaved == false)
                if(AskIfSure())
                {
                    InitializeGUI();
                    UpdateGUI();
                }
                else
                {
                    InitializeGUI();
                    UpdateGUI();
                }
            else
            {
                InitializeGUI();
                UpdateGUI();
            }
        }

        private void mnuFileOpenBinary_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            try
            {
                if (result == DialogResult.OK)
                {

                    m_animalManager.BinaryDeSerialize(openFileDialog1.FileName);
                    UpdateGUI();
                    m_fileFmt = FileFormats.dat;
                    latestSaved = openFileDialog1.FileName;
                }
            }
            catch
            {
                MessageBox.Show("Could not open binary file!");
            }
        }

        private void mnuFileOpenText_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = File.OpenText(openFileDialog1.FileName))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            infoBox.Items.Add(s);
                        }
                    }
                    m_fileFmt = FileFormats.txt;
                    latestSaved = openFileDialog1.FileName;
                    hasSaved = true;
                }
                catch
                {
                    MessageBox.Show("Could not open text file!");
                }
            }
        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            string sPath = latestSaved;

            try
            {
                if (m_fileFmt == FileFormats.txt)
                {
                    if (latestSaved != string.Empty)
                    {
                        using (var sfd = new SaveFileDialog())
                        {
                            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                            sfd.Title = "Save a text file";
                            sfd.FilterIndex = 2;
                            string saveAsString = "";

                            foreach (var item in infoBox.Items)
                            {
                                saveAsString += item.ToString() + "\n";
                            }
                            File.WriteAllText(sPath, saveAsString);
                            hasSaved = true;
                            m_fileFmt = FileFormats.txt;
                        }

                        MessageBox.Show("Items were saved at \n" + sPath);
                        hasSaved = true;
                    }
                }
                else if (m_fileFmt == FileFormats.dat)
                {
                    if (latestSaved != string.Empty)
                    {
                        using (var sfd = new SaveFileDialog())
                        {
                            sfd.Filter = "dat files (*.dat)|*.dat|All files (*.*)|*.*";
                            sfd.Title = "Save a binary file";
                            sfd.FilterIndex = 2;

                            Console.WriteLine(m_animalManager.getAnimalList().Count + latestSaved);
                            m_animalManager.BinarySerialize(latestSaved);
                            hasSaved = true;
                            latestSaved = sfd.FileName;
                            m_fileFmt = FileFormats.dat;
                        }

                        MessageBox.Show("Items were saved at \n" + sPath);
                        hasSaved = true;
                    }
                }
                else if (m_fileFmt == FileFormats.xml)
                {
                    if (latestSaved != string.Empty)
                    {
                        using (var sfd = new SaveFileDialog())
                        {
                            sfd.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                            sfd.Title = "Save a XML file";
                            sfd.FilterIndex = 2;

                            m_foodManager.XMLSerialize(latestSaved);
                            hasSaved = true;
                            m_fileFmt = FileFormats.xml;
                        }

                        MessageBox.Show("Items were saved at \n" + sPath);
                        hasSaved = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Could not save file at \n" + sPath);
            }
        }

        private void mnuFileSaveAsTextFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    sfd.Title = "Save a text file";
                    sfd.FilterIndex = 2;
                    string saveAsString = "";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        foreach (var item in infoBox.Items)
                        {
                            saveAsString += item.ToString() + "\n";
                        }
                        File.WriteAllText(sfd.FileName, saveAsString);
                        hasSaved = true;
                        latestSaved = sfd.FileName;
                        m_fileFmt = FileFormats.txt;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Could not save text file!");
            }
        }

        private void mnuFileSaveAsBinary_Click(object sender, EventArgs e)
        {
            try
            {
                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = "dat files (*.dat)|*.dat|All files (*.*)|*.*";
                    sfd.Title = "Save a binary file";
                    sfd.FilterIndex = 2;

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        m_animalManager.BinarySerialize(sfd.FileName);
                        hasSaved = true;
                        latestSaved = sfd.FileName;
                        m_fileFmt = FileFormats.dat;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Could not save binary file!");
            }
        }

        private void mnuFileXMLImport_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();

            try
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    m_foodManager.XmlFileDeserialize(openFileDialog1.FileName);
                    
                    UpdateGUI();
                    latestSaved = openFileDialog1.FileName;
                    m_fileFmt = FileFormats.xml;
                }
            }
            catch
            {
                MessageBox.Show("Could not import XML file!");
            }
        }

        private void mnuFileXMLExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count > 0)
                {
                    using (var sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                        sfd.Title = "Save a XML file";
                        sfd.FilterIndex = 2;

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            m_foodManager.XMLSerialize(sfd.FileName);
                            hasSaved = true;
                            latestSaved = sfd.FileName;
                            m_fileFmt = FileFormats.xml;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Could not export XML file!");
            }
        }
    }
}