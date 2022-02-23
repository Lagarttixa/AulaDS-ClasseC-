using System;

namespace AulaO1
{
    public class Funcionario
    {
        private string nome;
        private string departamento;
        private double salario;
        private string dataEntrada;
        private string rg;
        private bool estaNaEmpresa;

        public void bonifica(double aumento)
        {
            salario = salario * aumento;
        }

    }




}