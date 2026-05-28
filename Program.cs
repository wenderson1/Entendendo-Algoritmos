
#region Pesquisa Binária
static int? pesquisaBinaria(int[] vetor, int valor)
{
    int baixo = 0;
    int alto = vetor.Length - 1;


    while (baixo <= alto)
    {
        int meio = (baixo + alto) / 2;
        int chute = vetor[meio];

        if (valor.Equals(chute))
            return meio;
        else if (chute > valor)
            alto = meio - 1;
        else
            baixo = meio + 1;
    }

    return null;
}

int[] lista = [1, 3, 5, 7, 9, 11, 13, 15, 17, 19];
Console.WriteLine(pesquisaBinaria(lista, 3));
Console.WriteLine(pesquisaBinaria(lista, -1) is null ? "Não encontrado" : pesquisaBinaria(lista, -1).ToString());
#endregion