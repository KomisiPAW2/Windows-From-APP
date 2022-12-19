# Windows-From-APP

##This app make with C# (C sharp)


## Gambar Aplikasi
![image](https://user-images.githubusercontent.com/82931864/208446563-55123d3c-2ecc-456a-937b-5595ffae9916.png)


## cara menggunakan
!!! pastikan sebelum menggunakan aplikasi koneksikan Database mssql anda kedalam code dengan nama From1.cs
*lalu anda bisa run via Debugging Visual Studio atau bisa klik execute file di directory Crud_APP\Crud_APP\bin\Debug\netcoreapp3.1\Crud_APP.exe


## install mssql via docker with docker-compose.yml 
```
version: "3"
services:
  sql-server:
    image: mcr.microsoft.com/mssql/server:2019-latest
    hostname: sql-server
    container_name: sql-server
    ports:
      - "1433:1433"
    environment:
      - ACCEPT_EULA=Y
      - SA_PASSWORD=yourStrong(!)Password
      - MSSQL_PID=Express
```
sesudah itu gunakan ```docker compose -f docker-compose.yml up -d```


## Documentation mengenai MS SQL Server
''' https://learn.microsoft.com/en-us/sql/?view=sql-server-ver16 '''


## Cara Membuat Koneksi 
'''
SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=yourStrong(!)Password");
'''


## cara membuka koneksi 
'''
con.Open();
'''


## cara menutup Koneksi
'''
con.Close();
'''

## contoh endpoint
'''
SqlCommand cmd = new SqlCommand("update  dbo.Test set Nama=@Nama,Kelas=@Kelas where NIM=@NIM", con);
            cmd.Parameters.AddWithValue("@NIM", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Nama", textBox2.Text);
            cmd.Parameters.AddWithValue("@Kelas", textBox3.Text);
            cmd.ExecuteNonQuery();
'''


## Link Youtube mengenai Penjelasan Panjang dari MS SQL SERVER dari Kelompok kami
''' https://www.youtube.com/watch?v=cjpPSjyMe18 '''


## Link Youtube referensi kami
''' https://www.youtube.com/watch?v=lo80Q8C0nXk '''
