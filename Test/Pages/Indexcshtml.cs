using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Test.Models;

namespace Test.Pages
{
    public class IndexModel : PageModel
    {
        
        public string Name { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Name = "Test do Name";
        }
        public void OnPostSubmit(Cidade cidade)
        {
            var cep = new CEP();
            var nomeCidade = cep.BuscarCidade(cidade);
            this.Name = nomeCidade;
        }
    }
}
