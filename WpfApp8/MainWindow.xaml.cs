using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace WpfApp8
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Bold_Click(object sender, RoutedEventArgs e)
        {      
            if (start_text.Text != "" && end_text.Text != "" && int.Parse(start_text.Text) < int.Parse(end_text.Text))
            {
                TextPointer p1 = paragraf.ContentStart.GetPositionAtOffset(int.Parse(start_text.Text));
                TextPointer p2 = paragraf.ContentEnd.GetPositionAtOffset(int.Parse(end_text.Text) - textRun.Text.Length - 1);
                text.Selection.Select(p1, p2);
                text.Selection.ApplyPropertyValue(RichTextBox.FontWeightProperty, "Bold");
            }
           
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (start_text.Text != "" && end_text.Text != "" && int.Parse(start_text.Text) < int.Parse(end_text.Text))
            {
                TextPointer p1 = paragraf.ContentStart.GetPositionAtOffset(int.Parse(start_text.Text));
                TextPointer p2 = paragraf.ContentEnd.GetPositionAtOffset(int.Parse(end_text.Text) - textRun.Text.Length - 1);
                text.Selection.Select(p1, p2);
                text.Selection.ApplyPropertyValue(RichTextBox.FontStyleProperty, "Italic");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (start_text.Text != "" && end_text.Text != "" && int.Parse(start_text.Text) < int.Parse(end_text.Text))
            {
                TextPointer p1 = paragraf.ContentStart.GetPositionAtOffset(int.Parse(start_text.Text));
                TextPointer p2 = paragraf.ContentEnd.GetPositionAtOffset(int.Parse(end_text.Text) - textRun.Text.Length - 1);
                text.Selection.Select(p1, p2);
                text.Selection.ApplyPropertyValue(Run.TextDecorationsProperty, "Underline");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (start_text.Text != "" && end_text.Text != "" && int.Parse(start_text.Text) < int.Parse(end_text.Text))
            {
                ComboBox comboBox = (ComboBox)sender;
                ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
                TextPointer p1 = paragraf.ContentStart.GetPositionAtOffset(int.Parse(start_text.Text));
                TextPointer p2 = paragraf.ContentEnd.GetPositionAtOffset(int.Parse(end_text.Text) - textRun.Text.Length - 1);
                text.Selection.Select(p1, p2);
                text.Selection.ApplyPropertyValue(Run.FontSizeProperty, double.Parse(selectedItem.Content.ToString()));
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (start_text.Text != "" && end_text.Text != "" && int.Parse(start_text.Text) < int.Parse(end_text.Text))
            {
                ComboBox comboBox = (ComboBox)sender;
                ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
                TextPointer p1 = paragraf.ContentStart.GetPositionAtOffset(int.Parse(start_text.Text));
                TextPointer p2 = paragraf.ContentEnd.GetPositionAtOffset(int.Parse(end_text.Text) - textRun.Text.Length - 1);
                text.Selection.Select(p1, p2);            
                text.Selection.ApplyPropertyValue(RichTextBox.BackgroundProperty, selectedItem.Background );
               
            }
        }
    }
}
