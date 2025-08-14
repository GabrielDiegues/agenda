using System;

namespace ConversorFusoHorario
{
    /// <summary>
    /// Interface para convers�o de datas e hor�rios entre diferentes fusos hor�rios.
    /// </summary>
    public interface IConversorHora
    {
        /// <summary>
        /// Converte uma data/hora para o fuso hor�rio de destino informado.
        /// </summary>
        /// <param name="dataHora">Data e hora original.</param>
        /// <param name="idFusoDestino">ID do fuso hor�rio de destino.</param>
        /// <returns>Data e hora convertida para o fuso hor�rio de destino.</returns>
        DateTime ConverterParaFusoHorario(DateTime dataHora, string idFusoDestino);

        /// <summary>
        /// Obt�m o ID do fuso hor�rio correspondente � data/hora informada (em formato string).
        /// </summary>
        /// <param name="dataHoraStr">Data e hora em formato string.</param>
        /// <returns>ID do fuso hor�rio correspondente.</returns>
        string ObterFusoHorarioDaData(string dataHoraStr);
    }
}
