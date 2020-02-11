<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalMaster.Master" AutoEventWireup="true" CodeBehind="frmPrincipal.aspx.cs" Inherits="doemais.frmPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Doe + | Página Principal</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="corpo" runat="server">
<div class="content-wrapper">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h4 class="page-head-line">Principal</h4>

            </div>

        </div>
        <div class="row">
            <div class="col-md-6 col-sm-6 col-xs-12">
                <div class="dashboard-div-wrapper bk-clr-three">
                        <h5>Você é um:</h5>
                    <h3><asp:Label ID="lblvoce" runat="server"></asp:Label></h3>
                </div>
            </div>
            <div class="col-md-6 col-sm-6 col-xs-12">
                <div class="dashboard-div-wrapper bk-clr-two">
                        <h5>Seu tipo sangíneo é:</h5>
                    <h3><asp:Label ID ="lblsanguineo" runat="server"></asp:Label></h3>
                </div>
            </div>
        </div>
    </div>
</div>
           
</asp:Content>
