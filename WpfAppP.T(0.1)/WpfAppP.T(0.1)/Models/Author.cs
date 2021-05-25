using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppP.T_0._1_
{
    public partial class Author
    {
        public string FullName
        {
            get
            {
                return $"{Surname} {Name} {(string.IsNullOrWhiteSpace(Patronymic) ? "" : Patronymic)}";
            }
        }
    }
}
