using System.Security.Cryptography;

int Player=0, Maquina=0, rodada=0;

    Console.WriteLine("--------------------------------------------------------------------");
    Console.WriteLine("CORRIDA DE DADOS");
    Console.WriteLine("--------------------------------------------------------------------");
    Console.WriteLine("Tamanho da pista: 30 casas\n");
    Console.WriteLine("Eventos especiais:");
    Console.WriteLine("-Caso o competidor caia nas casas 5, 10 e 20, ele avanca 3 casas;");
    Console.WriteLine("-Caso o competidor caia nas casas 7, 13 e 20 ele recua 2 casas;");
    Console.WriteLine("-Caso o valor do dado caia no 6, o competidor ganha um turno extra.\n\n");
    Console.ReadLine();

    while(true == true)
    {
        int roldado = RandomNumberGenerator.GetInt32(1, 6);
        int roldado1 = RandomNumberGenerator.GetInt32(1, 6);
        int roldado2 = RandomNumberGenerator.GetInt32(1, 6);
        int roldado3 = RandomNumberGenerator.GetInt32(1, 6);
        int roldado4 = RandomNumberGenerator.GetInt32(1, 6);

        Console.Clear();
        rodada++;
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("Rodada: " + rodada);
        Console.WriteLine("Sua Posicao: " + Player);
        Console.WriteLine("Posicao Maquina: " + Maquina);
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("Pressione Enter para jogar o dado\n");
        Console.ReadLine();

        Console.WriteLine("Seu dado: " + roldado + "\n");
        Player = Player + roldado;
        Console.ReadLine();
        Console.WriteLine("Dado Maquina: " + roldado2 + "\n");
        Maquina = Maquina + roldado2;
        Console.ReadLine();

        //Bonus avanco extra
        
        if(Player == 5 || Player == 10 || Player ==15 )
        {
            Console.WriteLine("Bonus!! Voce avanca 3 casas\n");
            Player = Player +3;
            Console.ReadLine();
        }

        if(Maquina == 5 || Maquina == 10 || Maquina ==15 )
        {
            Console.WriteLine("Bonus!! A Maquina avanca 3 casas\n");
            Maquina = Maquina +3;
            Console.ReadLine();
        }

        //Penalidade

        if(Player == 7 || Player == 13 || Player == 20)
        {
            Console.WriteLine("A casa " + Player + " é amaldiçoada volte 2 casas.");
            Player = Player - 2;
            Console.ReadLine();
        }

        if(Maquina == 7 || Maquina == 13 || Maquina == 20)
        {
            Console.WriteLine("A casa " + Maquina + " é amaldiçoada a maquina volta 2 casas.");
            Maquina = Maquina - 2;
            Console.ReadLine();
        }

        // Turno extra

        if(roldado == 6)
        {
            Console.WriteLine("O dado caiu no 6 e voce ganhou mais um turno!");
            Console.WriteLine("Jogue o dado novamente (enter)...");
            Console.WriteLine("Seu dado: " + roldado3);

        Player = Player + roldado3;
        }

        if(roldado2 == 6)
        {
            Console.WriteLine("O dado da maquina caiu no 6 e ela ganhou mais um turno!");
            Console.WriteLine("Digite enter para continuar...");
            Console.WriteLine("Dado da Maquina: " + roldado4);

            Maquina = Maquina + roldado4;
        }

        //Checa o ganhador

        if(Player >= 30)
        {
            
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Você ganhou!!");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Digite enter para jogar novamente...");
            Console.ReadLine();
            rodada = 0;
            Player = 0;
            Maquina = 0;

            
        }
        else if(Maquina >= 30)
        {
            
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Você perdeu :C");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Digite enter para jogar novamente...");
            Console.ReadLine();
            rodada = 0;
            Player = 0;
            Maquina = 0;
            
        }


    }
