using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ESNAJ
{
    class Excel
    {
        //Regresa una lista con los datos de los jugadores que se deben actualizar
        public static List<Jugador> infoActualizar(String nomArchivo)
        {
            List<Jugador> resp = new List<Jugador>();
            FileStream archivo = new FileStream(nomArchivo + ".xls", FileMode.Open, FileAccess.Read);
            HSSFWorkbook libro = new HSSFWorkbook(archivo);
            ISheet hoja = libro.GetSheetAt(0);
            IRow fila;
            ICell celda;
            int id = 0, puntos = 0;
            String nombre = "", trofeo = "", escuela = "", categoria = "", torneo = "";

            //Obtener categoria
            fila = hoja.GetRow(0);
            celda = fila.GetCell(0);
            categoria = celda.StringCellValue;
            //Obtener torneo
            fila = hoja.GetRow(1);
            celda = fila.GetCell(0);
            torneo = celda.StringCellValue;
            
            for (int i = 2; i < hoja.LastRowNum; i++)
            {   
                Jugador j;
                fila = hoja.GetRow(i);

                //Ver si el ID existe
                celda = fila.GetCell(0);
                if (celda != null && celda.CellType == CellType.Numeric)
                    id = (int) celda.NumericCellValue;
                else
                    id = 0;

                //SIEMPRE habrá datos en esta columna (puntos)
                celda = fila.GetCell(1);
                puntos = (int) celda.NumericCellValue;

                //Verificar trofeos
                celda = fila.GetCell(2);
                if (celda != null && celda.CellType != CellType.Blank)
                    trofeo = celda.StringCellValue;
                else
                    trofeo = "";

                //Verificar escuela
                celda = fila.GetCell(3);
                if (celda != null && celda.CellType != CellType.Blank)
                    escuela = celda.StringCellValue;
                else
                    escuela = "";

                //SIEMPRE habrá datos en esta columna (puntos)
                celda = fila.GetCell(4);
                nombre = celda.StringCellValue;

                j = new Jugador(id, puntos, escuela, nombre, trofeo, categoria, torneo);
                resp.Add(j);
            }
            MessageBox.Show("Se leyó correctamente");
            return resp;
        }

        public static List<Escuela> getEscuelas(String nomArchivo)
        {
            List<Escuela> resp = new List<Escuela>();
            FileStream archivo = new FileStream(nomArchivo + ".xls", FileMode.Open, FileAccess.Read);
            HSSFWorkbook libro = new HSSFWorkbook(archivo);
            ISheet hoja = libro.GetSheetAt(0);
            IRow fila;
            ICell celda;
            int id = 0;
            String nombre = "";

            for (int i = 1; i < hoja.LastRowNum; i++)
            {
                Escuela e;

                fila = hoja.GetRow(i);
                celda = fila.GetCell(0);
                id = (int) celda.NumericCellValue;
                celda = fila.GetCell(1);
                nombre = celda.StringCellValue;
                e = new Escuela(id, nombre);
                resp.Add(e);
            }
            return resp;
        }

        public static List<Jugador> inscritosCargaAutomatica(String nomArchivo)
        {
            List<Jugador> resp = new List<Jugador>();
            FileStream archivo = new FileStream(nomArchivo + ".xls", FileMode.Open, FileAccess.Read);
            HSSFWorkbook libro = new HSSFWorkbook(archivo);
            ISheet hoja = libro.GetSheetAt(0);
            IRow fila;
            ICell celda;
            int id = 0;
            String cat = "", nombre = "", escuela = "";

            for (int i = 2; i < hoja.LastRowNum; i++)
            {
                Jugador j;

                fila = hoja.GetRow(i);
                celda = fila.GetCell(0);
                if (celda != null && celda.CellType == CellType.Numeric)
                    id = (int) celda.NumericCellValue;
                else
                    id = 0;

                //SIEMPRE se manda una categoria
                celda = fila.GetCell(1);
                cat = celda.StringCellValue;

                celda = fila.GetCell(2);
                if (celda != null && celda.CellType != CellType.Blank)
                    nombre = celda.StringCellValue;
                else
                    nombre = "";

                //Verificar escuela
                celda = fila.GetCell(3);
                if (celda != null && celda.CellType != CellType.Blank)
                    escuela = celda.StringCellValue;
                else
                    escuela = "";

                j = new Jugador(id, cat, nombre, escuela);
                resp.Add(j);
            }
            return resp;
        }
    }
}
