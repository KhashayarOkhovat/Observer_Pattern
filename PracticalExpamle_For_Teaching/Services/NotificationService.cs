using Microsoft.EntityFrameworkCore;
using PracticalExpamle_For_Teaching.Infrustructure;

namespace PracticalExpamle_For_Teaching.Services
{
    public class NotificationService
    {
        private readonly ApplicationDbContext _context;

        public NotificationService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task UpdateProductStockAsync(int productId, bool isInStock)
        {
            // پیدا کردن محصول
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new Exception("Product not found");

            // بررسی تغییر وضعیت
            if (product.IsInStock == isInStock)
            {
                Console.WriteLine($"Product {product.Name} stock status unchanged.");
                return;
            }

            // بروزرسانی وضعیت
            product.IsInStock = isInStock;
            _context.Products.Update(product);
            await _context.SaveChangesAsync();

            Console.WriteLine($"Product {product.Name} stock status updated to {(isInStock ? "In Stock" : "Out of Stock")}.");

            // اگر موجود شد، اعلان بفرست
            if (isInStock)
            {
                await NotifyUsersAsync(productId);
            }
        }
        private async Task NotifyUsersAsync(int productId)
        {
            // پیدا کردن کاربران مرتبط
            var notifications = await _context.Notifications
                .Include(n => n.User)
                .Where(n => n.ProductID == productId)
                .ToListAsync();

            foreach (var notification in notifications)
            {
                Console.WriteLine($"Sending email to {notification.User!.Email}: {notification.Product!.Name} is now in stock!");
                // TODO: ارسال ایمیل
            }
        }
    }
}
