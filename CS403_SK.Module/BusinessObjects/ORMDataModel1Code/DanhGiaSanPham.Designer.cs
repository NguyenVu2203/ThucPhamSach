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

    public partial class DanhGiaSanPham : XPObject
    {
        string fMaDG;
        public string MaDG
        {
            get { return fMaDG; }
            set { SetPropertyValue<string>(nameof(MaDG), ref fMaDG, value); }
        }
        string fSoSao;
        public string SoSao
        {
            get { return fSoSao; }
            set { SetPropertyValue<string>(nameof(SoSao), ref fSoSao, value); }
        }
        string fNoiDungDanhGia;
        public string NoiDungDanhGia
        {
            get { return fNoiDungDanhGia; }
            set { SetPropertyValue<string>(nameof(NoiDungDanhGia), ref fNoiDungDanhGia, value); }
        }
        DateTime fNgayDanhGia;
        public DateTime NgayDanhGia
        {
            get { return fNgayDanhGia; }
            set { SetPropertyValue<DateTime>(nameof(NgayDanhGia), ref fNgayDanhGia, value); }
        }
        NguoiDung fMaND;
        [Association(@"DanhGiaSanPhamReferencesNguoiDung")]
        public NguoiDung MaND
        {
            get { return fMaND; }
            set { SetPropertyValue<NguoiDung>(nameof(MaND), ref fMaND, value); }
        }
        SanPham fMaSP;
        [Association(@"DanhGiaSanPhamReferencesSanPham")]
        public SanPham MaSP
        {
            get { return fMaSP; }
            set { SetPropertyValue<SanPham>(nameof(MaSP), ref fMaSP, value); }
        }
    }

}
