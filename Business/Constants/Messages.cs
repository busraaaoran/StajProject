using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string CarLicencePlateAlreadyExists = "Sistemde aynı plakaya sahip bir araba zaten var!";
        public static string CarImageAdded = "Araba resmi eklendi.";
        public static string CarImageDeleted = "Araba resmi silindi.";
        public static string CarImageUpdated = "Araba resmi güncellendi.";
        public static string ImagesListed = "Resimler listelendi.";
        public static string CarImageLimitExceeded = "Bir arabaya ait en fazla 10 resim yükleyebilirsiniz!";
        public static string AuthorizationDenied = "İşlem için yetkiniz bulunmamaktadır!";
        public static string CustomerRegistered = "Müşteri kaydoldu.";
        public static string CustomerNotFound = "Müşteri bulunamadı.";
        public static string CustomerAlreadyExists = "Müşteri zaten kayıtlı.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string PasswordError = "Şifre hatası!";
        public static string ColorsListed = "Renkler listelendi.";
        public static string CustomersListed = "Müşteriler listelendi.";
        public static string BrandsListed = "Markalar listelendi.";
        public static string CarServicesListed = "Araba servisleri listelendi.";
    }
}
