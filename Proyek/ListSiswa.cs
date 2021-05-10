using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyek
{
    class ListSiswa
    {
        string nisn;
        string nis;
        string nama;
        string jenis_kelamin;
        DateTime tanggal_lahir;
        string password;
        string alamat;
        string notelp;
        string email;
        string nama_ortu;
        int idjur;

        public ListSiswa(string nisn, string nis, string nama, string jenis_kelamin, DateTime tanggal_lahir, string password, string alamat, string notelp, string email, string nama_ortu, int idjur)
        {
            this.nisn = nisn;
            this.nis = nis;
            this.nama = nama;
            this.jenis_kelamin = jenis_kelamin;
            this.tanggal_lahir = tanggal_lahir;
            this.password = password;
            this.alamat = alamat;
            this.notelp = notelp;
            this.email = email;
            this.nama_ortu = nama_ortu;
            this.idjur = idjur;
        }

        public string Nisn { get => nisn; set => nisn = value; }
        public string Nis { get => nis; set => nis = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Jenis_kelamin { get => jenis_kelamin; set => jenis_kelamin = value; }
        public DateTime Tanggal_lahir { get => tanggal_lahir; set => tanggal_lahir = value; }
        public string Password { get => password; set => password = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Notelp { get => notelp; set => notelp = value; }
        public string Email { get => email; set => email = value; }
        public string Nama_ortu { get => nama_ortu; set => nama_ortu = value; }
        public int Idjur { get => idjur; set => idjur = value; }
    }
}
