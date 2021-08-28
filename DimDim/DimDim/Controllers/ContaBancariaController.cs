using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DimDim.Context;
using DimDim.Models;
using Microsoft.AspNetCore.Mvc;

namespace DimDim.Controllers
{
    public class ContaBancariaController : ControllerBase
    {
        private readonly CrudContexto _crudContexto;

        public ContaBancariaController(CrudContexto contexto)
        {
            _crudContexto = contexto;
        }

        [HttpPost]
        public void Post([FromBody] ContaBancaria contaBancaria)
        {
            _crudContexto.ContaBancaria.Add(contaBancaria);
            _crudContexto.SaveChanges();
        }
    }
}
