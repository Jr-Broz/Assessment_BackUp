using System;
using System.Threading.Tasks;
namespace Assessment{ 
public class Pokedex : FuncoesMenu{             
    public void MostrarMenu(){
    String resposta;
    
    do { 

System.Console.WriteLine("Saudacoes, usuario escolha [1] Para que os dados sejam salvos em arquivo de texto | [2] Para ser salvo em lista [3] Para procurar por um Nome de pokemon em específico Em Formato de Texto | [4] Para excluir algum Dado Em Formato de Texto | [5] Para Alterar Dados Ja Existentes Em Formato de Texto | [6] Para Procurar por Arquivo especifico em Lista |  [7] Para Excluir dados Especificos em Lista | [8] Para Alterar Dados em Lista | [9] Para Sair do Programa" ) ;
    Console.WriteLine("------------------------------");
    resposta = Console.ReadLine();

switch(resposta){

    case "1":

    SalvarEmTexto();
    break;

    case "2":

    SalvarEmLista();
    break; 

    case "3":

    pesquisarDadoPorNomeParaTexto();
    break;

    case "4":

    ExcluirDadosParaTexto();
    break;

    case "5":
    alterarDadosParaTexto();
    break;

    case "6":
     PesquisarDadoNomeLista();    
    break;

    
    case "7":
  ExcluirDadosParaLista();
    break;

    
    case "8":
   AlterarDadosLista();
 
    break;

    case "9":

    break;

    default:
    System.Console.WriteLine("Esperando Input correto");
    Thread.Sleep(1500);
    Console.Clear();
    break;      
} 

}while(resposta != "6");
}
    
    public void MenuFuncoes(){
 
            System.Console.WriteLine("Gostaria de Procurar por um Nome Específico?   [1] Para Sim || [2] Para Não.");
            String resposta = Console.ReadLine();

            switch(resposta){

                case "1":
                pesquisarDadoPorNomeParaTexto();
                break;

                default:
                System.Console.WriteLine("...................");
                Thread.Sleep(1500);
                Console.Clear();
                break;
           }
    }    
   }
}
