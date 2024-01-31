using System;
using System.Runtime.InteropServices;

// Token: 0x0200010A RID: 266
[StructLayout(LayoutKind.Auto)]
public struct AICoreActionResultStruct<T>
{
	// Token: 0x040006AC RID: 1708
	public T Action;

	// Token: 0x040006AD RID: 1709
	public string Reason;
}
