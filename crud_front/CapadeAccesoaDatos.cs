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
                firstName.ParameterName = "@FirstName";
                firstName.Value = Contact.FirstName;
                firstName.DbType = System.Data.DbType.String;

                #endregion

                #region FORMA CORTA DE AÑADIR PARÁMETROS

                SqlParameter lastName = new SqlParameter("@LastName", Contact.LastName);
                SqlParameter phone = new SqlParameter("@phone", Contact.Phone);
                SqlParameter address = new SqlParameter("@address", Contact.Address);

                #endregion
                                                   //Le pasamos el comando y la conexión
                SqlCommand command = new SqlCommand(query,conn);

                command.Parameters.Add(firstName);
                command.Parameters.Add(lastName);
                command.Parameters.Add(phone);
                command.Parameters.Add(address);

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

        public List<Contacto> tenerContacts(){

            List<Contacto> Contact = new List<Contacto>();

            try{
                conn.Open();
                string query = @"SELECT Id, FirstName, LastName, Phone, Address FROM users";
                SqlCommand command = new SqlCommand(query,conn);



                /*El "ExecuteReader" retorna un DataReader que posee todas la filas
                que cumplen con los requisitos de nuestra consulta. En este caso todas
                las filas poseen las culumnas indicadas en la consulta por lo que nos
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

    }

}
