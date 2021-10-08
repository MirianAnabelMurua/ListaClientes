using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace operacionesBancarias.dominio
{
    class Cliente : IComparable<Cliente>
    {
        // Atributos para datos
        private String primerNombre;
        private String apellido;
        // Atributos para la agregación
        private List<Cuenta> cuentas;
        private int numeroDeCuentas = 0;

        public Cliente(String p, String a)
        {
            primerNombre = p;
            apellido = a;
            cuentas = new List<Cuenta>();
        }

        public void AgregaCuenta(Cuenta cta)
        {
            cuentas.Add(cta);
            numeroDeCuentas = cuentas.Count;
        }
        public Cuenta GetCuenta(int indiceCuenta)
        {
            return cuentas[indiceCuenta];
        }

        public String PrimerNombre
        {
            get
            {
                return primerNombre;
            }
        }
        public String Apellido
        {
            get
            {
                return apellido;
            }
        }
        public int NumeroDeCuentas
        {
            get
            {
                return numeroDeCuentas;
            }
        }

        public int CompareTo(Cliente obj)
        {
            if (obj == null) return 1;
            int aux = apellido.CompareTo(obj.apellido);
            if (aux != 0) return aux;
            aux = primerNombre.CompareTo(obj.primerNombre);
            if (aux != 0) return aux;
            return 0;
        }
    }
}
