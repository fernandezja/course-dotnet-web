using TextToFile.ConsoleApp;

namespace TextToFile.ConsoleAppTests
{
    public class TextToFileCustomTest
    {
        [Fact]
        public void WriteTxt_Simple()
        {
            var textToFileCustom = new TextToFileCustom();
            var archivoPath = "starwars-phrases-tests.txt";

            textToFileCustom.WriteTxt("The Force is strong with you! (Tests)",
                                    archivoPath);

           Assert.True(File.Exists(archivoPath));
        }
    }
}