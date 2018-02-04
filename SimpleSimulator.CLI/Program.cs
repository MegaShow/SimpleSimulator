using System;
using SimpleSimulator;

namespace SimpleSimulator.CLI {
  class Program {
    static void Main(string[] args) {
      if (args.Length == 1) {
        args[0] = args[0].ToLower();
        switch (args[0]) {
          case "-v":
          case "--version": {
            Console.WriteLine(Simulator.Version());
            break;
          }
        }
      } else if (args.Length > 1) {
        Console.WriteLine("To much parameters.");
      } else {
        Simulator mips = new Simulator("MIPS");
        Console.Write("mips> ");
        string str;
        while ((str = Console.ReadLine()) != null) {
          Console.Write(mips.Run(str));
          Console.Write("mips> ");
        }
        Console.WriteLine("Exit: null");
      }
    }
  }
}
