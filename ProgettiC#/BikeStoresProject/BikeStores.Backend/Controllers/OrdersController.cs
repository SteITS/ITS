using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BikeStores.Data.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace BikeStores.Backend.Controllers
{
    [Authorize(Roles = "Administrators, Employees,Customers")]
    public class OrdersController : Controller
    {
        private readonly BikeStoresContext _context;

        public OrdersController(BikeStoresContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index(string status)
        {

            var bikeStoresContext = _context.Orders.Include(o => o.Customer).Include(o => o.OrderStatusNavigation).Include(o => o.Staff).Include(o => o.Store).OrderByDescending(d => d.OrderDate).AsQueryable();
            var userMail = User.FindFirstValue(ClaimTypes.Email);
            if (User.IsInRole("Employees"))
            {
                bikeStoresContext = bikeStoresContext.Where(p=>p.Staff.Email.Equals(userMail));
            }
            if (User.IsInRole("Customers"))
            {
                bikeStoresContext = bikeStoresContext.Where(p => p.Customer.Email.Equals(userMail));
            }
            if (!string.IsNullOrEmpty(status))
            {
                bikeStoresContext = bikeStoresContext.Where(x => x.OrderStatusNavigation.StatusDescription == status);
                var statuses = bikeStoresContext.Select(x => x.OrderStatusNavigation.StatusDescription).ToList();
            }
            ViewBag.Status = _context.OrderStatuses
        .Select(os => os.StatusDescription)
        .ToList();
            ViewBag.SelectedStatus = status;
            return View(await bikeStoresContext.ToListAsync());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.OrderStatusNavigation)
                .Include(o => o.Staff)
                .Include(o => o.Store)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "Email");
            ViewData["OrderStatus"] = new SelectList(_context.OrderStatuses, "StatusId", "StatusDescription");
            ViewData["StaffId"] = new SelectList(_context.Staffs, "StaffId", "Email");
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreName");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,CustomerId,OrderStatus,OrderDate,RequiredDate,ShippedDate,StoreId,StaffId")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "Email", order.CustomerId);
            ViewData["OrderStatus"] = new SelectList(_context.OrderStatuses, "StatusId", "StatusDescription", order.OrderStatus);
            ViewData["StaffId"] = new SelectList(_context.Staffs, "StaffId", "Email", order.StaffId);
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreName", order.StoreId);
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "Email", order.CustomerId);
            ViewData["OrderStatus"] = new SelectList(_context.OrderStatuses, "StatusId", "StatusDescription", order.OrderStatus);
            ViewData["StaffId"] = new SelectList(_context.Staffs, "StaffId", "Email", order.StaffId);
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreName", order.StoreId);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,CustomerId,OrderStatus,OrderDate,RequiredDate,ShippedDate,StoreId,StaffId")] Order order)
        {
            if (id != order.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderId))
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
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "Email", order.CustomerId);
            ViewData["OrderStatus"] = new SelectList(_context.OrderStatuses, "StatusId", "StatusDescription", order.OrderStatus);
            ViewData["StaffId"] = new SelectList(_context.Staffs, "StaffId", "Email", order.StaffId);
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreName", order.StoreId);
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.OrderStatusNavigation)
                .Include(o => o.Staff)
                .Include(o => o.Store)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderId == id);
        }
    }
}
