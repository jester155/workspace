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

namespace Cars
{
    public partial class MainWindow : Form
    {
        string file;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchFunction(SearchBox.Text);

            if (MakeBox.Text != "" && ModelBox.Text != "")
            {
                StringBuilder navigate = new StringBuilder();
                navigate
                    .Append(MakeBox.Text)
                    .Append(" ")
                    .Append(ModelBox.Text);
                GoogleTabBrowser.Navigate("http://google.com/search?q=" + navigate.ToString());
                WikipediaTabBrowser.Navigate("http://wikipedia.com/wiki/" + navigate.ToString());
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            StringBuilder car = new StringBuilder();
            car
                .Append(MakeLabel.Text)
                .Append(", ")
                .Append(ModelLabel.Text)
                .Append(", ")
                .Append(ColorLabel.Text)
                .Append(", ")
                .Append(YearLabel.Text)
                .AppendLine()
                .Append("<------------------------------------------------->")
                .AppendLine()
                .Append(MakeBox.Text)
                .Append(", ")
                .Append(ModelBox.Text)
                .Append(", ")
                .Append(ColorBox.Text)
                .Append(", ")
                .Append(YearBox.Text);

            Stream myStream;
            SaveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|CSV files (*.csv)|*.csv";
            SaveFileDialog.FilterIndex = 1;
            SaveFileDialog.RestoreDirectory = true;
            SaveFileDialog.Title = "Save";
            SaveFileDialog.FileName = SaveLocationBox.Text;

            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = SaveFileDialog.OpenFile()) != null)
                {
                    myStream.Write(Encoding.ASCII.GetBytes(car.ToString()), 0, Encoding.ASCII.GetBytes(car.ToString()).Length);
                    myStream.Close();
                    file = Path.GetFullPath(SaveFileDialog.FileName);
                    SaveLocationBox.Text = file;
                }
            }

            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MakeBox.Clear();
            ModelBox.Clear();
            ColorBox.Clear();
            YearBox.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            using (var destination = File.AppendText(file))
            {
                StringBuilder car = new StringBuilder();
            car
                .Append(MakeLabel.Text)
                .Append(", ")
                .Append(ModelLabel.Text)
                .Append(", ")
                .Append(ColorLabel.Text)
                .Append(", ")
                .Append(YearLabel.Text)
                .AppendLine()
                .Append("<------------------------------------------------->")
                .AppendLine()
                .Append(MakeBox.Text)
                .Append(", ")
                .Append(ModelBox.Text)
                .Append(", ")
                .Append(ColorBox.Text)
                .Append(", ")
                .Append(YearBox.Text);

                destination.WriteLine(car.ToString());
            }

        }

        private void searchFunction(string search)
        {
            if ("default".Contains(search))
            {
                MakeBox.Text = DeclaredCars.defaultCar.getMake();
                ModelBox.Text = DeclaredCars.defaultCar.getModel();
                ColorBox.Text = DeclaredCars.defaultCar.getColor();
                YearBox.Text = DeclaredCars.defaultCar.getYear().ToString();
            }
            else if ("mark's car".Contains(search) || "marks car".Contains(search))
            {
                MakeBox.Text = DeclaredCars.marksCar.getMake();
                ModelBox.Text = DeclaredCars.marksCar.getModel();
                ColorBox.Text = DeclaredCars.marksCar.getColor();
                YearBox.Text = DeclaredCars.marksCar.getYear().ToString();
            }
            else if ("shannon's car".Contains(search) || "shannons car".Contains(search))
            {
                MakeBox.Text = DeclaredCars.shannonsCar.getMake();
                ModelBox.Text = DeclaredCars.shannonsCar.getModel();
                ColorBox.Text = DeclaredCars.shannonsCar.getColor();
                YearBox.Text = DeclaredCars.shannonsCar.getYear().ToString();
            }
            else if ("shana's car".Contains(SearchBox.Text) || "shanas car".Contains(SearchBox.Text))
            {
                MakeBox.Text = DeclaredCars.shanasCar.getMake();
                ModelBox.Text = DeclaredCars.shanasCar.getModel();
                ColorBox.Text = DeclaredCars.shanasCar.getColor();
                YearBox.Text = DeclaredCars.shanasCar.getYear().ToString();
            }
        }
    }
}
