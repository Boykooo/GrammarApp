
.assembly program
{
}

.class public Program
{
   .field private static int32[] arr 
   .field private static int32 k 
  .method public static void InitValue() cil managed {
    .locals init (
      [0] int32 
    )
    L_000000: ldc.i4 0 
    L_000001: stloc 0 
    L_000002: ldloc 0 
    L_000003: ldc.i4 10 
    L_000004: clt 
    L_000005: brfalse L_000015 
    L_000006: ldsfld  int32[] Program::arr 
    L_000007: ldloc 0 
    L_000008: ldloc 0 
    L_000009: stelem.i4 
    L_000010: ldloc 0 
    L_000011: ldc.i4 1 
    L_000012: add 
    L_000013: stloc 0 
    L_000014: br L_000002 
    L_000015: ret 
  }
  .method public static void Output() cil managed {
    .locals init (
      [0] int32 
    )
    L_000016: ldc.i4 0 
    L_000017: stloc 0 
    L_000018: ldloc 0 
    L_000019: ldc.i4 10 
    L_000020: clt 
    L_000021: brfalse L_000031 
    L_000022: ldsfld  int32[] Program::arr 
    L_000023: ldloc 0 
    L_000024: ldelem.i4 
    L_000025: call void [mscorlib]System.Console::Write(int32) 
    L_000026: ldloc 0 
    L_000027: ldc.i4 1 
    L_000028: add 
    L_000029: stloc 0 
    L_000030: br L_000018 
    L_000031: ret 
  }
  .method public static void Sort() cil managed {
    .locals init (
      [0] int32,
      [1] int32,
      [2] int32 
    )
    L_000032: ldc.i4 0 
    L_000033: stloc 1 
    L_000034: ldloc 1 
    L_000035: ldc.i4 10 
    L_000036: clt 
    L_000037: brfalse L_000082 
    L_000038: ldc.i4 0 
    L_000039: stloc 2 
    L_000040: ldloc 2 
    L_000041: ldc.i4 9 
    L_000042: clt 
    L_000043: brfalse L_000077 
    L_000044: ldsfld  int32[] Program::arr 
    L_000045: ldloc 2 
    L_000046: ldelem.i4 
    L_000047: ldsfld  int32[] Program::arr 
    L_000048: ldloc 2 
    L_000049: ldc.i4 1 
    L_000050: add 
    L_000051: ldelem.i4 
    L_000052: clt 
    L_000053: brfalse L_000072 
    L_000054: ldsfld  int32[] Program::arr 
    L_000055: ldloc 2 
    L_000056: ldelem.i4 
    L_000057: stloc 0 
    L_000058: ldsfld  int32[] Program::arr 
    L_000059: ldloc 2 
    L_000060: ldsfld  int32[] Program::arr 
    L_000061: ldloc 2 
    L_000062: ldc.i4 1 
    L_000063: add 
    L_000064: ldelem.i4 
    L_000065: stelem.i4 
    L_000066: ldsfld  int32[] Program::arr 
    L_000067: ldloc 2 
    L_000068: ldc.i4 1 
    L_000069: add 
    L_000070: ldloc 0 
    L_000071: stelem.i4 
    L_000072: ldloc 2 
    L_000073: ldc.i4 1 
    L_000074: add 
    L_000075: stloc 2 
    L_000076: br L_000040 
    L_000077: ldloc 1 
    L_000078: ldc.i4 1 
    L_000079: add 
    L_000080: stloc 1 
    L_000081: br L_000034 
    L_000082: ret 
  }
  .method public static void Rec() cil managed {
    .locals init (
    )
    L_000083: ldsfld  int32 Program::k 
    L_000084: ldc.i4 5 
    L_000085: clt 
    L_000086: brfalse L_000096 
    L_000087: ldsfld  int32 Program::k 
    L_000088: ldc.i4 1 
    L_000089: add 
    L_000090: stsfld  int32 Program::k 
    L_000091: call void [mscorlib]System.Console::WriteLine() 
    L_000092: nop 
    L_000093: ldsfld  int32 Program::k 
    L_000094: call void [mscorlib]System.Console::Write(int32) 
    L_000095: call void Program::Rec()  
    L_000096: ret 
  }
  .method public static void main() cil managed {
    .entrypoint
    .locals init (
    )
    L_000097: ldc.i4 10 
    L_000098: newarr int32 
    L_000099: stsfld int32[] Program::arr 
    L_000100: ldc.i4 0 
    L_000101: stsfld  int32 Program::k 

    L_000102: call void Program::InitValue()  
    L_000103: call void Program::Output()  
    L_000104: call void [mscorlib]System.Console::WriteLine() 
    L_000105: nop 
    L_000106: call void Program::Sort()  
    L_000107: call void Program::Output()  
    L_000108: call void [mscorlib]System.Console::WriteLine() 
    L_000109: nop 
    L_000110: call void Program::Rec()  
    L_000111: nop 
    L_000112: call int32 [mscorlib]System.Console::Read() 
    L_000113: pop 
    L_000114: ret 
  }


}
