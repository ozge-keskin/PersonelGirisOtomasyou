

using Microsoft.Data.SqlClient;
using System.Data;

namespace Otomasyon
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
        }
        //veri taban� ba�lant�s�n� nu kodla �ekiyoruz
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-JJKJQG1\SQLEXPRESS;Database=Otomasyon;integrated security=True;MultipleActiveResultSets=True;");
        SqlCommand command;
        SqlDataAdapter dataAdapter = new SqlDataAdapter();

        void PersonelGetir()
        {
            connection.Open();
            dataAdapter = new SqlDataAdapter(@"SELECT [PerId],[PerAd]
      ,[PerSoyad]
      ,[PerSehir]
      ,[PerMaas]
      ,[PerDurum]
      ,[PerMeslek]
  FROM [Otomasyon].[dbo].[Tbl_Personel]", connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }
        void ClearText()
        {
            PerId.Text = "";
            PerAd.Text = "";
            PerSoyad.Text = "";
            comboBox1.Text = "";
            PerMaas.Text = "";
            label7.Text = "";
            PerMeslek.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PersonelGetir();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PerAd_TextChanged(object sender, EventArgs e)
        {

        }



        private void PerMeslek_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnlist_Click(object sender, EventArgs e)
        {
            PersonelGetir();
        }
        private void btnsave_Click(object sender, EventArgs e) //kaydet butonunun kodlar�
        {
            connection.Open(); //connection nesnesini a�ma
            command = new SqlCommand(@"INSERT INTO [dbo].[Tbl_Personel]
           ([PerAd]
           ,[PerSoyad]
           ,[PerSehir]
           ,[PerMaas]
           ,[PerDurum]
           ,[PerMeslek])
     VALUES
           (@perAd
           ,@perSoyad
           ,@perSehir
           ,@perMaas
           ,@perDurum
           ,@perMeslek)", connection);// @ i�areti parametre oldu�unu belirliyor


            command.Parameters.AddWithValue("@perAd", PerAd.Text);// command nesnesine de�er ekle 
            command.Parameters.AddWithValue("@perSoyad", PerSoyad.Text);
            command.Parameters.AddWithValue("@perSehir", comboBox1.Text);
            command.Parameters.AddWithValue("@perMaas", PerMaas.Text);
            command.Parameters.AddWithValue("@perDurum", radioButton1.Checked);
            command.Parameters.AddWithValue("@perMeslek", PerMeslek.Text);
            command.ExecuteNonQuery(); //komut listesini �al��t�rmak i�in
            connection.Close(); //connection nesnesini kapama

            MessageBox.Show("Personel Ba�ar�l� Bir �ekilde Kaydedildi.");
            PersonelGetir();
            ClearText();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new SqlCommand(@"DELETE FROM [dbo].[Tbl_Personel] WHERE PerId=@PerId", connection);
            command.Parameters.AddWithValue("PerId", PerId.Text);
            command.ExecuteNonQuery();
            connection.Close();
            PerId.Text = "";
            MessageBox.Show("Personel Ba�ar�l� Bir �ekilde Silindi.");
            PersonelGetir();
            ClearText();
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new SqlCommand(@"UPDATE [dbo].[Tbl_Personel]
   SET [PerAd] = @perAd
      ,[PerSoyad] = @perSoyad
      ,[PerSehir] = @perSehir
      ,[PerMaas] = @perMaas
      ,[PerDurum] = @perDurum
      ,[PerMeslek] = @perMeslek
 WHERE PerId = @perId", connection);
            command.Parameters.AddWithValue("@perId", PerId.Text);
            command.Parameters.AddWithValue("@perAd", PerAd.Text);
            command.Parameters.AddWithValue("@perSoyad", PerSoyad.Text);
            command.Parameters.AddWithValue("@perSehir", comboBox1.Text);
            command.Parameters.AddWithValue("@perMaas", PerMaas.Text);
            command.Parameters.AddWithValue("@perDurum", radioButton1.Checked);
            command.Parameters.AddWithValue("@perMeslek", PerMeslek.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Personel Ba�ar�l� Bir �ekilde G�ncellendi.");
            PersonelGetir();
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearText();
        }




        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            PerId.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            PerAd.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            PerSoyad.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            PerMaas.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            label7.Text = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            PerMeslek.Text = dataGridView1.Rows[secim].Cells[6].Value.ToString();


        }

        private void label7_TextChanged(object sender, EventArgs e)
        {
            if (label7.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label7.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label7.Text = "True";
            }

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label7.Text = "False";
            }
        }


    }
}