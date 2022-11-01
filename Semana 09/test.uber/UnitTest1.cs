

using uber.Models;

namespace test.uber;

public class Tests
{
    [SetUp]
    public void VerificarDadosCorridas()
    {
        var corrida = new Corrida();
        Assert.Catch(()=>{
            corrida.VisualizarSolicitacaoDeCorrida();
        });

        corrida.Origem = new Endereco{
            Rua = "Rua Jose Zeferino",
            Bairro = "Tracado",
            Numero = 908
        };
        corrida.Destino = new Endereco{
            Rua = "Rua Boanerges de Souza",
            Bairro = "Praca",
            Numero = 258
        };

        Assert.DoesNotThrow(() =>{
            corrida.VisualizarSolicitacaoDeCorrida();
        });
    }

    
}
