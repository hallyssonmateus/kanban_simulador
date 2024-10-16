using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefasKanban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tarefasfazer = new List<string>();
            List<string> tarefasprogress = new List<string>();
            List<string> tarefasconcluidas = new List<string>();
            bool condição = true;
            while (condição)
            {
                Console.WriteLine("\n ------- Escolha uma opção: ----------");
                Console.WriteLine("1 - Adicionar nova tarefa");
                Console.WriteLine("2 - Exibir tarefas");
                Console.WriteLine("3 - Mover tarefa");
                Console.WriteLine("4 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite uma tarefa:");                        
                    string novatarefa = Console.ReadLine();
                        tarefasfazer.Add(novatarefa);
                        Console.WriteLine("Tarefa adicionada com sucesso\n");
                        break;
                    case 2:
                        Console.WriteLine("\nA fazer:");
                        // Listar as tarefas a fazer:
                        foreach(string afazer in tarefasfazer)
                        {
                            Console.WriteLine(afazer);
                        }
                        Console.WriteLine("\nEm progresso:");
                        // Listar as tarefas em progress:
                        foreach (string progress in tarefasprogress)
                        {
                            Console.WriteLine(progress);
                        }
                        Console.WriteLine("\nConcluidas:");
                        // Listar as tarefas concluidas:
                        foreach (string concluida in tarefasconcluidas)
                        {
                            Console.WriteLine(concluida);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nEscolha de qual lista você quer mover uma tarefa:");
                        Console.WriteLine("1 - A Fazer");
                        Console.WriteLine("2 - Em Progresso");
                        Console.WriteLine("3 - Concluído");

                        int listaEscolhida = int.Parse(Console.ReadLine());
                        List<string> listaOrigem = null;
                        List<string> listaDestino = null;

                        switch (listaEscolhida)
                        {
                            case 1:
                                listaOrigem = tarefasfazer;
                                Console.WriteLine("Você escolheu a lista 'A Fazer'.");
                                break;
                            case 2:
                                listaOrigem = tarefasprogress;
                                Console.WriteLine("Você escolheu a lista 'Em Progresso'.");
                                break;
                            case 3:
                                listaOrigem = tarefasconcluidas;
                                Console.WriteLine("Você escolheu a lista 'Concluído'.");
                                break;
                            default:
                                Console.WriteLine("Opção inválida.");
                                return;
                        }

                        Console.WriteLine("\nEscolha a tarefa que deseja mover:");
                        for (int i = 0; i < listaOrigem.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {listaOrigem[i]}");
                        }

                        int tarefaEscolhida = int.Parse(Console.ReadLine());

                        string tarefa = listaOrigem[tarefaEscolhida - 1];

                        Console.WriteLine("\nPara qual lista deseja mover?");
                        Console.WriteLine("1 - Em Progresso");
                        Console.WriteLine("2 - Concluído");
                        Console.WriteLine("3 - A Fazer");

                        int destinoEscolhido = int.Parse(Console.ReadLine());

                        switch (destinoEscolhido)
                        {
                            case 1:
                                listaDestino = tarefasprogress;
                                break;
                            case 2:
                                listaDestino = tarefasconcluidas;
                                break;
                            case 3:
                                listaDestino = tarefasfazer;
                                break;
                            default:
                                Console.WriteLine("Destino inválido.");
                                return;
                        }

                        // Remover a tarefa da lista de origem
                        listaOrigem.Remove(tarefa);
                        // Adicionar tarefa à lista de destino
                        listaDestino.Add(tarefa);

                        Console.WriteLine("Tarefa movida com sucesso!\n");
                        break;
                    case 4:
                        Console.WriteLine("Saindo..");
                        // Lógica para adicionar tarefa
                        condição = false;
                        break;
                    default:
                        Console.WriteLine("Opção Invalida, tente novamente");
                        // Lógica para adicionar tarefa
                        break;
                }
            }            
        }
    }
}
