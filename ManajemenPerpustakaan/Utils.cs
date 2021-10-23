using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ManajemenPerpustakaan
{
    class Utils
    {
        SqlConnection _connection;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;
        SqlCommand command;

        public bool OpenConnection()
        {
            if (_connection != null)
            {
                try
                {
                    if (_connection.State == ConnectionState.Open) _connection.Close();
                    _connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            return false;
        }

        public bool CloseConnection()
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public SqlConnection InitConnection(string urlConnection)
        {
            try
            {
                _connection = new SqlConnection(urlConnection);
                return _connection;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                if (_connection != null) _connection.Close();
            }
        }

        public Utils(string urlConnection)
        {
            InitConnection(urlConnection);
        }

        public void create(string query)
        {
            if (OpenConnection() == true)
            {
                try
                {
                    command = new SqlCommand(query, _connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

        public void update(string query)
        {
            if (OpenConnection() == true)
            {
                try
                {
                    command = new SqlCommand(query, _connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Diperbarui", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

        public void delete(string query)
        {
            if (OpenConnection() == true)
            {
                try
                {
                    command = new SqlCommand(query, _connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

        public void readToDataGrid(string query, DataGridView dgv)
        {
            if (OpenConnection() == true)
            {
                try
                {
                    command = new SqlCommand(query, _connection);
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgv.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

        public void setCombobox(string sql, ComboBox cb, string valueString, string displayString)
        {
            DataTable dtz = new DataTable();
            dtz = readToDataTable(sql);
            cb.DataSource = dtz;
            cb.DisplayMember = displayString;
            cb.ValueMember = valueString;
        }

        public DataTable readToDataTable(string query)
        {
            if (OpenConnection() == true)
            {
                try
                {
                    command = new SqlCommand(query, _connection);
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    CloseConnection();
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public SqlDataReader sqlDataReader(string query)
        {
            if(OpenConnection() == true)
            {
                try
                {
                    command = new SqlCommand(query, _connection);
                    SqlDataReader reader;
                    reader = command.ExecuteReader();
                    reader.Read();
                    
                    return reader;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    CloseConnection();
                }
            }
            else
            {
                return null;
            }
        }

        public void query(string query)
        {
            if (OpenConnection() == true)
            {
                try
                {
                    command = new SqlCommand(query, _connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

        public void MsgInfo(string msg)
        {
            MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MsgWarn(string msg)
        {
            MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
       public void MsgQuestion(string msg)
       {
            MessageBox.Show(msg, "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
