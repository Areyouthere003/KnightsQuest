using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knight_s_Quest
{
    internal class Logica
    {
        public static void Logica1()
        {
            bool valid; int opcion, condatq;
            int saludHeroe, estadisticaEnemigo;
            int SaludOrco = 100;
            int saludLich = 250;
            int saludDarkKnight = 280;
            int saludWizard = 300;
            int saludDarkDemonKing = 450;
            Historia historia = new Historia();
            historia.Introduccion();
            historia.PrimerJefe();
            CicloAtaque ciclo = new CicloAtaque();
            Ataques ataques = new Ataques();
            Personajes variable1 = new Personajes();
            Enemigo variable2 = new Enemigo(SaludOrco);
            saludHeroe = variable1.RetornoHeroe();
            //estadisticaEnemigo = variable2.RetornoOrco();
            ciclo.cicloAtaque(saludHeroe, SaludOrco);
            historia.GanaBatalla();
            historia.SegundoJefe();
            ciclo.cicloAtaque(saludHeroe, saludLich);
            historia.GanaBatalla();
            historia.TercerJefe();
            ciclo.cicloAtaque(saludHeroe, saludDarkKnight);
            historia.GanaBatalla();
            historia.CuartoJefe();
            ciclo.cicloAtaque(saludHeroe, saludDarkDemonKing);
            historia.ReyDemonio();
            historia.GanaBatallaFinal();
        }
    }
}
