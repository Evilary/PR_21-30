using System.Windows.Controls;

namespace RegIN_Чернышков.Pages
{
    public partial class Confirmation : Page
    {
        public enum TypeConfirmation
        {
            Login
        }

        public Confirmation(TypeConfirmation typeConfirmation)
        {
            InitializeComponent();
        }
    }
}