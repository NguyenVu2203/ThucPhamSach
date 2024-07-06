﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace CS403_SK.Module.BusinessObjects.ORMDataModel1
{

    public partial class ChiTietDonHang : XPObject
    {
        string fMaCT;
        public string MaCT
        {
            get { return fMaCT; }
            set { SetPropertyValue<string>(nameof(MaCT), ref fMaCT, value); }
        }
        double fSoLuong;
        public double SoLuong
        {
            get { return fSoLuong; }
            set { SetPropertyValue<double>(nameof(SoLuong), ref fSoLuong, value); }
        }
        decimal fDonGia;
        public decimal DonGia
        {
            get { return fDonGia; }
            set { SetPropertyValue<decimal>(nameof(DonGia), ref fDonGia, value); }
        }
        string fPhuongThucThanhToan;
        public string PhuongThucThanhToan
        {
            get { return fPhuongThucThanhToan; }
            set { SetPropertyValue<string>(nameof(PhuongThucThanhToan), ref fPhuongThucThanhToan, value); }
        }
        SanPham fMaSP;
        [Association(@"ChiTietDonHangReferencesSanPham")]
        public SanPham MaSP
        {
            get { return fMaSP; }
            set
            {
                if (SetPropertyValue<SanPham>(nameof(MaSP), ref fMaSP, value)
                    && value != null && !IsLoading)
                    DonGia = value.Gia;
            }
        }
        string fTenSP;
        public string TenSP
        {
            get { return fTenSP; }
            set { SetPropertyValue<string>(nameof(TenSP), ref fTenSP, value); }
        }
        DonHang fMaDH;
        [Association(@"ChiTietDonHangReferencesDonHang")]
        public DonHang MaDH
        {
            get { return fMaDH; }
            set { SetPropertyValue<DonHang>(nameof(MaDH), ref fMaDH, value); }
        }
        decimal fThanhTien;
        public decimal ThanhTien
        {
            get { return (decimal)SoLuong * DonGia; }

            set { SetPropertyValue<decimal>(nameof(ThanhTien), ref fThanhTien, value); }
        }
    }

}
