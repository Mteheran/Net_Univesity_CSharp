using System.IO;
using System;

namespace DemoStore.Utilidades
{
    public static class TiendaLog
    {
        public static void GuardarEnLog(string textoLog)
        {
            string ruta = Directory.GetCurrentDirectory() + @"\TiendaLog.Log";

            string contenidoLog = "";
            if(File.Exists(ruta))
            {
                StreamReader sr = new StreamReader(ruta);
                contenidoLog = sr.ReadToEnd();
                sr.Close();
            }
          
            StreamWriter sw = new StreamWriter(ruta);
            sw.WriteLine($"{DateTime.Now} - {textoLog}");
            sw.WriteLine(contenidoLog);
            sw.Close();

        }
    }
}