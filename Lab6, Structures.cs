//svg does precious
using System;                          // Аналог <iostream> для работы с консолью и основными функциями
using System.Collections.Generic;       // Аналог <vector>, <list>, <map>, <set>, <unordered_map>, <unordered_set>, <stack>, <queue>
using System.Text;                      // Аналог <string>, <cstring> (для работы со строками и StringBuilder)
using System.Linq;                      // Аналог <algorithm> (для работы с LINQ, сортировок, поиска и т.д.)
using System.IO;                        // Аналог <cstdio>, <fstream> (работа с файлами)
using System.Globalization;             // Аналог <iomanip> (для форматирования)
using System.Collections;               // Работа с различными коллекциями (например, ArrayList)
using System.Threading;                 // Потоки и многопоточность
using System.Runtime.Serialization;     // Аналог <stdexcept> (работа с исключениями)
using System.Reflection;                // Аналог <typeinfo> (информация о типах, рефлексия)
using System.Diagnostics;               // Аналог <utility>, <std::pair> (вспомогательные функции и классы)
using System.ComponentModel;            // Дополнительные утилиты и атрибуты
using System.Numerics;                  // Работа с большими числами и математическими операциями
using System.Globalization;
using System.Diagnostics;
using System.Net;
using System.Numerics;
// Для работы с потоками данных:
using System.Threading.Tasks;           // Асинхронные задачи

// Для работы с датами и временем:
using System.Timers;                    // Для работы с таймерами и временем
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO; //important
using System.Globalization;
using System.Collections;
using System.Threading;
using System.Runtime.Serialization;
using System.Reflection;
using System.Diagnostics;
using System.ComponentModel;
using System.Numerics;
using System.Globalization;
using System.Diagnostics;
using System.Net;
using System.Numerics;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Web;
using System.Media;
using System.Drawing;
using System.Configuration;
using System.Timers;
using System.Runtime.Remoting;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.CodeDom;
using System.CodeDom.Compiler;
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
Izzspot - 19 years
Boogie B - 20 years
SJ - 21 years
Bandokay - life sentence

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

// Лабораторная №6
class Program
{
    static void Main()
    {
        Console.WriteLine("1 Уровень Задача 1");
        task11.Run();

        Console.WriteLine("\n1 Уровень Задача 2");
        task12.Run();

        Console.WriteLine("\n1 Уровень Задача 3");
        task13.Run();

        Console.WriteLine("\n2 Уровень Задача 7");
        task27.Run();

        Console.WriteLine("\n2 Уровень Задача 8");
        task28.Run();

        Console.WriteLine("\n2 Уровень Задача 9");
        task29.Run();

        Console.WriteLine("3 Уровень Задача 3");
        task33.Run();

        Console.WriteLine("\n3 Уровень Задача 4");
        task34.Run();

        Console.WriteLine("\n3 Уровень Задача 5");
        task35.Run();
    }
}

// Задача 1: Соревнования по прыжкам в длину
class task11
{
    struct Participant
    {
        public string LastName;
        public string Club;
        public double Attempt1;
        public double Attempt2;
        public double TotalScore;

        public Participant(string lastName, string club, double attempt1, double attempt2)
        {
            LastName = lastName;
            Club = club;
            Attempt1 = attempt1;
            Attempt2 = attempt2;
            TotalScore = attempt1 + attempt2;
        }
    }

    public static void Run()
    {
        var participants = new List<Participant>
        {
            new Participant("Lewandowski", "Spartak", 6.5, 7.1),
            new Participant("Yamal", "Dynamo", 7.2, 6.9),
            new Participant("Raphinha", "Labor", 6.8, 7.3)
        };

        var sortedParticipants = participants.OrderByDescending(p => p.TotalScore).ToList();

        Console.WriteLine("Результаты соревнований по прыжкам в длину:");
        Console.WriteLine("Место\tФамилия\t\tОбщество\tПопытка 1\tПопытка 2\tСумма");
        for (int i = 0; i < sortedParticipants.Count; i++)
        {
            var p = sortedParticipants[i];
            Console.WriteLine($"{i + 1}\t{p.LastName}\t\t{p.Club}\t\t{p.Attempt1:F2}\t\t{p.Attempt2:F2}\t\t{p.TotalScore:F2}");
        }
    }
}

// Задача 2: Результаты кросса на 500 м для женщин
class task12
{
    struct Runner
    {
        public string LastName;
        public string Group;
        public string Coach;
        public double Result;
        public bool NormativeMet;

        public Runner(string lastName, string group, string coach, double result, double normative)
        {
            LastName = lastName;
            Group = group;
            Coach = coach;
            Result = result;
            NormativeMet = result <= normative;
        }
    }

    public static void Run()
    {
        double normative = 90.0; // Время в секундах для выполнения норматива
        var runners = new List<Runner>
        {
            new Runner("Lewandowski", "Group 1", "Smirnov", 85.4, normative),
            new Runner("Yamal", "Group 2", "Petrov", 92.1, normative),
            new Runner("Raphinha", "Group 1", "Smirnov", 88.7, normative)
        };

        var sortedRunners = runners.OrderBy(r => r.Result).ToList();
        int normativeCount = sortedRunners.Count(r => r.NormativeMet);

        Console.WriteLine("Результаты кросса на 500 м для женщин:");
        Console.WriteLine("Фамилия\t\tГруппа\t\tПреподаватель\tРезультат\tНорматив");
        foreach (var r in sortedRunners)
        {
            Console.WriteLine($"{r.LastName}\t\t{r.Group}\t{r.Coach}\t\t{r.Result:F1}\t\t{(r.NormativeMet ? "Выполнен" : "Не выполнен")}");
        }
        Console.WriteLine($"Всего участниц, выполнивших норматив: {normativeCount}");
    }
}

// Задача 3: Опрос радиокомпании «Человек года»
class task13
{
    struct Vote
    {
        public string Candidate;
        public int Count;

        public Vote(string candidate, int count)
        {
            Candidate = candidate;
            Count = count;
        }
    }

    public static void Run()
    {
        var votes = new List<string> { "Lewandowski", "Yamal", "Raphinha", "Lewandowski", "Raphinha", "Lewandowski", "Yamal", "Yamal", "Raphinha", "Raphinha" };
        var voteCounts = votes.GroupBy(v => v)
                              .Select(g => new Vote(g.Key, g.Count()))
                              .OrderByDescending(v => v.Count)
                              .Take(5)
                              .ToList();

        int totalVotes = votes.Count;
        Console.WriteLine("Результаты опроса 'Человек года':");
        Console.WriteLine("Кандидат\tГолосов\t\tДоля (%)");
        foreach (var v in voteCounts)
        {
            double percentage = (double)v.Count / totalVotes * 100;
            Console.WriteLine($"{v.Candidate}\t\t{v.Count}\t\t{percentage:F2}");
        }
    }
}


// Задача 7: Турнирная таблица по шахматам
class task27
{
    struct Participant
    {
        public string LastName;
        public double[] Results;
        public double TotalScore => Results.Sum();

        public Participant(string lastName, double[] results)
        {
            LastName = lastName;
            Results = results;
        }
    }

    public static void Run()
    {
        var participants = new List<Participant>
        {
            new Participant("Lewandowski", new double[] { 1, 0.5, 1, 0 }),
            new Participant("Yamal", new double[] { 0.5, 1, 1, 1 }),
            new Participant("Raphinha", new double[] { 1, 1, 0, 0.5 })
        };

        var sortedParticipants = participants.OrderByDescending(p => p.TotalScore).ToList();

        Console.WriteLine("Итоговая таблица шахматного турнира:");
        Console.WriteLine("Фамилия\t\tОчки");
        foreach (var p in sortedParticipants)
        {
            Console.WriteLine($"{p.LastName}\t\t{p.TotalScore:F1}");
        }
    }
}

// Задача 8: Список кандидатов в хоккейную сборную
class task28
{
    struct Player
    {
        public string LastName;
        public int[] PenaltyTimes;
        public int TotalPenaltyTime => PenaltyTimes.Sum();

        public Player(string lastName, int[] penaltyTimes)
        {
            LastName = lastName;
            PenaltyTimes = penaltyTimes;
        }

        public bool IsEligible => !PenaltyTimes.Contains(10);
    }

    public static void Run()
    {
        var players = new List<Player>
        {
            new Player("Lewandowski", new int[] { 2, 5, 2 }),
            new Player("Yamal", new int[] { 10, 2, 5 }),
            new Player("Raphinha", new int[] { 5, 2, 5 }),
            new Player("Gavi", new int[] { 2, 2, 2 }),
            new Player("Pedri", new int[] { 2, 5, 2 })
        };

        var eligiblePlayers = players
            .Where(p => p.IsEligible)
            .OrderBy(p => p.TotalPenaltyTime)
            .ToList();

        Console.WriteLine("Список кандидатов в хоккейную сборную:");
        Console.WriteLine("Фамилия\t\tСуммарное штрафное время");
        foreach (var p in eligiblePlayers)
        {
            Console.WriteLine($"{p.LastName}\t\t{p.TotalPenaltyTime}");
        }
    }
}

// Задача 9: Итоговая таблица соревнований фигуристов
class task29
{
    struct Skater
    {
        public string LastName;
        public double[] Scores;
        public int[] Places;
        public int TotalPlace => Places.Sum();

        public Skater(string lastName, double[] scores)
        {
            LastName = lastName;
            Scores = scores;
            Places = new int[scores.Length];
        }

        public void CalculatePlaces(List<Skater> skaters)
        {
            var currentSkater = this; // Копируем текущий экземпляр в локальную переменную
            for (int j = 0; j < Scores.Length; j++)
            {
                Places[j] = skaters
                    .OrderByDescending(s => s.Scores[j])
                    .Select((s, index) => new { s, index = index + 1 })
                    .First(x => x.s.Equals(currentSkater)).index;
            }
        }

    }

    public static void Run()
    {
        var skaters = new List<Skater>
        {
            new Skater("Lewandowski", new double[] { 5.8, 5.9, 6.0, 5.7, 5.8, 6.0, 5.9 }),
            new Skater("Yamal", new double[] { 5.5, 5.6, 5.4, 5.6, 5.5, 5.4, 5.5 }),
            new Skater("Raphinha", new double[] { 5.7, 5.8, 5.9, 5.7, 5.8, 5.9, 5.8 }),
            new Skater("Gavi", new double[] { 5.6, 5.7, 5.8, 5.5, 5.6, 5.7, 5.6 }),
            new Skater("Pedri", new double[] { 5.4, 5.3, 5.5, 5.2, 5.4, 5.3, 5.5 })
        };

        foreach (var skater in skaters)
        {
            skater.CalculatePlaces(skaters);
        }

        var sortedSkaters = skaters.OrderBy(s => s.TotalPlace).ToList();

        Console.WriteLine("Итоговая таблица соревнований фигуристов:");
        Console.WriteLine("Фамилия\t\tСумма мест");
        foreach (var skater in sortedSkaters)
        {
            Console.WriteLine($"{skater.LastName}\t\t{skater.TotalPlace}");
        }
    }
}

// Задача 3: Определение команды-победителя на соревнованиях
class task33
{
    struct Team
    {
        public string Name;
        public int[] Places;
        public int TotalScore;

        public Team(string name, int[] places)
        {
            Name = name;
            Places = places;
            TotalScore = CalculateScore(places);
        }

        private static int CalculateScore(int[] places)
        {
            int score = 0;
            foreach (var place in places)
            {
                score += place switch
                {
                    1 => 5,
                    2 => 4,
                    3 => 3,
                    4 => 2,
                    5 => 1,
                    _ => 0
                };
            }
            return score;
        }
    }

    public static void Run()
    {
        var teams = new List<Team>
        {
            new Team("Team A", new int[] { 1, 6, 3, 8, 5, 10 }),
            new Team("Team B", new int[] { 2, 7, 4, 9, 12, 11 }),
            new Team("Team C", new int[] { 1, 2, 3, 4, 5, 6 })
        };

        var winningTeam = teams.OrderByDescending(t => t.TotalScore)
                               .ThenBy(t => t.Places.Min())
                               .First();

        Console.WriteLine("Команда-победитель:");
        Console.WriteLine($"Название: {winningTeam.Name}, Очки: {winningTeam.TotalScore}");
    }
}

// Задача 4: Лыжные гонки для двух групп участников
class task34
{
    struct Participant
    {
        public string LastName;
        public double Result;

        public Participant(string lastName, double result)
        {
            LastName = lastName;
            Result = result;
        }
    }

    public static void Run()
    {
        var group1 = new List<Participant>
        {
            new Participant("Lewandowski", 21.5),
            new Participant("Yamal", 19.7),
            new Participant("Raphinha", 22.8)
        };

        var group2 = new List<Participant>
        {
            new Participant("Gavi", 20.3),
            new Participant("Pedri", 23.1),
            new Participant("Kounde", 21.2)
        };

        var sortedGroup1 = group1.OrderBy(p => p.Result).ToList();
        var sortedGroup2 = group2.OrderBy(p => p.Result).ToList();

        var combinedResults = sortedGroup1.Concat(sortedGroup2).OrderBy(p => p.Result).ToList();

        Console.WriteLine("Результаты лыжных гонок:");
        Console.WriteLine("Фамилия\t\tРезультат (секунды)");
        foreach (var participant in combinedResults)
        {
            Console.WriteLine($"{participant.LastName}\t\t{participant.Result}");
        }
    }
}

// Задача 5: Первенство по футболу
class task35
{
    struct GameResult
    {
        public string TeamName;
        public int GoalsScored;
        public int GoalsConceded;

        public GameResult(string teamName, int goalsScored, int goalsConceded)
        {
            TeamName = teamName;
            GoalsScored = goalsScored;
            GoalsConceded = goalsConceded;
        }
    }

    struct TeamStanding
    {
        public string TeamName;
        public int Points;
        public int GoalDifference;

        public TeamStanding(string teamName, int points, int goalDifference)
        {
            TeamName = teamName;
            Points = points;
            GoalDifference = goalDifference;
        }
    }

    public static void Run()
    {
        var games = new List<GameResult>
        {
            new GameResult("Team A", 2, 1),
            new GameResult("Team B", 0, 0),
            new GameResult("Team A", 1, 3),
            new GameResult("Team B", 2, 2),
            new GameResult("Team C", 3, 1)
        };

        var standings = CalculateStandings(games);

        var sortedStandings = standings.OrderByDescending(s => s.Points)
                                       .ThenByDescending(s => s.GoalDifference)
                                       .ToList();

        Console.WriteLine("Таблица очков первенства по футболу:");
        Console.WriteLine("Место\tКоманда\t\tОчки\tРазница мячей");
        for (int i = 0; i < sortedStandings.Count; i++)
        {
            var s = sortedStandings[i];
            Console.WriteLine($"{i + 1}\t{s.TeamName}\t\t{s.Points}\t{s.GoalDifference}");
        }
    }

    private static List<TeamStanding> CalculateStandings(List<GameResult> games)
    {
        var standingsDict = new Dictionary<string, TeamStanding>();

        foreach (var game in games)
        {
            int pointsA = game.GoalsScored > game.GoalsConceded ? 3 : (game.GoalsScored == game.GoalsConceded ? 1 : 0);
            int pointsB = game.GoalsScored < game.GoalsConceded ? 3 : (game.GoalsScored == game.GoalsConceded ? 1 : 0);

            UpdateStanding(standingsDict, game.TeamName, pointsA, game.GoalsScored - game.GoalsConceded);
            UpdateStanding(standingsDict, game.TeamName, pointsB, game.GoalsConceded - game.GoalsScored);
        }

        return standingsDict.Values.ToList();
    }

    private static void UpdateStanding(Dictionary<string, TeamStanding> standingsDict, string teamName, int points, int goalDifference)
    {
        if (standingsDict.ContainsKey(teamName))
        {
            var standing = standingsDict[teamName];
            standing.Points += points;
            standing.GoalDifference += goalDifference;
            standingsDict[teamName] = standing;
        }
        else
        {
            standingsDict[teamName] = new TeamStanding(teamName, points, goalDifference);
        }
    }
}
