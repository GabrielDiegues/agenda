using System;

namespace ConversorFusoHorario
{
    /// <summary>
    /// Interface que representa uma entrada de agenda, contendo data/hora e t�tulo do compromisso.
    /// </summary>
    public interface IAgendaEntrada
    {
        /// <summary>
        /// Data e hora do compromisso.
        /// </summary>
        DateTime DataHora { get; set; }

        /// <summary>
        /// T�tulo do compromisso.
        /// </summary>
        string Titulo { get; set; }

        /// <summary>
        /// Imprime a entrada completa (data/hora e t�tulo), convertendo a data/hora para o timezone informado, se fornecido.
        /// </summary>
        /// <param name="idFusoDestino">ID do fuso hor�rio de destino (opcional).</param>
        void Imprimir(string? idFusoDestino = null);

        /// <summary>
        /// Imprime apenas a hora do compromisso, convertendo para o timezone informado, se fornecido.
        /// </summary>
        /// <param name="idFusoDestino">ID do fuso hor�rio de destino (opcional).</param>
        void ImprimirHora(string? idFusoDestino = null);

        /// <summary>
        /// Imprime apenas o dia do compromisso, convertendo para o timezone informado, se fornecido.
        /// </summary>
        /// <param name="idFusoDestino">ID do fuso hor�rio de destino (opcional).</param>
        void ImprimirDia(string? idFusoDestino = null);

        /// <summary>
        /// Imprime o dia da semana do compromisso, convertendo para o timezone informado, se fornecido.
        /// </summary>
        /// <param name="idFusoDestino">ID do fuso hor�rio de destino (opcional).</param>
        void ImprimirDiaSemana(string? idFusoDestino = null);
    }
}
