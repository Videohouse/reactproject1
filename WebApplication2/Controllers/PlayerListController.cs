using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using System.Globalization;
using System.Text;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/playerlist")]
    public class PlayerListController : ControllerBase
    {
        private readonly PlayerContext _context;

        public PlayerListController(PlayerContext context)
        {
            _context = context;
        }
        // GET: api/playerlist/Anderlecht
        [HttpGet("{name}")]
        public async Task<ActionResult<List<Player>>> GetPlayerList(string name)
        {
            if (_context.Player == null)
            {
                return NotFound();
            }
            List<Player> playerList = new List<Player>();
            var role = "";

            using (var reader = new StreamReader("K:/PLAY SPORTS/1. ALGEMEEN/PLOEGEN/JPL/" + name + ".csv", Encoding.GetEncoding("ISO-8859-1")))
            using (var csv = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();

                while (csv.Read())
                {
                    var record = csv.GetRecord<Player>();
                    if (record.Role == "")
                    {
                        record.Role = role;
                    }
                    else
                    {
                        role = record.Role;
                    }
                    if (record.Role != "") playerList.Add(record);
                }
            }


            if (playerList == null)
            {
                return NotFound();
            }

            return playerList;
        }

    }
}
