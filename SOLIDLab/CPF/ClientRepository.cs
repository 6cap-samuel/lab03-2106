using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using SOLIDLab.CPF;

namespace ConsoleApp1.CPF
{
    /**
     * ClientRepository handles the data access to SQL, abstracts
     * data access from the other layers of the program. Validation
     * has been removed and transfered to a utility class. (SRP)
     */
    class ClientRepository : IRepository<Client>
    {
        public string Add(Client client)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "DBConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENT (NAME, EMAIL CPF, RegisterData) VALUES (@name, @email, @cpf, @dataReg))";

                cmd.Parameters.AddWithValue("name", client.Name);
                cmd.Parameters.AddWithValue("email", client.Email);
                cmd.Parameters.AddWithValue("cpf", client.Cpf);
                cmd.Parameters.AddWithValue("RegisterData", client.DataRegister);

                cn.Open();
                cmd.ExecuteNonQuery();
                return "Client registered successfully !";
            }
        }
    }
}
