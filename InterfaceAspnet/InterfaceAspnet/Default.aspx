<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="InterfaceAspnet._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="title">Cadastro de Pessoas</h2>
    <div class="form-inline filter">
            <div class="form-group">
                <label class="sr-only" for="cpf"></label>
                <input type="email" class="form-control" id="cpf" placeholder="Filtrar por CPF">
            </div>
            <button type="submit" class="btn btn-warning">
                <span class="glyphicon glyphicon-search"></span> Filtrar
            </button>
        </div>

        <div class="table-responsive">
            <table class="table">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Nome</th>
                    <th>CPF</th>
                    <th>Telefone</th>
                    <th>Endereço</th>
                    <th>Ações</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>1</td>
                    <td>Julieta Gomes</td>
                    <td>723.074.224-20</td>
                    <td>(71) 6871-4961</td>
                    <td>Vila dos Unidos, 1968 - Salvador, BA</td>
                    <td>
                        <a class="btn btn-info">
                            <span class="glyphicon glyphicon-eye-open"></span>
                        </a>
                        <a class="btn btn-warning">
                            <span class="glyphicon glyphicon-pencil"></span>
                        </a>
                        <a class="btn btn-danger">
                            <span class="glyphicon glyphicon-trash"></span>
                        </a>
                    </td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>Letícia Azevedo</td>
                    <td>910.558.955-07</td>
                    <td>(31) 3088-9671</td>
                    <td>Beco Vinícius de Moraes, 598 - Belo Horizonte-MG</td>
                    <td>
                        <a class="btn btn-info">
                            <span class="glyphicon glyphicon-eye-open"></span>
                        </a>
                        <a class="btn btn-warning">
                            <span class="glyphicon glyphicon-pencil"></span>
                        </a>
                        <a class="btn btn-danger">
                            <span class="glyphicon glyphicon-trash"></span>
                        </a>
                    </td>
                </tr>
                <tr>
                    <td>3</td>
                    <td>Anna Gonçalves</td>
                    <td>314.752.854-50</td>
                    <td>(11) 6118-6444</td>
                    <td>Rua Doutor Guilherme Elis, 1764 - São Paulo-SP</td>
                    <td>
                        <a class="btn btn-info">
                            <span class="glyphicon glyphicon-eye-open"></span>
                        </a>
                        <a class="btn btn-warning">
                            <span class="glyphicon glyphicon-pencil"></span>
                        </a>
                        <a class="btn btn-danger">
                            <span class="glyphicon glyphicon-trash"></span>
                        </a>
                    </td>
                </tr>
                <tr>
                    <td>4</td>
                    <td>Danilo Barbosa Gonçalves</td>
                    <td>296.661.307-69</td>
                    <td>(31) 8479-5577</td>
                    <td>Rua Francisco Torres, 1199 - Betim-MG</td>
                    <td>
                        <a class="btn btn-info">
                            <span class="glyphicon glyphicon-eye-open"></span>
                        </a>
                        <a class="btn btn-warning">
                            <span class="glyphicon glyphicon-pencil"></span>
                        </a>
                        <a class="btn btn-danger">
                            <span class="glyphicon glyphicon-trash"></span>
                        </a>
                    </td>
                </tr>
                <tr>
                    <td>5</td>
                    <td>Rebeca Oliveira Almeida</td>
                    <td>248.897.954-64</td>
                    <td>(81) 9449-6323</td>
                    <td>Rua Dezenove, 118 - Igarassu-PE</td>
                    <td>
                        <a class="btn btn-info">
                            <span class="glyphicon glyphicon-eye-open"></span>
                        </a>
                        <a class="btn btn-warning">
                            <span class="glyphicon glyphicon-pencil"></span>
                        </a>
                        <a class="btn btn-danger">
                            <span class="glyphicon glyphicon-trash"></span>
                        </a>
                    </td>
                </tr>
                <tr>
                    <td>6</td>
                    <td>Mateus Souza Dias</td>
                    <td>198.641.693-35</td>
                    <td>(47) 4837-6139</td>
                    <td>Rua Aladi Schendroski Bini, 1557 - Itajaí-SC</td>
                    <td>
                        <a class="btn btn-info">
                            <span class="glyphicon glyphicon-eye-open"></span>
                        </a>
                        <a class="btn btn-warning">
                            <span class="glyphicon glyphicon-pencil"></span>
                        </a>
                        <a class="btn btn-danger">
                            <span class="glyphicon glyphicon-trash"></span>
                        </a>
                    </td>
                </tr>
                <tr>
                    <td>7</td>
                    <td>Luís Dias Melo</td>
                    <td>457.659.096-04</td>
                    <td>(47) 3282-8172</td>
                    <td>Rua Itapiranga, 1104 - Blumenau-SC</td>
                    <td>
                        <a class="btn btn-info">
                            <span class="glyphicon glyphicon-eye-open"></span>
                        </a>
                        <a class="btn btn-warning">
                            <span class="glyphicon glyphicon-pencil"></span>
                        </a>
                        <a class="btn btn-danger">
                            <span class="glyphicon glyphicon-trash"></span>
                        </a>
                    </td>
                </tr>
            </tbody>
        </table>
        </div>

        <div class="row">
            <div class="col-xs-12">
                <a href="#" class="btn btn-success">
                    <span class="glyphicon glyphicon-plus"></span> Cadastar Pessoa
                </a>
            </div>
        </div>

</asp:Content>
