//svg does precious
using System.Collections.Concurrent;
using System.Runtime;
using System.Windows;
using System.Windows.Input;
using System.Security.Principal;
using System.Security.Permissions;
using System.Resources;
using C = System.Console; //console
using dl = System.Decimal;//decimal
using str = System.String;//string
using l = System.Int64;   //long
using u = System.UInt64;  //Ulong
using db = System.Double; //Double

/*
SJ 19, Bandokay 21, Double Lz 19 OFB 4r

Youngest in the charge 
OFB, we don't window shop
Bro caught him an opp and tried turn him off (Bow, bow)
In this X3, man's swervin' off (Skrr, skrr)
Free Boogie Bando, he got birded off (Free my bro, free my bro)
Whenever we get a burner loss
We just cop a next one and go burst it off (Ay)
Lil bro's tellin' me he got his earnings wrong
We just took him OT, now his trapline's gone (Ring, ring)
Hashtag 
Bro backed this ting and just started squeezin' (Clarted)
When it broad day, it was freezin'
Hashtag fuckery, hashtag screamin'
One on the hand ting woi, left man lеanin', leanin' (Fucker)
Show us cause it's good to feel it
Shortiе's cooze and she must be dreamin'
*/
/* ¡Adelante Barcelona, adelante Cataluña! Visca el Barça! Visca Catalunya!
   ¡Al diablo con todos los demás, porque lo más importante en la vida es el fútbol!
*/
//-------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------

namespace CombinedTasks
{
    class EncoderDecoder
    {
        private Dictionary<string, string> wordToCode;
        private Dictionary<string, string> codeToWord;
        public EncoderDecoder()
        {
            wordToCode = new Dictionary<string, string>()
            {
                { "и", "001" },
                { "в", "002" },
                { "на", "003" },
                { "с", "004" },
                { "Barcelona", "005" },
                { "best", "006" },
                { "club", "007" },
                { "world", "008" }
            };
            codeToWord = new Dictionary<string, string>();
            foreach (var pair in wordToCode)
                codeToWord.Add(pair.Value, pair.Key);
        }
        public string EncodeWord(string word) =>
            wordToCode.ContainsKey(word) ? wordToCode[word] : word;
        public string DecodeWord(string word) =>
            codeToWord.ContainsKey(word) ? codeToWord[word] : word;
    }

    class TextProcessor
    {
