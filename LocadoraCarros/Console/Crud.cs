using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace ViewConsole
{
    public delegate void Operations();
    public class Crud
    {
        protected List<BaseModel> lista = new List<BaseModel>();
        protected Operations createOperation;
        protected Operations readOperation;
        protected Operations updateOperation;
        protected Operations deleteOperation;
        public void Create()
        {
            createOperation();
        }
        public void Read()
        {
            readOperation();
        }
        public void Update()
        {
            updateOperation();
        }
        public void Delete()
        {
            deleteOperation();
        }

        protected void PausarImpressao()
        {
            Console.WriteLine("Precione qualquer tecla para continuar.....");
            Console.ReadLine();
        }
    }
}
