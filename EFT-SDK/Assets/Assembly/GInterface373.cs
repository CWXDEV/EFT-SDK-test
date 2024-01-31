using System;
using System.Threading.Tasks;

// Token: 0x02002D06 RID: 11526
public interface GInterface373<T> where T : struct, Enum
{
	// Token: 0x17002795 RID: 10133
	// (get) Token: 0x0600E283 RID: 57987
	bool Closed { get; }

	// Token: 0x17002796 RID: 10134
	// (get) Token: 0x0600E284 RID: 57988
	T ScreenType { get; }

	// Token: 0x0600E285 RID: 57989
	Task<bool> TryCloseScreen();
}
