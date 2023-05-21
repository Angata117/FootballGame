using System;
using System.Collections.Generic;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach t1Coach = new Coach("Steve", 45);
            Goalkeeper t1Goalkeeper = new Goalkeeper("Gosho Vasilev", 35, 1, 184);
            Defender t1Defender1 = new Defender("Vasko", 30, 5, 180);
            Defender t1Defender2 = new Defender("Mitko", 25, 6, 182);
            Defender t1Defender3 = new Defender("Angel", 28, 7, 185);
            Defender t1Defender4 = new Defender("Viktor", 30, 8, 178);
            Midfield t1Midfield1 = new Midfield("Strahil", 24, 9, 184);
            Midfield t1Midfield2 = new Midfield("Ivan", 26, 10, 180);
            Midfield t1Midfield3 = new Midfield("Dragan", 27,12, 184);
            Striker t1Striker1 = new Striker("Rondalno", 38, 11, 185);
            Striker t1Striker2 = new Striker("Kristian", 34, 13, 183);
            Striker t1Striker3 = new Striker("Runi", 41, 14, 181);
            List<FootbalPlayer> team1Players = new List<FootbalPlayer>
            {
                t1Goalkeeper,
                t1Defender1,
                t1Defender2,
                t1Defender3,
                t1Defender4,
                t1Midfield1,
                t1Midfield2,
                t1Midfield3,
                t1Striker1,
                t1Striker2,
                t1Striker3,
            };
            Team team1 = new Team(t1Coach, team1Players);

            Coach t2Coach = new Coach("Matt", 40);
            Goalkeeper t2Goalkeeper = new Goalkeeper("Peter Cheh", 38, 4, 190);
            Defender t2Defender1 = new Defender("Djoko", 30, 5, 180);
            Defender t2Defender2 = new Defender("Karata", 25, 6, 182);
            Defender t2Defender3 = new Defender("Kiril", 28, 7, 185);
            Defender t2Defender4 = new Defender("Petko", 30, 8, 178);
            Midfield t2Midfield1 = new Midfield("Niki", 24, 9, 184);
            Midfield t2Midfield2 = new Midfield("Strinko", 26, 10, 180);
            Midfield t2Midfield3 = new Midfield("Goshko", 27, 12, 184);
            Striker t2Striker1 = new Striker("Messi", 38, 11, 185);
            Striker t2Striker2 = new Striker("Neymar", 34, 13, 183);
            Striker t2Striker3 = new Striker("Mbappe", 41, 14, 181);

            List<FootbalPlayer> team2Players = new List<FootbalPlayer>
            {
                t2Goalkeeper,
                t2Defender1,
                t2Defender2,
                t2Defender3,
                t2Defender4,
                t2Midfield1,
                t2Midfield2,
                t2Midfield3,
                t2Striker1,
                t2Striker2,
                t2Striker3,
            };
            Team team2 = new Team(t2Coach, team2Players);
            Referee MainReferee = new Referee("Georgi", 37);
            Referee Assistant1 = new Referee("Stoyan", 35);
            Referee Assistant2 = new Referee("Zlatko", 34);

            Game game = new Game(team1, team2, MainReferee);
            game.AddGoal(10, t1Striker1);
            game.AddGoal(60, t1Striker2);
            game.AddGoal(90, t1Striker1);

            game.AddGoal(42, t2Striker1);
            game.AddGoal(70, t2Striker3);
            game.AddGoal(23, t2Striker3);
            game.PrintResult();
        }
    }
}
