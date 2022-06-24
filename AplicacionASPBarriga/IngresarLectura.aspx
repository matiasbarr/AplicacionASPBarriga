<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="IngresarLectura.aspx.cs" Inherits="AplicacionASPBarriga.IngresarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensaje">
                <asp:Label runat="server" ID="mensajeLbl1" CssClass="text-sucess"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-info tet-white">
                    <h3>Agregar Lectura</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="medidorDdl">Numero de Medidores: </label>
                        <asp:DropDownList runat="server" ID="medidorDdl" CssClass="form-select">

                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="fechaLbl">Fecha :</label>
                        <asp:Calendar ID="fechaCalendar" runat="server"
                            OnSelectionChanged="fechaCalendar_SelectionChanged"></asp:Calendar>
                    </div>
                    <div class="form-group">
                        <label for="horaLbl">Hora: </label>
                        <asp:TextBox ID="horaTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="minutosLbl">Minutos: </label>
                        <asp:TextBox ID="minutosTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="consumoTxt">Consumo:</label>
                        <asp:TextBox ID="consumoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarLecturaBtn" OnClick="agregarLecturaBtn_Click" Text="Agregar Lectura" CssClass="btn btn-primary"/>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
