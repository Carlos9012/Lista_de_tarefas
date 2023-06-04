using System.ComponentModel;

namespace ListaDeTarefas.Enums
{
    public enum StatusTarefa
    {
        [Description("A fazer")]
        Afazer = 1,
        [Description("Em andamento")]
        EmAndamento = 2,
        [Description("Concluido")]
        Cocluido = 3

    }
}
