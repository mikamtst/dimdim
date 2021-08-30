using DimDim.Context;
using DimDim.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DimDim.Controllers
{
    [Route("api/cliente/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly CrudContexto _crudContexto;

        public ClienteController(CrudContexto crud)
        {
            _crudContexto = crud;
        }

        [HttpPost]
        public void Post([FromBody] Cliente cliente)
        {
            _crudContexto.Cliente.Add(cliente);
            _crudContexto.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cliente cliente)
        {
            cliente.ClienteId = id;
            _crudContexto.Cliente.Update(cliente);
            _crudContexto.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _crudContexto.Cliente.FirstOrDefault(x => x.ClienteId == id);
            if (item != null)
            {
                _crudContexto.Cliente.Remove(item);
                _crudContexto.SaveChanges();
            }

        }
    }
}
