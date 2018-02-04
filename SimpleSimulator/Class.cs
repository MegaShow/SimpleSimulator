using System;
using SimpleSimulator.Core;

namespace SimpleSimulator {
  public class Simulator {
    private MIPS mips;

    public static string Version() {
      return "SimpleSimulator MIPS32 Alpha Version";
    }

    public Simulator(string ver) {
      switch (ver) {
        case "MIPS": {
          mips = new MIPS();
          break;
        }
      }
    }

    public string Run(string instruction) {
      if (instruction.Length == 0) return String.Empty;
      Int32 code = mips.Translate(instruction);
      return instruction + '\n' + Convert.ToString(code, 2).PadLeft(32, '0') + '\n';
    }
  }
}
