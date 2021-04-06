using System;

namespace Series
{
    class Program
    {

        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            
            string opUsuario = ObterOpcaoUsuario();
            
            while(opUsuario.ToUpper() != "X"){

                switch(opUsuario){
                    case "1":
                        ListarSeries();
                    break;
                    case "2":
                        InserirSerie();
                    break;
                    case "3":
                        //AtualizarSerie();
                    break;
                    case "4":
                        //ExcluirSerie();
                    break;
                    case "5":
                        //VizualizaSerie();
                    break;
                    case "C":
                        Console.Clear();
                    break;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                    break;
                }

                opUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
            
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar Séries.");

            var lista = repositorio.Lista();

            if(lista.Count == 0){
                Console.WriteLine("Nenhuma série cadastrada.");
                return;

            }

            foreach(var serie in lista){
                Console.WriteLine($"#ID {serie.retornaId()}: - {serie.retornaTitulo()}");
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Block Buster Revival");
            Console.WriteLine("Informe a opção desejada.");

            Console.WriteLine("1 - Listar Séries.");
            Console.WriteLine("2 - Inserir nova série.");
            Console.WriteLine("3 - Atualizar Série.");
            Console.WriteLine("4 - Excluir Série.");
            Console.WriteLine("5 - Visualizar Série.");
            Console.WriteLine("C - Limpar Tela.");
            Console.WriteLine("X - Sair.");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        private static void InserirSerie()
        {

            Console.WriteLine("Inserir nova série.");
            foreach(int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.WriteLine("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de lançamento: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao

                                        );
            
            repositorio.Insere(novaSerie);

        }



    }
}
