using System;

namespace Series
{
    class Program
    {

        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
             OperacoesLocadora();
        }

        private static string OpcoesLocadora(){

            Console.WriteLine();
            Console.WriteLine("Bem-Vindo à Block Buster Revival.");
            Console.WriteLine("Informe a Opção Desejada.");

            Console.WriteLine("1 - Séries.");
            Console.WriteLine("2 - Filmes.");
            Console.WriteLine("C - Limpar a Tela.");
            Console.WriteLine("X - Sair.");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            return opcaoUsuario;
            
        }

        private static void OperacoesLocadora(){

            string opcaoUsuario = OpcoesLocadora();

            while(opcaoUsuario.ToUpper() != "X"){
                switch(opcaoUsuario){
                    case "1":
                        OperacoesSeries();
                    break;
                    case "2":
                        OperacoesFilmes();
                    break;
                    case "C":
                        Console.Clear();
                        Console.WriteLine();
                    break;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        Console.WriteLine();
                    break;
                }

                opcaoUsuario = OpcoesLocadora();

            }

        }

        private static string ObterOpcaoUsuarioSerie()
        {
            Console.WriteLine();
            Console.WriteLine("Block Buster Revival - Séries");
            Console.WriteLine("Informe a Opção Desejada.");

            Console.WriteLine("1 - Listar Séries.");
            Console.WriteLine("2 - Inserir nova Série.");
            Console.WriteLine("3 - Atualizar Série.");
            Console.WriteLine("4 - Excluir Série.");
            Console.WriteLine("5 - Visualizar Série.");
            Console.WriteLine("C - Limpar Tela.");
            Console.WriteLine("X - Sair.");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            return opcaoUsuario;
        }

        private static void OperacoesSeries(){
             
            string opUsuario = ObterOpcaoUsuarioSerie();
            
            while(opUsuario.ToUpper() != "X"){

                switch(opUsuario){
                    case "1":
                        ListarSeries();
                    break;
                    case "2":
                        InserirSerie();
                    break;
                    case "3":
                        AtualizarSerie();
                    break;
                    case "4":
                        ExcluirSerie();
                    break;
                    case "5":
                        VizualizaSerie();
                    break;
                    case "C":
                        Console.Clear();
                    break;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                    break;
                }

                opUsuario = ObterOpcaoUsuarioSerie();
            }
            
        }

        private static string ObterOpcaoUsuarioFilme(){

            Console.WriteLine();
            Console.WriteLine("Block Buster Revival - Filmes");
            Console.WriteLine("Informe a Opção Desejada.");

            Console.WriteLine("1 - Listar Filmes.");
            Console.WriteLine("2 - Inserir Filme.");
            Console.WriteLine("3 - Atualizar Filme.");
            Console.WriteLine("4 - Excluir Filme.");
            Console.WriteLine("5 - Visualizar Filme.");
            Console.WriteLine("C - Limpar Tela.");
            Console.WriteLine("X - Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            return opcaoUsuario;

        }

        private static void OperacoesFilmes(){

            string opcao = ObterOpcaoUsuarioFilme();

            while(opcao != "X"){
                switch(opcao){
                    case "1":
                        //ListarFilmes();
                    break;
                    case "2":
                        //InsereFilme();
                    break;
                    case "3":
                        //AtualizaFilme();
                    break;
                    case "4":
                        //ExcluirFilme();
                    break;
                    case "5":
                        //VizualizaFilme();
                    break;
                    case "C":
                        Console.Clear();
                        Console.WriteLine();
                    break;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        Console.WriteLine();
                    break;

                }

                opcao = ObterOpcaoUsuarioFilme();
            }


        }

        private static void VizualizaSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            
            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);

        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Excluir(indiceSerie);

        }

        private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

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

            Serie novaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao

                                        );
            
            repositorio.Atualizar(indiceSerie, novaSerie);

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
                var excluido = serie.retornaExcluido();
                Console.WriteLine($"#ID {serie.retornaId()}: - {serie.retornaTitulo()} status: {excluido}");
            }
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
