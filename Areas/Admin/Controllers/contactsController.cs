using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Models;
using Microsoft.AspNetCore.Authorization;
using WebApplication3.Data;
using WebApplication3.Models;

namespace cafeSite2.Areas.admin.Controllers
{
	[Area("admin")]
	[Authorize]

	public class contactsController : Controller
	{
		private readonly ApplicationDbContext _context;

		public contactsController(ApplicationDbContext context)
		{
			_context = context;
		}

		// GET: admin/contacts
		public async Task<IActionResult> Index()
		{
			return View(await _context.contacts.ToListAsync());
		}

		// GET: admin/contacts/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var contacts = await _context.contacts
				.FirstOrDefaultAsync(m => m.id == id);
			if (contacts == null)
			{
				return NotFound();
			}

			return View(contacts);
		}

		// GET: admin/contacts/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: admin/contacts/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("id,name,eMail,mesaj,telefon,Tarih")] contact contacts)
		{
			if (ModelState.IsValid)
			{
				_context.Add(contacts);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(contacts);
		}

		// GET: admin/contacts/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var contacts = await _context.contacts.FindAsync(id);
			if (contacts == null)
			{
				return NotFound();
			}
			return View(contacts);
		}

		// POST: admin/contacts/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("id,name,eMail,mesaj,telefon,Tarih")] contact contacts)
		{
			if (id != contacts.id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(contacts);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!contactsExists(contacts.id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(contacts);
		}

		// GET: admin/contacts/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var contacts = await _context.contacts
				.FirstOrDefaultAsync(m => m.id == id);
			if (contacts == null)
			{
				return NotFound();
			}

			return View(contacts);
		}

		// POST: admin/contacts/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var contacts = await _context.contacts.FindAsync(id);
			if (contacts != null)
			{
				_context.contacts.Remove(contacts);
			}

			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool contactsExists(int id)
		{
			return _context.contacts.Any(e => e.id == id);
		}
	}
}