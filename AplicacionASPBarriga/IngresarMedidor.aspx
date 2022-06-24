<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="IngresarMedidor.aspx.cs" Inherits="AplicacionASPBarriga.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div mensaje="">
                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-sucess"></asp:Label>
            </div>

            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ingresar Medidor</h3>
                </div>
                <div class="card-body">

                    <div class="form-group">
                        <label for="numMedidorTxt">Numero de Medidor</label>
                        <asp:TextBox ID="numMedidorTxt" CssClass="form-group" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group ">
                        <label for="radioB1"></label>
                        <asp:RadioButtonList runat="server" ID="radioB1">
                            <asp:ListItem Selected="True" Value="1" Text="Analogo"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Digital"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    
                    <div class="form-group">
                        <asp:Button 
                            runat="server" 
                            ID="agregarBtn" 
                            OnClick="agregarBtn_Click"
                            Text="Agregar" 
                            CssClass="btn btn-primary" />
                    </div>

                </div>
            </div>

        </div>
    </div>

</asp:Content>
