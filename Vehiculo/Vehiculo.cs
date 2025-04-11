using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    public class Vehiculo
    {
        private string matricula;
        private string modelo;
        private int potenciaCV;

        public Vehiculo(string matricula, string modelo, int potenciaCV)
        {
            this.matricula = matricula;
            this.modelo = modelo;
            this.potenciaCV = potenciaCV;
        }

        public string getMatricula()
        {
            return matricula;
        }

        public string getModelo()
        {
            return modelo;
        }

        public int getPotenciaCV()
        {
            return potenciaCV;
        }
    }
    public class Taxi : Vehiculo
    {
        private string numeroLicencia;

        public Taxi(string matricula, string modelo, int potenciaCV)
            : base(matricula, modelo, potenciaCV)
        {
        }

        public void setNumeroLicencia(string numeroLicencia)
        {
            this.numeroLicencia = numeroLicencia;
        }

        public string getNumeroLicencia()
        {
            return numeroLicencia;
        }
    }

   
    public class Autobus : Vehiculo
    {
        private int numeroPlazas;

        public Autobus(string matricula, string modelo, int potenciaCV)
            : base(matricula, modelo, potenciaCV)
        {
        }

        public void setNumeroPlazas(int numeroPlazas)
        {
            this.numeroPlazas = numeroPlazas;
        }

        public int getNumeroPlazas()
        {
            return numeroPlazas;
        }
    }
}
