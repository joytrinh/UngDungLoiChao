using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Script.Serialization;

public class XL_LUUTRU
{
    static DirectoryInfo ThuMucDuLieu = new DirectoryInfo
        (HttpContext.Current.Server.MapPath($"../DuLieu"));
    static DirectoryInfo ThuMucNhanVien = ThuMucDuLieu.GetDirectories("NhanVien")[0];
    static DirectoryInfo ThuMucNhomHang = ThuMucDuLieu.GetDirectories("NhomHang")[0];
    static DirectoryInfo ThuMucQuanLy = ThuMucDuLieu.GetDirectories("QuanLy")[0];

    public static List<XL_NHOMHANG> DocDanhSachNhomHang()
    {
        List<XL_NHOMHANG> DanhSachNhomHang = new List<XL_NHOMHANG>();
        ThuMucNhomHang.GetFiles("*.json").ToList().ForEach(TapTin =>
        {
            var DuongDan = TapTin.FullName;
            var ChuoiLuuTru = File.ReadAllText(DuongDan);
            var XuLy = new JavaScriptSerializer();
            var NhomHang = new XL_NHOMHANG();
            NhomHang = (XL_NHOMHANG)XuLy.Deserialize(ChuoiLuuTru, NhomHang.GetType());
            DanhSachNhomHang.Add(NhomHang);
        });
        return DanhSachNhomHang;
    }  
    public static List<XL_NHANVIEN> DocDanhSachNhanVien()
    {
        List<XL_NHANVIEN> DanhSachNhanVien = new List<XL_NHANVIEN>();
        ThuMucNhanVien.GetFiles("*.json").ToList().ForEach(TapTin =>
        {
            var DuongDan = TapTin.FullName;
            var ChuoiLuuTru = File.ReadAllText(DuongDan);
            var XuLy = new JavaScriptSerializer();
            var NhanVien = new XL_NHANVIEN();
            NhanVien = (XL_NHANVIEN)XuLy.Deserialize(ChuoiLuuTru, NhanVien.GetType());
            DanhSachNhanVien.Add(NhanVien);
        });
        return DanhSachNhanVien;
    }
    public static List<XL_QUANLY> DocDanhSachQuanLy()
    {
        List<XL_QUANLY> DanhSachQuanLy = new List<XL_QUANLY>();
        ThuMucQuanLy.GetFiles("*.json").ToList().ForEach(TapTin =>
        {
            var DuongDan = TapTin.FullName;
            var ChuoiLuuTru = File.ReadAllText(DuongDan);
            var XuLy = new JavaScriptSerializer();
            var QuanLy = new XL_QUANLY();
            QuanLy = (XL_QUANLY)XuLy.Deserialize(ChuoiLuuTru, QuanLy.GetType());
            DanhSachQuanLy.Add(QuanLy);
        });
        return DanhSachQuanLy;
    }
    public static void GhiNhanVien(XL_NHANVIEN NhanVien)
    {
        var XuLy = new JavaScriptSerializer();
        var ChuoiLuuTru = XuLy.Serialize(NhanVien);
        var DuongDan = $"{ThuMucNhanVien.FullName}\\{NhanVien.MaSo}.json";
        File.WriteAllText(DuongDan, ChuoiLuuTru);
    }
    public static void GhiQuanLy(XL_QUANLY QuanLy)
    {
        var XuLy = new JavaScriptSerializer();
        var ChuoiLuuTru = XuLy.Serialize(QuanLy);
        var DuongDan = $"{ThuMucQuanLy.FullName}\\{QuanLy.MaSo}.json";
        File.WriteAllText(DuongDan, ChuoiLuuTru);
    }
}