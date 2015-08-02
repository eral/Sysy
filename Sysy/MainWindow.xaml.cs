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

namespace Sysy {
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void minimize_button_Click(object sender, RoutedEventArgs e) {
			SystemCommands.MinimizeWindow(this);
		}

		private void maximize_button_Click(object sender, RoutedEventArgs e) {
			SystemCommands.MaximizeWindow(this);
		}

		private void close_button_Click(object sender, RoutedEventArgs e) {
			SystemCommands.CloseWindow(this);
		}
	}
}
