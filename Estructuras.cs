using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SistAlmacenamientoProfeJheyson
{
    
    public class Nodo
    {
        public string NombreDestinatario { get; set; }
        public string Telefono { get; set; }
        public string Tamaño { get; set; }
        public string DNI { get; set; }
        public string FechaIngreso { get; set; }
        public Nodo Siguiente { get; set; }
        public string Casillero { get; set; }
    }

    
    public class ColaPaquetes
    {
        private Nodo frente;
        private Nodo fin;

        public ColaPaquetes()
        {
            frente = null;
            fin = null;
            CargarPendientesDesdeBD(); 
        }

        
        private void EncolarSoloMemoria(string nombre, string telefono, string tamaño, string dni, string fecha, string casillero)
        {
            Nodo nuevo = new Nodo
            {
                NombreDestinatario = nombre,
                Telefono = telefono,
                Tamaño = tamaño,
                DNI = dni,
                FechaIngreso = fecha,
                Casillero = casillero,
                Siguiente = null
            };

            if (frente == null)
                frente = fin = nuevo;
            else
            {
                fin.Siguiente = nuevo;
                fin = nuevo;
            }
        }

        
        public void Encolar(string nombre, string telefono, string tamaño, string dni, string fecha, string casillero)
        {
            
            EncolarSoloMemoria(nombre, telefono, tamaño, dni, fecha, casillero);

            
            try
            {
                using (var cn = new SQLiteConnection(BDHelper.CadenaConexion))
                {
                    cn.Open();
                    string sql = @"INSERT INTO paquetes 
                               (nombre, telefono, tamano, fecha_ingreso, estado, casillero)
                               VALUES (@n, @t, @tam, @f, 'Pendiente', @casi);";
                    using (var cmd = new SQLiteCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@n", nombre);
                        cmd.Parameters.AddWithValue("@t", telefono);
                        cmd.Parameters.AddWithValue("@tam", tamaño + " - DNI:" + dni);
                        cmd.Parameters.AddWithValue("@f", fecha);
                        cmd.Parameters.AddWithValue("@casi", casillero);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al guardar paquete en BD:\n" + ex.Message);
            }
        }

        
        public Nodo Desencolar()
        {
            if (frente == null)
                return null;

            Nodo tmp = frente;
            frente = frente.Siguiente;
            if (frente == null)
                fin = null;

            try
            {
                using (var cn = new SQLiteConnection(BDHelper.CadenaConexion))
                {
                    cn.Open();
                    string sql = @"UPDATE paquetes 
                               SET estado='Entregado' 
                               WHERE nombre=@n AND telefono=@t AND fecha_ingreso=@f AND estado='Pendiente';";


                    using (var cmd = new SQLiteCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@n", tmp.NombreDestinatario);
                        cmd.Parameters.AddWithValue("@t", tmp.Telefono);
                        cmd.Parameters.AddWithValue("@f", tmp.FechaIngreso);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al actualizar estado en BD:\n" + ex.Message);
            }

            return tmp;
        }

        #region
        public void MostrarEnGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.Columns.Add("colNombre", "Nombre");
            dgv.Columns.Add("colTelefono", "Teléfono");
            dgv.Columns.Add("colTamano", "Tamaño");
            dgv.Columns.Add("colFecha", "Fecha Ingreso");
            dgv.Columns.Add("colEstado", "Estado");
            dgv.Columns.Add("colCasillero", "Casillero");

            try
            {
                using (var cn = new SQLiteConnection(BDHelper.CadenaConexion))
                {
                    cn.Open();
                    string sql = @"SELECT nombre, telefono, tamano, fecha_ingreso, estado, casillero
                                   FROM paquetes
                                   ORDER BY id ASC;";
                    using (var cmd = new SQLiteCommand(sql, cn))
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            dgv.Rows.Add(
                               rd["nombre"].ToString(),
                            rd["telefono"].ToString(),
                            rd["tamano"].ToString(),
                            rd["fecha_ingreso"].ToString(),
                            rd["estado"].ToString(),
                            rd["casillero"].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al leer paquetes desde BD:\n" + ex.Message);
            }
        }

        
        private void CargarPendientesDesdeBD()
        {
            try
            {
                using (var cn = new SQLiteConnection(BDHelper.CadenaConexion))
                {
                    cn.Open();
                    string sql = @"SELECT nombre, telefono, tamano, fecha_ingreso, casillero
                                   FROM paquetes 
                                   WHERE estado='Pendiente' 
                                   ORDER BY id ASC;";
                    using (var cmd = new SQLiteCommand(sql, cn))
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            string tamCompleto = rd["tamano"].ToString();
                            string[] partes = tamCompleto.Split(new string[] { " - DNI:" }, StringSplitOptions.None);
                            string tamano = partes[0];
                            string dni = (partes.Length > 1) ? partes[1] : "N/A";

                            EncolarSoloMemoria(
                                rd["nombre"].ToString(),
                            rd["telefono"].ToString(),
                            tamano,
                            dni,
                            rd["fecha_ingreso"].ToString(),
                            rd["casillero"].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al reconstruir cola desde BD:\n" + ex.Message);
            }
        }

        public bool EstaVacia() => frente == null;
    }
    #endregion

    public class PilaHistorial
    {
        private Nodo tope;

        public void Apilar(Nodo paquete)
        {
            paquete.Siguiente = tope;
            tope = paquete;
        }

        public Nodo Desapilar()
        {
            if (tope == null)
                return null;

            Nodo tmp = tope;
            tope = tope.Siguiente;
            return tmp;
        }

        public void MostrarEnGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.Columns.Add("colNombre", "Nombre");
            dgv.Columns.Add("colTelefono", "Teléfono");
            dgv.Columns.Add("colTamano", "Tamaño");
            dgv.Columns.Add("colDNI", "DNI");
            dgv.Columns.Add("colCasi", "Casillero");
            

            Nodo actual = tope;
            while (actual != null)
            {
                dgv.Rows.Add(actual.NombreDestinatario, actual.Telefono, actual.Tamaño, actual.DNI, actual.Casillero);
                actual = actual.Siguiente;
            }
        }

        public bool EstaVacia() => tope == null;
    }

    
    public class ListaHistorial
    {
        private Nodo cabeza;

        
        public void Agregar(Nodo paquete)
        {
            if (paquete == null) return;
            paquete.Siguiente = null; 

            if (cabeza == null)
            {
                cabeza = paquete;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = paquete;
            }
        }

        public void InsertarFinal(string nombre, string telefono, string tamaño, string dni, string fecha)
        {
            Nodo nuevo = new Nodo
            {
                NombreDestinatario = nombre,
                Telefono = telefono,
                Tamaño = tamaño,
                DNI = dni,
                FechaIngreso = fecha,
                Siguiente = null
            };

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        
        public void MostrarEnGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.Columns.Add("colNombre", "Nombre");
            dgv.Columns.Add("colTelefono", "Teléfono");
            dgv.Columns.Add("colTamaño", "Tamaño");
            dgv.Columns.Add("colDNI", "DNI");
            dgv.Columns.Add("colFecha", "Fecha");
            dgv.Columns.Add("colCasi", "Casillero");

            Nodo actual = cabeza;
            while (actual != null)
            {
                dgv.Rows.Add(actual.NombreDestinatario, actual.Telefono, actual.Tamaño, actual.DNI, actual.FechaIngreso);
                actual = actual.Siguiente;
            }
        }

        public bool EstaVacia() => cabeza == null;
    }
}

