using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotebookAndHook.Models
{
    public class Notebook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int MaxNumberOfPages { get; set; }
        public Gender Gender { get; set; }
        public Size Size { get; set; }
        public List<Hook> OwnedHooks { get; set; } = new List<Hook>();
    }
}
