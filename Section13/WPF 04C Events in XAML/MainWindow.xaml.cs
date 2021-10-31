using System;
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

namespace WPF_04C_Events_in_XAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button was clicked - Direct Event");
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse button went up / was released - Bubbling event");
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Mouse button went up / was released - Tunneling event");
        }

        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Left Mouse button went down - Tunneling event");
        }

        private void Button_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Right mouse button went up- Tunneling event");
        }


        // https://stackoverflow.com/questions/16736444/difference-between-bubbling-and-tunneling-events?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa
        // Routed events - WPF mechanisms to handle events
        // Direct routed events - handled by the item itself. e.g. click 

        // Bubbling Event - Bubbling happens when the event is not handled by the element 
        // ( say a textbox) and the event "bubbles" its way up the UI containers which hold it. 
        // For example, let's say you have a window that contains a panel and inside that panel 
        // you have a grid and inside the grid you have a textbox. If the event is not handled by the textbox, 
        // then it moves, is passed or "bubbles" up to the grid level (as the grid contains the textbox),
        // if it is not handled at that level then the event bubbles further up the "tree" (known as a visual tree) 
        // to the panel where it may or may not be handled. This process continues until it is handled or the event 
        // "escapes" the top most element.
        // Examples of a bubbling event would be something like a MouseButtonDown event. Or a Keydown event.

        /// Tunneling Event
        /// Tunneling is the opposite of Bubbling.So instead of an event going "up" the visual tree, 
        /// the event travels down the visual tree toward the element that is considered the source.
        /// The standard WPF naming definition of a tunneling event is that they all start with "preview"
        /// for example previewdownkey and previewmousebuttondown. You can catch them on their way to the "target"
        /// element and handle it. An example for this might be perhaps you have some controls inside 
        /// a grid control and for some reason you have decided that no control within that grid will 
        /// be allowed to have the letter "t" reach it.

    }
}
