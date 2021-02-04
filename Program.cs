using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 ------------------------------------------------
 Desenvolvido por...: Edson de Araujo
 Finalidade.........: Sistema Cadastro
 Criado em Data.....: 26/01/2021
 Ultima Atualização : 26/01/2021 

 DEUS SEJA LOUVADO
 ------------------------------------------------
*/

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
