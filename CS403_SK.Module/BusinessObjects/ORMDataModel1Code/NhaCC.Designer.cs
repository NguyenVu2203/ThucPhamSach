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

    public partial class NhaCC : XPObject
    {
        string fMaNCC;
        public string MaNCC
        {
            get { return fMaNCC; }
            set { SetPropertyValue<string>(nameof(MaNCC), ref fMaNCC, value); }
        }
        string fTen_NCC;
        public string Ten_NCC
        {
            get { return fTen_NCC; }
            set { SetPropertyValue<string>(nameof(Ten_NCC), ref fTen_NCC, value); }
        }
        string fDiaChi_NCC;
        public string DiaChi_NCC
        {
            get { return fDiaChi_NCC; }
            set { SetPropertyValue<string>(nameof(DiaChi_NCC), ref fDiaChi_NCC, value); }
        }
        string fSDT_NCC;
        public string SDT_NCC
        {
            get { return fSDT_NCC; }
            set { SetPropertyValue<string>(nameof(SDT_NCC), ref fSDT_NCC, value); }
        }
        string fEmail_NCC;
        public string Email_NCC
        {
            get { return fEmail_NCC; }
            set { SetPropertyValue<string>(nameof(Email_NCC), ref fEmail_NCC, value); }
        }
        string fMaXacThuc;
        public string MaXacThuc
        {
            get { return fMaXacThuc; }
            set { SetPropertyValue<string>(nameof(MaXacThuc), ref fMaXacThuc, value); }
        }
        DateTime fNgayXacThuc;
        public DateTime NgayXacThuc
        {
            get { return fNgayXacThuc; }
            set { SetPropertyValue<DateTime>(nameof(NgayXacThuc), ref fNgayXacThuc, value); }
        }
        string fNguoiXacThuc;
        public string NguoiXacThuc
        {
            get { return fNguoiXacThuc; }
            set { SetPropertyValue<string>(nameof(NguoiXacThuc), ref fNguoiXacThuc, value); }
        }
        string fNoiDungXacThuc;
        public string NoiDungXacThuc
        {
            get { return fNoiDungXacThuc; }
            set { SetPropertyValue<string>(nameof(NoiDungXacThuc), ref fNoiDungXacThuc, value); }
        }
        string fKetQuaXacThuc;
        public string KetQuaXacThuc
        {
            get { return fKetQuaXacThuc; }
            set { SetPropertyValue<string>(nameof(KetQuaXacThuc), ref fKetQuaXacThuc, value); }
        }
        string fPhanQuyen;
        public string PhanQuyen
        {
            get { return fPhanQuyen; }
            set { SetPropertyValue<string>(nameof(PhanQuyen), ref fPhanQuyen, value); }
        }
        [Association(@"SanPhamReferencesNhaCC")]
        public XPCollection<SanPham> SanPhams { get { return GetCollection<SanPham>(nameof(SanPhams)); } }
    }

}
