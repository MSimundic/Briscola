namespace Briscola.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
public class User
{
    [Key]
    public int Id { get; set; }

    public string Name { get; } = null!;

    public int Elo { get; set; }

    public string passHash { get; } = null!;
    public User(
        int id,
        string name,
        string passHash,
        int elo)
    {
        Id = id;
        Name = name;
        Elo = 1500;
        this.passHash = passHash;
    }

    public User(){}
}