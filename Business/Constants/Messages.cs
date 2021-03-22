using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Eklendi";
        public static string Error = "İsim geçersiz veya fiyat 0 dan büyük olmalı.";
        public static string Deleted = "Başarıyla Silindi";
        public static string Information = "Sistem Pazar Günleri Kapalı";
        public static string Listed = "Listelendi";
        public static string Updated = "Güncellendi";
        public static string NameError = "İsim alanları boş geçilemez";
        public static string MailError = "Geçersiz E-Mail";
        public static string Car = "Teslim edilmemiş araba";
        public static string Deliver = "Araba Teslim edildi";
        public static string TakeDelivery = "Araba Teslim alındı";
    }
}
