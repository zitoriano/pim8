<%@ Page Title= "CadastrarPessoas" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastrarPessoas.aspx.vb" Inherits="InterfaceAspnet.CadastrarPessoas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Cadastrar Pessoa</h2>

        <div class="row form-horizontal">
                <div class="col-xs-12">
                    <div class="col-xs-12 col-md-6">
                        <h3 class="title">Dados Pessoais</h3>
                        <div class="form-group">
                            <label for="nome" class="col-xs-4 col-sm-2">Nome</label>
                            <div class="col-xs-8 col-sm-10">
                                <input type="text" class="form-control" id="nome">
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="cpf" class="col-xs-4 col-sm-2">CPF</label>
                            <div class="col-xs-8 col-sm-10">
                                <input type="text" class="form-control" id="cpf">
                            </div>
                        </div>
                    </div>
        
                    <div class="col-xs-12 col-md-6">
                        <h3 class="title">Telefones</h3>
                        <div class="group-form">
                            <div class="group-fields">
                                <div class="form-group">
                                    <label for="ddd" class="col-xs-4 col-sm-2">DDD</label>
                                    <div class="col-xs-8 col-sm-10">
                                        <input type="text" class="form-control" id="ddd" name="ddd[]">
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="telefone" class="col-xs-4 col-sm-2">Telefone</label>
                                    <div class="col-xs-8 col-sm-10">
                                        <input type="text" class="form-control" id="telefone" name="telefone[]">
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="tipo" class="col-xs-4 col-sm-2">Tipo</label>
                                    <div class="col-xs-8 col-sm-10">
                                        <select name="tipo[]" id="tipo" class="form-control">
                                            <option value="">Selecione...</option>
                                            <option value="">Residencial</option>
                                            <option value="">Celular</option>
                                        </select>
                                    </div>
                                </div>
                                <div class="close-div">
                                    <a href="#" class="btn btn-danger close-btn">
                                        <span class="glyphicon glyphicon-remove"></span>
                                    </a>
                                </div>
                            </div>
                        </div>
                        <a href="#" class="btn btn-info dupe-form-fields">
                            <span class="glyphicon glyphicon-plus"></span> Adicionar telefone
                        </a>
                    </div>
        
                    <div class="col-xs-12 col-md-6">
                        <h3 class="title">Endereços</h3>
                        <div class="group-form">
                            <div class="group-fields">
                                <div class="form-group">
                                    <label for="logradouro" class="col-xs-4 col-sm-2">Logradouro</label>
                                    <div class="col-xs-8 col-sm-10">
                                        <input type="text" class="form-control" id="logradouro">
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="numero" class="col-xs-4 col-sm-2">Número</label>
                                    <div class="col-xs-8 col-sm-10">
                                        <input type="text" class="form-control" id="numero">
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="cep" class="col-xs-4 col-sm-2">CEP</label>
                                    <div class="col-xs-8 col-sm-10">
                                        <input type="text" class="form-control" id="cep">
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="bairro" class="col-xs-4 col-sm-2">Bairro</label>
                                    <div class="col-xs-8 col-sm-10">
                                        <input type="text" class="form-control" id="bairro">
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="cidade" class="col-xs-4 col-sm-2">Cidade</label>
                                    <div class="col-xs-8 col-sm-10">
                                        <input type="text" class="form-control" id="cidade">
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="estado" class="col-xs-4 col-sm-2">Estado</label>
                                    <div class="col-xs-8 col-sm-10">
                                        <select name="estado" class="form-control">
                                            <option value="AC">Acre</option>
                                            <option value="AL">Alagoas</option>
                                            <option value="AP">Amapá</option>
                                            <option value="AM">Amazonas</option>
                                            <option value="BA">Bahia</option>
                                            <option value="CE">Ceará</option>
                                            <option value="DF">Distrito Federal</option>
                                            <option value="ES">Espírito Santo</option>
                                            <option value="GO">Goiás</option>
                                            <option value="MA">Maranhão</option>
                                            <option value="MT">Mato Grosso</option>
                                            <option value="MS">Mato Grosso do Sul</option>
                                            <option value="MG">Minas Gerais</option>
                                            <option value="PA">Pará</option>
                                            <option value="PB">Paraíba</option>
                                            <option value="PR">Paraná</option>
                                            <option value="PE">Pernambuco</option>
                                            <option value="PI">Piauí</option>
                                            <option value="RJ">Rio de Janeiro</option>
                                            <option value="RN">Rio Grande do Norte</option>
                                            <option value="RS">Rio Grande do Sul</option>
                                            <option value="RO">Rondônia</option>
                                            <option value="RR">Roraima</option>
                                            <option value="SC">Santa Catarina</option>
                                            <option value="SP">São Paulo</option>
                                            <option value="SE">Sergipe</option>
                                            <option value="TO">Tocantins</option>
                                        </select>
                                    </div>
                                </div>
                                <div class="close-div">
                                    <a href="#" class="btn btn-danger close-btn">
                                        <span class="glyphicon glyphicon-remove"></span>
                                    </a>
                                </div>
                            </div>
                        </div>
                        <a href="#" class="btn btn-info dupe-form-fields">
                            <span class="glyphicon glyphicon-plus"></span> Adicionar endereço
                        </a>
                    </div>
                </div>
            </div>

</asp:Content>
