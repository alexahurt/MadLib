using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;


namespace MadLibProject
{
    class MadLibUI
    {
        
        static void Main(string[] args)
        {

            int numberMinutes;
            string nounRings, verbAlgebra, adjectiveThornberrys, firstName, exclamation, adjectiveIce, container, person, verbRemote;
            string clothing, sillyWord, adjectiveBeavers, verbFruit, bodyPart, vehicle, animalPlural;
            string letter;

            Console.Write("Enter in a number of minutes: ");
            numberMinutes = Convert.ToInt32(Console.ReadLine());
            Console.Beep();

            Console.Write("Enter in a noun: ");
            nounRings = Console.ReadLine();
            Console.Beep();

            Console.Write("Enter in a verb: ");
            verbAlgebra = Console.ReadLine();
            Console.Beep();

            Console.Write("Enter in an adjective: ");
            adjectiveThornberrys = Console.ReadLine();
            Console.Beep();

            Console.Write("Enter in your first name: ");
            firstName = Console.ReadLine();
            Console.Beep();

            Console.Write("Enter in an exclamation: ");
            exclamation = Console.ReadLine();
            Console.Beep();

            Console.Write("Enter in an adjective: ");
            adjectiveIce = Console.ReadLine();
            Console.Beep();

            Console.Write("Enter in a type of container: ");
            container = Console.ReadLine();
            Console.Beep();


            Console.Write("Enter in a letter of the alphabet: ");
            letter = Console.ReadLine();
            letter = letter.ToUpper();
            Console.Beep();

            Console.Write("Enter in the name of a person in the room: ");
            person = Console.ReadLine();
            Console.Beep();

            Console.Write("Enter in a verb: ");
            verbRemote = Console.ReadLine();
            Console.Beep();

            Console.Write("Enter in an article of clothing: ");
            clothing = Console.ReadLine();
            Console.Beep();

            Console.Write("Enter in a silly word: ");
            sillyWord = Console.ReadLine();
            Console.Beep();

            Console.Write("Enter in an adjective: ");
            adjectiveBeavers = Console.ReadLine();
            Console.Beep();

            Console.Write("Enter in a verb: ");
            verbFruit = Console.ReadLine();
            Console.Beep();

            Console.Write("Enter in a body part: ");
            bodyPart = Console.ReadLine();
            Console.Beep();

            Console.Write("Enter in a type of vehicle: ");
            vehicle = Console.ReadLine();
            Console.Beep();

            Console.Write("Enter in a type of animal (plural): ");
            animalPlural = Console.ReadLine();
            Console.Beep();

            Console.Clear();

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Users\Owner\Downloads\346775__evanjones4__first-renoise-track.wav");
            player.Play();


            Console.WriteLine("Only " + numberMinutes + " minutes left till the school " + nounRings + ", and when it does, I'm so out of here!");
            Console.WriteLine( "It's impossible to " + verbAlgebra + " on algebra when I could be home watching shows like The " + adjectiveThornberrys + " Thornberrys on " + firstName + " - toons.");
            Console.WriteLine("Seriously, right now the only thing standing between me, " + exclamation + " Arnold! and an ice-" + adjectiveIce + " juice " + container + " is math!");
            Console.WriteLine("O-M-" + letter + "! What if my older sister " + person + " makes it home before I do? ");
            Console.WriteLine("She'll totally " + verbRemote + " the remote, and I'd rather eat my own " + clothing + " than miss an episode of Ren & " + sillyWord + " or The " + adjectiveBeavers + " Beavers. ");
            Console.WriteLine("And does she actually think she can just " + verbFruit + " my Fruit by the " + bodyPart + "and keep me from watching " + vehicle + " Power? ");


            Console.WriteLine("As if! She may be bossy like Angelica from the Rug- " + animalPlural + ", but I've got Mom's number on speed dial!");
            
            Console.ReadLine();
        }
    }
}
