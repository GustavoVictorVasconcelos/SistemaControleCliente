

using CodificacaoAT.Classes;

string? opcao = "";
PessoaJuridica metodosPJ =new PessoaJuridica();
do
{
    Console.Clear(); 

    
    Console.WriteLine(@"
    
    1 - Cadastrar PJ
    2 - Listar PJ
    0 - Sair
    ");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1": 
            PessoaJuridica pj = new PessoaJuridica();

            Console.WriteLine("Informe o nome da PJ: ");
            pj.Nome = Console.ReadLine();

            Console.WriteLine("Informe o rendimento da PJ: ");
            pj.Rendimento = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o CNPJ da PJ: ");
            pj.CNPJ = Console.ReadLine();

            metodosPJ.Inserir(pj);

            Console.WriteLine("Pessoa Juridica cadastrada com sucesso");
            Console.ReadLine();
            break;

        case "2":
        
            Console.WriteLine("Digite o nome da PJ: ");

            
            string? nomePJ = Console.ReadLine();

            
            PessoaJuridica pjLida = metodosPJ.Ler(nomePJ!);

            Console.WriteLine($@"

                Nome: {pjLida.Nome}
                Rendimento: R${pjLida.Rendimento},00
                Cpnj: {pjLida.CNPJ}
            ");

            
            Console.Read();
            break;

        default:
            break;
    }
    
} while (opcao != "0");