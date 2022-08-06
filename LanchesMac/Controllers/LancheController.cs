 using LanchesMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        //Acessa a instância do respositório (indo no banco de dados retornando os valores)
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            //ATENÇÃO! É OBRIGATÓRIO CRIAR UM ARQUIVO list.html , para retornar a view ao usuário!


            //Retorna uma lista de lanches
            var lanches = _lancheRepository.Lanches;
            return View(lanches);
        }
    }
}
