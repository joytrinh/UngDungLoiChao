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
    public static string TaoChuoiHTMLDanhSachNhomHang(List<XL_NHOMHANG> DanhSachNhomHang)
    {
        string chuoiHTML = "<div class='btn'>";
        DanhSachNhomHang.ForEach(NhomHang =>
        {
            string chuoiHinh = "<div class='btn'> <img src='../Media/" + NhomHang.MaSo + ".png' width='50' height='50'>";
            string chuoiThongTin = "<br/><div>" + NhomHang.Ten + "</div>";
            chuoiHTML += $"{chuoiHinh}" + $"{chuoiThongTin}" + "<br />";
        });
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
}
