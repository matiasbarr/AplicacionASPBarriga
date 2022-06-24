<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="VerLecturas.aspx.cs" Inherits="AplicacionASPBarriga.VerLecturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-sucess text-white">
                    <h3>Ver Lecturas</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="medidorLbl">Filtrar por Medidor</label>
                        <asp:GridView CssClass="table table-hover table-bordered mt-5"
                            EmptyDataText="No hay lecturas" ShowHeader="true"
                            OnRowCommand="grillaLecturas_RowCommand"
                            AutoGenerateColums="false" runat="server" ID="grillaLecturas">
                            <Columns>
                                <asp:BoundField DataField="MedidoresLectura" HeaderText="Tipo Medidor" />
                                <asp:BoundField DataField="FechaLectura" HeaderText="Fecha" />
                                <asp:BoundField DataField="HoraLectura" HeaderText="Hora" />
                                <asp:BoundField DataField="MinutoLectura" HeaderText="Minutos" />
                                <asp:BoundField DataField="ConsumoLectura" HeaderText="Consumo" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Button 
                                            CommandName="eliminar"
                                            CommandArgument='<%# Eval("MedidoresLectura") %>'
                                            runat="server"
                                            CssClass="btn bg-sucess" Text="Eliminar"/>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
