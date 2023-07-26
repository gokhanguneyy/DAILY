using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAdoNetDemo1
{
    public class Daily
    {
        // veritabanında kolonlarıma karşılık gelen propertyler tanımlıyorum.
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }    
        public string Context { get; set; }  

        // bu özelliklere veritabanından bilgiler gelecek.
    }
}
