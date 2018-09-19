using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotebookAndHook.Models;

namespace NotebookAndHook.DataAccess
{
    public class NotebookStorage
    {
        static List<Notebook> _hutch = new List<Notebook>(); //static = shared across all instances; the hutch holds all of the notebooks


        public void Add(Notebook notebook)
        {
            notebook.Id = _hutch.Any() ? _hutch.Max(n => n.Id) + 1: 1;  // if there is anything in the hutch perform max code, if not, the id should be 1.
        }

        public Notebook GetById(int id)
        {
            return _hutch.First(notebook => notebook.Id == id);
        }
    }
}
