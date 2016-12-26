
.assembly program
{
}

.class public Program
{
  .method public static void main() cil managed {
    .entrypoint
    .locals init (
      [0] int32,
      [1] int32,
      [2] int32[] arr,
      [3] int32,
      [4] int32,
      [5] int32 
    )
    L_000000: ldc.i4 2 
    L_000001: stloc 0 
    L_000002: ldc.i4 3 
    L_000003: stloc 1 
    L_000004: ldloc 0 
    L_000005: ldc.i4 2 
    L_000006: mul 
    L_000007: stloc 1 
    L_000008: ldloc 0 
    L_000009: ldloc 1 
    L_000010: clt 
    L_000011: brfalse L_000014 
    L_000012: ldloc 1 
    L_000013: call void [mscorlib]System.Console::Write(int32) 
    L_000014: ldc.i4 15 
    L_000015: newarr int32 
    L_000016: stloc 2 
    L_000017: ldc.i4 0 
    L_000018: stloc 3 
    L_000019: ldloc 3 
    L_000020: ldc.i4 10 
    L_000021: clt 
    L_000022: brfalse L_000036 
    L_000023: ldloc 2 
    L_000024: ldloc 3 
    L_000025: ldloc 3 
    L_000026: stelem.i4 
    L_000027: ldloc 2 
    L_000028: ldloc 3 
    L_000029: ldelem.i4 
    L_000030: call void [mscorlib]System.Console::Write(int32) 
    L_000031: ldloc 3 
    L_000032: ldc.i4 1 
    L_000033: add 
    L_000034: stloc 3 
    L_000035: br L_000019 
    L_000036: ldc.i4 0 
    L_000037: stloc 3 
    L_000038: ldloc 3 
    L_000039: ldc.i4 10 
    L_000040: clt 
    L_000041: brfalse L_000086 
    L_000042: ldc.i4 0 
    L_000043: stloc 5 
    L_000044: ldloc 5 
    L_000045: ldc.i4 9 
    L_000046: clt 
    L_000047: brfalse L_000081 
    L_000048: ldloc 2 
    L_000049: ldloc 5 
    L_000050: ldelem.i4 
    L_000051: ldloc 2 
    L_000052: ldloc 5 
    L_000053: ldc.i4 1 
    L_000054: add 
    L_000055: ldelem.i4 
    L_000056: clt 
    L_000057: brfalse L_000076 
    L_000058: ldloc 2 
    L_000059: ldloc 5 
    L_000060: ldelem.i4 
    L_000061: stloc 4 
    L_000062: ldloc 2 
    L_000063: ldloc 5 
    L_000064: ldloc 2 
    L_000065: ldloc 5 
    L_000066: ldc.i4 1 
    L_000067: add 
    L_000068: ldelem.i4 
    L_000069: stelem.i4 
    L_000070: ldloc 2 
    L_000071: ldloc 5 
    L_000072: ldc.i4 1 
    L_000073: add 
    L_000074: ldloc 4 
    L_000075: stelem.i4 
    L_000076: ldloc 5 
    L_000077: ldc.i4 1 
    L_000078: add 
    L_000079: stloc 5 
    L_000080: br L_000044 
    L_000081: ldloc 3 
    L_000082: ldc.i4 1 
    L_000083: add 
    L_000084: stloc 3 
    L_000085: br L_000038 
    L_000086: call void [mscorlib]System.Console::WriteLine() 
    L_000087: nop 
    L_000088: ldc.i4 0 
    L_000089: stloc 3 
    L_000090: ldloc 3 
    L_000091: ldc.i4 10 
    L_000092: clt 
    L_000093: brfalse L_000103 
    L_000094: ldloc 2 
    L_000095: ldloc 3 
    L_000096: ldelem.i4 
    L_000097: call void [mscorlib]System.Console::Write(int32) 
    L_000098: ldloc 3 
    L_000099: ldc.i4 1 
    L_000100: add 
    L_000101: stloc 3 
    L_000102: br L_000090 
    L_000103: nop 
    L_000104: call int32 [mscorlib]System.Console::Read() 
    L_000105: pop 
    L_000106: ret 
  }


}
