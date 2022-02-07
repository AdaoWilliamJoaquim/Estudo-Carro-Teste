// See https://aka.ms/new-console-template for more information
using EstudoCarro;

Console.WriteLine("Ola Mundo");
carro carro = new carro();
carro.SetCarName(" La Ferrari");
carro.Turnon();
Start(carro);
 
 static void Start(carro car)
{ 
    Console.Clear();

    if (car.on) 
    {
        Console.WriteLine("\t **********");
        Console.WriteLine("\t Car turned On");
        Console.WriteLine("\t **********");
        Console.WriteLine("\t Name :"+car.ReturnCarName());
        Console.WriteLine("\t Speed :" + car.ReturnSpeed());
    }
    else 
    {
        car.speed=0; 
        Console.WriteLine("\t **********");
        Console.WriteLine("\t Car turned On");
        Console.WriteLine("\t **********");
        Console.WriteLine("\t Name :" + car.ReturnCarName());
        Console.WriteLine("\t Speed :" + car.ReturnSpeed());
    }
    Console.WriteLine("\t ----------");
    Console.WriteLine("\t What would you like to do? ");
    Console.WriteLine("\t accelerate car? Type 1 ");
    Console.WriteLine("\t Breake car? Type 2 ");
    if (!car.on)
        Console.WriteLine("\t Turn the car ON? Type 3 ");
    else
        Console.WriteLine("\t Turn the car OFF? Type 3 ");

    Console.WriteLine("\t  Type 4 to exit");

    string escolha = Console.ReadLine();
        var escolhaint=Convert.ToInt32(escolha);

    if ((escolhaint == 1 || escolhaint == 2) && !car.on)
    {

        Console.WriteLine("\t First you need to turn the car ON ");
        Thread.Sleep(3000);

        Start(car);

    }
    switch (escolhaint)
    {

        case 1:

            car.Aceleratecar();
            Start(car);
            break;
        case 2:

            car.BreakCar();
            Start(car);
            break;

        case 3:
            if (car.retunTurnon())
            {
                car.off();
            }
            else
            {
                car.Turnon();

            }
            Start(car);
            break;

        case 4:
            Console.WriteLine("\t PRESS ANY NUMBER TO FINISH ");



            car.Aceleratecar();
            ;
            break;
        default:
            Start(car);
            break;

    }



}

