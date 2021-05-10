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
using Oracle.DataAccess.Client;

namespace Proyek
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        public static string nmuser;
        public static int current_idus;
        OracleConnection conn;
        List<ListSiswa> listsiswa = new List<ListSiswa>();
        List<ListGuru> listguru = new List<ListGuru>();

/*        private void addsiswa()
        {
            OracleCommand cmd = new OracleCommand($"select * from SISWA", conn);
            conn.Close();
            conn.Open();
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listsiswa.Add(new ListSiswa(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), Convert.ToInt32(reader[10])));
            }
            conn.Close();
        }

        private void addguru()
        {
            OracleCommand cmd = new OracleCommand($"select * from GURU", conn);
            conn.Close();
            conn.Open();
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listguru.Add(new ListGuru(reader.GetString(0),reader.GetString(1),reader.GetString(2),reader.GetString(3),reader.GetString(4),reader.GetString(5),reader.GetString(6),reader.GetString(7)));
            }
            conn.Close();
        }*/

        public LoginForm()
        {
            InitializeComponent();
            conn = MainWindow.conn;
/*            addsiswa();
            addguru();*/
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            if (tbNISP.Text.ToUpper() == "ADMIN" && tbpassword.Text.ToUpper() == "ADMIN")
            {
                MasterMahasiswa mm = new MasterMahasiswa();
                this.Close();
                mm.Show();
            }
            else
            {
/*                for (int i = 0; i < listuser.Count; i++)
                {
                    if (tbNISP.Text.ToUpper() == listuser[i].Username.ToUpper())
                    {
                        if (tbpassword.Text.ToUpper() == listuser[i].Password.ToUpper())
                        {
                            nmuser = listuser[i].Nama_user;
                            current_idus = listuser[i].Id;
                            login = true;
                        }
                    }
                }

                if (login)
                {
                    WindowKerjaKuis wkk = new WindowKerjaKuis();
                    this.Close();
                    wkk.ShowDialog();
                }
                else
                {
                    MessageBox.Show("username dan password salah");
                }*/
            }
        }
    }
}
