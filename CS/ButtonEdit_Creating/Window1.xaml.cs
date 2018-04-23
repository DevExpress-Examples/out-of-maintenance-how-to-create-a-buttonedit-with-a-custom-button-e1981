using System.Windows;

namespace ButtonEdit_Creating {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
        private void ButtonInfo_Click(object sender, RoutedEventArgs e) {
            buttonEdit.EditValue = string.Empty;
        }
    }
}
