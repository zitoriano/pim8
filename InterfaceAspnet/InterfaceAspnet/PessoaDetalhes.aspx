<%@ Page Title= "PessoaDetalhes" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PessoaDetalhes.aspx.vb" Inherits="InterfaceAspnet.PessoaDetalhes" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>#1 - Julieta Gomes</h2>

        <div class="row">
            <div class="col-xs-12">
                <a class="btn btn-warning">
                    <span class="glyphicon glyphicon-pencil"></span> Editar
                </a>
                <a class="btn btn-danger">
                    <span class="glyphicon glyphicon-trash"></span> Remover
                </a>
            </div>
            <div class="col-xs-12 col-md-6">
                <dl class="row">
                    <div class="col-xs-12">
                        <h3 class="title">Dados Pessoais</h3>
                    </div>

                    <dt class="col-xs-3">Nome</dt>
                    <dd class="col-xs-9">Julieta Gomes</dd>

                    <dt class="col-xs-3">CPF</dt>
                    <dd class="col-xs-9">723.074.224-20</dd>
                </dl>
            </div>
            <div class="col-xs-12 col-md-6">
                <dl class="row">
                    <div class="col-xs-12">
                        <h3 class="title">Telefones</h3>
                    </div>

                    <dt class="col-xs-3">DDD</dt>
                    <dd class="col-xs-9">71</dd>

                    <dt class="col-xs-3">Telefone</dt>
                    <dd class="col-xs-9">6871-4961</dd>

                    <dt class="col-xs-3">Tipo</dt>
                    <dd class="col-xs-9">Residencial</dd>
                </dl>
            </div>
            <div class="col-xs-12 col-md-6">
                <dl class="row">
                    <div class="col-xs-12">
                        <h3 class="title">Endereço</h3>
                    </div>

                    <dt class="col-xs-3">Logradouro</dt>
                    <dd class="col-xs-9">Vila dos Unidos</dd>

                    <dt class="col-xs-3">Número</dt>
                    <dd class="col-xs-9">1968</dd>

                    <dt class="col-xs-3">CEP</dt>
                    <dd class="col-xs-9">40490-000</dd>

                    <dt class="col-xs-3">Bairro</dt>
                    <dd class="col-xs-9">Alto do Peru</dd>

                    <dt class="col-xs-3">Cidade</dt>
                    <dd class="col-xs-9">Salvador</dd>

                    <dt class="col-xs-3">Estado</dt>
                    <dd class="col-xs-9">BA</dd>
                </dl>
            </div>
        </div>
</asp:Content>
