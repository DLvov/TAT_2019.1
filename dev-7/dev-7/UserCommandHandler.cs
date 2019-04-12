using System;

namespace dev_7
{
    class UserCommandHandler
    {
        private enum UserCommands
        {
            CountAll = 1,
            CountTypes,
            AveragePrice,
            AveragePriceType,
            Execute,
            Exit
        }
        
        public VehicleCatalog Catalog { get; set; }
        public Command Command { get; set; }

        public UserCommandHandler(VehicleCatalog catalog)
        {
            this.Catalog = catalog;
        }

        public void RequestUserCommand()
        {
            DisplayInfo();
            while (int.TryParse(Console.ReadLine(), out int userCommandNumber) && (UserCommands)userCommandNumber != UserCommands.Exit)
            {
                switch ((UserCommands)userCommandNumber)
                {
                    case UserCommands.CountAll:
                        this.Command = new CountAllCommand(this.Catalog);
                        Command.Execute();
                        break;
                    case UserCommands.CountTypes:
                        this.Command = new CountTypesCommand(this.Catalog);
                        Command.Execute();
                        break;
                    case UserCommands.AveragePrice:
                        this.Command = new AveragePriceCommand(this.Catalog);
                        Command.Execute();
                        break;
                    case UserCommands.AveragePriceType:
                        Console.WriteLine("Enter brand");
                        this.Command = new AveragePriceTypeCommand(this.Catalog, Console.ReadLine());
                        Command.Execute();
                        break;
                    case UserCommands.Execute:
                        this.Command = new ExcecuteCommand(this.Catalog);
                        Command.Execute();
                        break;
                    default:
                        Console.WriteLine("Unknown command!");
                        DisplayInfo();
                        break;
                }
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("-----------------------------------\n" + "Enter command(1-6):\n" + "1. Count all\n" + "2. Count types\n" +
                "3. Average price\n" + "4. Average price type\n" + "5. Execute\n" + "6. Exit" + "-----------------------------------");
        }
    }
}
