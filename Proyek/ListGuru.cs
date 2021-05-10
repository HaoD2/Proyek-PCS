using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyek
{
    class ListGuru
    {
        string kode_guru;
        string nama;
        string jenis_kelamin;
        string mengajar;
        string password;
        string notelp;
        string email;
        string alamat;

        public ListGuru(string kode_guru, string nama, string jenis_kelamin, string mengajar, string password, string notelp, string email, string alamat)
        {
            this.kode_guru = kode_guru;
            this.nama = nama;
            this.jenis_kelamin = jenis_kelamin;
            this.mengajar = mengajar;
            this.password = password;
            this.notelp = notelp;
            this.email = email;
            this.alamat = alamat;
        }

        public string Kode_guru { get => kode_guru; set => kode_guru = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Jenis_kelamin { get => jenis_kelamin; set => jenis_kelamin = value; }
        public string Mengajar { get => mengajar; set => mengajar = value; }
        public string Password { get => password; set => password = value; }
        public string Notelp { get => notelp; set => notelp = value; }
        public string Email { get => email; set => email = value; }
        public string Alamat { get => alamat; set => alamat = value; }
    }
}
