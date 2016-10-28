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
            FileStream archivo = new FileStream(nomArchivo, FileMode.Open, FileAccess.Read);
            HSSFWorkbook libro = new HSSFWorkbook(archivo);
            ISheet hoja = libro.GetSheetAt(0);
            IRow fila;
            ICell celda;
            int id = 0, escuela = 0, pos = 0, torneo = 0;
            double puntos = 0;
            String nombre = "", categoria = "";

            //Obtener categoria
            fila = hoja.GetRow(0);
            celda = fila.GetCell(0);
            categoria = celda.StringCellValue;
            //Obtener torneo
            fila = hoja.GetRow(1);
            celda = fila.GetCell(0);
            torneo = (int)celda.NumericCellValue;

            for (int i = 2; i <= hoja.LastRowNum; i++)
            {
                Jugador j;
                fila = hoja.GetRow(i);

                //Ver si el ID existe
                celda = fila.GetCell(0);
                if (celda != null && celda.CellType == CellType.Numeric)
                    id = (int)celda.NumericCellValue;
                else
                    id = 0;

                //SIEMPRE habrá datos en esta columna (puntos)
                celda = fila.GetCell(1);
                puntos = (int)celda.NumericCellValue;

                //Verificar posicion
                celda = fila.GetCell(2);
                pos = (int)celda.NumericCellValue;

                //Verificar escuela
                celda = fila.GetCell(3);
                if (celda != null && celda.CellType != CellType.Numeric)
                    escuela = (int)celda.NumericCellValue;
                else
                    escuela = 0;

                //SIEMPRE habrá datos en esta columna (nombre)
                celda = fila.GetCell(4);
                nombre = celda.StringCellValue;

                j = new Jugador(id, categoria, nombre, puntos, escuela, torneo, pos);
                resp.Add(j);
            }
            return resp;
        }

        public static List<Jugador> altaInicial(String nomArchivo)
        {
            List<Jugador> resp = new List<Jugador>();
            FileStream archivo = new FileStream(nomArchivo, FileMode.Open, FileAccess.Read);
            HSSFWorkbook libro = new HSSFWorkbook(archivo);
            ISheet hoja = libro.GetSheetAt(0);
            IRow fila;
            ICell celda;
            int id = 0;
            int idEscuela = 0;
            double puntos = 0;
            String nombre = "", correo = "", categoria = "", contra = "";

            for (int i = 1; i <= hoja.LastRowNum; i++)
            {
                fila = hoja.GetRow(i);
                celda = fila.GetCell(0);
                id = (int)celda.NumericCellValue;

                celda = fila.GetCell(1);
                nombre = celda.StringCellValue;

                celda = fila.GetCell(2);
                correo = celda.StringCellValue;

                celda = fila.GetCell(3);
                contra = celda.StringCellValue;

                celda = fila.GetCell(4);
                puntos = celda.NumericCellValue;

                celda = fila.GetCell(5);
                categoria = celda.StringCellValue;

                celda = fila.GetCell(6);
                idEscuela = (int)celda.NumericCellValue;
                Jugador j = new Jugador(id, nombre, correo, contra, puntos, idEscuela, categoria);
                resp.Add(j);
            }
            return resp;
        }

        public static List<Escuela> getEscuelas(String nomArchivo)
        {
            List<Escuela> resp = new List<Escuela>();
            FileStream archivo = new FileStream(nomArchivo, FileMode.Open, FileAccess.Read);
            HSSFWorkbook libro = new HSSFWorkbook(archivo);
            ISheet hoja = libro.GetSheetAt(0);
            IRow fila;
            ICell celda;
            int id = 0;
            String nombre = "";

            for (int i = 1; i <= hoja.LastRowNum; i++)
            {
                Escuela e;

                fila = hoja.GetRow(i);
                celda = fila.GetCell(0);
                id = (int)celda.NumericCellValue;
                celda = fila.GetCell(1);
                nombre = celda.StringCellValue;
                e = new Escuela(id, nombre);
                resp.Add(e);
            }
            return resp;
        }
    }
}
