namespace BCDT.Core.Constants
{
    public static class Message
    {
        public static class NhomQuyen
        {
            public const string NQ_NotFound = "Nhóm quyền không tồn tại.";

            #region Cán bộ - nhóm quyền
            public const string CB_NQ_Add = "Thêm cán bộ vào nhóm quyền thành công.";
            public const string CB_NQ_Delete = "Xóa cán bộ khỏi nhóm quyền thành công.";
            #endregion
            #region Menu - nhóm quyền
            public const string NQ_M_DS = "Lấy danh sách thành công.";
            public const string NQ_M_Add = "Thêm menu vào nhóm quyền thành công.";
            public const string NQ_M_Xoa = "Xóa menu khỏi nhóm quyền thành công.";
            #endregion

        }
        public static class CanBo
        {
            public const string CB_NotFound = "Không tìm thấy cán bộ.";
            public const string CB_AddToUser = "Thêm cán bộ thành công.";
            public const string CB_Delete = "Xóa cán bộ thành công.";
            public const string CB_List = "Lấy danh sách cán bộ thành công.";
        }
        public static class User
        {
            public const string U_NotFound = "Không tìm thấy User.";
            public const string U_Active = "Thay đổi trạng thái user thành công";
            public const string U_User_InActive = "Tài khoản đang bị khóa.";
        }
    }
}
