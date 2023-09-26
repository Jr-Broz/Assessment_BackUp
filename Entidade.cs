using System;
namespace Assessment{
internal class Entidade : FuncoesMenu{

     
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
    }
}
