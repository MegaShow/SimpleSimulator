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
      } else {
        Console.WriteLine("Fewer parameters or to much parameters.");
      }
    }
  }
}
