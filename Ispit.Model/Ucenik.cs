using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    public class Ucenik
    {
        #region Members

        private string _ime;
        private string _prezime;
        private DateTime _datumrodjenja;
        private double _prosjek;

        #endregion

        #region Properties

        public string Ime
        {
            get { return _ime; }
            set { _ime = value; }
        }

        public string Prezime
        {
            get { return _prezime; }
            set { _prezime = value; }
        }

        public DateTime Datumrodjenja
        {
            get { return _datumrodjenja; }
            set { _datumrodjenja = value; }
        }

        public double Prosjek
        {
            get { return _prosjek; }
            set { _prosjek = value; }
        }

        #endregion

        #region Methods

        public int Starost()
        {
            return DateTime.Now.Year - _datumrodjenja.Year;
        }

        public string IspisProsjeka()
        {

            if (_prosjek >= 1 && _prosjek <= 1.49) return "nedovoljan";
            else if (_prosjek >= 1.50 && _prosjek <= 2.49) return "dovoljan";
            else if (_prosjek >= 2.50 && _prosjek <= 3.49) return "dobar";
            else if (_prosjek >= 3.50 && _prosjek <= 4.49) return "vrlo dobar";
            else if (_prosjek >= 4.50 && _prosjek <= 5) return "odlican";
            else return "pogresan unos";
            
        }

        public override string ToString()
        {
            var ime = "Ime i prezime: " + _ime + " " + _prezime + ".\n";
            var starost = "Star je " + this.Starost() + " godina.\n";
            var prosjek = "Prosjek ocjena je " + IspisProsjeka() + ".\n";
            return ime + starost + prosjek;
        }



        #endregion
    }
}
