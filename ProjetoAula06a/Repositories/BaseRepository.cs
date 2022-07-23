using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula06a.Repositories
{
    /// <summary>
    /// Classe abstratta para operações de repositório de dados
    /// </summary>
    public abstract class BaseRepository<T>
    {
        public abstract void Exportar(T obj);
    }
}
