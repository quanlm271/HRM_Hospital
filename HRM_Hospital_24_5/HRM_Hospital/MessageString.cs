using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_Hospital
{
    class MessageString
    {
        public string get_fail = "Lấy dữ liệu thất bại !";
        public string check_fail = "Kiểm tra dữ liệu thất bại !";

        public string fields_not_fill = "Vui lòng điền đủ thông tin !";

        public string insert_success = "Thêm mới thành công !";
        public string delete_success = "Xoá thành công !";
        public string update_success = "Cập nhật thành công !";

        public string finish = "Hoàn tất !";

        public string insert_fail = "Thêm mới thất bại !";
        public string delete_fail = "Xoá thất bại !";
        public string update_fail = "Cập nhật thất bại !";

        public string invalid = " không hợp lệ!, vui lòng thử lại !";

        public string login_success = "Đăng nhập thành công !";
        public string login_fail = "Đăng nhập thất bại, vui lòng thử lại !";

        public string check_login_fail = "Kiểm tra đăng nhập thất bại.";
    }
}
