
using GCook.Models;

namespace GCook.ViewModels;

    public class HomeVM
    {
        public Lista<Categoria> Categoria { get; set; }

        public List<Receita> Receitas { get; set; }
    }
