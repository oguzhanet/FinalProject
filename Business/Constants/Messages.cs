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
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürün listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla on ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde bir ürün eklidir tekrar eklenemez";
        public static string CategoryLimitExceded ="Kategori limiti aşıldığı için yeni ürün eklenemedi";
        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string UserRegistered= "Kullanıcı başarıyla kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string ProductUpdated = "Ürün güncellendi";
    }
}
