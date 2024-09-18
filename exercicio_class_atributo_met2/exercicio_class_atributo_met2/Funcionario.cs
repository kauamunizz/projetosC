using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_class_atributo_met2 {
    internal class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() { 
            return SalarioBruto - Imposto;
        }
        public void Aumentarsalario(double porcentagem) {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString() {
            return "Funcionario: " + Nome + ", R$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
            ;
        }
    }
}
