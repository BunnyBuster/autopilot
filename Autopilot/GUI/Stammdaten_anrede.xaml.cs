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
using System.Data.Entity;
using System.Collections.ObjectModel;

namespace Autopilot.GUI
{
    /// <summary>
    /// Interaktionslogik für Stammdaten-anrde.xaml
    /// </summary>
    public partial class Stammdaten_anrede : Page
    {
        AutopilotEntities content = new AutopilotEntities();
        bool isInsertMode = false;
        bool isBeingEdited = false;

        public Stammdaten_anrede()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = GetList();            
        }

        private ObservableCollection<anrede> GetList()
        {
            var list = from e in content.anrede select e;
            return new ObservableCollection<anrede>(list);             
        }

        private void DataGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            anrede anrede = new anrede();
            anrede data = e.Row.DataContext as anrede;
            if (isInsertMode)
            {
                var InsertRecord = MessageBox.Show("Möchten Sie " + data.anr_bez + " als neue Anrede zufügen?", "Bestätigen?", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (InsertRecord == MessageBoxResult.Yes)
                {
                    anrede.anr_bez = data.anr_bez;
                    anrede.anr_id = data.anr_id;
                    content.anrede.Add(anrede);
                    content.SaveChanges();
                    DataGrid.ItemsSource = GetList();
                    MessageBox.Show(data.anr_bez + " wurde zugefügt!", "Eintrag gespeichert", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    DataGrid.ItemsSource = GetList();
            }

            content.SaveChanges();
        }

        private void DataGrid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete && !isBeingEdited)
            {
                var grid = (DataGrid)sender;
                if (grid.SelectedItems.Count > 0)
                {
                    var Res = MessageBox.Show("Möchten Sie wirklich " + grid.SelectedItems.Count + " Anreden löschen?", "Löschen", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
                    if (Res == MessageBoxResult.Yes)
                    {
                        foreach (var row in grid.SelectedItems)
                        {
                            anrede anrede = row as anrede;
                            content.anrede.Remove(anrede);
                        }
                        content.SaveChanges();
                        MessageBox.Show(grid.SelectedItems.Count + " Anreden wurden gelöscht!");
                    }
                    else
                        DataGrid.ItemsSource = GetList();
                }
            }
        }

        private void DataGrid_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            isInsertMode = true;
        }

        private void DataGrid_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            isBeingEdited = true;
        }

    }
}
