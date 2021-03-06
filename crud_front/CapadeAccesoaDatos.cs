using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_front
{
    public class CapadeAccesoaDatos
    {
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Initial Catalog=clientes;Data Source=DESKTOP-J2E8NJJ");

        public void InsertContact(Contacto Contact){

            try
            {

                #region FORMA ALARGADA DE AÑADIR PARÁMETROS

                conn.Open();  //El @ permite escribir un STRING en varias líneas
                string query = @"INSERT INTO users (FirstName, LastName, Phone, Address)
                                 VALUES (@FirstName, @LastName, @Phone, @Address)";

                SqlParameter firstName = new SqlParameter();
                firstName.ParameterName = "@FirstName"; //Este parámetro/variable posee el valor que se encuentra
                firstName.Value = Contact.FirstName; //en la propiedad FirstName del objeto 'Contact'
                firstName.DbType = System.Data.DbType.String;

                #endregion

                #region FORMA CORTA DE AÑADIR PARÁMETROS

                SqlParameter LastName = new SqlParameter("@LastName", Contact.LastName);
                SqlParameter Phone = new SqlParameter("@phone", Contact.Phone);
                SqlParameter Address = new SqlParameter("@address", Contact.Address);

                #endregion
                                                   //Le pasamos el comando y la conexión
                SqlCommand command = new SqlCommand(query,conn);

                command.Parameters.Add(firstName);
                command.Parameters.Add(LastName);
                command.Parameters.Add(Phone);
                command.Parameters.Add(Address);

                //Nuestro algoritmo solo inserta una fila por lo que "ExecuteNonQuery" devolverá
                //un 1 (uno) en caso de que todo salga bien, y cero si no insertó nada.
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally{
                //Da igual si todo sale bien, siempre hay que cerrar la conexión con DB
                conn.Close();
            }
        
        }

        public List<Contacto> tenerContacts(string searchText = null)
        {

            List<Contacto> Contact = new List<Contacto>();

            try{
                conn.Open();
                string query = @"SELECT Id, FirstName, LastName, Phone, Address FROM users";
                SqlCommand command = new SqlCommand();


                //Cuando searchText no sea ni nulo ni vacio. " ! " indica lo contrario a...
                if (!string.IsNullOrEmpty(searchText)){

                    query += @" WHERE FirstName LIKE @searchText
                               OR LastName LIKE @searchText
                               OR Phone LIKE @searchText
                               OR Address LIKE @searchText";


                    //Los %{contenido}% siginifican "no importa lo que haya adelante o atrás"
                    //Lo que contenga la variable searchText lo inserta en @searchText que es
                    //lenguaje SQL
                    command.Parameters.Add(new SqlParameter("@searchText", $"%{searchText}%"));
                
                }

                command.CommandText = query;
                command.Connection = conn;



                /*El "ExecuteReader" retorna un DataReader que posee todas la filas
                que cumplen con los requisitos de nuestra consulta. En este caso todas
                las filas poseen las columnas indicadas en la consulta por lo que nos
                debería retornar todas las filas.*/
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()){
                
                    Contact.Add(new Contacto{
                        Id= int.Parse(reader["Id"].ToString()),
                        FirstName= reader["FirstName"].ToString(),
                        LastName= reader["LastName"].ToString(),
                        Phone= reader["Phone"].ToString(),
                        Address= reader["Address"].ToString()
                    });
                
                }
            }
            catch (Exception){

                throw;
            }
            finally{
                conn.Close();
            }

            return Contact;
        
        }

        public void ActualizarContact(Contacto Contact){

            try
            {
                conn.Open();
                string query = @"UPDATE users SET 
                                    FirstName = @FirstName, 
                                    LastName = @LastName, 
                                    Phone = @Phone, 
                                    Address = @Address 
                                                  WHERE Id = @Id";

                SqlParameter Id = new SqlParameter("@Id", Contact.Id);
                SqlParameter FirstName = new SqlParameter("@FirstName", Contact.FirstName);
                SqlParameter LastName = new SqlParameter("@LastName", Contact.LastName);
                SqlParameter Phone = new SqlParameter("@phone", Contact.Phone);
                SqlParameter Address = new SqlParameter("@address", Contact.Address);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(Id);
                command.Parameters.Add(FirstName);
                command.Parameters.Add(LastName);
                command.Parameters.Add(Phone);
                command.Parameters.Add(Address);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally{

                conn.Close();

            }

        }

        public void DeleteContact(int Id){

            try
            {
                conn.Open();
                string query = @"DELETE FROM users WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally{

                conn.Close();
            
            }
        
        }

    }

}
