using System.Collections.Generic;

namespace BCDT.Core.Constants
{
    public static class Constants
    {
        public static class AuthConfig
        {
            public const string CheckPass = nameof(CheckPass);
            public const string HashSalt = nameof(HashSalt);

            public static string MinLength = nameof(MinLength);
        }

        public static class MessageResponse
        {
            public const string DuplicateName = "Tên đã bị trùng. Vui lòng đổi tên khác!";
            public const string DuplicateCode = "Mã đã bị trùng. Vui lòng đổi mã khác!";
            public const string NotFound = "Không tồn tại id : ";
            public const string UploadImageFailed = "Tải ảnh lên thất bại.";
            public const string WrongImageType = "Loại ảnh truyền lên không đúng.";
            public const string ConvertToListFailed = "Danh sách truyền vào không hợp lệ.";
            public const string HasChildItem = "Có đơn vị con không thể xóa.";
        }
        public static class CodeError
        {
            public const string Duplicate = "G001";
            public const string NotFound = "G002";
            public const string UploadFailed = "G003";
            public const string WrongType = "G004";
            public const string HasChildItem = "G005";
        }
        public static class ImageType
        {
            public const int AnhDaiDien = 1;
            public const int AnhChuKy = 2;
            public const int AnhChuKyNhay = 3;
        }
        public static class KieuDonViType
        {
            public const int DonVi = 1;
            public const int PhongBan = 2;
            public const int PhongBanAo = 3;
        }
        public static class FolderName
        {
            public const string Attachments = nameof(Attachments);
        }
        public static class FolderFtp
        {
            public const string ParentFolder = "Common";
            public const string AnhDaiDien = nameof(AnhDaiDien);
            public const string AnhChuKy = nameof(AnhChuKy);
            public const string AnhChuKyNhay = nameof(AnhChuKyNhay);
        }
        public static class FtpInformation
        {
            public const string FtpHost = "ftp_host";
            public const string FtpUserName = "ftp_username";
            public const string FtpPassword = "ftp_password";
            public const string FtpFile = "ftp_file";
        }
        public static class LdapInformation
        {
            public const string Ldap1 = nameof(Ldap1);
            public const string Ldap2 = nameof(Ldap2);
        }

        public static class Default
        {
            public const int GetAllPaging = 1000;
            public const int UnitLevel = 1;
            public const int ParentUnitId = 1;
        }
        public static class Other
        {
            public const string CryptoKey = "crypto_key";
            public const string DefaultPassword = "DefaultPassword";
        }
        public static Dictionary<int, string> TypeOfUpload()
        {
            return new Dictionary<int, string>()
            {
                {1,"AnhDaiDien_FilePath"},
                {2,"AnhChuKy_FilePath"},
                {3,"AnhChuKyNhay_FilePath"},
            };
        }
    }
}
