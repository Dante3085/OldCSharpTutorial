using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*"C# Tutorial"
 * 
 * Allgemeine Informationen
 * ------------------------
 * 1. "STRG + F5", um Konsole nach Start offen zu halten.
 * 2. "Grüne Schlangenlinie" unter Variablen bedeutet, dass diese Variable nicht verwendet wird.
 * 3. Verweise werden hier mit "*Zahl" angegeben. Sie werden in jeglichen Kommentaren verwendet und verweisen auf eine Stelle im "Verweise" Abschnitt.
 * ------------------------
 * 
 * Verweise
 * ---------
 * *1: "Sichtbarkeitsmodifier/Zugangsmodifier" limitieren den Zugang zu den Klasseneigenschaften. "public": Der Zugang ist nicht eingeschränkt.; "protected": Der Zugang ist auf die eigene Klasse und Klassen, die von der eigenen Klasse
 *     geerbt haben beschränkt. "private": Der Zugang ist auf den Body der Klasse beschränkt, in der die Deklaration stattgefunden hat.
 *     
 *     Klassen agieren als Blaupausen für Objekte. Objekte sind Instanzen ihrer Blaupausen (Klassen).
 *     
 * *2: Klassen erstellen automatisch einen Default-Constructor, sofern man keinen eigenen erstellt.
 * 
 * *3: Use the static modifier to declare a static member, which belongs to the type itself rather than to a specific object. The static modifier can be used with classes, fields, methods, properties, operators, events, and 
 *     constructors, but it cannot be used with indexers, finalizers, or types other than classes.
 *     
 * *4: Eine abstrakte Klasse kann nicht instanziiert werden. Sie kann normale, "nicht abstrakte" Methoden enthalten. Wohingegen das Interface ausschließlich abstrakte Methoden enthält.
 * 
 * *5: https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/enum (Enums in C#); https://de.wikipedia.org/wiki/Aufz%C3%A4hlungstyp (Enums allgemein)
 * 
 * *6: "Anonymous Method": Hat keinen Namen und sein Returntyp wird von dem returnten Wert in der Methode definiert.
 * 
 * *7: https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/statements-expressions-operators/lambda-expressions
 * ---------
 * 
 * Internetverweise
 * -----------------
 * 
 * -----------------
 */

//delegate double GetSum(double num1, double num2); //"Deligates": Werden benutzt, um Methoden als Argumente an andere Methoden zu geben. *6

namespace CsharpTutorial
{

    //public enum Temperature //"enums". *5
    //{
    //    Freeze,
    //    Low,
    //    Warm,
    //    Boil
    //}

    //struct Customers
    //{
    //    private string name;
    //    private double balance;
    //    private int id;
    //
    //    public void createCust(string n, double b, int i)
    //    {
    //        name = n;
    //        balance = b;
    //        id = i;
    //    }
    //
    //    public void showCust()
    //    {
    //        Console.WriteLine("Name: {0} \n Balance: {1} \n ID: {2}", name, balance, id );
    //    }
    //}

    class Program
    {
        static void Main(string[] args)        //1. Anfang des Programms (Main).
        {
            //2. One Line Comment

            /*3.
             * Multi Line Comment
             * 
             */

            /*Console.Write("Hello and ");*/                    //4. Schreibt in Parameterklammern angegebenen Text in die Konsole, ohne nach dem Schreiben eine neue Zeile anzufangen.
            /*Console.WriteLine("Hello2");*/                    //5. Dasselbe wie "Console.Write()" nur mit neuer Zeile am Ende.

            //Console.Write("What is you'r Name? ");
            /*string name = Console.ReadLine(); */              //6. Userinput
            /*Console.WriteLine("Hallo" + name);*/              //Ausgabe des Strings "name". Mehrere Elemente der Ausgabe werden wie in Java mit einem "+" verbunden.

            /*bool canVote = true;*/                            //7. Boolean Variable, die entweder "true" oder "false" sein kann.

            /*char grade = 'A';*/                               //8. char Variablen können nur ein einziges Zeichen speichern.

            /*Console.WriteLine(int.MaxValue);    */            //9. "int.MaxValue" ist der Maximalwert, den eine int Variable annehmen kann.
            /*Console.WriteLine(long.MaxValue);   */            //10. Dasselbe für long.
            /*Console.WriteLine(decimal.MaxValue);*/            //11. Dasselbe für decimal. Für etwas größeres nach "BigInteger" suchen.
            /*Console.WriteLine(float.MaxValue);  */            //12. Dasselbe für float. float ist eine 32 bit Zahl. Sie hat eine Präzision von 7 Nachkommastellen. Mehr Verursachen Probleme.
            /*Console.WriteLine(double.MaxValue); */            //13. Dasselbe für double. double ist eine 32 bit Zahl. Sie hat eine Präzision von 15 Nachkommastellen. Mehr Verursachen Probleme.

            /* var varVariable = "Tom";*/                        //14. var Variablen definieren ihren Datentyp nach dem Initialisierungswert. Nachträglich können sie keinen anderen Wert mehr zugewiesen bekommen.
            /*Console.WriteLine("varVariable is a {0}", varVariable.GetTypeCode());*/   //15. "GetTypeCode()" liefert den Datentyp einer var Variable. "{0}" ist ähnlich dem "%d" in Java. Es ist ein Platzhalter für Daten im String.

            /*Console.WriteLine(5 + 5);*/                           //16. Addition
            /*Console.WriteLine(5 - 5);*/                           //17. Subtraktion
            /*Console.WriteLine(5 / 5);*/                           //18. Division
            /*Console.WriteLine(5 * 5);*/                           //19. Multiplikation
            /*Console.WriteLine(6 % 5);*/                           //20. Modulo Ausdruck "%" gibt den Rest einer Division aus.

            //int i = 0;

            /*Console.WriteLine("i++: " + (i++));*/                 //21. Nimmt erst "i" und erhöht es dann um eins.
            /*Console.WriteLine("++i: " + (++i));*/                 //22. Erhöht i erst um eins und nimmt es sich dann.
            /*Console.WriteLine("i--: " + (i--));*/                 //23. siehe oben.
            /*Console.WriteLine("--i: " + (--i));*/                 //24. siehe oben.

            /* Console.WriteLine("i += 3: " + (i += 3));*/          //25. "i += 3" ist dasselbe wie "i = i + 3".

            //double pi = 3.14;
            /*int intPi = (int)pi;*/                                //26. Casting. Die double Variable "pi" wird in der int Variable "intPi" gespeichert, indem sie zu int runtergecastet wird. *1

            //double number1 = 10.5;
            //double number2 = 15;

            /*Console.WriteLine("Math.Abs(number1)          " + (Math.Abs(number1)));         */    //27. Absolutwert.
            /*Console.WriteLine("Math.Ceiling(number1)      " + (Math.Ceiling(number1)));     */    //28. Aufrunden.
            /*Console.WriteLine("Math.Floor(number1)        " + (Math.Floor(number1)));       */    //29. Abrunden.
            /*Console.WriteLine("Math.Max(number1, number2) " + (Math.Max(number1, number2)));*/    //30. Größere Zahl wird ausgegeben.
            /*Console.WriteLine("Math.Min(number1, number2) " + (Math.Min(number1, number2)));*/    //31. Kleinere Zahl wird ausgegeben.
            /*Console.WriteLine("Math.Pow(number1, number2) " + (Math.Pow(number1, 2)));      */    //32. Potenzrechnung. number 1 hoch number 2.
            /*Console.WriteLine("Math.Round(number1)        " + (Math.Round(number1)));       */    //33. Runden.
            /*Console.WriteLine("Math.Sqrt(number1)         " + (Math.Sqrt(number1)));        */    //34. Quadratwurzel.

            //Console.WriteLine();

            /*Random rand = new Random();*/           //35. "rand" ist ein Objekt der Klasse "Random". 
            /*Console.WriteLine("Random Number between 1 and 10: " + rand.Next(1, 11));*/           //36. rand kann mit der Funktion "Next()" zufällige Zahlen in einem bestimmten Bereich generieren. 1 und 11 ist zwischen 1 und 10.

            //Relationale Operatoren: < > <= >= == != | kleiner als, größer als, kleiner gleich, größer gleich, gleich, ungleich.
            //Logische Operatoren: && || ^ ! | und, oder, exklusives oder (genau einer der beiden Operanden ist true), nicht.

            //int age = 8;

            //if (age < 5)    //37. if-Ausdrücke mit relationalen und logischen Operatoren. Wenn Bedingung zutrifft, dann . . .
            //{
            //    Console.WriteLine("Du kannst noch nicht zur' Schule.");
            //}
            //else if (age >= 5 && age <= 7)  //38. else-if-Ausdrücke. 
            //{
            //    Console.WriteLine("Geh' zur Grundschule.");
            //}
            //else if (age > 7 && age < 13)
            //{
            //    Console.WriteLine("Geh' zur weiterführenden Schule.");
            //}
            //else //39. else-Statement.
            //{
            //    Console.WriteLine("Geh' zur' Hochschule.");
            //}

            //if (age < 14 || age > 67)
            //{
            //    Console.WriteLine("You shouldn't work");
            //}

            //Console.WriteLine("!true: " + !true);   //40. ! nicht.

            //int age = 17;
            //bool canDrive = age >= 16 ? true : false;   //41. Fragezeichenoperator. Wenn links von "?" (age >= 16) true ist, wird linke Seite von rechts von ? (true) ausgegeben. Wenn nicht, dann rechte Seite (false).

            //int age = 0;
            //
            //switch (age)                        //42. switch-Statement
            //{
            //    case 0:                         //43. "case" eines switch-Statements.
            //        Console.WriteLine("Infant");
            //        break;                      //Cases müssen in C# mit einem "break" beendet werden. Sonst Compilererror.
            //
            //    case 1:                             //Wenn "age" 1 oder 2 ist, wird folgender Code ausgeführt.
            //    case 2:                             
            //        Console.WriteLine("Toddler");
            //        break;
            //
            //    case 3:
            //        goto Cute;                      //"goto" Statement. NICHT BENUTZEN. SPAGHETTICODE.
            //
            //    default:                            //Wird ausgeführt, wenn keiner der vorherigen cases zutrifft.
            //        Console.WriteLine("Child");
            //        break;
            //}
            //Cute: Console.WriteLine("Toddlers are Cute");

            //int i = 0;
            //
            //while (i < 10)          //44. while-loop. Benötigt eine Bedingung. Code im Loop wird so lange ausgeführt, bis Bedingung nicht mehr gilt.
            //{
            //
            //    if ((i % 2) > 0)
            //    {
            //        Console.WriteLine(i + " ist eine ungerade Zahl!");
            //        i++;
            //        continue;       //45. "continue" beendet den jetzigen Schleifendurchgang. Wenn die Bedingung noch gilt, wird die Schleife wieder angefangen. Wohingegen "break" die Schleife komplett abbricht.
            //    }
            //
            //    if ((i % 2) == 0)
            //    {
            //        Console.WriteLine(i + " ist eine gerade Zahl");
            //        i++;
            //        continue;
            //    }
            //}
            //
            //String guess;
            //
            //do                      //46. do-while Loop. Wird immer einmal ausgeführt, da die Bedingung erst abgefragt wird, wenn der Code schon durchgelaufen ist.
            //{
            //    Console.WriteLine("Rate eine Zahl");
            //    guess = Console.ReadLine();
            //}
            //while (!guess.Equals("15"));
            //
            //for (int z = 0; z < 10; z++)    //47. for Loop. Zählvariable, Bedingung und Inkrementierung der Zählvariable werden im Kopf der Schleife erledigt.
            //{
            //    if (z % 2 > 0)
            //    {
            //        Console.WriteLine(z + " ist eine ungerade Zahl");
            //    }
            //}
            //
            //String randStr = "Here are some random characters.";
            //
            //foreach (char c in randStr) //48. foreach Loop. Geht mit jedem Schleifendurchgang durch einen Character des spezifizierten Strings.
            //{
            //    Console.WriteLine(c);
            //}

            //string sampString = "A bunch of random words";
            //string sampString2 = " ";
            //string sampString3 = "More random words";
            //string sampString4 = "A bunch of random words";
            //string sampString5 = "  A bunch of random words   ";
            //string sampString6 = "  Whitespace will be deleted.";
            //
            //Console.WriteLine("Is empty: " + String.IsNullOrEmpty(sampString));       //49. String Funktion "IsNullOrEmpty()" überprüft, ob ein String leer ist. Gibt bool zurück.
            //
            //Console.WriteLine("Is empty: " + String.IsNullOrWhiteSpace(sampString2)); //50. String Funktion "IsNullOrWhiteSpace()" überprüft, ob String leer ist oder nur Whitespace hat. Gibt bool zurück.
            //
            //Console.WriteLine("String length: " + sampString.Length);                 //51. "Length" ruft Anzahl der Zeichen im aktuellen Stringobjekt ab.
            //
            //Console.WriteLine("Index of bunch: " + sampString.IndexOf("bunch"));      //52. "IndexOf()" gibt den Index einer spezifizierten Zeichenkette in einem String zurück.
            //
            //Console.WriteLine("2nd Word: " + sampString.Substring(2, 6));             //53. "Substring()" zieht eine durch Indexanfang und Indexende spezifizierte Zeichenkette als Substring aus dem String.
            //
            //Console.WriteLine("Strings Equal: " + sampString.Equals(sampString3));    //54. "Equals()" prüft, ob 2 Strings gleich sind.
            //Console.WriteLine("Strings Equal: " + sampString.Equals(sampString4));
            //
            //Console.WriteLine("Starts With \"A bunch\": " + sampString.StartsWith("A bunch")); //55. "StartsWith()" prüft, ob ein String mit einer spezifizierten Zeichenkette startet. \"A bunch:\" ermöglicht, dass innerhalb "", "" stehen können.
            //
            //Console.WriteLine("Ends with \"words\": " + sampString.EndsWith("words"));  //56. "EndsWith()" prüft, ob ein String mit einer spezifizierten Zeichenkette endet.
            //
            //sampString5 = sampString5.Trim();     //57. "Trim()" entfernt Whitespace vorne und hinten aus einem String. Whitespace zwischen Zeichen/Zeichenketten wird nicht entfernt.
            //Console.WriteLine(sampString5);
            //
            //sampString5 = sampString5.TrimStart();   //58. "TrimStart()" entfernt Whitespace nur am Anfang.
            //sampString5 = sampString5.TrimEnd();     //59. "TrimEnd()" entfernt Leerzeichen nur am Ende.
            //
            //sampString6 = sampString6.Replace(" ", ""); //60. "Replace" ersetzt spezifizierte Zeichenkette durch andere spezifizierte Zeichenkette.
            //Console.WriteLine(sampString6);
            //
            //sampString = sampString.Remove(0, 2); //61. "Remove()" nimmt Zeichen vom spezifizierten Indexanfang bis zum spezifizierten Indexende heraus. Achtung: Zeichen am Indexende wird nicht rausgenommen. In diesem Fall wird 0 und 1 rausgenommen.
            //Console.WriteLine(sampString);
            //
            //string[] names = new string[3] {"Matt", "Joe", "Paul"}; //62. String-Array. Kann in geschweiften Klammern initialisiert werden.
            //names[0] = "Peter";                                     //Allerdings kann auch jeder Index (entspricht einem String) einzeln angesprochen werden.
            //
            //Console.WriteLine("Name List: " + String.Join(", ", names)); //63. "Join()" verbindet alle Elemente eines String-Arrays und trennt sie mit dem angegebenen Trennzeichen.

            //string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.567, .56, 1000);   //64. String.Format()
            //Console.WriteLine(fmtStr);

            //StringBuilder sb = new StringBuilder(); //65. "StringBuilder". Jedes Mal, wenn ein String erzeugt wird, wird ein String im Speicher erstellt. StringBuilder werden benutzt, wenn man einen String manipulieren will, ohne neue Strings zu erstellen.
            //
            //sb.Append("This is a new sentence"); //66. "Append()" hängt spezifizierte Zeichenkette hinten dran, ohne eine neue Zeile zu erstellen.
            //
            //sb.AppendFormat("My name is {0} and I live in {1}", "Moritz", "Germany"); //67. "AppendFormat()".
            //
            ////sb.Clear(); //68. Entfernt alle Zeichen aus dem StringBuilder Objekt.
            //
            //sb.Replace("a", "e");   //69. "Replace()" ersetzt spezifizierte Zeichenkette mit anderer spezifizierten Zeichenkette.
            //
            //sb.Remove(0, 1); //70. "Remove" Entfernt den angegebenen Bereich von Zeichen aus dem Objekt.
            //
            //Console.WriteLine("String Builder \"sb\": " + sb.ToString());  //71. "ToString()" konvertiert das StringBuilder Objekt in einen String.

            //int[] randNumArray; //72. "int-Array" deklariert.
            //
            //int[] randArray = new int[5];   //73. "int-Arrray" mit 5 Plätzen deklariert. Merke: Es wird bei "0" angefangen zu zählen.
            //randArray[4] = 4;
            //
            //int[] randArray2 = {1, 2, 3, 4, 5}; //74. "int-Array" das direkt mit 5 Werten initialisiert wurde. Die Größe des Arrays wird dann automatisch an die Menge der Initialisierungswerte angepasst.
            //
            //Console.WriteLine("Array Length: " + randArray2.Length);    //75. "Length" gibt die Länge eines Arrays an.
            //
            //Console.WriteLine("Item 0: " + randArray2[0]);  //Der angegebene Index des Arrays wird ausgegeben.
            //
            //for (int i = 0; i < randArray2.Length; i++) //Die for-Schleife geht durch jeden Index des Arrays.
            //{
            //    Console.WriteLine("{0} : {1}", i, randArray2[i]);
            //}
            //
            //foreach (int num in randArray2) //foreach-Schleife geht durch Array. "num" ist der Zwischenspeicher jedes Elements des Arrays. "randArray2" ist das, durch was durchgegangen werden soll.
            //{
            //    Console.WriteLine(num);
            //}
            //
            //Console.WriteLine("Where is 1: " + Array.IndexOf(randArray2,1));    //76. "IndexOf()" gibt den Index eines spezifizierten Elements wieder.
            //
            //string[] names = { "Peter", "Paul", "Georgina" };
            //
            //string nameStr = string.Join(",", names);   //77. "Join()" verkettet alle Elemente eines String-Arrays und verwendet das spezifizierte Trennzeichen zwischen den Elementen.
            //Console.WriteLine(nameStr);
            //
            //string[] nameArray = nameStr.Split(',');    //78. "Split()" unterteilt eine Zeichenfolge anhand der Zeichen in einem Array in Teilzeichenfolgen.
            //Console.WriteLine(nameArray[0]);
            //
            //int[,] multArray = new int[5, 5];           //79. Multidimensionales Array wird deklariert. Jedes "," in den ersten eckigen Klammern zeigt eine zusätzliche Dimension an.
            //
            //int[,] multArray2 = {{0, 1}, {2, 3} , {4, 5}}; //Mit den geschweiften Klammern kann das Array wieder sofort initialisiert werden.
            //
            //foreach(int num in multArray2)   //Mit foreach kann durch das multidimensionale Array gegangen werden.
            //{
            //    Console.WriteLine(num);
            //}
            //
            //for (int x = 0; x < multArray2.GetLength(0); x++)
            //{
            //    for (int y = 0; y < multArray2.GetLength(1); y++)
            //    {
            //        Console.WriteLine("{0} | {2} : {2}", x, y, multArray2[x, y]);
            //    }
            //}

            //List<int> numList = new List<int>();                        //80. Wie ein Array, mit dem Unterschied, dass die List ihre Größe bei Hinzugabe bzw. Löschen von Inhalten dynamisch anpasst.
            //
            //numList.Add(5);                                             //81. "Add()" fügt ein Element hinzu. Die Größe der List wird dann dynamisch angepasst.
            //numList.Add(15);
            //numList.Add(25);
            //
            //int[] randArray = {1,2,3,4,5};  
            //numList.AddRange(randArray);                                //82. Mit "AddRange()" lassen sich leicht Arrays einer List hinzufügen.
            //
            //numList.Clear();                                            //83. Mit "Clear()" kann eine List komplett geleert werden.
            //
            //numList.AddRange(randArray);
            //
            //List<int> numList2 = new List<int>(randArray);              //84. So lässt sich ein Array als Initialisierungswert in die List packen.
            //
            //List<int> numList3 = new List<int>(new int[] {1,2,3,4});    //85. Ein Array kann innerhalb einer Listdeklaration erstellt werden.
            //
            //numList.Insert(1, 10);                                      //86. "Insert()" fügt am angegebenen Index ein Element in die List hinzu.
            //
            //numList.Remove(5);                                          //87. "Remove()" entfernt das Vorkommen eines angegebenen Elements.
            //
            //numList.RemoveAt(0);                                        //88. "RemoveAt()" entfernt das Element am angegebenen Index.
            //
            //for (int i = 0; i < numList.Count; i++)                     //89. "Count" ruft die Anzahl der Elemente ab, die in der List stecken.
            //{
            //    Console.WriteLine(numList[i]);
            //}
            //
            //Console.WriteLine("10 is in Index: " + numList.IndexOf(10)); //90. "IndexOf()" gibt den Index eines spezifizierten Elements zurück.
            //
            //Console.WriteLine("5 exists in List ?: " + numList.Contains(5)); //91. "Contains()" überprüft, ob das angegebene Element in der List existiert.
            //
            //List<string> strList = new List<string>(new string[] { "Tom", "Paul" }); //Lists können natürlich auch mit "strings" als Datentyp erstellt werden.
            //
            //Console.WriteLine("Tom in List: " + strList.Contains("tom"), StringComparer.OrdinalIgnoreCase); //92. "StringComparer.OrdinalIgnoreCase" sorgt dafür, dass bei der Suche nach "tom" Groß- und Kleinschreibung ignoriert wird.
            //
            //strList.Sort(); //Sortiert die Elemente der List mithilfe des Standardcomparers.

            //try //93. In den "try-Block" kommt Code, der Fehler auslösen könnte.
            //{
            //    Console.WriteLine("Divide 10 by");
            //    int num = int.Parse(Console.ReadLine());  //94. "Parse()" übersetzt eine Zahl als String in eine tatsächliche Zahl.
            //    Console.WriteLine("10 / {0} = {1}", num, 10 / num);
            //}
            //
            //catch (DivideByZeroException ex)            //95. Im "catch-Block" werden mögliche Fehler verarbeitet. Zum Beispiel findet sich unten die Ausgabe einer für den Benutzer geeignete Errormessage, sowie die Ausgabe des Exceptionnamens.
            //{
            //    Console.WriteLine("Can't divide by zero");
            //    Console.WriteLine(ex.GetType().Name);   //96. "GetType().Name" gibt den Namen der Exception aus.
            //    Console.WriteLine(ex.Message);          //97. "Message" ruft eine Meldung auf, die die aktuelle Exception (Ausnahme) beschreibt.
            //    //throw ex;   //98. "throw" wirft eine Exception zur nächst höheren Ebene, zum Beispiel dem Aufrufer einer Methode.
            //    throw new InvalidOperationException("Operation Failed", ex);    //99. Es können auch neue Exceptions geworfen werden.
            //}
            //
            //catch (Exception ex)    //100. "Exception" ist eine allgemeine Exception.
            //{
            //    Console.WriteLine("Generic Exception {0}", ex.GetType().Name);
            //}

            //Animal peter = new Animal(1.85, 85, "Hello", "Peter"); //107. Instanziierung der "Animal" Klasse.
            //
            //Console.WriteLine(peter.toString());
            //Console.WriteLine("Numbe of Animals is: " + Animal.getNumOfAnimals());    //108. Static Methods werden durch den Klassennamen aufgerufen (Static Reference), da sie zur Klasse und nicht den Objects gehören.
            //Console.WriteLine(peter.getSum(5, 6));
            //Console.WriteLine(peter.getSum(5.4, 6.8));
            //Console.WriteLine(peter.getSum(num1: 5, num2: 7)); //110. Mit dieser Schreibweise "num1: 5" kann der übergebene Wert präzise übergeben werden, zum Beispiel auch andersherum.
            //
            //Animal grover = new Animal //111. In C# können Objekte auch wie folgt erstellt werden (Object Initializer).
            //{
            //    name = "Grover",
            //    height = 10,
            //    weight = 18,
            //    sound = "Grrrr"
            //};
            //
            //Dog spike = new Dog();
            //
            //Console.WriteLine(spike.toString());
            //
            //spike = new Dog(10, 20, "Spike", "GRR", "Chicken");
            //
            //Console.WriteLine(spike.toString());

            //Shapeitem rect = new Rectangle(5, 5);
            //Shapeitem tri = new Triangle(5, 5);
            //
            //Console.WriteLine("Rect Area: " + rect.area());
            //Console.WriteLine("Trie Area: " + tri.area());
            //
            //Rectangle combRect = new Rectangle(5, 5) + new Rectangle(5, 5);
            //
            //Console.WriteLine("combRectArea: " + combRect.area());

            //KeyValue <string, string> superman = new KeyValue<string, string>("", "");
            //
            //superman.key = "Superman";
            //superman.value = "Clark Kent";
            //
            //KeyValue<int, string> samsungTV = new KeyValue<int, string>(0, "");
            //
            //samsungTV.key = 12345;
            //samsungTV.value = "a 50 inch Samsung TV";
            //
            //superman.showData();
            //samsungTV.showData();

            //Temperature micTemp = Temperature.Warm;
            //
            //switch (micTemp)
            //{
            //    case Temperature.Freeze:
            //        Console.WriteLine("Temp on Freezing");
            //        break;
            //
            //    case Temperature.Low:
            //        Console.WriteLine("Temp on Low");
            //        break;
            //
            //    case Temperature.Warm:
            //        Console.WriteLine("Temp on Warm");
            //        break;
            //
            //    case Temperature.Boil:
            //        Console.WriteLine("Temp on Boil");
            //        break;
            //}

            //Customers bob = new Customers();
            //
            //bob.createCust("Bob", 15.50, 1234);
            //bob.showCust();

            //GetSum sum = delegate (double num1, double num2) //Anonyme Methode.
            //{
            //    return num1 + num2;
            //};
            //
            //Console.WriteLine("5 + 10 = " + sum(5, 10));

            //"Lambda Expression": Ein Lambdaausdruck ist eine anonyme Funktion, mit der Typen für Delegaten oder die Ausdrucksbaumstruktur erstellt werden können. *7
            //Func<int, int, int> getSum = (x, y) => x + y;
            //
            //Console.WriteLine("5 + 3: " + getSum.Invoke(5, 3));
            //
            //List<int> numList = new List<int> { 5, 10, 15, 20, 25 };
            //List<int> oddNums = numList.Where(n => n % 2 == 1).ToList();
            //
            //foreach(int num in oddNums)
            //{
            //    Console.WriteLine(num + ", ");
            //}

            //"File I/O"
            string[] custs = new string[] {"Tom", "Paul", "Greg" };

            using (StreamWriter sw = new StreamWriter("custs.txt")) //Wird in "Debug" Ordner automatisch erstellt.
            {
                foreach (string cust in custs)
                {
                    sw.WriteLine(cust);
                }
            }

            string custName = "";

            using (StreamReader sr = new StreamReader("custs.txt"))
            {
                while ((custName = sr.ReadLine()) != null)
                {
                    Console.WriteLine(custName);
                }
            }
        }
    }

    //class Animal    //101. Klasse "Animal".
    //{
    //    //*1
    //    public double height { get; set; }  //101. "{ get; set; }" erstellt für jeweiliges Attribut automatisch eine get und eine set Methode.
    //    public double weight { get; set; }
    //    public string sound { get; set; }
    //
    //    public string name;
    //
    //    public string Name  //102. Eigene get und setter Methode.
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }
    //
    //    //*2
    //    public Animal() //103. Default-Konstruktor. Dieser Konstruktor setzt einfach alle Attribute einer Animal Instanz auf einen Defaultwert.
    //    {
    //        this.height = 0; //The this keyword refers to the "current instance" of the class and is also used as a modifier of the first parameter of an extension method. Hier werden alle Attribute einer Animal Instanz auf einen Standardwert gesetzt.
    //        this.weight = 0;
    //        this.sound = "No Sound";
    //        this.name = "No Name";
    //        numOfAnimals++; //Jedes Mal wenn dieser Konstruktor aufgerufen wird, erhöht sich die "numOfAnimals" um 1.
    //    }
    //
    //    public Animal(double _height, double _weight, string _sound, string _name) //104. Dieser Konstruktor erlaubt dem Aufrufer, beliebige Werte in die 4 Klassenattribute zu setzen.
    //    {
    //        this.height = _height;
    //        this.weight = _weight;
    //        this.sound = _sound;
    //        this.name = _name;
    //        numOfAnimals++; //Jedes Mal wenn dieser Konstruktor aufgerufen wird, erhöht sich die "numOfAnimals" um 1.
    //    }
    //
    //    static int numOfAnimals = 0; //105. *3
    //
    //    public static int getNumOfAnimals() //106. Gibt "numOfAnimals" zurück. Mit "static" modfizierte Methoden haben keinen Zugriff auf nicht static Attribute.
    //    {
    //        return numOfAnimals;
    //    }
    //
    //    public string toString() //Gibt alle Attribute eines Animal Objects aus.
    //    {
    //        return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3}", name, height, weight, sound);
    //    }
    //
    //    public int getSum(int num1, int num2) //Mit "int num1 = irgendwas" könnten Defaultwerte gesetzt werden, die benutzt werden, falls keine Parameter übergeben wurden.
    //    {
    //        return num1 + num2;
    //    }
    //
    //    public double getSum(double num1, double num2) //109. "Method Overloading". Gleiche Methode wie "getSum()" von oben, mit dem Unterschied, dass hier double Werte verarbeitet werden. "getSum()" wurde überladen.
    //    {
    //        return num1 + num2;
    //    }
    //}
    //
    //class Dog : Animal //112. "Vererbung". Die neue Klasse "Dog" erbt von "Animal".
    //{
    //    public string favFood { get; set; }
    //
    //    public Dog() : base() //113. "base" sorgt dafür, dass alle Initialisierungen der Superklasse/Elternklasse der Attribute für die erbende Klasse übernommen werden. (Call Superclass Methods)
    //    {
    //        this.favFood = "No Favorite Food";
    //    }
    //
    //    public Dog(double height, double weight, string name, string sound, string favFood) : base(height, weight, name, sound)
    //    {
    //        this.favFood = favFood;
    //    }
    //
    //    new public string toString() //114. "new" overrided die Methode "toString()" aus Animal. Diese "toString()" Methode ist praktisch eine andere Version derer aus Animal.
    //    {
    //        return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3} and eats {4}", name, height, weight, sound, favFood);
    //    }
    //}

    //115. "Abstract Class": Erzwingt bei den erbenden Klassen die Implementierung seiner Methoden. Pro Klasse kann immer nur von "einer einzigen" abstrakten Klasse geerbt werden, jedoch von beliebig vielen Interfaces. *4
    //abstract class Shape
    //{
    //    public abstract double area();
    //
    //    public void sayHi()
    //    {
    //        Console.WriteLine("Hello");
    //    }
    //}

    //116. Da in einem Interface ausschließlich abstrakte Methoden sind, müssen diese nicht mehr mit "abstract" deklariert werden. Sie sind es automatisch.
    //public interface Shapeitem
    //{
    //    double area();
    //}
    //
    //class Rectangle : Shapeitem
    //{
    //    private double length;
    //    private double width;
    //
    //    public Rectangle(double num1, double num2)
    //    {
    //        length = num1;
    //        width = num2;
    //    }
    //
    //    public double area()
    //    {
    //        return length * width;
    //    }
    //
    //    public static Rectangle operator +(Rectangle rect1, Rectangle rect2) //117. Operator Overloading. "+" Operator wird überladen. Erwartet 2 "Rectangle" Objekte.
    //    {
    //        double rectLength = rect1.length + rect2.length; //Die Summe der beiden Rectangle Längen wird die Länge des neuen Rectangles.
    //        double rectWidth = rect1.width + rect2.width;    //Die Summe der beiden Rectangle Breiten wird die Breite des neuen Rectangles.
    //
    //        return new Rectangle(rectLength, rectWidth);     //Ein neues Rectangle mit den vorhin berechneten Maßen wird zurückgegeben.
    //    } 
    //}
    //
    //class Triangle : Shapeitem
    //{
    //    private double _base;
    //    private double _height;
    //
    //    public Triangle(double num1, double num2)
    //    {
    //        _base = num1;
    //        _height = num2;
    //    }
    //
    //    public double area()
    //    {
    //        return 0.5 * (_base * _height);
    //    }
    //}

    //class KeyValue<TKey, TValue> //118. "Generics". Ermöglichen die Einstellung eines Datentypplatzhalters. Der Datentyp wird erst durch die Übergabe bei der Erstellung einer Instanz festgelegt.
    //{
    //    public TKey key { get; set; }
    //    public TValue value { get; set; }
    //
    //    public KeyValue(TKey k, TValue v)
    //    {
    //        key = k;
    //        value = v;
    //    }
    //
    //    public void showData()
    //    {
    //        Console.WriteLine("{0} is {1}", this.key, this.value);
    //    }
    //}
}
