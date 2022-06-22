﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EjercicioPrueba3.Default" %>

            

    
<asp:Content ID="Conten1" ContentPlaceHolderID="Contenido" runat="server">
    
    <div class="row">
     
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
     <a href="Default.aspx">Default.aspx</a>
                    <h3>Agregar Medidores</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="nombreTxt">ID Medidor: </label>
                        <asp:TextBox ID="nombreTxt" CssClass="form-control" runat="server"></asp:TextBox> 
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" Text="Agregar" CssClass="btn btn-primary" OnClick="agregarBtn_Click"/>
                    </div>

                </div>
            </div>
        </div>
    </div>

</asp:Content>
