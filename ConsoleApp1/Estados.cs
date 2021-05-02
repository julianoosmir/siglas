using System;
using System.Collections.Generic;

static public class Siglas
{
    public static string[] estados = {
        "Acre", "Alagoas", "Amapá","Amazonas","Bahia","Ceará","Distrito Federal","Espirito Santo",
        "Goiás","Maranhão","Mato Grosso","Mato Grosso do Sul","Minas Gerais","Pará",
        "Paraíba","Paraná","Pernambuco","Piauí","Rio de Janeiro","Rio Grande do Norte",
        "Rio Grande do Sul","Rondônia","Roraima","Santa Catarina","São Paulo","Sergipe",
        "Tocantins",
        };
    public static string[] siglas ={
        "AC","AL","AP","AM","BA","CE","DF","ES","GO","MA","MT","MS","MG","PA","PB","PR",
        "PE","PI","RJ","RN","RS","RO","RR","SC","SP","SE","TO"
    };
    public static string EstadoPorSigla(string sigla)
    {
        string aux = "estado nao exite";

        for (int i = 0; i < siglas.Length; i++)
        {
            if (siglas[i] == sigla) aux = estados[i];
        }
        return aux;
    }

}

