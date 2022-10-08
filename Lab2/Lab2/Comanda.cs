using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    [AsChoice] //pt a folosi CSharp Choices 
    public static partial class Produs
    {
       // public record Contact(string Nume, string Prenume, string NrTelefon, string Adresa);

        public interface IQuantity{} //interfata marker, artificiala, pt constructii de genu.
        public record Kg(float kg):IQuantity;
        public record Unit(int unit):IQuantity;


    }
}
