using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToFile.ConsoleApp
{
    public class TextToFileCustom
    {
        public  void WriteTxt(string cadena, string archivoPath )
        {

            var stream = new StreamWriter(archivoPath, true);

            stream.AutoFlush = true;

            try
            {
                stream.WriteLine(cadena);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
            finally
            {
                stream.Close();
            }

        }
    }
}
