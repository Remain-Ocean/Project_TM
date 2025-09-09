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
using System.Windows.Shapes;

namespace TM_WPF
{
    /// <summary>
    /// AddToilet.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AddToilet : Window
    {
        private int CardCount = 0;
        public Toilet ToiletInfo { get; private set; }
        public AddToilet()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            ToiletInfo = new Toilet
            {
                Floor = FloorTextBox.Text,
                Gender = RadioMale.IsChecked == true ? "남자" : RadioFemale.IsChecked == true ? "여자" : "",
                LocationDetail = DetailTextBox.Text,
                Status = "정상"
            };

            string floor = FloorTextBox.Text.Trim();
            string detail = FloorTextBox.Text.Trim();
            string gender = RadioMale.IsChecked == true ? "남자" : RadioFemale.IsChecked == true ? "여자" : "";

            if (string.IsNullOrEmpty(floor))
            {
                MessageBox.Show("층을 입력해주세요.", "입력 확인", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("성별을 선택해주세요.", "입력 확인", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (string.IsNullOrEmpty(detail))
            {
                MessageBox.Show("상세 위치를 입력해주세요.", "입력 확인", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            AddCard(floor, gender, detail);

        }

        private void AddCard(string floor, string gender, string detail)
        {
            
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
