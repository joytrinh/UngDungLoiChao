using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class XL_NGHIEPVU
{
    public static string TaoLoiChaoKhachThamQuan()
    {
        return "Xin chào khách tham quan";
    }
    public static string TaoLoiChaoKhachHang(string HoTen)
    {
        return "Xin chào Khách Hàng " + HoTen;
    }
    public static string TaoLoiChaoNhanVien(XL_NHANVIEN NV)
    {
        return "Xin chào Nhân viên " + NV.HoTen + "<br/>Số lần đăng nhập hiện nay là " 
            + NV.DanhSachCacLanDangNhap.Count;
    }
    public static string TaoLoiChaoQuanLy(XL_QUANLY QL)
    {
        return "Xin chào Quản lý " + QL.HoTen + "<br/>Số lần đăng nhập hiện nay là "
            + QL.DanhSachCacLanDangNhap.Count;
    }
    public static List<XL_NHOMHANG> TaoDanhSachNhomHang(XL_NHANVIEN NV, List<XL_NHOMHANG> DanhSachNhomHang)
    {
        List<XL_NHOMHANG> DanhSach = new List<XL_NHOMHANG>();
        NV.DanhSachMaSoNhomHang.ForEach(NVNH =>
        {
            var NhomHang = DanhSachNhomHang.FirstOrDefault(NH => NH.MaSo == NVNH);
            DanhSach.Add(NhomHang);
        });
        return DanhSach;
    }
    public static int PhatSinh(int n)
    {
        var BoPhatSinh = new Random();
        return BoPhatSinh.Next(0, n);
    }
}