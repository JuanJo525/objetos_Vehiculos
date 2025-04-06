using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos_Vehiculos
{
    public class Cls_vehiculo
    {

        public string Matricula { get; set; }
        public string Modelo { get; set; }
        public int PotenciaCV { get; set; }

        public Cls_vehiculo(string matricula, string modelo, int potencia)
        {
            Matricula = matricula;
            Modelo = modelo;
            PotenciaCV = potencia;
        }

        public string GetMatricula()
        {
            return Matricula;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public int GetPotencia()
        {
            return PotenciaCV;
        }
    }

    public class ClsTaxi : Cls_vehiculo
    {
        public string numLicencia { get; set; }

        public string getLicencia()
        {
            return numLicencia;
        }

        public ClsTaxi(string matricula, string modelo, int potencia) : base(matricula, modelo, potencia)
        {
            //
        }

        public void setLicencia(string licencia)
        {
            numLicencia = licencia;
        }
    }


    public class ClsAutobus : Cls_vehiculo
    {
        public int numPlazas { get; set; }

        public ClsAutobus(string matricula, string modelo, int potencia) : base(matricula, modelo, potencia)
        {

        }

        public int getPlazas()
        {
            return numPlazas;
        }

        public void setPlazas(int plazas)
        {
            numPlazas = plazas;

        }
    }
}


