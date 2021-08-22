using System;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.IO;
using System.Reflection;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 
/// 
/// </summary>
namespace pragrimtech_c_sharp__vs_2019_
{

    public class OneHitWonders
    {
        public static List<Song> DetermineOneHitWonders(List<Song> songs)
        {
            List<Song> oneHitWonders = new List<Song>();
            foreach (Song song in songs)
            {
                bool oneHit = true;
                foreach (Song otherSong in songs)
                {
                    if (otherSong.Id != song.Id && otherSong.Artist == song.Artist) oneHit = false;
                }
                if (oneHit) oneHitWonders.Add(song);
            }
            return oneHitWonders;
        }

        public static List<Song> NewDetermineOneHitWonders(List<Song> songs)
        {
            List<Song> oneHitWonders = new List<Song>();

            var temp1 = songs.GroupBy(s => s.Artist).Where(b => b.Count() == 1).ToList();
                        
            foreach(var v in temp1)
            {
                oneHitWonders.AddRange(songs.Where(a => a.Artist == v.Key).ToList());
                    
            }
            return oneHitWonders;
        }
    }

    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
    }


    public class Program
    {
        public static void Main()
        {
            Song song1 = new Song()
            {
                Id = 1,
                Name = "n1",
                Artist = "ed sheeran"
            };

            Song song2 = new Song()
            {
                Id = 2,
                Name = "n2",
                Artist = "bob"
            };

            Song song3 = new Song()
            {
                Id = 3,
                Name = "n3",
                Artist = "ed sheeran"
            };

            Song song4 = new Song()
            {
                Id = 4,
                Name = "n4",
                Artist = "bob"
            };

            Song song5 = new Song()
            {
                Id = 5,
                Name = "n5",
                Artist = "james"
            };

            List<Song> songs = new List<Song>()
            {
                song1,
                song2,
                song3,
                song4,
                song5
            };

            List<Song> oneHitList = OneHitWonders.NewDetermineOneHitWonders(songs);

            foreach (var item in oneHitList)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Artist);
            }




        }

    }

    public enum Names
    {
        Agent47 = 101,
        IllidanStormrage = 102, 
        MasterChief = 103,
        Warden = 104 
    }


    public class SavingsCustomer : Customer
    {

    }

    public class Customer 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


        #region
        public string FirstName { get; set; }
        public string LastName { get; set; }


        
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Customer))
            {
                return false;
            }

            return 
                this.FirstName == ((Customer)obj).FirstName &&
                this.LastName == ((Customer)obj).LastName;

        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();

        }

        public void AddNumbers(int firstNumber, int secondNumber, [Optional] params int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;

            if (restOfNumbers != null)
            {
                foreach (int number in restOfNumbers)
                {
                    result += number;
                }
            }

            Console.WriteLine("Sum = " + result);

        }
        #endregion

    }





}



