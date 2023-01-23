namespace Briscola.Model;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class GameResult
{
    [Key]
    public int Id { get; set; }

    public int IdPlayer1 { get; }

    public int IdPlayer2 { get; }

    public int Player1Points{get; set; }
    public int Player2Points{get; set; }
    public GameResult(
        int id,
        int idPlayer1,
        int idPlayer2)
    {
        Id = id;
        IdPlayer1 = idPlayer1;
        IdPlayer2 = idPlayer2;
        Player1Points = 0;
        Player2Points = 0;
    }

    public GameResult() { }


}