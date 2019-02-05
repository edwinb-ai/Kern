//
// Translated by CS2J (http://www.cs2j.com): 2/4/2019 9:18:40 PM
//

package ProcesadorImagenes;

import ProcesadorImagenes.Main;
import ProcesadorImagenes.Program;

public class Program   
{
    /**
    * The main entry point for the application.
    */
    public static void main(String[] args) throws Exception {
        Program.Main();
    }

    static void Main() throws Exception {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Main());
    }

}


