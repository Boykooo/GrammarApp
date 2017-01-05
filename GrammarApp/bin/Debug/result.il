
.assembly program
{
}

.class public Program
{
   .field private static int32 k 
  .method public static void main() cil managed {
    .entrypoint
    .locals init (
    )
    L_000000: call void Program::Temp()  
    L_000001: nop 
    L_000002: call int32 [mscorlib]System.Console::Read() 
    L_000003: pop 
    L_000004: ret 
  }
  .method public static void Temp() cil managed {
    .locals init (
      [0] int32,
      [1] int32,
      [2] int32[] arr,
      [3] int32,
      [4] int32,
      [5] int32 
    )
    L_000005: ldc.i4 2 
    L_000006: stloc 0 
    L_000007: ldc.i4 3 
    L_000008: stloc 1 
    L_000009: ldloc 0 
    L_000010: ldc.i4 2 
    L_000011: mul 
    L_000012: stloc 1 
    L_000013: ldloc 0 
    L_000014: ldloc 1 
    L_000015: clt 
    L_000016: brfalse L_000019 
    L_000017: ldloc 1 
    L_000018: call void [mscorlib]System.Console::Write(int32) 
    L_000019: call void [mscorlib]System.Console::WriteLine() 
    L_000020: nop 
    L_000021: ldc.i4 15 
    L_000022: newarr int32 
    L_000023: stloc 2 
    L_000024: ldc.i4 0 
    L_000025: stloc 3 
    L_000026: ldloc 3 
    L_000027: ldc.i4 10 
    L_000028: clt 
    L_000029: brfalse L_000043 
    L_000030: ldloc 2 
    L_000031: ldloc 3 
    L_000032: ldloc 3 
    L_000033: stelem.i4 
    L_000034: ldloc 2 
    L_000035: ldloc 3 
    L_000036: ldelem.i4 
    L_000037: call void [mscorlib]System.Console::Write(int32) 
    L_000038: ldloc 3 
    L_000039: ldc.i4 1 
    L_000040: add 
    L_000041: stloc 3 
    L_000042: br L_000026 
    L_000043: ldc.i4 0 
    L_000044: stloc 3 
    L_000045: ldloc 3 
    L_000046: ldc.i4 10 
    L_000047: clt 
    L_000048: brfalse L_000093 
    L_000049: ldc.i4 0 
    L_000050: stloc 5 
    L_000051: ldloc 5 
    L_000052: ldc.i4 9 
    L_000053: clt 
    L_000054: brfalse L_000088 
    L_000055: ldloc 2 
    L_000056: ldloc 5 
    L_000057: ldelem.i4 
    L_000058: ldloc 2 
    L_000059: ldloc 5 
    L_000060: ldc.i4 1 
    L_000061: add 
    L_000062: ldelem.i4 
    L_000063: clt 
    L_000064: brfalse L_000083 
    L_000065: ldloc 2 
    L_000066: ldloc 5 
    L_000067: ldelem.i4 
    L_000068: stloc 4 
    L_000069: ldloc 2 
    L_000070: ldloc 5 
    L_000071: ldloc 2 
    L_000072: ldloc 5 
    L_000073: ldc.i4 1 
    L_000074: add 
    L_000075: ldelem.i4 
    L_000076: stelem.i4 
    L_000077: ldloc 2 
    L_000078: ldloc 5 
    L_000079: ldc.i4 1 
    L_000080: add 
    L_000081: ldloc 4 
    L_000082: stelem.i4 
    L_000083: ldloc 5 
    L_000084: ldc.i4 1 
    L_000085: add 
    L_000086: stloc 5 
    L_000087: br L_000051 
    L_000088: ldloc 3 
    L_000089: ldc.i4 1 
    L_000090: add 
    L_000091: stloc 3 
    L_000092: br L_000045 
    L_000093: call void [mscorlib]System.Console::WriteLine() 
    L_000094: nop 
    L_000095: ldc.i4 0 
    L_000096: stloc 3 
    L_000097: ldloc 3 
    L_000098: ldc.i4 10 
    L_000099: clt 
    L_000100: brfalse L_000110 
    L_000101: ldloc 2 
    L_000102: ldloc 3 
    L_000103: ldelem.i4 
    L_000104: call void [mscorlib]System.Console::Write(int32) 
    L_000105: ldloc 3 
    L_000106: ldc.i4 1 
    L_000107: add 
    L_000108: stloc 3 
    L_000109: br L_000097 
    L_000110: ret 
  }


}
