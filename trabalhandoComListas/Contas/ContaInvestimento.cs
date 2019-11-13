﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Banco.Contas;

namespace Array
{
    class ContaInvestimento : Conta, ITributavel
    {
        public override void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }
        public override void Saca(double valor)
        {
            this.Saldo -= (valor + 0.10);
        }
        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }
    }
}
