<!DOCTYPE html>
<script runat="server">

    Protected Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs)

    End Sub
</script>

<style type="text/css">
    #titulo{
        margin-left: 115px;
        color:#000000;
        line-height: 50px;
        font-size: 25px;
    }
    #labels{
      height: 140px;
      width: 100px;
      background: #a239d0;
      float:left;
    }
    #texboxs{
      height: 150px;
      width: 180px;
      float:left; 
      background: #a239d0;
    }
    asp:TextBox{
      margin-bottom: 10px;
    }
    label{
      line-height: 22px;
    }
    #topo{
      font-size: 50px;
      margin: 0px;
      border: 5px #000000 solid;
    }
    #form2{
      height: 335px;
      width: 330px;
      margin: 0px auto;
      position: relative;
      top: 80px;
      background: #a239d0;
      border: 2px #000000 solid;
      border-radius: 10px;
    }
    body{
      background: #8709f6
    }
    #but{
      top: 80px;
    }
</style>
<main>
<title>Atualização de cadastro</title>
</head>
    <body>
        <div id="topo">
            Atualização de cadastro
        </div>
        <p>
            &nbsp;</p>
        <form id="form2" runat="server">               
                <div id="titulo" dir="ltr">
                   Informações
                </div>

            <div id="labels" style="height: 22px">
                <label>Nome: </label><br></br>
                <label>sobrenome: </label><br></br>
                <label>Email: </label><br></br>
                <label>Telefone: </label><br></br>
                <label>Endareço: </label><br></br>
                <label>N°Documento: </label><br></br>

                <button style="background:#000000; color: white; width: 323px; height: 27px;">ATUALIZAR</button>

            </div>
            <div id="texboxs" style="height: 150px">
                
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br></br>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br></br>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br></br>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br></br>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br></br>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>

                <br></br>
        
            </div>
            <div id="but">

            </div>
        </form>
     </body>
</main>
