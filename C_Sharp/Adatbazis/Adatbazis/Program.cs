using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using MySql.Data.MySqlClient;

namespace Adatbazis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Select();
        }

        /// <summary>
        /// Lekérdezés (olvasás) adatbázisból - SELECT
        /// </summary>
        public static void Select()
        {
            /* Adatbázis útvonal megadása */
            string connectionString = "SERVER=\"127.0.0.1\"; DATABASE=\"beer\"; UID=\"root\"; PASSWORD=\"\"; PORT=\"3306\"; SslMode=None;";

            /* Létrehozok egy MySQL kapcsolatot és megadom neki az útvonalat */
            MySqlConnection connection = new MySqlConnection(connectionString);

            /* Megnyitom a kapcsolatot */
            connection.Open();

            /* Lekérdezést megadunk */
            string selectCommand = "SELECT products.ID, products.Brand, products.Alcohol, products.Price, manufacturer.Name FROM products, manufacturer WHERE products.ManufacturerID = manufacturer.ID ORDER BY products.ID ASC";

            /* Létrehozunk egy MySQL lekérdezés végrehajtó példányt és átadjuk neki a parancsot */
            MySqlCommand command = new MySqlCommand(selectCommand, connection);

            /* Parancs alapján a dataadapter feltölt egy adott adatszerkezetet */
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            /* Lezároma a kapcsolatot */
            connection.Close();


            /* Kiírom konzolra a dataadapter által feltöltött datatable */
            foreach (DataRow row in table.Rows)
            {
                Console.Write(row[0] + " ");
                Console.Write(row[1] + " ");
                Console.Write(row[2] + " ");
                Console.Write(row[3] + " ");
                Console.Write(row[4] + "\n");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Beszúrás (írás) adatbázisba - INSERT
        /// </summary>
        public static void Insert()
        {
            /* Adatbázis útvonal megadása */
            string connectionString = "SERVER=\"127.0.0.1\"; DATABASE=\"beer\"; UID=\"root\"; PASSWORD=\"\"; PORT=\"3306\"; SslMode=None;";

            /* Létrehozok egy MySQL kapcsolatot és megadom neki az útvonalat */
            MySqlConnection connection = new MySqlConnection(connectionString);

            /* Megnyitom a kapcsolatot */
            connection.Open();

            /* Beszúrást megadunk */
            string insertCommand = "INSERT INTO products (Brand, Alcohol, Price, ManufacturerID) VALUES (@Brand, @Alcohol, @Price, @ManufacturerID)";

            /* Létrehozunk egy MySQL beszúrást végrehajtó példányt és átadjuk neki a parancsot */
            MySqlCommand command = new MySqlCommand(insertCommand, connection);

            /* Paraméterezett beszúrás (paraméterek 9összekötése konrkét adatokkal) */
            command.Prepare();
            command.Parameters.AddWithValue("@Brand", "Faxxe");
            command.Parameters.AddWithValue("@Alcohol", 6.7);
            command.Parameters.AddWithValue("@Price", 130);
            command.Parameters.AddWithValue("@ManufacturerID", 4);
            command.ExecuteNonQuery();

            /* Lezároma a kapcsolatot */
            connection.Close();

            Console.ReadKey();
        }

        /// <summary>
        /// Törlést (írás) adatbázisból - DELETE
        /// </summary>
        public static void Delete()
        {
            /* Adatbázis útvonal megadása */
            string connectionString = "SERVER=\"127.0.0.1\"; DATABASE=\"beer\"; UID=\"root\"; PASSWORD=\"\"; PORT=\"3306\"; SslMode=None;";

            /* Létrehozok egy MySQL kapcsolatot és megadom neki az útvonalat */
            MySqlConnection connection = new MySqlConnection(connectionString);

            /* Megnyitom a kapcsolatot */
            connection.Open();

            /* Törlést megadunk */
            string deleteCommand = "DELETE FROM products WHERE ID = @ID";

            /* Létrehozunk egy MySQL törlést végrehajtó példányt és átadjuk neki a parancsot */
            MySqlCommand command = new MySqlCommand(deleteCommand, connection);

            /* Paraméterezett törlést (paraméterek összekötése konrkét adatokkal) */
            command.Prepare();
            command.Parameters.AddWithValue("@ID", 19);
            command.ExecuteNonQuery();

            /* Lezároma a kapcsolatot */
            connection.Close();

            Console.ReadKey();
        }

        public static void Update()
        {
            /* Adatbázis útvonal megadása */
            string connectionString = "SERVER=\"127.0.0.1\"; DATABASE=\"beer\"; UID=\"root\"; PASSWORD=\"\"; PORT=\"3306\"; SslMode=None;";

            /* Létrehozok egy MySQL kapcsolatot és megadom neki az útvonalat */
            MySqlConnection connection = new MySqlConnection(connectionString);

            /* Megnyitom a kapcsolatot */
            connection.Open();

            /* Módosítást megadunk */
            string updateCommand = "UPDATE products SET Brand = @Brand WHERE ID = @ID";

            /* Létrehozunk egy MySQL törlést végrehajtó példányt és átadjuk neki a parancsot */
            MySqlCommand command = new MySqlCommand(updateCommand, connection);

            /* Paraméterezett törlést (paraméterek összekötése konrkét adatokkal) */
            command.Prepare();
            command.Parameters.AddWithValue("@Brand", "Faxxe");
            command.Parameters.AddWithValue("@ID", 16);
            command.ExecuteNonQuery();

            /* Lezároma a kapcsolatot */
            connection.Close();

            Console.ReadKey();
        }
    }
}
