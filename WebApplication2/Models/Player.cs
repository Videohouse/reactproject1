namespace WebApplication2.Models
{
    public class Player
    {
        public string Role { get; set; } = null!;
        public string Nr { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string LineupName { get; set; } = null!;

        public Player(string role, string nr, string name, string lineupName)
        {
            this.Role = role;
            this.Nr = nr;
            this.Name = name;
            this.LineupName = lineupName;
        }
    }
}
