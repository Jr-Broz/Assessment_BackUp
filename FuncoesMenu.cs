using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Assessment{ 
public class FuncoesMenu : IFuncoes{
        protected String NomePokemon;
        protected double PesoPokemon;
        protected bool Eh_Pokemon_Shiny;
        protected int NivelPokemon;
        protected DateTime dataDaCaptura;
        protected String IdPokedex;     
        public double variavelAuxiliarPeso;
        public bool variavelAuxiliarShiny;
        protected String kg = "kg";

        private static Mutex mutex = new Mutex();
        string respostaPraPergunta;
        private string caminho = "Arquivos_Pokedex.txt";

        public  StreamWriter arquivar = new StreamWriter(@"Arquivos_Pokedex.txt", true);
        string rp2;

 List<String> listagem = new List<String>();

             double novoPeso;
            String novoPesoString;
             int novoNivel;
            String novoNivelString;
            Boolean novoShiny;
            String novoShinyString;

                DateTime novaData;
                String novaDataString;


    public void setNomePokemon(String nomePokemon){

        NomePokemon = nomePokemon;
   
}
    public string getNomePokemon(){

    return NomePokemon;
}

    public void setNivelPokemon(int nivelPokemon){

    NivelPokemon = nivelPokemon;

}

    public int getNivelPokemon(){

    return NivelPokemon;
}

    public void setEh_Pokemon_Shiny(bool eh_shiny){

    Eh_Pokemon_Shiny = eh_shiny;
}

    public bool getEh_Pokemon_Shiny(){

    return Eh_Pokemon_Shiny;
}

    public void setDataCaptura(DateTime data_Captura){

    dataDaCaptura = data_Captura;
}
    public DateTime getDataCaptura(){

     return dataDaCaptura;

}

    public void setIdPokedex(String Id_pokedex){

    IdPokedex =  Id_pokedex;
}

    public String getIdPokedex(){

    return IdPokedex;

}

    public void setPesoPokemon(double pesoPokemon){

    PesoPokemon = pesoPokemon;
}

    public double getPesoPokemon(){

    return PesoPokemon;
}
 public void SalvarEmTexto(){

 try { 
    do { 
        Console.WriteLine("Escreva o nome do pokemon");
        setNomePokemon(Console.ReadLine()); 

        Console.WriteLine("Escreva o Peso do Pokemon");
        variavelAuxiliarPeso = Double.Parse(Console.ReadLine());
        setPesoPokemon(variavelAuxiliarPeso);

        Console.WriteLine("O pokemon E Shiny? -> true  || false ");
        variavelAuxiliarShiny = Boolean.Parse(Console.ReadLine());

         String AuxShinyConvertido = Convert.ToString(variavelAuxiliarShiny);    
        if(AuxShinyConvertido == "sim".ToLower()){

            setEh_Pokemon_Shiny(true);
        }
         else{

            setEh_Pokemon_Shiny(false);
        }

        Console.WriteLine("Qual o Nivel do pokemon");
        setNivelPokemon(Int32.Parse(Console.ReadLine()));

        Console.WriteLine("Qual a data da Captura");
        setDataCaptura(DateTime.Parse(Console.ReadLine()));

        String variavelAuxiliarId = Guid.NewGuid().ToString().Substring(0, Guid.NewGuid().ToString().IndexOf("-"));

        Console.WriteLine("Gerando ID Único do pokemon.."); 
        setIdPokedex(variavelAuxiliarId);
        
        Thread.Sleep(1200);
        Console.WriteLine("Conferindo informações..");
        Thread.Sleep(1500);
        Console.WriteLine("Escrevendo em um arquivo de texto.");
        Thread.Sleep(1300);
        Console.WriteLine("Sucesso na Operação, obrigado por utilizar.");
        System.Console.WriteLine("Para Procurar pelo Pokemon, procure por: " + getNomePokemon());

arquivar.WriteLine("Nome do Pokemon: " + getNomePokemon() + "," + " ID: " + IdPokedex + "," + " Nivel: " + getNivelPokemon() + "," + " Data de Captura: " + getDataCaptura() + "," + " É Shiny: " +  AuxShinyConvertido + "," + " Peso: " + getPesoPokemon() + kg);
   
System.Console.WriteLine("Quer Adicionar Mais algum?");
 respostaPraPergunta = Console.ReadLine();

    if(respostaPraPergunta == "sim"){

        continue;
    }

    arquivar.WriteLine("--------------------------");
    arquivar.Close();

}   while (respostaPraPergunta != "nao".ToLower());
 }    

    catch(Exception ex){

    System.Console.WriteLine("Ocorreu um Erro ao Cadastrar O Pokemon na Pokedex." + ex.Message);
    }
}
    public void SalvarEmLista(){
        try{ 

        Console.WriteLine("Escreva o nome do pokemon");
        setNomePokemon(Console.ReadLine()); 

        Console.WriteLine("Escreva o Peso do Pokemon");
        variavelAuxiliarPeso = Double.Parse(Console.ReadLine());
        setPesoPokemon(variavelAuxiliarPeso);

        Console.WriteLine("O pokemon E Shiny? -> true  ||  false");
        variavelAuxiliarShiny = Boolean.Parse(Console.ReadLine());	
        
        if(variavelAuxiliarShiny == true){

            setEh_Pokemon_Shiny(true);
        }
         else{

            setEh_Pokemon_Shiny(false);
        }

        Console.WriteLine("Qual o Nivel do pokemon");
        setNivelPokemon(Int32.Parse(Console.ReadLine()));

        Console.WriteLine("Qual a data da Captura");
        setDataCaptura(DateTime.Parse(Console.ReadLine()));

        String variavelAuxiliarId = Guid.NewGuid().ToString().Substring(0, Guid.NewGuid().ToString().IndexOf("-"));

        Console.WriteLine("Gerando ID Único do pokemon.."); 
        setIdPokedex(variavelAuxiliarId);
        
        Thread.Sleep(1200);
        Console.WriteLine("Conferindo informações..");
        Thread.Sleep(1500);
        Console.WriteLine("Sucesso na Operação, obrigado por utilizar.");

    String dataCapturaConvertida = Convert.ToString(dataDaCaptura);
    String nivelConvertido = Convert.ToString(getNivelPokemon());
    String AuxShinyConvertido = Convert.ToString(variavelAuxiliarShiny);
    String AuxPesoConvertido = Convert.ToString(variavelAuxiliarPeso);

    listagem.Add(getNomePokemon());
    listagem.Add(getIdPokedex());
    listagem.Add(dataCapturaConvertida);
    listagem.Add(nivelConvertido);
    listagem.Add(AuxShinyConvertido);
    listagem.Add(AuxPesoConvertido);

    System.Console.WriteLine("Listando Todas as Informações: ");

    foreach(string element in listagem){
       
    if(element == getNomePokemon()){

        System.Console.WriteLine("Nome Pokemon: " + getNomePokemon());
    }
    
    else  if(element == getIdPokedex()){

        System.Console.WriteLine("ID: " + variavelAuxiliarId);
    }
    
    else if(element == dataCapturaConvertida){

        System.Console.WriteLine("Data de Captura : " + getDataCaptura());
    }
    
   else  if(element == nivelConvertido){

        System.Console.WriteLine("Nivel Pokemon: " + getNivelPokemon());
    }
    
    else if(element == AuxShinyConvertido){

        System.Console.WriteLine("É Shiny? : " + AuxShinyConvertido);
}
    
    else if(element == AuxPesoConvertido){

        System.Console.WriteLine("Peso: " + AuxPesoConvertido);
    }
    }
        }catch(Exception ex){
        
            System.Console.WriteLine("Houve algo de errado " + ex.Message);
        }  
}

public void alterarDadosParaTexto(){

     try{

        System.Console.WriteLine("Qual linha voce quer alterar, informe o nome do pokemon.");
        
        string respostaParaAlterar = Console.ReadLine();
        string procurar = respostaParaAlterar;
        string textoAntesDeAlterar;
        string n = "";

        System.Console.WriteLine("E o que vc vai alterar? , altere no mesmo formato, Nome, ID, Nivel,DataDeCaptura,SeEShinyOuNao, Peso");
        System.Console.WriteLine("------------------------------------------");
        String respostaAlterada = Console.ReadLine();

        StreamReader sr = File.OpenText(caminho);

        while((textoAntesDeAlterar = sr.ReadLine()) != null){

            if(!textoAntesDeAlterar.Contains(procurar)){

                n += textoAntesDeAlterar + Environment.NewLine;
                System.Console.WriteLine("Alteramos aquilo que desejava.");
                System.Console.WriteLine("---------------------------------");
            }
            else{

                procurar.Replace(procurar, respostaAlterada);
            }
            
        }     
            sr.Close();
            File.WriteAllText(caminho, respostaAlterada);

            }
catch(Exception ex){
    System.Console.WriteLine("Algo de Errado Ocorreu." + ex.Message);
}
}
public void ExcluirDadosParaTexto(){
     try{

            System.Console.WriteLine("----------------------------------------------");
            System.Console.WriteLine("Se Chegou nesta parte do programa, é porque quer deletar uma linha, iremos repassar a Funcao anterior para que possa escolher o que quer deletar");
        
        System.Console.WriteLine("-------------------------");


        System.Console.WriteLine("Mostrando Todas as linhas de texto para que você escolha....");;
        Thread.Sleep(5000);

        pesquisarDadoPorNomeParaTexto();

        System.Console.WriteLine("Qual o Nome do pokemon que voce quer deletar?");
        string respostaParaDeletar = Console.ReadLine();
        string procurar = respostaParaDeletar;
        string textoAntesDeletar;
        string n = "";

        StreamReader sr = File.OpenText(caminho);

        while((textoAntesDeletar = sr.ReadLine()) != null){

            if(!textoAntesDeletar.Contains(procurar)){

                n += textoAntesDeletar + Environment.NewLine;
                System.Console.WriteLine("Apagamos o que desejava, obrigado por utilizar.");
            }
            
        }     
            sr.Close();
            File.WriteAllText(caminho, n);
     }
catch{
    System.Console.WriteLine("Algo de Errado Ocorreu.");
}
}

    public void  pesquisarDadoPorNomeParaTexto(){

 try { 
        System.Console.WriteLine("Escreva o que quer procurar (nome, nivel, etc).");
        string nome_Sendo_Procurado = Console.ReadLine();
        
        bool foiAchado = false;

        System.Console.WriteLine("Aguarde um pouco........");
        Thread.Sleep(3000);

        String caminho = "Arquivos_Pokedex.txt";

        String[] linhas = File.ReadAllLines(caminho);

    var procuraPorNome = linhas.Where(linha => linha.Contains(nome_Sendo_Procurado)).ToList();       

        if(procuraPorNome.Count > 0){

            System.Console.WriteLine("Acreditamos que encontramos o que procurava.");
            System.Console.WriteLine("--------------------------------------------");
            foreach(var linha in linhas){

                System.Console.WriteLine(linha);

            }
        }
        else{

             System.Console.WriteLine("O Nome escrito não foi encontrado, tem certeza que o inseriu corretamente?");
        }
        
   }
   catch(IOException ex){

    System.Console.WriteLine("Erro" + ex.Message);
    System.Console.WriteLine("Tentando novamente em alguns segundos.");
    Thread.Sleep(5000);
    pesquisarDadoPorNomeParaTexto();
    return;
   }

   catch(Exception ex){

    System.Console.WriteLine("Ocorreu um Erro, tente novamente." + ex.Message);
   }
    }
    public void AlterarDadosLista(){

    try { 
        
    System.Console.WriteLine("Iremos repassar a Lista.");

    string  variavelAuxiliarId =  Convert.ToString(getIdPokedex());
    string dataCapConvetida = Convert.ToString(getDataCaptura());
    string nivelConvert = Convert.ToString(NivelPokemon);
    string shinyConvertido = Convert.ToString(variavelAuxiliarShiny);
    string pesoconvert = Convert.ToString(PesoPokemon);

    foreach(string element in listagem){
       
    if(element == getNomePokemon()){

        System.Console.WriteLine("Nome Pokemon: " + getNomePokemon());
    }
    
    else  if(element == getIdPokedex()){

        System.Console.WriteLine("ID: " + variavelAuxiliarId);
    }
    
    else if(element == dataCapConvetida){

        System.Console.WriteLine("Data de Captura : " + getDataCaptura());
    }
    
   else  if(element == nivelConvert){

        System.Console.WriteLine("Nivel Pokemon: " + getNivelPokemon());
    }
    
    else if(element == shinyConvertido){

        System.Console.WriteLine("É Shiny? : " + shinyConvertido);
}
    
    else if(element == pesoconvert){

        System.Console.WriteLine("Peso: " + pesoconvert);
    }
        }

        System.Console.WriteLine("-----------------------");
        System.Console.WriteLine("Quer Alterar o que ?");       
        String resposta = Console.ReadLine();

    if(resposta == "Nome".ToLower()){

            System.Console.WriteLine("-------------------------------");
            System.Console.WriteLine("Insira o Novo Nome: ");
            String novo_Nome = Console.ReadLine();

            setNomePokemon(novo_Nome);
            listagem.Add(novo_Nome);
            System.Console.WriteLine("Novo Nome: " + getNomePokemon());
        }
       else  if(resposta == "Id".ToLower()){

                System.Console.WriteLine("-----------------------------");
                System.Console.WriteLine("Insira um Novo ID");
                String novo_ID = Console.ReadLine();

                setIdPokedex(novo_ID);
                listagem.Add(novo_ID);
                System.Console.WriteLine("Novo ID: " + getIdPokedex());
            }
    
    else if(resposta == "Nivel".ToLower()){

                System.Console.WriteLine("-----------------------------");
                System.Console.WriteLine("Insira um Novo ID");
    
                 novoNivel = Convert.ToInt32(Console.ReadLine());
                 novoNivelString = Convert.ToString(novoNivel);
                setNivelPokemon(novoNivel);

                listagem.Add(novoNivelString);
                System.Console.WriteLine("Novo Nivel: " + getNivelPokemon());
    }

                else if(resposta == "Peso".ToLower()){
               
                System.Console.WriteLine("-----------------------------");
                System.Console.WriteLine("Insira o Novo Peso");
    
               novoPeso = Convert.ToDouble(Console.ReadLine());
               novoPesoString = Convert.ToString(novoPeso);

                setPesoPokemon (novoPeso);
                listagem.Add(novoPesoString);
                System.Console.WriteLine("Novo Peso: " + novoPesoString + kg);
    }
        else if(resposta == "Data".ToLower()){

                System.Console.WriteLine("-----------------------------");
                System.Console.WriteLine("Insira a nova Data da captura");
   
                 novaData = Convert.ToDateTime(Console.ReadLine());
                 novaDataString = Convert.ToString(novaData);
        
                setDataCaptura(novaData);
                listagem.Add(novaDataString);
                System.Console.WriteLine("Nova Data de Captura: " + novaDataString);     
        }

        else if(resposta == "Shiny".ToLower()){

                System.Console.WriteLine("-----------------------------");
                System.Console.WriteLine("Insira a nova Data da captura");

                 novoShiny = Convert.ToBoolean(Console.ReadLine());
                 novoShinyString = Convert.ToString(novoShiny);

                setEh_Pokemon_Shiny(novoShiny);
                listagem.Add(novoShinyString);
                System.Console.WriteLine("E Shiny ou Nao: " + novoShinyString);
        }       
    else {
        System.Console.WriteLine("Programa ainda rodando.........");
    }       
}
    catch(Exception Ex){

        System.Console.WriteLine("Error" + Ex.Message);
    }
}
public void PesquisarDadoNomeLista(){

        try{ 

            do { 
        System.Console.WriteLine("Se chegou aqui e porque voce procura por algum dado em especifico, escreva abaixo pelo que quer procura");
        String procura = Console.ReadLine();

        if(procura ==  "Nome".ToLower()){

            System.Console.WriteLine("E isso que procura? " + getNomePokemon());
        }
            else if(procura == "Id".ToLower()){

                System.Console.WriteLine("ID do pokemon: " + getIdPokedex());
            }

        else if(procura == "Nivel".ToLower()){
                                                            //Talvez tenha que mudar pro getNivelPokemon()
            System.Console.WriteLine("E isso que procura: " + "LVL: " + NivelPokemon);

        }
            else if(procura == "Shiny".ToLower()){

                System.Console.WriteLine("E Shiny: " + Eh_Pokemon_Shiny);
            }

        else if(procura == "Peso".ToLower()){

            System.Console.WriteLine("E isso que procura: " + PesoPokemon + kg);
        }

        else if(procura == "Data".ToLower()){

            System.Console.WriteLine("Data de Captura E: " + dataDaCaptura);
        }

            else{

                System.Console.WriteLine("Nao foi possível achar aquilo que queria.");
            }

        System.Console.WriteLine("Deseja procurar mais alguma coisa? [1] Para sim [2] Para nao");
         rp2 = Console.ReadLine();

}
while(rp2 != "2");
}
catch(Exception ex){

    System.Console.WriteLine("Algo de errado ocorreu" + ex.Message);
    }
}
public void ExcluirDadosParaLista(){

try { 

    System.Console.WriteLine("-----------------------------------");
    System.Console.WriteLine("O que exatamente voce quer Deletar");
    String RespostaFinal  = Console.ReadLine().ToLower();


        if(RespostaFinal == "Nome".ToLower() && getNomePokemon() != null){
            
            listagem.RemoveAll(l => l == getNomePokemon()  ||  l == NomePokemon);
            System.Console.WriteLine("Removendo nome......");


        }
            else if(RespostaFinal == "Id".ToLower()){

                System.Console.WriteLine("Removendo ID");
                listagem.Remove(getIdPokedex());


            }
            else if(RespostaFinal == "Peso".ToLower()){

                System.Console.WriteLine("Removendo peso.");
                listagem.Remove(novoPesoString);
            }

        else if(RespostaFinal == "Nivel"){

            System.Console.WriteLine("Removendo Nivel.");
            listagem.Remove(novoNivelString);
        }
        else if(RespostaFinal == "Shiny".ToLower()){

            System.Console.WriteLine("Removendo se e Shiny ou Nao");
            listagem.Remove(novoShinyString);

        }

    else if(RespostaFinal == "Data".ToLower()){

        System.Console.WriteLine("Removendo a Data da Captura");

        listagem.Remove(novaDataString);
    }

}
catch(Exception ex){

    System.Console.WriteLine("Algum erro Ocorreu" + ex.Message);
}
        }
    }   //Fim da classe.
} //Fim namespace.
