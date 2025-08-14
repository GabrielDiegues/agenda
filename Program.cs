// Fazer a opção de criar compromisso

using System;
using ConversorFusoHorario;

// See https://aka.ms/new-console-template for more information

List<IAgendaEntrada> agenda = new List<IAgendaEntrada>();

Dictionary<int, string> timezones = new Dictionary<int, string>{
    { 1, "BR" },
    {2, "CA" }
};

// Funções
int criarMenu(string opcoes, int totalOpcoes)
{
    int inputUsuario = 0;
    do
    {
        Console.WriteLine(opcoes);
        try
        {
            inputUsuario = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Por favor, insira um número válido");
        }
    }
    while (!(inputUsuario >= 1 && inputUsuario <= totalOpcoes));
    return inputUsuario;
}


void exibirCompromissosHoje(int timeZone)
{
    string? fuso = timezones.ContainsKey(timeZone) ? timezones[timeZone] : null;
    foreach (IAgendaEntrada compromisso in agenda)
    {
        compromisso.Imprimir(fuso);
    }
}


void exibirCompromissosEspecifico(DateTime data, int timeZone)
{
    string? fuso = timezones.ContainsKey(timeZone) ? timezones[timeZone] : null;
    foreach (IAgendaEntrada compromisso in agenda)
    {
        if(compromisso.DataHora.Date == data.Date)
        {
            Console.WriteLine(compromisso);
        }
    }
}


int menuTimezone()
{
    int inputUsuario = criarMenu("Escolha um timezone:\n1- Brasil\n2- Canadá", 2);
    return inputUsuario;
}

// Main program
while (true)
{
    Console.WriteLine("Bem-vindo a agenda");
    int opcaoUsuario = criarMenu("1- Exibir compromissos\n2- Criar um compromisso", 2);

    switch (opcaoUsuario)
    {
        case 1:
            opcaoUsuario = criarMenu("1- Exibir compromissos do dia de hoje\n2- Exibir compromissos de um dia em específico", 2);
            int opcaoTimezone = menuTimezone();
            if (opcaoUsuario == 1)
            {
                exibirCompromissosHoje(opcaoTimezone);
            }

            else
            {
                DateTime dataConvertida;
                string dataUsuario = "";
                do
                {
                    Console.WriteLine("Digite uma data no formato: dd/mm/yyyy");
                    dataUsuario = Console.ReadLine();
                } while (DateTime.TryParseExact(dataUsuario, "dd/mm/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out dataConvertida));

                exibirCompromissosEspecifico(dataConvertida, opcaoTimezone);
            }
            break;

        case 2:

            break;
    }
}
