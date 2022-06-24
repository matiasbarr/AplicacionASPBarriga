<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="AplicacionASPBarriga.VerMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="row">
    <div class="col-lg-6 mx-auto">
        <div class="card">
            <div class="card-header bg-sucess text-white">
                <h3>Ver Medidores</h3>
            </div>
            <div class="card-body">
                <div class="form-group">
                    <label for="filtrarMedidorLbl">Filtrar por Tipo de medidor</label>
                    <asp:DropDownList AutoPostBack="true" ID="filtrarMedidorDdl" OnSelectedIndexChanged="filtrarMedidorDdl_SelectedIndexChanged" runat="server" >
                        <asp:ListItem Value="1" Text="Analogo"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Digital"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <asp:GridView CssClass="table table-hover table-bordered mt-5"
                    EmptyDataText="No hay medidores" ShowHeader="true"
                    ID="grillaMedidores" runat="server" AutoGenerateColumns="false"
                    OnRowCommand="grillaMedidores_RowCommand">

                    <Columns>
                        <asp:BoundField DataField="Numero" HeaderText="Numero Medidor" />
                        <asp:BoundField DataField="TipoTxt" HeaderText="Tipo Medidor" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button 
                                    CommandName="eliminar"
                                    CommandArgument='<%# Eval("Numero") %>'
                                    runat="server"
                                    CssClass="btn bg-danger"
                                    Text="Eliminar"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</div>

</asp:Content>
