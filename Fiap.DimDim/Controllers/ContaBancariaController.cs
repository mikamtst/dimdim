using Fiap.DimDim.Context;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.DimDim.Controllers
{
    public class ContaBancariaController : Controller
    {
        private readonly CrudContexto _crudContexto;

        public ContaBancariaController(CrudContexto crud)
        {
            _crudContexto = crud;
        }

        [HttpGet]
        public IActionResult CadastrarConta()
        {
            return View();
        }
    }
}
