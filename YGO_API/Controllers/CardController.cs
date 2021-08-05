using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YGO_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YGO_API.Controllers
{
    [Route("api/[controller]")]
    public class CardController : Controller
    {
        private readonly YGO_DatabaseContext Card;
        
        public CardController(YGO_DatabaseContext card)
        {
            Card = card;
        }
        // GET: api/<controller>
        [HttpGet("No")]
        public IEnumerable<CardData> Get_by_No(string Card_No)
        {
            var result = from a in Card.CardData
                         where a.No == Card_No
                         select a;
            return result;
        }
        [HttpGet("Data")]
        public IEnumerable<CardData> Get(string? Card_name, string? Card_type, string? Card_level,string? Card_attribute,string? Card_race,string? Card_atk,string? Card_def)
        {
            var result = from a in Card.CardData
                         select a;
            if(Card_name!=null)
                result = result.Where(a => a.Name.Contains(Card_name));
            if (Card_type != null)
                result = result.Where(a => a.Type == Card_type);
            if (Card_level != null)
                result = result.Where(a => a.Level == Card_level);
            if (Card_attribute != null)
                result = result.Where(a => a.Attribute == Card_attribute);
            if (Card_race != null)
                result = result.Where(a => a.Race == Card_race);
            if (Card_atk != null)
                result = result.Where(a => a.Atk == Card_atk);
            if (Card_def != null)
                result = result.Where(a => a.Def == Card_def);
            result = result.Take(5);
            return result;
        }
    }
}
