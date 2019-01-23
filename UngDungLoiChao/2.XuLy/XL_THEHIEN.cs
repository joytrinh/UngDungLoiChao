using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

public class XL_THEHIEN
{
    public static CultureInfo DinhDangVN = CultureInfo.GetCultureInfo("vi-VN");
    
    public static string TaoChuoiHTMLKhachThamQuan()
    {
        string chuoiHinh = "<img src='../Media/Khach_tham_quan_" + XL_NGHIEPVU.PhatSinh(5) + ".png' width='150' height='150'> <br/>";
        string chuoiThongTin = XL_NGHIEPVU.TaoLoiChaoKhachThamQuan();
        string chuoiHTML = "<div class='btn'>" + $"{chuoiHinh}" + $"{chuoiThongTin}" + 
            "<br/>Đây là Ứng dụng Web<b> dành riêng cho Xử lý thể hiện</b> của tôi </div><br/>" +
            "<div class='btn'> Danh sách các Nhóm hàng hiện nay <br/>";
        return chuoiHTML;
    }
    public static string TaoChuoiHTMLKhachHang(XL_KhachHang KhachHang)
    {
        string chuoiHinh = "<img src='../Media/KHACH_HANG_" + XL_NGHIEPVU.PhatSinh(4) + ".png' width='150' height='150'> <br/>";
        string chuoiThongTin = XL_NGHIEPVU.TaoLoiChaoKhachHang(KhachHang.HoTen);
        string chuoiHTML = "<div class='btn'>" + $"{chuoiHinh}" + $"{chuoiThongTin}" +
            "<br/>Đây là Ứng dụng Web<b> dành riêng cho Xử lý thể hiện</b> của tôi </div><br/>" +
            "<div class='btn'> Danh sách các Nhóm hàng hiện nay <br/>";
        return chuoiHTML;
    }
    public static string TaoChuoiHTMLNhanVien(XL_NHANVIEN NhanVien)
    {
        string chuoiHinh = "<img src='../Media/" + NhanVien.MaSo + ".png' width='150' height='150'> <br/>";
        string chuoiThongTin = XL_NGHIEPVU.TaoLoiChaoNhanVien(NhanVien);
        string chuoiHTML = "<div class='btn'>" + $"{chuoiHinh}" + $"{chuoiThongTin}" +
            "<br/>Đây là Ứng dụng Web<b> dành riêng cho Xử lý thể hiện</b> của tôi<br/>" +
            "Anh Chị đã được phân công " + NhanVien.DanhSachMaSoNhomHang.Count + " Nhóm hàng</div><br/>";
        return chuoiHTML;
    }
    public static string TaoChuoiHTMLQuanLy(XL_QUANLY QuanLy)
    {
        string chuoiHinh = "<img src='../Media/" + QuanLy.MaSo + ".png' width='150' height='150'> <br/>";
        string chuoiThongTin = XL_NGHIEPVU.TaoLoiChaoQuanLy(QuanLy);
        string chuoiHTML = "<div class='btn'>" + $"{chuoiHinh}" + $"{chuoiThongTin}" +
            "<br/>Đây là Ứng dụng Web<b> dành riêng cho Xử lý thể hiện</b> của tôi </div><br/>";
        return chuoiHTML;
    }

    //Tao chuoi HTML Danh sach doi tuong
    public static string TaoChuoiHTMLDanhSachNhomHang(List<XL_NHOMHANG> DanhSachNhomHang)
    {
        string TieuDe = $"<div class='btn'> Danh sách {DanhSachNhomHang.Count} Nhóm hàng<div><br/>";
        string chuoiHTML = "<div class='btn'>";
        DanhSachNhomHang.ForEach(NhomHang =>
        {
            string chuoiHinh = "<div class='btn'> <img src='../Media/" + NhomHang.MaSo + ".png' width='50' height='50'>";
            string chuoiThongTin = "<br/><div>" + NhomHang.Ten + "</div>";
            chuoiHTML += $"{chuoiHinh}" + $"{chuoiThongTin}" + "<br />";
        });
        return TieuDe + chuoiHTML;
    }
    public static string TaoChuoiHTMLDanhSachNhanVien(List<XL_NHANVIEN> DanhSachNhanVien)
    {
        string TieuDe = $"<div class='btn'> Danh sách {DanhSachNhanVien.Count} Nhân viên<div><br/>";
        string chuoiHTML = "<div class='btn'>";
        DanhSachNhanVien.ForEach(NhanVien =>
        {
            string chuoiHinh = "<div class='btn'> <img src='../Media/" + NhanVien.MaSo + ".png' width='50' height='50'>";
            string chuoiThongTin = "<br/><div>" + NhanVien.HoTen + "</div>";
            chuoiHTML += $"{chuoiHinh}" + $"{chuoiThongTin}" + "<br />";
        });
        return TieuDe + chuoiHTML;
    }
    public static string TaoChuoiHTMLCacLanDangNhap(List<DateTime> DanhSachCacLanDangNhap)
    {
        string chuoiHTML_CacLanDangNhap = "<br/><div>Danh sách các lần đăng nhập";
        DanhSachCacLanDangNhap.ForEach(ngay =>
        {
            chuoiHTML_CacLanDangNhap += "<br/>" + ngay.ToString(DinhDangVN);
        });
        chuoiHTML_CacLanDangNhap += "</div>";
        return chuoiHTML_CacLanDangNhap;
    }

    //Tao chuoi HTML thong bao yeu cau dang nhap
    public static string TaoChuoiHTMLThongBaoYeuCauDangNhap()
    {
        string chuoiHTML = "<div>" + "Xin vui lòng Nhập Tên đăng nhập và Mật khẩu"
            + "<br/> Click đồng ý => Nếu hợp lệ Ứng dụng sẽ chào anh/chị"
            + "<div>";
        return chuoiHTML;
    }
}
