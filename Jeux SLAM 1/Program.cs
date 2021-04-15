using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux_SLAM_1
{
    // Classe Personnage: //
    public class Personnage
    {
        protected String pseudo;
        protected String sexe;
        protected int pv;
        protected int mana;
        protected int defence;
        protected int attack;
        protected int niveau;
        protected int xp;

        // Constructeur Personnage: //
        public Personnage(String pseudo, String sexe)
        {
            this.pseudo = pseudo;
            this.sexe = sexe;
            this.pv = 200;
            this.mana = 100;
            this.defence = 2;
            this.attack = 5;
            this.niveau = 1;
            this.xp = 0;
        }

        // Méthode de dommage reçu: //
        public void Damage(int damage)
        {
            this.pv = pv - damage;
        }

        // Méthode d'attaque: //

        public String GetPseudo()
        {
            return pseudo;
        }

        public String GetSexe()
        {
            return sexe;
        }

        public int GetPv()
        {
            return pv;
        }

        public int GetMana()
        {
            return mana;
        }

        public int GetDefence()
        {
            return defence;
        }

        public int GetForce()
        {
            return force;
        }

        public int GetNiveau()
        {
            return niveau;
        }

        public int GetXp()
        {
            return xp;
        }
    }

    //----------------------------------- Heros -----------------------------------------//
    // Classe Tank héritant de Personnage: //
    public class Tank : Personnage
    {
        public Tank(String pseudo, String sexe) : base(pseudo, sexe)
        {
            this.pv = pv * 5;
        }
    }

    // Classe Archer héritant de Personnage: //
    public class Archer : Personnage
    {
        public Archer(String pseudo, String sexe) : base(pseudo, sexe)
        {
            this.pv = pv * 2;
            this.force = force * 2;
        }
    }

    // Classe Mage héritant de Personnage: //
    public class Mage : Personnage
    {
        public Mage(String pseudo, String sexe) : base(pseudo, sexe)
        {
            this.force = force * 5;
        }
    }

    //---------------------------------- Monstre ---------------------------------------//

    // Classe Golem héritant de Personnage: //
    public class Golem : Personnage
    {
        public Golem(String pseudo, String sexe) : base(pseudo, sexe)
        {
        }
    }

    // Classe Goblin héritant de Personnage: //
    public class Goblin : Personnage
    {
        public Goblin(String pseudo, String sexe) : base(pseudo, sexe)
        {
        }
    }

    // Classe Chaman héritant de Personnage: //
    public class Chaman : Personnage
    {
        public Chaman(String pseudo, String sexe) : base(pseudo, sexe)
        {
        }
    }

    //-------------------------------- Programe --------------------------------------//
    class Program
    {
        static void Main(string[] args)
        {
            String sonNom1;
            String sonSexe1;
            Personnage seb = new Personnage("Seb", "F");
            Tank tank = new Tank("Anas", "M");
            Tank anas = tank;
            Console.WriteLine("seb : {0}", seb.GetPv());
            Console.WriteLine("anas : {0}", anas.GetPv());
            Console.WriteLine("Saisissez Votre nouveau pseudo : ");
            sonNom1 = Console.ReadLine();
            Console.WriteLine("  H.Votre Personnage est un homme !        F.Votre Personnage est une femme");
            sonSexe1 = Console.ReadLine();
            Archer valentino = new Archer(sonNom1, sonSexe1);
            Console.WriteLine("Bonjour {0}", sonNom1);   
            Console.ReadKey();
        }
    }
}
