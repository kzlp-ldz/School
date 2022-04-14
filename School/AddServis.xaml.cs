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

namespace School
{
    /// <summary>
    /// Логика взаимодействия для AddServis.xaml
    /// </summary>
    public partial class AddServis : Page
    {
        Service service = new Service();
        public AddServis()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void btn_safe_Click(object sender, RoutedEventArgs e)
        {
            service.Title = tbx_name.Text;
            service.Cost = int.Parse(tbx_cost.Text);
            service.Description = tbx_full.Text;
            service.Discount = int.Parse(tbx_discount.Text);
            service.DurationInSeconds = int.Parse(tbx_duration.Text);

            bd_connection.school.Service.Add(service);
            bd_connection.school.SaveChanges();
        }
    }
}
