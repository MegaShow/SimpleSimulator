using System;

namespace SimpleSimulator.Core {
  public struct InsFormat {
    private string instruction;
    private Int32 machineCode;
    private bool isFormatR;

    public InsFormat(string ins, int opcode, string rs, string rt, string rd, int shamt, int funct) {
      instruction = ins;
      int rsNum = Convert.ToInt32(rs.Substring(1));
      int rtNum = Convert.ToInt32(rt.Substring(1));
      int rdNum = Convert.ToInt32(rd.Substring(1));
      Console.WriteLine($"{opcode} - {rsNum} - {rtNum} - {rdNum} - {shamt} - {funct}");
      machineCode = (opcode << 26) + (rsNum << 21) + (rtNum << 16) + (rdNum << 11) + (shamt << 6) + funct;
      isFormatR = true;
    }

    public Int32 GetMachineCode() {
      return machineCode;
    }

    public bool isFormatRIns() {
      return isFormatR;
    }
  }
}