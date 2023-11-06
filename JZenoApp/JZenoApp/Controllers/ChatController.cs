using JZenoApp.Hubs;
using JZenoApp.Data;
using JZenoApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;

namespace JZenoApp.Controllers
{
    public class ChatController : Controller
    {
        private readonly JZenoDbContext _context;
        private readonly IHubContext<SignalHub> _hubContext;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public ChatController(JZenoDbContext context, IHubContext<SignalHub> hubContext, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _context = context;
            _hubContext = hubContext;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            var jZsChatDbContext = await _context.Chat.Include(c => c.Receiver).Include(c => c.Sender).Include(e => e.chats).Where(e => e.senderId == _userManager.GetUserId(User) || e.receiverId == _userManager.GetUserId(User)).ToListAsync();
            return View(jZsChatDbContext);

        }
        public async Task<IActionResult> ChatBar()
        {
            var jZsChatDbContext = await _context.Chat.Include(c => c.Receiver).Include(c => c.Sender).Include(e => e.chats).Where(e => e.senderId == _userManager.GetUserId(User) || e.receiverId == _userManager.GetUserId(User)).ToListAsync();
            return PartialView("ChatBar", jZsChatDbContext);
        }

        public async Task<IActionResult> Message(string id)
        {
            var jZsChatDbContext = _context.Chat.Include(c => c.Receiver).Include(c => c.Sender).Include(e => e.chats).Where(e => e.senderId == _userManager.GetUserId(User) || e.receiverId == _userManager.GetUserId(User));
            ViewData["GetChat"] = jZsChatDbContext;
            if (id == null || _context.Chat == null)
            {
                return NotFound();
            }
            var chat = await _context.Chat
                .Include(c => c.Receiver)
                .Include(c => c.Sender)
                .Include(c => c.chats)
                .FirstOrDefaultAsync(m => m.id == id);
            if (chat == null)
            {
                return NotFound();
            }
            await _hubContext.Clients.All.SendAsync("ReceiveMessage");
            return View(chat);
        }
        public JsonResult GetMessage(string id)
        {
            var jZsChatDbContext = _context.ChatDetail.Include(e => e.Chat).ThenInclude(e => e!.Receiver).Include(e => e.Chat).ThenInclude(e => e.Sender).Where(e => e.Chat!.id == id);

            return Json(jZsChatDbContext);
        }
        public JsonResult AddMessage(string chatId, string chatMessage)
        {
            try
            {
                if (chatMessage != null || chatId != null)
                {
                    ChatDetails chat = new ChatDetails
                    {
                        chatId = chatId,
                        message = chatMessage,
                        sendDate = DateTime.Now,
                        senderId = _userManager.GetUserAsync(User).Result!.Id
                    };
                    _context.Add(chat);
                    _context.SaveChanges();
                    _hubContext.Clients.All.SendAsync("ReceiveMessage");
                    return Json(chat);
                }
            }
            catch (Exception e)
            {
                return Json(e.ToString());
            }
            return Json("Không thành công");
        }
        public IActionResult Create()
        {
            ViewData["receiverId"] = new SelectList(_context.Users, "Id", "fullName");
            ViewData["senderId"] = new SelectList(_context.Users, "Id", "fullName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,isActive,nameActive,senderId,receiverId")] Chat chat)
        {
            if (ModelState.IsValid)
            {
                chat.isActive = false;
                chat.nameActive = "";
                chat.id = chat.senderId + "-" + chat.receiverId;
                _context.Add(chat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["receiverId"] = new SelectList(_context.Users, "Id", "fullName", chat.receiverId);
            ViewData["senderId"] = new SelectList(_context.Users, "Id", "fullName", chat.senderId);
            return View(chat);
        }
        [HttpPost]
        public async Task<JsonResult> AddChat(string senderId, string receiverId)
        {
            try
            {
                var sender = await _context.User.FindAsync(senderId);
                var receiver = await _context.User.FindAsync(receiverId);
                Chat jzChat = new Chat();
                jzChat.id = senderId + "_" + receiverId;
                jzChat.senderId = senderId;
                jzChat.receiverId = receiverId;
                jzChat.isActive = false;
                jzChat.nameActive = "";
                jzChat.Sender = sender;
                jzChat.Receiver = receiver;
                _context.Add(jzChat);
                await _context.SaveChangesAsync();
                return Json(jzChat);
            }
            catch (Exception e)
            {
                return Json(e);
            }
        }
    }
}
