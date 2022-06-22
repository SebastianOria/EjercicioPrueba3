<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarLectura.aspx.cs" Inherits="EjercicioPrueba3.AgregarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">

        
    <div class="row">
     
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                <a href="AgregarLetura.aspx"></a>
                    <h3>Agregar Lecturas</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="nombreTxt">ID Medidor: </label>
                        <asp:TextBox ID="idmedidor" CssClass="form-control" runat="server"></asp:TextBox> 
                    </div>

                    <div class="form-group">
                        <label for="nombreTxt">fecha: </label>
                        <asp:TextBox ID="fecha" CssClass="form-control" runat="server"></asp:TextBox> 
                    </div>

                    <div class="form-group">
                        <label for="nombreTxt">hora: </label>
                        <asp:TextBox ID="hora" CssClass="form-control" runat="server"></asp:TextBox> 
                    </div>

                    <div class="form-group">
                        <label for="nombreTxt">minutos: </label>
                        <asp:TextBox ID="minutos" CssClass="form-control" runat="server"></asp:TextBox> 
                    </div>

                    <div class="form-group">
                        <label for="nombreTxt">Valor Consumo: </label>
                        <asp:TextBox ID="valorConsum" CssClass="form-control" runat="server"></asp:TextBox> 
                    </div>

                 
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" Text="Agregar" CssClass="btn btn-primary" OnClick="agregarBtn_Click"/>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
