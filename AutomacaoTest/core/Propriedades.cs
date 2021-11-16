using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoTest.core
{
    public class Propriedades
    {
        public static Boolean FECHAR_BROWSER = false;
        public static Navegador browser = Navegador.CHROME;

    }

    public enum Navegador {
        CHROME, FIREFOX, IE
    }
}
