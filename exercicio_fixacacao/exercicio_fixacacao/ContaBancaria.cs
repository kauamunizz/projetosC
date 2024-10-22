using System.Globalization;

namespace exercicio_fixacacao {
    class ContaBancaria {

        public int NumConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numConta, string titular) {
            NumConta = numConta;
            Titular = titular;
            Saldo = 0.0;
        }

        public ContaBancaria(int numConta, string titular, double saldo) : this(numConta, titular) {
            Saldo = saldo;
        }

        public override string ToString() {
            return "Conta "
                + NumConta
                + ", Titular: "
                + Titular
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
