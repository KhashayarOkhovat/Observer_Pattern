
using SimpleExample_For_Teaching.Services;

// ایجاد ایستگاه هواشناسی
var weatherStation = new WeatherStation();

// ایجاد مشاهدکنندگان
var farmer = new Farmer();
var fisherman = new Fisherman();

// اضافه کردن مشاهدکنندگان به لیست ایستگاه
weatherStation.Attach(farmer);
weatherStation.Attach(fisherman);

// تغییر وضعیت آب‌وهوا
weatherStation.WeatherData = "Sunny";
weatherStation.WeatherData = "Rainy";

// حذف یکی از مشاهدکننده‌ها
weatherStation.Detach(farmer);

// تغییر وضعیت دوباره
weatherStation.WeatherData = "Windy";

Console.ReadKey();