﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrnNHibernate.Api.Core.Requests
{
    public class ProdutoRequest
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int QuantidadeEstoque { get; set; }


    }
}
