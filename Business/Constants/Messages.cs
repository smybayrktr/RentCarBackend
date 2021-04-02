using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Eklendi";
        public static string Deleted = "Silindi";
        public static string Listed = "Listelendi";
        public static string Updated = "Güncellendi";

        public static string ClockInformation = "Sistem Pazar Günleri Kapalı";
        public static string NameError = "İsim alanları boş geçilemez";
        public static string MailError = "Geçersiz E-Mail";

        public static string CarInformation = "Araba işlem dışı";
        public static string Deliver = "Araba Teslim edildi";
        public static string TakeDelivery = "Araba Teslim alındı";

        public static string CarImageAddedMessage = "Araba Resmi Eklendi";
        public static string MoreThanFiveImage = "Bir arabanın 5 ten fazla resmi olamaz.";
    }
}
