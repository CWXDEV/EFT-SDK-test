using System;
using System.Threading.Tasks;
using EFT.UI.Screens;

// Token: 0x02002D07 RID: 11527
public interface GInterface374<T> : GInterface373<T> where T : struct, Enum
{
	// Token: 0x17002797 RID: 10135
	// (get) Token: 0x0600E286 RID: 57990
	bool Root { get; }

	// Token: 0x17002798 RID: 10136
	// (get) Token: 0x0600E287 RID: 57991
	bool Queued { get; }

	// Token: 0x17002799 RID: 10137
	// (get) Token: 0x0600E288 RID: 57992
	bool KeyScreen { get; }

	// Token: 0x1700279A RID: 10138
	// (set) Token: 0x0600E289 RID: 57993
	bool Disabled { set; }

	// Token: 0x1700279B RID: 10139
	// (get) Token: 0x0600E28A RID: 57994
	GInterface374<T> PreviousScreen { get; }

	// Token: 0x1700279C RID: 10140
	// (get) Token: 0x0600E28B RID: 57995
	GInterface374<T> RootScreen { get; }

	// Token: 0x0600E28C RID: 57996
	void RestoreScreen();

	// Token: 0x0600E28D RID: 57997
	void ShowScreenAsPrevious();

	// Token: 0x0600E28E RID: 57998
	void QueueScreen(EScreenState screenState);

	// Token: 0x0600E28F RID: 57999
	void ShowScreen(EScreenState screenState);

	// Token: 0x0600E290 RID: 58000
	Task<bool> ShowPreviousKeyScreen();

	// Token: 0x0600E291 RID: 58001
	Task<bool> ReturnToRootScreen();

	// Token: 0x0600E292 RID: 58002
	Task<bool> CloseSelf(bool forced);

	// Token: 0x0600E293 RID: 58003
	void CloseScreenForced();
}
