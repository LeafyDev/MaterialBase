// -----------------------------------------------------------
// This program is private software, based on C# source code.
// To sell or change credits of this software is forbidden,
// except if someone approves it from the LeafyCoding INC. team.
// -----------------------------------------------------------
// Copyrights (c) 2016 MaterialBase INC. All rights reserved.
// -----------------------------------------------------------

#region

using System.Windows;
using MaterialBase.Functions;

#endregion

namespace MaterialBase
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    internal sealed partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
            => Dialog.ShowMessageDialog("AYY LMAO", "tits"); // Sample code for Rekti the titsmeister.
    }
}