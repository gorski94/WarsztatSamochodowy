using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabele
{
    public class Uzytkownicy
    {
       
          //  private int idUzytkownika=1;
            private string login="Szefo";
            private string haslo="";
            private string typ="";

            //public int IdUzytkownika
            //{
            //    get
            //    {
            //        return idUzytkownika;
            //    }

            //    set
            //    {
            //        idUzytkownika = value;
            //    }
            //}

            public string Login
            {
                get
                {
                    return login;
                }

                set
                {
                    login = value;
                }
            }

            public string Haslo
            {
                get
                {
                    return haslo;
                }

                set
                {
                    haslo = value;
                }
            }

            public string Typ
            {
                get
                {
                    return typ;
                }

                set
                {
                    typ = value;
                }
            }
        }
    }

