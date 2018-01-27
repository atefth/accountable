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
using Accountable.Contexts;
using Accountable.Actors.Administrators.UX;
using Accountable.Actors.Employees.UX;
using Accountable.Actors.UX;
using Accountable.Stakeholders.Companies.UX;
using Accountable.UX;
using Accountable.Actors.Administrators;

namespace Accountable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateAdmin();
            //InitialConnect();
            _mainFrame.Navigate(new Login());
            //_mainFrame.Navigate(new AddNewAdministrator());
        }

        private void InitialConnect()
        {
            using (var db = new AccountableContext())
            {
            }
        }

        public void CreateAdmin(){
            using (var db = new AccountableContext())
            {
                if (db.Administrators.Count() == 0)
                {
                    var Entry = new RootAdmin
                    {
                        Username = "user",
                        Password = "pass"
                    };
                    db.RootAdmins.Add(Entry);
                }                
                db.SaveChanges();
            }
        }
    }
}
