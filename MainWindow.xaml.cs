﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Breshna_Notes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> studentList = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
            Preload();
            DisplayToListBox();
        }

        // New method to display to a list box
        public void DisplayToListBox()
        {
            // Clear list box first
            lbStudents.Items.Clear();

            for (int i = 0; i < studentList.Count; i++)
            {
                lbStudents.Items.Add(studentList[i]);
            }


        }

        void Preload()
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                string firstName = "Breshna" + i;
                string lastName = "Nein" + i;
                int csiGrade = rand.Next(0, 101);
                int genEd = rand.Next(0, 101);

                Student breshna = new Student(firstName, lastName, csiGrade, genEd);

                studentList.Add(breshna);

            }

        }
        // Button Click
        private void btnUpdateStudent_Click(object sender, RoutedEventArgs e)
        {

        }

        // Selection Changed
        private void lbStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



    }
}
