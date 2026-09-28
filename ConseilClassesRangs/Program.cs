namespace TaxeDouane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int niveau;
            int nombreDeQuetesHero;
            string G = "Guerrier";
            string M = "Mage";
            string R = "Rogue";
            string grade;
            Console.WriteLine("Choisissez votre niveau");
            niveau = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choisissez votre classe (G pour Guerrier, M pour Mage, R pour Rogue) :");
            char classe = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.WriteLine("Combien de quêtes héroïques avez-vous accomplies ?");
            nombreDeQuetesHero = Convert.ToInt32(Console.ReadLine());

            if (niveau < 10)
                grade = "Novice";

            else if (niveau >= 10 && niveau <= 20 && nombreDeQuetesHero >= 5)
                grade = "Adepte";
            else if (niveau >= 10 && niveau <= 20 && nombreDeQuetesHero < 5)
                grade = "Apprenti Assermenté";
            else if ((niveau > 20 && niveau < 30) || (classe == 'M' && niveau >= 25))
                grade = "Vétéran";
            else if ((niveau >= 30 && nombreDeQuetesHero >= 20) || classe == 'G' || classe == 'M')
                grade = "Maître de Guilde";
            else
                grade = "Statut indérterminé/Hors-la-loi";

            Console.WriteLine($"Vous niveau {niveau} et grade {grade}");

        }
    }
}