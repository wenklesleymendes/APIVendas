﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Core.Enumeradores
{
    public enum EnumStatus
    {
        AguardandoPagamento,
        Pagamentoaprovado,
        EnviadoparaTransportadora,
        Entregue,
        Cancelada
    }
}
