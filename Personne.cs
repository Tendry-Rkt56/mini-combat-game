// using system;
public class Guerrier 
{
    //les choses à declarer dans une classe
    private string Nom;
    private int Attaque;
    private int Defense;
    private int Sante;
    private int Mana;

    //constructeur
    public Guerrier (string nom, int attaque, int defense, int sante, int mana)
    {
        this.Nom = nom;
        this.Attaque = attaque;
        this.Defense  =defense;
        this.Sante = sante;
        this.Mana = mana;
    }

    public Guerrier (string nom,int attaque,int defense,int sante)
    {
        this.Nom = nom;
        this.Attaque = attaque;
        this.Defense = defense;
        this.Sante = sante;
        this.Mana = 100;
    }

    public void LancerAttaque(Guerrier cible)
    {
        if (this.Attaque > cible.Defense) {
            cible.Sante -= this.Attaque;
            Console.WriteLine("Resultat du lancement d'attaque:Diminuation du santé");
        }
        else if (cible.Sante <= 0) {
            Console.WriteLine("Resultat du lancement d'attaque:Guerrier Mort");
        }
        else {
            Console.WriteLine("Resultat du lancement d'attaque:sans effet");
        }
        Console.WriteLine("le Joueur "+this.Nom+ " attaque le Joueur "+cible.Nom);
    }
    public void LancerAttaqueAvecDefense(Guerrier cible)
    {
        if(this.Attaque<cible.Defense) {
            this.Sante -= (cible.Defense - this.Attaque);
        }
        else if(this.Attaque>cible.Defense) {
            cible.Sante -= (this.Attaque-cible.Defense);
        }
        else {
            Console.WriteLine("vous etes à egalité");
        }
    }

    public void ActiveSoin()
    {
        if (this.Mana < 10) {
            Console.WriteLine("votre Mana est plus faible");
        }
        else {
            this.Mana -=10;
            this.Sante+=10;
            Console.WriteLine("votre mana est:"+this.Mana);
            Console.WriteLine("Votre niveau de vie est maintenant:"+this.Sante);
        }
    }
    public void AfficheInformation()
    {
        Console.WriteLine("Nom: " +this.Nom);
        Console.WriteLine("Attaqe: " +this.Attaque);
        Console.WriteLine("Defense: " +this.Defense);
        Console.WriteLine("Sante: " +this.Sante);
    }
}