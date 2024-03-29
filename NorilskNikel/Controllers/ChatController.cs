﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorilskNikel.EF;

namespace NorilskNikel.Controllers
{
    public class ChatController : Controller
    {
        // GET: ChatController
        public List<ChatMessages> Messages(int categoryId)
        {
            var db = new NornikelContext();
            return db.chatMessages.Where(x => x.IdCategory == categoryId).OrderByDescending(x => x.dateTime).ToList();

          //  return View();
        }
        public void AddMessage(string message, int categoryId, string author)
        {
            var db = new NornikelContext();
           db.chatMessages.Add(new ChatMessages { dateTime = DateTime.Now, Text = message, Name = author, IdCategory = categoryId });
           db.SaveChanges();
        }
    }
}
