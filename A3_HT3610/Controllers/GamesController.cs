//Name: Harshal Thavrani
//    Student Id: 8733610
//    Assignment 3 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using A3_HT3610.Data;

namespace A3_HT3610.Models
{
    public class GamesController : Controller
    {
        private readonly AuditContext _context;
        private const string sessionGame = "Game";
        private const string cookieplayer = "Player";
        public GamesController(AuditContext context)
        {
            _context = context;
        }

        // GET: Games
        public IActionResult Index()
        {
            return View();
        }

        // This is the Play Action where the "Actual Game Works"
        public async Task<IActionResult> Play(int? idxtile)
        {
            //Decalring objects and initializing the strings
            Player knownplayer = null;
            string playerCookie = Request.Cookies[cookieplayer];
            if (!string.IsNullOrEmpty(playerCookie))
            {
                knownplayer = JsonConvert.DeserializeObject<Player>(playerCookie);
            }
            if (knownplayer == null)
            {
                return RedirectToAction("Join");
            }

            //Gets the game from session
            string gamestring = HttpContext.Session.GetString(sessionGame);
            //Desearlizing the object 
            Game currentgame = JsonConvert.DeserializeObject<Game>(gamestring);

            if (idxtile != null)
            {
                currentgame.RevealTile((int)idxtile);
                if (currentgame.GamePointMessage == "You Lose")
                {
                    //Audit Data For Lose
                    Audit currentAudit = new Audit();
                    currentAudit.AuditTypeId = 4;
                    currentAudit.PlayerName = knownplayer.PlayerName;
                    currentAudit.CreatedDate = DateTime.Now;
                    currentAudit.Amount = Convert.ToDouble(currentgame.GameCoins.ToString("N2"));
                    _context.Add(currentAudit);
                    await _context.SaveChangesAsync();
                }
                currentgame.GameCoins = currentgame.GameCoins * currentgame.tiles[(int)idxtile].Value;
            }
            
            ViewData["PlayerName"] = currentgame.Player.PlayerName;
            ViewData["TotalCoins"] = currentgame.Player.TotalCoins.ToString("N2");
            ViewData["GameCoins"] = currentgame.GameCoins.ToString("N2");
            ViewData["cashoutcoins"] = currentgame.GameCoins + currentgame.Player.TotalCoins;
            //Serializing the Game
            gamestring = JsonConvert.SerializeObject(currentgame);
            //Sets the session
            HttpContext.Session.SetString(sessionGame, gamestring);

            if (idxtile != null)
            {
                if (currentgame.tiles[(int)idxtile].Value == 0)
                {
                    TempData["alertmessage"] = $"Oh no! You busted out. Better luck next time!";
                    
                }
                if (currentgame.tiles[(int)idxtile].Value != 0)
                {
                    //Audit Data For Win
                    Audit currentAudit = new Audit();
                    currentAudit.AuditTypeId = 3;
                    currentAudit.PlayerName = knownplayer.PlayerName;
                    currentAudit.CreatedDate = DateTime.Now;
                    currentAudit.Amount = Convert.ToDouble(currentgame.GameCoins.ToString("N2"));
                    _context.Add(currentAudit);
                    await _context.SaveChangesAsync();
                    TempData["alertmessage"] = $"Congrats you’ve found a {currentgame.tiles[(int)idxtile].Value.ToString("N2")} multipler!  All remaining values have doubled.  Will you Press Your Luck?";
                }

            }

            return View(currentgame);
        }

        // This is the start method which takes the wager amount from the player to start the game
        public async Task<IActionResult> Start()
        {
            //Decalring objects and initializing the strings
            Game game = new();
            Player knownplayer = null;
            string playerCookie = Request.Cookies[cookieplayer];
            string gamestring = HttpContext.Session.GetString(sessionGame);
            //If null or empty string then deserialize it
            if (!string.IsNullOrEmpty(playerCookie))
            {
                knownplayer = JsonConvert.DeserializeObject<Player>(playerCookie);
            }
            //If object null then takes the player back to the welcome page
            if (knownplayer == null)
            {
                return RedirectToAction("Join");
            }
            //This condition helps storing the player data into a cookie
            if (!string.IsNullOrEmpty(gamestring))
            {
                Game currentgame = JsonConvert.DeserializeObject<Game>(gamestring);
                if (currentgame != null)
                {
                    knownplayer.TotalCoins += currentgame.GameCoins;
                    var options = new CookieOptions { Expires = DateTime.Now.AddDays(1) };
                    string playerstring = JsonConvert.SerializeObject(knownplayer);
                    Response.Cookies.Append(cookieplayer, playerstring, options);
                }
               
            }
            var choice = new CookieOptions { Expires = DateTime.Now.AddDays(1) };
            Response.Cookies.Append("cashoutcoin", knownplayer.TotalCoins.ToString("N2"),choice);
            Response.Cookies.Append("takeoutcoin", game.GameCoins.ToString("N2"), choice);
            ViewData["PlayerName"] = knownplayer.PlayerName;
            ViewData["TotalCoins"] = knownplayer.TotalCoins.ToString("N2");
            return View();
        }



        //This Post Start method takes player to the Game provided if he has entered the current data

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Start([Bind("Id,GameCoins,GamePoint,GamePointMessage")] Game currentgame)
        {
            if (ModelState.IsValid)
            {
                //Decalring objects and initializing the strings
                Player currentplayer = null;
                string playerCookie = Request.Cookies[cookieplayer];
                //If null or empty string then deserialize it
                if (!string.IsNullOrEmpty(playerCookie))
                {
                    currentplayer = JsonConvert.DeserializeObject<Player>(playerCookie);
                }
                //If object null then takes the player back to the welcome page
                if (currentplayer == null)
                {
                    return RedirectToAction("Join");
                }
                currentgame.Player = currentplayer;
                //Here we call the start method to help the start the game
                currentgame.Start();
                //Serialize the tiles
                string gamestring = JsonConvert.SerializeObject(currentgame);
                //Sets the session
                HttpContext.Session.SetString(sessionGame, gamestring);
                var options = new CookieOptions { Expires = DateTime.Now.AddDays(1) };
                string playerstring = JsonConvert.SerializeObject(currentplayer);
                Response.Cookies.Append(cookieplayer, playerstring, options);
                Response.Cookies.Append("GameCoins", currentgame.GameCoins.ToString(), options);
                Response.Cookies.Append("TotalCoins", currentgame.Player.TotalCoins.ToString(), options);
                return RedirectToAction("Play");
            }
            return View(currentgame);
        }

        // This is the Get Join Method aka Method that gets the Welcome Page which further
        // takes the player to the wager page in the post method
        public IActionResult Join()
        {
            return View();
        }

        // This Post Join Method takes the player to the Wager Page and also stores the player data into a cookie
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Join([Bind("PlayerName,TotalCoins")] Player player)
        {
            if (ModelState.IsValid)
            {
                //Creating acookie
                var options = new CookieOptions { Expires = DateTime.Now.AddDays(1) };
                //Serializing the object
                string playerstring = JsonConvert.SerializeObject(player);
                //Storing the cookie
                Response.Cookies.Append(cookieplayer, playerstring, options);
                //Audit Data For Cash In
                Audit currentAudit = new Audit();
                currentAudit.AuditTypeId = 1;
                currentAudit.PlayerName = player.PlayerName;
                currentAudit.CreatedDate = DateTime.Now;
                currentAudit.Amount = Convert.ToDouble(player.TotalCoins.ToString("N2"));
                _context.Add(currentAudit);
                await _context.SaveChangesAsync();
                return RedirectToAction("Start");
            }
            return View(player);
        }

        //This Method takes the user back to the Welcome Page and cashes out all the coins
        public async Task<IActionResult> Cashout(Game game, Player player)
        {
            
            string playerCookie = Request.Cookies[cookieplayer];
            player = JsonConvert.DeserializeObject<Player>(playerCookie);
            TempData["alertmessage"] = $"You cashed out for " + "$"+ Convert.ToDouble(player.TotalCoins.ToString("N2")) + " coins.";
            //Audit Data For Cash Out
            Audit currentAudit = new Audit();
            currentAudit.AuditTypeId = 2;
            currentAudit.PlayerName = player.PlayerName;
            currentAudit.CreatedDate = DateTime.Now;
            currentAudit.Amount = Convert.ToDouble(player.TotalCoins.ToString("N2"));
            _context.Add(currentAudit);
            await _context.SaveChangesAsync();
            HttpContext.Session.Remove(sessionGame);
            return RedirectToAction("Join");
        }
         //This Method takes all the coins the user has one
        public IActionResult takeoutcoins(Game game)
        {
            string gamestring = HttpContext.Session.GetString(sessionGame);
            Game currentgame = JsonConvert.DeserializeObject<Game>(gamestring);
            TempData["alertmessage"] = $"BIG WINNER! You chased out for "+"$"+ currentgame.GameCoins.ToString("N2") + " coins!  Care to press your luck again?";
            return RedirectToAction("Start");

        }
    }
}
