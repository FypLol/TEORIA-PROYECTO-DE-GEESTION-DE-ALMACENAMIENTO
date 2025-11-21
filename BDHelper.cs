using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;


namespace SistAlmacenamientoProfeJheyson
{
    public static class BDHelper
    {
        
        public static string RutaBD = "sistema.db";
        public static string CadenaConexion => $"Data Source={RutaBD};Version=3;";


        public static void Inicializar()
        {
            try
            {
                
                if (!File.Exists(RutaBD))
                    SQLiteConnection.CreateFile(RutaBD);

                using (var cn = new SQLiteConnection(CadenaConexion))
                {
                    cn.Open();

                   
                    string sqlUsuarios = @"
                    CREATE TABLE IF NOT EXISTS usuarios (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        usuario TEXT NOT NULL,
                        contrasena TEXT NOT NULL

                    );";
                    new SQLiteCommand(sqlUsuarios, cn).ExecuteNonQuery();

                    
                    string check = "SELECT COUNT(*) FROM usuarios WHERE usuario='admin';";
                    int existeAdmin = Convert.ToInt32(new SQLiteCommand(check, cn).ExecuteScalar());
                    if (existeAdmin == 0)
                    {
                        string insertAdmin = "INSERT INTO usuarios(usuario, contrasena) VALUES('admin','1234');";
                        new SQLiteCommand(insertAdmin, cn).ExecuteNonQuery();
                    }

                    
                    string sqlPaquetes = @"
                        CREATE TABLE IF NOT EXISTS paquetes (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            nombre TEXT NOT NULL,
                            telefono TEXT NOT NULL,
                            tamano TEXT NOT NULL,
                            fecha_ingreso TEXT NOT NULL,
                            estado TEXT NOT NULL,
                            casillero TEXT NOT NULL
                        );";
                    new SQLiteCommand(sqlPaquetes, cn).ExecuteNonQuery();
                }

                Console.WriteLine("Base de datos inicializada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar la base de datos:\n" + ex.Message,
                                "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}