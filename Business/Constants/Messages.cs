using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AppointmentScheduled = "Randevu alındı.";
        public static string CustomerIdInvalid = "Müşteri no 100den büyük olamaz.";
        public static string MaintenanceTime = "Sistem Bakımda.";
        public static string ApptsListed = "Randevular Listelendi.";
        public static string ApptDeleted = "Randevu silindi.";
        public static string ApptUpdated = "Randevu Bilgisi Güncellendi.";
        public static string BrandAdded = "Marka Eklendi.";
        public static string BrandDeleted = "Marka Silindi.";
        public static string BrandUpdated = "Marka Bilgisi Güncellendi.";
        public static string CarAdded = "Araba Eklendi.";
        public static string CarDeleted = "Araba Silindi.";
        public static string CarUpdated = "Araba Bilgisi Güncellendi.";
        public static string CarServiceAdded = "Araba Servisi Eklendi.";
        public static string CarServiceDeleted = "Araba Servisi Silindi.";
        public static string CarServiceUpdated = "Araba Servis Bilgisi Güncellendi.";
        public static string ColorAdded = "Renk Eklendi.";
        public static string ColorDeleted = "Renk Silindi.";
        public static string ColorUpdated = "Renk Bilgisi Güncellendi.";
        public static string CustomerUpdated = "Müşteri Bilgisi Güncellendi.";
        public static string CustomerAdded = "Müşteri Eklendi.";
        public static string CustomerDeleted = "Müşteri Silindi.";
        public static string CarsListed = "Arabalar listelendi.";
        public static string CarInfoDisplayed = "Araba bilgisi listelendi";
        public static string CarBrandCountError = "Bir markaya ait 50den fazla araba olamaz!";
        internal static string CarLicencePlateAlreadyExists = "Sistemde aynı plakaya sahip bir araba zaten var!";
        internal static string CarImageAdded;
        internal static string CarImageDeleted;
        internal static string CarImageUpdated;
        internal static string ImagesListed;
        internal static string CarImageLimitExceeded;
    }
}
