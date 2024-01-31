using System;
using System.Threading.Tasks;
using JetBrains.Annotations;

// Token: 0x02002E03 RID: 11779
public interface GInterface376
{
	// Token: 0x0600E7D0 RID: 59344
	void HighlightItemViewPosition(GClass2821 itemContext, [CanBeNull] GClass2809 targetItemContext, bool preview);

	// Token: 0x0600E7D1 RID: 59345
	void DisableHighlight();

	// Token: 0x0600E7D2 RID: 59346
	void DragStarted();

	// Token: 0x0600E7D3 RID: 59347
	void DragCancelled();

	// Token: 0x0600E7D4 RID: 59348
	bool CanAccept(GClass2821 itemContext, [CanBeNull] GClass2809 targetItemContext, out GStruct412 operation);

	// Token: 0x0600E7D5 RID: 59349
	bool CanDrag(GClass2809 itemContext);

	// Token: 0x0600E7D6 RID: 59350
	Task AcceptItem(GClass2821 itemContext, [CanBeNull] GClass2809 targetItemContext);
}
