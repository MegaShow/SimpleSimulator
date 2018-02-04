using System;

namespace SimpleSimulator.Core {
  public class MIPS {
    private Int32[] register;

    public MIPS() {
      register = new Int32[32];
    }

    public Int32 Translate(string instruction) {
      string ins = string.Empty;
      string[] key = new string[3];
      bool inGetIns = true, inGetKey = false;
      int index = 0;
      for (int i = 0; i < instruction.Length; i++) {
        if (instruction[i] == ' ') continue;
        if (inGetIns) {
          while (i < instruction.Length && instruction[i] != ' ') {
            ins += instruction[i];
            i++;
          }
          inGetIns = false;
          inGetKey = true;
        } else {
          while (inGetKey && i < instruction.Length && instruction[i] != ' ' && instruction[i] != ',') {
            key[index] += instruction[i];
            i++;
          }
          inGetKey = false;
          if (i < instruction.Length && instruction[i] == ',') {
            index++;
            inGetKey = true;
          }
        }
      }
      InsFormat insformat;
      bool isFormatR = false;
      int opcode = 0, shamt = 0, funct = 0;
      switch (ins) {
        case "add":
          isFormatR = true;
          opcode = 0;
          shamt = 0;
          funct = 32;
          break;
        case "sub":
          isFormatR = true;
          opcode = 0;
          shamt = 0;
          funct = 34;
          break;
      }
      if (isFormatR) {
        insformat = new InsFormat(ins, opcode, key[1], key[2], key[0], shamt, funct);
      } else {
        return 0;
      }
      return insformat.GetMachineCode();
    }
  }
}
