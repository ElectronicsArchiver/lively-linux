using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace lively.Views.Pages
{
    public partial class LibraryPage : UserControl
    {
        public LibraryPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
