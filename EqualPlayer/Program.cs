using System;
using System.Security.Principal;
using EqualPlayer;
using Microsoft.VisualBasic;
using System.Collections.Generic;
namespace EqualPlayer
{
    public class Program
    {
        private static void Main(string[] args)
        {
            HashSet<Player> setOfPlayers = new()
            {
                new Player(PlayerClass.Tank, "Ana"),
                new Player(PlayerClass.Slayer, "Paulo"),
                new Player(PlayerClass.Tank, "Ana")
            };
        
            foreach (Player i in setOfPlayers)
            {
                Console.WriteLine($"{i.Name} is a {i.PClass}" );
            }

        }
    }
    public enum PlayerClass
    {
        Tank,Fighter,Slayer,Mage,Controller,Marksmen
    }
    public class Player
    {
        public PlayerClass PClass {get;}
        public string Name {get;}
        public Player (PlayerClass pClass, string name)
        {
            PClass = pClass;
            Name = name;
        }

    
        public override bool Equals(object other)
        {
           // Player.otherPlayer = other as Player;
            Player otherPlayer = other as Player;
            if  (other is null) return false;
            if (Name.Equals(otherPlayer.Name)&& PClass.Equals(otherPlayer.PClass))
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return PClass.GetHashCode() ^ Name.GetHashCode();
        }

        
    }
} //Player1.Equals(Player2)


