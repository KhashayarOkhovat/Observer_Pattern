

using PracticalExpamle_For_Teaching.Infrustructure;
using PracticalExpamle_For_Teaching.Services;

using var context = new ApplicationDbContext();

// ایجاد سرویس اطلاع‌رسانی
var notificationService = new NotificationService(context);

// تغییر وضعیت موجودی کالا
await notificationService.UpdateProductStockAsync(1, true);