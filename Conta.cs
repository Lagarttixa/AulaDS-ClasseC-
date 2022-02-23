using System;

namespace AulaO1
{
    public class Conta
    {
        private int numero;
        private double saldo;
        private double limite;
        private string nome;
        public void saca(double valor)
        {
            saldo = saldo - valor;
        }

        public void deposita(double valor)
        {
            saldo = saldo + valor;
        }


        public void transfere(Conta destino, double valor)
        {
            saldo = saldo - valor;
        }
    }

}