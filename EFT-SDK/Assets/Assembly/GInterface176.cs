using System;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x02001C65 RID: 7269
public interface GInterface176
{
	// Token: 0x060097CA RID: 38858
	Task Fold(bool mute, CancellationToken token);

	// Token: 0x060097CB RID: 38859
	Task Unfold(bool mute, CancellationToken token);

	// Token: 0x060097CC RID: 38860
	Task Rocking(CancellationToken token);
}
