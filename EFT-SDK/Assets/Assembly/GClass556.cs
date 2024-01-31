using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x0200057A RID: 1402
public class GClass556 : IDisposable
{
	// Token: 0x06002186 RID: 8582 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400203E RID: 8254
	public int responseCode;

	// Token: 0x0400203F RID: 8255
	public Dictionary<string, string> responseHeaders;

	// Token: 0x04002040 RID: 8256
	public byte[] responseData;

	// Token: 0x04002041 RID: 8257
	public int responseDataLength;

	// Token: 0x04002042 RID: 8258
	public string responseText;

	// Token: 0x04002043 RID: 8259
	public Stopwatch stopwatch;

	// Token: 0x04002044 RID: 8260
	public string errorText;
}
